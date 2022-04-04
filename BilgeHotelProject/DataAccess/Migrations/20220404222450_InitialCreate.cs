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
                name: "Settings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmtpHost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SmtpPort = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    SmtpEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SmtpPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HomePageID = table.Column<int>(type: "int", nullable: false),
                    AboutusID = table.Column<int>(type: "int", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Settings_Aboutus_AboutusID",
                        column: x => x.AboutusID,
                        principalTable: "Aboutus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Settings_Contacts_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contacts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Settings_HomePages_HomePageID",
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
                name: "HotelServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconPicture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SettingID = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_HotelServices_Settings_SettingID",
                        column: x => x.SettingID,
                        principalTable: "Settings",
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
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "f16dbcf2-730d-457d-b556-f6b278ed15a2", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "6f7943e0-761a-4f32-a7b5-d45d293adc5b", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "a8fce85c-c1a7-44b8-9320-b803c8a42fe0", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "6e648c1b-091a-4778-918d-23728dadf1ca", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "39863d36-9f01-48a8-9429-f164573bbef0", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f5a56f9a-9bf9-478f-8987-dc520d1d88da", "user", "USER" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7af1b97f-3731-4ac2-be2d-d024ec0f268a", "mutfak", "MUTFAK" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "cf1573ee-87b2-48b6-a1bc-98033b905d49", "muhasebe", "MUHASEBE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "91568893-feb4-4c07-a523-6ce308888ddd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "2de991b2-efee-4d09-bf2d-94eb51382d53", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clayton.Howell67@hotmail.com", true, "Clayton", "Howell", false, null, "CLAYTON.HOWELL67@HOTMAIL.COM", "CLAYTON.HOWELL67@HOTMAIL.COM", "AHFIa04ylPIVFdhYNb9lKNSIfoK+xAOqa1SrajACfR+QTS4Q8leStkvkmZ8EmlFscg==", "05111111111", false, "505d489e-748f-4f28-ad8d-bc96d1f51386", false, "Clayton.Howell67@hotmail.com" },
                    { "a7263790-59f1-4f6d-b0ec-3bd74899d1d0", 0, new Guid("00000000-0000-0000-0000-000000000000"), "701827cc-fb85-4184-99b5-440ee59aabe8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leland_Kessler77@yahoo.com", true, "Leland", "Kessler", false, null, "LELAND_KESSLER77@YAHOO.COM", "LELAND_KESSLER77@YAHOO.COM", "APfvQz21azfKVRi4N18TXoFihCQ8oZcyUKTOQC44x6G4onx0Y35HL9/u/OldJ7TI2w==", "05111111111", false, "72c633bc-80fa-48c5-9031-bce2ccbcbf94", false, "Leland_Kessler77@yahoo.com" },
                    { "bf58fa77-59af-4b38-af7f-6cc60249b8a5", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6c0698e6-2662-487d-a94d-feaf78b33eff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otis_Sporer30@gmail.com", true, "Otis", "Sporer", false, null, "OTIS_SPORER30@GMAIL.COM", "OTIS_SPORER30@GMAIL.COM", "ALczKB8FhE/uXZSC1L+LRkR9leWlRaaBBV0Gk0O/K0zaMNdryEsCGr+3qBw1rtbioA==", "05111111111", false, "29cd5c43-566a-4f82-8321-b8d288636b7b", false, "Otis_Sporer30@gmail.com" },
                    { "8d796e71-5df5-4fbf-8518-05885e3d5b75", 0, new Guid("00000000-0000-0000-0000-000000000000"), "818346ac-7ddf-40f2-ac0b-cba8e7cc909a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wayne41@hotmail.com", true, "Wayne", "Kassulke", false, null, "WAYNE41@HOTMAIL.COM", "WAYNE41@HOTMAIL.COM", "AKE53Dp5q1/x1fzrww25Aef2220PjEwlsFSCPzblCf2A5wR35AYOpCzi15URYIUXWg==", "05111111111", false, "33b9b1db-b4a1-48d7-89f5-79e6f22baf0b", false, "Wayne41@hotmail.com" },
                    { "04ec5159-4484-4f9b-9ef1-ac947433ecd3", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6fb6aff7-81dc-4d9a-bb39-d8e2edccf7f7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robyn.Quitzon@hotmail.com", true, "Robyn", "Quitzon", false, null, "ROBYN.QUITZON@HOTMAIL.COM", "ROBYN.QUITZON@HOTMAIL.COM", "AApn0pwbLxqTduYN7FpmSC4fZfPDEC1HGHXhbZNN91vYUw9tNrCHMHPZ8pHIj1bUFg==", "05111111111", false, "44b407be-5c41-425f-9a25-7c0da96967d5", false, "Robyn.Quitzon@hotmail.com" },
                    { "4239338b-9d71-4d98-87ab-75cb6805d7db", 0, new Guid("00000000-0000-0000-0000-000000000000"), "53c23197-748f-4710-b435-d514af50bc71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estelle28@hotmail.com", true, "Estelle", "Kris", false, null, "ESTELLE28@HOTMAIL.COM", "ESTELLE28@HOTMAIL.COM", "AJYpTIHgfWRxoapgYmyMSmmo7RUaUXwbotbbGklsVzUyBEUMqynSPW3fWxQn9SRMeA==", "05111111111", false, "11c6b5e4-b1eb-4379-a174-53ca7b45c4db", false, "Estelle28@hotmail.com" },
                    { "8a644b3f-f1c5-4934-8cad-d6b6b0472b3f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "bfffbee5-8412-44e3-82f1-fbbbbd2fb67b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ellis_Schowalter@hotmail.com", true, "Ellis", "Schowalter", false, null, "ELLIS_SCHOWALTER@HOTMAIL.COM", "ELLIS_SCHOWALTER@HOTMAIL.COM", "AEQTtd/VUWI7lerROOXEVkDr61gmWJk47s9x4nlEOnF4wWYPH4tSx+hP9gPhTkEyHQ==", "05111111111", false, "4a574392-1e01-445e-8faa-60647212c2c0", false, "Ellis_Schowalter@hotmail.com" },
                    { "0dbb3350-ac77-4695-94c2-c41095fcb649", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9d993450-fab7-44be-92c7-0fdedd4bc154", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stacy16@hotmail.com", true, "Stacy", "Lebsack", false, null, "STACY16@HOTMAIL.COM", "STACY16@HOTMAIL.COM", "APaTDf8/fp2+EG5Q/nGjzO0QHqC03vsjhv+SnoDSRSjrC6GXKjGP9LbmFMx127zbmQ==", "05111111111", false, "8275eeb5-7934-41e6-b8dc-7a165085e111", false, "Stacy16@hotmail.com" },
                    { "b708da78-f5dd-4b9f-980a-8878435cfa7f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e1f62dc8-a130-4872-9764-93965b53adbd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Damon36@yahoo.com", true, "Damon", "Aufderhar", false, null, "DAMON36@YAHOO.COM", "DAMON36@YAHOO.COM", "AB5CqZMMr2Wkj3L1VLvQA3lqgO0qprcSa2LEE44U+wkCcJ10bU1pBkP9mVF7nJH1sQ==", "05111111111", false, "720b478a-a45d-4865-8cfc-64997af1096d", false, "Damon36@yahoo.com" },
                    { "498253b1-8809-4cc6-9889-2da6fedaf631", 0, new Guid("00000000-0000-0000-0000-000000000000"), "7dfd93fd-6b5f-4f3e-895c-aea8f90002fa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everett59@gmail.com", true, "Everett", "Olson", false, null, "EVERETT59@GMAIL.COM", "EVERETT59@GMAIL.COM", "ABHas8A2qZY/Seem+AEPr60WONA23AlLr4cu+aDxvpYOcMCoZcPS0zf86X2yEI/4Dg==", "05111111111", false, "36e75960-96f2-47d3-9c06-a9a8ec2bcf25", false, "Everett59@gmail.com" },
                    { "f080f977-63eb-4b54-8047-9de9bf5798df", 0, new Guid("00000000-0000-0000-0000-000000000000"), "285709db-8271-4d2b-9c15-88bbdd9036ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Calvin_Little@hotmail.com", true, "Calvin", "Little", false, null, "CALVIN_LITTLE@HOTMAIL.COM", "CALVIN_LITTLE@HOTMAIL.COM", "AHx5EdNokecnqd7Laoj7M48Etn+5EYTt5UO9yF3bgZx5vYHqdR3fvCqayP1CXwhsYQ==", "05111111111", false, "d7a943ed-1110-490c-9ee3-af5dec7fed37", false, "Calvin_Little@hotmail.com" },
                    { "b51b9fee-6cc2-4cec-8fd4-fbf936cc4d5f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "341b668e-079c-417a-b370-fbf0e76c4ff6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elisa51@yahoo.com", true, "Elisa", "Hegmann", false, null, "ELISA51@YAHOO.COM", "ELISA51@YAHOO.COM", "AGUk4wBYuehecrnVhhoQBOM3cF74H+8ERrjQMWPuPwUS784BGpS2pU1X9r5EZ3szLw==", "05111111111", false, "5c6a2f20-9d9c-42a1-a832-b89b4d60f100", false, "Elisa51@yahoo.com" },
                    { "186d7d00-399f-461b-8e74-0b185d04d390", 0, new Guid("00000000-0000-0000-0000-000000000000"), "78d9093d-a08e-47ad-b334-58a3f5275e5c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flora.McGlynn@yahoo.com", true, "Flora", "McGlynn", false, null, "FLORA.MCGLYNN@YAHOO.COM", "FLORA.MCGLYNN@YAHOO.COM", "AKDnC4nYyVodPS9ckCPDcUvulCG8gVy1kg0i8Jvz1OFFgUsxZratWEEqK9Uxxg4YKg==", "05111111111", false, "ed31075a-8938-4a05-bd94-4afabce8ea01", false, "Flora.McGlynn@yahoo.com" },
                    { "1c5463b5-5ce9-4b2a-974d-94026ee3e28d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "37ec58ed-4e60-4e33-99b8-1076660184aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freda86@hotmail.com", true, "Freda", "Bauch", false, null, "FREDA86@HOTMAIL.COM", "FREDA86@HOTMAIL.COM", "AG9vobQNcdldC7OOu4OGm26CBwuFHpDgbYdW+7rbZrIZFoj1u2kgpvIPVT39R/55fA==", "05111111111", false, "4ec7462b-f351-4d4a-bb9c-eb63edbfcadc", false, "Freda86@hotmail.com" },
                    { "2eff5e09-9423-413b-bc53-bc1005a69ab5", 0, new Guid("00000000-0000-0000-0000-000000000000"), "736341d1-7bfc-481b-9aa2-18dac361d947", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lynne91@hotmail.com", true, "Lynne", "Herman", false, null, "LYNNE91@HOTMAIL.COM", "LYNNE91@HOTMAIL.COM", "AGPAngp2bi8+kGx0Ge0shTdO+7smOj9FjW6fiRxlU6w4ed6fctf7z4lh8iYPv47PDA==", "05111111111", false, "c01b7282-e492-4b0f-9b54-ac1417931605", false, "Lynne91@hotmail.com" },
                    { "68a18ffe-ec3a-40f6-ac08-2b39dc044d6a", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5572efab-dad2-4f8f-87f9-9c1eb4798156", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rogelio.Yundt27@hotmail.com", true, "Rogelio", "Yundt", false, null, "ROGELIO.YUNDT27@HOTMAIL.COM", "ROGELIO.YUNDT27@HOTMAIL.COM", "AA9AW1shRb1PT8maCZM/rEFyCgsKj9tCTsKMwOP1EkAQzqxphNCRNCbezi6qdoDAPA==", "05111111111", false, "7d828763-4c75-48d1-8ab7-5f0ca795ed96", false, "Rogelio.Yundt27@hotmail.com" },
                    { "7e7deb9d-2f0e-4496-83f6-3f7f1c02d3c5", 0, new Guid("00000000-0000-0000-0000-000000000000"), "428942ab-d697-49ae-b2e1-ce626cea7bcd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dawn.Schaefer@hotmail.com", true, "Dawn", "Schaefer", false, null, "DAWN.SCHAEFER@HOTMAIL.COM", "DAWN.SCHAEFER@HOTMAIL.COM", "ANiOHSyl7EsdzCjLevYzKwbOnsvXy2WMwNIpR7uHtyf92IZNklp8o9HpizAtbvHqBA==", "05111111111", false, "adb20ea9-cc2c-4a1b-93a5-87c302b3efe0", false, "Dawn.Schaefer@hotmail.com" },
                    { "0f6cfb56-f35d-46e4-9b2f-f0e5264a696f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e896795c-ebb7-4cf6-a0bb-7eb1301b708b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosemary24@hotmail.com", true, "Rosemary", "Ullrich", false, null, "ROSEMARY24@HOTMAIL.COM", "ROSEMARY24@HOTMAIL.COM", "AMGplRAFGLI3g/vJZQma8288e/QH38ysylJF4Qx5wWnOZEsy1dvlLdwtMV+lx75gOg==", "05111111111", false, "096b7398-7212-4304-95ab-4c0cc6eb9e12", false, "Rosemary24@hotmail.com" },
                    { "a8ce5158-6ebb-4ede-8154-296c471e76dd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b98f9e11-eea3-4976-8e19-170b7082762d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel_Murray20@yahoo.com", true, "Samuel", "Murray", false, null, "SAMUEL_MURRAY20@YAHOO.COM", "SAMUEL_MURRAY20@YAHOO.COM", "AMRqPpLPMDMjwVpL1hdQFiUQPJ8GU8FCrUbf0xj76KrQm1eOR7j1S11nUqoVPa85fA==", "05111111111", false, "e93c63e1-85f7-43cd-87de-147a2c8d21d8", false, "Samuel_Murray20@yahoo.com" },
                    { "3c0f0dda-f64e-4760-8c55-374f7b42089e", 0, new Guid("00000000-0000-0000-0000-000000000000"), "75eb149a-6e9f-4832-bb84-439c8b7191a3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irene10@gmail.com", true, "Irene", "Pollich", false, null, "IRENE10@GMAIL.COM", "IRENE10@GMAIL.COM", "AD6sZTobtQinBMZbiWapj3TfczVSOVBgsv3hUKPZ44EU4DHn1eKioiSAQGBQT2/tCw==", "05111111111", false, "31f4afd2-cf75-4962-9481-edb5c1b1a249", false, "Irene10@gmail.com" },
                    { "5342700a-8c50-47ad-9599-039c6540fc99", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f7bd41c5-25dd-4b0f-97e4-476ae6584745", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Louise10@gmail.com", true, "Louise", "Dickens", false, null, "LOUISE10@GMAIL.COM", "LOUISE10@GMAIL.COM", "AEgZjNN1n49Mr4j7jNyEUkc4CnMdqAEB7Hp5ZD/I5bknzd0P/Ii4N7CEvOOHzfr5LA==", "05111111111", false, "697d85db-7a9e-46ef-848e-0cdcbcc090ce", false, "Louise10@gmail.com" },
                    { "24a7031f-3180-41fc-a471-555024ca8d66", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6074203e-e76b-48f8-b029-89f069b4a048", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayla.Reilly19@hotmail.com", true, "Kayla", "Reilly", false, null, "KAYLA.REILLY19@HOTMAIL.COM", "KAYLA.REILLY19@HOTMAIL.COM", "AE/L5DZuFbTMFC/HM8u9GwPHqQa7rdNT60kSSEVyQ5XnVlwUXn0wKR8uzw0JB6E+MQ==", "05111111111", false, "fe5dcecc-7ec6-4875-ba9c-5be824e4707a", false, "Kayla.Reilly19@hotmail.com" },
                    { "73ff4615-f322-439e-9251-83e45d2d8188", 0, new Guid("00000000-0000-0000-0000-000000000000"), "34192c9c-0e49-4372-b3a5-33601c07eb0d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rafael_Weissnat27@yahoo.com", true, "Rafael", "Weissnat", false, null, "RAFAEL_WEISSNAT27@YAHOO.COM", "RAFAEL_WEISSNAT27@YAHOO.COM", "AIDbMhgIRdRyG1IHpzqPzgr5UWNkngLE18/lkO0FIqYF/9RLTZEsxqv4AjYi+r338w==", "05111111111", false, "3f3e662a-0ac9-4fbf-898b-fc66d629ee14", false, "Rafael_Weissnat27@yahoo.com" },
                    { "a1f2c838-8c0f-42d6-a480-1da6bd1ff4a9", 0, new Guid("00000000-0000-0000-0000-000000000000"), "daa01998-d9ed-4baf-b44a-0379ede740d8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kristi.Moen1@yahoo.com", true, "Kristi", "Moen", false, null, "KRISTI.MOEN1@YAHOO.COM", "KRISTI.MOEN1@YAHOO.COM", "AKGofR+R3pI4gQyz+UJki4BLywWX2R78ixlA5EnLvbNbn0feELYaAvYcI8Tw6rSAVg==", "05111111111", false, "5d60fb5d-5831-49d4-83ae-d3714b89db84", false, "Kristi.Moen1@yahoo.com" },
                    { "bdc19aee-648f-4e35-bffd-0a151340f9ce", 0, new Guid("00000000-0000-0000-0000-000000000000"), "a82f979e-92a0-467a-b566-7bb130478055", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cornelius85@hotmail.com", true, "Cornelius", "Mueller", false, null, "CORNELIUS85@HOTMAIL.COM", "CORNELIUS85@HOTMAIL.COM", "AJVoATNo+/VCgP7q2cbp/N2ig+AoO+7XEM9/aR/EzIy9dUj6LepyhU9EHgNhkr4Erw==", "05111111111", false, "82e7da04-b600-437e-974b-55adcd501cf7", false, "Cornelius85@hotmail.com" },
                    { "746bf451-2f0f-40bf-b10a-4c6faf62c132", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f1c7b45e-2008-49c5-ab4e-a2276eb5992b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfonso68@gmail.com", true, "Alfonso", "Murray", false, null, "ALFONSO68@GMAIL.COM", "ALFONSO68@GMAIL.COM", "AOzJ6eMl9CpG6TjjgASBOOKsNWYGiQ4H3xkT+3cdETHtXhGrQwnalhT4JdQwLd4OcQ==", "05111111111", false, "7dda579c-57cc-4544-a544-44c504e936fc", false, "Alfonso68@gmail.com" },
                    { "758cac08-c79e-4683-bd68-bc7b13feca19", 0, new Guid("00000000-0000-0000-0000-000000000000"), "759d48b0-568e-4274-a3d5-95cdd268c329", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergio.Deckow67@hotmail.com", true, "Sergio", "Deckow", false, null, "SERGIO.DECKOW67@HOTMAIL.COM", "SERGIO.DECKOW67@HOTMAIL.COM", "AKwLG52l7pbLwf9XQLw5VmIlkEqaaZ1ROqux7+H98EkZSDuaK7jOVg6Y7dJSP6wAIA==", "05111111111", false, "b0563c51-aa8d-41e7-8c62-9555ae039c04", false, "Sergio.Deckow67@hotmail.com" },
                    { "4b0ba339-7c65-4d0d-b421-1f84ff78db57", 0, new Guid("00000000-0000-0000-0000-000000000000"), "8439968b-34bd-4423-9cf7-0d20df515cb7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam_Powlowski83@gmail.com", true, "Sam", "Powlowski", false, null, "SAM_POWLOWSKI83@GMAIL.COM", "SAM_POWLOWSKI83@GMAIL.COM", "AITzhNtWNMMMeic6rqvyw2iOiUDAN9jmy0pgApDuZugv7v11frDMPqCaJMnF0FT2jg==", "05111111111", false, "93c26763-21e1-466a-8a4b-a34ff1bd9aae", false, "Sam_Powlowski83@gmail.com" },
                    { "16edb950-186f-42f4-9cec-6a33f8d69a1d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "aa891fd7-24e6-44ec-9e08-328fc5b3bc12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edith21@gmail.com", true, "Edith", "Schneider", false, null, "EDITH21@GMAIL.COM", "EDITH21@GMAIL.COM", "AL6DKK32IUqsdZW369zoLorX3S+JgcbwuQrVKzjvYcbuIc6gMNoUuFmovIO/FvPC5Q==", "05111111111", false, "3f0e1b6f-1391-421a-a08b-38d44258828a", false, "Edith21@gmail.com" },
                    { "3465ba99-caf2-4849-af96-6a55851a5b77", 0, new Guid("00000000-0000-0000-0000-000000000000"), "4bf7efeb-9dd3-4fe6-a062-40365ae1a2ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paulette_Jerde30@yahoo.com", true, "Paulette", "Jerde", false, null, "PAULETTE_JERDE30@YAHOO.COM", "PAULETTE_JERDE30@YAHOO.COM", "AG4OYoX41WG/rEr8R9p958Eix4W5HwV4a4GrsVpj+bCCqEmTATVvZSPELZtukGpF+g==", "05111111111", false, "6a73a8bd-18a5-475c-97ae-9c2f28ebea3a", false, "Paulette_Jerde30@yahoo.com" },
                    { "7adeb4ea-e823-4699-ad3b-7eb2a3f0b749", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f5fcd88b-296c-460e-9b14-d07df571b4d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winifred25@hotmail.com", true, "Winifred", "Corwin", false, null, "WINIFRED25@HOTMAIL.COM", "WINIFRED25@HOTMAIL.COM", "ABL9ZNindSQYdCVIu3J1ntZ8dhf4Kv9whq5OgwTfYguXetu3oUQm0b2UXDoDwfy5XA==", "05111111111", false, "30b7a3f1-d7a4-488a-b472-f1c623cf895b", false, "Winifred25@hotmail.com" },
                    { "ed31056b-7fb0-4e77-b7e8-4085cbc926d7", 0, new Guid("00000000-0000-0000-0000-000000000000"), "4eec4a7f-7af7-41e1-886e-4b584e72c200", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee.Mayer99@gmail.com", true, "Lee", "Mayer", false, null, "LEE.MAYER99@GMAIL.COM", "LEE.MAYER99@GMAIL.COM", "AN/XwxjjJp2Tu3GkPoLztaxgtlbpWZM5gO34nS0uOOEeueYJTiWMtQxqz0Q48JS5Pg==", "05111111111", false, "38cb8e1d-fba9-44f2-b627-f7f847c28ad8", false, "Lee.Mayer99@gmail.com" },
                    { "0083f5f9-e6fd-475a-a2df-f43523008feb", 0, new Guid("00000000-0000-0000-0000-000000000000"), "8cbfd3aa-94d7-4672-93fe-5c3eec86eb7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jodi70@yahoo.com", true, "Jodi", "Volkman", false, null, "JODI70@YAHOO.COM", "JODI70@YAHOO.COM", "AFIH3XQZERGiDbXqi3tQ2pXNeQJtCU3fdCs+vRD8Ux6iKZMemMBnbbZcfCA9isjZkg==", "05111111111", false, "096060c9-a0a4-46b7-8cb5-001d95c0427a", false, "Jodi70@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "65ddf361-0344-465d-ab9e-b818daaf0be7", 0, new Guid("00000000-0000-0000-0000-000000000000"), "73bb9168-6c5d-41c2-984b-9b6f38bcfaa2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin.Gerhold@gmail.com", true, "Justin", "Gerhold", false, null, "JUSTIN.GERHOLD@GMAIL.COM", "JUSTIN.GERHOLD@GMAIL.COM", "APQr7GNi0o9pQbPsKnONG3QU45SL2dbLJCemBa0kMQb2SZJZypB66ufjinXZOAdukA==", "05111111111", false, "5cf801e5-2e88-4edc-b03d-9b2a752399fb", false, "Justin.Gerhold@gmail.com" },
                    { "ead7f891-0ef9-49ee-a5c2-cb7302311447", 0, new Guid("00000000-0000-0000-0000-000000000000"), "624bb009-6273-4922-a569-ecd71d68fad5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly.Braun68@gmail.com", true, "Kimberly", "Braun", false, null, "KIMBERLY.BRAUN68@GMAIL.COM", "KIMBERLY.BRAUN68@GMAIL.COM", "AEGGtHrr1XS/EdSwcEjsBfEjbJgsNaAmJ58yORxxS46vghkFrQJcgZA+4mkbhgW7XA==", "05111111111", false, "adee2c8e-2ce1-4a85-a0c5-855339612add", false, "Kimberly.Braun68@gmail.com" },
                    { "6e02fba6-cf2e-4ac4-b2c2-077e659740d4", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e9e3451c-b525-446b-9ae9-5d3829725dea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janice85@hotmail.com", true, "Janice", "Gaylord", false, null, "JANICE85@HOTMAIL.COM", "JANICE85@HOTMAIL.COM", "AMBahub2Jd1yw4NDIQjiYtKhEYcvlTjreJoPCbTp7nquRQPUORb1mbUXO/xIYVf/Aw==", "05111111111", false, "6aedc9e0-b88c-464d-ab36-c1d8ba6c9ff8", false, "Janice85@hotmail.com" },
                    { "f0773878-23d7-4835-a421-6e2ed4ab8038", 0, new Guid("00000000-0000-0000-0000-000000000000"), "d7a8cd7d-470a-4455-9e19-0540ee02285e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darren9@yahoo.com", true, "Darren", "Oberbrunner", false, null, "DARREN9@YAHOO.COM", "DARREN9@YAHOO.COM", "AJLMRykom99Z8Bip620hEqaoEtrw1z/vAZhGUPc48UilIy2YZnwe1/Ekfi3lxKgbDw==", "05111111111", false, "e36951ce-e131-4769-a7b8-317b9056f6e1", false, "Darren9@yahoo.com" },
                    { "51b8feca-22c2-49aa-a83b-c79b81393563", 0, new Guid("00000000-0000-0000-0000-000000000000"), "45d3e12c-2b4e-4a90-9815-e4dfdc0bb2d2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johanna_Donnelly54@hotmail.com", true, "Johanna", "Donnelly", false, null, "JOHANNA_DONNELLY54@HOTMAIL.COM", "JOHANNA_DONNELLY54@HOTMAIL.COM", "AK3Gh6Fla+DuDkt04y5cGlMemSV98u6Ocdhr3ArRKnlkIfdb6FEr0DLrxx+HaUa2qA==", "05111111111", false, "f8f9af44-1aeb-42bc-b55a-4668032aef07", false, "Johanna_Donnelly54@hotmail.com" },
                    { "e02a26ff-8714-4309-9b94-cd438dab006d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "8ac4c178-208f-4c46-8fa4-74b7fcb65cdf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delbert_Lesch81@hotmail.com", true, "Delbert", "Lesch", false, null, "DELBERT_LESCH81@HOTMAIL.COM", "DELBERT_LESCH81@HOTMAIL.COM", "AHVQ4Ftg5P/hJgp/zALMgCiBy/z0XJO+8Mr02xUl1xW3Rdxjhy0NQrWIsxyzrOv2NA==", "05111111111", false, "d7ea31e9-ff39-4ca6-aa95-c160bc47f0c1", false, "Delbert_Lesch81@hotmail.com" },
                    { "b7fccc7c-fff8-4ccc-840c-4e6ecec3ddc4", 0, new Guid("00000000-0000-0000-0000-000000000000"), "3ff60961-5295-44c8-856e-c691bcf7f1f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hector20@yahoo.com", true, "Hector", "Huels", false, null, "HECTOR20@YAHOO.COM", "HECTOR20@YAHOO.COM", "AOvOIknD2FG6pqLmH/wZsnyhkp8rf8EjfXG/7F4++X94Yzfel4Dmu49iiQbNMSTXpA==", "05111111111", false, "ddaec124-668e-49e4-91c7-0ef656d4647f", false, "Hector20@yahoo.com" },
                    { "bfdb57ee-9ce1-4f57-a2af-cc89b606c643", 0, new Guid("00000000-0000-0000-0000-000000000000"), "2115fbed-86dd-4d36-a7c9-87a4f3ccb98c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donna.Huels@hotmail.com", true, "Donna", "Huels", false, null, "DONNA.HUELS@HOTMAIL.COM", "DONNA.HUELS@HOTMAIL.COM", "AN3NnwItmEgOHwqdt6jySyhtZoh/oHItBELMmBggLJxoAco3pFqW5xnmThmOXpF+zQ==", "05111111111", false, "30ecfeda-ff0f-4f53-acce-e49689eb8f2a", false, "Donna.Huels@hotmail.com" },
                    { "8aefe060-1b14-446e-8780-16342e0d1fa6", 0, new Guid("00000000-0000-0000-0000-000000000000"), "d854bf41-644f-42fe-b42d-48ef837d363f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elbert28@yahoo.com", true, "Elbert", "Volkman", false, null, "ELBERT28@YAHOO.COM", "ELBERT28@YAHOO.COM", "AKdx6ZBV5miS9EibDMfoWLuKIPVUbRNedjWFKYpaQHdBVkk2ZiIbtiixgSkjF7zDig==", "05111111111", false, "87953814-e532-4e8f-9578-3a088a7aac78", false, "Elbert28@yahoo.com" },
                    { "5b1c893c-4baa-4e91-99f3-e837cd63585b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "da534738-ba44-4d99-a918-9abc3c2df68c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tricia.Wiza@yahoo.com", true, "Tricia", "Wiza", false, null, "TRICIA.WIZA@YAHOO.COM", "TRICIA.WIZA@YAHOO.COM", "ADG5Fru8avuHETYpEq0Lz/8Iw+RVAtyLEyO2sx85ZFrMsgeVZ6dyLb8gISDO2LmCfw==", "05111111111", false, "294b0957-12e7-4b41-be4a-213e3ecac023", false, "Tricia.Wiza@yahoo.com" },
                    { "33c98c9f-d8f0-42a6-b105-80f246aa2c11", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1224e130-4d08-4e54-9bda-3c51fab0a7ce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlene_Hayes@gmail.com", true, "Arlene", "Hayes", false, null, "ARLENE_HAYES@GMAIL.COM", "ARLENE_HAYES@GMAIL.COM", "AJqCz2Upvs/n77Hk4Vef5I5DSL3vP2rDTmdAfbwqkZiqLo4BDejsp20p/wq4h3Swpw==", "05111111111", false, "8fc0dcff-c813-4124-b9c8-2919e020d4bc", false, "Arlene_Hayes@gmail.com" },
                    { "3fbe28a2-383a-4bc1-91c3-39c49600fdf7", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b22a5d5f-a1ca-455d-b25a-69f533365199", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mack_Hilpert@yahoo.com", true, "Mack", "Hilpert", false, null, "MACK_HILPERT@YAHOO.COM", "MACK_HILPERT@YAHOO.COM", "AODtrWDBvE8QIlb51apuEbrEzMesm1DAmoHfnG4c6kVQxBoaSc9T5YTnSnY9YJNIVA==", "05111111111", false, "4a7babed-7176-4e5c-910b-c1c8df8374ce", false, "Mack_Hilpert@yahoo.com" },
                    { "4e66fd1d-0b73-4f78-a631-cfc3fd0f0bf6", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9a9efa00-fead-43ab-9bd1-7e721834c07c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miriam.Bernier48@hotmail.com", true, "Miriam", "Bernier", false, null, "MIRIAM.BERNIER48@HOTMAIL.COM", "MIRIAM.BERNIER48@HOTMAIL.COM", "AGLO9Hg4hsUrkxCDuS+mM8e6F2QDiz09iO8piblolTZFCHIR8bEtEfUHwe6l1YYLiw==", "05111111111", false, "43a6c526-da7a-44ae-8f37-2905eaf1a2bb", false, "Miriam.Bernier48@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Email", "Facebook", "Fax", "Instagram", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "93521 McDermott Divide, Gulgowskiland, Greenland", null, null, null, null, null, "Mack23@yahoo.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, null, null, null, null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 6, null, null, null, null, null, "İnsan Kaynakları", null, null, null, null, null, null },
                    { 4, null, null, null, null, null, "Resepsiyon", null, null, null, null, null, null },
                    { 3, null, null, null, null, null, "Mutfak", null, null, null, null, null, null },
                    { 2, null, null, null, null, null, "Bilgi İşlem", null, null, null, null, null, null },
                    { 1, null, null, null, null, null, "Yardımcı Hizmetler", null, null, null, null, null, null },
                    { 5, null, null, null, null, null, "Yönetim", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ExtraServices",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Price", "ServiceName" },
                values: new object[,]
                {
                    { 2, null, null, null, null, null, null, null, null, null, null, 400m, "Hamam" },
                    { 1, null, null, null, null, null, null, null, null, null, null, 600m, "Sauna" }
                });

            migrationBuilder.InsertData(
                table: "HomePages",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Paragraph1", "Paragraph2", "Paragraph3", "Paragraph4", "Paragraph5", "PictureUrl", "Subtitle", "Title" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, "Bilge Hotel Thermal Spa & Convention Center; Kemer şehir merkezinde, güler yüzlü ve profesyonel ekibi ile beklentilerin üzerinde hizmet vermektedir.", "Bilge Hotel 35 yıllık deneyimi, misafir memnuniyeti odaklı hizmet anlayışı ile sizleri kaliteye ve konfora davet ediyor.", null, null, null, "/img/homepage-img.jpg", "Bilge Hotel'e Hoşgeldiniz...", "Kalite ve Konfor" });

            migrationBuilder.InsertData(
                table: "RoomFacilities",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FacilityName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "Klima", null, null, null, null, null },
                    { 2, null, null, null, null, null, null, "Tv", null, null, null, null, null },
                    { 3, null, null, null, null, null, null, "Saç Kurutma Makinesi", null, null, null, null, null },
                    { 4, null, null, null, null, null, null, "Kablosuz Internet", null, null, null, null, null },
                    { 5, null, null, null, null, null, null, "Minibar", null, null, null, null, null },
                    { 6, null, null, null, null, null, null, "Balkon", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "NumberOfBed", "NumberOfPeople", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 4, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda üç adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 3, 1500m, "Triple Room" },
                    { 2, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik iki adet yatak bulunmaktadır.", null, null, null, null, null, 2, 2, 1050m, "Double Room" },
                    { 3, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda iki kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 2, 1050m, "Double Superior Room" },
                    { 1, null, null, null, null, null, "15 - 20 m² Single Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 1, 600m, "Single Room" },
                    { 7, null, null, null, null, null, "Yatak odası, yemek yeme alanına sahip oturma salonu ve iki ayrı banyosuyla 85 m² olan geniş kullanım alanı, şehir ve dağ manzarası ile konforu sunuyor.Rahatlamak ve keyif almak için özel olarak tasarlanan jakuzili banyoda ruhunuzu ve bedeninizi dinlendirebilir, gününüzü keyifle noktalayabilirsiniz.", null, null, null, null, null, 1, 2, 2500m, "Presidential Suite" },
                    { 6, null, null, null, null, null, "30 - 35 m² Family Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet çift kişilik, iki adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 4, 1900m, "Family Room" },
                    { 5, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet tek kişilik, bir adet iki kişilik yatak bulunmaktadır.", null, null, null, null, null, 2, 3, 1500m, "Triple Superior Room" }
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
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "1c5463b5-5ce9-4b2a-974d-94026ee3e28d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "51b8feca-22c2-49aa-a83b-c79b81393563" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e02a26ff-8714-4309-9b94-cd438dab006d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b7fccc7c-fff8-4ccc-840c-4e6ecec3ddc4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a1f2c838-8c0f-42d6-a480-1da6bd1ff4a9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7adeb4ea-e823-4699-ad3b-7eb2a3f0b749" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "24a7031f-3180-41fc-a471-555024ca8d66" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5342700a-8c50-47ad-9599-039c6540fc99" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a7263790-59f1-4f6d-b0ec-3bd74899d1d0" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bf58fa77-59af-4b38-af7f-6cc60249b8a5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8d796e71-5df5-4fbf-8518-05885e3d5b75" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "04ec5159-4484-4f9b-9ef1-ac947433ecd3" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4239338b-9d71-4d98-87ab-75cb6805d7db" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8a644b3f-f1c5-4934-8cad-d6b6b0472b3f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0dbb3350-ac77-4695-94c2-c41095fcb649" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ead7f891-0ef9-49ee-a5c2-cb7302311447" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "498253b1-8809-4cc6-9889-2da6fedaf631" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f080f977-63eb-4b54-8047-9de9bf5798df" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b51b9fee-6cc2-4cec-8fd4-fbf936cc4d5f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1c5463b5-5ce9-4b2a-974d-94026ee3e28d" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f0773878-23d7-4835-a421-6e2ed4ab8038" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "3c0f0dda-f64e-4760-8c55-374f7b42089e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "33c98c9f-d8f0-42a6-b105-80f246aa2c11" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3fbe28a2-383a-4bc1-91c3-39c49600fdf7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3c0f0dda-f64e-4760-8c55-374f7b42089e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a8ce5158-6ebb-4ede-8154-296c471e76dd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0f6cfb56-f35d-46e4-9b2f-f0e5264a696f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7e7deb9d-2f0e-4496-83f6-3f7f1c02d3c5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "68a18ffe-ec3a-40f6-ac08-2b39dc044d6a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2eff5e09-9423-413b-bc53-bc1005a69ab5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b708da78-f5dd-4b9f-980a-8878435cfa7f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "186d7d00-399f-461b-8e74-0b185d04d390" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "91568893-feb4-4c07-a523-6ce308888ddd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bdc19aee-648f-4e35-bffd-0a151340f9ce" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "746bf451-2f0f-40bf-b10a-4c6faf62c132" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "758cac08-c79e-4683-bd68-bc7b13feca19" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4b0ba339-7c65-4d0d-b421-1f84ff78db57" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "16edb950-186f-42f4-9cec-6a33f8d69a1d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3465ba99-caf2-4849-af96-6a55851a5b77" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ed31056b-7fb0-4e77-b7e8-4085cbc926d7" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0083f5f9-e6fd-475a-a2df-f43523008feb" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "65ddf361-0344-465d-ab9e-b818daaf0be7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5b1c893c-4baa-4e91-99f3-e837cd63585b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6e02fba6-cf2e-4ac4-b2c2-077e659740d4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4e66fd1d-0b73-4f78-a631-cfc3fd0f0bf6" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8aefe060-1b14-446e-8780-16342e0d1fa6" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "a8ce5158-6ebb-4ede-8154-296c471e76dd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bfdb57ee-9ce1-4f57-a2af-cc89b606c643" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "7e7deb9d-2f0e-4496-83f6-3f7f1c02d3c5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "8aefe060-1b14-446e-8780-16342e0d1fa6" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "33c98c9f-d8f0-42a6-b105-80f246aa2c11" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f0773878-23d7-4835-a421-6e2ed4ab8038" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "51b8feca-22c2-49aa-a83b-c79b81393563" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e02a26ff-8714-4309-9b94-cd438dab006d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b7fccc7c-fff8-4ccc-840c-4e6ecec3ddc4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bfdb57ee-9ce1-4f57-a2af-cc89b606c643" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "a1f2c838-8c0f-42d6-a480-1da6bd1ff4a9" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7adeb4ea-e823-4699-ad3b-7eb2a3f0b749" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "24a7031f-3180-41fc-a471-555024ca8d66" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5342700a-8c50-47ad-9599-039c6540fc99" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "a7263790-59f1-4f6d-b0ec-3bd74899d1d0" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bf58fa77-59af-4b38-af7f-6cc60249b8a5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "8d796e71-5df5-4fbf-8518-05885e3d5b75" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "04ec5159-4484-4f9b-9ef1-ac947433ecd3" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4239338b-9d71-4d98-87ab-75cb6805d7db" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "8a644b3f-f1c5-4934-8cad-d6b6b0472b3f" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "0f6cfb56-f35d-46e4-9b2f-f0e5264a696f" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ead7f891-0ef9-49ee-a5c2-cb7302311447" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "498253b1-8809-4cc6-9889-2da6fedaf631" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "3fbe28a2-383a-4bc1-91c3-39c49600fdf7" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4e66fd1d-0b73-4f78-a631-cfc3fd0f0bf6" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "0dbb3350-ac77-4695-94c2-c41095fcb649" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5b1c893c-4baa-4e91-99f3-e837cd63585b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6e02fba6-cf2e-4ac4-b2c2-077e659740d4" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "68a18ffe-ec3a-40f6-ac08-2b39dc044d6a" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "2eff5e09-9423-413b-bc53-bc1005a69ab5" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "b708da78-f5dd-4b9f-980a-8878435cfa7f" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "1c5463b5-5ce9-4b2a-974d-94026ee3e28d" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "186d7d00-399f-461b-8e74-0b185d04d390" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "91568893-feb4-4c07-a523-6ce308888ddd" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "bdc19aee-648f-4e35-bffd-0a151340f9ce" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "746bf451-2f0f-40bf-b10a-4c6faf62c132" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "4b0ba339-7c65-4d0d-b421-1f84ff78db57" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "758cac08-c79e-4683-bd68-bc7b13feca19" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "73ff4615-f322-439e-9251-83e45d2d8188" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "f080f977-63eb-4b54-8047-9de9bf5798df" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "65ddf361-0344-465d-ab9e-b818daaf0be7" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "b51b9fee-6cc2-4cec-8fd4-fbf936cc4d5f" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "ed31056b-7fb0-4e77-b7e8-4085cbc926d7" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3465ba99-caf2-4849-af96-6a55851a5b77" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "16edb950-186f-42f4-9cec-6a33f8d69a1d" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "0083f5f9-e6fd-475a-a2df-f43523008feb" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "73ff4615-f322-439e-9251-83e45d2d8188" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "b51b9fee-6cc2-4cec-8fd4-fbf936cc4d5f", null, null, null, null, null, 2, "Elisa51@yahoo.com", 3, "Elisa", 195.813818446273830m, "4389", true, "Hegmann", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 2, 24, 13, 18, 16, 333, DateTimeKind.Unspecified).AddTicks(2044), "Bilgi İşlem Sorumlusu" },
                    { 31, "7adeb4ea-e823-4699-ad3b-7eb2a3f0b749", null, null, null, null, null, 3, "Winifred25@hotmail.com", 3, "Winifred", 198.572303959434990m, "2550", true, "Corwin", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 21, 13, 36, 4, 781, DateTimeKind.Unspecified).AddTicks(6702), "Garson" },
                    { 43, "f080f977-63eb-4b54-8047-9de9bf5798df", null, null, null, null, null, 1, "Calvin_Little@hotmail.com", 3, "Calvin", 196.803197714874150m, "4978", true, "Little", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 9, 16, 12, 38, 4, 205, DateTimeKind.Unspecified).AddTicks(5596), "Elektirikçi" },
                    { 36, "8d796e71-5df5-4fbf-8518-05885e3d5b75", null, null, null, null, null, 3, "Wayne41@hotmail.com", 3, "Wayne", 194.92655759441040m, "7878", true, "Kassulke", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 10, 23, 15, 37, 5, 206, DateTimeKind.Unspecified).AddTicks(8406), "Garson" },
                    { 35, "bf58fa77-59af-4b38-af7f-6cc60249b8a5", null, null, null, null, null, 3, "Otis_Sporer30@gmail.com", 3, "Otis", 193.608101319339170m, "8444", true, "Sporer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 1, 21, 13, 31, 47, 423, DateTimeKind.Unspecified).AddTicks(4589), "Garson" },
                    { 34, "a7263790-59f1-4f6d-b0ec-3bd74899d1d0", null, null, null, null, null, 3, "Leland_Kessler77@yahoo.com", 3, "Leland", 191.96354946678670m, "6975", true, "Kessler", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 4, 19, 17, 25, 865, DateTimeKind.Unspecified).AddTicks(9686), "Garson" },
                    { 33, "5342700a-8c50-47ad-9599-039c6540fc99", null, null, null, null, null, 3, "Louise10@gmail.com", 3, "Louise", 197.905111535408120m, "1550", true, "Dickens", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 6, 27, 15, 55, 55, 594, DateTimeKind.Unspecified).AddTicks(6028), "Garson" },
                    { 32, "24a7031f-3180-41fc-a471-555024ca8d66", null, null, null, null, null, 3, "Kayla.Reilly19@hotmail.com", 3, "Kayla", 193.229083508825430m, "9513", true, "Reilly", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 27, 10, 56, 46, 22, DateTimeKind.Unspecified).AddTicks(2981), "Garson" },
                    { 22, "3fbe28a2-383a-4bc1-91c3-39c49600fdf7", null, null, null, null, null, 3, "Mack_Hilpert@yahoo.com", 3, "Mack", 191.207412654164910m, "9782", true, "Hilpert", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 7, 19, 17, 11, 29, 362, DateTimeKind.Unspecified).AddTicks(2063), "Aşçı" },
                    { 24, "33c98c9f-d8f0-42a6-b105-80f246aa2c11", null, null, null, null, null, 3, "Arlene_Hayes@gmail.com", 3, "Arlene", 193.555256539748640m, "4311", true, "Hayes", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 8, 22, 17, 45, 27, 754, DateTimeKind.Unspecified).AddTicks(5010), "Aşçı" },
                    { 23, "8aefe060-1b14-446e-8780-16342e0d1fa6", null, null, null, null, null, 3, "Elbert28@yahoo.com", 3, "Elbert", 195.92982682209920m, "3540", true, "Volkman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 7, 27, 14, 21, 36, 926, DateTimeKind.Unspecified).AddTicks(46), "Aşçı" },
                    { 45, "73ff4615-f322-439e-9251-83e45d2d8188", null, null, null, null, null, 5, "Rafael_Weissnat27@yahoo.com", 0, "Rafael", 190.05715055393853720m, "3240", true, "Weissnat", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2021, 8, 30, 23, 14, 36, 46, DateTimeKind.Unspecified).AddTicks(2861), "Müdür" },
                    { 21, "4e66fd1d-0b73-4f78-a631-cfc3fd0f0bf6", null, null, null, null, null, 3, "Miriam.Bernier48@hotmail.com", 3, "Miriam", 193.751820281032390m, "5594", true, "Bernier", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 4, 6, 11, 33, 30, 463, DateTimeKind.Unspecified).AddTicks(5908), "Aşçı" },
                    { 20, "6e02fba6-cf2e-4ac4-b2c2-077e659740d4", null, null, null, null, null, 3, "Janice85@hotmail.com", 3, "Janice", 195.161676814389260m, "3117", true, "Gaylord", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 3, 16, 12, 40, 20, 420, DateTimeKind.Unspecified).AddTicks(191), "Aşçı" },
                    { 19, "5b1c893c-4baa-4e91-99f3-e837cd63585b", null, null, null, null, null, 3, "Tricia.Wiza@yahoo.com", 3, "Tricia", 190.1131398277884070m, "6569", true, "Wiza", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 1, 9, 20, 12, 14, 715, DateTimeKind.Unspecified).AddTicks(7339), "Aşçı" },
                    { 13, "4b0ba339-7c65-4d0d-b421-1f84ff78db57", null, null, null, null, null, 1, "Sam_Powlowski83@gmail.com", 3, "Sam", 199.910395047585660m, "5230", true, "Powlowski", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 9, 2, 17, 46, 43, 168, DateTimeKind.Unspecified).AddTicks(3015), "Temizlik Görevlisi" },
                    { 12, "758cac08-c79e-4683-bd68-bc7b13feca19", null, null, null, null, null, 1, "Sergio.Deckow67@hotmail.com", 3, "Sergio", 194.702825497231830m, "3045", true, "Deckow", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 11, 5, 46, 8, 244, DateTimeKind.Unspecified).AddTicks(4831), "Temizlik Görevlisi" },
                    { 30, "a1f2c838-8c0f-42d6-a480-1da6bd1ff4a9", null, null, null, null, null, 3, "Kristi.Moen1@yahoo.com", 3, "Kristi", 196.036900335940020m, "5511", true, "Moen", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 6, 22, 39, 42, 674, DateTimeKind.Unspecified).AddTicks(643), "Garson" },
                    { 46, "1c5463b5-5ce9-4b2a-974d-94026ee3e28d", null, null, null, null, null, 6, "Freda86@hotmail.com", 1, "Freda", 193.333762652861780m, "7812", true, "Bauch", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 9, 21, 22, 34, 34, 47, DateTimeKind.Unspecified).AddTicks(166), "İnsan Kaynakları Müdürü" },
                    { 16, "ed31056b-7fb0-4e77-b7e8-4085cbc926d7", null, null, null, null, null, 1, "Lee.Mayer99@gmail.com", 3, "Lee", 194.236644378042150m, "9604", true, "Mayer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 7, 6, 2, 51, 58, 799, DateTimeKind.Unspecified).AddTicks(3996), "Temizlik Görevlisi" },
                    { 5, "68a18ffe-ec3a-40f6-ac08-2b39dc044d6a", null, null, null, null, null, 4, "Rogelio.Yundt27@hotmail.com", 3, "Rogelio", 196.701255821018130m, "5047", true, "Yundt", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 3, 8, 19, 49, 31, 601, DateTimeKind.Unspecified).AddTicks(769), "Resepsiyonist" },
                    { 11, "746bf451-2f0f-40bf-b10a-4c6faf62c132", null, null, null, null, null, 1, "Alfonso68@gmail.com", 3, "Alfonso", 193.876531209739170m, "5929", true, "Murray", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 3, 2, 27, 1, 866, DateTimeKind.Unspecified).AddTicks(2231), "Temizlik Görevlisi" },
                    { 7, "b708da78-f5dd-4b9f-980a-8878435cfa7f", null, null, null, null, null, 4, "Damon36@yahoo.com", 3, "Damon", 197.213234676613120m, "9934", true, "Aufderhar", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2020, 4, 8, 6, 22, 41, 147, DateTimeKind.Unspecified).AddTicks(1160), "Resepsiyonist" },
                    { 6, "2eff5e09-9423-413b-bc53-bc1005a69ab5", null, null, null, null, null, 4, "Lynne91@hotmail.com", 3, "Lynne", 192.465373302095280m, "8411", true, "Herman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2022, 1, 29, 17, 22, 35, 309, DateTimeKind.Unspecified).AddTicks(1633), "Resepsiyonist" },
                    { 42, "498253b1-8809-4cc6-9889-2da6fedaf631", null, null, null, null, null, 3, "Everett59@gmail.com", 3, "Everett", 190.06543837490744810m, "9609", true, "Olson", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 11, 14, 12, 51, 31, 632, DateTimeKind.Unspecified).AddTicks(8589), "Garson" },
                    { 41, "ead7f891-0ef9-49ee-a5c2-cb7302311447", null, null, null, null, null, 3, "Kimberly.Braun68@gmail.com", 3, "Kimberly", 199.969621226177380m, "2219", true, "Braun", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 6, 15, 2, 51, 11, 437, DateTimeKind.Unspecified).AddTicks(8173), "Garson" },
                    { 40, "0dbb3350-ac77-4695-94c2-c41095fcb649", null, null, null, null, null, 3, "Stacy16@hotmail.com", 3, "Stacy", 198.886408362950390m, "1835", true, "Lebsack", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 9, 27, 4, 30, 2, 669, DateTimeKind.Unspecified).AddTicks(2240), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "8a644b3f-f1c5-4934-8cad-d6b6b0472b3f", null, null, null, null, null, 3, "Ellis_Schowalter@hotmail.com", 3, "Ellis", 197.407718336865180m, "5057", true, "Schowalter", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 9, 17, 22, 26, 4, 840, DateTimeKind.Unspecified).AddTicks(3417), "Garson" },
                    { 38, "4239338b-9d71-4d98-87ab-75cb6805d7db", null, null, null, null, null, 3, "Estelle28@hotmail.com", 3, "Estelle", 199.246293399131990m, "8582", true, "Kris", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 11, 5, 15, 8, 59, 743, DateTimeKind.Unspecified).AddTicks(2515), "Garson" },
                    { 37, "04ec5159-4484-4f9b-9ef1-ac947433ecd3", null, null, null, null, null, 3, "Robyn.Quitzon@hotmail.com", 3, "Robyn", 199.21755138282550m, "4507", true, "Quitzon", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 8, 30, 8, 45, 57, 520, DateTimeKind.Unspecified).AddTicks(7391), "Garson" },
                    { 28, "b7fccc7c-fff8-4ccc-840c-4e6ecec3ddc4", null, null, null, null, null, 3, "Hector20@yahoo.com", 3, "Hector", 195.101441673516040m, "6235", true, "Huels", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 3, 19, 9, 15, 36, 232, DateTimeKind.Unspecified).AddTicks(2878), "Aşçı" },
                    { 27, "e02a26ff-8714-4309-9b94-cd438dab006d", null, null, null, null, null, 3, "Delbert_Lesch81@hotmail.com", 3, "Delbert", 195.530074823428910m, "1555", true, "Lesch", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 2, 13, 20, 32, 224, DateTimeKind.Unspecified).AddTicks(1587), "Aşçı" },
                    { 26, "51b8feca-22c2-49aa-a83b-c79b81393563", null, null, null, null, null, 3, "Johanna_Donnelly54@hotmail.com", 3, "Johanna", 196.978073053517410m, "2601", true, "Donnelly", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 12, 8, 5, 50, 3, 336, DateTimeKind.Unspecified).AddTicks(9517), "Aşçı" },
                    { 25, "f0773878-23d7-4835-a421-6e2ed4ab8038", null, null, null, null, null, 3, "Darren9@yahoo.com", 3, "Darren", 190.5531718305094040m, "2984", true, "Oberbrunner", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 13, 12, 10, 52, 893, DateTimeKind.Unspecified).AddTicks(6156), "Aşçı" },
                    { 18, "65ddf361-0344-465d-ab9e-b818daaf0be7", null, null, null, null, null, 1, "Justin.Gerhold@gmail.com", 3, "Justin", 190.1135315234370210m, "7752", true, "Gerhold", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 3, 22, 21, 50, 13, 875, DateTimeKind.Unspecified).AddTicks(1876), "Temizlik Görevlisi" },
                    { 17, "0083f5f9-e6fd-475a-a2df-f43523008feb", null, null, null, null, null, 1, "Jodi70@yahoo.com", 3, "Jodi", 196.430273641101210m, "8961", true, "Volkman", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 2, 2, 5, 13, 3, 660, DateTimeKind.Unspecified).AddTicks(845), "Temizlik Görevlisi" },
                    { 15, "3465ba99-caf2-4849-af96-6a55851a5b77", null, null, null, null, null, 1, "Paulette_Jerde30@yahoo.com", 3, "Paulette", 197.063454607065510m, "1881", true, "Jerde", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 7, 2, 14, 13, 51, 426, DateTimeKind.Unspecified).AddTicks(4965), "Temizlik Görevlisi" },
                    { 14, "16edb950-186f-42f4-9cec-6a33f8d69a1d", null, null, null, null, null, 1, "Edith21@gmail.com", 3, "Edith", 198.790448773089070m, "5084", true, "Schneider", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 3, 5, 0, 51, 24, 516, DateTimeKind.Unspecified).AddTicks(9946), "Temizlik Görevlisi" },
                    { 4, "7e7deb9d-2f0e-4496-83f6-3f7f1c02d3c5", null, null, null, null, null, 4, "Dawn.Schaefer@hotmail.com", 3, "Dawn", 199.766172249692570m, "3919", true, "Schaefer", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 5, 7, 5, 30, 52, 25, DateTimeKind.Unspecified).AddTicks(6147), "Resepsiyonist" },
                    { 29, "bfdb57ee-9ce1-4f57-a2af-cc89b606c643", null, null, null, null, null, 3, "Donna.Huels@hotmail.com", 3, "Donna", 191.973969299334090m, "9175", true, "Huels", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 1, 23, 12, 52, 54, 966, DateTimeKind.Unspecified).AddTicks(4516), "Aşçı" },
                    { 10, "bdc19aee-648f-4e35-bffd-0a151340f9ce", null, null, null, null, null, 1, "Cornelius85@hotmail.com", 3, "Cornelius", 196.700575415371250m, "9684", true, "Mueller", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 2, 10, 21, 4, 59, 736, DateTimeKind.Unspecified).AddTicks(9401), "Temizlik Görevlisi" },
                    { 8, "186d7d00-399f-461b-8e74-0b185d04d390", null, null, null, null, null, 1, "Flora.McGlynn@yahoo.com", 3, "Flora", 197.653185784655240m, "3649", true, "McGlynn", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 13, 17, 26, 55, 199, DateTimeKind.Unspecified).AddTicks(3350), "Temizlik Görevlisi" },
                    { 3, "0f6cfb56-f35d-46e4-9b2f-f0e5264a696f", null, null, null, null, null, 4, "Rosemary24@hotmail.com", 3, "Rosemary", 191.620506407516310m, "1847", true, "Ullrich", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 11, 24, 5, 25, 14, 633, DateTimeKind.Unspecified).AddTicks(4564), "Resepsiyonist" },
                    { 2, "a8ce5158-6ebb-4ede-8154-296c471e76dd", null, null, null, null, null, 4, "Samuel_Murray20@yahoo.com", 3, "Samuel", 191.163035054301390m, "1568", true, "Murray", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 9, 13, 4, 54, 59, 720, DateTimeKind.Unspecified).AddTicks(7549), "Resepsiyonist" },
                    { 1, "3c0f0dda-f64e-4760-8c55-374f7b42089e", null, null, null, null, null, 4, "Irene10@gmail.com", 3, "Irene", 197.439600395709090m, "2793", true, "Pollich", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 5, 9, 1, 59, 40, 368, DateTimeKind.Unspecified).AddTicks(870), "Resepsiyonist" },
                    { 9, "91568893-feb4-4c07-a523-6ce308888ddd", null, null, null, null, null, 1, "Clayton.Howell67@hotmail.com", 3, "Clayton", 190.33269607011820m, "1113", true, "Howell", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 1, 27, 10, 25, 34, 708, DateTimeKind.Unspecified).AddTicks(9151), "Temizlik Görevlisi" }
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
                    { 2, 5, null, null, null, null, null, null, null, null, null, null },
                    { 4, 1, null, null, null, null, null, null, null, null, null, null },
                    { 1, 5, null, null, null, null, null, null, null, null, null, null },
                    { 3, 3, null, null, null, null, null, null, null, null, null, null },
                    { 4, 3, null, null, null, null, null, null, null, null, null, null },
                    { 5, 3, null, null, null, null, null, null, null, null, null, null },
                    { 6, 3, null, null, null, null, null, null, null, null, null, null },
                    { 1, 4, null, null, null, null, null, null, null, null, null, null },
                    { 2, 4, null, null, null, null, null, null, null, null, null, null },
                    { 3, 4, null, null, null, null, null, null, null, null, null, null },
                    { 3, 5, null, null, null, null, null, null, null, null, null, null },
                    { 3, 1, null, null, null, null, null, null, null, null, null, null },
                    { 1, 1, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FacilitiesOfRooms",
                columns: new[] { "RoomFacilityID", "RoomTypeID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
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
                    { 28, null, null, null, null, null, null, 2, null, null, null, null, null, "127", 5, 1 },
                    { 29, null, null, null, null, null, null, 2, null, null, null, null, null, "128", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
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
                    { 31, null, null, null, null, null, null, 2, null, null, null, null, null, "130", 5, 2 },
                    { 32, null, null, null, null, null, null, 2, null, null, null, null, null, "131", 5, 2 },
                    { 49, null, null, null, null, null, null, 3, null, null, null, null, null, "148", 5, 3 },
                    { 50, null, null, null, null, null, null, 3, null, null, null, null, null, "149", 5, 3 },
                    { 17, null, null, null, null, null, null, 1, null, null, null, null, null, "116", 5, 4 },
                    { 62, null, null, null, null, null, null, 4, null, null, null, null, null, "161", 5, 3 },
                    { 63, null, null, null, null, null, null, 4, null, null, null, null, null, "162", 5, 3 },
                    { 64, null, null, null, null, null, null, 4, null, null, null, null, null, "163", 5, 3 },
                    { 65, null, null, null, null, null, null, 4, null, null, null, null, null, "164", 5, 3 },
                    { 48, null, null, null, null, null, null, 3, null, null, null, null, null, "147", 5, 3 },
                    { 66, null, null, null, null, null, null, 4, null, null, null, null, null, "165", 5, 3 },
                    { 68, null, null, null, null, null, null, 4, null, null, null, null, null, "167", 5, 3 },
                    { 69, null, null, null, null, null, null, 4, null, null, null, null, null, "168", 5, 3 },
                    { 70, null, null, null, null, null, null, 4, null, null, null, null, null, "169", 5, 3 },
                    { 16, null, null, null, null, null, null, 1, null, null, null, null, null, "115", 5, 4 },
                    { 15, null, null, null, null, null, null, 1, null, null, null, null, null, "114", 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 14, null, null, null, null, null, null, 1, null, null, null, null, null, "113", 5, 4 },
                    { 13, null, null, null, null, null, null, 1, null, null, null, null, null, "112", 5, 4 },
                    { 67, null, null, null, null, null, null, 4, null, null, null, null, null, "166", 5, 3 },
                    { 11, null, null, null, null, null, null, 1, null, null, null, null, null, "110", 5, 4 },
                    { 47, null, null, null, null, null, null, 3, null, null, null, null, null, "146", 5, 3 },
                    { 45, null, null, null, null, null, null, 3, null, null, null, null, null, "144", 5, 3 },
                    { 33, null, null, null, null, null, null, 2, null, null, null, null, null, "132", 5, 2 },
                    { 34, null, null, null, null, null, null, 2, null, null, null, null, null, "133", 5, 2 },
                    { 35, null, null, null, null, null, null, 2, null, null, null, null, null, "134", 5, 2 },
                    { 36, null, null, null, null, null, null, 2, null, null, null, null, null, "135", 5, 2 },
                    { 37, null, null, null, null, null, null, 2, null, null, null, null, null, "136", 5, 2 },
                    { 38, null, null, null, null, null, null, 2, null, null, null, null, null, "137", 5, 2 },
                    { 39, null, null, null, null, null, null, 2, null, null, null, null, null, "138", 5, 2 },
                    { 40, null, null, null, null, null, null, 2, null, null, null, null, null, "139", 5, 2 },
                    { 46, null, null, null, null, null, null, 3, null, null, null, null, null, "145", 5, 3 },
                    { 52, null, null, null, null, null, null, 3, null, null, null, null, null, "151", 5, 5 },
                    { 51, null, null, null, null, null, null, 3, null, null, null, null, null, "150", 5, 5 },
                    { 20, null, null, null, null, null, null, 1, null, null, null, null, null, "119", 5, 4 },
                    { 19, null, null, null, null, null, null, 1, null, null, null, null, null, "118", 5, 4 },
                    { 18, null, null, null, null, null, null, 1, null, null, null, null, null, "117", 5, 4 },
                    { 41, null, null, null, null, null, null, 3, null, null, null, null, null, "140", 5, 3 },
                    { 42, null, null, null, null, null, null, 3, null, null, null, null, null, "141", 5, 3 },
                    { 43, null, null, null, null, null, null, 3, null, null, null, null, null, "142", 5, 3 },
                    { 44, null, null, null, null, null, null, 3, null, null, null, null, null, "143", 5, 3 },
                    { 61, null, null, null, null, null, null, 4, null, null, null, null, null, "160", 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "ID", "AboutusID", "ContactID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "HomePageID", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "SmtpEmail", "SmtpHost", "SmtpPassword", "SmtpPort" },
                values: new object[] { 1, 1, 1, null, null, null, null, null, 1, null, null, null, null, null, "the.mstfa@gmail.com", "smtp.gmail.com", "Mustafa.2525774", 587 });

            migrationBuilder.InsertData(
                table: "HotelServices",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "IconPicture", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "ServiceName", "SettingID" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/oda-servisi.jpg", null, null, null, null, null, "Oda Servisi", 1 },
                    { 2, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/ucretsiz-wi-fi.jpg", null, null, null, null, null, "Ücretsiz Wifi", 1 },
                    { 3, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/camasir-yikama.jpg", null, null, null, null, null, "Çamaşır Yıkama", 1 },
                    { 4, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/oda-ici-kasa.jpg", null, null, null, null, null, "Kasa", 1 },
                    { 5, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/toplanti-olanaklari-max-10.jpg", null, null, null, null, null, "Toplantı Olanakları", 1 },
                    { 6, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/bagaj-depolama.jpg", null, null, null, null, null, "Bagaj Depolama", 1 },
                    { 7, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/hizli-c-in-c-out.jpg", null, null, null, null, null, "Hızlı C in / C out", 1 },
                    { 8, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/kuru-temizleme.jpg", null, null, null, null, null, "Kuru Temizleme", 1 },
                    { 9, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/bebek-karyolasi.jpg", null, null, null, null, null, "Bebek Karyolası", 1 },
                    { 10, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/aile-odasi.jpg", null, null, null, null, null, "Aile Odası", 1 },
                    { 11, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/sicak-kahvalti.jpg", null, null, null, null, null, "Sıcak Kahvaltı", 1 },
                    { 12, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/merkezi-konum.jpg", null, null, null, null, null, "Merkezi Konum", 1 },
                    { 13, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/ucretsiz-acik-kapali-otopark.jpg", null, null, null, null, null, "Ücretsiz Açık / Kapalı Otopark", 1 },
                    { 14, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/utu-hizmeti.jpg", null, null, null, null, null, "Ütü Hizmeti", 1 },
                    { 15, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/cay-kahve-hizmeti.jpg", null, null, null, null, null, "Çay - Kahve Hizmeti", 1 }
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
                name: "IX_HotelServices_SettingID",
                table: "HotelServices",
                column: "SettingID");

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
                name: "IX_Settings_AboutusID",
                table: "Settings",
                column: "AboutusID");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_ContactID",
                table: "Settings",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_HomePageID",
                table: "Settings",
                column: "HomePageID");

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
                name: "Settings");

            migrationBuilder.DropTable(
                name: "ExtraServices");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Aboutus");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "HomePages");

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
