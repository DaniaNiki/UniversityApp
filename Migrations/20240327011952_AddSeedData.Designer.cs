﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityApp.Data;

#nullable disable

namespace UniversityApp.Migrations
{
    [DbContext(typeof(UniversityContext))]
    [Migration("20240327011952_AddSeedData")]
    partial class AddSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("UniversityApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Score")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Name = "Daniil",
                            Score = 8.5
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Name = "Alexey",
                            Score = 9.0999999999999996
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Name = "Michail",
                            Score = 7.2999999999999998
                        },
                        new
                        {
                            Id = 4,
                            Age = 20,
                            Name = "Sophia",
                            Score = 8.6999999999999993
                        },
                        new
                        {
                            Id = 5,
                            Age = 23,
                            Name = "Maria",
                            Score = 6.9000000000000004
                        });
                });
#pragma warning restore 612, 618
        }
    }
}