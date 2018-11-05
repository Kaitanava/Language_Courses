﻿// <auto-generated />
using System;
using Language_Courses.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Language_Courses.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Language_Courses.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<string>("DescriptionOfCourse");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("Hourse");

                    b.Property<string>("IntensityOfTraining");

                    b.Property<string>("NameOfCourse");

                    b.Property<int>("NumberOfPlaces");

                    b.Property<string>("TrainingProgram");

                    b.HasKey("CourseID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Language_Courses.Models.Education", b =>
                {
                    b.Property<int>("EducationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Stage");

                    b.HasKey("EducationID");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("Language_Courses.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EducationID");

                    b.Property<string>("NameEmployee");

                    b.Property<string>("Patronymic");

                    b.Property<string>("Position");

                    b.Property<string>("Surname");

                    b.HasKey("EmployeeID");

                    b.HasIndex("EducationID");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("Language_Courses.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId");

                    b.Property<int?>("ListenerId");

                    b.HasKey("GroupId");

                    b.HasIndex("CourseId");

                    b.HasIndex("ListenerId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Language_Courses.Models.Listener", b =>
                {
                    b.Property<int>("ListenerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int?>("EducationID");

                    b.Property<string>("NameListener");

                    b.Property<string>("PassportData");

                    b.Property<string>("Phone");

                    b.Property<string>("Surname");

                    b.HasKey("ListenerID");

                    b.ToTable("Listeners");
                });

            modelBuilder.Entity("Language_Courses.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<int?>("CourseId");

                    b.Property<int?>("ListenerId");

                    b.Property<DateTime>("PaymentDate");

                    b.HasKey("PaymentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("ListenerId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Language_Courses.Models.Course", b =>
                {
                    b.HasOne("Language_Courses.Models.Employee", "Employee")
                        .WithMany("Courses")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Language_Courses.Models.Employee", b =>
                {
                    b.HasOne("Language_Courses.Models.Education", "Education")
                        .WithMany("Employes")
                        .HasForeignKey("EducationID");
                });

            modelBuilder.Entity("Language_Courses.Models.Group", b =>
                {
                    b.HasOne("Language_Courses.Models.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseId");

                    b.HasOne("Language_Courses.Models.Listener", "Listener")
                        .WithMany("Groups")
                        .HasForeignKey("ListenerId");
                });

            modelBuilder.Entity("Language_Courses.Models.Payment", b =>
                {
                    b.HasOne("Language_Courses.Models.Course", "Course")
                        .WithMany("Payments")
                        .HasForeignKey("CourseId");

                    b.HasOne("Language_Courses.Models.Listener", "Listener")
                        .WithMany("Payments")
                        .HasForeignKey("ListenerId");
                });
#pragma warning restore 612, 618
        }
    }
}
