﻿// <auto-generated />
using ConsoleAppEF.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleAppEF.Migrations
{
    [DbContext(typeof(Academy))]
    [Migration("20220623205408_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsoleAppEF.DAL.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "C2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "C3"
                        });
                });

            modelBuilder.Entity("ConsoleAppEF.DAL.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Name = "S1",
                            Score = 91
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Name = "S2",
                            Score = 99
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1,
                            Name = "S3",
                            Score = 90
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            Name = "S4",
                            Score = 90
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 2,
                            Name = "S5",
                            Score = 100
                        });
                });

            modelBuilder.Entity("ConsoleAppEF.DAL.Student", b =>
                {
                    b.HasOne("ConsoleAppEF.DAL.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ConsoleAppEF.DAL.Course", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
