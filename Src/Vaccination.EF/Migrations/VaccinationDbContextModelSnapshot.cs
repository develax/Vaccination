﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Vaccination.EF;

namespace Vaccination.EF.Migrations
{
    [DbContext(typeof(VaccinationDbContext))]
    partial class VaccinationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Vaccination.Domain.Entities.Inoculation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("HasConsent")
                        .HasColumnType("boolean");

                    b.Property<int>("IntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("VaccineId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IntId")
                        .IsUnique();

                    b.HasIndex("PatientId");

                    b.HasIndex("VaccineId");

                    b.ToTable("Inoculations");
                });

            modelBuilder.Entity("Vaccination.Domain.Entities.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InsuranceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.Property<int>("IntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedFirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedFullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedPatronymic")
                        .HasColumnType("text");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceNumber")
                        .IsUnique();

                    b.HasIndex("IntId")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Vaccination.Domain.Entities.Vaccine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("IntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IntId")
                        .IsUnique();

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("Vaccination.Domain.Entities.Inoculation", b =>
                {
                    b.HasOne("Vaccination.Domain.Entities.Patient", null)
                        .WithMany("Inoculations")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vaccination.Domain.Entities.Vaccine", "Vaccine")
                        .WithMany()
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
