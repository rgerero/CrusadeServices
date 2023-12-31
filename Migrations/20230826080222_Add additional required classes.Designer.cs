﻿// <auto-generated />
using System;
using CrusadeServices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrusadeServices.Migrations
{
    [DbContext(typeof(CrusadeServicesContext))]
    [Migration("20230826080222_Add additional required classes")]
    partial class Addadditionalrequiredclasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CrusadeServices.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_HomeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_OfficeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerTypeID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsBlacklisted")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesPersonID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CrusadeServices.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastMOdified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesPersonId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CrusadeServices.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"), 1L, 1);

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_HomeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_OfficeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_UnitNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_UnitNo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfDelivery")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfJob")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfQuotation")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescCarpet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescGeneral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescMattress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescOthers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescRug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescUpholstery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsBlacklisted")
                        .HasColumnType("int");

                    b.Property<bool>("IsQuotation")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeOfPayment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceNoGST")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PrizeSpecial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesPersonID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technicians")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermsAndCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeArrived")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeCompletion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeOfJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitNo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionID");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("CrusadeServices.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
