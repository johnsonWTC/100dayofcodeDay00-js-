﻿// <auto-generated />
using System;
using EF10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF10.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("studentID")
                        .HasColumnType("int");

                    b.HasKey("departmentID");

                    b.HasIndex("studentID");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("EF10.Models.Student", b =>
                {
                    b.Property<int>("studentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("studentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studentID");

                    b.ToTable("students");
                });

            modelBuilder.Entity("EF10.Models.Department", b =>
                {
                    b.HasOne("EF10.Models.Student", null)
                        .WithMany("departments")
                        .HasForeignKey("studentID");
                });
#pragma warning restore 612, 618
        }
    }
}
