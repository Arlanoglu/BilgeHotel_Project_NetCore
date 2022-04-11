using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aboutus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Paragraph2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aboutus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesShifts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShiftID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesShifts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExtraServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraServices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdCardFrontSideImage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IdCardBackSideImage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomePages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Paragraph1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Paragraph2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Paragraph5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HotelServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomFacilities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFacilities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    NumberOfBed = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ServicePacks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PackPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePacks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmtpHost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SmtpPort = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    SmtpEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SmtpPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AboutusID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pictures_Aboutus_AboutusID",
                        column: x => x.AboutusID,
                        principalTable: "Aboutus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSlides",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HomePageID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSlides", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HomePageSlides_HomePages_HomePageID",
                        column: x => x.HomePageID,
                        principalTable: "HomePages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacilitiesOfRooms",
                columns: table => new
                {
                    RoomTypeID = table.Column<int>(type: "int", nullable: false),
                    RoomFacilityID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitiesOfRooms", x => new { x.RoomFacilityID, x.RoomTypeID });
                    table.ForeignKey(
                        name: "FK_FacilitiesOfRooms_RoomFacilities_RoomFacilityID",
                        column: x => x.RoomFacilityID,
                        principalTable: "RoomFacilities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilitiesOfRooms_RoomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomPictures",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RoomTypeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPictures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoomPictures_RoomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    RoomStatus = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RoomTypeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StartDateOfWork = table.Column<DateTime>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonthlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OvertimePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LeavingWorkDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReasonForLeaving = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmployeeStatus = table.Column<int>(type: "int", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "Shifts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionReservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "date", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "date", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payment = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false),
                    ReservationType = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    RoomTypeID = table.Column<int>(type: "int", nullable: true),
                    ServicePackID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionReservations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReceptionReservations_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceptionReservations_RoomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceptionReservations_ServicePacks_ServicePackID",
                        column: x => x.ServicePackID,
                        principalTable: "ServicePacks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "date", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "date", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CheckInTime = table.Column<TimeSpan>(type: "time", nullable: false, defaultValue: new TimeSpan(0, 14, 0, 0, 0)),
                    CheckOutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    RegistrationType = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    RegistrationStatus = table.Column<int>(type: "int", nullable: false),
                    ReservationID = table.Column<int>(type: "int", nullable: true),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    ServicePackID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Registrations_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_ServicePacks_ServicePackID",
                        column: x => x.ServicePackID,
                        principalTable: "ServicePacks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatusesOfRooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    StatusEndDate = table.Column<DateTime>(type: "date", nullable: false),
                    RoomStatus = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusesOfRooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StatusesOfRooms_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebReservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "date", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "date", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Payment = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ReservationStatus = table.Column<int>(type: "int", nullable: false),
                    ReservationType = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    RoomTypeID = table.Column<int>(type: "int", nullable: true),
                    ServicePackID = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebReservations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WebReservations_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WebReservations_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WebReservations_RoomTypes_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WebReservations_ServicePacks_ServicePackID",
                        column: x => x.ServicePackID,
                        principalTable: "ServicePacks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeenPaid = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Month = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Salaries_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkSchedules",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    TotalWorkTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimesWorked = table.Column<TimeSpan>(type: "time", nullable: false),
                    HaveOverTime = table.Column<bool>(type: "bit", nullable: false),
                    OverTimeHour = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkStatus = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShiftName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ShiftEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSchedules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkSchedules_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestRegistration",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(type: "int", nullable: false),
                    GuestID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestRegistration", x => new { x.RegistrationID, x.GuestID });
                    table.ForeignKey(
                        name: "FK_GuestRegistration_Guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestRegistration_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeDate = table.Column<DateTime>(type: "date", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegistrationID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Incomes_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UseOfExtraServices",
                columns: table => new
                {
                    ExtraServiceID = table.Column<int>(type: "int", nullable: false),
                    RegistrationID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseOfExtraServices", x => new { x.ExtraServiceID, x.RegistrationID });
                    table.ForeignKey(
                        name: "FK_UseOfExtraServices_ExtraServices_ExtraServiceID",
                        column: x => x.ExtraServiceID,
                        principalTable: "ExtraServices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UseOfExtraServices_Registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "Registrations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aboutus",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Paragraph1", "Paragraph2", "Paragraph3", "Paragraph4", "Paragraph5", "PictureUrl", "Title" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, "Kemer’in tarihi ve kültürel merkezlerinin kesişim noktasında yer alan, şehrin ilk 5 yıldızlı konaklama tesisi unvanına sahip Bilge Hotel, 35 yıllık deneyimi ile alanının en iyisi olmaya devam ediyor.", "Bilge Hotel, Osmanlı sarayları ve Fransız mimarisinden esinlenilerek özenle tasarlanmış yeni konsepti kapsamında; birbirinden farklı şekilde dekore edilmiş lüks oda ve süitleri, Türk ve dünya mutfağının seçkin lezzetlerini servis eden restoranları, A’dan Z’ye yenilenmiş SPA tesisiyle misafirlerine en konforlu konaklama deneyimini sunuyor.", "Bilge Hotel iş toplantıları, kutlamalar ve farklı özel etkinlikler için 1000 kişilik kapasiteye ve eksiksiz teknik donanıma sahip salonlarıyla bir şehir otelinin ötesine geçerek kişiye özel lüks hizmetler sunuyor.", "Kemer şehir merkezinde yer alan Bilge Otel, alışveriş merkezlerine, Atatürk Kongre ve Kültür Merkezi’ne ve toplu taşıma duraklarına yürüyüş mesafesindedir.", "Bilge Hotel Güvenli Turizm Sertifikası, ISO 22000 Gıda Güvenliği Yönetim Sistemi Belgesi, Sıfır Atık Belgesi ve Turuncu Bayrak sahibidir.", "/img/aboutus-img.jpg", "Bilge Hotel, Kalite ve Konforun Adresi" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "54a0b504-06a5-4ebe-9b9e-34e8d94491e3", "mutfak", "MUTFAK" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "ccb9eaef-9b53-4a7d-a736-bb2fa6954ce8", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "282c363c-2303-49ec-b7ef-7a6e6777d5ee", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "4c03f6cb-4bc7-468a-b609-40a2b4dc1a57", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "7afc93b5-9ed3-4304-bce3-9dab85ff4f30", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "70c68bd8-23c2-4547-9ecc-97d8c29f0ad7", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0ab099bc-ffd2-4f09-ab7b-575ef55e5283", "user", "USER" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "5bcfcf8e-96f1-4a64-8f37-c0d1ed8f1857", "muhasebe", "MUHASEBE" },
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "ca7073b2-4b3c-4e2e-a432-4e944b70447c", "valilik", "VALILIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9c6165a6-08fc-46f8-9069-6c02b968c53c", 0, null, "499d1fd9-fdf4-44fb-9d52-f5ef14f8c9b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Woodrow74@yahoo.com", true, "Woodrow", "Mueller", false, null, "WOODROW74@YAHOO.COM", "WOODROW74@YAHOO.COM", "ANA63JYrfRbL2ee4vFdsf/cIo/tMkBq7D71ybunbikWq6ds6MvtsOICSM3MKrkULhQ==", "05111111111", false, "0f97dcf3-6682-49f4-9c9a-601e7675a86f", false, "Woodrow74@yahoo.com" },
                    { "c1ccf713-ea68-4161-9a77-e7f47cd51c25", 0, null, "d18a7a37-9423-4b75-9986-897cad10d038", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oliver.Heaney@yahoo.com", true, "Oliver", "Heaney", false, null, "OLIVER.HEANEY@YAHOO.COM", "OLIVER.HEANEY@YAHOO.COM", "AKtyO9ldDncxOtZxAvPfuuMRKYdA+iX8Qbby3BhuBZgCWYutJo0XCdUW9eaxcDNy0g==", "05111111111", false, "e83b091f-ab5c-4793-b2f9-76718f52696d", false, "Oliver.Heaney@yahoo.com" },
                    { "ebb4a71e-29fb-4560-9978-4e4e007754c5", 0, null, "66e6e80e-b284-467a-8289-ffcdf51151a0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel.Stanton@yahoo.com", true, "Manuel", "Stanton", false, null, "MANUEL.STANTON@YAHOO.COM", "MANUEL.STANTON@YAHOO.COM", "AAZRUiADZ7HaQ4B1LAx9N4yrAu8FU9EhOVD4xQ6aXZxYypZvjwkuW8fGa5MUy9UHjQ==", "05111111111", false, "dd6aabf7-f951-467b-b0d4-9f8aee7a7e6d", false, "Manuel.Stanton@yahoo.com" },
                    { "7db834a0-98c3-42e9-8a84-dda867a5b334", 0, null, "fcc0c5c7-0cc5-43e4-b3dd-cb77fb445dca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenny.Hodkiewicz56@hotmail.com", true, "Kenny", "Hodkiewicz", false, null, "KENNY.HODKIEWICZ56@HOTMAIL.COM", "KENNY.HODKIEWICZ56@HOTMAIL.COM", "ALxXj90fRvMRsK8amVwKmxD3fdTYLTw6e2AYbeLd/2VGGkq2hpHEfF/1sRbxGvp7PQ==", "05111111111", false, "32ddfe60-8c40-481f-8bd0-732be42fce6d", false, "Kenny.Hodkiewicz56@hotmail.com" },
                    { "18d0ccf1-8264-45f2-9886-2c14119b906b", 0, null, "cc1eaf0e-ce7b-4a53-87ae-7c1f98dcdce6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deborah2@gmail.com", true, "Deborah", "Schulist", false, null, "DEBORAH2@GMAIL.COM", "DEBORAH2@GMAIL.COM", "AJGOMFIoL5zErJdXunEiyqSj1DNhAD5/KzVhWrQg2nOBFH3wWfWZM75XPs0xfNgCyQ==", "05111111111", false, "471f8011-b7e6-4cfb-ae6c-90359ef85bb0", false, "Deborah2@gmail.com" },
                    { "9dd6e77d-fd8d-46e8-bcfa-0bf0b2167bfc", 0, null, "b16d907a-4f45-44a3-95aa-8f1f4d6688bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moses.OKon74@yahoo.com", true, "Moses", "O'Kon", false, null, "MOSES.OKON74@YAHOO.COM", "MOSES.OKON74@YAHOO.COM", "AHlE8iHSEP6y1wZKcM6B/NnK+qZhVuTVwCy4P6Ru3LsXnAzHT/ehOCLSxpJwDTgGyw==", "05111111111", false, "ac377b2e-7897-4a93-9700-eddf045f71b5", false, "Moses.OKon74@yahoo.com" },
                    { "4a27635f-7d47-4907-90fc-33ba5148fb80", 0, null, "c8b0df18-783d-4889-b064-fbd759903457", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto_Boyer@yahoo.com", true, "Alberto", "Boyer", false, null, "ALBERTO_BOYER@YAHOO.COM", "ALBERTO_BOYER@YAHOO.COM", "ADR+YG1oPN7LNJl9oFem8kpb5IR7c6bb3NKGsqx2YjbXT5U/xCYhwtFutX73zmmmeQ==", "05111111111", false, "095c2614-52b2-476b-b96f-9eb1d5b704e0", false, "Alberto_Boyer@yahoo.com" },
                    { "b516bd0d-f6bd-4236-9b42-728291e7e5e1", 0, null, "a5da377f-f129-42db-b783-ee18b80c34dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucas64@gmail.com", true, "Lucas", "Boyle", false, null, "LUCAS64@GMAIL.COM", "LUCAS64@GMAIL.COM", "AGAx+nYvW3RU/6Z7QspDRaJSAzcz+icWdVMxSMEMIcp4D8TnOlo7IH0E5BtgFraFVg==", "05111111111", false, "f25843e5-8d09-441a-b4e0-acb6a7db67b9", false, "Lucas64@gmail.com" },
                    { "d98c3d23-7a3d-4dad-a237-1beeea5f4d76", 0, null, "eca66616-e437-428d-a9b7-9798bf08f1c5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deborah.Ward@yahoo.com", true, "Deborah", "Ward", false, null, "DEBORAH.WARD@YAHOO.COM", "DEBORAH.WARD@YAHOO.COM", "APwyujTT+yUhgHonO3DXTO4p7cHR0yhPeNHCx3yYhe1MK/KTA8u2ftdB7WZuozbtxQ==", "05111111111", false, "024609fd-b9b3-4ecd-ae8b-d3bad794a476", false, "Deborah.Ward@yahoo.com" },
                    { "c64b7ee2-0f12-4f96-a67c-6fd781bdaf2e", 0, null, "6b37d667-f66d-40db-80c6-07ca7abcb2ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamara.OKeefe@hotmail.com", true, "Tamara", "O'Keefe", false, null, "TAMARA.OKEEFE@HOTMAIL.COM", "TAMARA.OKEEFE@HOTMAIL.COM", "AISMogftnB9fnU6nojCX4pqB8Iy8+GMW8x+dokvsYu8bJ0cPwkZJ0BSSMNa8766kiQ==", "05111111111", false, "ded1ae8a-943b-4c1d-8396-454bb7c3cd9f", false, "Tamara.OKeefe@hotmail.com" },
                    { "5ca60e42-a9e9-4e60-a6ff-9bf5b1c57f71", 0, null, "ab10e4b7-bcbf-4e7d-abdd-bed169f8aaf5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horace49@yahoo.com", true, "Horace", "Ebert", false, null, "HORACE49@YAHOO.COM", "HORACE49@YAHOO.COM", "AMfozAgDuEQ+WAkqhwcs0L2GgeWuPbEmrWEoYj6TlVAaYCLypuzaSJ6pANlBUo2+mw==", "05111111111", false, "2aeccf3d-9318-4415-8923-499ad40087ea", false, "Horace49@yahoo.com" },
                    { "ca51837b-a702-493a-9371-99cd3190122a", 0, null, "f6138583-ad55-4be3-abdf-23abc133eecb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yvonne.Powlowski@gmail.com", true, "Yvonne", "Powlowski", false, null, "YVONNE.POWLOWSKI@GMAIL.COM", "YVONNE.POWLOWSKI@GMAIL.COM", "AHD7fdqcnX5bIYtNXXrKqVd8Jnh00wqS1D4Zhfz8mY8xZp7zraoUhljX1AuBwBgKKg==", "05111111111", false, "91fe0e5b-3879-4283-9f04-c1c22d2e06fc", false, "Yvonne.Powlowski@gmail.com" },
                    { "3099fa3d-131c-4f9e-832d-af54c176309e", 0, null, "7f5f178f-074b-4416-997c-04287e4eaa18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberta_Hills54@hotmail.com", true, "Roberta", "Hills", false, null, "ROBERTA_HILLS54@HOTMAIL.COM", "ROBERTA_HILLS54@HOTMAIL.COM", "ABc7iZXA4KQyUHpjCQLv0cQZh8Wj0QTdttITcaU4k5G9lDWLxlHmSqMlh5MvwxvKow==", "05111111111", false, "bf298adc-db73-4ec7-b698-4c8ea0d2fdbb", false, "Roberta_Hills54@hotmail.com" },
                    { "bb15eb8e-84ee-4b7d-b8b2-5bd3529e2dc7", 0, null, "6760e6ce-e52d-49a6-b95e-3386de9f73f4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dawn_Stehr@hotmail.com", true, "Dawn", "Stehr", false, null, "DAWN_STEHR@HOTMAIL.COM", "DAWN_STEHR@HOTMAIL.COM", "AGSqJ2WpPLr7GN8z9yKL5jGe8LAwMO3UD6pnhQsfqk+UARHDKIk1CyjvSS14ZkP1sA==", "05111111111", false, "0116a4ff-e0c4-4f86-9ac3-d75580376511", false, "Dawn_Stehr@hotmail.com" },
                    { "35262fa6-4cf1-4cef-8072-0986410a4fd4", 0, null, "b21f37fb-a75f-4e1a-8c90-e137fff3bba2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valilik@bilgehotel.com", true, "Bilge", "Hotel", false, null, "VALILIK@BILGEHOTEL.COM", "VALILIK@BILGEHOTEL.COM", "ALtyxuDFr22AXrgZxxoN6kdzXB+6XK+w1yYsD7tvwUa0/45CICsYM3vt0KHn7tx6eA==", "05111111111", false, "a31bdad3-e82d-446c-a244-3ace1b8a4878", false, "valilik@bilgehotel.com" },
                    { "59f9799e-9a61-45c0-bd61-98ca91abf885", 0, null, "3a261967-cdd5-4df0-ab7b-163f070f332d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seth4@hotmail.com", true, "Seth", "Berge", false, null, "SETH4@HOTMAIL.COM", "SETH4@HOTMAIL.COM", "AKD6LzqQVINIEZBn9UWSHDpzDdJ8qvocI+UUlmmPuiq+F8946b5I21R7KhdW8qLWgw==", "05111111111", false, "75eff5fd-0372-45d5-b004-f210afd0fb51", false, "Seth4@hotmail.com" },
                    { "f44b17ce-911d-46fb-98ed-ba2cda983d47", 0, null, "11064f73-2097-4ddb-9967-35b7b678d467", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vivian_Sanford72@hotmail.com", true, "Vivian", "Sanford", false, null, "VIVIAN_SANFORD72@HOTMAIL.COM", "VIVIAN_SANFORD72@HOTMAIL.COM", "AJjWQKaCejvjJilz1jKe97lRstilnkewZzfRQ9AUPTv1pOKMzjiRb9O0A8+flckbXA==", "05111111111", false, "4cbbb83b-9f0a-451d-9683-c3f179a614bd", false, "Vivian_Sanford72@hotmail.com" },
                    { "5d61c37c-7881-4358-9c86-a1cd87db9548", 0, null, "02af846b-105a-4761-ab2e-edeb63e2bd6e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neal_Hahn@hotmail.com", true, "Neal", "Hahn", false, null, "NEAL_HAHN@HOTMAIL.COM", "NEAL_HAHN@HOTMAIL.COM", "AGZavL1XnEY+1je8ZTo8w/dlMq5Tm0add7FqD58wyKTUb5XQocEgEPM4UJ7vJJYHjQ==", "05111111111", false, "604f282e-7ab5-44da-8bb0-0f7386139c2f", false, "Neal_Hahn@hotmail.com" },
                    { "a7b5c014-01b6-44f1-bfe2-323b07e40ac0", 0, null, "4e74613a-443a-47fe-969e-c80b87ef053d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jermaine86@hotmail.com", true, "Jermaine", "Kshlerin", false, null, "JERMAINE86@HOTMAIL.COM", "JERMAINE86@HOTMAIL.COM", "AP5qFcN3cEx0sjfZhmQIFhDlL6oxT+oP3QKJkiDZ9wDrNYNmrVF+BnDaIlwGjpqeJw==", "05111111111", false, "77a66070-ac77-4cd3-a24d-64fd35e16ede", false, "Jermaine86@hotmail.com" },
                    { "92e62870-3a1d-4949-9c0e-f6f432a8d928", 0, null, "bc9dc0c2-80e6-4f75-b69f-1b27528a50a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmer23@hotmail.com", true, "Elmer", "Lemke", false, null, "ELMER23@HOTMAIL.COM", "ELMER23@HOTMAIL.COM", "ADkKS32sG3E3WRXsuj0lm487PoUHk3jcVjWjVi88lfEPZ/ESCklQLN3S2JSGp05Djw==", "05111111111", false, "48812b30-d26e-46ed-b637-d0cc1c44af27", false, "Elmer23@hotmail.com" },
                    { "a9b8d805-6d2c-451a-a86a-5266e621fe70", 0, null, "0afab4d7-bffd-49b0-b218-98c82180d213", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faith_Blick21@gmail.com", true, "Faith", "Blick", false, null, "FAITH_BLICK21@GMAIL.COM", "FAITH_BLICK21@GMAIL.COM", "AG1XZS6sF3zuqU9sJ/NFL+RIdQttuGm4A1XXRo9N71MRg2zkEZylNkRVYNq4dHUlwA==", "05111111111", false, "d99aa0c6-d934-4212-b43d-076493235392", false, "Faith_Blick21@gmail.com" },
                    { "25785f2e-4f4a-4df1-8c8c-52a22f387d98", 0, null, "4e4364f1-bd49-4506-8b69-e3d615a849db", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel79@gmail.com", true, "Isabel", "Howell", false, null, "ISABEL79@GMAIL.COM", "ISABEL79@GMAIL.COM", "AGEVuzRS6xY+s6qQVGTHb9lqTbCFLQqdKa4HZ2mHCZLoUSEnnMnyhM2f2wyfJBmfgA==", "05111111111", false, "1414056c-7981-4420-a9df-29236aef58bf", false, "Isabel79@gmail.com" },
                    { "65cf912e-f4e8-490d-8033-ebcf7fe3b9b8", 0, null, "24e04fb2-9dc6-47ba-ac60-63fd888498d2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roy18@yahoo.com", true, "Roy", "Wiza", false, null, "ROY18@YAHOO.COM", "ROY18@YAHOO.COM", "AIEdK6qeYnEPvo2lCExhfiFPoofJd3bdyHE3e8dew4RJrN0wfqMFkK6AhgnwuFHywA==", "05111111111", false, "bfc4ab9c-60de-4bdc-b6da-793e59c29c2e", false, "Roy18@yahoo.com" },
                    { "d11906a5-a4e3-4c2a-a1da-2a8eabeefab8", 0, null, "39849d2a-47c6-4b68-b367-2f92cb0e2596", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terrence_Carter72@hotmail.com", true, "Terrence", "Carter", false, null, "TERRENCE_CARTER72@HOTMAIL.COM", "TERRENCE_CARTER72@HOTMAIL.COM", "ALs7mJw+CwqXR2GWXJN7IMcssgfl8DJrEgO+PDTsCYe34lXfA7uGaTdZVrswXqg82A==", "05111111111", false, "2e7ce74e-0094-40a0-ae9e-7b66c8ec31ee", false, "Terrence_Carter72@hotmail.com" },
                    { "ddb8eed5-4679-4ab1-b76d-f19656d8335a", 0, null, "8eea4a60-e3c7-4eed-acb3-a3f021c17bd9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren11@gmail.com", true, "Lauren", "Rohan", false, null, "LAUREN11@GMAIL.COM", "LAUREN11@GMAIL.COM", "ABWeXTZKr1L/vVjQZeoBwL3fM3iCagZ+J9A5VVyWPNZSBEAtIA6/8GYGt1zy1IvNjA==", "05111111111", false, "5dfeb7c3-ce8b-48b7-a35d-7b4a5042214b", false, "Lauren11@gmail.com" },
                    { "5075f0bf-8284-4855-924d-47d6133d24ab", 0, null, "2dbf1975-051a-46f1-a7ab-36c8797742b0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francis38@hotmail.com", true, "Francis", "Johns", false, null, "FRANCIS38@HOTMAIL.COM", "FRANCIS38@HOTMAIL.COM", "ANpqFnWwQWpdNacdZ3CKA9Nh59iFoAbEZGrI0kawe37UsecyymWUlIVUTSGWPdTSrw==", "05111111111", false, "0e468488-ad04-4671-b6bf-98a899961434", false, "Francis38@hotmail.com" },
                    { "6af20cca-5467-4db4-96b1-219562213659", 0, null, "a458e41f-f7d5-4153-8918-467441631d59", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debbie71@hotmail.com", true, "Debbie", "Ebert", false, null, "DEBBIE71@HOTMAIL.COM", "DEBBIE71@HOTMAIL.COM", "AO9BrdQMXptw2Hn49Xp7r1d+Ik4P27txSnZKyWt32gZykyUfIpzoZwhzaOajzVeSJQ==", "05111111111", false, "78209773-744c-45d7-b094-678f1a2b1972", false, "Debbie71@hotmail.com" },
                    { "8ab094f0-12e6-44a0-9795-f13c08affb4b", 0, null, "39678de8-a276-4795-b7e2-2fa0f67f137e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beth58@hotmail.com", true, "Beth", "Beier", false, null, "BETH58@HOTMAIL.COM", "BETH58@HOTMAIL.COM", "AFS5exlFW3OBUFZtpXjHTC85xiJa3Nn3GAMMw65ZMmge7eEA+3AF+oYyh22p44Mm2g==", "05111111111", false, "89de5f9a-fe4d-4b50-a0d6-5a8ebb2ced53", false, "Beth58@hotmail.com" },
                    { "79ea9981-7cb7-4b37-89b2-ca454342d491", 0, null, "be7a3e43-05c6-4126-893d-9f34b6ffd40e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claude.Hammes50@gmail.com", true, "Claude", "Hammes", false, null, "CLAUDE.HAMMES50@GMAIL.COM", "CLAUDE.HAMMES50@GMAIL.COM", "AIv3NDRS01MJUp91bnQZ/vXJCEf50duLGCyHqLg/94B18EgOsgRRJVxZZ7eGX9cDTw==", "05111111111", false, "8ef7a0a1-db53-4399-8250-d28a0ce0189d", false, "Claude.Hammes50@gmail.com" },
                    { "320ec9ee-9931-4975-b21e-9b905b95187f", 0, null, "13ebdb4d-bc25-4173-933c-07b5700e7057", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gary_Robel@hotmail.com", true, "Gary", "Robel", false, null, "GARY_ROBEL@HOTMAIL.COM", "GARY_ROBEL@HOTMAIL.COM", "AEtnN/QS5Y2vfYWvV/jDHJNyepAKg0oVyCUMVQn7QeS4y1BnF57XCm1ZMuLfydR6Og==", "05111111111", false, "a3b51e30-cac1-4a19-b915-1bcc04aabc56", false, "Gary_Robel@hotmail.com" },
                    { "05f77b7a-a11e-42e9-bda7-8b2ac3181fa2", 0, null, "a34e8767-85d5-477e-acf1-5a6b9c99d479", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna_Hodkiewicz@gmail.com", true, "Anna", "Hodkiewicz", false, null, "ANNA_HODKIEWICZ@GMAIL.COM", "ANNA_HODKIEWICZ@GMAIL.COM", "AFAh24fvu59VegTtHil3MZfm/HqP4bhCqkZYqPIJr+E5xltIeHgpJrwT/LKWJR2Pxw==", "05111111111", false, "ba5e2d75-2461-4faf-b8e3-b7b7673c1874", false, "Anna_Hodkiewicz@gmail.com" },
                    { "1f6ad392-f210-4447-8c12-49bddee591d4", 0, null, "aa38abb8-2d14-4cc9-ae0a-a7e57c0d503c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominick41@gmail.com", true, "Dominick", "Monahan", false, null, "DOMINICK41@GMAIL.COM", "DOMINICK41@GMAIL.COM", "AI3v5tsB0uaBFxW4DdZQd/bkMQE14ilpXbe5SypKyIXl8TU1YH2axK+HOkt8/Rul/g==", "05111111111", false, "c3d5ca05-3abd-410d-95c6-5e303d20e383", false, "Dominick41@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7060f4d0-8343-4536-b84d-dfd69f2a3975", 0, null, "2e7d7e1f-5c60-4d5f-b8b2-fd3fb1effc5d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex_Kutch17@hotmail.com", true, "Rex", "Kutch", false, null, "REX_KUTCH17@HOTMAIL.COM", "REX_KUTCH17@HOTMAIL.COM", "AKrE2APjeGzsCxTsVipLOEl4pXA2y6kqfKWMDT6ttZIP02bS1hH31ck8IJeX4Jq+zg==", "05111111111", false, "209f94ca-75f4-45d3-8064-18405d0fb4de", false, "Rex_Kutch17@hotmail.com" },
                    { "82964b35-5273-4d7d-9e4c-28c57f6bff23", 0, null, "9d821bb1-cd81-4e41-b499-c6107ed299c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mack.Erdman@gmail.com", true, "Mack", "Erdman", false, null, "MACK.ERDMAN@GMAIL.COM", "MACK.ERDMAN@GMAIL.COM", "AN4tZa4MJE67VS5q1GW9dQk5IrddPNRgebq14pzEv2bFMVWS4KFry9XukYPEfoyVMQ==", "05111111111", false, "9a7c7340-e714-43c1-9a4c-274e6bc92d3c", false, "Mack.Erdman@gmail.com" },
                    { "f56ca38d-4199-403f-9214-f4627002e5f1", 0, null, "e503c30a-9021-4cdd-b554-eb03a13ca73f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amy_McGlynn@hotmail.com", true, "Amy", "McGlynn", false, null, "AMY_MCGLYNN@HOTMAIL.COM", "AMY_MCGLYNN@HOTMAIL.COM", "AAWvForJBZhNrKHR5gG/VTbuftTawr+AP9cQdthRnUhGZepjRwH8WykLPpRvCYneag==", "05111111111", false, "45cf0a5a-475b-4674-8705-d8e86e1d6a2b", false, "Amy_McGlynn@hotmail.com" },
                    { "68a1683a-7aa0-4d63-9797-4adbca944655", 0, null, "49783e9f-7542-4794-8818-1f77936bc68b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilbert.Greenfelder86@hotmail.com", true, "Wilbert", "Greenfelder", false, null, "WILBERT.GREENFELDER86@HOTMAIL.COM", "WILBERT.GREENFELDER86@HOTMAIL.COM", "AP4TA53y0FrLB2wEBRJVmhUEZohyxyatCfe+1U1vX6tP2zThm0Qs+ku795wHg99DvQ==", "05111111111", false, "b3eba896-bd1c-4c51-9aeb-25a511d504c9", false, "Wilbert.Greenfelder86@hotmail.com" },
                    { "d5a5cce1-b853-434e-a66e-3220fe1d4caf", 0, null, "71a91e3c-0608-46f1-b08f-4be61837a091", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicolas_Hane@yahoo.com", true, "Nicolas", "Hane", false, null, "NICOLAS_HANE@YAHOO.COM", "NICOLAS_HANE@YAHOO.COM", "AAa76xqK6DB3x5V0Ht4GktqHTceK7qemnIQDZILhXEUoY/wAApSflONqKvImXIcezA==", "05111111111", false, "a79be5ee-08fe-40f4-88e7-dc66e2cb4f40", false, "Nicolas_Hane@yahoo.com" },
                    { "5223700c-a281-47f7-84ea-b64e42057102", 0, null, "1aa0d345-7d37-4e13-93c8-2191c59e50ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel.Goldner@gmail.com", true, "Isabel", "Goldner", false, null, "ISABEL.GOLDNER@GMAIL.COM", "ISABEL.GOLDNER@GMAIL.COM", "AJLkvDXC8pjQf/C2WNLbciF3dHPDorXqa9FQChUBdHpqiqINaqkY53dJKN5N1/OdhQ==", "05111111111", false, "81ba62eb-767e-40c9-bde1-bf728683120d", false, "Isabel.Goldner@gmail.com" },
                    { "3e369eee-0b45-4164-8f24-58c61449f59a", 0, null, "cd96cf23-1ff0-472b-b4c0-4bce767396d0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wm.Spencer@hotmail.com", true, "Wm", "Spencer", false, null, "WM.SPENCER@HOTMAIL.COM", "WM.SPENCER@HOTMAIL.COM", "AEv4m6UIRxDtS3ExBJ3W2n06jCa6cA3NA8MQ6q9T6tbU4YrQyiTVVLV8dEBeAhxyqQ==", "05111111111", false, "4fb5f237-73ac-4a17-a85a-be1e5cedbeff", false, "Wm.Spencer@hotmail.com" },
                    { "fae1ebb2-1966-467a-8286-4b3dead27151", 0, null, "b84b627e-f0bc-4525-aca9-596dbda62a32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al.Lemke52@hotmail.com", true, "Al", "Lemke", false, null, "AL.LEMKE52@HOTMAIL.COM", "AL.LEMKE52@HOTMAIL.COM", "AJVZAwneZeQBsjpD+DLmWbByQGAKnNY56SleFUi2RaaY/6aiPPVIWAGPtAV43jwEgg==", "05111111111", false, "8c6244db-7f03-4ace-b526-99336a0c0d6a", false, "Al.Lemke52@hotmail.com" },
                    { "e805fbfc-c3df-4577-a107-b30550197de1", 0, null, "805522e8-e929-4b10-8b58-ad6d5c2c05ce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alonzo_Frami54@yahoo.com", true, "Alonzo", "Frami", false, null, "ALONZO_FRAMI54@YAHOO.COM", "ALONZO_FRAMI54@YAHOO.COM", "ABSaX0yRNzakKM4PzO+zHXRa381cMUBKBkcHXOvKM4PqyoEvX8cXFFc7b4qOy4zPtw==", "05111111111", false, "e061f08d-fb04-4efc-906c-7a97e749d504", false, "Alonzo_Frami54@yahoo.com" },
                    { "e07dd079-f8f9-4565-b549-706d5a4cfca9", 0, null, "4d62a8bb-011a-4bf2-94c1-6871414f5d77", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremiah.Nienow49@yahoo.com", true, "Jeremiah", "Nienow", false, null, "JEREMIAH.NIENOW49@YAHOO.COM", "JEREMIAH.NIENOW49@YAHOO.COM", "ALpqD2mHEhlssKYtdSd7zgSvGl3sLvvliOkkMS21oZG0kS0iPeM6pYIv0VOzxnLLhw==", "05111111111", false, "d8c79e43-de59-490c-8350-fa51a4b377de", false, "Jeremiah.Nienow49@yahoo.com" },
                    { "8b8ce305-7a44-4b8a-8cf2-5fed25102301", 0, null, "b0d98774-f4e3-403b-8fcf-9f61c490db81", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doris48@hotmail.com", true, "Doris", "Murray", false, null, "DORIS48@HOTMAIL.COM", "DORIS48@HOTMAIL.COM", "AK50brygx9v2XPEhV000+cnmxDTgrfUEYxBQ2L5lmo3fu2oVjWyT0LbGwWAbNiOM6w==", "05111111111", false, "e0c6899b-38af-4042-aec3-db534f574790", false, "Doris48@hotmail.com" },
                    { "3f688831-a828-43a2-869c-9f0dcacd0194", 0, null, "8196b25a-0071-4800-a05d-3a01905c6ad3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilma_Morar@gmail.com", true, "Wilma", "Morar", false, null, "WILMA_MORAR@GMAIL.COM", "WILMA_MORAR@GMAIL.COM", "AEE19b+l1IANam4WUaaugFJ0du/b1npR3znoKpM+W3b4PyxVk+KJOzcfp/dcjkv0dg==", "05111111111", false, "46c958df-bc6d-426a-a973-a1dbea888b94", false, "Wilma_Morar@gmail.com" },
                    { "3bc49c63-327e-429c-a7e2-f25650be37ec", 0, null, "9483c778-239a-4d29-bbbc-321a1348f322", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren_McGlynn61@gmail.com", true, "Lauren", "McGlynn", false, null, "LAUREN_MCGLYNN61@GMAIL.COM", "LAUREN_MCGLYNN61@GMAIL.COM", "ALzTx42mYRBCeW9G6b3CIuE6pKFamAAxA3wo81kVplxTT8JtlFNzEXB9Ziawx2FIdg==", "05111111111", false, "2d1ef3ea-ab23-4279-b429-2cfb190d0c77", false, "Lauren_McGlynn61@gmail.com" },
                    { "bb78b083-967a-48da-8140-407ef2d6b3bf", 0, null, "0f2af2c3-bb9f-4cd0-a24c-9cb175b48085", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deanna_Stokes@hotmail.com", true, "Deanna", "Stokes", false, null, "DEANNA_STOKES@HOTMAIL.COM", "DEANNA_STOKES@HOTMAIL.COM", "AF3DiPlVdpDigT6Wl2zJNW8aTmfcPuYbkHXwRXMVB8HP90VWZ0Guhw3brh9wUYCLSg==", "05111111111", false, "23943d0e-2d08-43ff-874b-fc8c8d695235", false, "Deanna_Stokes@hotmail.com" },
                    { "f79cf1a4-36f9-4b87-bbde-304362fa7738", 0, null, "e88698f4-4e44-42f7-ace2-716cd6f40424", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco_Fritsch54@yahoo.com", true, "Marco", "Fritsch", false, null, "MARCO_FRITSCH54@YAHOO.COM", "MARCO_FRITSCH54@YAHOO.COM", "ALVWSjUYBzkj0oGgNNdgRivid3Ila+ljoIlzI10LDVzzfciqtak6nIJsvlmAOaF78g==", "05111111111", false, "be7117d9-7386-451b-8858-bb709bdb4916", false, "Marco_Fritsch54@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Email", "Facebook", "Fax", "Instagram", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "0418 Trenton Drives, South Jordane, Andorra", null, null, null, null, null, "Amelia30@yahoo.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, null, null, null, null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 2, null, null, null, null, null, "Bilgi İşlem", null, null, null, null, null, null },
                    { 1, null, null, null, null, null, "Yardımcı Hizmetler", null, null, null, null, null, null },
                    { 3, null, null, null, null, null, "Mutfak", null, null, null, null, null, null },
                    { 4, null, null, null, null, null, "Resepsiyon", null, null, null, null, null, null },
                    { 5, null, null, null, null, null, "Yönetim", null, null, null, null, null, null },
                    { 6, null, null, null, null, null, "İnsan Kaynakları", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ExtraServices",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Price", "ServiceName" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, 600m, "Sauna" },
                    { 2, null, null, null, null, null, null, null, null, null, null, 400m, "Hamam" }
                });

            migrationBuilder.InsertData(
                table: "HomePages",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Paragraph1", "Paragraph2", "Paragraph3", "Paragraph4", "Paragraph5", "PictureUrl", "Subtitle", "Title" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, "Bilge Hotel Thermal Spa & Convention Center; Kemer şehir merkezinde, güler yüzlü ve profesyonel ekibi ile beklentilerin üzerinde hizmet vermektedir.", "Bilge Hotel 35 yıllık deneyimi, misafir memnuniyeti odaklı hizmet anlayışı ile sizleri kaliteye ve konfora davet ediyor.", null, null, null, "/img/homepage-img.jpg", "Bilge Hotel'e Hoşgeldiniz...", "Kalite ve Konfor" });

            migrationBuilder.InsertData(
                table: "HotelServices",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "IconPicture", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "ServiceName" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/oda-servisi.jpg", null, null, null, null, null, "Oda Servisi" },
                    { 15, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/cay-kahve-hizmeti.jpg", null, null, null, null, null, "Çay - Kahve Hizmeti" },
                    { 14, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/utu-hizmeti.jpg", null, null, null, null, null, "Ütü Hizmeti" },
                    { 2, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/ucretsiz-wi-fi.jpg", null, null, null, null, null, "Ücretsiz Wifi" },
                    { 12, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/merkezi-konum.jpg", null, null, null, null, null, "Merkezi Konum" },
                    { 13, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/ucretsiz-acik-kapali-otopark.jpg", null, null, null, null, null, "Ücretsiz Açık / Kapalı Otopark" },
                    { 7, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/hizli-c-in-c-out.jpg", null, null, null, null, null, "Hızlı C in / C out" },
                    { 6, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/bagaj-depolama.jpg", null, null, null, null, null, "Bagaj Depolama" },
                    { 5, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/toplanti-olanaklari-max-10.jpg", null, null, null, null, null, "Toplantı Olanakları" },
                    { 4, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/oda-ici-kasa.jpg", null, null, null, null, null, "Kasa" },
                    { 3, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/camasir-yikama.jpg", null, null, null, null, null, "Çamaşır Yıkama" },
                    { 8, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/kuru-temizleme.jpg", null, null, null, null, null, "Kuru Temizleme" },
                    { 10, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/aile-odasi.jpg", null, null, null, null, null, "Aile Odası" },
                    { 11, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/sicak-kahvalti.jpg", null, null, null, null, null, "Sıcak Kahvaltı" },
                    { 9, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/bebek-karyolasi.jpg", null, null, null, null, null, "Bebek Karyolası" }
                });

            migrationBuilder.InsertData(
                table: "RoomFacilities",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FacilityName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 5, null, null, null, null, null, null, "Minibar", null, null, null, null, null },
                    { 4, null, null, null, null, null, null, "Kablosuz Internet", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RoomFacilities",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FacilityName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 3, null, null, null, null, null, null, "Saç Kurutma Makinesi", null, null, null, null, null },
                    { 2, null, null, null, null, null, null, "Tv", null, null, null, null, null },
                    { 1, null, null, null, null, null, null, "Klima", null, null, null, null, null },
                    { 6, null, null, null, null, null, null, "Balkon", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "NumberOfBed", "NumberOfPeople", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 7, null, null, null, null, null, "Yatak odası, yemek yeme alanına sahip oturma salonu ve iki ayrı banyosuyla 85 m² olan geniş kullanım alanı, şehir ve dağ manzarası ile konforu sunuyor.Rahatlamak ve keyif almak için özel olarak tasarlanan jakuzili banyoda ruhunuzu ve bedeninizi dinlendirebilir, gününüzü keyifle noktalayabilirsiniz.", null, null, null, null, null, 1, 2, 2500m, "Presidential Suite" },
                    { 6, null, null, null, null, null, "30 - 35 m² Family Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet çift kişilik, iki adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 4, 1900m, "Family Room" },
                    { 5, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet tek kişilik, bir adet iki kişilik yatak bulunmaktadır.", null, null, null, null, null, 2, 3, 1500m, "Triple Superior Room" },
                    { 4, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda üç adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 3, 1500m, "Triple Room" },
                    { 3, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda iki kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 2, 1050m, "Double Superior Room" },
                    { 2, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik iki adet yatak bulunmaktadır.", null, null, null, null, null, 2, 2, 1050m, "Double Room" },
                    { 1, null, null, null, null, null, "15 - 20 m² Single Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 1, 600m, "Single Room" }
                });

            migrationBuilder.InsertData(
                table: "ServicePacks",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PackName", "PackPrice" },
                values: new object[,]
                {
                    { 2, null, null, null, null, null, "Bu pakette konaklama süresince 3 öğün yemekler, 5 çayı ve atıştırmalıklarla gün boyunca içecekler (alkolsüz içeceklerle - yerli alkollü içecekler) konaklama ücretine dahildir. Otellerdeki aktiviteler bu konseptte dahil değildir.", null, null, null, null, null, "Her Şey Dahil", 500m },
                    { 1, null, null, null, null, null, "Bu pakette sabah kahvaltısı, öğle yemeği ve akşam yemekleri konaklama ücretine dahildir.", null, null, null, null, null, "Tam Pansiyon", 200m }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "SmtpEmail", "SmtpHost", "SmtpPassword", "SmtpPort" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, "the.mstfa@gmail.com", "smtp.gmail.com", "Mustafa.2525774", 587 });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "EndTime", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "ShiftName", "StartTime" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, null, null, "Gündüz", new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, null, null, null, null, null, null, new TimeSpan(0, 0, 0, 0, 0), null, null, null, null, null, "Akşam", new TimeSpan(0, 16, 0, 0, 0) },
                    { 3, null, null, null, null, null, null, new TimeSpan(0, 8, 0, 0, 0), null, null, null, null, null, "Gece", new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "35262fa6-4cf1-4cef-8072-0986410a4fd4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e07dd079-f8f9-4565-b549-706d5a4cfca9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8b8ce305-7a44-4b8a-8cf2-5fed25102301" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3f688831-a828-43a2-869c-9f0dcacd0194" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3bc49c63-327e-429c-a7e2-f25650be37ec" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f56ca38d-4199-403f-9214-f4627002e5f1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d11906a5-a4e3-4c2a-a1da-2a8eabeefab8" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5ca60e42-a9e9-4e60-a6ff-9bf5b1c57f71" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c1ccf713-ea68-4161-9a77-e7f47cd51c25" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ebb4a71e-29fb-4560-9978-4e4e007754c5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7db834a0-98c3-42e9-8a84-dda867a5b334" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "18d0ccf1-8264-45f2-9886-2c14119b906b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9dd6e77d-fd8d-46e8-bcfa-0bf0b2167bfc" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4a27635f-7d47-4907-90fc-33ba5148fb80" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b516bd0d-f6bd-4236-9b42-728291e7e5e1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d98c3d23-7a3d-4dad-a237-1beeea5f4d76" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c64b7ee2-0f12-4f96-a67c-6fd781bdaf2e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ca51837b-a702-493a-9371-99cd3190122a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "25785f2e-4f4a-4df1-8c8c-52a22f387d98" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bb15eb8e-84ee-4b7d-b8b2-5bd3529e2dc7" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e805fbfc-c3df-4577-a107-b30550197de1" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "f44b17ce-911d-46fb-98ed-ba2cda983d47" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "fae1ebb2-1966-467a-8286-4b3dead27151" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5223700c-a281-47f7-84ea-b64e42057102" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f44b17ce-911d-46fb-98ed-ba2cda983d47" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5d61c37c-7881-4358-9c86-a1cd87db9548" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a7b5c014-01b6-44f1-bfe2-323b07e40ac0" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "92e62870-3a1d-4949-9c0e-f6f432a8d928" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "65cf912e-f4e8-490d-8033-ebcf7fe3b9b8" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f79cf1a4-36f9-4b87-bbde-304362fa7738" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "59f9799e-9a61-45c0-bd61-98ca91abf885" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a9b8d805-6d2c-451a-a86a-5266e621fe70" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9c6165a6-08fc-46f8-9069-6c02b968c53c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5075f0bf-8284-4855-924d-47d6133d24ab" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6af20cca-5467-4db4-96b1-219562213659" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8ab094f0-12e6-44a0-9795-f13c08affb4b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "79ea9981-7cb7-4b37-89b2-ca454342d491" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "320ec9ee-9931-4975-b21e-9b905b95187f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "05f77b7a-a11e-42e9-bda7-8b2ac3181fa2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1f6ad392-f210-4447-8c12-49bddee591d4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7060f4d0-8343-4536-b84d-dfd69f2a3975" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "82964b35-5273-4d7d-9e4c-28c57f6bff23" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "68a1683a-7aa0-4d63-9797-4adbca944655" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bb78b083-967a-48da-8140-407ef2d6b3bf" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d5a5cce1-b853-434e-a66e-3220fe1d4caf" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3e369eee-0b45-4164-8f24-58c61449f59a" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "5d61c37c-7881-4358-9c86-a1cd87db9548" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ddb8eed5-4679-4ab1-b76d-f19656d8335a" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "92e62870-3a1d-4949-9c0e-f6f432a8d928" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "3e369eee-0b45-4164-8f24-58c61449f59a" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "fae1ebb2-1966-467a-8286-4b3dead27151" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e805fbfc-c3df-4577-a107-b30550197de1" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e07dd079-f8f9-4565-b549-706d5a4cfca9" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "8b8ce305-7a44-4b8a-8cf2-5fed25102301" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "3f688831-a828-43a2-869c-9f0dcacd0194" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "3bc49c63-327e-429c-a7e2-f25650be37ec" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ddb8eed5-4679-4ab1-b76d-f19656d8335a" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f56ca38d-4199-403f-9214-f4627002e5f1" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "d11906a5-a4e3-4c2a-a1da-2a8eabeefab8" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5223700c-a281-47f7-84ea-b64e42057102" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5ca60e42-a9e9-4e60-a6ff-9bf5b1c57f71" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ebb4a71e-29fb-4560-9978-4e4e007754c5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7db834a0-98c3-42e9-8a84-dda867a5b334" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "18d0ccf1-8264-45f2-9886-2c14119b906b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "9dd6e77d-fd8d-46e8-bcfa-0bf0b2167bfc" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4a27635f-7d47-4907-90fc-33ba5148fb80" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "a7b5c014-01b6-44f1-bfe2-323b07e40ac0" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "d98c3d23-7a3d-4dad-a237-1beeea5f4d76" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c64b7ee2-0f12-4f96-a67c-6fd781bdaf2e" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c1ccf713-ea68-4161-9a77-e7f47cd51c25" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "d5a5cce1-b853-434e-a66e-3220fe1d4caf" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b516bd0d-f6bd-4236-9b42-728291e7e5e1" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "68a1683a-7aa0-4d63-9797-4adbca944655" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bb78b083-967a-48da-8140-407ef2d6b3bf" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "65cf912e-f4e8-490d-8033-ebcf7fe3b9b8" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "f79cf1a4-36f9-4b87-bbde-304362fa7738" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "59f9799e-9a61-45c0-bd61-98ca91abf885" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "bb15eb8e-84ee-4b7d-b8b2-5bd3529e2dc7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "a9b8d805-6d2c-451a-a86a-5266e621fe70" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "9c6165a6-08fc-46f8-9069-6c02b968c53c" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "5075f0bf-8284-4855-924d-47d6133d24ab" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "6af20cca-5467-4db4-96b1-219562213659" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "bb15eb8e-84ee-4b7d-b8b2-5bd3529e2dc7" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "79ea9981-7cb7-4b37-89b2-ca454342d491" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "8ab094f0-12e6-44a0-9795-f13c08affb4b" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "25785f2e-4f4a-4df1-8c8c-52a22f387d98" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "ca51837b-a702-493a-9371-99cd3190122a" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "82964b35-5273-4d7d-9e4c-28c57f6bff23" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3099fa3d-131c-4f9e-832d-af54c176309e" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "1f6ad392-f210-4447-8c12-49bddee591d4" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "05f77b7a-a11e-42e9-bda7-8b2ac3181fa2" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "320ec9ee-9931-4975-b21e-9b905b95187f" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "7060f4d0-8343-4536-b84d-dfd69f2a3975" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "3099fa3d-131c-4f9e-832d-af54c176309e" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "25785f2e-4f4a-4df1-8c8c-52a22f387d98", null, null, null, null, null, 2, "Isabel79@gmail.com", 3, "Isabel", 191.653896543036170m, "9598", true, "Howell", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 12, 8, 20, 47, 59, 709, DateTimeKind.Unspecified).AddTicks(9431), "Bilgi İşlem Sorumlusu" },
                    { 32, "d11906a5-a4e3-4c2a-a1da-2a8eabeefab8", null, null, null, null, null, 3, "Terrence_Carter72@hotmail.com", 3, "Terrence", 198.351960656397030m, "4320", true, "Carter", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 13, 1, 0, 11, 318, DateTimeKind.Unspecified).AddTicks(7534), "Garson" },
                    { 43, "ca51837b-a702-493a-9371-99cd3190122a", null, null, null, null, null, 1, "Yvonne.Powlowski@gmail.com", 3, "Yvonne", 196.905998018060810m, "4462", true, "Powlowski", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 11, 15, 11, 1, 17, 212, DateTimeKind.Unspecified).AddTicks(3284), "Elektirikçi" },
                    { 36, "7db834a0-98c3-42e9-8a84-dda867a5b334", null, null, null, null, null, 3, "Kenny.Hodkiewicz56@hotmail.com", 3, "Kenny", 197.6309567725430m, "7532", true, "Hodkiewicz", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 7, 1, 9, 31, 39, 156, DateTimeKind.Unspecified).AddTicks(4808), "Garson" },
                    { 35, "ebb4a71e-29fb-4560-9978-4e4e007754c5", null, null, null, null, null, 3, "Manuel.Stanton@yahoo.com", 3, "Manuel", 190.2959106072298770m, "9130", true, "Stanton", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 6, 10, 22, 26, 0, 165, DateTimeKind.Unspecified).AddTicks(1053), "Garson" },
                    { 34, "c1ccf713-ea68-4161-9a77-e7f47cd51c25", null, null, null, null, null, 3, "Oliver.Heaney@yahoo.com", 3, "Oliver", 190.2830058896369330m, "4446", true, "Heaney", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 4, 11, 14, 31, 45, 35, DateTimeKind.Unspecified).AddTicks(8980), "Garson" },
                    { 33, "5ca60e42-a9e9-4e60-a6ff-9bf5b1c57f71", null, null, null, null, null, 3, "Horace49@yahoo.com", 3, "Horace", 196.277943438048450m, "3168", true, "Ebert", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 2, 29, 13, 24, 14, 955, DateTimeKind.Unspecified).AddTicks(9366), "Garson" },
                    { 23, "3e369eee-0b45-4164-8f24-58c61449f59a", null, null, null, null, null, 3, "Wm.Spencer@hotmail.com", 3, "Wm", 196.369678422980790m, "8632", true, "Spencer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 7, 26, 16, 56, 54, 26, DateTimeKind.Unspecified).AddTicks(8569), "Aşçı" },
                    { 30, "ddb8eed5-4679-4ab1-b76d-f19656d8335a", null, null, null, null, null, 3, "Lauren11@gmail.com", 3, "Lauren", 190.8090570293409080m, "1636", true, "Rohan", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 3, 8, 0, 5, 31, 989, DateTimeKind.Unspecified).AddTicks(6512), "Garson" },
                    { 24, "fae1ebb2-1966-467a-8286-4b3dead27151", null, null, null, null, null, 3, "Al.Lemke52@hotmail.com", 3, "Al", 193.971508016796550m, "5110", true, "Lemke", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 10, 31, 16, 11, 43, 847, DateTimeKind.Unspecified).AddTicks(3500), "Aşçı" },
                    { 45, "3099fa3d-131c-4f9e-832d-af54c176309e", null, null, null, null, null, 5, "Roberta_Hills54@hotmail.com", 0, "Roberta", 195.021706169946910m, "9041", true, "Hills", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 6, 12, 3, 7, 47, 861, DateTimeKind.Unspecified).AddTicks(1512), "Müdür" },
                    { 22, "5223700c-a281-47f7-84ea-b64e42057102", null, null, null, null, null, 3, "Isabel.Goldner@gmail.com", 3, "Isabel", 199.813198898831940m, "4261", true, "Goldner", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 20, 3, 17, 13, 433, DateTimeKind.Unspecified).AddTicks(4340), "Aşçı" },
                    { 21, "d5a5cce1-b853-434e-a66e-3220fe1d4caf", null, null, null, null, null, 3, "Nicolas_Hane@yahoo.com", 3, "Nicolas", 194.425361265626440m, "8281", true, "Hane", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 26, 3, 6, 16, 503, DateTimeKind.Unspecified).AddTicks(683), "Aşçı" },
                    { 20, "bb78b083-967a-48da-8140-407ef2d6b3bf", null, null, null, null, null, 3, "Deanna_Stokes@hotmail.com", 3, "Deanna", 195.791756527401390m, "7695", true, "Stokes", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 31, 22, 29, 7, 946, DateTimeKind.Unspecified).AddTicks(2247), "Aşçı" },
                    { 19, "68a1683a-7aa0-4d63-9797-4adbca944655", null, null, null, null, null, 3, "Wilbert.Greenfelder86@hotmail.com", 3, "Wilbert", 191.009867140562210m, "7092", true, "Greenfelder", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 29, 8, 54, 52, 888, DateTimeKind.Unspecified).AddTicks(1772), "Aşçı" },
                    { 13, "79ea9981-7cb7-4b37-89b2-ca454342d491", null, null, null, null, null, 1, "Claude.Hammes50@gmail.com", 3, "Claude", 196.987917286803910m, "2491", true, "Hammes", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 12, 5, 5, 26, 56, 81, DateTimeKind.Unspecified).AddTicks(6709), "Temizlik Görevlisi" },
                    { 31, "f56ca38d-4199-403f-9214-f4627002e5f1", null, null, null, null, null, 3, "Amy_McGlynn@hotmail.com", 3, "Amy", 191.902626576788080m, "5077", true, "McGlynn", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 3, 28, 23, 30, 21, 90, DateTimeKind.Unspecified).AddTicks(4223), "Garson" },
                    { 46, "bb15eb8e-84ee-4b7d-b8b2-5bd3529e2dc7", null, null, null, null, null, 6, "Dawn_Stehr@hotmail.com", 1, "Dawn", 199.59150096382550m, "7420", true, "Stehr", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2021, 11, 8, 3, 51, 11, 594, DateTimeKind.Unspecified).AddTicks(3696), "İnsan Kaynakları Müdürü" },
                    { 17, "7060f4d0-8343-4536-b84d-dfd69f2a3975", null, null, null, null, null, 1, "Rex_Kutch17@hotmail.com", 3, "Rex", 199.93264944755130m, "9286", true, "Kutch", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 9, 20, 12, 48, 36, 699, DateTimeKind.Unspecified).AddTicks(5810), "Temizlik Görevlisi" },
                    { 5, "65cf912e-f4e8-490d-8033-ebcf7fe3b9b8", null, null, null, null, null, 4, "Roy18@yahoo.com", 3, "Roy", 195.403856791278280m, "2016", true, "Wiza", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 2, 24, 0, 40, 50, 93, DateTimeKind.Unspecified).AddTicks(9777), "Resepsiyonist" },
                    { 12, "8ab094f0-12e6-44a0-9795-f13c08affb4b", null, null, null, null, null, 1, "Beth58@hotmail.com", 3, "Beth", 198.539316411381270m, "4548", true, "Beier", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 12, 27, 6, 2, 3, 647, DateTimeKind.Unspecified).AddTicks(8290), "Temizlik Görevlisi" },
                    { 7, "59f9799e-9a61-45c0-bd61-98ca91abf885", null, null, null, null, null, 4, "Seth4@hotmail.com", 3, "Seth", 192.473825948533520m, "9599", true, "Berge", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2020, 11, 22, 19, 53, 28, 676, DateTimeKind.Unspecified).AddTicks(9340), "Resepsiyonist" },
                    { 6, "f79cf1a4-36f9-4b87-bbde-304362fa7738", null, null, null, null, null, 4, "Marco_Fritsch54@yahoo.com", 3, "Marco", 190.6309550537871920m, "6550", true, "Fritsch", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2021, 6, 29, 15, 37, 59, 243, DateTimeKind.Unspecified).AddTicks(3920), "Resepsiyonist" },
                    { 42, "c64b7ee2-0f12-4f96-a67c-6fd781bdaf2e", null, null, null, null, null, 3, "Tamara.OKeefe@hotmail.com", 3, "Tamara", 196.235476493013780m, "5847", true, "O'Keefe", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 8, 12, 7, 22, 51, 40, DateTimeKind.Unspecified).AddTicks(9282), "Garson" },
                    { 41, "d98c3d23-7a3d-4dad-a237-1beeea5f4d76", null, null, null, null, null, 3, "Deborah.Ward@yahoo.com", 3, "Deborah", 196.653624925135460m, "2583", true, "Ward", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 7, 26, 15, 15, 17, 558, DateTimeKind.Unspecified).AddTicks(8576), "Garson" },
                    { 40, "b516bd0d-f6bd-4236-9b42-728291e7e5e1", null, null, null, null, null, 3, "Lucas64@gmail.com", 3, "Lucas", 194.492101168489130m, "4693", true, "Boyle", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 1, 19, 9, 46, 34, 139, DateTimeKind.Unspecified).AddTicks(3290), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "4a27635f-7d47-4907-90fc-33ba5148fb80", null, null, null, null, null, 3, "Alberto_Boyer@yahoo.com", 3, "Alberto", 191.67770848221970m, "6386", true, "Boyer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 5, 24, 0, 11, 17, 71, DateTimeKind.Unspecified).AddTicks(9898), "Garson" },
                    { 38, "9dd6e77d-fd8d-46e8-bcfa-0bf0b2167bfc", null, null, null, null, null, 3, "Moses.OKon74@yahoo.com", 3, "Moses", 197.026128255308660m, "2452", true, "O'Kon", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 3, 21, 5, 24, 59, 32, DateTimeKind.Unspecified).AddTicks(9321), "Garson" },
                    { 37, "18d0ccf1-8264-45f2-9886-2c14119b906b", null, null, null, null, null, 3, "Deborah2@gmail.com", 3, "Deborah", 190.7537516815372520m, "4357", true, "Schulist", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 1, 10, 17, 21, 15, 174, DateTimeKind.Unspecified).AddTicks(3020), "Garson" },
                    { 28, "3f688831-a828-43a2-869c-9f0dcacd0194", null, null, null, null, null, 3, "Wilma_Morar@gmail.com", 3, "Wilma", 194.993576698467870m, "7692", true, "Morar", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 2, 23, 23, 41, 11, 530, DateTimeKind.Unspecified).AddTicks(4068), "Aşçı" },
                    { 27, "8b8ce305-7a44-4b8a-8cf2-5fed25102301", null, null, null, null, null, 3, "Doris48@hotmail.com", 3, "Doris", 199.912871080410140m, "8916", true, "Murray", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 6, 26, 14, 32, 43, 847, DateTimeKind.Unspecified).AddTicks(165), "Aşçı" },
                    { 26, "e07dd079-f8f9-4565-b549-706d5a4cfca9", null, null, null, null, null, 3, "Jeremiah.Nienow49@yahoo.com", 3, "Jeremiah", 193.126483090746440m, "2682", true, "Nienow", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 11, 14, 12, 16, 44, 630, DateTimeKind.Unspecified).AddTicks(4220), "Aşçı" },
                    { 25, "e805fbfc-c3df-4577-a107-b30550197de1", null, null, null, null, null, 3, "Alonzo_Frami54@yahoo.com", 3, "Alonzo", 199.848908274364150m, "3731", true, "Frami", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 7, 24, 15, 45, 35, 701, DateTimeKind.Unspecified).AddTicks(1659), "Aşçı" },
                    { 18, "82964b35-5273-4d7d-9e4c-28c57f6bff23", null, null, null, null, null, 1, "Mack.Erdman@gmail.com", 3, "Mack", 198.720618127249470m, "6205", true, "Erdman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 4, 20, 21, 19, 57, 687, DateTimeKind.Unspecified).AddTicks(2503), "Temizlik Görevlisi" },
                    { 16, "1f6ad392-f210-4447-8c12-49bddee591d4", null, null, null, null, null, 1, "Dominick41@gmail.com", 3, "Dominick", 198.441001213361040m, "1125", true, "Monahan", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 2, 9, 0, 16, 24, 849, DateTimeKind.Unspecified).AddTicks(6664), "Temizlik Görevlisi" },
                    { 15, "05f77b7a-a11e-42e9-bda7-8b2ac3181fa2", null, null, null, null, null, 1, "Anna_Hodkiewicz@gmail.com", 3, "Anna", 192.673201790392960m, "4429", true, "Hodkiewicz", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 5, 16, 22, 8, 20, 712, DateTimeKind.Unspecified).AddTicks(4151), "Temizlik Görevlisi" },
                    { 14, "320ec9ee-9931-4975-b21e-9b905b95187f", null, null, null, null, null, 1, "Gary_Robel@hotmail.com", 3, "Gary", 194.988905915519640m, "7827", true, "Robel", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 10, 19, 7, 24, 33, 936, DateTimeKind.Unspecified).AddTicks(6220), "Temizlik Görevlisi" },
                    { 4, "92e62870-3a1d-4949-9c0e-f6f432a8d928", null, null, null, null, null, 4, "Elmer23@hotmail.com", 3, "Elmer", 191.338605154929030m, "2026", true, "Lemke", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 2, 18, 18, 1, 56, 353, DateTimeKind.Unspecified).AddTicks(3537), "Resepsiyonist" },
                    { 29, "3bc49c63-327e-429c-a7e2-f25650be37ec", null, null, null, null, null, 3, "Lauren_McGlynn61@gmail.com", 3, "Lauren", 192.645529495852780m, "9384", true, "McGlynn", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 3, 3, 1, 7, 43, 445, DateTimeKind.Unspecified).AddTicks(2398), "Aşçı" },
                    { 11, "6af20cca-5467-4db4-96b1-219562213659", null, null, null, null, null, 1, "Debbie71@hotmail.com", 3, "Debbie", 196.110964508778860m, "7556", true, "Ebert", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 12, 1, 14, 41, 7, 480, DateTimeKind.Unspecified).AddTicks(4670), "Temizlik Görevlisi" },
                    { 9, "9c6165a6-08fc-46f8-9069-6c02b968c53c", null, null, null, null, null, 1, "Woodrow74@yahoo.com", 3, "Woodrow", 190.1273573423397530m, "7329", true, "Mueller", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 9, 4, 8, 57, 28, 455, DateTimeKind.Unspecified).AddTicks(141), "Temizlik Görevlisi" },
                    { 8, "a9b8d805-6d2c-451a-a86a-5266e621fe70", null, null, null, null, null, 1, "Faith_Blick21@gmail.com", 3, "Faith", 194.482531293520020m, "4328", true, "Blick", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 10, 23, 18, 27, 2, 271, DateTimeKind.Unspecified).AddTicks(209), "Temizlik Görevlisi" },
                    { 3, "a7b5c014-01b6-44f1-bfe2-323b07e40ac0", null, null, null, null, null, 4, "Jermaine86@hotmail.com", 3, "Jermaine", 199.142836732390730m, "8862", true, "Kshlerin", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 10, 5, 6, 46, 8, 59, DateTimeKind.Unspecified).AddTicks(3987), "Resepsiyonist" },
                    { 2, "5d61c37c-7881-4358-9c86-a1cd87db9548", null, null, null, null, null, 4, "Neal_Hahn@hotmail.com", 3, "Neal", 190.9266691379838940m, "6258", true, "Hahn", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 7, 22, 6, 10, 38, 129, DateTimeKind.Unspecified).AddTicks(1604), "Resepsiyonist" },
                    { 1, "f44b17ce-911d-46fb-98ed-ba2cda983d47", null, null, null, null, null, 4, "Vivian_Sanford72@hotmail.com", 3, "Vivian", 197.023979302972540m, "5266", true, "Sanford", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 4, 7, 23, 2, 22, 626, DateTimeKind.Unspecified).AddTicks(5922), "Resepsiyonist" },
                    { 10, "5075f0bf-8284-4855-924d-47d6133d24ab", null, null, null, null, null, 1, "Francis38@hotmail.com", 3, "Francis", 191.207063729505550m, "2965", true, "Johns", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 8, 4, 12, 36, 33, 26, DateTimeKind.Unspecified).AddTicks(697), "Temizlik Görevlisi" }
                });

            migrationBuilder.InsertData(
                table: "FacilitiesOfRooms",
                columns: new[] { "RoomFacilityID", "RoomTypeID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 1, 2, null, null, null, null, null, null, null, null, null, null },
                    { 2, 2, null, null, null, null, null, null, null, null, null, null },
                    { 3, 2, null, null, null, null, null, null, null, null, null, null },
                    { 4, 2, null, null, null, null, null, null, null, null, null, null },
                    { 5, 2, null, null, null, null, null, null, null, null, null, null },
                    { 1, 3, null, null, null, null, null, null, null, null, null, null },
                    { 2, 3, null, null, null, null, null, null, null, null, null, null },
                    { 6, 5, null, null, null, null, null, null, null, null, null, null },
                    { 5, 5, null, null, null, null, null, null, null, null, null, null },
                    { 4, 5, null, null, null, null, null, null, null, null, null, null },
                    { 1, 5, null, null, null, null, null, null, null, null, null, null },
                    { 2, 5, null, null, null, null, null, null, null, null, null, null },
                    { 4, 1, null, null, null, null, null, null, null, null, null, null },
                    { 3, 3, null, null, null, null, null, null, null, null, null, null },
                    { 4, 3, null, null, null, null, null, null, null, null, null, null },
                    { 5, 3, null, null, null, null, null, null, null, null, null, null },
                    { 6, 3, null, null, null, null, null, null, null, null, null, null },
                    { 1, 4, null, null, null, null, null, null, null, null, null, null },
                    { 2, 4, null, null, null, null, null, null, null, null, null, null },
                    { 3, 4, null, null, null, null, null, null, null, null, null, null },
                    { 3, 5, null, null, null, null, null, null, null, null, null, null },
                    { 3, 1, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FacilitiesOfRooms",
                columns: new[] { "RoomFacilityID", "RoomTypeID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, null, null, null, null, null, null, null },
                    { 4, 4, null, null, null, null, null, null, null, null, null, null },
                    { 6, 7, null, null, null, null, null, null, null, null, null, null },
                    { 5, 7, null, null, null, null, null, null, null, null, null, null },
                    { 4, 7, null, null, null, null, null, null, null, null, null, null },
                    { 3, 7, null, null, null, null, null, null, null, null, null, null },
                    { 2, 7, null, null, null, null, null, null, null, null, null, null },
                    { 1, 7, null, null, null, null, null, null, null, null, null, null },
                    { 2, 1, null, null, null, null, null, null, null, null, null, null },
                    { 5, 4, null, null, null, null, null, null, null, null, null, null },
                    { 6, 6, null, null, null, null, null, null, null, null, null, null },
                    { 5, 6, null, null, null, null, null, null, null, null, null, null },
                    { 4, 6, null, null, null, null, null, null, null, null, null, null },
                    { 3, 6, null, null, null, null, null, null, null, null, null, null },
                    { 2, 6, null, null, null, null, null, null, null, null, null, null },
                    { 1, 6, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "HomePageSlides",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "HomePageID", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PictureName", "PictureUrl" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, 1, null, null, null, null, null, "Slide1", "https://www.almira.com.tr/images/genel1.jpg" },
                    { 3, null, null, null, null, null, 1, null, null, null, null, null, "Slide3", "https://www.almira.com.tr/images/gallery/almira/07.jpg" },
                    { 2, null, null, null, null, null, 1, null, null, null, null, null, "Slide2", "https://www.almira.com.tr/images/gallery/almira/04.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "ID", "AboutusID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PictureName", "PictureUrl" },
                values: new object[,]
                {
                    { 7, 1, null, null, null, null, null, null, null, null, null, null, "Görsel7", "/img/gallery/room-presidential-suite.jpg" },
                    { 5, 1, null, null, null, null, null, null, null, null, null, null, "Görsel5", "/img/gallery/room-triple-superrior.jpg" },
                    { 4, 1, null, null, null, null, null, null, null, null, null, null, "Görsel4", "/img/gallery/room-triple.jpg" },
                    { 3, 1, null, null, null, null, null, null, null, null, null, null, "Görsel3", "/img/gallery/room-double-superrior.jpg" },
                    { 2, 1, null, null, null, null, null, null, null, null, null, null, "Görsel2", "/img/gallery/room-double.jpg" },
                    { 6, 1, null, null, null, null, null, null, null, null, null, null, "Görsel6", "/img/gallery/room-family.jpg" },
                    { 1, 1, null, null, null, null, null, null, null, null, null, null, "Görsel1", "/img/gallery/room-single.jpg" }
                });

            migrationBuilder.InsertData(
                table: "RoomPictures",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PictureUrl", "RoomTypeID" },
                values: new object[,]
                {
                    { 5, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-triple-superrior.jpg", 5 },
                    { 7, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-presidential-suite.jpg", 7 },
                    { 6, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-family.jpg", 6 },
                    { 3, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-double-superrior.jpg", 3 },
                    { 1, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-single.jpg", 1 },
                    { 4, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-triple.jpg", 4 },
                    { 2, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-double.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 21, null, null, null, null, null, null, 2, null, null, null, null, null, "120", 5, 1 },
                    { 22, null, null, null, null, null, null, 2, null, null, null, null, null, "121", 5, 1 },
                    { 23, null, null, null, null, null, null, 2, null, null, null, null, null, "122", 5, 1 },
                    { 24, null, null, null, null, null, null, 2, null, null, null, null, null, "123", 5, 1 },
                    { 25, null, null, null, null, null, null, 2, null, null, null, null, null, "124", 5, 1 },
                    { 26, null, null, null, null, null, null, 2, null, null, null, null, null, "125", 5, 1 },
                    { 12, null, null, null, null, null, null, 1, null, null, null, null, null, "111", 5, 4 },
                    { 10, null, null, null, null, null, null, 1, null, null, null, null, null, "109", 5, 1 },
                    { 28, null, null, null, null, null, null, 2, null, null, null, null, null, "127", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 29, null, null, null, null, null, null, 2, null, null, null, null, null, "128", 5, 1 },
                    { 30, null, null, null, null, null, null, 2, null, null, null, null, null, "129", 5, 1 },
                    { 57, null, null, null, null, null, null, 3, null, null, null, null, null, "156", 5, 5 },
                    { 56, null, null, null, null, null, null, 3, null, null, null, null, null, "155", 5, 5 },
                    { 55, null, null, null, null, null, null, 3, null, null, null, null, null, "154", 5, 5 },
                    { 27, null, null, null, null, null, null, 2, null, null, null, null, null, "126", 5, 1 },
                    { 9, null, null, null, null, null, null, 1, null, null, null, null, null, "108", 5, 1 },
                    { 7, null, null, null, null, null, null, 1, null, null, null, null, null, "106", 5, 1 },
                    { 54, null, null, null, null, null, null, 3, null, null, null, null, null, "153", 5, 5 },
                    { 77, null, null, null, null, null, null, 4, null, null, null, null, null, "176", 5, 7 },
                    { 76, null, null, null, null, null, null, 4, null, null, null, null, null, "175", 5, 6 },
                    { 75, null, null, null, null, null, null, 4, null, null, null, null, null, "174", 5, 6 },
                    { 74, null, null, null, null, null, null, 4, null, null, null, null, null, "173", 5, 6 },
                    { 73, null, null, null, null, null, null, 4, null, null, null, null, null, "172", 5, 6 },
                    { 72, null, null, null, null, null, null, 4, null, null, null, null, null, "171", 5, 6 },
                    { 71, null, null, null, null, null, null, 4, null, null, null, null, null, "170", 5, 6 },
                    { 8, null, null, null, null, null, null, 1, null, null, null, null, null, "107", 5, 1 },
                    { 60, null, null, null, null, null, null, 3, null, null, null, null, null, "159", 5, 5 },
                    { 58, null, null, null, null, null, null, 3, null, null, null, null, null, "157", 5, 5 },
                    { 1, null, null, null, null, null, null, 1, null, null, null, null, null, "100", 5, 1 },
                    { 2, null, null, null, null, null, null, 1, null, null, null, null, null, "101", 5, 1 },
                    { 3, null, null, null, null, null, null, 1, null, null, null, null, null, "102", 5, 1 },
                    { 4, null, null, null, null, null, null, 1, null, null, null, null, null, "103", 5, 1 },
                    { 5, null, null, null, null, null, null, 1, null, null, null, null, null, "104", 5, 1 },
                    { 6, null, null, null, null, null, null, 1, null, null, null, null, null, "105", 5, 1 },
                    { 59, null, null, null, null, null, null, 3, null, null, null, null, null, "158", 5, 5 },
                    { 53, null, null, null, null, null, null, 3, null, null, null, null, null, "152", 5, 5 },
                    { 32, null, null, null, null, null, null, 2, null, null, null, null, null, "131", 5, 2 },
                    { 11, null, null, null, null, null, null, 1, null, null, null, null, null, "110", 5, 4 },
                    { 49, null, null, null, null, null, null, 3, null, null, null, null, null, "148", 5, 3 },
                    { 50, null, null, null, null, null, null, 3, null, null, null, null, null, "149", 5, 3 },
                    { 61, null, null, null, null, null, null, 4, null, null, null, null, null, "160", 5, 3 },
                    { 17, null, null, null, null, null, null, 1, null, null, null, null, null, "116", 5, 4 },
                    { 63, null, null, null, null, null, null, 4, null, null, null, null, null, "162", 5, 3 },
                    { 64, null, null, null, null, null, null, 4, null, null, null, null, null, "163", 5, 3 },
                    { 65, null, null, null, null, null, null, 4, null, null, null, null, null, "164", 5, 3 },
                    { 48, null, null, null, null, null, null, 3, null, null, null, null, null, "147", 5, 3 },
                    { 66, null, null, null, null, null, null, 4, null, null, null, null, null, "165", 5, 3 },
                    { 68, null, null, null, null, null, null, 4, null, null, null, null, null, "167", 5, 3 },
                    { 69, null, null, null, null, null, null, 4, null, null, null, null, null, "168", 5, 3 },
                    { 70, null, null, null, null, null, null, 4, null, null, null, null, null, "169", 5, 3 },
                    { 16, null, null, null, null, null, null, 1, null, null, null, null, null, "115", 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 15, null, null, null, null, null, null, 1, null, null, null, null, null, "114", 5, 4 },
                    { 14, null, null, null, null, null, null, 1, null, null, null, null, null, "113", 5, 4 },
                    { 13, null, null, null, null, null, null, 1, null, null, null, null, null, "112", 5, 4 },
                    { 67, null, null, null, null, null, null, 4, null, null, null, null, null, "166", 5, 3 },
                    { 47, null, null, null, null, null, null, 3, null, null, null, null, null, "146", 5, 3 },
                    { 46, null, null, null, null, null, null, 3, null, null, null, null, null, "145", 5, 3 },
                    { 45, null, null, null, null, null, null, 3, null, null, null, null, null, "144", 5, 3 },
                    { 33, null, null, null, null, null, null, 2, null, null, null, null, null, "132", 5, 2 },
                    { 34, null, null, null, null, null, null, 2, null, null, null, null, null, "133", 5, 2 },
                    { 35, null, null, null, null, null, null, 2, null, null, null, null, null, "134", 5, 2 },
                    { 36, null, null, null, null, null, null, 2, null, null, null, null, null, "135", 5, 2 },
                    { 37, null, null, null, null, null, null, 2, null, null, null, null, null, "136", 5, 2 },
                    { 38, null, null, null, null, null, null, 2, null, null, null, null, null, "137", 5, 2 },
                    { 39, null, null, null, null, null, null, 2, null, null, null, null, null, "138", 5, 2 },
                    { 40, null, null, null, null, null, null, 2, null, null, null, null, null, "139", 5, 2 },
                    { 52, null, null, null, null, null, null, 3, null, null, null, null, null, "151", 5, 5 },
                    { 51, null, null, null, null, null, null, 3, null, null, null, null, null, "150", 5, 5 },
                    { 20, null, null, null, null, null, null, 1, null, null, null, null, null, "119", 5, 4 },
                    { 19, null, null, null, null, null, null, 1, null, null, null, null, null, "118", 5, 4 },
                    { 18, null, null, null, null, null, null, 1, null, null, null, null, null, "117", 5, 4 },
                    { 41, null, null, null, null, null, null, 3, null, null, null, null, null, "140", 5, 3 },
                    { 42, null, null, null, null, null, null, 3, null, null, null, null, null, "141", 5, 3 },
                    { 43, null, null, null, null, null, null, 3, null, null, null, null, null, "142", 5, 3 },
                    { 44, null, null, null, null, null, null, 3, null, null, null, null, null, "143", 5, 3 },
                    { 31, null, null, null, null, null, null, 2, null, null, null, null, null, "130", 5, 2 },
                    { 62, null, null, null, null, null, null, 4, null, null, null, null, null, "161", 5, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AppUserId",
                table: "Employees",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ShiftID",
                table: "Employees",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitiesOfRooms_RoomTypeID",
                table: "FacilitiesOfRooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestRegistration_GuestID",
                table: "GuestRegistration",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_HomePageSlides_HomePageID",
                table: "HomePageSlides",
                column: "HomePageID");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_RegistrationID",
                table: "Incomes",
                column: "RegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AppUserID",
                table: "Messages",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_AboutusID",
                table: "Pictures",
                column: "AboutusID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionReservations_RoomID",
                table: "ReceptionReservations",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionReservations_RoomTypeID",
                table: "ReceptionReservations",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionReservations_ServicePackID",
                table: "ReceptionReservations",
                column: "ServicePackID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_RoomID",
                table: "Registrations",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ServicePackID",
                table: "Registrations",
                column: "ServicePackID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPictures_RoomTypeID",
                table: "RoomPictures",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeID",
                table: "Rooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_EmployeeID",
                table: "Salaries",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_StatusesOfRooms_RoomID",
                table: "StatusesOfRooms",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_UseOfExtraServices_RegistrationID",
                table: "UseOfExtraServices",
                column: "RegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_WebReservations_AppUserID",
                table: "WebReservations",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_WebReservations_RoomID",
                table: "WebReservations",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_WebReservations_RoomTypeID",
                table: "WebReservations",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WebReservations_ServicePackID",
                table: "WebReservations",
                column: "ServicePackID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkSchedules_EmployeeID",
                table: "WorkSchedules",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EmployeesShifts");

            migrationBuilder.DropTable(
                name: "FacilitiesOfRooms");

            migrationBuilder.DropTable(
                name: "GuestRegistration");

            migrationBuilder.DropTable(
                name: "HomePageSlides");

            migrationBuilder.DropTable(
                name: "HotelServices");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "ReceptionReservations");

            migrationBuilder.DropTable(
                name: "RoomPictures");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "StatusesOfRooms");

            migrationBuilder.DropTable(
                name: "UseOfExtraServices");

            migrationBuilder.DropTable(
                name: "WebReservations");

            migrationBuilder.DropTable(
                name: "WorkSchedules");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "RoomFacilities");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "HomePages");

            migrationBuilder.DropTable(
                name: "Aboutus");

            migrationBuilder.DropTable(
                name: "ExtraServices");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "ServicePacks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
