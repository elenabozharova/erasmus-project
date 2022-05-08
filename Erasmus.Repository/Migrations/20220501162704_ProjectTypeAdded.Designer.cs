﻿// <auto-generated />
using System;
using Erasmus.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Erasmus.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220501162704_ProjectTypeAdded")]
    partial class ProjectTypeAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Erasmus.Domain.Domain.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ErasmusProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ErasmusProjectId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d73d3e8c-ff96-4805-a1bc-18a2467280cc"),
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5"
                        });
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Coordinator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ErasmusProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ErasmusProjectId");

                    b.HasIndex("FacultyId")
                        .IsUnique()
                        .HasFilter("[FacultyId] IS NOT NULL");

                    b.ToTable("Coordinators");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.ErasmusProjectUniversity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ErasmusProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UniversityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ErasmusProjectId");

                    b.HasIndex("UniversityId");

                    b.ToTable("ErasmusProjectUniversity");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.NonGovProjectOrganizer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("NonGovProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrganizerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NonGovProjectId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("NonGovProjectOrganizer");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Organizer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizer");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.ProjectType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectType");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.ErasmusProject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ErasmusProjects");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.ErasmusUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CoordinatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<Guid?>("OrganizerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ParticipantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique()
                        .HasFilter("[AdminId] IS NOT NULL");

                    b.HasIndex("CoordinatorId")
                        .IsUnique()
                        .HasFilter("[CoordinatorId] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("OrganizerId")
                        .IsUnique()
                        .HasFilter("[OrganizerId] IS NOT NULL");

                    b.HasIndex("ParticipantId")
                        .IsUnique()
                        .HasFilter("[ParticipantId] IS NOT NULL");

                    b.HasIndex("StudentId")
                        .IsUnique()
                        .HasFilter("[StudentId] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d0a7a140-6f22-43b6-af0b-125b071cfc96",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPKTIbYmibKLMwISGQalpOp7S9QjWbspfnLGhZFrwpx52xmuhLdmToN1/3NWSX8PIw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "7e529e7b-c007-4199-b2d5-1cd28f8d84a9",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UniversityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.NonGovProject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProjectTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTypeId");

                    b.ToTable("NonGovProject");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.University", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7",
                            ConcurrencyStamp = "8b5ee835-e6e8-4f38-9631-e1b81f8a25ef",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c76aee55-4ff7-463d-a2ba-ce2c8a06e13b",
                            ConcurrencyStamp = "5351e13c-59c8-4332-bf5c-5b6d567bc18e",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "4eb6f781-cba6-4873-ac70-7539916f1a17",
                            ConcurrencyStamp = "1414de76-ea05-4d49-b445-a06661a993c8",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "12739aa2-fc68-45db-82e8-2d0602e94eb6",
                            ConcurrencyStamp = "b51ab947-3ed7-4c2a-b678-e1653c0a4b74",
                            Name = "Coordinator",
                            NormalizedName = "COORDINATOR"
                        },
                        new
                        {
                            Id = "94a5b35b-ef16-434d-b99c-6ecf3c88b40a",
                            ConcurrencyStamp = "e108f19e-c3da-44a2-bdb1-249138272a56",
                            Name = "Participant",
                            NormalizedName = "PARTICIPANT"
                        },
                        new
                        {
                            Id = "12c4851c-da44-4fa4-bf22-3c92b823582b",
                            ConcurrencyStamp = "3d217d2d-2829-4166-82d0-00a8158fcd62",
                            Name = "Organizer",
                            NormalizedName = "ORGANIZER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                            RoleId = "d5057dbb-cb98-476a-8f85-f27d6e6d7ec7"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Admin", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusProject", "ErasmusProject")
                        .WithMany("Admins")
                        .HasForeignKey("ErasmusProjectId");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Coordinator", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusProject", "ErasmusProject")
                        .WithMany("Coordinators")
                        .HasForeignKey("ErasmusProjectId");

                    b.HasOne("Erasmus.Domain.DomainModels.Faculty", "Faculty")
                        .WithOne("Coordinator")
                        .HasForeignKey("Erasmus.Domain.Domain.Coordinator", "FacultyId");
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.ErasmusProjectUniversity", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusProject", "ErasmusProject")
                        .WithMany("ErasmusProjectUniversities")
                        .HasForeignKey("ErasmusProjectId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("Erasmus.Domain.DomainModels.University", "University")
                        .WithMany("ErasmusProjectUniversities")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.NonGovProjectOrganizer", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.NonGovProject", "NonGovProject")
                        .WithMany("NonGovProjectOrganizers")
                        .HasForeignKey("NonGovProjectId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("Erasmus.Domain.Domain.Organizer", "Organizer")
                        .WithMany("NonGovProjectOrganizers")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.ClientCascade);
                });

            modelBuilder.Entity("Erasmus.Domain.Domain.Student", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.Faculty", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("FacultyId");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.ErasmusUser", b =>
                {
                    b.HasOne("Erasmus.Domain.Domain.Admin", "Admin")
                        .WithOne("BaseRecord")
                        .HasForeignKey("Erasmus.Domain.DomainModels.ErasmusUser", "AdminId");

                    b.HasOne("Erasmus.Domain.Domain.Coordinator", "Coordinator")
                        .WithOne("BaseRecord")
                        .HasForeignKey("Erasmus.Domain.DomainModels.ErasmusUser", "CoordinatorId");

                    b.HasOne("Erasmus.Domain.Domain.Organizer", "Organizer")
                        .WithOne("BaseRecord")
                        .HasForeignKey("Erasmus.Domain.DomainModels.ErasmusUser", "OrganizerId");

                    b.HasOne("Erasmus.Domain.Domain.Participant", "Participant")
                        .WithOne("BaseRecord")
                        .HasForeignKey("Erasmus.Domain.DomainModels.ErasmusUser", "ParticipantId");

                    b.HasOne("Erasmus.Domain.Domain.Student", "Student")
                        .WithOne("BaseRecord")
                        .HasForeignKey("Erasmus.Domain.DomainModels.ErasmusUser", "StudentId");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.Faculty", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityId");
                });

            modelBuilder.Entity("Erasmus.Domain.DomainModels.NonGovProject", b =>
                {
                    b.HasOne("Erasmus.Domain.Domain.ProjectType", "ProjectType")
                        .WithMany("NonGovProjects")
                        .HasForeignKey("ProjectTypeId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Erasmus.Domain.DomainModels.ErasmusUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}