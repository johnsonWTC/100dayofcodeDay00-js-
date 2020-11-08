﻿// <auto-generated />
using System;
using EF15.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF15.Migrations
{
    [DbContext(typeof(postContext))]
    [Migration("20201108164951_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF15.Models.Comment", b =>
                {
                    b.Property<int>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("postID")
                        .HasColumnType("int");

                    b.HasKey("commentID");

                    b.HasIndex("postID");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("EF15.Models.Post", b =>
                {
                    b.Property<int>("postID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("postContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("postID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("EF15.Models.Comment", b =>
                {
                    b.HasOne("EF15.Models.Post", "post")
                        .WithMany("Comments")
                        .HasForeignKey("postID");
                });
#pragma warning restore 612, 618
        }
    }
}
