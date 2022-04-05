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
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bbd93b27-cfbe-4070-bcf0-a8d7f9a41fa5", "mutfak", "MUTFAK" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "b809c348-01ba-41d1-9288-38fc821dffcc", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "1456bd85-236c-4753-864f-3400a29da9ea", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "981003db-3b18-4d8d-bdfc-5df9d307e5b5", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "d0462a57-7d56-4c60-a25d-ec4d9bf98c2a", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "68888675-74c1-4c2b-a8b1-beb8a97bf402", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d5118e40-06c3-4aee-8acb-6d88f9f3eaf8", "user", "USER" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "6694b8b5-7263-4258-8d4d-88875cd3513c", "muhasebe", "MUHASEBE" },
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "49378e69-e104-4565-9dcc-231843110692", "valilik", "VALILIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ebfe94ea-5c9f-47bb-b14a-8979ebc4fe4f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6755f991-afa9-42f6-9ed0-6c99a3460551", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flora.Mitchell27@gmail.com", true, "Flora", "Mitchell", false, null, "FLORA.MITCHELL27@GMAIL.COM", "FLORA.MITCHELL27@GMAIL.COM", "AAHTYGCDMtu4GePWXiRgxNh+iuVQP9iPr5Trp6QCNjQmJtU9iBTjlAxGeqJGh0i28A==", "05111111111", false, "ea537d59-9f7f-468d-9699-3850e7c5398a", false, "Flora.Mitchell27@gmail.com" },
                    { "17e92d4d-8d29-457f-80f3-1ff18959998b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "08171655-d5da-4535-9677-4cf5bf453254", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leslie18@yahoo.com", true, "Leslie", "Abshire", false, null, "LESLIE18@YAHOO.COM", "LESLIE18@YAHOO.COM", "AF+0EPICgCALQq5stTz/+lVQ2FTHMlgN2qgYzFiBdMj7Ei2VpjFdyCLLqV3u0jaGpw==", "05111111111", false, "d98da037-7333-4824-bcef-a1a7c7630e2b", false, "Leslie18@yahoo.com" },
                    { "bbcedef2-06b5-4ddf-b609-ca5a78427cec", 0, new Guid("00000000-0000-0000-0000-000000000000"), "ab8fdd72-8290-4f43-9b60-b754295514a7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laurie.Keebler93@yahoo.com", true, "Laurie", "Keebler", false, null, "LAURIE.KEEBLER93@YAHOO.COM", "LAURIE.KEEBLER93@YAHOO.COM", "ADQUxb2KZoK1pyUfUybqxCh5zfvltJJztHB2tkYSXQqyXH9WpDL+dFZXC9voK2hf2w==", "05111111111", false, "f601b533-0a7b-48cc-8d2c-a22a501ffc36", false, "Laurie.Keebler93@yahoo.com" },
                    { "41b7f81a-bf37-4ab8-9c73-9ffb9035d841", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5772ff5e-cb83-4e2c-871b-21b9d5a52db1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toby80@hotmail.com", true, "Toby", "Schiller", false, null, "TOBY80@HOTMAIL.COM", "TOBY80@HOTMAIL.COM", "APYMo0LqjUCalSNYWjOjawL8S8l18ngVJ4n9ww2Q4vlsumWM4nfXpCVY89tqOn5eQg==", "05111111111", false, "fcd35411-6860-48ca-87da-dd5ddcbc148a", false, "Toby80@hotmail.com" },
                    { "4c87d152-45ed-40d7-950e-22536f09a01b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "5ac75cfe-d8ca-4280-b963-ff515c8bde40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doug_Hegmann@yahoo.com", true, "Doug", "Hegmann", false, null, "DOUG_HEGMANN@YAHOO.COM", "DOUG_HEGMANN@YAHOO.COM", "AOS9B94POkgfvoL99vhFfrLl9AhTBP80+pSWWgdLeRlp+camBduR0+6BR+286cHNuA==", "05111111111", false, "46357267-9ece-4c95-84c9-e393f206813b", false, "Doug_Hegmann@yahoo.com" },
                    { "35901c53-ad28-4c59-83b9-5b2fdbf9cafd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "7dd3880b-d51c-4eb4-b77c-d76495bf1382", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arturo.Schneider@yahoo.com", true, "Arturo", "Schneider", false, null, "ARTURO.SCHNEIDER@YAHOO.COM", "ARTURO.SCHNEIDER@YAHOO.COM", "ABjQZP+vVerRZ/3UA+PtyuZlvlI/RfH0c3z+B+Hw+8d06k4OrIUzsqjjFG0rpFI7hg==", "05111111111", false, "c95e04cc-5c60-4d9c-9740-6007c1cbc4ca", false, "Arturo.Schneider@yahoo.com" },
                    { "cef81cda-3204-48a7-a03e-257241f7116a", 0, new Guid("00000000-0000-0000-0000-000000000000"), "1b0dd56e-8479-4854-b84b-b7190a72b579", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roman47@gmail.com", true, "Roman", "Kuhn", false, null, "ROMAN47@GMAIL.COM", "ROMAN47@GMAIL.COM", "AG2GGeLLGvLHJ019o9//ScqNXysWVIksHAkN7GTciKoo34+NLmJx0SQG/oSx9fmwDA==", "05111111111", false, "3c85fa89-84a0-406a-a382-8b7fcd771f83", false, "Roman47@gmail.com" },
                    { "9f5aa4fa-5456-4e7b-bc0e-c17a9c96b793", 0, new Guid("00000000-0000-0000-0000-000000000000"), "84d6e943-e975-4f92-8aad-d05a78e6d2b1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatrice_Effertz39@gmail.com", true, "Beatrice", "Effertz", false, null, "BEATRICE_EFFERTZ39@GMAIL.COM", "BEATRICE_EFFERTZ39@GMAIL.COM", "AL5LtBJOiVddzlpBVTpofx4fMgxXCOFmb9TIioiL+9IIKwdGoAigxVQCke8IW3+mmQ==", "05111111111", false, "fc30f146-46cf-48be-a915-a37c0d4f7be5", false, "Beatrice_Effertz39@gmail.com" },
                    { "e9bec946-e3a7-4327-8100-9137fe2c4eca", 0, new Guid("00000000-0000-0000-0000-000000000000"), "eaceb643-955d-4df4-8cb9-98384195fba4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucia.Dibbert@hotmail.com", true, "Lucia", "Dibbert", false, null, "LUCIA.DIBBERT@HOTMAIL.COM", "LUCIA.DIBBERT@HOTMAIL.COM", "AOyafXjooYdLLZCfl28f7enzpiukr+XZzRdfRFFTyYzG2nvmvHm1Gv64Ln2cjhDeig==", "05111111111", false, "7ed1b90e-5eb2-47d7-98f1-4880932c7a59", false, "Lucia.Dibbert@hotmail.com" },
                    { "8a26c46c-4de3-480a-b678-26c94a9530eb", 0, new Guid("00000000-0000-0000-0000-000000000000"), "0d4c4cf0-9c61-41bf-880f-e8dacf83f808", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruce_Lindgren@hotmail.com", true, "Bruce", "Lindgren", false, null, "BRUCE_LINDGREN@HOTMAIL.COM", "BRUCE_LINDGREN@HOTMAIL.COM", "APdAiMTnF5Lg9tnxqoJBzAh0Rg2Cd3acXy3HNDVHk7mCZ+EUeLuPnIUMUL/ABfHlnQ==", "05111111111", false, "26f59452-a28a-49eb-abe9-d7eb3a99b58e", false, "Bruce_Lindgren@hotmail.com" },
                    { "194e2176-f23b-4d87-8a6d-603575f6da7d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "0a55e4f6-ead8-4ce3-8735-55488f9ca271", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles47@gmail.com", true, "Charles", "Harris", false, null, "CHARLES47@GMAIL.COM", "CHARLES47@GMAIL.COM", "ACbbzg/qMy5g8H0W7j3p4AFyr5oUU36cGl39vykklRJwelem8NPDWjonMJ5NJ5X3Ug==", "05111111111", false, "9b159b5a-2b46-478b-a3ed-1dbfe4b15dfc", false, "Charles47@gmail.com" },
                    { "b447bffb-1bfd-40ea-9922-330fdafb4810", 0, new Guid("00000000-0000-0000-0000-000000000000"), "3df1f756-f0ff-4dce-a508-bcdc13a41336", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindsay_Balistreri49@hotmail.com", true, "Lindsay", "Balistreri", false, null, "LINDSAY_BALISTRERI49@HOTMAIL.COM", "LINDSAY_BALISTRERI49@HOTMAIL.COM", "AFacVESpEItKVxyj2DDlF6T/sweBpjeJyJ9isVyBDBeVZDVaGFrxsvPrUaHfHIoy4w==", "05111111111", false, "790e071b-2ca7-490b-b43d-15147a891238", false, "Lindsay_Balistreri49@hotmail.com" },
                    { "b0a256fc-164f-4346-9f4a-3d2fa2d69d98", 0, new Guid("00000000-0000-0000-0000-000000000000"), "197578d7-6e9b-45d3-98d8-e2bcb4a48f3c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elias_Bartoletti@gmail.com", true, "Elias", "Bartoletti", false, null, "ELIAS_BARTOLETTI@GMAIL.COM", "ELIAS_BARTOLETTI@GMAIL.COM", "AO2A/5RcoTdWKRlU+LXlLWiAUmYXLeLBE+QBGAC03Hr8kOBxx8TREWsehkLe7lZwxg==", "05111111111", false, "9c8d3d3d-cfb6-4817-9276-b959c229bcee", false, "Elias_Bartoletti@gmail.com" },
                    { "3e8c8626-f052-4562-8500-f02befa0570e", 0, new Guid("00000000-0000-0000-0000-000000000000"), "c609a42e-d6b1-476a-bb4c-120e18c03f1d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clay.Schaden@hotmail.com", true, "Clay", "Schaden", false, null, "CLAY.SCHADEN@HOTMAIL.COM", "CLAY.SCHADEN@HOTMAIL.COM", "AHC+0rlcakzaryL3xuIk7gIEss8UMGenvi4DRJ6pdqOn1PjiZgBjJ6YJPoaUZ39yuQ==", "05111111111", false, "8330889a-9a06-4710-9c73-b86260298845", false, "Clay.Schaden@hotmail.com" },
                    { "20ebd9da-6a4b-43d1-bd66-72b93ba85437", 0, new Guid("00000000-0000-0000-0000-000000000000"), "19c643e9-17ee-4364-8406-d5d071e2fbcf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tim.Corkery74@gmail.com", true, "Tim", "Corkery", false, null, "TIM.CORKERY74@GMAIL.COM", "TIM.CORKERY74@GMAIL.COM", "AMx5JgRM5lHIHoO9GFSABJZ15z0GGzbZZ2L4sDklPl3NzZPAvba7XkwfLAxYyI0zgg==", "05111111111", false, "da5f7817-862f-4d6a-b19b-669add77f2ed", false, "Tim.Corkery74@gmail.com" },
                    { "efb29df0-f1c0-45db-9f27-937ed7580fbc", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b3d5fa0f-56db-4fa3-b6de-ce5c67016367", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gretchen44@hotmail.com", true, "Gretchen", "Turcotte", false, null, "GRETCHEN44@HOTMAIL.COM", "GRETCHEN44@HOTMAIL.COM", "ACo/bj+8g8FYDmKJdEl7laWzns0+5VLKjNFIgmSWK3Gm/zcwp29PTTmpUsgiU82qvg==", "05111111111", false, "5239c318-dca7-48f9-92ae-1d538016ee69", false, "Gretchen44@hotmail.com" },
                    { "95dc3b56-976f-4af2-b49c-adb48e1d8956", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6addf6dd-9571-4ca5-ba37-6b14ac6a19a1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Randal.Emmerich63@gmail.com", true, "Randal", "Emmerich", false, null, "RANDAL.EMMERICH63@GMAIL.COM", "RANDAL.EMMERICH63@GMAIL.COM", "ADTvj2OcTH2SRxzIAaRYG5o9qTf6WCKam2L4BuoRLfIRxpLrjQ6De+N81MdtPURFag==", "05111111111", false, "91a690bf-417c-4dab-93b5-83ec17066e7c", false, "Randal.Emmerich63@gmail.com" },
                    { "811718d7-5627-48ad-9908-ed64867a3033", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f240d64c-1782-4025-92fb-2022c67c4197", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kim_Goldner@hotmail.com", true, "Kim", "Goldner", false, null, "KIM_GOLDNER@HOTMAIL.COM", "KIM_GOLDNER@HOTMAIL.COM", "APSydXIzNsvCpki2/h+LNllF5d8zx3q3m8+g0ztoy8e1r0F76kbRNLdpgmFvGfy9gA==", "05111111111", false, "1e3a780e-95cd-4063-abba-b2d8921c31ca", false, "Kim_Goldner@hotmail.com" },
                    { "02d85a69-9e91-4c36-95fe-95a1c8909715", 0, new Guid("00000000-0000-0000-0000-000000000000"), "ffebd036-1dc9-47c3-a9ec-075c9a63b7f0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guillermo_Yost38@yahoo.com", true, "Guillermo", "Yost", false, null, "GUILLERMO_YOST38@YAHOO.COM", "GUILLERMO_YOST38@YAHOO.COM", "AHguZD4UByWMPSEbV50/XasGKdRmtUSHoBBjlDMaw0cjG+c0zDPtfFrgxYgkyYMWig==", "05111111111", false, "451be2c5-6d3e-406d-a9a6-1308dd9f4b67", false, "Guillermo_Yost38@yahoo.com" },
                    { "c31e0739-2ed0-43e3-bbc1-ef42aebca270", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e102f692-5c8b-4de8-bdd1-cf1b894dbe19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dominic92@gmail.com", true, "Dominic", "Graham", false, null, "DOMINIC92@GMAIL.COM", "DOMINIC92@GMAIL.COM", "AI4M85akG8frx+H5bynANeQJin+iGP4nT45JgBM8wWCGsoK4elH5+u8FpPYGudwvrQ==", "05111111111", false, "33fcba78-4025-4662-bfa8-29698ddb7a52", false, "Dominic92@gmail.com" },
                    { "3c8d2294-7919-49dd-bf66-44d5f193879f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "03588ac9-dd97-40fb-b4ce-dc6c26117161", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valilik@bilgehotel.com", true, "Bilge", "Hotel", false, null, "VALILIK@BILGEHOTEL.COM", "VALILIK@BILGEHOTEL.COM", "ANWPL6rMvQ1m41bi7j+ImReRedrJctt03Cfhd1BiMqbhwreVIc6+mNtOrklvaBqL8A==", "05111111111", false, "3aed9c02-633f-4673-a3be-0a5d71121dbb", false, "valilik@bilgehotel.com" },
                    { "1ab015d1-a1d2-4646-bda6-623fc4c371ad", 0, new Guid("00000000-0000-0000-0000-000000000000"), "33a28713-0c5d-49e3-9178-72f6a740ebb7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna.Schimmel6@gmail.com", true, "Anna", "Schimmel", false, null, "ANNA.SCHIMMEL6@GMAIL.COM", "ANNA.SCHIMMEL6@GMAIL.COM", "AL70DTXoeLQelKuO/YNmVozmyKUM4AEaFA9QzXCLGpb0kcLsAec8gwGXfOMgolazkA==", "05111111111", false, "eb60741d-2eee-4af9-88ee-63a80341655f", false, "Anna.Schimmel6@gmail.com" },
                    { "c06dc470-ada2-4a62-a816-e56ce3482b30", 0, new Guid("00000000-0000-0000-0000-000000000000"), "44427585-c7fc-4cbd-a820-77361554416d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inez_Jones@yahoo.com", true, "Inez", "Jones", false, null, "INEZ_JONES@YAHOO.COM", "INEZ_JONES@YAHOO.COM", "AB/5+6gUECuCI9M4jgnAmhD0EozIRfhfK3WfmM018nVQi3za4umBUpUVpT4h/chnJg==", "05111111111", false, "000ba9f5-f492-4f69-9857-91e25f2c14ea", false, "Inez_Jones@yahoo.com" },
                    { "59c50966-a45c-45f4-b2a5-d32564eb5e2b", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f2def384-b5e7-4d9e-9dae-0f4deefe3312", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah.Brakus38@yahoo.com", true, "Noah", "Brakus", false, null, "NOAH.BRAKUS38@YAHOO.COM", "NOAH.BRAKUS38@YAHOO.COM", "AAl8f0KmZiNIja8M74SkxekfkOIrWuIKD8U9NVNuAB3u36XPWc2n62aKOfGlYUK7Vg==", "05111111111", false, "b1e4f3ce-f879-4260-a2d0-6110844ff452", false, "Noah.Brakus38@yahoo.com" },
                    { "71ec6d73-c677-4a08-9b14-d25230286c38", 0, new Guid("00000000-0000-0000-0000-000000000000"), "cbed64d1-a896-4ace-9b4e-3ac03d16f940", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole_Luettgen@gmail.com", true, "Nicole", "Luettgen", false, null, "NICOLE_LUETTGEN@GMAIL.COM", "NICOLE_LUETTGEN@GMAIL.COM", "AG3k08vgm9CRJuDfpqwNs64vCBDTIW1vWKHIZWPlzjq1NlmPDE5hXT9lop0+8bnddg==", "05111111111", false, "0b9a8add-a1d6-4b17-9d08-e397e1a4fd5f", false, "Nicole_Luettgen@gmail.com" },
                    { "3930342e-2654-4b8d-a418-1c0be8c68cc1", 0, new Guid("00000000-0000-0000-0000-000000000000"), "87d17dbc-9fd7-4a1c-8818-69066477a3b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nellie.Schuster@yahoo.com", true, "Nellie", "Schuster", false, null, "NELLIE.SCHUSTER@YAHOO.COM", "NELLIE.SCHUSTER@YAHOO.COM", "ACkYCDlT7gd71HjVxQnzQI/CGN3NU7WUzSaQtnth72993CfQG8x/J6LjopDQkTzWwA==", "05111111111", false, "bdc9f351-69df-4914-acc0-f612b230f253", false, "Nellie.Schuster@yahoo.com" },
                    { "5b6215c2-88b0-4473-8e47-c81632d24bd4", 0, new Guid("00000000-0000-0000-0000-000000000000"), "2bc0b544-0b57-4dca-b40e-c6066d830496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latoya_Reynolds@yahoo.com", true, "Latoya", "Reynolds", false, null, "LATOYA_REYNOLDS@YAHOO.COM", "LATOYA_REYNOLDS@YAHOO.COM", "AMcY3MB54exE6hiDNj/VBQ+Eb9PUkf9XRoDRbnX8WUGPkoqNTcgk225jAZBmTsZflQ==", "05111111111", false, "f6d46276-b499-4113-9c95-f9508208dce7", false, "Latoya_Reynolds@yahoo.com" },
                    { "b7747579-485e-4313-ae21-a7ddb1d4909e", 0, new Guid("00000000-0000-0000-0000-000000000000"), "af45b392-351b-47f2-8257-d824af94561f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicolas30@gmail.com", true, "Nicolas", "Blick", false, null, "NICOLAS30@GMAIL.COM", "NICOLAS30@GMAIL.COM", "AO5czasac4WAH0OZfxymH8YRUqUQpl6YczP2O6FBhZDeh50MzsXUQ5LryA4FT4c4Ow==", "05111111111", false, "07a5ee6d-0590-4fc3-8c02-cbc56a744f3a", false, "Nicolas30@gmail.com" },
                    { "d3d7494b-451a-4d6a-a2a0-0d7c6f4f73ca", 0, new Guid("00000000-0000-0000-0000-000000000000"), "84d5456c-b626-4393-a71d-d1114a19caba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anita60@hotmail.com", true, "Anita", "Price", false, null, "ANITA60@HOTMAIL.COM", "ANITA60@HOTMAIL.COM", "ALdjxu/g6MzVNrkuhSsOzxo3YtwRrdxcTGCuOcxXSR7jVQwSAYdTG2X6oVyIEkQ34w==", "05111111111", false, "3fbe34d6-5625-4579-a870-6953f5402796", false, "Anita60@hotmail.com" },
                    { "a1ac7438-4802-4fb3-8070-a54ab4085bbd", 0, new Guid("00000000-0000-0000-0000-000000000000"), "6147a1e3-b878-4715-b501-fafca739e4df", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Priscilla.Douglas89@gmail.com", true, "Priscilla", "Douglas", false, null, "PRISCILLA.DOUGLAS89@GMAIL.COM", "PRISCILLA.DOUGLAS89@GMAIL.COM", "AKmnQHi02TCNG85tOwskAz4QoD5cwqS4mRZ9zc0eh6+n9yUPTJf9zxK2yLMyaQyxvw==", "05111111111", false, "d6e3130b-8df0-4c2d-85eb-c8b4a4b4d6fc", false, "Priscilla.Douglas89@gmail.com" },
                    { "defff5b7-f601-4960-86ae-4579a87edf2c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "28609cd2-d7ea-41d7-83e5-c5185af03a5d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melvin_Harvey@gmail.com", true, "Melvin", "Harvey", false, null, "MELVIN_HARVEY@GMAIL.COM", "MELVIN_HARVEY@GMAIL.COM", "AHGBzXo7h2V8KOWgYid8Gy+7z1OZbgHngkqOf6SOEOW/aKmOTejXE6vVKcXB3jNZMg==", "05111111111", false, "b0cf4839-727b-4bb6-a266-c373c5df4099", false, "Melvin_Harvey@gmail.com" },
                    { "93f2687b-d100-40e5-86d2-405cf51f6f03", 0, new Guid("00000000-0000-0000-0000-000000000000"), "274bdcf7-df2a-402d-b31c-f01233efdae2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe_Gutkowski@yahoo.com", true, "Joe", "Gutkowski", false, null, "JOE_GUTKOWSKI@YAHOO.COM", "JOE_GUTKOWSKI@YAHOO.COM", "ACgWwbHbk+lRJ9FBk0DaZp35uSbXZR3OEI3ZXImV7OepA8ga3zqq4q3RAAOnVl6BHQ==", "05111111111", false, "bec6ca53-fe57-4070-b143-7936390553b1", false, "Joe_Gutkowski@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6a6257de-0560-48fb-8c63-f9db4327e1a1", 0, new Guid("00000000-0000-0000-0000-000000000000"), "48f56d19-5b7f-4a03-972c-db248cad4fa7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tricia.Hickle67@yahoo.com", true, "Tricia", "Hickle", false, null, "TRICIA.HICKLE67@YAHOO.COM", "TRICIA.HICKLE67@YAHOO.COM", "AEPyYiaXv+N0iizs5NldNQuJqw7KjCQfg6aGD34JEIl0dcIHpySEgDeASYtYk1laVw==", "05111111111", false, "f3c87497-bc76-4087-87de-6ee6af4ffbda", false, "Tricia.Hickle67@yahoo.com" },
                    { "b9d511dd-036d-4329-b74c-917bf4b77d44", 0, new Guid("00000000-0000-0000-0000-000000000000"), "73ec94bb-fa73-4561-9b48-cca33e633537", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alex0@yahoo.com", true, "Alex", "Lebsack", false, null, "ALEX0@YAHOO.COM", "ALEX0@YAHOO.COM", "ADJFVDjyv1E2/IpLfDETKm0m/dClAkDBaDjFxeBBEYOMWFa29xueaO2ESWA/VMnvWg==", "05111111111", false, "2d668228-eca4-4d3f-afc4-63ef05bd60ec", false, "Alex0@yahoo.com" },
                    { "44ae0eee-fe5e-4c13-80dc-f8721bc8d332", 0, new Guid("00000000-0000-0000-0000-000000000000"), "d1b67e04-1e66-400b-ada5-ee63691d8981", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice87@hotmail.com", true, "Alice", "McCullough", false, null, "ALICE87@HOTMAIL.COM", "ALICE87@HOTMAIL.COM", "ACIJ8kyBHsp9w9gzo5mRUb3W8tQ8hNOgQAMhf7j5oYuvqz+A7b+aP8JX5Kh6sxWkfA==", "05111111111", false, "87ba04cf-3fd6-49b2-8c1e-a8ea3134fa4a", false, "Alice87@hotmail.com" },
                    { "f6551f83-3117-4ccb-a881-289662cb8925", 0, new Guid("00000000-0000-0000-0000-000000000000"), "ab329bfc-5ecb-4279-90e1-033d43c73621", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rudy19@gmail.com", true, "Rudy", "Kshlerin", false, null, "RUDY19@GMAIL.COM", "RUDY19@GMAIL.COM", "AAh8w8bmF4PXZ+x2vWxuAi1/yHVSasPPQoxq9BM7D7OjuhShfT6AU5du6W7cVbbluw==", "05111111111", false, "e8394112-88dc-45f4-ad41-9475cdb17f74", false, "Rudy19@gmail.com" },
                    { "623ddee6-78bb-4e98-bc14-e71d2b29f85c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "f1d302c5-14cb-4fbe-b259-ef1925621b68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnnie32@hotmail.com", true, "Johnnie", "Bergnaum", false, null, "JOHNNIE32@HOTMAIL.COM", "JOHNNIE32@HOTMAIL.COM", "ACe6qcCl4B+ARrNPsC6a4HkKd1V+U1WfF6nLk+F2DlcSvjqEjkErF8njWOVgpNjnyA==", "05111111111", false, "8c290439-9179-499d-8823-4378c32b94a9", false, "Johnnie32@hotmail.com" },
                    { "fc827145-248d-4889-9265-958ae75058f2", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e284817b-278a-4be6-b020-22b914287b4e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sidney.Corkery@gmail.com", true, "Sidney", "Corkery", false, null, "SIDNEY.CORKERY@GMAIL.COM", "SIDNEY.CORKERY@GMAIL.COM", "ADAhn/vHZTjNePXi2Dxq/C6t10LuvH1klFpWe/+xh1yPNvne4lQDiElKuFBL/lPNcA==", "05111111111", false, "e16d9738-0f32-4bfd-931d-0f4ef727d1d1", false, "Sidney.Corkery@gmail.com" },
                    { "1a8976a5-3cc2-4fba-9c72-cedb8e8eb213", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9b08a66f-fad0-4098-8b37-866ef7337268", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yvette_Hoeger@yahoo.com", true, "Yvette", "Hoeger", false, null, "YVETTE_HOEGER@YAHOO.COM", "YVETTE_HOEGER@YAHOO.COM", "AJTx6AxX+53/jU2YSA+qFXEjnTosBnT18goEyAIL07lvvPZjEdD/DOil0m8/9YSAUA==", "05111111111", false, "cab2618d-7920-4718-98ad-cd5333ce4c17", false, "Yvette_Hoeger@yahoo.com" },
                    { "e000de25-6b0a-4957-9aa5-ef6b66d8484d", 0, new Guid("00000000-0000-0000-0000-000000000000"), "13dd71d4-1248-4230-863d-ff86018daa19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erma_Bailey17@gmail.com", true, "Erma", "Bailey", false, null, "ERMA_BAILEY17@GMAIL.COM", "ERMA_BAILEY17@GMAIL.COM", "APg2dRXyvI64K4SE+HY04suHNHYCcZ67c5v63xh7IQxYjKVmtAImouuZoO8oRVEViQ==", "05111111111", false, "796e7340-8988-49cb-8e2a-be1b2ea26f27", false, "Erma_Bailey17@gmail.com" },
                    { "cdc2ec66-eb08-4faf-b83c-7a51d59ad92c", 0, new Guid("00000000-0000-0000-0000-000000000000"), "9a9000ab-78a0-4859-a91f-2f172f00219f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sally.Rosenbaum@gmail.com", true, "Sally", "Rosenbaum", false, null, "SALLY.ROSENBAUM@GMAIL.COM", "SALLY.ROSENBAUM@GMAIL.COM", "AJZdTZkbkJK4S2gRIasJ0Na06aoDUq3ZlQXogXsSFuFgJ59Sv8Jp1a/Q61g8ETQ/dA==", "05111111111", false, "933c1140-967c-46bb-b2b3-9bceab663ee8", false, "Sally.Rosenbaum@gmail.com" },
                    { "6786ba50-ce6f-4fa2-8994-5ff415dbefa1", 0, new Guid("00000000-0000-0000-0000-000000000000"), "c998eeb7-a16d-4d89-9571-70310f42bb4f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel_Collier43@hotmail.com", true, "Samuel", "Collier", false, null, "SAMUEL_COLLIER43@HOTMAIL.COM", "SAMUEL_COLLIER43@HOTMAIL.COM", "APtt4OBmv+rwOtl4IY7Ff5SxMeTNnsfz5UaKUtvux8zaavpPcQJQ7faKa4bMzazyMA==", "05111111111", false, "9dce8154-256c-46fc-b23b-8af488960be6", false, "Samuel_Collier43@hotmail.com" },
                    { "285151fd-90d5-4ffe-a9c8-2acedd3582d9", 0, new Guid("00000000-0000-0000-0000-000000000000"), "4d8a4c9f-6702-499c-8d85-a6846cf69740", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cora.Pouros13@gmail.com", true, "Cora", "Pouros", false, null, "CORA.POUROS13@GMAIL.COM", "CORA.POUROS13@GMAIL.COM", "AHFjyrwuOWKeOLk0wl6vGsuG8RD5F0nu0ZvHyvARrIE630Vtx9mhE8Lo4UjCZ8qyfg==", "05111111111", false, "25b850e4-1b3c-4846-b14d-5982b8b4a95b", false, "Cora.Pouros13@gmail.com" },
                    { "74618ca3-b63e-4bdc-bb1e-69811183bd00", 0, new Guid("00000000-0000-0000-0000-000000000000"), "b26e5f09-9c7e-4325-83a9-43c7b55470ee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian.Prosacco@yahoo.com", true, "Christian", "Prosacco", false, null, "CHRISTIAN.PROSACCO@YAHOO.COM", "CHRISTIAN.PROSACCO@YAHOO.COM", "AJC5Z5S+aQ/4hDvO7u8LkCIMTOj0M7ZvjL3qmrCMsMcpvRfvrckx0kmjTI320wBH3Q==", "05111111111", false, "02d47e46-e3ab-431b-89b4-7a57986b9e51", false, "Christian.Prosacco@yahoo.com" },
                    { "756400a3-f2e3-407c-84b7-2b610e457813", 0, new Guid("00000000-0000-0000-0000-000000000000"), "e5d6c367-ecb2-451d-9470-f926cf8bc892", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harriet_Bosco@yahoo.com", true, "Harriet", "Bosco", false, null, "HARRIET_BOSCO@YAHOO.COM", "HARRIET_BOSCO@YAHOO.COM", "ADJ6Y8AET/FOlS9OPsamXEoU7kjUUKnGAAyidDkw8KuijTIBeTPJQK2uU7PTkTHYBA==", "05111111111", false, "b1addede-1e45-4e02-8cf6-6d083a157032", false, "Harriet_Bosco@yahoo.com" },
                    { "b7610c14-057c-40de-a184-f5d64c9a9d7f", 0, new Guid("00000000-0000-0000-0000-000000000000"), "c7de7231-dea3-4bcc-9a00-40bbe54c4cca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eddie_Altenwerth@hotmail.com", true, "Eddie", "Altenwerth", false, null, "EDDIE_ALTENWERTH@HOTMAIL.COM", "EDDIE_ALTENWERTH@HOTMAIL.COM", "AIbT6WL10ARJyZnXhWLnvkpgyBfpe3+d7nxe+35SbvsGHCHwdzx6MLCOIkb/INbSvA==", "05111111111", false, "d5807922-bd7a-46fb-948c-4ec1c9ba2051", false, "Eddie_Altenwerth@hotmail.com" },
                    { "1030ff91-7a78-4f13-a1ec-f627fa32b569", 0, new Guid("00000000-0000-0000-0000-000000000000"), "76990a50-4bcb-44fa-b0da-cd2e17e17988", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bobbie.Torp34@hotmail.com", true, "Bobbie", "Torp", false, null, "BOBBIE.TORP34@HOTMAIL.COM", "BOBBIE.TORP34@HOTMAIL.COM", "AD9aiZXkhkfSalfIEGHbr19D8edl8xjfiVVfbwLqc+NPllvsqb6etWzSZ23iDloVmA==", "05111111111", false, "3b17d684-d2b3-439f-a64d-85412e9e6857", false, "Bobbie.Torp34@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Email", "Facebook", "Fax", "Instagram", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "228 Alf Fords, Maximilliastad, Suriname", null, null, null, null, null, "Eleanor.Nikolaus@hotmail.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, null, null, null, null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 6, null, null, null, null, null, "İnsan Kaynakları", null, null, null, null, null, null },
                    { 5, null, null, null, null, null, "Yönetim", null, null, null, null, null, null },
                    { 4, null, null, null, null, null, "Resepsiyon", null, null, null, null, null, null },
                    { 3, null, null, null, null, null, "Mutfak", null, null, null, null, null, null },
                    { 2, null, null, null, null, null, "Bilgi İşlem", null, null, null, null, null, null },
                    { 1, null, null, null, null, null, "Yardımcı Hizmetler", null, null, null, null, null, null }
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
                table: "RoomFacilities",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FacilityName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 2, null, null, null, null, null, null, "Tv", null, null, null, null, null },
                    { 1, null, null, null, null, null, null, "Klima", null, null, null, null, null },
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
                    { 5, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet tek kişilik, bir adet iki kişilik yatak bulunmaktadır.", null, null, null, null, null, 2, 3, 1500m, "Triple Superior Room" },
                    { 1, null, null, null, null, null, "15 - 20 m² Single Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 1, 600m, "Single Room" },
                    { 4, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda üç adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 3, 1500m, "Triple Room" },
                    { 3, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda iki kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 2, 1050m, "Double Superior Room" },
                    { 7, null, null, null, null, null, "Yatak odası, yemek yeme alanına sahip oturma salonu ve iki ayrı banyosuyla 85 m² olan geniş kullanım alanı, şehir ve dağ manzarası ile konforu sunuyor.Rahatlamak ve keyif almak için özel olarak tasarlanan jakuzili banyoda ruhunuzu ve bedeninizi dinlendirebilir, gününüzü keyifle noktalayabilirsiniz.", null, null, null, null, null, 1, 2, 2500m, "Presidential Suite" },
                    { 6, null, null, null, null, null, "30 - 35 m² Family Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet çift kişilik, iki adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 4, 1900m, "Family Room" },
                    { 2, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik iki adet yatak bulunmaktadır.", null, null, null, null, null, 2, 2, 1050m, "Double Room" }
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
                    { 2, null, null, null, null, null, null, new TimeSpan(0, 0, 0, 0, 0), null, null, null, null, null, "Akşam", new TimeSpan(0, 16, 0, 0, 0) },
                    { 1, null, null, null, null, null, null, new TimeSpan(0, 16, 0, 0, 0), null, null, null, null, null, "Gündüz", new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "EndTime", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "ShiftName", "StartTime" },
                values: new object[] { 3, null, null, null, null, null, null, new TimeSpan(0, 8, 0, 0, 0), null, null, null, null, null, "Gece", new TimeSpan(0, 0, 0, 0, 0) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "3c8d2294-7919-49dd-bf66-44d5f193879f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e000de25-6b0a-4957-9aa5-ef6b66d8484d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "cdc2ec66-eb08-4faf-b83c-7a51d59ad92c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6786ba50-ce6f-4fa2-8994-5ff415dbefa1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "74618ca3-b63e-4bdc-bb1e-69811183bd00" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6a6257de-0560-48fb-8c63-f9db4327e1a1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c06dc470-ada2-4a62-a816-e56ce3482b30" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "194e2176-f23b-4d87-8a6d-603575f6da7d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "17e92d4d-8d29-457f-80f3-1ff18959998b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bbcedef2-06b5-4ddf-b609-ca5a78427cec" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "41b7f81a-bf37-4ab8-9c73-9ffb9035d841" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4c87d152-45ed-40d7-950e-22536f09a01b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "35901c53-ad28-4c59-83b9-5b2fdbf9cafd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "cef81cda-3204-48a7-a03e-257241f7116a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9f5aa4fa-5456-4e7b-bc0e-c17a9c96b793" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f6551f83-3117-4ccb-a881-289662cb8925" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "8a26c46c-4de3-480a-b678-26c94a9530eb" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b447bffb-1bfd-40ea-9922-330fdafb4810" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1ab015d1-a1d2-4646-bda6-623fc4c371ad" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "59c50966-a45c-45f4-b2a5-d32564eb5e2b" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1a8976a5-3cc2-4fba-9c72-cedb8e8eb213" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "c31e0739-2ed0-43e3-bbc1-ef42aebca270" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "fc827145-248d-4889-9265-958ae75058f2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "285151fd-90d5-4ffe-a9c8-2acedd3582d9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c31e0739-2ed0-43e3-bbc1-ef42aebca270" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "02d85a69-9e91-4c36-95fe-95a1c8909715" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "811718d7-5627-48ad-9908-ed64867a3033" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "95dc3b56-976f-4af2-b49c-adb48e1d8956" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "efb29df0-f1c0-45db-9f27-937ed7580fbc" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "20ebd9da-6a4b-43d1-bd66-72b93ba85437" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e9bec946-e3a7-4327-8100-9137fe2c4eca" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3e8c8626-f052-4562-8500-f02befa0570e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ebfe94ea-5c9f-47bb-b14a-8979ebc4fe4f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "3930342e-2654-4b8d-a418-1c0be8c68cc1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5b6215c2-88b0-4473-8e47-c81632d24bd4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b7747579-485e-4313-ae21-a7ddb1d4909e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d3d7494b-451a-4d6a-a2a0-0d7c6f4f73ca" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "a1ac7438-4802-4fb3-8070-a54ab4085bbd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "defff5b7-f601-4960-86ae-4579a87edf2c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "93f2687b-d100-40e5-86d2-405cf51f6f03" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b9d511dd-036d-4329-b74c-917bf4b77d44" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "44ae0eee-fe5e-4c13-80dc-f8721bc8d332" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "756400a3-f2e3-407c-84b7-2b610e457813" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "623ddee6-78bb-4e98-bc14-e71d2b29f85c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1030ff91-7a78-4f13-a1ec-f627fa32b569" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b7610c14-057c-40de-a184-f5d64c9a9d7f" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "02d85a69-9e91-4c36-95fe-95a1c8909715" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "71ec6d73-c677-4a08-9b14-d25230286c38" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "95dc3b56-976f-4af2-b49c-adb48e1d8956" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b7610c14-057c-40de-a184-f5d64c9a9d7f" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "fc827145-248d-4889-9265-958ae75058f2" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "1a8976a5-3cc2-4fba-9c72-cedb8e8eb213" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e000de25-6b0a-4957-9aa5-ef6b66d8484d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "cdc2ec66-eb08-4faf-b83c-7a51d59ad92c" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6786ba50-ce6f-4fa2-8994-5ff415dbefa1" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "74618ca3-b63e-4bdc-bb1e-69811183bd00" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "71ec6d73-c677-4a08-9b14-d25230286c38" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6a6257de-0560-48fb-8c63-f9db4327e1a1" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c06dc470-ada2-4a62-a816-e56ce3482b30" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "285151fd-90d5-4ffe-a9c8-2acedd3582d9" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "194e2176-f23b-4d87-8a6d-603575f6da7d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bbcedef2-06b5-4ddf-b609-ca5a78427cec" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "41b7f81a-bf37-4ab8-9c73-9ffb9035d841" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4c87d152-45ed-40d7-950e-22536f09a01b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "35901c53-ad28-4c59-83b9-5b2fdbf9cafd" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "cef81cda-3204-48a7-a03e-257241f7116a" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "811718d7-5627-48ad-9908-ed64867a3033" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f6551f83-3117-4ccb-a881-289662cb8925" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "8a26c46c-4de3-480a-b678-26c94a9530eb" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "17e92d4d-8d29-457f-80f3-1ff18959998b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "1030ff91-7a78-4f13-a1ec-f627fa32b569" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "9f5aa4fa-5456-4e7b-bc0e-c17a9c96b793" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "756400a3-f2e3-407c-84b7-2b610e457813" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "623ddee6-78bb-4e98-bc14-e71d2b29f85c" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "efb29df0-f1c0-45db-9f27-937ed7580fbc" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "20ebd9da-6a4b-43d1-bd66-72b93ba85437" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "e9bec946-e3a7-4327-8100-9137fe2c4eca" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "59c50966-a45c-45f4-b2a5-d32564eb5e2b" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3e8c8626-f052-4562-8500-f02befa0570e" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "ebfe94ea-5c9f-47bb-b14a-8979ebc4fe4f" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "3930342e-2654-4b8d-a418-1c0be8c68cc1" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "5b6215c2-88b0-4473-8e47-c81632d24bd4" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "59c50966-a45c-45f4-b2a5-d32564eb5e2b" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "d3d7494b-451a-4d6a-a2a0-0d7c6f4f73ca" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "b7747579-485e-4313-ae21-a7ddb1d4909e" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "1ab015d1-a1d2-4646-bda6-623fc4c371ad" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "b447bffb-1bfd-40ea-9922-330fdafb4810" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "44ae0eee-fe5e-4c13-80dc-f8721bc8d332" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "93f2687b-d100-40e5-86d2-405cf51f6f03" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "defff5b7-f601-4960-86ae-4579a87edf2c" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "a1ac7438-4802-4fb3-8070-a54ab4085bbd" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "b9d511dd-036d-4329-b74c-917bf4b77d44" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "b0a256fc-164f-4346-9f4a-3d2fa2d69d98" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "1ab015d1-a1d2-4646-bda6-623fc4c371ad", null, null, null, null, null, 2, "Anna.Schimmel6@gmail.com", 3, "Anna", 192.803513232061410m, "5222", true, "Schimmel", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 6, 26, 15, 34, 0, 615, DateTimeKind.Unspecified).AddTicks(5680), "Bilgi İşlem Sorumlusu" },
                    { 32, "c06dc470-ada2-4a62-a816-e56ce3482b30", null, null, null, null, null, 3, "Inez_Jones@yahoo.com", 3, "Inez", 198.888778564934050m, "1875", true, "Jones", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 12, 26, 1, 36, 25, 757, DateTimeKind.Unspecified).AddTicks(4430), "Garson" },
                    { 43, "b447bffb-1bfd-40ea-9922-330fdafb4810", null, null, null, null, null, 1, "Lindsay_Balistreri49@hotmail.com", 3, "Lindsay", 194.470321202869680m, "3948", true, "Balistreri", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 6, 16, 15, 17, 33, 919, DateTimeKind.Unspecified).AddTicks(5163), "Elektirikçi" },
                    { 36, "41b7f81a-bf37-4ab8-9c73-9ffb9035d841", null, null, null, null, null, 3, "Toby80@hotmail.com", 3, "Toby", 195.703555948894260m, "4635", true, "Schiller", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 1, 29, 19, 21, 44, 602, DateTimeKind.Unspecified).AddTicks(345), "Garson" },
                    { 35, "bbcedef2-06b5-4ddf-b609-ca5a78427cec", null, null, null, null, null, 3, "Laurie.Keebler93@yahoo.com", 3, "Laurie", 196.73258215502490m, "6725", true, "Keebler", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 7, 25, 5, 24, 1, 502, DateTimeKind.Unspecified).AddTicks(3646), "Garson" },
                    { 34, "17e92d4d-8d29-457f-80f3-1ff18959998b", null, null, null, null, null, 3, "Leslie18@yahoo.com", 3, "Leslie", 191.154976753124490m, "3558", true, "Abshire", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 2, 13, 16, 58, 57, 871, DateTimeKind.Unspecified).AddTicks(1436), "Garson" },
                    { 33, "194e2176-f23b-4d87-8a6d-603575f6da7d", null, null, null, null, null, 3, "Charles47@gmail.com", 3, "Charles", 190.4026090448734390m, "4232", true, "Harris", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 10, 24, 4, 22, 50, 850, DateTimeKind.Unspecified).AddTicks(560), "Garson" },
                    { 23, "b7610c14-057c-40de-a184-f5d64c9a9d7f", null, null, null, null, null, 3, "Eddie_Altenwerth@hotmail.com", 3, "Eddie", 191.62514270824620m, "2552", true, "Altenwerth", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 2, 16, 7, 29, 11, 821, DateTimeKind.Unspecified).AddTicks(1943), "Aşçı" },
                    { 30, "71ec6d73-c677-4a08-9b14-d25230286c38", null, null, null, null, null, 3, "Nicole_Luettgen@gmail.com", 3, "Nicole", 197.638414892199640m, "2294", true, "Luettgen", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 11, 28, 18, 12, 24, 473, DateTimeKind.Unspecified).AddTicks(3645), "Garson" },
                    { 24, "fc827145-248d-4889-9265-958ae75058f2", null, null, null, null, null, 3, "Sidney.Corkery@gmail.com", 3, "Sidney", 192.053674530262910m, "3614", true, "Corkery", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 5, 19, 2, 22, 32, 990, DateTimeKind.Unspecified).AddTicks(5014), "Aşçı" },
                    { 45, "b0a256fc-164f-4346-9f4a-3d2fa2d69d98", null, null, null, null, null, 5, "Elias_Bartoletti@gmail.com", 0, "Elias", 192.330899365400380m, "4788", true, "Bartoletti", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2020, 6, 16, 14, 23, 57, 366, DateTimeKind.Unspecified).AddTicks(386), "Müdür" },
                    { 22, "285151fd-90d5-4ffe-a9c8-2acedd3582d9", null, null, null, null, null, 3, "Cora.Pouros13@gmail.com", 3, "Cora", 196.858992896442760m, "9483", true, "Pouros", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 10, 11, 19, 14, 19, 803, DateTimeKind.Unspecified).AddTicks(5419), "Aşçı" },
                    { 21, "1030ff91-7a78-4f13-a1ec-f627fa32b569", null, null, null, null, null, 3, "Bobbie.Torp34@hotmail.com", 3, "Bobbie", 193.583972516275930m, "6430", true, "Torp", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 6, 9, 0, 19, 4, 29, DateTimeKind.Unspecified).AddTicks(4449), "Aşçı" },
                    { 20, "623ddee6-78bb-4e98-bc14-e71d2b29f85c", null, null, null, null, null, 3, "Johnnie32@hotmail.com", 3, "Johnnie", 194.422458202774850m, "2765", true, "Bergnaum", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 5, 3, 3, 41, 43, 872, DateTimeKind.Unspecified).AddTicks(745), "Aşçı" },
                    { 19, "756400a3-f2e3-407c-84b7-2b610e457813", null, null, null, null, null, 3, "Harriet_Bosco@yahoo.com", 3, "Harriet", 193.582017455986710m, "3107", true, "Bosco", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 12, 0, 40, 53, 169, DateTimeKind.Unspecified).AddTicks(8421), "Aşçı" },
                    { 13, "d3d7494b-451a-4d6a-a2a0-0d7c6f4f73ca", null, null, null, null, null, 1, "Anita60@hotmail.com", 3, "Anita", 192.538813339797230m, "8384", true, "Price", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 11, 18, 20, 47, 49, 799, DateTimeKind.Unspecified).AddTicks(8281), "Temizlik Görevlisi" },
                    { 31, "6a6257de-0560-48fb-8c63-f9db4327e1a1", null, null, null, null, null, 3, "Tricia.Hickle67@yahoo.com", 3, "Tricia", 197.179552860175980m, "6606", true, "Hickle", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 4, 19, 8, 1, 42, 719, DateTimeKind.Unspecified).AddTicks(2282), "Garson" },
                    { 46, "59c50966-a45c-45f4-b2a5-d32564eb5e2b", null, null, null, null, null, 6, "Noah.Brakus38@yahoo.com", 1, "Noah", 192.53723741627170m, "8669", true, "Brakus", null, null, null, null, null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 8, 12, 10, 18, 45, 981, DateTimeKind.Unspecified).AddTicks(476), "İnsan Kaynakları Müdürü" },
                    { 17, "b9d511dd-036d-4329-b74c-917bf4b77d44", null, null, null, null, null, 1, "Alex0@yahoo.com", 3, "Alex", 196.020840176390880m, "2795", true, "Lebsack", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 5, 19, 7, 19, 48, 75, DateTimeKind.Unspecified).AddTicks(553), "Temizlik Görevlisi" },
                    { 5, "efb29df0-f1c0-45db-9f27-937ed7580fbc", null, null, null, null, null, 4, "Gretchen44@hotmail.com", 3, "Gretchen", 192.224036977730710m, "1555", true, "Turcotte", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 7, 30, 19, 13, 20, 556, DateTimeKind.Unspecified).AddTicks(226), "Resepsiyonist" },
                    { 12, "b7747579-485e-4313-ae21-a7ddb1d4909e", null, null, null, null, null, 1, "Nicolas30@gmail.com", 3, "Nicolas", 196.460333958482520m, "7846", true, "Blick", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 6, 9, 13, 42, 41, 824, DateTimeKind.Unspecified).AddTicks(6983), "Temizlik Görevlisi" },
                    { 7, "e9bec946-e3a7-4327-8100-9137fe2c4eca", null, null, null, null, null, 4, "Lucia.Dibbert@hotmail.com", 3, "Lucia", 192.094758731357180m, "4122", true, "Dibbert", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2019, 9, 24, 18, 7, 1, 362, DateTimeKind.Unspecified).AddTicks(3733), "Resepsiyonist" },
                    { 6, "20ebd9da-6a4b-43d1-bd66-72b93ba85437", null, null, null, null, null, 4, "Tim.Corkery74@gmail.com", 3, "Tim", 192.097057687163850m, "8526", true, "Corkery", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2019, 7, 1, 15, 45, 37, 262, DateTimeKind.Unspecified).AddTicks(8160), "Resepsiyonist" },
                    { 42, "8a26c46c-4de3-480a-b678-26c94a9530eb", null, null, null, null, null, 3, "Bruce_Lindgren@hotmail.com", 3, "Bruce", 199.067978295063590m, "7661", true, "Lindgren", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 1, 1, 9, 2, 42, 912, DateTimeKind.Unspecified).AddTicks(5112), "Garson" },
                    { 41, "f6551f83-3117-4ccb-a881-289662cb8925", null, null, null, null, null, 3, "Rudy19@gmail.com", 3, "Rudy", 195.150397087051720m, "5790", true, "Kshlerin", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 9, 16, 8, 59, 47, 30, DateTimeKind.Unspecified).AddTicks(5264), "Garson" },
                    { 40, "9f5aa4fa-5456-4e7b-bc0e-c17a9c96b793", null, null, null, null, null, 3, "Beatrice_Effertz39@gmail.com", 3, "Beatrice", 199.612687881855620m, "3893", true, "Effertz", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 5, 4, 14, 23, 53, 556, DateTimeKind.Unspecified).AddTicks(1733), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "cef81cda-3204-48a7-a03e-257241f7116a", null, null, null, null, null, 3, "Roman47@gmail.com", 3, "Roman", 193.028567220563330m, "1889", true, "Kuhn", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 8, 26, 2, 47, 57, 366, DateTimeKind.Unspecified).AddTicks(9975), "Garson" },
                    { 38, "35901c53-ad28-4c59-83b9-5b2fdbf9cafd", null, null, null, null, null, 3, "Arturo.Schneider@yahoo.com", 3, "Arturo", 195.310121879591660m, "3752", true, "Schneider", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 4, 2, 11, 26, 33, 324, DateTimeKind.Unspecified).AddTicks(4046), "Garson" },
                    { 37, "4c87d152-45ed-40d7-950e-22536f09a01b", null, null, null, null, null, 3, "Doug_Hegmann@yahoo.com", 3, "Doug", 195.119428474046020m, "1457", true, "Hegmann", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 4, 14, 1, 45, 46, 916, DateTimeKind.Unspecified).AddTicks(4753), "Garson" },
                    { 28, "6786ba50-ce6f-4fa2-8994-5ff415dbefa1", null, null, null, null, null, 3, "Samuel_Collier43@hotmail.com", 3, "Samuel", 192.309013373362370m, "9335", true, "Collier", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 6, 8, 11, 17, 3, 221, DateTimeKind.Unspecified).AddTicks(9660), "Aşçı" },
                    { 27, "cdc2ec66-eb08-4faf-b83c-7a51d59ad92c", null, null, null, null, null, 3, "Sally.Rosenbaum@gmail.com", 3, "Sally", 199.346701232412220m, "7612", true, "Rosenbaum", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 3, 9, 34, 40, 687, DateTimeKind.Unspecified).AddTicks(2107), "Aşçı" },
                    { 26, "e000de25-6b0a-4957-9aa5-ef6b66d8484d", null, null, null, null, null, 3, "Erma_Bailey17@gmail.com", 3, "Erma", 193.597491664624540m, "8789", true, "Bailey", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 21, 20, 20, 35, 328, DateTimeKind.Unspecified).AddTicks(282), "Aşçı" },
                    { 25, "1a8976a5-3cc2-4fba-9c72-cedb8e8eb213", null, null, null, null, null, 3, "Yvette_Hoeger@yahoo.com", 3, "Yvette", 197.968127391286250m, "5558", true, "Hoeger", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 8, 31, 22, 11, 4, 273, DateTimeKind.Unspecified).AddTicks(5714), "Aşçı" },
                    { 18, "44ae0eee-fe5e-4c13-80dc-f8721bc8d332", null, null, null, null, null, 1, "Alice87@hotmail.com", 3, "Alice", 198.812662856100440m, "7442", true, "McCullough", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 9, 5, 1, 53, 10, 947, DateTimeKind.Unspecified).AddTicks(2897), "Temizlik Görevlisi" },
                    { 16, "93f2687b-d100-40e5-86d2-405cf51f6f03", null, null, null, null, null, 1, "Joe_Gutkowski@yahoo.com", 3, "Joe", 191.505005136833060m, "9832", true, "Gutkowski", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 7, 14, 18, 57, 43, 95, DateTimeKind.Unspecified).AddTicks(5693), "Temizlik Görevlisi" },
                    { 15, "defff5b7-f601-4960-86ae-4579a87edf2c", null, null, null, null, null, 1, "Melvin_Harvey@gmail.com", 3, "Melvin", 192.053496228555910m, "4396", true, "Harvey", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 4, 19, 12, 13, 2, 883, DateTimeKind.Unspecified).AddTicks(8740), "Temizlik Görevlisi" },
                    { 14, "a1ac7438-4802-4fb3-8070-a54ab4085bbd", null, null, null, null, null, 1, "Priscilla.Douglas89@gmail.com", 3, "Priscilla", 192.512443537131160m, "6255", true, "Douglas", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 12, 17, 3, 32, 17, 282, DateTimeKind.Unspecified).AddTicks(3076), "Temizlik Görevlisi" },
                    { 4, "95dc3b56-976f-4af2-b49c-adb48e1d8956", null, null, null, null, null, 4, "Randal.Emmerich63@gmail.com", 3, "Randal", 194.779848323566770m, "3593", true, "Emmerich", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 1, 26, 8, 18, 0, 760, DateTimeKind.Unspecified).AddTicks(7242), "Resepsiyonist" },
                    { 29, "74618ca3-b63e-4bdc-bb1e-69811183bd00", null, null, null, null, null, 3, "Christian.Prosacco@yahoo.com", 3, "Christian", 198.743375846530950m, "8910", true, "Prosacco", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 10, 21, 18, 26, 43, 78, DateTimeKind.Unspecified).AddTicks(2023), "Aşçı" },
                    { 11, "5b6215c2-88b0-4473-8e47-c81632d24bd4", null, null, null, null, null, 1, "Latoya_Reynolds@yahoo.com", 3, "Latoya", 195.025052290887130m, "3202", true, "Reynolds", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 5, 17, 16, 53, 26, 783, DateTimeKind.Unspecified).AddTicks(8237), "Temizlik Görevlisi" },
                    { 9, "ebfe94ea-5c9f-47bb-b14a-8979ebc4fe4f", null, null, null, null, null, 1, "Flora.Mitchell27@gmail.com", 3, "Flora", 190.005466695877475060m, "2603", true, "Mitchell", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 5, 13, 13, 4, 57, 491, DateTimeKind.Unspecified).AddTicks(7373), "Temizlik Görevlisi" },
                    { 8, "3e8c8626-f052-4562-8500-f02befa0570e", null, null, null, null, null, 1, "Clay.Schaden@hotmail.com", 3, "Clay", 195.031317898552550m, "5692", true, "Schaden", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 12, 24, 4, 29, 30, 361, DateTimeKind.Unspecified).AddTicks(5244), "Temizlik Görevlisi" },
                    { 3, "811718d7-5627-48ad-9908-ed64867a3033", null, null, null, null, null, 4, "Kim_Goldner@hotmail.com", 3, "Kim", 190.6560727398172360m, "9641", true, "Goldner", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 8, 10, 23, 11, 4, 684, DateTimeKind.Unspecified).AddTicks(7855), "Resepsiyonist" },
                    { 2, "02d85a69-9e91-4c36-95fe-95a1c8909715", null, null, null, null, null, 4, "Guillermo_Yost38@yahoo.com", 3, "Guillermo", 196.488734118868010m, "3369", true, "Yost", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 1, 3, 6, 46, 286, DateTimeKind.Unspecified).AddTicks(6042), "Resepsiyonist" },
                    { 1, "c31e0739-2ed0-43e3-bbc1-ef42aebca270", null, null, null, null, null, 4, "Dominic92@gmail.com", 3, "Dominic", 198.032466600664180m, "2499", true, "Graham", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 9, 3, 8, 17, 46, 854, DateTimeKind.Unspecified).AddTicks(7388), "Resepsiyonist" },
                    { 10, "3930342e-2654-4b8d-a418-1c0be8c68cc1", null, null, null, null, null, 1, "Nellie.Schuster@yahoo.com", 3, "Nellie", 194.857698345956250m, "6830", true, "Schuster", null, null, null, null, null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 12, 16, 6, 54, 3, 229, DateTimeKind.Unspecified).AddTicks(5776), "Temizlik Görevlisi" }
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
