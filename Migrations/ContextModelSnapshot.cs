﻿// <auto-generated />
using System;
using ExaminationSystemProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExaminationSystemProject.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExaminationSystemProject.Models.Answer", b =>
                {
                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<string>("ans1txt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ans2txt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ans3txt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ans4txt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("MaxDegree")
                        .HasColumnType("int");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("InstructorID");

                    b.HasIndex("StudentID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.ExamQuestions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("QuestID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ExamID");

                    b.HasIndex("QuestID");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Questionpool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Correctanswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("Questiontxt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseId");

                    b.ToTable("Questionpools");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Student_Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("StudentDegree")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExamID");

                    b.HasIndex("StudentID");

                    b.ToTable("student_Exams");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.StudentCourse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("studentCourses");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Answer", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Questionpool", "Questionpool")
                        .WithMany()
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questionpool");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Course", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystemProject.Models.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentID");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Exam", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystemProject.Models.Instructor", "Instructor")
                        .WithMany("Exams")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.ExamQuestions", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Exam", "Exam")
                        .WithMany("ExamQuestions")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystemProject.Models.Questionpool", "Questionpool")
                        .WithMany()
                        .HasForeignKey("QuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Questionpool");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Questionpool", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Course", "course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Student_Exam", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystemProject.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.StudentCourse", b =>
                {
                    b.HasOne("ExaminationSystemProject.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExaminationSystemProject.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Exam", b =>
                {
                    b.Navigation("ExamQuestions");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Instructor", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Exams");
                });

            modelBuilder.Entity("ExaminationSystemProject.Models.Student", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
