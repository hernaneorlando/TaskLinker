﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskLinker.Persistence;

namespace TaskLinker.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201230202205_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TaskLinker.Model.CommandItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CommandLine")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CommandLine")
                        .IsUnique();

                    b.HasIndex("GroupId");

                    b.ToTable("CommandItems");
                });

            modelBuilder.Entity("TaskLinker.Model.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("TaskLinker.Model.CommandItem", b =>
                {
                    b.HasOne("TaskLinker.Model.Group", null)
                        .WithMany("CommandItems")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("TaskLinker.Model.Group", b =>
                {
                    b.Navigation("CommandItems");
                });
#pragma warning restore 612, 618
        }
    }
}