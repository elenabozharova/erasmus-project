using Erasmus.Domain.Domain;
using Erasmus.Repository.Interface;
using Erasmus.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Erasmus.Service.Implementation
{
    public class ParticipantApplicationService : IParticipantApplicationService
    {
        private readonly IParticipantApplicationRepository _repository;
        private readonly IEmailService _emailService;
        private readonly IOrganizerService _organizerService;
        public ParticipantApplicationService(IParticipantApplicationRepository repository,
            IEmailService emailService,
            IOrganizerService organizerService)
        {
            _repository = repository;
            _emailService = emailService;
            _organizerService = organizerService;
        }

        public ParticipantApplication Approve(ParticipantApplication application, string approveFeedback = "")
        {
            application.ReviewStatus = ApplicationStatus.Approved;
            _repository.Update(application);
            // send mail to participant
            _organizerService.SendMailForApprovedApplicationAsync(application, approveFeedback);
            return application;
        }

        public void Delete(ParticipantApplication application)
        {
            _repository.Delete(application);
        }

        public ParticipantApplication Get(Guid id)
        {
            return _repository.GetApplication(id);
        }

        public List<ParticipantApplication> GetAllForProject(Guid projectId)
        {
            return _repository.GetAllForProject(projectId);
        }

        public ParticipantApplication GetForParticipantAndProject(string participantId, Guid projectId)
        {
            return _repository.GetForParticipantAndProject(participantId, projectId);
        }

        public void Insert(ParticipantApplication application)
        {
            _repository.Insert(application);
        }

        public ParticipantApplication Reject(ParticipantApplication application, string rejectFeedback = "")
        {
            application.ReviewStatus = ApplicationStatus.Rejected;
            _repository.Update(application);
            // send mail to participant
            _organizerService.SendMailForRejectedApplicationAsync(application, rejectFeedback);
            return application;
        }

        public void Update(ParticipantApplication application)
        {
            _repository.Update(application);
        }
    }
}
