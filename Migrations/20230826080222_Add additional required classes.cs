using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrusadeServices.Migrations
{
    public partial class Addadditionalrequiredclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeID = table.Column<int>(type: "int", nullable: false),
                    SalesPersonID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_HomeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_OfficeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBlacklisted = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DateOfJob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceNoGST = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModeOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technicians = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OtherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_HomeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_OfficeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesPersonID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ContractDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeOfJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermsAndCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_UnitNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsQuotation = table.Column<bool>(type: "bit", nullable: false),
                    PrizeSpecial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B_UnitNo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescRug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescCarpet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescMattress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescUpholstery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescGeneral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescOthers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfDelivery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfQuotation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeArrived = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeCompletion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerTypeID = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBlacklisted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
