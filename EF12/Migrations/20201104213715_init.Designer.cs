﻿// <auto-generated />
using System;
using EF12.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF12.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20201104213715_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF12.Models.Department", b =>
                {
                    b.Property<int>("departmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("departmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("studentID")
                        .HasColumnType("int");

                    b.HasKey("departmentID");

                    b.HasIndex("studentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EF12.Models.Student", b =>
                {
                    b.Property<int>("studentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("departmentID")
                        .HasColumnType("int");

                    b.Property<string>("studentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF12.Models.Department", b =>
                {
                    b.HasOne("EF12.Models.Student", null)
                        .WithMany("departments")
                        .HasForeignKey("studentID");
                });
#pragma warning restore 612, 618
        }
    }
}
