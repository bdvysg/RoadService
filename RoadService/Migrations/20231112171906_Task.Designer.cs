﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoadService;

#nullable disable

namespace RoadService.Migrations
{
    [DbContext(typeof(RoadServiceDBContext))]
    [Migration("20231112171906_Task")]
    partial class Task
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("RoadService.Classes.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("RoadService.Classes.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WagePerHour")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("RoadService.Classes.EmployeeTimeTableItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTimeTableItems");
                });

            modelBuilder.Entity("RoadService.Classes.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ActualResourcesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlannedResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActualResourcesId");

                    b.HasIndex("PlannedResourceId");

                    b.ToTable("Resources");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Resource");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("RoadService.Classes.ResourceTimeTableItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("ResourceTimeTableItems");
                });

            modelBuilder.Entity("RoadService.Classes.Stock", b =>
                {
                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ResourceId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("RoadService.Classes.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ActualPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("ActualResourcesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PlannedPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlannedResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isClosed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("RoadService.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoadService.Classes.Material", b =>
                {
                    b.HasBaseType("RoadService.Classes.Resource");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Resources");

                    b.HasDiscriminator().HasValue("Material");
                });

            modelBuilder.Entity("RoadService.Classes.Tool", b =>
                {
                    b.HasBaseType("RoadService.Classes.Resource");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Resources");

                    b.HasDiscriminator().HasValue("Tool");
                });

            modelBuilder.Entity("RoadService.Classes.Transport", b =>
                {
                    b.HasBaseType("RoadService.Classes.Resource");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Resources");

                    b.HasDiscriminator().HasValue("Transport");
                });

            modelBuilder.Entity("RoadService.Classes.Employee", b =>
                {
                    b.HasOne("RoadService.Classes.Task", null)
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("RoadService.Classes.EmployeeTimeTableItem", b =>
                {
                    b.HasOne("RoadService.Classes.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("RoadService.Classes.Resource", b =>
                {
                    b.HasOne("RoadService.Classes.Task", null)
                        .WithMany("ActualResources")
                        .HasForeignKey("ActualResourcesId");

                    b.HasOne("RoadService.Classes.Task", null)
                        .WithMany("PlannedResources")
                        .HasForeignKey("PlannedResourceId");
                });

            modelBuilder.Entity("RoadService.Classes.ResourceTimeTableItem", b =>
                {
                    b.HasOne("RoadService.Classes.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("RoadService.Classes.Stock", b =>
                {
                    b.HasOne("RoadService.Classes.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("RoadService.Classes.User", b =>
                {
                    b.HasOne("RoadService.Classes.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("RoadService.Classes.Task", b =>
                {
                    b.Navigation("ActualResources");

                    b.Navigation("Employees");

                    b.Navigation("PlannedResources");
                });
#pragma warning restore 612, 618
        }
    }
}
