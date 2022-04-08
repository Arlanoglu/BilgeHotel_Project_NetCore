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
                    IncomeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c3933fcc-23a0-4a51-bdd6-956d4390209a", "mutfak", "MUTFAK" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "cc262816-8c33-471d-bc46-bef20e18ad44", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "640cb6e8-6d8b-40cd-adbc-01eb6a12bba0", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "4699ccba-eaee-46a3-8cd7-1e7d88781e18", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "fecc5393-f14f-4c4b-a7f1-158a601154e5", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "09d9c0b2-5946-4e6c-963d-1ce1d561e819", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a0dff476-2dc9-4bc6-b93b-db66e3183a2b", "user", "USER" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "af9eb8fb-c8bf-417d-86a2-cf88e8fe7845", "muhasebe", "MUHASEBE" },
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "9ee324c1-0111-4964-ac1e-042132da5fb3", "valilik", "VALILIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bead453e-fd54-43d5-9669-714315989044", 0, new Guid("00000000-0000-0000-0000-000000000000"), "aa64fccc-a4d1-444e-9346-9796f8685430", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edmond_DuBuque72@yahoo.com", true, "Edmond", "DuBuque", false, null, "EDMOND_DUBUQUE72@YAHOO.COM", "EDMOND_DUBUQUE72@YAHOO.COM", "AN0/KOrfdXl8bqhk7VZm3bhVUfAVCc4OlUeAmnJW/tTRqID4UPVW6pSBU5bttjH04w==", "05111111111", false, "d4c118a1-1a62-40f0-99eb-4b9654516bc2", false, "Edmond_DuBuque72@yahoo.com" },
                    { "b7186e2c-844a-4c8c-b322-57d22066c7d4", 0, new Guid("00000000-0000-0000-0000-000000000000"), "d6ce5820-a225-4bac-ab0a-6e02c73ecb1f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annette.Luettgen@gmail.com", true, "Annette", "Luettgen", false, null, "ANNETTE.LUETTGEN@GMAIL.COM", "ANNETTE.LUETTGEN@GMAIL.COM", "ADo5x7NOxz+Pkcom1hctl9OwbHf6pBDv+o+U4mf7YZsKTepD1YhPzxvTYGnMwGv+5w==", "05111111111", false, "b638bf9f-436e-4eb0-b387-6977974491d4", false, "Annette.Luettgen@gmail.com" },
                    { "301ef378-2291-4297-b1d5-01bd6ac4881d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "ae044862-4399-4375-b844-7baa890a1b86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joy.Jones2@yahoo.com", true, "Joy", "Jones", false, null, "JOY.JONES2@YAHOO.COM", "JOY.JONES2@YAHOO.COM", "AD387dpwUF5JkGz019oI7gO3MfqVlvcylN161dpHjE0VVoHAEGeGHi5I++pYkasZpg==", "05111111111", false, "ac28046d-8fd8-49ba-a3a5-bc826d5d5c2c", false, "Joy.Jones2@yahoo.com" },
                    { "6f19cb42-19e6-4b1f-a08e-52ed25062e91", 0, new Guid("00000000-0000-0000-0000-000000000000"), "fecb6a94-46c9-4fe3-88ff-f390470c1cd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esther.Klein76@yahoo.com", true, "Esther", "Klein", false, null, "ESTHER.KLEIN76@YAHOO.COM", "ESTHER.KLEIN76@YAHOO.COM", "ABIje4OGgO33rgIyxP595cmXWPnZJSpdlDfAolNCcJTyX0HtT0ar4Uo4tq9NpXZDlQ==", "05111111111", false, "9b2e765e-4f8b-47ad-a4a4-86ab4d79aa52", false, "Esther.Klein76@yahoo.com" },
                    { "405a073f-1e16-4b99-93bf-4d8cc8e439e7", 0, new Guid("00000000-0000-0000-0000-000000000000"), "412da0da-ad22-4623-90f7-58e7329ce96c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresa_Schoen5@gmail.com", true, "Theresa", "Schoen", false, null, "THERESA_SCHOEN5@GMAIL.COM", "THERESA_SCHOEN5@GMAIL.COM", "AOAhLqJXGdRb6RomplnDKH0sNz7z/Eq35Ei5yHhAsYucDmGt/5JshsbD7rlDLJdJbw==", "05111111111", false, "f302b8b7-1385-45ad-bf1b-1301a45ed7ad", false, "Theresa_Schoen5@gmail.com" },
                    { "e74d272e-acdb-45a8-9557-ccd768adf99c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e8cd0b81-21f0-47f0-8365-fc8dd1bad2f7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisy76@yahoo.com", true, "Daisy", "Douglas", false, null, "DAISY76@YAHOO.COM", "DAISY76@YAHOO.COM", "AO9y8z21iFDKMb8d3E7egXKPF0q0s4E9qNjrjGk3KbRwGtVKVufHQdDkmyLuii+7rA==", "05111111111", false, "d8b943f3-2f44-4e58-9505-6fc1544c4686", false, "Daisy76@yahoo.com" },
                    { "4e5672e4-932c-4d9a-bab7-b298c89ad3b5", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5addb26e-833c-4033-97ae-68e488680d2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emilio_Sporer17@yahoo.com", true, "Emilio", "Sporer", false, null, "EMILIO_SPORER17@YAHOO.COM", "EMILIO_SPORER17@YAHOO.COM", "AP4P2moK6V5I5XcZcGv4/4MM+c9kNru2YiWO+vxhJ8cujGYuyeNxKeWrmHlMSbl7Zw==", "05111111111", false, "db1aac71-b9f0-4c76-97c5-9a21d973b37b", false, "Emilio_Sporer17@yahoo.com" },
                    { "df6aebfd-acda-4163-8ad4-4dda2927eb71", 0, new Guid("00000000-0000-0000-0000-000000000000"), "4ee0840d-c300-429e-9d63-38cb468fb3d1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian_Braun@hotmail.com", true, "Ian", "Braun", false, null, "IAN_BRAUN@HOTMAIL.COM", "IAN_BRAUN@HOTMAIL.COM", "AKSemEi842GMl+Ww9uFWNZxttBXgzoQ3qaEWaTk8b3D9JcEjqD/F5wGmc7fV0H9mBg==", "05111111111", false, "bb456502-2b15-4415-8306-1e29646142bb", false, "Ian_Braun@hotmail.com" },
                    { "47d2c86f-dd6b-4f6c-ae51-b5f05d01f0f1", 0, new Guid("00000000-0000-0000-0000-000000000000"), "82fac566-7070-4fb1-a776-ad50f45f44b4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan_Larson91@gmail.com", true, "Ivan", "Larson", false, null, "IVAN_LARSON91@GMAIL.COM", "IVAN_LARSON91@GMAIL.COM", "AOQSLhr9TgeIHfCBIPcGCJSY/vsYkZNaEHJpx78rK1FHb1LMCZiSg5FRmjXIqDveHw==", "05111111111", false, "45013719-6d8b-4f11-9660-b56413ccaaee", false, "Ivan_Larson91@gmail.com" },
                    { "a288750d-ef4f-478d-9da7-53ddcfeadde4", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e88a3469-dcae-4ee0-97fe-cf8252474c8d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bernadette_Robel@gmail.com", true, "Bernadette", "Robel", false, null, "BERNADETTE_ROBEL@GMAIL.COM", "BERNADETTE_ROBEL@GMAIL.COM", "ACD/NNYGDVGVGqTVqKgValVYvP9n4Lo3aQe/WS66Ggkioled0IqIGbAsUB7zLCV3xw==", "05111111111", false, "a9e1d58e-58c1-47dc-8d88-7d1033c6645f", false, "Bernadette_Robel@gmail.com" },
                    { "678ba498-8415-4a97-a503-64e46f3ef56c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "52047865-207c-4fbe-9e34-76f969c63e1e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guy14@hotmail.com", true, "Guy", "Klocko", false, null, "GUY14@HOTMAIL.COM", "GUY14@HOTMAIL.COM", "ANWh8miJ7qYf5GCsY8TNKoga8xHCvL9tnjdNT1/3TiaWieob7teCayq3YZgbfq5MBA==", "05111111111", false, "7fccf47f-5f11-4a2c-9de5-561f2ef9c440", false, "Guy14@hotmail.com" },
                    { "2b0215d2-0572-4de0-a213-f79bd6969153", 0, new Guid("00000000-0000-0000-0000-000000000000"), "42a1ee73-8472-42e2-987d-3a0e5f95a69d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yvette_OReilly92@yahoo.com", true, "Yvette", "O'Reilly", false, null, "YVETTE_OREILLY92@YAHOO.COM", "YVETTE_OREILLY92@YAHOO.COM", "AGjiP/jYNL+ScgHVvmqoc13pOdl4TJi9h/GOYQ0rAL7u7+tFNcgdSS6+mT8qLj5qsg==", "05111111111", false, "f93273e4-e7eb-4389-8c76-70e0e17ca3f0", false, "Yvette_OReilly92@yahoo.com" },
                    { "0aa3d81b-eee4-424a-825e-c81ccbc1e405", 0, new Guid("00000000-0000-0000-0000-000000000000"), "0f1f4bbe-34a6-4161-a731-619cf2ff500c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julie.Tromp@yahoo.com", true, "Julie", "Tromp", false, null, "JULIE.TROMP@YAHOO.COM", "JULIE.TROMP@YAHOO.COM", "AAcUamPkPV6UouLmZ6ykeSvOy8TKRpihi0wUV5g6x79N+lPPyPlvqdFBbHWhpNNNhQ==", "05111111111", false, "2c7bde6b-922f-4c03-8637-c9358c88120f", false, "Julie.Tromp@yahoo.com" },
                    { "74c53285-0521-4c06-b4ab-0780615a4853", 0, new Guid("00000000-0000-0000-0000-000000000000"), "35f03d92-a6fb-46f4-a6eb-41d6981c1fcb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark_Wiza@yahoo.com", true, "Mark", "Wiza", false, null, "MARK_WIZA@YAHOO.COM", "MARK_WIZA@YAHOO.COM", "AOUQbP9G/q41JcyN3vmaXlCEind4cZD9drH/P0/jLfK+1EXsxXc+vl+Y0SBa2YSiQQ==", "05111111111", false, "475c753f-08ed-48c7-9064-26caec617f97", false, "Mark_Wiza@yahoo.com" },
                    { "013b6b1a-0200-45ba-bb95-32882a8816d9", 0, new Guid("00000000-0000-0000-0000-000000000000"), "bbf22fce-8b33-46a7-b3e8-d6632d420444", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valilik@bilgehotel.com", true, "Bilge", "Hotel", false, null, "VALILIK@BILGEHOTEL.COM", "VALILIK@BILGEHOTEL.COM", "AA0JIQtrpTBhy4ghlVCxlkTdk48WATo3M6zURCLrDYL/PniXmMHO6wYOauDubTL6QA==", "05111111111", false, "5030f99a-a7ad-4f86-adf6-a3267ab78ba4", false, "valilik@bilgehotel.com" },
                    { "508707ec-fc60-4ddc-ac41-1682cb13ac98", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e7283876-ee2c-49ad-bf57-fce3da638f06", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandy97@yahoo.com", true, "Brandy", "Harvey", false, null, "BRANDY97@YAHOO.COM", "BRANDY97@YAHOO.COM", "AFjOXt3Vyhf0ESfJCkTiY89KnjKZzmtc8vQX/DlmIS+c1QbsmwWHiKfBCuVvxUeocA==", "05111111111", false, "25ca8d2c-6901-41e2-99e0-ef411a43e8db", false, "Brandy97@yahoo.com" },
                    { "d29d616a-9530-4da8-a9e4-00171d261f7f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1409fdb3-329f-4fda-b77e-87f2192a0d20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randy8@gmail.com", true, "Randy", "Haley", false, null, "RANDY8@GMAIL.COM", "RANDY8@GMAIL.COM", "AI8xv+u0FeEXhljiRuLD1cWxYJFG8PhXAuXxCiNQfP1tYfOGH7QsLmsCVwawy/acxA==", "05111111111", false, "942be518-7a6b-4c86-839e-dd97cc457545", false, "Randy8@gmail.com" },
                    { "d50e5880-ac60-4174-9450-9ddb2cc4307a", 0, new Guid("00000000-0000-0000-0000-000000000000"), "abc8e94d-dc91-4394-afef-1102ed3f876f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delbert_Mayert82@hotmail.com", true, "Delbert", "Mayert", false, null, "DELBERT_MAYERT82@HOTMAIL.COM", "DELBERT_MAYERT82@HOTMAIL.COM", "AHdGzVW6wUH4Vu/e8ydVja0zrT68JdrXQfaTClMCvYX9yWCa4WRsn4kEAiN6FFinLQ==", "05111111111", false, "350e8d93-0017-44bf-8177-317803af006c", false, "Delbert_Mayert82@hotmail.com" },
                    { "2f012b31-9ca0-4f92-9cf3-b5ff68ff7f23", 0, new Guid("00000000-0000-0000-0000-000000000000"), "4ec4c66a-00cd-4625-9744-68bfc9248096", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin80@hotmail.com", true, "Martin", "Hills", false, null, "MARTIN80@HOTMAIL.COM", "MARTIN80@HOTMAIL.COM", "AM32vsB9yZRiJGyvfdPetw5KCsZtR6esUi3I+nF6WLwh/108P+Ahoqp383GTfaBAwg==", "05111111111", false, "aef0e9ea-0320-4133-948c-e4c23610a588", false, "Martin80@hotmail.com" },
                    { "3f174aae-92a5-424a-93b4-549bc2d0e985", 0, new Guid("00000000-0000-0000-0000-000000000000"), "644af215-6fd4-4114-a53a-b288735ade75", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lynette_Kuhlman84@hotmail.com", true, "Lynette", "Kuhlman", false, null, "LYNETTE_KUHLMAN84@HOTMAIL.COM", "LYNETTE_KUHLMAN84@HOTMAIL.COM", "AE6N3vLNzuTtJVxc71t20M8DDq49vNao8vFp1IS6GcPGxCi6PchgFQA/aXqu9zHXWw==", "05111111111", false, "029aafe4-d65c-4913-9591-9055d24c065d", false, "Lynette_Kuhlman84@hotmail.com" },
                    { "0b25144e-ce15-446f-8fcb-005958b94ada", 0, new Guid("00000000-0000-0000-0000-000000000000"), "582b1d1b-0e9d-4fe6-9501-ac1e1aa9ee10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorenzo_Schulist76@gmail.com", true, "Lorenzo", "Schulist", false, null, "LORENZO_SCHULIST76@GMAIL.COM", "LORENZO_SCHULIST76@GMAIL.COM", "AFNRAiu979pEwDBIFozwglwhl7DdaHzDyaB5LrJ5bhVUgNS6+alMyTDTXNvQ6e0Z+A==", "05111111111", false, "fffc2c46-b687-4e15-8788-48a05777fd1a", false, "Lorenzo_Schulist76@gmail.com" },
                    { "4a93f476-0581-40a0-bdf7-57001a44f757", 0, new Guid("00000000-0000-0000-0000-000000000000"), "c1c7df12-cfa3-4979-8bb9-2ebea7f41c64", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brittany_Pfannerstill@gmail.com", true, "Brittany", "Pfannerstill", false, null, "BRITTANY_PFANNERSTILL@GMAIL.COM", "BRITTANY_PFANNERSTILL@GMAIL.COM", "AIiBv8sRy1SmwtTWf/nD0lQ89VBghokG1uEbAqXglJJzPsa0VdOpb3e37hp8/6zyUQ==", "05111111111", false, "76c04650-d82a-4eda-bf69-a4a3380d8dc3", false, "Brittany_Pfannerstill@gmail.com" },
                    { "aa44e854-6d19-4251-8bcb-a38fb28de46e", 0, new Guid("00000000-0000-0000-0000-000000000000"), "25751fe3-c2ec-42db-aa86-d8e9906e5930", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie_Yost@gmail.com", true, "Billie", "Yost", false, null, "BILLIE_YOST@GMAIL.COM", "BILLIE_YOST@GMAIL.COM", "AJhrlC9a5xNvaHkMtdAH6UpWPORgkloqeA1M912VRQKWDhIfCSdr5uWQAKnx/1cy5Q==", "05111111111", false, "89570622-ae6c-4e72-b42d-6a25670f6e1c", false, "Billie_Yost@gmail.com" },
                    { "3d381798-2cc6-44d8-bc12-7d623daf14f7", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b3739c40-6326-4dba-91a7-18cf3fa13b8f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laurie_Carroll16@gmail.com", true, "Laurie", "Carroll", false, null, "LAURIE_CARROLL16@GMAIL.COM", "LAURIE_CARROLL16@GMAIL.COM", "AAM52OPCLVtjEutKm1dv/0j7cCEjP/PWcKxWdIaR5EdoZGAn20rYqus/nO7Tq3vmsA==", "05111111111", false, "97234e93-3648-4279-8bad-62b382b1bea5", false, "Laurie_Carroll16@gmail.com" },
                    { "738ea8b9-8630-4cbc-a5f0-e190ac4c3b9d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f391e3a8-25f8-4ca1-aee0-3bcdd33c3c3b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam.Weissnat@yahoo.com", true, "Sam", "Weissnat", false, null, "SAM.WEISSNAT@YAHOO.COM", "SAM.WEISSNAT@YAHOO.COM", "AL/KajZGQGkpipfS7YQP92ypFFdAjl9J8rQ1UcttKmzCKsbNtkog624EqO+1NbCDgg==", "05111111111", false, "11914110-2d22-4bf2-9e44-87cad2f117b1", false, "Sam.Weissnat@yahoo.com" },
                    { "f719911c-b2b1-4cd3-958c-3b2cc3b867aa", 0, new Guid("00000000-0000-0000-0000-000000000000"), "a86655f1-0ed2-41f6-a4cb-44bbd8993553", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ross.Blick@gmail.com", true, "Ross", "Blick", false, null, "ROSS.BLICK@GMAIL.COM", "ROSS.BLICK@GMAIL.COM", "ANYtbZ5K9WnOMOX/Hb81HIx25CsnGSts1Dqelk+NCwq1RKJVfZMj7P6qK/3v6aZvKA==", "05111111111", false, "fc14e00d-f6ea-45ae-9f81-4441b41b148a", false, "Ross.Blick@gmail.com" },
                    { "33f679cd-bde7-4f24-9c25-04d0cd5fffcd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9546c73a-07d5-4219-bef6-71e704433ec4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nichole_Bahringer@hotmail.com", true, "Nichole", "Bahringer", false, null, "NICHOLE_BAHRINGER@HOTMAIL.COM", "NICHOLE_BAHRINGER@HOTMAIL.COM", "ADedC6qVliUeqUoDPGjRilpkAET9UgrJbMEz9HJ1+X/Bq//rQCRXYSbrL1eh2ftPLw==", "05111111111", false, "3af1012e-ee05-42d8-aaa4-842caf7a0c44", false, "Nichole_Bahringer@hotmail.com" },
                    { "d025addc-28cd-40c9-b93a-2af36ff824c3", 0, new Guid("00000000-0000-0000-0000-000000000000"), "42db11bc-2546-45d1-820e-539224c6075f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony_Weber@gmail.com", true, "Anthony", "Weber", false, null, "ANTHONY_WEBER@GMAIL.COM", "ANTHONY_WEBER@GMAIL.COM", "AH8U+B0TPo3EHm0er47TkCrDu60xYUDzpynEtgZbRQDPhAgWw8TICJoai8Vi542xRg==", "05111111111", false, "9ce6d976-4cd6-4e25-a0ba-39916a47c0e7", false, "Anthony_Weber@gmail.com" },
                    { "4e4f33aa-8737-484a-8f72-1fccc92a339a", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e5aa9060-c323-4f65-b130-84e7fc67f1b0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chad75@gmail.com", true, "Chad", "Lockman", false, null, "CHAD75@GMAIL.COM", "CHAD75@GMAIL.COM", "AGCY1Vge/Pfk+o3VCbTYO/nItKToiFAYS8rVKP2BcYHZ88HzwsjZ60+z+FCi10EzOQ==", "05111111111", false, "ddd84ee2-259d-4afc-af91-6bc3d5fbbc59", false, "Chad75@gmail.com" },
                    { "b060d268-df2c-4dc9-8b33-330192da22cd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "8a785005-1938-41bc-823c-9740509783fb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnny_Bins@hotmail.com", true, "Johnny", "Bins", false, null, "JOHNNY_BINS@HOTMAIL.COM", "JOHNNY_BINS@HOTMAIL.COM", "AMbTCQG+LNi4ZNa4Eb5Bh6QAi84oE6UyyqfdTinsKWbjtjtJ2aYYPb5VCwk0Gos4oA==", "05111111111", false, "3ba1a045-0964-45e6-acdc-3d0482cbe902", false, "Johnny_Bins@hotmail.com" },
                    { "0b3e32fd-16c4-4dda-b395-d3c921c546a6", 0, new Guid("00000000-0000-0000-0000-000000000000"), "842e37d9-8ad5-4727-8132-236cb91aa9e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erick42@yahoo.com", true, "Erick", "Reynolds", false, null, "ERICK42@YAHOO.COM", "ERICK42@YAHOO.COM", "AGvx/pH2ryK37ip3AxdF7hnKEgeiFvKkdtE+1ASOEP4wRZIEqVPDXqGB/a46R/KcaQ==", "05111111111", false, "4c57b0a2-7daa-43f5-bdfa-331f022d29b7", false, "Erick42@yahoo.com" },
                    { "fd0edfd4-a033-4c0a-8a7f-b99d8f840136", 0, new Guid("00000000-0000-0000-0000-000000000000"), "fe1aeb61-c16f-4928-b4c1-163780799ce3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hugo4@gmail.com", true, "Hugo", "Johns", false, null, "HUGO4@GMAIL.COM", "HUGO4@GMAIL.COM", "ACPaesd83ZXn5VbpgDZwtyw8kQAAr4YgZ6WhYXVVB/ztt9RWZnMG2PBRNgpISqw1HQ==", "05111111111", false, "54e594a1-a406-4cfe-9368-20b96331aa42", false, "Hugo4@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0543a674-c83d-4802-83fd-6fa134fdb78d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "bbe7140a-7add-4e83-a041-663d42a8ed31", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pete_Daugherty38@hotmail.com", true, "Pete", "Daugherty", false, null, "PETE_DAUGHERTY38@HOTMAIL.COM", "PETE_DAUGHERTY38@HOTMAIL.COM", "ADaDEcnL/trWKB6y404DRllQJh2hwOv0BIsCxBVb65Yi9bS0HrSmYMSwWgYjYOse8A==", "05111111111", false, "6496a0dd-58f1-47fe-a9db-09d9e545e81d", false, "Pete_Daugherty38@hotmail.com" },
                    { "2916ea2c-c308-49e6-8b36-39ea2dbe948b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "630fcf31-8df9-4ed6-bdf2-6dc300a46b8c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julio.Auer60@yahoo.com", true, "Julio", "Auer", false, null, "JULIO.AUER60@YAHOO.COM", "JULIO.AUER60@YAHOO.COM", "AFLzygzJJj8dObiAoqN2ZnvpugY1Vwb7jRSE/616J3Jtv4Ohqgd5HsDgljDlqsnCYw==", "05111111111", false, "2cf75d1c-1f19-4450-9f6c-75d4018b0285", false, "Julio.Auer60@yahoo.com" },
                    { "05484306-ad7d-47c1-bac2-3d671965c06d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "d0d0b802-a51a-43e4-b28a-6f1e61ea9aa2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blanche72@hotmail.com", true, "Blanche", "Hayes", false, null, "BLANCHE72@HOTMAIL.COM", "BLANCHE72@HOTMAIL.COM", "ALZOm9T2fB66G41ybo4X53IGqICLYc3J5sTJFUjWefPFJxiQCHaB7PeuHTvYz/7iWA==", "05111111111", false, "6b6df23f-9b3d-4408-bf8e-27b06ecfd59d", false, "Blanche72@hotmail.com" },
                    { "62a1ff3a-bbab-47b1-9112-11a21a63018c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "8770d567-ce48-4390-863a-484693a56b93", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rhonda15@yahoo.com", true, "Rhonda", "Kovacek", false, null, "RHONDA15@YAHOO.COM", "RHONDA15@YAHOO.COM", "ABwTB3Y65lC8Ga2qPgVYGBCRPBWWTG09LMWYD3p0f1Dh4Dar9JK4CAUma/zFUCwCAg==", "05111111111", false, "21a4da73-ca77-4a39-8f12-d223de73afd9", false, "Rhonda15@yahoo.com" },
                    { "5db5d90f-82e6-4837-94f6-340787958341", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9bafad57-21ca-48d3-9da8-48f16d17f832", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raquel15@hotmail.com", true, "Raquel", "Wolf", false, null, "RAQUEL15@HOTMAIL.COM", "RAQUEL15@HOTMAIL.COM", "ACRvcGDmyDSRRnNEk+9YUJ09RJXmpNeQ+7nelSzjYRfk35ic3/zmEy7q541HDF3aCQ==", "05111111111", false, "deaf59f9-93af-4386-8576-7dc072e1dc9c", false, "Raquel15@hotmail.com" },
                    { "9e583910-d454-4d29-b631-f935369cc542", 0, new Guid("00000000-0000-0000-0000-000000000000"), "38c600d6-d02c-4e75-86d4-58941c58d3e7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megan_Dicki@gmail.com", true, "Megan", "Dicki", false, null, "MEGAN_DICKI@GMAIL.COM", "MEGAN_DICKI@GMAIL.COM", "AEFfYK9r3ul1tTG4SyKqrFyemrJSsFObbFqEreDjrc2Qx9LGqXMdgLXYneUHnsnpoQ==", "05111111111", false, "7bd762a3-a40f-4392-88d3-f5a79405d321", false, "Megan_Dicki@gmail.com" },
                    { "9df7d5b4-1090-450d-a91d-ace449a2155a", 0, new Guid("00000000-0000-0000-0000-000000000000"), "df2ef988-7c26-4f4f-aefb-10518873a47d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melanie_Howell@gmail.com", true, "Melanie", "Howell", false, null, "MELANIE_HOWELL@GMAIL.COM", "MELANIE_HOWELL@GMAIL.COM", "AI6dElvYIjQqKNBBCyGHU2JcYPzW0YzTL4eDBwNwoj0jUUjCuVQ5yItu/DmUOnuJnA==", "05111111111", false, "a86a9132-9511-45a6-aa0f-5cb5a4de650f", false, "Melanie_Howell@gmail.com" },
                    { "09bc5eaf-ab87-4393-b4f2-35eea4578d75", 0, new Guid("00000000-0000-0000-0000-000000000000"), "dd3f216a-2e01-4745-b667-aec0e8a1d828", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geraldine44@hotmail.com", true, "Geraldine", "Goyette", false, null, "GERALDINE44@HOTMAIL.COM", "GERALDINE44@HOTMAIL.COM", "AK7Fd3DnGJmnoZf+50JJEW+B9PaUCaeO7OidCZ+ffiznzGXkABSKMBwh1a3R3Qh2+A==", "05111111111", false, "e6452aee-6a7e-4e28-af87-47d25815324e", false, "Geraldine44@hotmail.com" },
                    { "aa012fff-9ae0-45df-98fc-fbb455a72816", 0, new Guid("00000000-0000-0000-0000-000000000000"), "640d25e4-e83f-4f17-a9c6-65f61fd9a1c2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John.Cummings79@hotmail.com", true, "John", "Cummings", false, null, "JOHN.CUMMINGS79@HOTMAIL.COM", "JOHN.CUMMINGS79@HOTMAIL.COM", "AMyRf92JDhvf4L8O1557dsbdVxdw55FCl+FDSy5CdHUqlkbMAe9i962n7Yk82D/1Vw==", "05111111111", false, "3263a852-e217-4761-b87c-0c481fc9308b", false, "John.Cummings79@hotmail.com" },
                    { "5bb61c8a-0e0f-4db4-bd07-28051c086379", 0, new Guid("00000000-0000-0000-0000-000000000000"), "584213e7-8cd5-46dc-996d-6259339f058e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norman.Kutch76@gmail.com", true, "Norman", "Kutch", false, null, "NORMAN.KUTCH76@GMAIL.COM", "NORMAN.KUTCH76@GMAIL.COM", "AAtHpK1ZJXbIpbyvb26PKxDMxet7EdOze7mRBq6zejIxhM2Yvt5i2MWANMr0DNrD+w==", "05111111111", false, "b812efee-aa6f-468c-8832-48d81c665b86", false, "Norman.Kutch76@gmail.com" },
                    { "79e39fe2-451d-44b8-bc0e-23d2b1c9c696", 0, new Guid("00000000-0000-0000-0000-000000000000"), "718a76cd-a2a1-499e-8dfb-027ded8c6522", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolores79@hotmail.com", true, "Dolores", "Jenkins", false, null, "DOLORES79@HOTMAIL.COM", "DOLORES79@HOTMAIL.COM", "ABzR40w40xZwvgYCbypMe0CORmqa98N/A3MZMx6x9Y7mNIu9Xp+YKl6sus2bhO2WrA==", "05111111111", false, "f899f32d-03f4-4457-b932-0de7b9919c0d", false, "Dolores79@hotmail.com" },
                    { "7415b941-7f0c-4c7c-99ec-35e6abeaa5cc", 0, new Guid("00000000-0000-0000-0000-000000000000"), "84f3dd8e-8cc4-4942-82a8-2c593dd524e0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anita26@hotmail.com", true, "Anita", "Mitchell", false, null, "ANITA26@HOTMAIL.COM", "ANITA26@HOTMAIL.COM", "AIC/wkgp2vrooy3r42tK5fKxK6EGMSY5ce4/+BJsFNEPqfVQrXL/WqAygkL3xpM6ug==", "05111111111", false, "a06999fb-f756-4d17-86f6-fa20de7b619f", false, "Anita26@hotmail.com" },
                    { "1906ef83-ff42-4d95-8d36-8763583cdb9b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "caa9474a-6786-4f86-9c60-c63f2cc9ad77", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodney27@yahoo.com", true, "Rodney", "Altenwerth", false, null, "RODNEY27@YAHOO.COM", "RODNEY27@YAHOO.COM", "AMjwgUehd4wUva4W3Dkj4Jx8vcg8EMroUdMrBkid1KYRfLpQ4cKu3BPbMA2VwEjGRQ==", "05111111111", false, "bdf7ce66-d36e-4a05-a1ff-d96aa888e378", false, "Rodney27@yahoo.com" },
                    { "7dd78617-587f-4eab-afcc-36ad397fe6e0", 0, new Guid("00000000-0000-0000-0000-000000000000"), "7d56c687-f0e0-4799-b0be-913dadb1d845", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teri44@yahoo.com", true, "Teri", "Raynor", false, null, "TERI44@YAHOO.COM", "TERI44@YAHOO.COM", "AJT2kFSHpkxQeriBw96ShV8xC49Vmnn4jm37PcWICYUvU+IsK1BzB7opsrwuPyMSgg==", "05111111111", false, "ddb58de7-cbd2-473a-adb9-4056332afc7b", false, "Teri44@yahoo.com" },
                    { "3e76fd12-71dd-4d2a-b181-e319d0cda749", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6113b81f-fe78-44a4-892e-a41b60853c0e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terrance_Muller6@gmail.com", true, "Terrance", "Muller", false, null, "TERRANCE_MULLER6@GMAIL.COM", "TERRANCE_MULLER6@GMAIL.COM", "AI/w1UvH6sw9qDDP4Xvnd6WHFTJNAKBx6Q33S5TPR250bYqEjBRiCa86GtKjoXLBjg==", "05111111111", false, "cfcdfa01-3c05-4d15-9690-4ae01f0ee65f", false, "Terrance_Muller6@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Email", "Facebook", "Fax", "Instagram", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "643 Lakin Unions, Bernierton, Turkey", null, null, null, null, null, "Loren.Zemlak@hotmail.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, null, null, null, null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

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
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "013b6b1a-0200-45ba-bb95-32882a8816d9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5bb61c8a-0e0f-4db4-bd07-28051c086379" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "79e39fe2-451d-44b8-bc0e-23d2b1c9c696" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7415b941-7f0c-4c7c-99ec-35e6abeaa5cc" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1906ef83-ff42-4d95-8d36-8763583cdb9b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "05484306-ad7d-47c1-bac2-3d671965c06d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3d381798-2cc6-44d8-bc12-7d623daf14f7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "678ba498-8415-4a97-a503-64e46f3ef56c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b7186e2c-844a-4c8c-b322-57d22066c7d4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "301ef378-2291-4297-b1d5-01bd6ac4881d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6f19cb42-19e6-4b1f-a08e-52ed25062e91" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "405a073f-1e16-4b99-93bf-4d8cc8e439e7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e74d272e-acdb-45a8-9557-ccd768adf99c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4e5672e4-932c-4d9a-bab7-b298c89ad3b5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "df6aebfd-acda-4163-8ad4-4dda2927eb71" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "47d2c86f-dd6b-4f6c-ae51-b5f05d01f0f1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a288750d-ef4f-478d-9da7-53ddcfeadde4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2b0215d2-0572-4de0-a213-f79bd6969153" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4a93f476-0581-40a0-bdf7-57001a44f757" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "74c53285-0521-4c06-b4ab-0780615a4853" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "aa012fff-9ae0-45df-98fc-fbb455a72816" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "d29d616a-9530-4da8-a9e4-00171d261f7f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "09bc5eaf-ab87-4393-b4f2-35eea4578d75" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9e583910-d454-4d29-b631-f935369cc542" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d29d616a-9530-4da8-a9e4-00171d261f7f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d50e5880-ac60-4174-9450-9ddb2cc4307a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2f012b31-9ca0-4f92-9cf3-b5ff68ff7f23" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3f174aae-92a5-424a-93b4-549bc2d0e985" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "aa44e854-6d19-4251-8bcb-a38fb28de46e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3e76fd12-71dd-4d2a-b181-e319d0cda749" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "508707ec-fc60-4ddc-ac41-1682cb13ac98" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0b25144e-ce15-446f-8fcb-005958b94ada" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bead453e-fd54-43d5-9669-714315989044" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f719911c-b2b1-4cd3-958c-3b2cc3b867aa" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "33f679cd-bde7-4f24-9c25-04d0cd5fffcd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d025addc-28cd-40c9-b93a-2af36ff824c3" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4e4f33aa-8737-484a-8f72-1fccc92a339a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b060d268-df2c-4dc9-8b33-330192da22cd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0b3e32fd-16c4-4dda-b395-d3c921c546a6" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "fd0edfd4-a033-4c0a-8a7f-b99d8f840136" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0543a674-c83d-4802-83fd-6fa134fdb78d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2916ea2c-c308-49e6-8b36-39ea2dbe948b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "62a1ff3a-bbab-47b1-9112-11a21a63018c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7dd78617-587f-4eab-afcc-36ad397fe6e0" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5db5d90f-82e6-4837-94f6-340787958341" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9df7d5b4-1090-450d-a91d-ace449a2155a" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "d50e5880-ac60-4174-9450-9ddb2cc4307a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "738ea8b9-8630-4cbc-a5f0-e190ac4c3b9d" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "3f174aae-92a5-424a-93b4-549bc2d0e985" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "9df7d5b4-1090-450d-a91d-ace449a2155a" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "09bc5eaf-ab87-4393-b4f2-35eea4578d75" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "aa012fff-9ae0-45df-98fc-fbb455a72816" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5bb61c8a-0e0f-4db4-bd07-28051c086379" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "79e39fe2-451d-44b8-bc0e-23d2b1c9c696" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7415b941-7f0c-4c7c-99ec-35e6abeaa5cc" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "1906ef83-ff42-4d95-8d36-8763583cdb9b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "738ea8b9-8630-4cbc-a5f0-e190ac4c3b9d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "05484306-ad7d-47c1-bac2-3d671965c06d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "3d381798-2cc6-44d8-bc12-7d623daf14f7" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "9e583910-d454-4d29-b631-f935369cc542" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "678ba498-8415-4a97-a503-64e46f3ef56c" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "301ef378-2291-4297-b1d5-01bd6ac4881d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6f19cb42-19e6-4b1f-a08e-52ed25062e91" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "405a073f-1e16-4b99-93bf-4d8cc8e439e7" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e74d272e-acdb-45a8-9557-ccd768adf99c" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4e5672e4-932c-4d9a-bab7-b298c89ad3b5" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "2f012b31-9ca0-4f92-9cf3-b5ff68ff7f23" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "47d2c86f-dd6b-4f6c-ae51-b5f05d01f0f1" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "a288750d-ef4f-478d-9da7-53ddcfeadde4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b7186e2c-844a-4c8c-b322-57d22066c7d4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5db5d90f-82e6-4837-94f6-340787958341" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "df6aebfd-acda-4163-8ad4-4dda2927eb71" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "62a1ff3a-bbab-47b1-9112-11a21a63018c" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7dd78617-587f-4eab-afcc-36ad397fe6e0" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "aa44e854-6d19-4251-8bcb-a38fb28de46e" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "3e76fd12-71dd-4d2a-b181-e319d0cda749" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "508707ec-fc60-4ddc-ac41-1682cb13ac98" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "74c53285-0521-4c06-b4ab-0780615a4853" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "0b25144e-ce15-446f-8fcb-005958b94ada" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "bead453e-fd54-43d5-9669-714315989044" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "f719911c-b2b1-4cd3-958c-3b2cc3b867aa" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "33f679cd-bde7-4f24-9c25-04d0cd5fffcd" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "74c53285-0521-4c06-b4ab-0780615a4853" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "4e4f33aa-8737-484a-8f72-1fccc92a339a" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "d025addc-28cd-40c9-b93a-2af36ff824c3" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "4a93f476-0581-40a0-bdf7-57001a44f757" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "2b0215d2-0572-4de0-a213-f79bd6969153" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "2916ea2c-c308-49e6-8b36-39ea2dbe948b" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "fd0edfd4-a033-4c0a-8a7f-b99d8f840136" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "0b3e32fd-16c4-4dda-b395-d3c921c546a6" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "b060d268-df2c-4dc9-8b33-330192da22cd" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "0543a674-c83d-4802-83fd-6fa134fdb78d" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "0aa3d81b-eee4-424a-825e-c81ccbc1e405" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "4a93f476-0581-40a0-bdf7-57001a44f757", null, null, null, null, null, 2, "Brittany_Pfannerstill@gmail.com", 3, "Brittany", 193.973980650293630m, "6874", true, "Pfannerstill", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 6, 15, 4, 26, 153, DateTimeKind.Unspecified).AddTicks(9828), "Bilgi İşlem Sorumlusu" },
                    { 32, "3d381798-2cc6-44d8-bc12-7d623daf14f7", null, null, null, null, null, 3, "Laurie_Carroll16@gmail.com", 3, "Laurie", 199.354843087193950m, "8147", true, "Carroll", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 3, 16, 16, 46, 40, 738, DateTimeKind.Unspecified).AddTicks(1424), "Garson" },
                    { 43, "2b0215d2-0572-4de0-a213-f79bd6969153", null, null, null, null, null, 1, "Yvette_OReilly92@yahoo.com", 3, "Yvette", 191.790706814169280m, "9053", true, "O'Reilly", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 2, 3, 19, 24, 7, 929, DateTimeKind.Unspecified).AddTicks(3956), "Elektirikçi" },
                    { 36, "6f19cb42-19e6-4b1f-a08e-52ed25062e91", null, null, null, null, null, 3, "Esther.Klein76@yahoo.com", 3, "Esther", 190.6144237847134580m, "9458", true, "Klein", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 2, 18, 18, 28, 32, 668, DateTimeKind.Unspecified).AddTicks(879), "Garson" },
                    { 35, "301ef378-2291-4297-b1d5-01bd6ac4881d", null, null, null, null, null, 3, "Joy.Jones2@yahoo.com", 3, "Joy", 191.287527569237880m, "2799", true, "Jones", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 30, 22, 15, 16, 526, DateTimeKind.Unspecified).AddTicks(7369), "Garson" },
                    { 34, "b7186e2c-844a-4c8c-b322-57d22066c7d4", null, null, null, null, null, 3, "Annette.Luettgen@gmail.com", 3, "Annette", 195.53771144502690m, "2024", true, "Luettgen", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 9, 27, 7, 44, 51, 627, DateTimeKind.Unspecified).AddTicks(4672), "Garson" },
                    { 33, "678ba498-8415-4a97-a503-64e46f3ef56c", null, null, null, null, null, 3, "Guy14@hotmail.com", 3, "Guy", 194.731238556434980m, "9853", true, "Klocko", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 2, 21, 4, 32, 727, DateTimeKind.Unspecified).AddTicks(1498), "Garson" },
                    { 23, "9df7d5b4-1090-450d-a91d-ace449a2155a", null, null, null, null, null, 3, "Melanie_Howell@gmail.com", 3, "Melanie", 193.547261759427960m, "1973", true, "Howell", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 3, 27, 3, 31, 12, 642, DateTimeKind.Unspecified).AddTicks(9880), "Aşçı" },
                    { 30, "738ea8b9-8630-4cbc-a5f0-e190ac4c3b9d", null, null, null, null, null, 3, "Sam.Weissnat@yahoo.com", 3, "Sam", 194.962241116427930m, "1625", true, "Weissnat", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 5, 15, 8, 10, 57, 173, DateTimeKind.Unspecified).AddTicks(2753), "Garson" },
                    { 24, "09bc5eaf-ab87-4393-b4f2-35eea4578d75", null, null, null, null, null, 3, "Geraldine44@hotmail.com", 3, "Geraldine", 191.372904075017620m, "3179", true, "Goyette", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 5, 4, 12, 9, 14, 821, DateTimeKind.Unspecified).AddTicks(7353), "Aşçı" },
                    { 45, "0aa3d81b-eee4-424a-825e-c81ccbc1e405", null, null, null, null, null, 5, "Julie.Tromp@yahoo.com", 0, "Julie", 198.922338885684660m, "7836", true, "Tromp", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 3, 11, 20, 30, 43, 302, DateTimeKind.Unspecified).AddTicks(4657), "Müdür" },
                    { 22, "9e583910-d454-4d29-b631-f935369cc542", null, null, null, null, null, 3, "Megan_Dicki@gmail.com", 3, "Megan", 198.516696015613480m, "3176", true, "Dicki", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 18, 11, 57, 7, 75, DateTimeKind.Unspecified).AddTicks(6648), "Aşçı" },
                    { 21, "5db5d90f-82e6-4837-94f6-340787958341", null, null, null, null, null, 3, "Raquel15@hotmail.com", 3, "Raquel", 192.662589355680430m, "8898", true, "Wolf", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 5, 26, 14, 58, 36, 373, DateTimeKind.Unspecified).AddTicks(6123), "Aşçı" },
                    { 20, "7dd78617-587f-4eab-afcc-36ad397fe6e0", null, null, null, null, null, 3, "Teri44@yahoo.com", 3, "Teri", 198.533015930342030m, "6438", true, "Raynor", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 12, 19, 15, 37, 24, 584, DateTimeKind.Unspecified).AddTicks(8788), "Aşçı" },
                    { 19, "62a1ff3a-bbab-47b1-9112-11a21a63018c", null, null, null, null, null, 3, "Rhonda15@yahoo.com", 3, "Rhonda", 195.319154493193680m, "1788", true, "Kovacek", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 12, 23, 4, 23, 10, 457, DateTimeKind.Unspecified).AddTicks(4637), "Aşçı" },
                    { 13, "4e4f33aa-8737-484a-8f72-1fccc92a339a", null, null, null, null, null, 1, "Chad75@gmail.com", 3, "Chad", 198.003521197477130m, "3485", true, "Lockman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 5, 2, 3, 52, 53, 815, DateTimeKind.Unspecified).AddTicks(2584), "Temizlik Görevlisi" },
                    { 31, "05484306-ad7d-47c1-bac2-3d671965c06d", null, null, null, null, null, 3, "Blanche72@hotmail.com", 3, "Blanche", 190.2194612613969770m, "2063", true, "Hayes", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 12, 11, 23, 34, 9, 647, DateTimeKind.Unspecified).AddTicks(4106), "Garson" },
                    { 46, "74c53285-0521-4c06-b4ab-0780615a4853", null, null, null, null, null, 6, "Mark_Wiza@yahoo.com", 1, "Mark", 191.140369270527910m, "7405", true, "Wiza", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2021, 10, 27, 16, 32, 58, 70, DateTimeKind.Unspecified).AddTicks(1809), "İnsan Kaynakları Müdürü" },
                    { 17, "0543a674-c83d-4802-83fd-6fa134fdb78d", null, null, null, null, null, 1, "Pete_Daugherty38@hotmail.com", 3, "Pete", 199.525744928757540m, "7711", true, "Daugherty", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 12, 26, 10, 39, 9, 17, DateTimeKind.Unspecified).AddTicks(8404), "Temizlik Görevlisi" },
                    { 5, "aa44e854-6d19-4251-8bcb-a38fb28de46e", null, null, null, null, null, 4, "Billie_Yost@gmail.com", 3, "Billie", 194.812158394983110m, "4520", true, "Yost", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 27, 5, 19, 16, 71, DateTimeKind.Unspecified).AddTicks(208), "Resepsiyonist" },
                    { 12, "d025addc-28cd-40c9-b93a-2af36ff824c3", null, null, null, null, null, 1, "Anthony_Weber@gmail.com", 3, "Anthony", 194.321230740435990m, "4737", true, "Weber", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 11, 25, 19, 28, 47, 665, DateTimeKind.Unspecified).AddTicks(5694), "Temizlik Görevlisi" },
                    { 7, "508707ec-fc60-4ddc-ac41-1682cb13ac98", null, null, null, null, null, 4, "Brandy97@yahoo.com", 3, "Brandy", 193.855111074566430m, "4251", true, "Harvey", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2022, 1, 2, 7, 6, 59, 121, DateTimeKind.Unspecified).AddTicks(7384), "Resepsiyonist" },
                    { 6, "3e76fd12-71dd-4d2a-b181-e319d0cda749", null, null, null, null, null, 4, "Terrance_Muller6@gmail.com", 3, "Terrance", 190.2391022677715410m, "8712", true, "Muller", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2021, 11, 4, 20, 32, 41, 594, DateTimeKind.Unspecified).AddTicks(212), "Resepsiyonist" },
                    { 42, "a288750d-ef4f-478d-9da7-53ddcfeadde4", null, null, null, null, null, 3, "Bernadette_Robel@gmail.com", 3, "Bernadette", 190.6134551859523430m, "6937", true, "Robel", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 4, 11, 10, 10, 672, DateTimeKind.Unspecified).AddTicks(2738), "Garson" },
                    { 41, "47d2c86f-dd6b-4f6c-ae51-b5f05d01f0f1", null, null, null, null, null, 3, "Ivan_Larson91@gmail.com", 3, "Ivan", 191.342434376171990m, "3319", true, "Larson", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 3, 26, 17, 18, 13, 152, DateTimeKind.Unspecified).AddTicks(3349), "Garson" },
                    { 40, "df6aebfd-acda-4163-8ad4-4dda2927eb71", null, null, null, null, null, 3, "Ian_Braun@hotmail.com", 3, "Ian", 195.059752820553140m, "5561", true, "Braun", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 12, 0, 19, 5, 422, DateTimeKind.Unspecified).AddTicks(6249), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "4e5672e4-932c-4d9a-bab7-b298c89ad3b5", null, null, null, null, null, 3, "Emilio_Sporer17@yahoo.com", 3, "Emilio", 192.346739984278910m, "5044", true, "Sporer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 2, 20, 15, 21, 8, 795, DateTimeKind.Unspecified).AddTicks(6834), "Garson" },
                    { 38, "e74d272e-acdb-45a8-9557-ccd768adf99c", null, null, null, null, null, 3, "Daisy76@yahoo.com", 3, "Daisy", 195.275168500503140m, "1807", true, "Douglas", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 10, 26, 7, 54, 46, 540, DateTimeKind.Unspecified).AddTicks(3469), "Garson" },
                    { 37, "405a073f-1e16-4b99-93bf-4d8cc8e439e7", null, null, null, null, null, 3, "Theresa_Schoen5@gmail.com", 3, "Theresa", 196.488856229227440m, "5034", true, "Schoen", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 4, 23, 1, 13, 44, 0, DateTimeKind.Unspecified).AddTicks(9184), "Garson" },
                    { 28, "7415b941-7f0c-4c7c-99ec-35e6abeaa5cc", null, null, null, null, null, 3, "Anita26@hotmail.com", 3, "Anita", 197.961361221019810m, "5276", true, "Mitchell", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 6, 26, 6, 56, 32, 913, DateTimeKind.Unspecified).AddTicks(7524), "Aşçı" },
                    { 27, "79e39fe2-451d-44b8-bc0e-23d2b1c9c696", null, null, null, null, null, 3, "Dolores79@hotmail.com", 3, "Dolores", 194.817251039118160m, "1234", true, "Jenkins", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 11, 1, 54, 49, 117, DateTimeKind.Unspecified).AddTicks(2979), "Aşçı" },
                    { 26, "5bb61c8a-0e0f-4db4-bd07-28051c086379", null, null, null, null, null, 3, "Norman.Kutch76@gmail.com", 3, "Norman", 193.338984438841690m, "5831", true, "Kutch", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 9, 13, 22, 7, 5, 771, DateTimeKind.Unspecified).AddTicks(3465), "Aşçı" },
                    { 25, "aa012fff-9ae0-45df-98fc-fbb455a72816", null, null, null, null, null, 3, "John.Cummings79@hotmail.com", 3, "John", 196.555132580248240m, "2120", true, "Cummings", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 10, 22, 9, 7, 40, 841, DateTimeKind.Unspecified).AddTicks(4773), "Aşçı" },
                    { 18, "2916ea2c-c308-49e6-8b36-39ea2dbe948b", null, null, null, null, null, 1, "Julio.Auer60@yahoo.com", 3, "Julio", 195.175853318151020m, "1250", true, "Auer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 7, 17, 19, 21, 14, 855, DateTimeKind.Unspecified).AddTicks(1563), "Temizlik Görevlisi" },
                    { 16, "fd0edfd4-a033-4c0a-8a7f-b99d8f840136", null, null, null, null, null, 1, "Hugo4@gmail.com", 3, "Hugo", 192.791799922842440m, "3543", true, "Johns", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 4, 3, 19, 11, 34, 133, DateTimeKind.Unspecified).AddTicks(3483), "Temizlik Görevlisi" },
                    { 15, "0b3e32fd-16c4-4dda-b395-d3c921c546a6", null, null, null, null, null, 1, "Erick42@yahoo.com", 3, "Erick", 197.73250982525410m, "1484", true, "Reynolds", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 26, 20, 16, 28, 257, DateTimeKind.Unspecified).AddTicks(6684), "Temizlik Görevlisi" },
                    { 14, "b060d268-df2c-4dc9-8b33-330192da22cd", null, null, null, null, null, 1, "Johnny_Bins@hotmail.com", 3, "Johnny", 192.952207710106020m, "1798", true, "Bins", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 8, 18, 10, 56, 20, 960, DateTimeKind.Unspecified).AddTicks(9233), "Temizlik Görevlisi" },
                    { 4, "3f174aae-92a5-424a-93b4-549bc2d0e985", null, null, null, null, null, 4, "Lynette_Kuhlman84@hotmail.com", 3, "Lynette", 193.446368460285650m, "4365", true, "Kuhlman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 1, 4, 12, 12, 40, 607, DateTimeKind.Unspecified).AddTicks(7072), "Resepsiyonist" },
                    { 29, "1906ef83-ff42-4d95-8d36-8763583cdb9b", null, null, null, null, null, 3, "Rodney27@yahoo.com", 3, "Rodney", 195.894273741121530m, "6271", true, "Altenwerth", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 2, 17, 2, 48, 28, 66, DateTimeKind.Unspecified).AddTicks(1711), "Aşçı" },
                    { 11, "33f679cd-bde7-4f24-9c25-04d0cd5fffcd", null, null, null, null, null, 1, "Nichole_Bahringer@hotmail.com", 3, "Nichole", 196.358996814284010m, "2632", true, "Bahringer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 5, 18, 13, 39, 57, 467, DateTimeKind.Unspecified).AddTicks(7346), "Temizlik Görevlisi" },
                    { 9, "bead453e-fd54-43d5-9669-714315989044", null, null, null, null, null, 1, "Edmond_DuBuque72@yahoo.com", 3, "Edmond", 190.09273578417149180m, "4854", true, "DuBuque", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 6, 10, 8, 24, 32, 719, DateTimeKind.Unspecified).AddTicks(2832), "Temizlik Görevlisi" },
                    { 8, "0b25144e-ce15-446f-8fcb-005958b94ada", null, null, null, null, null, 1, "Lorenzo_Schulist76@gmail.com", 3, "Lorenzo", 193.836170311009590m, "2280", true, "Schulist", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 10, 8, 22, 42, 10, 964, DateTimeKind.Unspecified).AddTicks(2653), "Temizlik Görevlisi" },
                    { 3, "2f012b31-9ca0-4f92-9cf3-b5ff68ff7f23", null, null, null, null, null, 4, "Martin80@hotmail.com", 3, "Martin", 193.468859211294380m, "1550", true, "Hills", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 12, 19, 3, 41, 23, 295, DateTimeKind.Unspecified).AddTicks(1118), "Resepsiyonist" },
                    { 2, "d50e5880-ac60-4174-9450-9ddb2cc4307a", null, null, null, null, null, 4, "Delbert_Mayert82@hotmail.com", 3, "Delbert", 196.515831237899060m, "3935", true, "Mayert", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 7, 3, 1, 49, 40, 818, DateTimeKind.Unspecified).AddTicks(5595), "Resepsiyonist" },
                    { 1, "d29d616a-9530-4da8-a9e4-00171d261f7f", null, null, null, null, null, 4, "Randy8@gmail.com", 3, "Randy", 194.770552681186490m, "5208", true, "Haley", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 1, 21, 2, 17, 59, 225, DateTimeKind.Unspecified).AddTicks(3407), "Resepsiyonist" },
                    { 10, "f719911c-b2b1-4cd3-958c-3b2cc3b867aa", null, null, null, null, null, 1, "Ross.Blick@gmail.com", 3, "Ross", 196.263246809254980m, "6645", true, "Blick", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 3, 25, 9, 38, 24, 209, DateTimeKind.Unspecified).AddTicks(8454), "Temizlik Görevlisi" }
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
