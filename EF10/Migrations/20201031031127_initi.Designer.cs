﻿// <auto-generated />
using EF10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF10.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20201031031127_initi")]
    partial class initi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF10.Models.Department", b =>
                {
                    b.Property<int>("departmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("departmentFloor")
                        .HasColumnType("int");

                    b.Property<string>("departmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departmentID");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("EF10.Models.Student", b =>
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

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
