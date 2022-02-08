﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mercedes"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarState")
                        .HasColumnType("int")
                        .HasColumnName("State");

                    b.Property<int>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("CityId");

                    b.Property<int>("ColorId")
                        .HasColumnType("int")
                        .HasColumnName("ColorId");

                    b.Property<int>("FindexScore")
                        .HasColumnType("int")
                        .HasColumnName("FindexScore");

                    b.Property<int>("Kilometer")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int")
                        .HasColumnName("ModelId");

                    b.Property<short>("ModelYear")
                        .HasColumnType("smallint")
                        .HasColumnName("ModelYear");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Plate");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarState = 1,
                            CityId = 1,
                            ColorId = 1,
                            FindexScore = 600,
                            Kilometer = 0,
                            ModelId = 2,
                            ModelYear = (short)2018,
                            Plate = "06ABC06"
                        },
                        new
                        {
                            Id = 2,
                            CarState = 1,
                            CityId = 2,
                            ColorId = 2,
                            FindexScore = 600,
                            Kilometer = 0,
                            ModelId = 1,
                            ModelYear = (short)2018,
                            Plate = "34ABC34"
                        });
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 2,
                            Name = "İstanbul"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blue"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FindexScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<short>("Score")
                        .HasColumnType("smallint")
                        .HasColumnName("Score");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("FindexScores", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Fuels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Electric"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("InvoiceNo")
                        .HasColumnType("bigint");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.Property<double>("TotalSum")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentalId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Domain.Entities.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("MaintenanceDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("MaintenanceDate");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReturnDate");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Maintenances", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("BrandId");

                    b.Property<double>("DailyPrice")
                        .HasColumnType("float")
                        .HasColumnName("DailyPrice");

                    b.Property<int>("FuelId")
                        .HasColumnType("int")
                        .HasColumnName("FuelId");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int")
                        .HasColumnName("TransmissionId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Models", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            DailyPrice = 1000.0,
                            FuelId = 1,
                            ImageUrl = "",
                            Name = "418i",
                            TransmissionId = 2
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            DailyPrice = 600.0,
                            FuelId = 1,
                            ImageUrl = "",
                            Name = "CLA 180D",
                            TransmissionId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("CarId");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<int>("RentCityId")
                        .HasColumnType("int")
                        .HasColumnName("RentCityId");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentDate");

                    b.Property<int>("RentedKilometer")
                        .HasColumnType("int")
                        .HasColumnName("RentedKilometer");

                    b.Property<int>("ReturnCityId")
                        .HasColumnType("int")
                        .HasColumnName("ReturnCityId");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReturnDate");

                    b.Property<int?>("ReturnedCityId")
                        .HasColumnType("int")
                        .HasColumnName("ReturnedCityId");

                    b.Property<DateTime?>("ReturnedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReturnedDate");

                    b.Property<int>("ReturnedKilometer")
                        .HasColumnType("int")
                        .HasColumnName("ReturnedKilometer");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentCityId");

                    b.HasIndex("ReturnCityId");

                    b.HasIndex("ReturnedCityId");

                    b.ToTable("Rentals", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Transmissions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manuel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Automatic"
                        });
                });

            modelBuilder.Entity("Domain.Entities.CorporateCustomer", b =>
                {
                    b.HasBaseType("Domain.Entities.Customer");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TaxNumber");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.ToTable("CorporateCustomers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.IndividualCustomer", b =>
                {
                    b.HasBaseType("Domain.Entities.Customer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NationalId");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.ToTable("IndividualCustomers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.HasOne("Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Color");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Domain.Entities.FindexScore", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithOne("FindexScore")
                        .HasForeignKey("Domain.Entities.FindexScore", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Domain.Entities.Maintenance", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.HasOne("Domain.Entities.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Fuel", "Fuel")
                        .WithMany("Models")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Transmission", "Transmission")
                        .WithMany("Models")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Fuel");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.City", "RentCity")
                        .WithMany()
                        .HasForeignKey("RentCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.City", "ReturnCity")
                        .WithMany()
                        .HasForeignKey("ReturnCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.City", "ReturnedCity")
                        .WithMany()
                        .HasForeignKey("ReturnedCityId");

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("RentCity");

                    b.Navigation("ReturnCity");

                    b.Navigation("ReturnedCity");
                });

            modelBuilder.Entity("Domain.Entities.CorporateCustomer", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithOne("CorporateCustomer")
                        .HasForeignKey("Domain.Entities.CorporateCustomer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customer", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.CorporateCustomer", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.IndividualCustomer", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithOne("IndividualCustomer")
                        .HasForeignKey("Domain.Entities.IndividualCustomer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customer", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.IndividualCustomer", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Navigation("CorporateCustomer")
                        .IsRequired();

                    b.Navigation("FindexScore")
                        .IsRequired();

                    b.Navigation("IndividualCustomer")
                        .IsRequired();

                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Domain.Entities.Fuel", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Transmission", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
