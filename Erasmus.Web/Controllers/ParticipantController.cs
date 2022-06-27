﻿using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using Erasmus.Domain.Domain;
using Erasmus.Domain.DTO;
using Erasmus.Repository.Interface;
using Erasmus.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf.Parsing;
using System;
using System.IO;
using System.Security.Claims;

namespace Erasmus.Web.Controllers
{
    public class ParticipantController : Controller
    {
        private readonly INonGovProjectService _projectService;
        private readonly IUploadedFileRepository _uploadedFileRepository;
        private readonly IUserRepository _userRepository;
        private readonly IParticipantApplicationService _participantApplicationService;
        private readonly IParticipantService _participantService;
        private readonly IMapper _mapper;
        private readonly INotyfService _notyfService;
        private readonly IParticipantRepository _participantRepository;
        private readonly IRepository<ProfilePhoto> _profilePhotoRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ParticipantController(INonGovProjectService projectService, IUploadedFileRepository uploadedFileRepository, IUserRepository userRepository,
            IParticipantService participantService, INotyfService notyfService, IParticipantApplicationService participantApplicationService,
            IParticipantRepository participantRepository, IMapper mapper, IRepository<ProfilePhoto> profilePhotoRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _notyfService = notyfService;
            _projectService = projectService;
            _uploadedFileRepository = uploadedFileRepository;
            _userRepository = userRepository;
            _participantApplicationService = participantApplicationService;
            _participantService = participantService;
            _participantRepository = participantRepository;
            _profilePhotoRepository = profilePhotoRepository;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            GemBox.Document.ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            GemBox.Pdf.ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }

        //TODO:
        //Edit profile page

