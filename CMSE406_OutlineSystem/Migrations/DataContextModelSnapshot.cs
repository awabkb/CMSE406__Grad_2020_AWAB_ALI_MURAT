﻿// <auto-generated />
using System;
using CMSE406_OutlineSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMSE406_OutlineSystem.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.AssessmentType", b =>
                {
                    b.Property<string>("AssessmentCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AssessmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssessmentCode");

                    b.ToTable("AssessmentTypes");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.ClassTime", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseCode1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FinishTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseCode");

                    b.HasIndex("CourseCode1");

                    b.ToTable("ClassTime");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.Course", b =>
                {
                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseLOCloCode")
                        .HasColumnType("int");

                    b.Property<int?>("CourseSemesterDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("CourseWebpage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ects")
                        .HasColumnType("int");

                    b.Property<string>("LabTimeCourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rcode")
                        .HasColumnType("int");

                    b.Property<string>("ReqOrElc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudyProgramProgramCode")
                        .HasColumnType("int");

                    b.HasKey("CourseCode");

                    b.HasIndex("CourseLOCloCode");

                    b.HasIndex("CourseSemesterDetailsId");

                    b.HasIndex("LabTimeCourseCode");

                    b.HasIndex("StudyProgramProgramCode");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.CourseAssessment", b =>
                {
                    b.Property<string>("AssessmentCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AssessmentTypeAssessmentCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<int>("Rcode")
                        .HasColumnType("int");

                    b.Property<string>("YearSemester")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssessmentCode");

                    b.HasIndex("AssessmentTypeAssessmentCode");

                    b.ToTable("CourseAssessments");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.CourseLO", b =>
                {
                    b.Property<int>("CloCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseLearningOutcomes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rcode")
                        .HasColumnType("int");

                    b.Property<string>("YearSemester")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CloCode");

                    b.ToTable("CourseLOs");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.CourseSemesterDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssistantId")
                        .HasColumnType("int");

                    b.Property<int>("AttendanceGrade")
                        .HasColumnType("int");

                    b.Property<string>("CourseAssessmentAssessmentCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseSemesterWeeklyScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("IndicativeBasicReadingList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("MakeupPolicy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingTimePlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MissedLabPolicy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgGradePolicy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rcode")
                        .HasColumnType("int");

                    b.Property<string>("TextBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearSemester")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseAssessmentAssessmentCode");

                    b.HasIndex("CourseSemesterWeeklyScheduleId");

                    b.ToTable("CourseSemesterDetails");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.CourseSemesterWeeklySchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("LabTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LectureTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rcode")
                        .HasColumnType("int");

                    b.Property<int>("WeekNo")
                        .HasColumnType("int");

                    b.Property<string>("YearSemester")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseSemesterWeeklySchedules");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.Prerequisite", b =>
                {
                    b.Property<string>("PreCourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PreCourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreCourseCode");

                    b.HasIndex("CourseCode");

                    b.ToTable("Prerequisite");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.StudentLO", b =>
                {
                    b.Property<string>("SloCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentLearningOutcomes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SloCode");

                    b.ToTable("studentLOs");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.StudyProgram", b =>
                {
                    b.Property<int>("ProgramCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProgramCode");

                    b.ToTable("StudyPrograms");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.ClassTime", b =>
                {
                    b.HasOne("CMSE406_OutlineSystem.Models.Course", null)
                        .WithMany("LectureTime")
                        .HasForeignKey("CourseCode1");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.Course", b =>
                {
                    b.HasOne("CMSE406_OutlineSystem.Models.CourseLO", "CourseLO")
                        .WithMany()
                        .HasForeignKey("CourseLOCloCode");

                    b.HasOne("CMSE406_OutlineSystem.Models.CourseSemesterDetail", "CourseSemesterDetails")
                        .WithMany()
                        .HasForeignKey("CourseSemesterDetailsId");

                    b.HasOne("CMSE406_OutlineSystem.Models.ClassTime", "LabTime")
                        .WithMany()
                        .HasForeignKey("LabTimeCourseCode");

                    b.HasOne("CMSE406_OutlineSystem.Models.StudyProgram", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudyProgramProgramCode");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.CourseAssessment", b =>
                {
                    b.HasOne("CMSE406_OutlineSystem.Models.AssessmentType", "AssessmentType")
                        .WithMany()
                        .HasForeignKey("AssessmentTypeAssessmentCode");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.CourseSemesterDetail", b =>
                {
                    b.HasOne("CMSE406_OutlineSystem.Models.CourseAssessment", "CourseAssessment")
                        .WithMany()
                        .HasForeignKey("CourseAssessmentAssessmentCode");

                    b.HasOne("CMSE406_OutlineSystem.Models.CourseSemesterWeeklySchedule", "CourseSemesterWeeklySchedule")
                        .WithMany()
                        .HasForeignKey("CourseSemesterWeeklyScheduleId");
                });

            modelBuilder.Entity("CMSE406_OutlineSystem.Models.Prerequisite", b =>
                {
                    b.HasOne("CMSE406_OutlineSystem.Models.Course", null)
                        .WithMany("Prerequisites")
                        .HasForeignKey("CourseCode");
                });
#pragma warning restore 612, 618
        }
    }
}
