﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SwagMyRide.Data.DataContext;
using System;

namespace SwagMyRide.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180513235509_UpdatingAllModels")]
    partial class UpdatingAllModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SwagMyRide.Data.Models.GlobalData.City", b =>
                {
                    b.Property<long>("CitiyId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.HasKey("CitiyId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.GlobalData.Country", b =>
                {
                    b.Property<long>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.GlobalData.State", b =>
                {
                    b.Property<long>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Country");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.HasKey("StateId");

                    b.HasIndex("Country");

                    b.ToTable("State");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.UserData.UserProfile", b =>
                {
                    b.Property<long>("UserProfileId")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("Age");

                    b.Property<DateTime>("Brithday");

                    b.Property<long>("Country");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(2147483647);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UserProfileId");

                    b.HasIndex("Country");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue", b =>
                {
                    b.Property<long>("BodyWorkId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Weight");

                    b.HasKey("BodyWorkId");

                    b.HasIndex("Brand");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("BodyWorkCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", b =>
                {
                    b.Property<long>("BrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<short>("VechileTypeId");

                    b.HasKey("BrandId");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("BrandCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.BreakCatalogue", b =>
                {
                    b.Property<long>("BreakId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Pressure");

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Weight");

                    b.HasKey("BreakId");

                    b.HasIndex("Brand");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("BreakCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.CombustibleType", b =>
                {
                    b.Property<long>("CombustibleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.HasKey("CombustibleId");

                    b.ToTable("CombustibleType");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.ElectricSystemCatalogue", b =>
                {
                    b.Property<long>("ElecticSystemId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Volts");

                    b.HasKey("ElecticSystemId");

                    b.HasIndex("Brand");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("ElectricSystemCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.MotorCatalogue", b =>
                {
                    b.Property<long>("MotorId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<long>("CombustibleId");

                    b.Property<short>("Cylinders");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<short>("HorsePower");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Weight");

                    b.HasKey("MotorId");

                    b.HasIndex("Brand");

                    b.HasIndex("CombustibleId");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("MotorCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.SuspensionCatalogue", b =>
                {
                    b.Property<long>("SuspensionId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Price");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Weight");

                    b.HasKey("SuspensionId");

                    b.HasIndex("Brand");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("SuspensionCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.TiresCatalogue", b =>
                {
                    b.Property<long>("TiresId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Price");

                    b.Property<short>("Size");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Weight");

                    b.HasKey("TiresId");

                    b.HasIndex("Brand");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("TiresCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.WheelCatalogue", b =>
                {
                    b.Property<long>("WheelId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Brand");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("Manufactured");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.Property<double>("Price");

                    b.Property<short>("Size");

                    b.Property<int>("Stock");

                    b.Property<short>("VechileTypeId");

                    b.Property<double>("Weight");

                    b.HasKey("WheelId");

                    b.HasIndex("Brand");

                    b.HasIndex("Manufactured");

                    b.HasIndex("VechileTypeId");

                    b.ToTable("WheelCatalogue");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleData.VehicleBrand", b =>
                {
                    b.Property<long>("VehicleBrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName")
                        .HasMaxLength(100);

                    b.Property<short>("VehicleTypeId");

                    b.HasKey("VehicleBrandId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleData.VehicleModel", b =>
                {
                    b.Property<long>("VehicleModelId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("VehicleBrandlId");

                    b.Property<string>("VehicleNameModel")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<short>("VehicleTypeId");

                    b.Property<short>("VehicleYearModel")
                        .HasMaxLength(4);

                    b.HasKey("VehicleModelId");

                    b.HasIndex("VehicleBrandlId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleData.VehicleType", b =>
                {
                    b.Property<short>("VehicleTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VehicleTypeName")
                        .IsRequired()
                        .HasMaxLength(90);

                    b.HasKey("VehicleTypeId");

                    b.ToTable("VehicleType");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.Vehicles.Vehicle", b =>
                {
                    b.Property<long>("VehicleId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("BodyWorkCatalogueId");

                    b.Property<long?>("BodyWorkId");

                    b.Property<long>("BreakCatalogueId");

                    b.Property<long?>("BreakId");

                    b.Property<long>("CombustibleId");

                    b.Property<long>("ElecticSystemId");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<long>("MotorId");

                    b.Property<long>("SuspensionId");

                    b.Property<long>("TiresId");

                    b.Property<long>("UserProfileId");

                    b.Property<short>("VechileTypeId");

                    b.Property<long>("VehicleBrandId");

                    b.Property<long>("VehicleModelId");

                    b.Property<long>("VehicleYear");

                    b.Property<long>("WheelId");

                    b.HasKey("VehicleId");

                    b.HasIndex("BodyWorkId");

                    b.HasIndex("BreakId");

                    b.HasIndex("CombustibleId");

                    b.HasIndex("ElecticSystemId");

                    b.HasIndex("MotorId");

                    b.HasIndex("SuspensionId");

                    b.HasIndex("TiresId");

                    b.HasIndex("UserProfileId");

                    b.HasIndex("VechileTypeId");

                    b.HasIndex("VehicleBrandId");

                    b.HasIndex("VehicleModelId");

                    b.HasIndex("WheelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.GlobalData.State", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Country")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.UserData.UserProfile", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Country")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.BreakCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.ElectricSystemCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.MotorCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.CombustibleType", "CombustibleTypeId")
                        .WithMany()
                        .HasForeignKey("CombustibleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.SuspensionCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.TiresCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleComponents.WheelCatalogue", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue", "BrandId")
                        .WithMany()
                        .HasForeignKey("Brand")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.GlobalData.Country", "CountryId")
                        .WithMany()
                        .HasForeignKey("Manufactured")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleData.VehicleBrand", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.VehicleData.VehicleModel", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleBrand", "BrandVehicle")
                        .WithMany()
                        .HasForeignKey("VehicleBrandlId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwagMyRide.Data.Models.Vehicles.Vehicle", b =>
                {
                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue", "BodyWorkCatalogue")
                        .WithMany()
                        .HasForeignKey("BodyWorkId");

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.BreakCatalogue", "BreakCatalogue")
                        .WithMany()
                        .HasForeignKey("BreakId");

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.CombustibleType", "CombustibleType")
                        .WithMany()
                        .HasForeignKey("CombustibleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.ElectricSystemCatalogue", "ElectricSystemCatalogue")
                        .WithMany()
                        .HasForeignKey("ElecticSystemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.MotorCatalogue", "MotorCatalogue")
                        .WithMany()
                        .HasForeignKey("MotorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.SuspensionCatalogue", "SuspensionCatalogue")
                        .WithMany()
                        .HasForeignKey("SuspensionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.TiresCatalogue", "TiresCatalogue")
                        .WithMany()
                        .HasForeignKey("TiresId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.UserData.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VechileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleBrand", "VehicleBrand")
                        .WithMany()
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleData.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwagMyRide.Data.Models.VehicleComponents.WheelCatalogue", "WheelCatalogue")
                        .WithMany()
                        .HasForeignKey("WheelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