        public IActionResult Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userRepository.Get(userId);
            var participant = _participantRepository.Get(userId);
            var model = _mapper.Map<ParticipantProfileDto>(user);
            _mapper.Map(participant, model);
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var participant = _participantService.Get(id);
            var model = new ParticipantProfileDto();
            var user = _participantService.GetUser(id);
            _mapper.Map(participant, model);
            _mapper.Map(user, model);
            return View(model);
        }
        public IActionResult EditProfile(ParticipantProfileDto model)
        {
            if (ModelState.IsValid)
            {
                _participantService.Edit(model);
                _notyfService.Success("Profile Saved!");
                return RedirectToAction("Profile");
            }
            else
            {
                _notyfService.Error("Error updating profile. Please try again later!");
                return View("Profile", model);
            }
        }
        [HttpGet]
        public IActionResult EditProfilePhoto(string participantId)
        {
            var user = _participantRepository.GetParticipantFromBase(participantId);
            var profilePhoto = _profilePhotoRepository.Get(user.ProfilePhotoId);
            var model = new EditProfilePictureDto
            {
                UserId = participantId,
                ProfilePhotoPath = user.Photo != null ? user.Photo.PathOnDisk : ""
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UploadPhoto(EditProfilePictureDto model)
        {
            string uniqueFileName = null;

            if (model.ProfilePhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = model.UserId + "_" + model.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfilePhoto.CopyTo(fileStream);
                }

                var organizer = _participantRepository.Get(model.UserId);
                var user = _participantRepository.GetParticipantFromBase(model.UserId);
                var photo = new ProfilePhoto
                {
                    PathOnDisk = uniqueFileName,
                    User = user
                };
                _profilePhotoRepository.Insert(photo);

                user.Photo = photo;
                user.ProfilePhotoId = photo.Id;
                _userRepository.Update(user);
                _notyfService.Success("Profile Picture updated successfully");
                return RedirectToAction("Profile");
            }
            return RedirectToAction("Profile");
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult UploadFiles(Guid eventId)
        {
            var project = _projectService.Get(eventId);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var application = _participantApplicationService.GetForParticipantAndProject(userId, eventId);
            var uploadedCv = _uploadedFileRepository.UploadedCvForEvent(userId, eventId);
            var uploadedMotivation = _uploadedFileRepository.UploadedMotivationalLetterForEvent(userId, eventId);
            if (project != null)
            {
                var model = new ApplyToEventDto
                {
                    ProjectId = project.Id,
                    Project = project,
                    UploadedCV = uploadedCv,
                    UploadedMotivation = uploadedMotivation,
                    ParticipantId = userId
                };

                if(application != null)
                {
                    model.ReviewStatus = application.ReviewStatus;
                }
                else
                {
                    model.ReviewStatus = ApplicationStatus.NotCompleted;
                }
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "NonGovProjects");
            }
        }

        [HttpPost]
        public IActionResult UploadFiles(ApplyToEventDto model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
            var project = _projectService.Get(model.ProjectId);
            model.Project = project;
            var participant = _participantService.Get(userId);
            try
            {
                if (model.CV != null)
                {
                    string uploadFolder = $"{Directory.GetCurrentDirectory()}\\ProjectFiles\\";
                    string fileToUpload = uploadFolder + userId + "_" + model.ProjectId + "_" + model.CV.FileName;

                    using (FileStream fs = System.IO.File.Create(fileToUpload))
                    {
                        model.CV.CopyTo(fs);
                        fs.Flush();
                    }
                    var userToFile = new UploadedFile
                    {
                        UserId = userId,
                        FileName = model.CV.FileName,
                        ProjectId = model.ProjectId,
                        User = participant,
                        PathOnDisk = fileToUpload,
                        FileType = FileType.CV
                    };
                    _uploadedFileRepository.Insert(userToFile);
                }

                if (model.MotivationLetter != null)
                {
                    string uploadFolder = $"{Directory.GetCurrentDirectory()}\\ProjectFiles\\";
                    string fileToUpload = uploadFolder + userId + "_" + model.ProjectId + "_" + model.MotivationLetter.FileName;

                    using (FileStream fs = System.IO.File.Create(fileToUpload))
                    {
                        model.MotivationLetter.CopyTo(fs);
                        fs.Flush();
                    }
                    var userToFile = new UploadedFile
                    {
                        UserId = userId,
                        FileName = model.MotivationLetter.FileName,
                        ProjectId = model.ProjectId,
                        User = participant,
                        PathOnDisk = fileToUpload,
                        FileType = FileType.MotivationLetter
                    };
                    _uploadedFileRepository.Insert(userToFile);
                }
                if(model.CV != null || model.UploadedCV != null)
                     _notyfService.Success("Files uploaded!");
                return RedirectToAction("UploadFiles", "Participant", new { eventId = model.ProjectId });

            }
            catch
            {
                _notyfService.Error("Error uploading file. Try again later");
            }


            return View(model);
        }

        public IActionResult ShowUploadedFile(Guid id)
        {
            var file = _uploadedFileRepository.Get(id);
            try
            {
                // check file type
                if (file.FileName.EndsWith(".docx"))
                {
                    var readStream = new FileStream(file.PathOnDisk, FileMode.Open, FileAccess.ReadWrite);
                    WordDocument loadedDocument = new WordDocument(readStream, FormatType.Docx);
                    
                    FileStream outputStream = new FileStream("Name_Surname_CV", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                    loadedDocument.Save(outputStream, FormatType.Docx);
                    var memoryStream = new MemoryStream();
                    loadedDocument.Save(memoryStream, FormatType.Docx);
                    return File(memoryStream.ToArray(), "application/docx", file.FileName);
                }
                else if (file.FileName.EndsWith(".pdf"))
                {
                    var readStream = new FileStream(file.PathOnDisk, FileMode.Open, FileAccess.ReadWrite);
                    PdfLoadedDocument loadedDocument = new PdfLoadedDocument(readStream);

                    FileStream outputStream = new FileStream("Name_Surname_CV", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                    loadedDocument.Save(outputStream);
                    var memoryStream = new MemoryStream();
                    loadedDocument.Save(memoryStream);
                    return File(memoryStream.ToArray(), "application/pdf", file.FileName);
                }
                else
                {
                    _notyfService.Error("Error uploading the document, please upload word or pdf format");
                    return View();
                }
            }
            catch (Exception ex)
            {
                switch (ex.GetType().ToString())
                {
                    case "FileNotFoundException":
                        _notyfService.Error("The file is not found!");
                        break;
                }
                return RedirectToAction("UploadFiles","Participant", new { eventId = file.ProjectId} );
            }
        }

        public IActionResult DownloadCVTemplate(Guid id)
        {
            try
            {
                var cvTemplatePath = Directory.GetCurrentDirectory() + "//FileTemplates/CV Template.docx";
                var readStream = new FileStream(cvTemplatePath, FileMode.Open, FileAccess.ReadWrite);
                WordDocument document = new WordDocument(readStream, FormatType.Automatic);
                FileStream outputStream = new FileStream("Name_Surname_CV", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                document.Save(outputStream, FormatType.Docx);
                var memoryStream = new MemoryStream();
                document.Save(memoryStream, FormatType.Docx);
                return File(memoryStream.ToArray(),"application/docx", "Name_Surname_CV.docx");
            }
            catch (Exception e)
            {
                return RedirectToAction("Details", "NonGovProjects", new { eventid = id });
            }
        }

        public IActionResult DeleteUploadedFile(Guid id)
        {
            var file = _uploadedFileRepository.Get(id);
            // delete the record
            _uploadedFileRepository.Delete(id);
            // delete the actual file
            var participantId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var application = _participantApplicationService.GetForParticipantAndProject(participantId, file.ProjectId);
            if(application != null)
                application.ReviewStatus = ApplicationStatus.NotCompleted;
            _participantApplicationService.Update(application);

            if(!IsFileLocked(file.PathOnDisk))
                System.IO.File.Delete(file.PathOnDisk);
            _notyfService.Success("File deleted");
            return RedirectToAction("UploadFiles", "Participant", new { eventId = file.ProjectId});
        }

       

        public IActionResult Apply(ApplyToEventDto model)
        {
            // create application in db
            _participantService.Apply(model.ParticipantId, model.ProjectId);
            _notyfService.Success("Your application for the event is successful!");
            return RedirectToAction("UploadFiles", new { eventId = model.ProjectId});
        }

        protected virtual bool IsFileLocked(string path)
        {
            try
            {
                using (FileStream stream = System.IO.File.Open(path, FileMode.Open))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
    }
}
