﻿// <auto-generated />
using FilegaJobs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilegaJobs.Migrations
{
    [DbContext(typeof(FilegaDbContext))]
    partial class FilegaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilegaJobs.Models.Jobs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Job");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "xxxxxxx",
                            Name = "Accountant",
                            salary = 1000
                        },
                        new
                        {
                            ID = 2,
                            Description = "xxxxxxx",
                            Name = "Sectretary",
                            salary = 100
                        },
                        new
                        {
                            ID = 3,
                            Description = "xxxxxxx",
                            Name = "Manager",
                            salary = 10000
                        });
                });

            modelBuilder.Entity("FilegaJobs.Models.UserProfiles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Abebe",
                            email = "ab@gmail.com",
                            resume = "xxxxxxxxx"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Shimelis",
                            email = "sh@gmail.com",
                            resume = "xxxxxxxxx"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Abigia",
                            email = "abg@gmail.com",
                            resume = "xxxxxxxxx"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Abel",
                            email = "abe@gmail.com",
                            resume = "xxxxxxxxx"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Adonai",
                            email = "ad@gmail.com",
                            resume = "xxxxxxxxx"
                        });
                });

            modelBuilder.Entity("FilegaJobs.Models.applicants", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("jobID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("profileID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("applicant");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            jobID = 1,
                            name = "Abigia",
                            profileID = 3
                        },
                        new
                        {
                            ID = 102,
                            jobID = 2,
                            name = "Abel",
                            profileID = 4
                        },
                        new
                        {
                            ID = 103,
                            jobID = 3,
                            name = "Adonai",
                            profileID = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}