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
                    ActivationKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5d514937-5afb-447b-b9b9-ecdc8fc85cb6", "mutfak", "MUTFAK" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "51415179-8f29-4ab2-a6f4-07ce6762b7a3", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "cec4d98f-8f7b-42e0-8e85-1665b7f0206c", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "bc9c8aaf-6526-4a9e-8a51-0364bd9d6993", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "512260c0-3ea6-45f1-9b46-0361360e02bd", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "b1c1b88b-e28f-493d-b51c-43567fa0b1a3", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "03efe6b4-0645-4831-adf2-8fdb00f4743e", "user", "USER" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "5946a65d-a39d-4aa0-a8cc-284acfb09c22", "muhasebe", "MUHASEBE" },
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "57f49665-3223-49c4-820e-0241dd9b09e1", "valilik", "VALILIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a871e5c7-0733-4124-801a-fb0ea09d3971", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9de19c6f-3c00-49ef-88cb-8741fe6b33ed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henrietta57@hotmail.com", true, "Henrietta", "Hane", false, null, "HENRIETTA57@HOTMAIL.COM", "HENRIETTA57@HOTMAIL.COM", "AM6qRHJECp/48S1h2pPhD/EEPHPZeV7Ujk2oDUBcatBKjYTKBXb/oZtMWIGqyx1YUQ==", "05111111111", false, "fabe8182-a7c7-4e85-9c22-e9e26237e549", false, "Henrietta57@hotmail.com" },
                    { "74afca61-8921-485e-a50c-4909f64823a3", 0, new Guid("00000000-0000-0000-0000-000000000000"), "afa23abd-cbf0-4356-ae48-22c39c335506", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristina56@hotmail.com", true, "Cristina", "Paucek", false, null, "CRISTINA56@HOTMAIL.COM", "CRISTINA56@HOTMAIL.COM", "AKY4GkQG2K8FbmxrkMMhEz254tPHGH6VB2A1t9LoWxAPFSk8dsAZ0+2PGYhEQQ0D8A==", "05111111111", false, "b32daf69-da98-4c7b-8543-cdb562f36994", false, "Cristina56@hotmail.com" },
                    { "157448a9-6bfc-44a8-8949-00d55f0cf106", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1d4b4ff1-4c45-44d8-8f61-79dd06ba93f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allan_Zboncak@yahoo.com", true, "Allan", "Zboncak", false, null, "ALLAN_ZBONCAK@YAHOO.COM", "ALLAN_ZBONCAK@YAHOO.COM", "AFsEDEJKIJ1aCT9AmL51Xqd4jKEVu7nxmakmVBlUkYUPSFMFeGmFq862Tj1w3FKNXw==", "05111111111", false, "3aa65f86-b469-4a24-b227-439b519eaded", false, "Allan_Zboncak@yahoo.com" },
                    { "eaf38669-9232-4bdf-a42b-0be01f42d17c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "a98a90c5-91fc-4f4a-b949-33370588374b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo.Homenick28@yahoo.com", true, "Guillermo", "Homenick", false, null, "GUILLERMO.HOMENICK28@YAHOO.COM", "GUILLERMO.HOMENICK28@YAHOO.COM", "AAig8fKsmvAHkVOBhuEls/MtaUCSVqWwwi6xjhlRi8mGFk8J0szFfc0wgugkVnUweg==", "05111111111", false, "0f428d50-769d-4c5d-abbc-9006e18a17a5", false, "Guillermo.Homenick28@yahoo.com" },
                    { "c70735fd-7815-4690-9df2-221392f96826", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b90ee8ec-fa9c-4f28-a0b1-9293a2048a5d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nichole0@gmail.com", true, "Nichole", "Smith", false, null, "NICHOLE0@GMAIL.COM", "NICHOLE0@GMAIL.COM", "AJKSlquZI+XDKjQUP0jJitPHzVDuvoL3qc6AvpjRf5LGGdhcNyJ94OBxQd3pNQrMnA==", "05111111111", false, "f761f02c-95dd-456a-9740-853c0ba325bd", false, "Nichole0@gmail.com" },
                    { "9d08f0fb-be8b-428a-9bf1-7987706187e7", 0, new Guid("00000000-0000-0000-0000-000000000000"), "50bb810d-67d2-4b5c-90f8-3f96c9478d16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfredo.Roberts@gmail.com", true, "Alfredo", "Roberts", false, null, "ALFREDO.ROBERTS@GMAIL.COM", "ALFREDO.ROBERTS@GMAIL.COM", "AKbkIMkbee4OBSfnXvvA1Y/UIRhwpvZqyR1kTjCl8jgnApBwpkmzMqK8MgRl2PCZhA==", "05111111111", false, "03842328-7470-4177-a869-59d80bb8486e", false, "Alfredo.Roberts@gmail.com" },
                    { "c268e84c-c4b9-4cce-9fad-7a50e7de1c39", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b0f41213-9ae7-49fe-8904-f042b8232b1b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin97@hotmail.com", true, "Kevin", "Kuhlman", false, null, "KEVIN97@HOTMAIL.COM", "KEVIN97@HOTMAIL.COM", "ALMufKJX+nWH7ygeIOqC9+YUInoJ3+SwiKCl+vhKMQyrzm6jN4QsqPDt5moi9Nsmtw==", "05111111111", false, "3563ace7-4431-4a2c-be4b-066bca266b75", false, "Kevin97@hotmail.com" },
                    { "632e4d14-c323-454d-84ae-fc770f0e8c19", 0, new Guid("00000000-0000-0000-0000-000000000000"), "3d40ebe3-7763-4e4c-9f2b-f5785ff02306", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rochelle.Wyman79@hotmail.com", true, "Rochelle", "Wyman", false, null, "ROCHELLE.WYMAN79@HOTMAIL.COM", "ROCHELLE.WYMAN79@HOTMAIL.COM", "ANiMBuiU73QywbVdAGmab9yRG6OoibmZ36EWOdMf6SQkwbbY15aMXGs29mgHRg8JsA==", "05111111111", false, "7b948437-dcc0-4594-bfc3-68e74c1be50a", false, "Rochelle.Wyman79@hotmail.com" },
                    { "f8dc1a85-39da-4cb2-b5b3-9e32e35ab988", 0, new Guid("00000000-0000-0000-0000-000000000000"), "39781356-7540-4df3-a041-1aa00fc2dd05", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al_Boyer@yahoo.com", true, "Al", "Boyer", false, null, "AL_BOYER@YAHOO.COM", "AL_BOYER@YAHOO.COM", "AA+doyc5vzC+swj1fiHDD5u+NYzFZfnWW31duO3l2gg3dtA0uJaZEwVKq6NV58Mwig==", "05111111111", false, "87b33fc3-2758-4c30-a25a-3e505ba37972", false, "Al_Boyer@yahoo.com" },
                    { "eb2a6164-1f2e-4b76-96e3-592071683630", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e1f4de89-0311-4b66-bb9e-75eb55e434e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuart30@yahoo.com", true, "Stuart", "Larson", false, null, "STUART30@YAHOO.COM", "STUART30@YAHOO.COM", "AF9ssLBDIVSQ8cP+lKBcLHLKFaZr248bJ7LMpc3B4xuud/wK/fNsSl3EHeoDizUcgQ==", "05111111111", false, "0f89b89b-f8cb-42ef-8ab5-8e1e00a77a96", false, "Stuart30@yahoo.com" },
                    { "f63dc90c-465b-4157-a8d1-8ff54736d9cb", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9f917c80-37e7-4c8f-b973-8dead1b6bebe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ella.Heller@gmail.com", true, "Ella", "Heller", false, null, "ELLA.HELLER@GMAIL.COM", "ELLA.HELLER@GMAIL.COM", "APdKgiRBIsbQKn9Ek3BQ+onW/0dx5TRT83eaGs+9YRDsrrITVboQS979yin9X0YNxg==", "05111111111", false, "fd45a70b-f4c3-47a5-9f75-f8a6ade1187d", false, "Ella.Heller@gmail.com" },
                    { "3fcd094d-fe33-4cf7-8728-a69be13eb323", 0, new Guid("00000000-0000-0000-0000-000000000000"), "a3bbe829-882a-4d56-97b6-20f60c865b0b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myron.Schmeler@yahoo.com", true, "Myron", "Schmeler", false, null, "MYRON.SCHMELER@YAHOO.COM", "MYRON.SCHMELER@YAHOO.COM", "ABp7RT4Qj0M4U4ygDqTR3bZZ77/aQx5gqAUEzxMQwJKTLWGScO1hT0d8UOFAniOptg==", "05111111111", false, "0bb23841-c42d-40f2-a669-c294154a92ab", false, "Myron.Schmeler@yahoo.com" },
                    { "6b512af0-fb2f-4d07-b052-eb04200b023f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "278541c0-b3ec-4acb-aaa2-ed13353af16a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randolph.Kreiger15@hotmail.com", true, "Randolph", "Kreiger", false, null, "RANDOLPH.KREIGER15@HOTMAIL.COM", "RANDOLPH.KREIGER15@HOTMAIL.COM", "ABT3qstY+PFmxy+7YoM7VUxEVqMeQgVrlre0dl+jXcQDdO7ArfRmrTsr1wkHuqkmsQ==", "05111111111", false, "2709849e-a1dd-4ef7-a454-66dbb4a6a68d", false, "Randolph.Kreiger15@hotmail.com" },
                    { "e976aa09-62d0-4d43-9a85-b3c6328ac75b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "ebda0751-6562-447f-89de-3380465a94ea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scott.Douglas86@yahoo.com", true, "Scott", "Douglas", false, null, "SCOTT.DOUGLAS86@YAHOO.COM", "SCOTT.DOUGLAS86@YAHOO.COM", "APpT2CsQbFvgw9BfTtFe04Z7DImpYY2eMrCIG8Zrih2IekHq7X5wRg00Plier3pzvA==", "05111111111", false, "2d0d3d51-e64f-4c02-880f-4410440ae570", false, "Scott.Douglas86@yahoo.com" },
                    { "1e80c629-cc52-4cdb-86f6-701d7dafabc1", 0, new Guid("00000000-0000-0000-0000-000000000000"), "4dd92691-5c7a-4ec2-ba1e-46c7cdf33a31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valilik@bilgehotel.com", true, "Bilge", "Hotel", false, null, "VALILIK@BILGEHOTEL.COM", "VALILIK@BILGEHOTEL.COM", "ACEmc7UGJLYpiOdN7Po9zvPfe6yBoA8fhS2dHzldACbKZY11uJ+SWKRYX22qJ0pz7Q==", "05111111111", false, "c8df8ffe-a9f7-4b3e-aaa5-39eafda4ab98", false, "valilik@bilgehotel.com" },
                    { "45f722a8-d6ed-462a-b94a-5a00f22a29bc", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5038c58f-2ecc-4b98-9e11-6aab5f73feee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lester_Bergstrom@hotmail.com", true, "Lester", "Bergstrom", false, null, "LESTER_BERGSTROM@HOTMAIL.COM", "LESTER_BERGSTROM@HOTMAIL.COM", "AFBEVMCXVkxs+Ln0HS55BAAHStxCmDV9o2grptGJQREspH2ASj7iY9GtQy31RjXdOg==", "05111111111", false, "e5cf9d82-9375-4008-a1f5-0e5adaabe1fd", false, "Lester_Bergstrom@hotmail.com" },
                    { "f521279c-a6cd-4676-bd1e-13c566729fb2", 0, new Guid("00000000-0000-0000-0000-000000000000"), "a74a7da6-f3e0-41ab-b55e-9c2aa1bbec8c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amber_Cronin@hotmail.com", true, "Amber", "Cronin", false, null, "AMBER_CRONIN@HOTMAIL.COM", "AMBER_CRONIN@HOTMAIL.COM", "ACSNhiKzJpNDrW8OoXuLsCucvsTpYGocMD4zgLcJ55v885YitgL2/4cduOGPHNLaxA==", "05111111111", false, "462a9564-70f6-4e7a-b1e4-247236321d2c", false, "Amber_Cronin@hotmail.com" },
                    { "6be611ed-5965-4645-ad54-49081b396a08", 0, new Guid("00000000-0000-0000-0000-000000000000"), "978058b2-eb6c-4308-9caf-1782a5ab33e6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel_Schamberger@hotmail.com", true, "Daniel", "Schamberger", false, null, "DANIEL_SCHAMBERGER@HOTMAIL.COM", "DANIEL_SCHAMBERGER@HOTMAIL.COM", "AMtu2GcpMWzn2etGXhBNaUnKz+m9qy06ncGsdgAJUF/kVIN1TdGo3shVnbvVekAx/g==", "05111111111", false, "a1e3921b-cd0f-45c4-9d03-4a6206411889", false, "Daniel_Schamberger@hotmail.com" },
                    { "755de770-7de1-48db-b7c1-1887177937cf", 0, new Guid("00000000-0000-0000-0000-000000000000"), "7249e846-fbd3-48d4-973f-d22f309d23ce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sally_OConnell@gmail.com", true, "Sally", "O'Connell", false, null, "SALLY_OCONNELL@GMAIL.COM", "SALLY_OCONNELL@GMAIL.COM", "AFY8+2aUdufHTL7umdn0Iin//8qvBFxKyT3Nd/l0yP5urV1yGMNLRsMmwRRrFQwofg==", "05111111111", false, "165dbfe9-8d71-4b50-9b4a-4a4202e37af7", false, "Sally_OConnell@gmail.com" },
                    { "591f8422-8282-4411-8ff9-3636a2a026f0", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e772417f-1f16-4441-afe1-0241ea24c646", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brooke19@gmail.com", true, "Brooke", "Mante", false, null, "BROOKE19@GMAIL.COM", "BROOKE19@GMAIL.COM", "AFBWfOEuI0pFvF+nwsK5nXS4uOP1U7GSvlhWwuI6Qbg4tn2bLKsW7RhgP+C7p6xLaA==", "05111111111", false, "801e7082-3ac4-4e3c-bab8-734924d23bde", false, "Brooke19@gmail.com" },
                    { "c6c9a895-e49d-44ba-8f6e-a286100b1227", 0, new Guid("00000000-0000-0000-0000-000000000000"), "82c14963-5fc3-4892-923b-3f0a1987c6fb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johanna_Kautzer76@yahoo.com", true, "Johanna", "Kautzer", false, null, "JOHANNA_KAUTZER76@YAHOO.COM", "JOHANNA_KAUTZER76@YAHOO.COM", "APQ4JyTi0wV16cWkW1BCVOuZ93kp8Q5NeDbjtwC0Pzuytw+l25HUU7wr5PY1c8vWpg==", "05111111111", false, "cf5197b2-eabd-4929-a9ed-9f4426e86c14", false, "Johanna_Kautzer76@yahoo.com" },
                    { "c7beaffb-22ab-4145-bf4f-c16ec16a4d84", 0, new Guid("00000000-0000-0000-0000-000000000000"), "27ff8e45-6ed2-4824-a089-db3273930a66", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimmy14@gmail.com", true, "Jimmy", "Lowe", false, null, "JIMMY14@GMAIL.COM", "JIMMY14@GMAIL.COM", "ACji9luWUxb/0/83SPf20jStvm9bv0RyD2ok+aeEWLrBlQdMVssFbkzpt7apk8QPxw==", "05111111111", false, "d9a84bc4-b252-44b9-b1b0-7b4b09854514", false, "Jimmy14@gmail.com" },
                    { "2e2591ee-68c3-4712-9c5b-97ee1f5a67bd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "458df8d4-b297-432e-a1c8-0b8717a5fef3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonia.Casper62@gmail.com", true, "Antonia", "Casper", false, null, "ANTONIA.CASPER62@GMAIL.COM", "ANTONIA.CASPER62@GMAIL.COM", "ALRnC6xs9fQZi8poWROsMJfseEGckf22OXuSTAZ8g2E4987agcDdi6HXAPxHPFNfKA==", "05111111111", false, "6f7d5150-d572-41f8-a68d-b530107a7ae1", false, "Antonia.Casper62@gmail.com" },
                    { "e20ebf82-e447-4cf4-8ab0-c5b3c1810f74", 0, new Guid("00000000-0000-0000-0000-000000000000"), "317c21fb-b43e-423b-83aa-96cde9b0939f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando53@gmail.com", true, "Fernando", "Senger", false, null, "FERNANDO53@GMAIL.COM", "FERNANDO53@GMAIL.COM", "AMgIQBw8tkYPiOcYifadFAj6+BpNXk7dZFueS7k8koFJ8g3u58JoRjQZVUFv5J0ZnQ==", "05111111111", false, "0ff60808-8cf5-4a90-a724-5c4074422787", false, "Fernando53@gmail.com" },
                    { "83006806-3b11-4e38-ade1-066208151af4", 0, new Guid("00000000-0000-0000-0000-000000000000"), "342c2435-4cee-4fd1-bac9-66dbf4e69f54", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlene_Feest@yahoo.com", true, "Arlene", "Feest", false, null, "ARLENE_FEEST@YAHOO.COM", "ARLENE_FEEST@YAHOO.COM", "AH26p6k5dclnZTliUWIS7MDnaU7vIsMt3dkmFdbL31EwJ8j6Tp9svWAPSXM5IiG1eQ==", "05111111111", false, "647e6bec-43db-4ea5-96d4-2b21ee5c0304", false, "Arlene_Feest@yahoo.com" },
                    { "fe7ac844-1eb9-43f8-a796-c2dca50c5d3d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "7c3f2d29-9db9-45d5-9420-bcc6176d9088", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan.Bahringer83@hotmail.com", true, "Megan", "Bahringer", false, null, "MEGAN.BAHRINGER83@HOTMAIL.COM", "MEGAN.BAHRINGER83@HOTMAIL.COM", "AERgal/VaXecNAGQpeececEHsO9f+53sMIzckzthA/ryxMpIMban+fn1hF+dp/au2Q==", "05111111111", false, "3208890c-d430-4c2b-84ce-c15ee63663c4", false, "Megan.Bahringer83@hotmail.com" },
                    { "1ce051a7-58fb-4f44-b360-63c6cbb31ab6", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1084430e-7f40-439d-a526-9a4c711b2dee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patti.Wiegand88@yahoo.com", true, "Patti", "Wiegand", false, null, "PATTI.WIEGAND88@YAHOO.COM", "PATTI.WIEGAND88@YAHOO.COM", "AGU2E3q6mBTpoDFL+xC4ZksXBvEo/kTZ/zraxV6IJc76lfUN6u4/3AOM86MyK3/VPg==", "05111111111", false, "907ab21e-9b0b-425c-a1ce-fe08b5cdf7c3", false, "Patti.Wiegand88@yahoo.com" },
                    { "3e5cb8d5-786b-4669-ad22-faa1f646a13c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5a2d332a-bb19-4138-9567-de2b0a96c10b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobbie.Kihn@hotmail.com", true, "Bobbie", "Kihn", false, null, "BOBBIE.KIHN@HOTMAIL.COM", "BOBBIE.KIHN@HOTMAIL.COM", "AEiQ8fz9RmpkCbK7/yieifLodt8woFhRWOD0/pWmDyePyutJgBrHRbvqxapPwbkwnA==", "05111111111", false, "39a0bad4-a991-4f1c-ac6b-bdc1ad56ef97", false, "Bobbie.Kihn@hotmail.com" },
                    { "bc79a5bb-b25d-4d6c-a13f-37ea4162a6d9", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1bce39bc-20fb-4127-91d4-8fd6fc28f03e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pat_Rippin@yahoo.com", true, "Pat", "Rippin", false, null, "PAT_RIPPIN@YAHOO.COM", "PAT_RIPPIN@YAHOO.COM", "AOgL0ie8wEWY8bwqpfjQOCaWDZdfaIZPI2D+F4chh7oqZ04HH2UxoAF0Yi6zkBJ5zA==", "05111111111", false, "2620e9f9-b1a0-4ba6-ab20-38dabd8a98b8", false, "Pat_Rippin@yahoo.com" },
                    { "ded6dcfc-1729-407b-8806-642767708015", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e1067813-ca8c-4d71-891f-e873c87e82a2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo_Wisozk@yahoo.com", true, "Guillermo", "Wisozk", false, null, "GUILLERMO_WISOZK@YAHOO.COM", "GUILLERMO_WISOZK@YAHOO.COM", "APqHfOvk/Soro1wZCKqdmXoginhesqj7fKUIc6faqlopOBqnr7pZFu0a2AP5fpMuiQ==", "05111111111", false, "97342ba3-d628-4118-a2b6-288cd2f2c290", false, "Guillermo_Wisozk@yahoo.com" },
                    { "3b76c08a-dcff-40f2-a6f3-c99796e9ecaa", 0, new Guid("00000000-0000-0000-0000-000000000000"), "837c8aa5-702c-448f-8ad5-857664d9c271", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wade53@hotmail.com", true, "Wade", "Rempel", false, null, "WADE53@HOTMAIL.COM", "WADE53@HOTMAIL.COM", "AEsgO1xpL/EXNpBl+g7/sY7Ie5sOf8+pdNenVGvGyMOA0ptcAXye/HhqsrpbdJwleg==", "05111111111", false, "452e10a5-2be7-4135-9a1f-185147d29066", false, "Wade53@hotmail.com" },
                    { "04cb22f0-d736-4eb6-9a4a-dc1a5c59cb19", 0, new Guid("00000000-0000-0000-0000-000000000000"), "759f69fe-93f8-490c-b0fc-a1ed082ecc9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alberto_Kreiger@hotmail.com", true, "Alberto", "Kreiger", false, null, "ALBERTO_KREIGER@HOTMAIL.COM", "ALBERTO_KREIGER@HOTMAIL.COM", "AIJonrcBnRmGuw6Pg4y8euvzhXtMQKR1w390IKwoPMt9vA9tmaUUS4683JWxSB/2MQ==", "05111111111", false, "e75fe27c-2585-411b-9376-b0d06e5634aa", false, "Alberto_Kreiger@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c57e708-748b-470b-8828-6638e1e1c798", 0, new Guid("00000000-0000-0000-0000-000000000000"), "505daf45-1ff6-4049-a486-ba2f73935d0d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alison_Keebler93@hotmail.com", true, "Alison", "Keebler", false, null, "ALISON_KEEBLER93@HOTMAIL.COM", "ALISON_KEEBLER93@HOTMAIL.COM", "AApl3UnVieII0AFbRNWngq1CSf4kd1BR07hLoFgkBblPU3xnQA4BgSmCtb2IbMcerQ==", "05111111111", false, "e104fc72-c422-4276-8ba1-f68f07e0e55c", false, "Alison_Keebler93@hotmail.com" },
                    { "9d1484d6-8231-46e1-ba56-2e83cc628929", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e6ae3982-e561-4e6e-ac8d-d60b211b8b14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karen_Kuvalis60@gmail.com", true, "Karen", "Kuvalis", false, null, "KAREN_KUVALIS60@GMAIL.COM", "KAREN_KUVALIS60@GMAIL.COM", "AIYJc/P9zeBZKHowfN2Tnc0CxiHpnfpB+1aw8/sAudzVqmoNpr8Qg8r2VoJpuleDzQ==", "05111111111", false, "903d92c0-4f8a-4113-8065-94c7cb759532", false, "Karen_Kuvalis60@gmail.com" },
                    { "deeb3ca7-1159-488c-8687-70ea52106fbe", 0, new Guid("00000000-0000-0000-0000-000000000000"), "7cbe78d2-99e0-4e0c-9d9a-ba41992053f1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earl.Welch54@yahoo.com", true, "Earl", "Welch", false, null, "EARL.WELCH54@YAHOO.COM", "EARL.WELCH54@YAHOO.COM", "APAO2JjoAA4u3E6qoTlSeTirFk93BvvJ/s71uPWCQmEERiAdqpvrl3nr5/I3KHwcPw==", "05111111111", false, "68a47680-21ee-4527-9ec8-e33c635c1d39", false, "Earl.Welch54@yahoo.com" },
                    { "8f154a5f-c7cf-4259-97e1-4de0a928fc90", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1a5a9a79-05e2-442c-87a9-42680c23c090", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sue.Schneider@hotmail.com", true, "Sue", "Schneider", false, null, "SUE.SCHNEIDER@HOTMAIL.COM", "SUE.SCHNEIDER@HOTMAIL.COM", "AG+A2J2MMRb7zNec47cRYojMCOe2g5Z11VnCczgeOcEyRb67K0nDT3qROkokd024NQ==", "05111111111", false, "ebb6d551-3bca-4d9d-8450-30451683bc10", false, "Sue.Schneider@hotmail.com" },
                    { "137a4112-474b-43e8-b6cf-41740a2fc689", 0, new Guid("00000000-0000-0000-0000-000000000000"), "91363cc5-6ab7-4497-bf3a-3ca44aef38e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naomi.Maggio86@hotmail.com", true, "Naomi", "Maggio", false, null, "NAOMI.MAGGIO86@HOTMAIL.COM", "NAOMI.MAGGIO86@HOTMAIL.COM", "APx3iL3N090vU+8j1OsO5xfcSQ8fsaGC9DVWKM2PYIeQwojpCEqY5mdufNXCH/NsHw==", "05111111111", false, "4a42d8fb-e4a3-4f33-92e8-52c2f6038459", false, "Naomi.Maggio86@hotmail.com" },
                    { "e04c62ec-8f9d-44e7-9082-e7e956dbd6bf", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e5fbb94c-8a51-4773-a5fa-23fb82676ca6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joey.Grady66@gmail.com", true, "Joey", "Grady", false, null, "JOEY.GRADY66@GMAIL.COM", "JOEY.GRADY66@GMAIL.COM", "AEZpetvFZZxGmmVb4FmPzzwLTmbNbdLx2TS70XVFCxdSMnMfmanjJh/jM+2aa5whbA==", "05111111111", false, "a8e27fc1-954e-45fc-a485-ed43b440cb77", false, "Joey.Grady66@gmail.com" },
                    { "d112a06f-8e4d-4044-9aad-178062911246", 0, new Guid("00000000-0000-0000-0000-000000000000"), "2906c873-0c5f-483c-b483-f164a71b6ba0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura63@hotmail.com", true, "Laura", "Boyer", false, null, "LAURA63@HOTMAIL.COM", "LAURA63@HOTMAIL.COM", "AHqDUlJ60lQQCdrhjSVwGLny/Z3PDdfcOtA3dWdVm36pt/AYCg1Jr/6WNYw5hfQoxw==", "05111111111", false, "d1193a82-0306-477f-9231-55c1af5b2972", false, "Laura63@hotmail.com" },
                    { "70ce3c90-0c15-48dc-9dd8-4d49964ae12e", 0, new Guid("00000000-0000-0000-0000-000000000000"), "3258e71d-9ec3-4924-a92b-c5d844105617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando.Gerlach44@hotmail.com", true, "Fernando", "Gerlach", false, null, "FERNANDO.GERLACH44@HOTMAIL.COM", "FERNANDO.GERLACH44@HOTMAIL.COM", "AN/3CG47u4Acest1CTV0NxZaQn4a9JUIF9hOMAdldWDK+jzkRtD4rPuPfXi0iXPs3g==", "05111111111", false, "1eac8284-23ba-4e28-b5f2-b4339705413e", false, "Fernando.Gerlach44@hotmail.com" },
                    { "b449f45d-d116-409f-a2e7-ee4804586c17", 0, new Guid("00000000-0000-0000-0000-000000000000"), "c070aeb0-5433-43c4-9672-8e7474c15f88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pat_White10@hotmail.com", true, "Pat", "White", false, null, "PAT_WHITE10@HOTMAIL.COM", "PAT_WHITE10@HOTMAIL.COM", "AHklZIELCRggvxemJG5p6mLz6RnvE1Q9C5BJuD0bPKq0QjGIRBCXSIZqrfALtaEj7w==", "05111111111", false, "913fc5e7-6efb-4111-b077-e00b112c7ac8", false, "Pat_White10@hotmail.com" },
                    { "e1ce5677-bc86-43b3-a02e-c8b33b509684", 0, new Guid("00000000-0000-0000-0000-000000000000"), "cf0d0d98-c37c-4eb4-a2af-25d4897ca755", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eileen7@gmail.com", true, "Eileen", "Leffler", false, null, "EILEEN7@GMAIL.COM", "EILEEN7@GMAIL.COM", "AJdx+g2DvZ227uRUvUSMT016ZtKtUPBn9Yy0HSJgKA4ds952p7fYxP4MiXNfTsz+ow==", "05111111111", false, "8164a83c-54b0-4fc3-8d95-025e47bf29df", false, "Eileen7@gmail.com" },
                    { "6adaf8d9-00bd-448a-943d-06400f673f7a", 0, new Guid("00000000-0000-0000-0000-000000000000"), "91052bc7-3afb-4086-b4df-5e3c6e78aa54", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brenda_Waelchi89@gmail.com", true, "Brenda", "Waelchi", false, null, "BRENDA_WAELCHI89@GMAIL.COM", "BRENDA_WAELCHI89@GMAIL.COM", "APn1+oa6TbyoWgDRX/x3TpjRuFF8pVE0QWFYhzgrWErZDdxoU5s4SziE/JMHLm+9Mg==", "05111111111", false, "fb4a118d-dcd7-45c0-aaa2-7e0a074409a8", false, "Brenda_Waelchi89@gmail.com" },
                    { "4ee607fe-f560-452d-a33d-96f99d829909", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5db264a9-00e6-4ce4-84e2-38b404dcfccc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fred96@gmail.com", true, "Fred", "Haag", false, null, "FRED96@GMAIL.COM", "FRED96@GMAIL.COM", "ALOAjAGsT4ZpgRe77gvFqxSlX5gXlTOrpzP/U8O4n+lzida8fTWiVnXJquSJ9blLXA==", "05111111111", false, "087c3dfa-04e0-4209-8811-c5a1939cfaeb", false, "Fred96@gmail.com" },
                    { "f85bf20b-f70f-4641-861e-dd2b1b1e9cfb", 0, new Guid("00000000-0000-0000-0000-000000000000"), "240bf08c-a31b-41f2-bab6-487837f8d690", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Betsy42@gmail.com", true, "Betsy", "Satterfield", false, null, "BETSY42@GMAIL.COM", "BETSY42@GMAIL.COM", "AFDmtCiMEjfll7N4h8CmUvIqjZHkdSUAVnDi/kPIVhKgsaP4NBsUKak/GWeZNWmbHg==", "05111111111", false, "f5d7946a-72c2-42db-99d9-d94ed776bd0f", false, "Betsy42@gmail.com" },
                    { "b21b08ee-5a0d-4955-9df9-48a6214555ab", 0, new Guid("00000000-0000-0000-0000-000000000000"), "c4c2c35f-4e34-4413-98cf-b0b74dbcbed1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zachary_Schoen@hotmail.com", true, "Zachary", "Schoen", false, null, "ZACHARY_SCHOEN@HOTMAIL.COM", "ZACHARY_SCHOEN@HOTMAIL.COM", "AMh0Levo3+GgT7ibOc/CrJe8ZhqCa+D2BtvGQ0KGToVjLCzTTb3UgxZBlHTTQ7pj0A==", "05111111111", false, "91ad669e-9c72-4e13-b682-539d9f482891", false, "Zachary_Schoen@hotmail.com" },
                    { "2cf041c9-180d-4016-bc3f-ac1da78324c6", 0, new Guid("00000000-0000-0000-0000-000000000000"), "50dd8943-3997-45fa-94ac-386f8a039331", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Herman_Christiansen@hotmail.com", true, "Herman", "Christiansen", false, null, "HERMAN_CHRISTIANSEN@HOTMAIL.COM", "HERMAN_CHRISTIANSEN@HOTMAIL.COM", "AKTYQHg3tU9C0X8NWD940BMYo8tnUz5MgDO/qgCON6lUEFh8O3JRcwRoYZrMMcKLmg==", "05111111111", false, "2bdb945d-25dd-41ed-b29a-0557c875c10e", false, "Herman_Christiansen@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Email", "Facebook", "Fax", "Instagram", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "1010 Aidan Cliffs, Rosendomouth, El Salvador", null, null, null, null, null, "Bill95@gmail.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, null, null, null, null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

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
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "1e80c629-cc52-4cdb-86f6-701d7dafabc1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e1ce5677-bc86-43b3-a02e-c8b33b509684" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6adaf8d9-00bd-448a-943d-06400f673f7a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4ee607fe-f560-452d-a33d-96f99d829909" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f85bf20b-f70f-4641-861e-dd2b1b1e9cfb" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "deeb3ca7-1159-488c-8687-70ea52106fbe" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e20ebf82-e447-4cf4-8ab0-c5b3c1810f74" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f63dc90c-465b-4157-a8d1-8ff54736d9cb" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "74afca61-8921-485e-a50c-4909f64823a3" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "157448a9-6bfc-44a8-8949-00d55f0cf106" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "eaf38669-9232-4bdf-a42b-0be01f42d17c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c70735fd-7815-4690-9df2-221392f96826" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9d08f0fb-be8b-428a-9bf1-7987706187e7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c268e84c-c4b9-4cce-9fad-7a50e7de1c39" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "632e4d14-c323-454d-84ae-fc770f0e8c19" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f8dc1a85-39da-4cb2-b5b3-9e32e35ab988" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "eb2a6164-1f2e-4b76-96e3-592071683630" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3fcd094d-fe33-4cf7-8728-a69be13eb323" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c7beaffb-22ab-4145-bf4f-c16ec16a4d84" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e976aa09-62d0-4d43-9a85-b3c6328ac75b" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b449f45d-d116-409f-a2e7-ee4804586c17" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "f521279c-a6cd-4676-bd1e-13c566729fb2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "70ce3c90-0c15-48dc-9dd8-4d49964ae12e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e04c62ec-8f9d-44e7-9082-e7e956dbd6bf" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f521279c-a6cd-4676-bd1e-13c566729fb2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6be611ed-5965-4645-ad54-49081b396a08" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "755de770-7de1-48db-b7c1-1887177937cf" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "591f8422-8282-4411-8ff9-3636a2a026f0" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2e2591ee-68c3-4712-9c5b-97ee1f5a67bd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2cf041c9-180d-4016-bc3f-ac1da78324c6" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "45f722a8-d6ed-462a-b94a-5a00f22a29bc" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c6c9a895-e49d-44ba-8f6e-a286100b1227" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a871e5c7-0733-4124-801a-fb0ea09d3971" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "fe7ac844-1eb9-43f8-a796-c2dca50c5d3d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1ce051a7-58fb-4f44-b360-63c6cbb31ab6" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3e5cb8d5-786b-4669-ad22-faa1f646a13c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bc79a5bb-b25d-4d6c-a13f-37ea4162a6d9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ded6dcfc-1729-407b-8806-642767708015" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3b76c08a-dcff-40f2-a6f3-c99796e9ecaa" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "04cb22f0-d736-4eb6-9a4a-dc1a5c59cb19" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2c57e708-748b-470b-8828-6638e1e1c798" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9d1484d6-8231-46e1-ba56-2e83cc628929" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8f154a5f-c7cf-4259-97e1-4de0a928fc90" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b21b08ee-5a0d-4955-9df9-48a6214555ab" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "137a4112-474b-43e8-b6cf-41740a2fc689" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d112a06f-8e4d-4044-9aad-178062911246" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "6be611ed-5965-4645-ad54-49081b396a08" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "83006806-3b11-4e38-ade1-066208151af4" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "591f8422-8282-4411-8ff9-3636a2a026f0" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "d112a06f-8e4d-4044-9aad-178062911246" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "70ce3c90-0c15-48dc-9dd8-4d49964ae12e" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b449f45d-d116-409f-a2e7-ee4804586c17" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e1ce5677-bc86-43b3-a02e-c8b33b509684" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6adaf8d9-00bd-448a-943d-06400f673f7a" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4ee607fe-f560-452d-a33d-96f99d829909" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f85bf20b-f70f-4641-861e-dd2b1b1e9cfb" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "83006806-3b11-4e38-ade1-066208151af4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "deeb3ca7-1159-488c-8687-70ea52106fbe" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e20ebf82-e447-4cf4-8ab0-c5b3c1810f74" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e04c62ec-8f9d-44e7-9082-e7e956dbd6bf" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f63dc90c-465b-4157-a8d1-8ff54736d9cb" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "157448a9-6bfc-44a8-8949-00d55f0cf106" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "eaf38669-9232-4bdf-a42b-0be01f42d17c" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c70735fd-7815-4690-9df2-221392f96826" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "9d08f0fb-be8b-428a-9bf1-7987706187e7" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c268e84c-c4b9-4cce-9fad-7a50e7de1c39" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "755de770-7de1-48db-b7c1-1887177937cf" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f8dc1a85-39da-4cb2-b5b3-9e32e35ab988" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "eb2a6164-1f2e-4b76-96e3-592071683630" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "74afca61-8921-485e-a50c-4909f64823a3" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "137a4112-474b-43e8-b6cf-41740a2fc689" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "632e4d14-c323-454d-84ae-fc770f0e8c19" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "8f154a5f-c7cf-4259-97e1-4de0a928fc90" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b21b08ee-5a0d-4955-9df9-48a6214555ab" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "2e2591ee-68c3-4712-9c5b-97ee1f5a67bd" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "2cf041c9-180d-4016-bc3f-ac1da78324c6" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "45f722a8-d6ed-462a-b94a-5a00f22a29bc" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "e976aa09-62d0-4d43-9a85-b3c6328ac75b" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "c6c9a895-e49d-44ba-8f6e-a286100b1227" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "a871e5c7-0733-4124-801a-fb0ea09d3971" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "fe7ac844-1eb9-43f8-a796-c2dca50c5d3d" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "1ce051a7-58fb-4f44-b360-63c6cbb31ab6" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "e976aa09-62d0-4d43-9a85-b3c6328ac75b" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "bc79a5bb-b25d-4d6c-a13f-37ea4162a6d9" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3e5cb8d5-786b-4669-ad22-faa1f646a13c" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "c7beaffb-22ab-4145-bf4f-c16ec16a4d84" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3fcd094d-fe33-4cf7-8728-a69be13eb323" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "9d1484d6-8231-46e1-ba56-2e83cc628929" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "6b512af0-fb2f-4d07-b052-eb04200b023f" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "04cb22f0-d736-4eb6-9a4a-dc1a5c59cb19" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3b76c08a-dcff-40f2-a6f3-c99796e9ecaa" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "ded6dcfc-1729-407b-8806-642767708015" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "2c57e708-748b-470b-8828-6638e1e1c798" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "6b512af0-fb2f-4d07-b052-eb04200b023f" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "c7beaffb-22ab-4145-bf4f-c16ec16a4d84", null, null, null, null, null, 2, "Jimmy14@gmail.com", 3, "Jimmy", 198.610372910560280m, "6523", true, "Lowe", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 12, 25, 22, 29, 15, 49, DateTimeKind.Unspecified).AddTicks(656), "Bilgi İşlem Sorumlusu" },
                    { 32, "e20ebf82-e447-4cf4-8ab0-c5b3c1810f74", null, null, null, null, null, 3, "Fernando53@gmail.com", 3, "Fernando", 192.385299593389640m, "3267", true, "Senger", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 11, 20, 0, 56, 12, 466, DateTimeKind.Unspecified).AddTicks(9028), "Garson" },
                    { 43, "3fcd094d-fe33-4cf7-8728-a69be13eb323", null, null, null, null, null, 1, "Myron.Schmeler@yahoo.com", 3, "Myron", 193.45763701175230m, "9732", true, "Schmeler", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 7, 31, 6, 44, 24, 909, DateTimeKind.Unspecified).AddTicks(6489), "Elektirikçi" },
                    { 36, "eaf38669-9232-4bdf-a42b-0be01f42d17c", null, null, null, null, null, 3, "Guillermo.Homenick28@yahoo.com", 3, "Guillermo", 193.808230652384570m, "9690", true, "Homenick", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 5, 28, 10, 33, 45, 363, DateTimeKind.Unspecified).AddTicks(2059), "Garson" },
                    { 35, "157448a9-6bfc-44a8-8949-00d55f0cf106", null, null, null, null, null, 3, "Allan_Zboncak@yahoo.com", 3, "Allan", 195.193733854775190m, "5536", true, "Zboncak", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 8, 9, 8, 15, 3, 277, DateTimeKind.Unspecified).AddTicks(490), "Garson" },
                    { 34, "74afca61-8921-485e-a50c-4909f64823a3", null, null, null, null, null, 3, "Cristina56@hotmail.com", 3, "Cristina", 190.4885816483239560m, "5162", true, "Paucek", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 7, 31, 0, 53, 51, 108, DateTimeKind.Unspecified).AddTicks(9591), "Garson" },
                    { 33, "f63dc90c-465b-4157-a8d1-8ff54736d9cb", null, null, null, null, null, 3, "Ella.Heller@gmail.com", 3, "Ella", 194.641657008156950m, "5145", true, "Heller", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 1, 28, 19, 57, 47, 796, DateTimeKind.Unspecified).AddTicks(7296), "Garson" },
                    { 23, "d112a06f-8e4d-4044-9aad-178062911246", null, null, null, null, null, 3, "Laura63@hotmail.com", 3, "Laura", 190.802847892419830m, "4304", true, "Boyer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 8, 6, 9, 35, 53, 58, DateTimeKind.Unspecified).AddTicks(2325), "Aşçı" },
                    { 30, "83006806-3b11-4e38-ade1-066208151af4", null, null, null, null, null, 3, "Arlene_Feest@yahoo.com", 3, "Arlene", 190.9334278995792510m, "7187", true, "Feest", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 5, 18, 0, 39, 15, 815, DateTimeKind.Unspecified).AddTicks(3891), "Garson" },
                    { 24, "70ce3c90-0c15-48dc-9dd8-4d49964ae12e", null, null, null, null, null, 3, "Fernando.Gerlach44@hotmail.com", 3, "Fernando", 199.839673275053350m, "8884", true, "Gerlach", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 1, 14, 0, 41, 42, 482, DateTimeKind.Unspecified).AddTicks(1897), "Aşçı" },
                    { 45, "6b512af0-fb2f-4d07-b052-eb04200b023f", null, null, null, null, null, 5, "Randolph.Kreiger15@hotmail.com", 0, "Randolph", 191.91857128027760m, "4362", true, "Kreiger", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 5, 16, 9, 53, 41, 909, DateTimeKind.Unspecified).AddTicks(551), "Müdür" },
                    { 22, "e04c62ec-8f9d-44e7-9082-e7e956dbd6bf", null, null, null, null, null, 3, "Joey.Grady66@gmail.com", 3, "Joey", 199.043196374104910m, "1358", true, "Grady", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 1, 29, 14, 37, 2, 885, DateTimeKind.Unspecified).AddTicks(6292), "Aşçı" },
                    { 21, "137a4112-474b-43e8-b6cf-41740a2fc689", null, null, null, null, null, 3, "Naomi.Maggio86@hotmail.com", 3, "Naomi", 198.704200721673760m, "5711", true, "Maggio", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 7, 3, 1, 14, 54, 906, DateTimeKind.Unspecified).AddTicks(5490), "Aşçı" },
                    { 20, "b21b08ee-5a0d-4955-9df9-48a6214555ab", null, null, null, null, null, 3, "Zachary_Schoen@hotmail.com", 3, "Zachary", 192.516712687218890m, "8075", true, "Schoen", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 3, 18, 15, 30, 15, 222, DateTimeKind.Unspecified).AddTicks(1459), "Aşçı" },
                    { 19, "8f154a5f-c7cf-4259-97e1-4de0a928fc90", null, null, null, null, null, 3, "Sue.Schneider@hotmail.com", 3, "Sue", 193.190725740599780m, "2396", true, "Schneider", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 5, 12, 9, 17, 47, 526, DateTimeKind.Unspecified).AddTicks(2773), "Aşçı" },
                    { 13, "bc79a5bb-b25d-4d6c-a13f-37ea4162a6d9", null, null, null, null, null, 1, "Pat_Rippin@yahoo.com", 3, "Pat", 191.751698172535610m, "6861", true, "Rippin", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 7, 2, 4, 27, 42, 133, DateTimeKind.Unspecified).AddTicks(4074), "Temizlik Görevlisi" },
                    { 31, "deeb3ca7-1159-488c-8687-70ea52106fbe", null, null, null, null, null, 3, "Earl.Welch54@yahoo.com", 3, "Earl", 199.574965555022920m, "9935", true, "Welch", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 1, 21, 1, 28, 33, 573, DateTimeKind.Unspecified).AddTicks(3283), "Garson" },
                    { 46, "e976aa09-62d0-4d43-9a85-b3c6328ac75b", null, null, null, null, null, 6, "Scott.Douglas86@yahoo.com", 1, "Scott", 195.126984615403690m, "9323", true, "Douglas", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 11, 7, 12, 54, 34, 868, DateTimeKind.Unspecified).AddTicks(7645), "İnsan Kaynakları Müdürü" },
                    { 17, "2c57e708-748b-470b-8828-6638e1e1c798", null, null, null, null, null, 1, "Alison_Keebler93@hotmail.com", 3, "Alison", 197.455390033989860m, "3805", true, "Keebler", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 5, 7, 15, 2, 3, 782, DateTimeKind.Unspecified).AddTicks(3091), "Temizlik Görevlisi" },
                    { 5, "2e2591ee-68c3-4712-9c5b-97ee1f5a67bd", null, null, null, null, null, 4, "Antonia.Casper62@gmail.com", 3, "Antonia", 197.548477797558750m, "8740", true, "Casper", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 2, 13, 0, 23, 7, 369, DateTimeKind.Unspecified).AddTicks(3850), "Resepsiyonist" },
                    { 12, "3e5cb8d5-786b-4669-ad22-faa1f646a13c", null, null, null, null, null, 1, "Bobbie.Kihn@hotmail.com", 3, "Bobbie", 196.728418593634120m, "5174", true, "Kihn", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 9, 1, 22, 57, 224, DateTimeKind.Unspecified).AddTicks(5266), "Temizlik Görevlisi" },
                    { 7, "45f722a8-d6ed-462a-b94a-5a00f22a29bc", null, null, null, null, null, 4, "Lester_Bergstrom@hotmail.com", 3, "Lester", 197.16123404780460m, "1652", true, "Bergstrom", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2021, 12, 24, 4, 16, 3, 201, DateTimeKind.Unspecified).AddTicks(5996), "Resepsiyonist" },
                    { 6, "2cf041c9-180d-4016-bc3f-ac1da78324c6", null, null, null, null, null, 4, "Herman_Christiansen@hotmail.com", 3, "Herman", 190.4186320260253880m, "9263", true, "Christiansen", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2020, 12, 3, 2, 9, 42, 92, DateTimeKind.Unspecified).AddTicks(7696), "Resepsiyonist" },
                    { 42, "eb2a6164-1f2e-4b76-96e3-592071683630", null, null, null, null, null, 3, "Stuart30@yahoo.com", 3, "Stuart", 193.788724692440m, "6346", true, "Larson", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 15, 2, 57, 11, 270, DateTimeKind.Unspecified).AddTicks(8675), "Garson" },
                    { 41, "f8dc1a85-39da-4cb2-b5b3-9e32e35ab988", null, null, null, null, null, 3, "Al_Boyer@yahoo.com", 3, "Al", 190.1256879047144610m, "6655", true, "Boyer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 9, 22, 23, 59, 55, 816, DateTimeKind.Unspecified).AddTicks(6108), "Garson" },
                    { 40, "632e4d14-c323-454d-84ae-fc770f0e8c19", null, null, null, null, null, 3, "Rochelle.Wyman79@hotmail.com", 3, "Rochelle", 193.532962213984210m, "2305", true, "Wyman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 8, 24, 20, 14, 22, 250, DateTimeKind.Unspecified).AddTicks(3306), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "c268e84c-c4b9-4cce-9fad-7a50e7de1c39", null, null, null, null, null, 3, "Kevin97@hotmail.com", 3, "Kevin", 197.42294277410160m, "1537", true, "Kuhlman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 6, 16, 1, 33, 9, 502, DateTimeKind.Unspecified).AddTicks(5722), "Garson" },
                    { 38, "9d08f0fb-be8b-428a-9bf1-7987706187e7", null, null, null, null, null, 3, "Alfredo.Roberts@gmail.com", 3, "Alfredo", 199.560083937626370m, "6601", true, "Roberts", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 7, 25, 20, 24, 5, 564, DateTimeKind.Unspecified).AddTicks(6549), "Garson" },
                    { 37, "c70735fd-7815-4690-9df2-221392f96826", null, null, null, null, null, 3, "Nichole0@gmail.com", 3, "Nichole", 197.294092959395650m, "1227", true, "Smith", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 26, 19, 30, 32, 635, DateTimeKind.Unspecified).AddTicks(5861), "Garson" },
                    { 28, "4ee607fe-f560-452d-a33d-96f99d829909", null, null, null, null, null, 3, "Fred96@gmail.com", 3, "Fred", 194.218671440248690m, "8854", true, "Haag", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 6, 9, 6, 41, 11, 312, DateTimeKind.Unspecified).AddTicks(8371), "Aşçı" },
                    { 27, "6adaf8d9-00bd-448a-943d-06400f673f7a", null, null, null, null, null, 3, "Brenda_Waelchi89@gmail.com", 3, "Brenda", 191.026429450617370m, "1692", true, "Waelchi", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 2, 12, 21, 49, 15, 181, DateTimeKind.Unspecified).AddTicks(7791), "Aşçı" },
                    { 26, "e1ce5677-bc86-43b3-a02e-c8b33b509684", null, null, null, null, null, 3, "Eileen7@gmail.com", 3, "Eileen", 196.546679882587250m, "1801", true, "Leffler", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 14, 15, 18, 30, 999, DateTimeKind.Unspecified).AddTicks(656), "Aşçı" },
                    { 25, "b449f45d-d116-409f-a2e7-ee4804586c17", null, null, null, null, null, 3, "Pat_White10@hotmail.com", 3, "Pat", 196.996481519656480m, "5513", true, "White", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 5, 5, 4, 26, 27, 632, DateTimeKind.Unspecified).AddTicks(4490), "Aşçı" },
                    { 18, "9d1484d6-8231-46e1-ba56-2e83cc628929", null, null, null, null, null, 1, "Karen_Kuvalis60@gmail.com", 3, "Karen", 197.530310460147590m, "2243", true, "Kuvalis", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 6, 5, 4, 56, 45, 604, DateTimeKind.Unspecified).AddTicks(1708), "Temizlik Görevlisi" },
                    { 16, "04cb22f0-d736-4eb6-9a4a-dc1a5c59cb19", null, null, null, null, null, 1, "Alberto_Kreiger@hotmail.com", 3, "Alberto", 196.356326894069240m, "9151", true, "Kreiger", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 3, 10, 5, 58, 44, 876, DateTimeKind.Unspecified).AddTicks(248), "Temizlik Görevlisi" },
                    { 15, "3b76c08a-dcff-40f2-a6f3-c99796e9ecaa", null, null, null, null, null, 1, "Wade53@hotmail.com", 3, "Wade", 196.697028701518210m, "6823", true, "Rempel", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 7, 22, 17, 48, 26, 436, DateTimeKind.Unspecified).AddTicks(1626), "Temizlik Görevlisi" },
                    { 14, "ded6dcfc-1729-407b-8806-642767708015", null, null, null, null, null, 1, "Guillermo_Wisozk@yahoo.com", 3, "Guillermo", 197.66227410997370m, "6321", true, "Wisozk", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 14, 20, 27, 55, 599, DateTimeKind.Unspecified).AddTicks(4207), "Temizlik Görevlisi" },
                    { 4, "591f8422-8282-4411-8ff9-3636a2a026f0", null, null, null, null, null, 4, "Brooke19@gmail.com", 3, "Brooke", 197.527081392485220m, "1690", true, "Mante", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 7, 23, 14, 24, 46, 488, DateTimeKind.Unspecified).AddTicks(6823), "Resepsiyonist" },
                    { 29, "f85bf20b-f70f-4641-861e-dd2b1b1e9cfb", null, null, null, null, null, 3, "Betsy42@gmail.com", 3, "Betsy", 196.099911539861890m, "3370", true, "Satterfield", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 8, 1, 6, 41, 10, 12, DateTimeKind.Unspecified).AddTicks(8032), "Aşçı" },
                    { 11, "1ce051a7-58fb-4f44-b360-63c6cbb31ab6", null, null, null, null, null, 1, "Patti.Wiegand88@yahoo.com", 3, "Patti", 197.797566753717870m, "9870", true, "Wiegand", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 6, 24, 18, 49, 45, 679, DateTimeKind.Unspecified).AddTicks(3552), "Temizlik Görevlisi" },
                    { 9, "a871e5c7-0733-4124-801a-fb0ea09d3971", null, null, null, null, null, 1, "Henrietta57@hotmail.com", 3, "Henrietta", 198.742714705291540m, "2988", true, "Hane", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 12, 1, 3, 36, 55, 30, DateTimeKind.Unspecified).AddTicks(2332), "Temizlik Görevlisi" },
                    { 8, "c6c9a895-e49d-44ba-8f6e-a286100b1227", null, null, null, null, null, 1, "Johanna_Kautzer76@yahoo.com", 3, "Johanna", 190.9844739972541450m, "8733", true, "Kautzer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 11, 28, 18, 45, 42, 873, DateTimeKind.Unspecified).AddTicks(2144), "Temizlik Görevlisi" },
                    { 3, "755de770-7de1-48db-b7c1-1887177937cf", null, null, null, null, null, 4, "Sally_OConnell@gmail.com", 3, "Sally", 190.5939387393155780m, "5268", true, "O'Connell", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 9, 14, 14, 51, 37, 800, DateTimeKind.Unspecified).AddTicks(3115), "Resepsiyonist" },
                    { 2, "6be611ed-5965-4645-ad54-49081b396a08", null, null, null, null, null, 4, "Daniel_Schamberger@hotmail.com", 3, "Daniel", 197.837629433645690m, "9918", true, "Schamberger", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 5, 27, 6, 10, 51, 292, DateTimeKind.Unspecified).AddTicks(8290), "Resepsiyonist" },
                    { 1, "f521279c-a6cd-4676-bd1e-13c566729fb2", null, null, null, null, null, 4, "Amber_Cronin@hotmail.com", 3, "Amber", 199.352841167409360m, "3215", true, "Cronin", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 8, 27, 20, 49, 2, 977, DateTimeKind.Unspecified).AddTicks(6485), "Resepsiyonist" },
                    { 10, "fe7ac844-1eb9-43f8-a796-c2dca50c5d3d", null, null, null, null, null, 1, "Megan.Bahringer83@hotmail.com", 3, "Megan", 198.467489647896720m, "8993", true, "Bahringer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 12, 28, 17, 1, 53, 583, DateTimeKind.Unspecified).AddTicks(9623), "Temizlik Görevlisi" }
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
