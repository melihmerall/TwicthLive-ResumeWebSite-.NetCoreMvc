﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ResumeContext))]
    [Migration("20221111224950_ad3")]
    partial class ad3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = "24",
                            BirthDate = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2831),
                            Description = "Deneme Açıklama",
                            Email = "tolgaboroğlu@gmail.com",
                            Name = "Tolga",
                            PhoneNumber = "05000000000",
                            Status = true,
                            Surname = "Boroğlu"
                        },
                        new
                        {
                            Id = 2,
                            Age = "23",
                            BirthDate = new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2841),
                            Description = "Emin durukan hakkında sayfası",
                            Email = "emin@gmail.com",
                            Name = "Emin",
                            PhoneNumber = "00000000000",
                            Status = true,
                            Surname = "Durukan"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("GraduationAverage")
                        .HasColumnType("real");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2986),
                            Description = "Güzel bir okuldu",
                            EndDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GraduationAverage = 78f,
                            SchoolName = "DenemeOkulu",
                            StartDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(2992),
                            Description = "Hoş bir Okul",
                            EndDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GraduationAverage = 3f,
                            SchoolName = "Atü",
                            StartDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3014),
                            Description = "Yazılım",
                            EndDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Deneme iş Yeri",
                            StartDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3026),
                            Description = "Yürüyüş gezi",
                            Name = "Dağcılık",
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3039),
                            Description = "Akıcı şekilde konuşuyor",
                            Level = "10",
                            Name = "İngilizce",
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Portfolios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3048),
                            Description = "Web sitesi yapımı",
                            EndDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cv Projesi",
                            StarDate = new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("References");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3065),
                            Description = "iyi bir öğrenci",
                            JobTitle = "Veri Bilimci",
                            NameSurname = "Tolga Boroğlu",
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AboutId")
                        .HasColumnType("int");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("int");

                    b.Property<int>("ReferenceId")
                        .HasColumnType("int");

                    b.Property<int>("SocialId")
                        .HasColumnType("int");

                    b.Property<int>("TalentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.HasIndex("EducationId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("PortfolioId");

                    b.HasIndex("ReferenceId");

                    b.HasIndex("SocialId");

                    b.HasIndex("TalentId");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("Entities.Concrete.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3075),
                            Description = "Twitter Adresim",
                            Name = "Twitter",
                            Status = true,
                            Url = "https://twitter.com/melihmerall"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Talent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Talents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 12, 1, 49, 50, 445, DateTimeKind.Local).AddTicks(3085),
                            Description = "orta derece bilgi sahibi",
                            Name = "C#",
                            Rate = "10",
                            Status = true
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Resume", b =>
                {
                    b.HasOne("Entities.Concrete.About", "About")
                        .WithMany("Resumes")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Education", "Education")
                        .WithMany("Resumes")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Experience", "Experience")
                        .WithMany("Resumes")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Hobby", "Hobby")
                        .WithMany("Resumes")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Language", "Language")
                        .WithMany("Resumes")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Portfolio", "Portfolio")
                        .WithMany("Resumes")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Reference", "Reference")
                        .WithMany("Resumes")
                        .HasForeignKey("ReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Social", "Social")
                        .WithMany("Resumes")
                        .HasForeignKey("SocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Talent", "Talent")
                        .WithMany("Resumes")
                        .HasForeignKey("TalentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");

                    b.Navigation("Education");

                    b.Navigation("Experience");

                    b.Navigation("Hobby");

                    b.Navigation("Language");

                    b.Navigation("Portfolio");

                    b.Navigation("Reference");

                    b.Navigation("Social");

                    b.Navigation("Talent");
                });

            modelBuilder.Entity("Entities.Concrete.About", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Education", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Experience", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Hobby", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Language", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Portfolio", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Reference", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Social", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Entities.Concrete.Talent", b =>
                {
                    b.Navigation("Resumes");
                });
#pragma warning restore 612, 618
        }
    }
}
