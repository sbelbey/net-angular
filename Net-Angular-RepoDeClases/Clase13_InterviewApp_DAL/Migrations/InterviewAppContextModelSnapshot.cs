﻿// <auto-generated />
using System;
using Clase13_InterviewApp_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clase13_InterviewApp_DAL.Migrations
{
    [DbContext(typeof(InterviewAppContext))]
    partial class InterviewAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Ansewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Ansewers");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Interview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IntervieweeId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IntervieweeId");

                    b.ToTable("Intreviews");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Interviewee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interviewees");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Interviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interviewers");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("InterviewInterviewer", b =>
                {
                    b.Property<int>("InterviewersId")
                        .HasColumnType("int");

                    b.Property<int>("InterviewsId")
                        .HasColumnType("int");

                    b.HasKey("InterviewersId", "InterviewsId");

                    b.HasIndex("InterviewsId");

                    b.ToTable("InterviewInterviewer");
                });

            modelBuilder.Entity("InterviewQuestion", b =>
                {
                    b.Property<int>("IntreviewsId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionsId")
                        .HasColumnType("int");

                    b.HasKey("IntreviewsId", "QuestionsId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("InterviewQuestion");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Ansewer", b =>
                {
                    b.HasOne("Clase13_InterviewApp_DAL.Models.Question", null)
                        .WithMany("Ansewers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Interview", b =>
                {
                    b.HasOne("Clase13_InterviewApp_DAL.Models.Interviewee", "Interviewee")
                        .WithMany("Interviews")
                        .HasForeignKey("IntervieweeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interviewee");
                });

            modelBuilder.Entity("InterviewInterviewer", b =>
                {
                    b.HasOne("Clase13_InterviewApp_DAL.Models.Interviewer", null)
                        .WithMany()
                        .HasForeignKey("InterviewersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clase13_InterviewApp_DAL.Models.Interview", null)
                        .WithMany()
                        .HasForeignKey("InterviewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterviewQuestion", b =>
                {
                    b.HasOne("Clase13_InterviewApp_DAL.Models.Interview", null)
                        .WithMany()
                        .HasForeignKey("IntreviewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clase13_InterviewApp_DAL.Models.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Interviewee", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("Clase13_InterviewApp_DAL.Models.Question", b =>
                {
                    b.Navigation("Ansewers");
                });
#pragma warning restore 612, 618
        }
    }
}
