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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
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
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Paragraph1", "Paragraph2", "Paragraph3", "Paragraph4", "Paragraph5", "PictureUrl", "Title" },
                values: new object[] { 1, null, null, "Kemer’in tarihi ve kültürel merkezlerinin kesişim noktasında yer alan, şehrin ilk 5 yıldızlı konaklama tesisi unvanına sahip Bilge Hotel, 35 yıllık deneyimi ile alanının en iyisi olmaya devam ediyor.", "Bilge Hotel, Osmanlı sarayları ve Fransız mimarisinden esinlenilerek özenle tasarlanmış yeni konsepti kapsamında; birbirinden farklı şekilde dekore edilmiş lüks oda ve süitleri, Türk ve dünya mutfağının seçkin lezzetlerini servis eden restoranları, A’dan Z’ye yenilenmiş SPA tesisiyle misafirlerine en konforlu konaklama deneyimini sunuyor.", "Bilge Hotel iş toplantıları, kutlamalar ve farklı özel etkinlikler için 1000 kişilik kapasiteye ve eksiksiz teknik donanıma sahip salonlarıyla bir şehir otelinin ötesine geçerek kişiye özel lüks hizmetler sunuyor.", "Kemer şehir merkezinde yer alan Bilge Otel, alışveriş merkezlerine, Atatürk Kongre ve Kültür Merkezi’ne ve toplu taşıma duraklarına yürüyüş mesafesindedir.", "Bilge Hotel Güvenli Turizm Sertifikası, ISO 22000 Gıda Güvenliği Yönetim Sistemi Belgesi, Sıfır Atık Belgesi ve Turuncu Bayrak sahibidir.", "/img/aboutus-img.jpg", "Bilge Hotel, Kalite ve Konforun Adresi" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "dbdd0250-8202-4426-a297-39f61b017a99", "mutfak", "MUTFAK" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "8f479cd3-50c1-42bf-9cc4-a95e1f473b29", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "30a06449-e697-4fb9-bac3-2d70835eaee1", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "9a4bf2d6-1b64-457b-8b29-00e8eb1db8b3", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "db214d5f-71c2-4851-9ed6-337e2c01cfa0", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "de8209ce-61bd-4984-87dc-5b7649b4003f", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b6920541-d456-413e-ae6e-211cc47a12d2", "user", "USER" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "11d54461-a261-488e-b6f7-0222c8289941", "muhasebe", "MUHASEBE" },
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "6b7a277f-bd9b-4c2e-a545-c1fee380ec60", "valilik", "VALILIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7285fc22-3947-4259-9d7b-2ce5fd47fdea", 0, null, "9f5f7b7d-8f1c-437a-9608-5b598adfe475", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elmer32@hotmail.com", true, "Elmer", "Ryan", false, null, "ELMER32@HOTMAIL.COM", "ELMER32@HOTMAIL.COM", "AJZalJ9xTvPPgAtIC/MbCYu/2QtHcwlryEGJzH1I2+I0+PdfyISOSsMp0YcFT+Mopg==", "05111111111", false, "43e7f88f-65c0-481f-8d6d-c5a66e25f6d9", false, "Elmer32@hotmail.com" },
                    { "507e0bf1-a9b8-4621-b43e-428b5d1b4e3d", 0, null, "04e46680-d27c-499b-b09e-0358ec6fadc3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie_Hudson74@yahoo.com", true, "Willie", "Hudson", false, null, "WILLIE_HUDSON74@YAHOO.COM", "WILLIE_HUDSON74@YAHOO.COM", "AAHad1NbWhPfFl2GGeDkn3wW9uai3ZtaO0HSIbnrtjpZq12L3X7g3oJZSDn+Z9RrEQ==", "05111111111", false, "3e612cf5-feeb-497b-9a2e-485876849f6c", false, "Willie_Hudson74@yahoo.com" },
                    { "59b0a516-dc46-4296-b099-f6fb98b82325", 0, null, "d26516e5-46c1-4aa6-bfb4-b52b7cb8b334", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vickie_Schaefer@hotmail.com", true, "Vickie", "Schaefer", false, null, "VICKIE_SCHAEFER@HOTMAIL.COM", "VICKIE_SCHAEFER@HOTMAIL.COM", "AO1xsSPTe/cBN+DIdbbuZ3dl8Nsun3+ErybMVujJadanc6t4LmTLvduoeMDIqiPjKQ==", "05111111111", false, "6b156f0e-8c6d-4335-9f01-7a4d1ca6af94", false, "Vickie_Schaefer@hotmail.com" },
                    { "23c9dc4d-dbc0-453e-8c75-fa2c106bc948", 0, null, "0108fcc8-c1cb-417a-b949-d4aeec5544e0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole.Mosciski@yahoo.com", true, "Nicole", "Mosciski", false, null, "NICOLE.MOSCISKI@YAHOO.COM", "NICOLE.MOSCISKI@YAHOO.COM", "AGYBwuAD/CUIK3eMrRO+n59kzks/Atmj3BwJEaU/eh1QUb8Q9DjedyiqszqztdlyoQ==", "05111111111", false, "872c5e47-a659-4b25-b771-83dcd0888ce6", false, "Nicole.Mosciski@yahoo.com" },
                    { "9d834ef1-80bb-4461-bac3-309b1d63e329", 0, null, "ca2230a4-105a-4b60-a514-cca9c48073ee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darnell83@gmail.com", true, "Darnell", "Waelchi", false, null, "DARNELL83@GMAIL.COM", "DARNELL83@GMAIL.COM", "AK8oaE2iUfdXh9xOm/GbAZd1j9jbId3+24exOi7914WZHGrn8wOdEX2KUR1qkiW4zQ==", "05111111111", false, "b7f0fb5b-1d16-4996-a3df-30240dd0e8c9", false, "Darnell83@gmail.com" },
                    { "545e20b2-a909-4949-bd52-a90770b47452", 0, null, "937d672a-ae76-4bc8-aea4-75261dc94272", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaron_McGlynn64@yahoo.com", true, "Aaron", "McGlynn", false, null, "AARON_MCGLYNN64@YAHOO.COM", "AARON_MCGLYNN64@YAHOO.COM", "AHjrmUqC3MP60aNnMDOX7OjroZQhSFFYFXZErRRRmW5PlyrJamz3a8pMdxyTFIIsVw==", "05111111111", false, "6f88d816-eacb-4a4c-8929-0ff63354cff7", false, "Aaron_McGlynn64@yahoo.com" },
                    { "be4f444f-5371-444c-a361-60a8f77c872b", 0, null, "20d4bbea-5f9f-4d65-a5f6-7d99f0386aef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phillip86@hotmail.com", true, "Phillip", "Kautzer", false, null, "PHILLIP86@HOTMAIL.COM", "PHILLIP86@HOTMAIL.COM", "AD4rbSp2lBGvoUXA3LHgEFLNtAhg3U++uqVp9EKzo9csLCk9i34q/z/W+2It5wm7/g==", "05111111111", false, "daa6fa5a-96d5-46fa-bd9e-18dfe3a8b4ab", false, "Phillip86@hotmail.com" },
                    { "13fb1c19-74b3-41c8-9228-93186c262f87", 0, null, "5a4abc36-4b74-4a09-a9b3-24b4278ec4e8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perry.Denesik@hotmail.com", true, "Perry", "Denesik", false, null, "PERRY.DENESIK@HOTMAIL.COM", "PERRY.DENESIK@HOTMAIL.COM", "AMqmaowu3mXxLmU81dyH7w1yz1g+ufRAR6S8t5TUl0UFMPBpBSWoxj4SRDiJbkOL1Q==", "05111111111", false, "27721b06-79fa-4ef1-9061-eef3ee932ada", false, "Perry.Denesik@hotmail.com" },
                    { "ea1676eb-0861-411a-85e9-a489bfc40a38", 0, null, "4bd13d73-6925-4bf0-ad19-2aa5c2c9f069", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria26@gmail.com", true, "Victoria", "Howell", false, null, "VICTORIA26@GMAIL.COM", "VICTORIA26@GMAIL.COM", "ADYZMBcLA9wWGTyc0lLkNzaLjw9iCSQ41HajWuTvQEKy6AkZiVKw4LV4z6iTsSZ1Cw==", "05111111111", false, "3261cfe7-3e3e-4e8e-a5cd-6a893b176d78", false, "Victoria26@gmail.com" },
                    { "fa5fd19b-46e4-4ad5-b61c-c7550a3921ba", 0, null, "55085be4-118f-4c7f-8b5a-77c38d6dbce0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Craig.Murazik@gmail.com", true, "Craig", "Murazik", false, null, "CRAIG.MURAZIK@GMAIL.COM", "CRAIG.MURAZIK@GMAIL.COM", "AHZ/9XUc0Ng+WvkEw19HBzP1gxHUgcODroOLiOoG4+tbGfEs5w1CK/AijeyHJb21Bw==", "05111111111", false, "6b8f1bcc-5eb1-465e-a17e-986e3ac0b842", false, "Craig.Murazik@gmail.com" },
                    { "04424223-c870-4a90-9c76-1fe4788041f7", 0, null, "c3eb1b7c-a988-47be-bbde-db4d75534b2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brenda_Graham@yahoo.com", true, "Brenda", "Graham", false, null, "BRENDA_GRAHAM@YAHOO.COM", "BRENDA_GRAHAM@YAHOO.COM", "AKq5f8h/IJ41wzeo1a8CJksPuo9PqxLPZhOYMNlT6Cc07sNdYRBfGr/XrDtE/LZF2w==", "05111111111", false, "59ef8db9-a684-4313-a719-835b010dc5fc", false, "Brenda_Graham@yahoo.com" },
                    { "6750220c-db37-41ac-abc2-ba89db5e34df", 0, null, "91608438-17e4-439a-9f29-a23f7c56d3ef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preston.Hyatt27@hotmail.com", true, "Preston", "Hyatt", false, null, "PRESTON.HYATT27@HOTMAIL.COM", "PRESTON.HYATT27@HOTMAIL.COM", "AKZanl4ZIMRLwSYtLvHwSXe3QuDivum61GOE41Mq37Jole9dclQPOQoHiiXLrPcg6A==", "05111111111", false, "cda68d4f-7560-4f82-9c06-bf1add79e818", false, "Preston.Hyatt27@hotmail.com" },
                    { "c2779518-1f30-4806-a8b7-471e97509137", 0, null, "c38b1f1a-5b2e-4565-968d-f9603f036227", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco.Boyer@yahoo.com", true, "Francisco", "Boyer", false, null, "FRANCISCO.BOYER@YAHOO.COM", "FRANCISCO.BOYER@YAHOO.COM", "AFAskGohfgq/t2RCxxyvmzcZA5amI5tdtJ80EsGF+Vdmxw+nJlcr89fvWwHoEmqvDA==", "05111111111", false, "c2f3481a-ca9c-48af-ae64-a5ea169529d0", false, "Francisco.Boyer@yahoo.com" },
                    { "496b7fc0-0129-4f90-8a63-f3e3b8271f43", 0, null, "9a64dda2-a67d-424c-9c31-34e9e832d7df", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erica16@hotmail.com", true, "Erica", "Murray", false, null, "ERICA16@HOTMAIL.COM", "ERICA16@HOTMAIL.COM", "AP3eiC4YOMNM7TEgJQ7lqXO7/EM5qPIdKd44fM33m0J2F7mfsBiw4iShZx9ivBr/sQ==", "05111111111", false, "f3869cc1-39c4-49b0-a887-bbbdf7e6b95d", false, "Erica16@hotmail.com" },
                    { "cbd6ca5e-672b-4244-93f0-92e85d0e48d4", 0, null, "1cef7d82-632b-4e34-85b8-e7abfe8f58d0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valilik@bilgehotel.com", true, "Bilge", "Hotel", false, null, "VALILIK@BILGEHOTEL.COM", "VALILIK@BILGEHOTEL.COM", "AHNPLju4yYwGG+VqvmvossrMrZGdKyYJBQSpItcgMIn31TBF7RCfQtyE6uNRK09Rcw==", "05111111111", false, "f7a7bdca-9dca-432f-a3d1-0f9ca39feeac", false, "valilik@bilgehotel.com" },
                    { "504039e4-19af-4539-a87b-8c228f3fe7b6", 0, null, "a490fb52-9028-4742-b4d0-1a7e9a1451a3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dale_DAmore66@gmail.com", true, "Dale", "D'Amore", false, null, "DALE_DAMORE66@GMAIL.COM", "DALE_DAMORE66@GMAIL.COM", "AFw7RHj9SzmRSLOpOPr2d/FXNoVSvdZ2rdsXVzrMb1fGyqA6TddaeBeCgVApsYtvgQ==", "05111111111", false, "9e4d7576-4636-44c1-94d3-b8aad7a69e95", false, "Dale_DAmore66@gmail.com" },
                    { "4f7ce9a5-6295-4cbb-8f7e-b39ccd7d2601", 0, null, "2dc5f57d-ed74-44ca-9dc9-599e98dcd3cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremy.Cassin4@yahoo.com", true, "Jeremy", "Cassin", false, null, "JEREMY.CASSIN4@YAHOO.COM", "JEREMY.CASSIN4@YAHOO.COM", "AHVtBkPFppBzRSlTVtz0jQUfFe89jn5PNFT8VNDdmvpNYI7NkkQLGiuSDw0MwlD0hg==", "05111111111", false, "e37b48e5-8a3a-416e-9d8c-167b64c93156", false, "Jeremy.Cassin4@yahoo.com" },
                    { "6251bfd1-6a86-468e-b521-d2bd5bd1fab1", 0, null, "c66d4a65-0fd2-474b-8dca-8c7c7b84855b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eddie14@yahoo.com", true, "Eddie", "Christiansen", false, null, "EDDIE14@YAHOO.COM", "EDDIE14@YAHOO.COM", "AJqsZBxRkAU9SVlC0deK21YgAES+YDWDYBYgsPilYncDIOWZJQFwWIrTvcLfkhRrVQ==", "05111111111", false, "7de173eb-9e8c-4b62-9a20-24a4acaed050", false, "Eddie14@yahoo.com" },
                    { "69c199e2-4d83-424c-a63d-43c48e347d81", 0, null, "7d421fee-fa41-4767-92bc-4f7cbca08e32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pat.Miller27@gmail.com", true, "Pat", "Miller", false, null, "PAT.MILLER27@GMAIL.COM", "PAT.MILLER27@GMAIL.COM", "ABiLvUf9uPe5s/qogis6w4D4kBrQ8SM69DJ/2DNXBJUrhfmQbDowqqodPEDJamTGrA==", "05111111111", false, "6e624561-9f77-4e97-83cf-6b5e5bcc953e", false, "Pat.Miller27@gmail.com" },
                    { "23325d5c-376d-43a0-a56a-9640344d2add", 0, null, "12e588a5-81cd-4896-a87e-d7d76c55a303", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger_Braun59@gmail.com", true, "Ginger", "Braun", false, null, "GINGER_BRAUN59@GMAIL.COM", "GINGER_BRAUN59@GMAIL.COM", "AA5u1/OasmS8mZLbVzDKPydw+kiaYKgL3k3yGzFnlpiaKo/+MwU59Antj+OaeGpxBg==", "05111111111", false, "82287f48-54ee-44e7-ab6c-a20e44f7dd73", false, "Ginger_Braun59@gmail.com" },
                    { "9e1d18ea-f2a2-43d3-8166-5abf46f868b1", 0, null, "195ac6c2-8736-4066-805b-d757f76eeab8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kendra.Larson68@yahoo.com", true, "Kendra", "Larson", false, null, "KENDRA.LARSON68@YAHOO.COM", "KENDRA.LARSON68@YAHOO.COM", "AIBQdDAVwrOP1iXZZTuBn6kHv7id4WEUgV1tiJkXLaaNMFt2w6z+g/wLCX0eAmkSGA==", "05111111111", false, "975087d3-bc62-455e-b572-10b4b92f8f01", false, "Kendra.Larson68@yahoo.com" },
                    { "5c307b3f-3706-43cc-9b5c-1112191cfad8", 0, null, "9ca91322-b37d-4b65-8131-9890c9bf5885", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bertha70@yahoo.com", true, "Bertha", "Rosenbaum", false, null, "BERTHA70@YAHOO.COM", "BERTHA70@YAHOO.COM", "AHfnSR+nDBwG2F2DdGuz6P9zGAtMSLmWsUzKbcXykZ4TJRILdFox/VsOrokDn7M5Ug==", "05111111111", false, "d29e0ba1-5c0f-42ae-8589-078bae0af8db", false, "Bertha70@yahoo.com" },
                    { "96ede2c4-7c30-4ae6-9269-c6d921062bf9", 0, null, "9e7a3a9d-fd08-4f4c-a5fc-7cd6a3d7f1c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myra4@hotmail.com", true, "Myra", "Watsica", false, null, "MYRA4@HOTMAIL.COM", "MYRA4@HOTMAIL.COM", "AO8T7gYTjjQ+Y1S23YWe3fs/wt/+YKP8335cQ5sWY9+5inpVZmCoqW2kpq19gXkx9w==", "05111111111", false, "90f8caca-b5a5-4a77-bd64-41729bec61f3", false, "Myra4@hotmail.com" },
                    { "89bb616f-5d85-4ffd-b372-e0e0ed7bcbf4", 0, null, "6ea3f0f1-5aa7-45c5-a5d5-71632227b6ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camille_Stracke56@yahoo.com", true, "Camille", "Stracke", false, null, "CAMILLE_STRACKE56@YAHOO.COM", "CAMILLE_STRACKE56@YAHOO.COM", "ANURxiwyxuS3dRHRWkBUAQxlVA3GzpeGxXshuj27x82eFDSN9RtXLpm+jm5FgpRm0g==", "05111111111", false, "9d4a702c-49ab-4486-bb8b-10efa96d9ae8", false, "Camille_Stracke56@yahoo.com" },
                    { "49c33160-ee6e-4dbe-8c77-56d8fedb6865", 0, null, "a96c2c53-728c-4ebc-b80c-62647bc936fe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earnest_Mitchell22@yahoo.com", true, "Earnest", "Mitchell", false, null, "EARNEST_MITCHELL22@YAHOO.COM", "EARNEST_MITCHELL22@YAHOO.COM", "ANIDRs0yEGbjdoQBN96oE0DD+1ZLDpdcL49DByu4e8+tpvW9Las/LIztfUkcNkrqSw==", "05111111111", false, "a92e3097-749f-47bc-b9ff-98d548aa446b", false, "Earnest_Mitchell22@yahoo.com" },
                    { "4a0a01c7-e573-4d15-b581-52dfb20a9e72", 0, null, "bf9c651f-9451-49f4-ad36-217bf08c78e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veronica.Nitzsche76@yahoo.com", true, "Veronica", "Nitzsche", false, null, "VERONICA.NITZSCHE76@YAHOO.COM", "VERONICA.NITZSCHE76@YAHOO.COM", "AOW36sNWumhjniqUZS1CNbL6FWs17aAWKJo8lE5rs/CwlYlOioY8x6Q8ctsZHBOxOg==", "05111111111", false, "dabb9704-0620-4678-b616-1dbbf5aad1f0", false, "Veronica.Nitzsche76@yahoo.com" },
                    { "e27fc89c-3f88-4084-8fcb-450602c4bfa9", 0, null, "0dc36532-c561-408b-9846-b4f9d05921c0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connie_Emard74@hotmail.com", true, "Connie", "Emard", false, null, "CONNIE_EMARD74@HOTMAIL.COM", "CONNIE_EMARD74@HOTMAIL.COM", "ADWEpeMciBOm+3WbrTWIUwCi0sB6gqqni6JSUUnwFnrq3c5KFyFbxaTd7kFV1h7dwQ==", "05111111111", false, "f4af82e8-f72e-4362-9882-83d393f717b3", false, "Connie_Emard74@hotmail.com" },
                    { "73543b77-c9ba-49af-b8f6-94f3942a6299", 0, null, "fba68f95-dc04-40be-a32b-92d59d31df75", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lela_Buckridge@yahoo.com", true, "Lela", "Buckridge", false, null, "LELA_BUCKRIDGE@YAHOO.COM", "LELA_BUCKRIDGE@YAHOO.COM", "AIE7K5QXF7tDN6VFUPhZIGrVjMEbLRNSStBYt7zQpQMLalabVxDL1e9Z8k5JRwJP0g==", "05111111111", false, "774c5d77-2924-43a8-a6eb-86ee28e0aa26", false, "Lela_Buckridge@yahoo.com" },
                    { "bf72edbd-72c0-48d8-8e95-30dc2d5ec54a", 0, null, "4abc7807-ea8b-45b4-976b-bf8d3b0d1f10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosie93@hotmail.com", true, "Rosie", "Lakin", false, null, "ROSIE93@HOTMAIL.COM", "ROSIE93@HOTMAIL.COM", "AOmIQqgwBFgUOnpvOCywFNlLRP5yTJoOgNdBZpKw4MSIgNqx7a6Nv+8zGuj+SmS7gQ==", "05111111111", false, "aa8cf484-297d-4cba-b2a1-7092994af983", false, "Rosie93@hotmail.com" },
                    { "f98d197a-8641-4e97-963b-1931ce645a72", 0, null, "ae91aee0-86f4-4f83-af51-7e84e0487216", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cora_Waters12@gmail.com", true, "Cora", "Waters", false, null, "CORA_WATERS12@GMAIL.COM", "CORA_WATERS12@GMAIL.COM", "ABcOYdO2+rYGMjWr6UXuvVuoH7yg5SCA2jWk8RYtaAY3udjRQcxi+7/GyeCMmPMbuA==", "05111111111", false, "16e458d5-cdd7-4add-b5d8-b47459d34ee9", false, "Cora_Waters12@gmail.com" },
                    { "4e57de01-388c-454a-9b91-120559cf3d83", 0, null, "4bba0c21-87e4-4655-9264-b68e69ac007e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosa94@yahoo.com", true, "Rosa", "Grant", false, null, "ROSA94@YAHOO.COM", "ROSA94@YAHOO.COM", "AIjDSrfDlgfGtiNDlbB7+57H2e7W0Lss4r+PyBIqXRsur2ltzPmt1uWZLJaTFn2c7g==", "05111111111", false, "004e5710-c1e7-4a3b-ab5a-7f0781fb0be6", false, "Rosa94@yahoo.com" },
                    { "09b6d160-f680-4cef-ba42-fa02e7f674f0", 0, null, "f991f3a0-0830-4a6f-b279-6147b1b82a22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luz10@hotmail.com", true, "Luz", "VonRueden", false, null, "LUZ10@HOTMAIL.COM", "LUZ10@HOTMAIL.COM", "AFC4IHqi8ZMKDhNlg4+Y3NQsBjLuV7kLfAPNOdVcg/eVwz0UDaWKv/hXKlxapA7J9Q==", "05111111111", false, "a3759e67-bf18-4939-968d-5d70e1ee52e7", false, "Luz10@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "078aca27-7b6e-4a00-a105-f2b298af643d", 0, null, "d2ac482e-95ee-4308-9a60-56e971943e57", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martha.Gleason@hotmail.com", true, "Martha", "Gleason", false, null, "MARTHA.GLEASON@HOTMAIL.COM", "MARTHA.GLEASON@HOTMAIL.COM", "AG09ysGuzc7VF16+4apQlL2kWpZZC6u5nWUeZfSydbXN46gk61gKtdGYUWy7+/oRYQ==", "05111111111", false, "b5d7abbd-67a9-40ea-9f9a-4bece1f11a23", false, "Martha.Gleason@hotmail.com" },
                    { "201c205c-af77-44ab-aa08-2417da763225", 0, null, "55673e72-fb65-4f17-a409-037b271d0e08", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misty_Daugherty38@gmail.com", true, "Misty", "Daugherty", false, null, "MISTY_DAUGHERTY38@GMAIL.COM", "MISTY_DAUGHERTY38@GMAIL.COM", "AKr9oP+1SZLqnHX8IUCSYA+afQds2rMHjWvykuHcMHuGcoox0xjckk89xjC++okEJw==", "05111111111", false, "2b360179-03fe-457f-b15f-f5a999d57649", false, "Misty_Daugherty38@gmail.com" },
                    { "ccf54ccd-fe63-4bc9-9185-acf1902ca1cc", 0, null, "3c0420c9-00b1-4136-ae16-376281029160", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edward.Muller5@hotmail.com", true, "Edward", "Muller", false, null, "EDWARD.MULLER5@HOTMAIL.COM", "EDWARD.MULLER5@HOTMAIL.COM", "AJRIVjmJnBcgbHHlNXmxQM2D+kGsn7L26FTNpqmBrQEsd72yxdKjyWQoq/HY1lvMlw==", "05111111111", false, "77d3a393-0003-4f7b-a3eb-0a2cbf2839ff", false, "Edward.Muller5@hotmail.com" },
                    { "b0622e14-32bc-4fee-b2b1-89e4587224d3", 0, null, "8ea8a367-e2d8-4c54-96c5-462e5975eec0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wesley.Turner@hotmail.com", true, "Wesley", "Turner", false, null, "WESLEY.TURNER@HOTMAIL.COM", "WESLEY.TURNER@HOTMAIL.COM", "AKYuloZQVLsb6hVDlOWZzncKqg4MnkyZkRRSAmba6cD+m9MPi0Qlp3Tk50NB4j9Aow==", "05111111111", false, "eed93fb1-c6c8-4cdb-b74d-d706be78b3c4", false, "Wesley.Turner@hotmail.com" },
                    { "7e1a58cc-095b-4eac-b101-79725c59c82e", 0, null, "b006e7f2-712a-43e0-85ab-0d2f376c3b89", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stewart8@gmail.com", true, "Stewart", "Stracke", false, null, "STEWART8@GMAIL.COM", "STEWART8@GMAIL.COM", "AMmiIKooUfi1996fCSnro5NC2SuDtETwmRcMvOhL5uGbXrwIthczBehjbFpNG9ZXSA==", "05111111111", false, "f0583a45-05d4-43ff-adf3-5d0b64994391", false, "Stewart8@gmail.com" },
                    { "cedcb7ea-a87e-4b3a-82d2-09c69f6938e5", 0, null, "f7e29518-317b-4e7d-b1b4-5668fcba1afc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cornelius_Stiedemann@yahoo.com", true, "Cornelius", "Stiedemann", false, null, "CORNELIUS_STIEDEMANN@YAHOO.COM", "CORNELIUS_STIEDEMANN@YAHOO.COM", "AB0jJCBtztHjcFyq7UINdraxY/eCGDBexwxJ0zfZ8njQiQUK9BY32f+YvubcfHBy4Q==", "05111111111", false, "af139699-e068-401a-906c-fd94c594927a", false, "Cornelius_Stiedemann@yahoo.com" },
                    { "bc57a858-e461-4a86-a3a4-fc0ed69866cb", 0, null, "6b181555-0559-4e3a-9434-2fec4bfaa7e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hattie_Ankunding62@yahoo.com", true, "Hattie", "Ankunding", false, null, "HATTIE_ANKUNDING62@YAHOO.COM", "HATTIE_ANKUNDING62@YAHOO.COM", "AFlx+q2WRIPL0PrsUgYoquHIxMTC0xEdDENiCISI/GMPwuwO1cPsWom9OaDh9g/5jA==", "05111111111", false, "109f1b5e-c00d-4114-a23f-a347dc1e644f", false, "Hattie_Ankunding62@yahoo.com" },
                    { "f8e01904-94ac-47f3-b0d8-db5e6cac802d", 0, null, "7a8af029-c893-4ea1-a0bf-c845f444b67c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gilbert.Hilll81@yahoo.com", true, "Gilbert", "Hilll", false, null, "GILBERT.HILLL81@YAHOO.COM", "GILBERT.HILLL81@YAHOO.COM", "AKx1IS30sqXwmhS4+00uiFQZBs3deMQ/xOLx7azqbG9Jwp1HNqdqhQB/K7eml7C+UA==", "05111111111", false, "a0e119aa-408c-46d1-ad55-2d4c88830fff", false, "Gilbert.Hilll81@yahoo.com" },
                    { "d78f5d28-ae66-4c5a-a887-6d46a345dc50", 0, null, "4f531022-02d4-4233-aa7c-8cf1feca22ac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caroline_Bechtelar39@gmail.com", true, "Caroline", "Bechtelar", false, null, "CAROLINE_BECHTELAR39@GMAIL.COM", "CAROLINE_BECHTELAR39@GMAIL.COM", "ANIr9Bw0WgDsC2xoYciviIEuG4D+7bn881BbJSRRmqM0ai7kxEaYg4poTArv9f2jpA==", "05111111111", false, "c170565c-65b2-4b90-a83a-445cbd7398bc", false, "Caroline_Bechtelar39@gmail.com" },
                    { "5d40b661-2307-42c0-8efa-29d0c1ea00f5", 0, null, "221868b2-a35f-4b02-8372-b1d3b5890ed7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kay84@yahoo.com", true, "Kay", "Prohaska", false, null, "KAY84@YAHOO.COM", "KAY84@YAHOO.COM", "ALpA/RhHdOHAeghWMejMsReiCsY2bwoWxg+HPNMXdD4KO2lKfqHxaqj6RV2YmC7rxQ==", "05111111111", false, "494536ff-c668-4ca4-a1db-617f768e9a4a", false, "Kay84@yahoo.com" },
                    { "1e261708-b457-4b01-b4c1-cc2d2d4a520b", 0, null, "67fbba81-5c50-4c51-83d3-4578d2d233d7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rita.Rippin44@hotmail.com", true, "Rita", "Rippin", false, null, "RITA.RIPPIN44@HOTMAIL.COM", "RITA.RIPPIN44@HOTMAIL.COM", "AC/XdUbNLTdmswljpIkiL7JPeDXIzIvQi5NJZZTt7sJLdYtZe/s5ijgN7Q61WowiAg==", "05111111111", false, "56814d25-d012-4e14-99e2-bed97b28e66c", false, "Rita.Rippin44@hotmail.com" },
                    { "f74d8e99-8af3-4b4d-a947-7dd14d7eee35", 0, null, "0ac276b4-c912-410f-9cf4-c210f9e2a1da", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jennie_McKenzie@hotmail.com", true, "Jennie", "McKenzie", false, null, "JENNIE_MCKENZIE@HOTMAIL.COM", "JENNIE_MCKENZIE@HOTMAIL.COM", "ALbYSW4s4yNR258VghkoJKgqFhDmeNw/nJJ/qAPQQYxNyfN9b5rlVcryz3SCgzQRIA==", "05111111111", false, "8f108638-a9d7-4f83-a392-084b6d8376ec", false, "Jennie_McKenzie@hotmail.com" },
                    { "1d276bc6-d83d-4c99-b2cb-ac47259a6536", 0, null, "72f07701-dd74-45a9-974e-e8236849f462", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ben_Kohler38@gmail.com", true, "Ben", "Kohler", false, null, "BEN_KOHLER38@GMAIL.COM", "BEN_KOHLER38@GMAIL.COM", "ANWERFamY5DEZQZCjhHVo6pYL3O1rVSDIQwtHrMbkF4XPoKXQGv1V5L0PVdLpNZ7sg==", "05111111111", false, "22871a46-9cfa-4274-9ed8-6fd23c5be887", false, "Ben_Kohler38@gmail.com" },
                    { "e4dbe198-d5a0-4688-a301-4d7fc1172034", 0, null, "51284e77-0d01-4b42-8d40-f4a6f2b06b7d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil.Haag@yahoo.com", true, "Virgil", "Haag", false, null, "VIRGIL.HAAG@YAHOO.COM", "VIRGIL.HAAG@YAHOO.COM", "ABYbSw/KA1AduH4iCSkLC+gKpDmxPHwTxgdE1FalPOTZQIExhX3g8Xgf8hWx+vEAew==", "05111111111", false, "0e4ba693-5d7b-4eeb-ab16-a5ab6db6affd", false, "Virgil.Haag@yahoo.com" },
                    { "d38ae425-80d4-4884-9cc6-661bec7c5992", 0, null, "24c6cd17-896b-4782-b5cf-f98c9bc0dbbb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clint_Braun73@gmail.com", true, "Clint", "Braun", false, null, "CLINT_BRAUN73@GMAIL.COM", "CLINT_BRAUN73@GMAIL.COM", "AG0A25GUIA1zz8+UUy7apdUsmJwoBAqXmTA3M2VKeTtTX6W1aYsfY9P0dkV+tqLcZw==", "05111111111", false, "e751189d-09b1-46cd-9342-0f0e8902e304", false, "Clint_Braun73@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedDate", "Email", "Facebook", "Fax", "Instagram", "ModifiedDate", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "47950 Bailey Court, Dayanaport, Albania", null, "Jessica.Zieme85@gmail.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreatedDate", "DepartmentName", "Description", "ModifiedDate" },
                values: new object[,]
                {
                    { 2, null, "Bilgi İşlem", null, null },
                    { 1, null, "Yardımcı Hizmetler", null, null },
                    { 3, null, "Mutfak", null, null },
                    { 4, null, "Resepsiyon", null, null },
                    { 5, null, "Yönetim", null, null },
                    { 6, null, "İnsan Kaynakları", null, null }
                });

            migrationBuilder.InsertData(
                table: "ExtraServices",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Price", "ServiceName" },
                values: new object[,]
                {
                    { 1, null, null, 600m, "Sauna" },
                    { 2, null, null, 400m, "Hamam" }
                });

            migrationBuilder.InsertData(
                table: "HomePages",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Paragraph1", "Paragraph2", "Paragraph3", "Paragraph4", "Paragraph5", "PictureUrl", "Subtitle", "Title" },
                values: new object[] { 1, null, null, "Bilge Hotel Thermal Spa & Convention Center; Kemer şehir merkezinde, güler yüzlü ve profesyonel ekibi ile beklentilerin üzerinde hizmet vermektedir.", "Bilge Hotel 35 yıllık deneyimi, misafir memnuniyeti odaklı hizmet anlayışı ile sizleri kaliteye ve konfora davet ediyor.", null, null, null, "/img/homepage-img.jpg", "Bilge Hotel'e Hoşgeldiniz...", "Kalite ve Konfor" });

            migrationBuilder.InsertData(
                table: "HotelServices",
                columns: new[] { "ID", "CreatedDate", "Description", "IconPicture", "ModifiedDate", "ServiceName" },
                values: new object[,]
                {
                    { 1, null, null, "https://roof264.com/media/image/mobil/oda-servisi.jpg", null, "Oda Servisi" },
                    { 15, null, null, "https://roof264.com/media/image/mobil/cay-kahve-hizmeti.jpg", null, "Çay - Kahve Hizmeti" },
                    { 14, null, null, "https://roof264.com/media/image/mobil/utu-hizmeti.jpg", null, "Ütü Hizmeti" },
                    { 2, null, null, "https://roof264.com/media/image/mobil/ucretsiz-wi-fi.jpg", null, "Ücretsiz Wifi" },
                    { 12, null, null, "https://roof264.com/media/image/mobil/merkezi-konum.jpg", null, "Merkezi Konum" },
                    { 13, null, null, "https://roof264.com/media/image/mobil/ucretsiz-acik-kapali-otopark.jpg", null, "Ücretsiz Açık / Kapalı Otopark" },
                    { 7, null, null, "https://roof264.com/media/image/mobil/hizli-c-in-c-out.jpg", null, "Hızlı C in / C out" },
                    { 6, null, null, "https://roof264.com/media/image/mobil/bagaj-depolama.jpg", null, "Bagaj Depolama" },
                    { 5, null, null, "https://roof264.com/media/image/mobil/toplanti-olanaklari-max-10.jpg", null, "Toplantı Olanakları" },
                    { 4, null, null, "https://roof264.com/media/image/mobil/oda-ici-kasa.jpg", null, "Kasa" },
                    { 3, null, null, "https://roof264.com/media/image/mobil/camasir-yikama.jpg", null, "Çamaşır Yıkama" },
                    { 8, null, null, "https://roof264.com/media/image/mobil/kuru-temizleme.jpg", null, "Kuru Temizleme" },
                    { 10, null, null, "https://roof264.com/media/image/mobil/aile-odasi.jpg", null, "Aile Odası" },
                    { 11, null, null, "https://roof264.com/media/image/mobil/sicak-kahvalti.jpg", null, "Sıcak Kahvaltı" },
                    { 9, null, null, "https://roof264.com/media/image/mobil/bebek-karyolasi.jpg", null, "Bebek Karyolası" }
                });

            migrationBuilder.InsertData(
                table: "RoomFacilities",
                columns: new[] { "ID", "CreatedDate", "Description", "FacilityName", "ModifiedDate" },
                values: new object[,]
                {
                    { 5, null, null, "Minibar", null },
                    { 4, null, null, "Kablosuz Internet", null }
                });

            migrationBuilder.InsertData(
                table: "RoomFacilities",
                columns: new[] { "ID", "CreatedDate", "Description", "FacilityName", "ModifiedDate" },
                values: new object[,]
                {
                    { 3, null, null, "Saç Kurutma Makinesi", null },
                    { 2, null, null, "Tv", null },
                    { 1, null, null, "Klima", null },
                    { 6, null, null, "Balkon", null }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "ID", "CreatedDate", "Description", "ModifiedDate", "NumberOfBed", "NumberOfPeople", "Price", "RoomTypeName" },
                values: new object[,]
                {
                    { 7, null, "Yatak odası, yemek yeme alanına sahip oturma salonu ve iki ayrı banyosuyla 85 m² olan geniş kullanım alanı, şehir ve dağ manzarası ile konforu sunuyor.Rahatlamak ve keyif almak için özel olarak tasarlanan jakuzili banyoda ruhunuzu ve bedeninizi dinlendirebilir, gününüzü keyifle noktalayabilirsiniz.", null, 1, 2, 2500m, "Presidential Suite" },
                    { 6, null, "30 - 35 m² Family Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet çift kişilik, iki adet tek kişilik yatak bulunmaktadır.", null, 3, 4, 1900m, "Family Room" },
                    { 5, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet tek kişilik, bir adet iki kişilik yatak bulunmaktadır.", null, 2, 3, 1500m, "Triple Superior Room" },
                    { 4, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda üç adet tek kişilik yatak bulunmaktadır.", null, 3, 3, 1500m, "Triple Room" },
                    { 3, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda iki kişilik bir adet yatak bulunmaktadır.", null, 1, 2, 1050m, "Double Superior Room" },
                    { 2, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik iki adet yatak bulunmaktadır.", null, 2, 2, 1050m, "Double Room" },
                    { 1, null, "15 - 20 m² Single Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik bir adet yatak bulunmaktadır.", null, 1, 1, 600m, "Single Room" }
                });

            migrationBuilder.InsertData(
                table: "ServicePacks",
                columns: new[] { "ID", "CreatedDate", "Description", "ModifiedDate", "PackName", "PackPrice" },
                values: new object[,]
                {
                    { 2, null, "Bu pakette konaklama süresince 3 öğün yemekler, 5 çayı ve atıştırmalıklarla gün boyunca içecekler (alkolsüz içeceklerle - yerli alkollü içecekler) konaklama ücretine dahildir. Otellerdeki aktiviteler bu konseptte dahil değildir.", null, "Her Şey Dahil", 500m },
                    { 1, null, "Bu pakette sabah kahvaltısı, öğle yemeği ve akşam yemekleri konaklama ücretine dahildir.", null, "Tam Pansiyon", 200m }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "SmtpEmail", "SmtpHost", "SmtpPassword", "SmtpPort" },
                values: new object[] { 1, null, null, "the.mstfa@gmail.com", "smtp.gmail.com", "Mustafa.2525774", 587 });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "ID", "CreatedDate", "Description", "EndTime", "ModifiedDate", "ShiftName", "StartTime" },
                values: new object[,]
                {
                    { 1, null, null, new TimeSpan(0, 16, 0, 0, 0), null, "Gündüz", new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, null, null, new TimeSpan(0, 0, 0, 0, 0), null, "Akşam", new TimeSpan(0, 16, 0, 0, 0) },
                    { 3, null, null, new TimeSpan(0, 8, 0, 0, 0), null, "Gece", new TimeSpan(0, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "cbd6ca5e-672b-4244-93f0-92e85d0e48d4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5d40b661-2307-42c0-8efa-29d0c1ea00f5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1e261708-b457-4b01-b4c1-cc2d2d4a520b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f74d8e99-8af3-4b4d-a947-7dd14d7eee35" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1d276bc6-d83d-4c99-b2cb-ac47259a6536" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ccf54ccd-fe63-4bc9-9185-acf1902ca1cc" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "89bb616f-5d85-4ffd-b372-e0e0ed7bcbf4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "04424223-c870-4a90-9c76-1fe4788041f7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "507e0bf1-a9b8-4621-b43e-428b5d1b4e3d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "59b0a516-dc46-4296-b099-f6fb98b82325" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "23c9dc4d-dbc0-453e-8c75-fa2c106bc948" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9d834ef1-80bb-4461-bac3-309b1d63e329" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "545e20b2-a909-4949-bd52-a90770b47452" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "be4f444f-5371-444c-a361-60a8f77c872b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "13fb1c19-74b3-41c8-9228-93186c262f87" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ea1676eb-0861-411a-85e9-a489bfc40a38" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "fa5fd19b-46e4-4ad5-b61c-c7550a3921ba" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6750220c-db37-41ac-abc2-ba89db5e34df" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5c307b3f-3706-43cc-9b5c-1112191cfad8" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "496b7fc0-0129-4f90-8a63-f3e3b8271f43" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d78f5d28-ae66-4c5a-a887-6d46a345dc50" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "4f7ce9a5-6295-4cbb-8f7e-b39ccd7d2601" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f8e01904-94ac-47f3-b0d8-db5e6cac802d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "cedcb7ea-a87e-4b3a-82d2-09c69f6938e5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4f7ce9a5-6295-4cbb-8f7e-b39ccd7d2601" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6251bfd1-6a86-468e-b521-d2bd5bd1fab1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "69c199e2-4d83-424c-a63d-43c48e347d81" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "23325d5c-376d-43a0-a56a-9640344d2add" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "96ede2c4-7c30-4ae6-9269-c6d921062bf9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d38ae425-80d4-4884-9cc6-661bec7c5992" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "504039e4-19af-4539-a87b-8c228f3fe7b6" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "9e1d18ea-f2a2-43d3-8166-5abf46f868b1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7285fc22-3947-4259-9d7b-2ce5fd47fdea" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4a0a01c7-e573-4d15-b581-52dfb20a9e72" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e27fc89c-3f88-4084-8fcb-450602c4bfa9" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "73543b77-c9ba-49af-b8f6-94f3942a6299" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bf72edbd-72c0-48d8-8e95-30dc2d5ec54a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f98d197a-8641-4e97-963b-1931ce645a72" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4e57de01-388c-454a-9b91-120559cf3d83" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "09b6d160-f680-4cef-ba42-fa02e7f674f0" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "078aca27-7b6e-4a00-a105-f2b298af643d" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "201c205c-af77-44ab-aa08-2417da763225" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b0622e14-32bc-4fee-b2b1-89e4587224d3" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "e4dbe198-d5a0-4688-a301-4d7fc1172034" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7e1a58cc-095b-4eac-b101-79725c59c82e" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bc57a858-e461-4a86-a3a4-fc0ed69866cb" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "6251bfd1-6a86-468e-b521-d2bd5bd1fab1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "49c33160-ee6e-4dbe-8c77-56d8fedb6865" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "23325d5c-376d-43a0-a56a-9640344d2add" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bc57a858-e461-4a86-a3a4-fc0ed69866cb" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f8e01904-94ac-47f3-b0d8-db5e6cac802d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "d78f5d28-ae66-4c5a-a887-6d46a345dc50" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "5d40b661-2307-42c0-8efa-29d0c1ea00f5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "1e261708-b457-4b01-b4c1-cc2d2d4a520b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "f74d8e99-8af3-4b4d-a947-7dd14d7eee35" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "1d276bc6-d83d-4c99-b2cb-ac47259a6536" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "49c33160-ee6e-4dbe-8c77-56d8fedb6865" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ccf54ccd-fe63-4bc9-9185-acf1902ca1cc" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "89bb616f-5d85-4ffd-b372-e0e0ed7bcbf4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "cedcb7ea-a87e-4b3a-82d2-09c69f6938e5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "04424223-c870-4a90-9c76-1fe4788041f7" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "59b0a516-dc46-4296-b099-f6fb98b82325" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "23c9dc4d-dbc0-453e-8c75-fa2c106bc948" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "9d834ef1-80bb-4461-bac3-309b1d63e329" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "545e20b2-a909-4949-bd52-a90770b47452" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "be4f444f-5371-444c-a361-60a8f77c872b" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "69c199e2-4d83-424c-a63d-43c48e347d81" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ea1676eb-0861-411a-85e9-a489bfc40a38" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "fa5fd19b-46e4-4ad5-b61c-c7550a3921ba" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "507e0bf1-a9b8-4621-b43e-428b5d1b4e3d" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7e1a58cc-095b-4eac-b101-79725c59c82e" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "13fb1c19-74b3-41c8-9228-93186c262f87" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b0622e14-32bc-4fee-b2b1-89e4587224d3" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "e4dbe198-d5a0-4688-a301-4d7fc1172034" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "96ede2c4-7c30-4ae6-9269-c6d921062bf9" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "d38ae425-80d4-4884-9cc6-661bec7c5992" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "504039e4-19af-4539-a87b-8c228f3fe7b6" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "496b7fc0-0129-4f90-8a63-f3e3b8271f43" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "9e1d18ea-f2a2-43d3-8166-5abf46f868b1" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "7285fc22-3947-4259-9d7b-2ce5fd47fdea" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "4a0a01c7-e573-4d15-b581-52dfb20a9e72" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "e27fc89c-3f88-4084-8fcb-450602c4bfa9" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "496b7fc0-0129-4f90-8a63-f3e3b8271f43" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "bf72edbd-72c0-48d8-8e95-30dc2d5ec54a" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "73543b77-c9ba-49af-b8f6-94f3942a6299" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "5c307b3f-3706-43cc-9b5c-1112191cfad8" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "6750220c-db37-41ac-abc2-ba89db5e34df" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "201c205c-af77-44ab-aa08-2417da763225" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "c2779518-1f30-4806-a8b7-471e97509137" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "09b6d160-f680-4cef-ba42-fa02e7f674f0" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "4e57de01-388c-454a-9b91-120559cf3d83" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "f98d197a-8641-4e97-963b-1931ce645a72" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "078aca27-7b6e-4a00-a105-f2b298af643d" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "c2779518-1f30-4806-a8b7-471e97509137" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedDate", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedDate", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "5c307b3f-3706-43cc-9b5c-1112191cfad8", null, 2, "Bertha70@yahoo.com", 3, "Bertha", 23.882716979776840m, "6936", true, "Rosenbaum", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 4, 14, 45, 48, 64, DateTimeKind.Unspecified).AddTicks(1901), "Bilgi İşlem Sorumlusu" },
                    { 32, "89bb616f-5d85-4ffd-b372-e0e0ed7bcbf4", null, 3, "Camille_Stracke56@yahoo.com", 3, "Camille", 28.328110844980980m, "4822", true, "Stracke", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 10, 27, 16, 39, 21, 346, DateTimeKind.Unspecified).AddTicks(7903), "Garson" },
                    { 43, "6750220c-db37-41ac-abc2-ba89db5e34df", null, 1, "Preston.Hyatt27@hotmail.com", 3, "Preston", 23.95162986775470m, "3337", true, "Hyatt", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 21, 3, 18, 6, 264, DateTimeKind.Unspecified).AddTicks(9222), "Elektirikçi" },
                    { 36, "23c9dc4d-dbc0-453e-8c75-fa2c106bc948", null, 3, "Nicole.Mosciski@yahoo.com", 3, "Nicole", 20.9169192290478010m, "1765", true, "Mosciski", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 4, 5, 22, 30, 46, 448, DateTimeKind.Unspecified).AddTicks(3448), "Garson" },
                    { 35, "59b0a516-dc46-4296-b099-f6fb98b82325", null, 3, "Vickie_Schaefer@hotmail.com", 3, "Vickie", 28.858398072821270m, "6233", true, "Schaefer", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 9, 4, 20, 58, 0, 898, DateTimeKind.Unspecified).AddTicks(263), "Garson" },
                    { 34, "507e0bf1-a9b8-4621-b43e-428b5d1b4e3d", null, 3, "Willie_Hudson74@yahoo.com", 3, "Willie", 25.191390554044110m, "3335", true, "Hudson", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 4, 3, 14, 8, 2, 364, DateTimeKind.Unspecified).AddTicks(2550), "Garson" },
                    { 33, "04424223-c870-4a90-9c76-1fe4788041f7", null, 3, "Brenda_Graham@yahoo.com", 3, "Brenda", 29.064142158750510m, "8474", true, "Graham", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 28, 3, 40, 33, 808, DateTimeKind.Unspecified).AddTicks(3975), "Garson" },
                    { 23, "bc57a858-e461-4a86-a3a4-fc0ed69866cb", null, 3, "Hattie_Ankunding62@yahoo.com", 3, "Hattie", 29.907255805985660m, "9820", true, "Ankunding", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 6, 15, 19, 0, 49, 123, DateTimeKind.Unspecified).AddTicks(9472), "Aşçı" },
                    { 30, "49c33160-ee6e-4dbe-8c77-56d8fedb6865", null, 3, "Earnest_Mitchell22@yahoo.com", 3, "Earnest", 25.745486941070060m, "4020", true, "Mitchell", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 8, 13, 23, 17, 25, 202, DateTimeKind.Unspecified).AddTicks(4115), "Garson" },
                    { 24, "f8e01904-94ac-47f3-b0d8-db5e6cac802d", null, 3, "Gilbert.Hilll81@yahoo.com", 3, "Gilbert", 21.86750333377510m, "5636", true, "Hilll", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 1, 8, 15, 31, 38, 186, DateTimeKind.Unspecified).AddTicks(6215), "Aşçı" },
                    { 45, "c2779518-1f30-4806-a8b7-471e97509137", null, 5, "Francisco.Boyer@yahoo.com", 0, "Francisco", 23.453677042133020m, "1767", true, "Boyer", null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2020, 5, 15, 7, 10, 26, 632, DateTimeKind.Unspecified).AddTicks(2275), "Müdür" },
                    { 22, "cedcb7ea-a87e-4b3a-82d2-09c69f6938e5", null, 3, "Cornelius_Stiedemann@yahoo.com", 3, "Cornelius", 21.51650515455590m, "2362", true, "Stiedemann", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 27, 8, 12, 30, 375, DateTimeKind.Unspecified).AddTicks(4220), "Aşçı" },
                    { 21, "7e1a58cc-095b-4eac-b101-79725c59c82e", null, 3, "Stewart8@gmail.com", 3, "Stewart", 26.279374103191950m, "5262", true, "Stracke", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 6, 22, 3, 45, 51, 138, DateTimeKind.Unspecified).AddTicks(1980), "Aşçı" },
                    { 20, "e4dbe198-d5a0-4688-a301-4d7fc1172034", null, 3, "Virgil.Haag@yahoo.com", 3, "Virgil", 20.3611329013300750m, "5482", true, "Haag", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 11, 15, 5, 5, 52, 389, DateTimeKind.Unspecified).AddTicks(2425), "Aşçı" },
                    { 19, "b0622e14-32bc-4fee-b2b1-89e4587224d3", null, 3, "Wesley.Turner@hotmail.com", 3, "Wesley", 21.064824867558120m, "5403", true, "Turner", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 3, 28, 20, 37, 21, 325, DateTimeKind.Unspecified).AddTicks(481), "Aşçı" },
                    { 13, "bf72edbd-72c0-48d8-8e95-30dc2d5ec54a", null, 1, "Rosie93@hotmail.com", 3, "Rosie", 22.454976147252590m, "7054", true, "Lakin", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 6, 1, 22, 54, 30, 847, DateTimeKind.Unspecified).AddTicks(5276), "Temizlik Görevlisi" },
                    { 31, "ccf54ccd-fe63-4bc9-9185-acf1902ca1cc", null, 3, "Edward.Muller5@hotmail.com", 3, "Edward", 28.905358164992820m, "7502", true, "Muller", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 4, 8, 5, 15, 2, 991, DateTimeKind.Unspecified).AddTicks(6758), "Garson" },
                    { 46, "496b7fc0-0129-4f90-8a63-f3e3b8271f43", null, 6, "Erica16@hotmail.com", 1, "Erica", 20.0686148461273940m, "5993", true, "Murray", null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2019, 6, 20, 3, 33, 34, 64, DateTimeKind.Unspecified).AddTicks(5794), "İnsan Kaynakları Müdürü" },
                    { 17, "078aca27-7b6e-4a00-a105-f2b298af643d", null, 1, "Martha.Gleason@hotmail.com", 3, "Martha", 28.159166261627880m, "8024", true, "Gleason", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 1, 26, 17, 40, 16, 675, DateTimeKind.Unspecified).AddTicks(6790), "Temizlik Görevlisi" },
                    { 5, "96ede2c4-7c30-4ae6-9269-c6d921062bf9", null, 4, "Myra4@hotmail.com", 3, "Myra", 27.915634465364570m, "2343", true, "Watsica", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 8, 28, 2, 46, 16, 312, DateTimeKind.Unspecified).AddTicks(9347), "Resepsiyonist" },
                    { 12, "73543b77-c9ba-49af-b8f6-94f3942a6299", null, 1, "Lela_Buckridge@yahoo.com", 3, "Lela", 24.03381821887280m, "3626", true, "Buckridge", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 11, 3, 2, 4, 59, 412, DateTimeKind.Unspecified).AddTicks(5311), "Temizlik Görevlisi" },
                    { 7, "504039e4-19af-4539-a87b-8c228f3fe7b6", null, 4, "Dale_DAmore66@gmail.com", 3, "Dale", 25.809468243182390m, "6938", true, "D'Amore", null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2021, 9, 14, 2, 57, 40, 474, DateTimeKind.Unspecified).AddTicks(752), "Resepsiyonist" },
                    { 6, "d38ae425-80d4-4884-9cc6-661bec7c5992", null, 4, "Clint_Braun73@gmail.com", 3, "Clint", 29.175872997928350m, "4717", true, "Braun", null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2019, 9, 27, 21, 38, 57, 231, DateTimeKind.Unspecified).AddTicks(4628), "Resepsiyonist" },
                    { 42, "fa5fd19b-46e4-4ad5-b61c-c7550a3921ba", null, 3, "Craig.Murazik@gmail.com", 3, "Craig", 21.194186565090990m, "4352", true, "Murazik", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 5, 7, 11, 22, 0, 123, DateTimeKind.Unspecified).AddTicks(3654), "Garson" },
                    { 41, "ea1676eb-0861-411a-85e9-a489bfc40a38", null, 3, "Victoria26@gmail.com", 3, "Victoria", 23.91543599959250m, "9187", true, "Howell", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 1, 3, 10, 21, 52, 56, DateTimeKind.Unspecified).AddTicks(5730), "Garson" },
                    { 40, "13fb1c19-74b3-41c8-9228-93186c262f87", null, 3, "Perry.Denesik@hotmail.com", 3, "Perry", 24.031598555870170m, "4458", true, "Denesik", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 3, 18, 15, 5, 0, 945, DateTimeKind.Unspecified).AddTicks(828), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedDate", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedDate", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "be4f444f-5371-444c-a361-60a8f77c872b", null, 3, "Phillip86@hotmail.com", 3, "Phillip", 27.869371482110290m, "7293", true, "Kautzer", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 2, 3, 1, 14, 51, 600, DateTimeKind.Unspecified).AddTicks(4830), "Garson" },
                    { 38, "545e20b2-a909-4949-bd52-a90770b47452", null, 3, "Aaron_McGlynn64@yahoo.com", 3, "Aaron", 21.654550517748370m, "2081", true, "McGlynn", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 9, 6, 7, 50, 10, 924, DateTimeKind.Unspecified).AddTicks(8113), "Garson" },
                    { 37, "9d834ef1-80bb-4461-bac3-309b1d63e329", null, 3, "Darnell83@gmail.com", 3, "Darnell", 27.549330041533960m, "3994", true, "Waelchi", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 10, 20, 15, 59, 13, 121, DateTimeKind.Unspecified).AddTicks(9677), "Garson" },
                    { 28, "f74d8e99-8af3-4b4d-a947-7dd14d7eee35", null, 3, "Jennie_McKenzie@hotmail.com", 3, "Jennie", 25.527832641046420m, "7593", true, "McKenzie", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 12, 28, 0, 22, 30, 719, DateTimeKind.Unspecified).AddTicks(5669), "Aşçı" },
                    { 27, "1e261708-b457-4b01-b4c1-cc2d2d4a520b", null, 3, "Rita.Rippin44@hotmail.com", 3, "Rita", 25.016473762233030m, "7585", true, "Rippin", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 6, 17, 0, 6, 29, 617, DateTimeKind.Unspecified).AddTicks(7349), "Aşçı" },
                    { 26, "5d40b661-2307-42c0-8efa-29d0c1ea00f5", null, 3, "Kay84@yahoo.com", 3, "Kay", 25.732072650330180m, "6418", true, "Prohaska", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 26, 17, 41, 45, 458, DateTimeKind.Unspecified).AddTicks(2404), "Aşçı" },
                    { 25, "d78f5d28-ae66-4c5a-a887-6d46a345dc50", null, 3, "Caroline_Bechtelar39@gmail.com", 3, "Caroline", 20.0002790801228392310m, "3708", true, "Bechtelar", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 12, 8, 10, 42, 52, 381, DateTimeKind.Unspecified).AddTicks(2410), "Aşçı" },
                    { 18, "201c205c-af77-44ab-aa08-2417da763225", null, 1, "Misty_Daugherty38@gmail.com", 3, "Misty", 22.229061025301490m, "7569", true, "Daugherty", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 11, 27, 12, 33, 18, 966, DateTimeKind.Unspecified).AddTicks(1982), "Temizlik Görevlisi" },
                    { 16, "09b6d160-f680-4cef-ba42-fa02e7f674f0", null, 1, "Luz10@hotmail.com", 3, "Luz", 20.913775642827980m, "9891", true, "VonRueden", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 6, 21, 9, 3, 37, 135, DateTimeKind.Unspecified).AddTicks(9066), "Temizlik Görevlisi" },
                    { 15, "4e57de01-388c-454a-9b91-120559cf3d83", null, 1, "Rosa94@yahoo.com", 3, "Rosa", 27.797159602771120m, "9121", true, "Grant", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 4, 18, 16, 52, 12, 850, DateTimeKind.Unspecified).AddTicks(190), "Temizlik Görevlisi" },
                    { 14, "f98d197a-8641-4e97-963b-1931ce645a72", null, 1, "Cora_Waters12@gmail.com", 3, "Cora", 21.588149695465410m, "8787", true, "Waters", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 1, 10, 7, 49, 50, 246, DateTimeKind.Unspecified).AddTicks(2945), "Temizlik Görevlisi" },
                    { 4, "23325d5c-376d-43a0-a56a-9640344d2add", null, 4, "Ginger_Braun59@gmail.com", 3, "Ginger", 26.528175355181180m, "1680", true, "Braun", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 5, 3, 8, 23, 1, 347, DateTimeKind.Unspecified).AddTicks(9957), "Resepsiyonist" },
                    { 29, "1d276bc6-d83d-4c99-b2cb-ac47259a6536", null, 3, "Ben_Kohler38@gmail.com", 3, "Ben", 29.701043753745520m, "8155", true, "Kohler", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 7, 28, 23, 52, 17, 677, DateTimeKind.Unspecified).AddTicks(4424), "Aşçı" },
                    { 11, "e27fc89c-3f88-4084-8fcb-450602c4bfa9", null, 1, "Connie_Emard74@hotmail.com", 3, "Connie", 21.50015050149530m, "7512", true, "Emard", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 1, 30, 15, 10, 43, 771, DateTimeKind.Unspecified).AddTicks(3947), "Temizlik Görevlisi" },
                    { 9, "7285fc22-3947-4259-9d7b-2ce5fd47fdea", null, 1, "Elmer32@hotmail.com", 3, "Elmer", 22.883416681030490m, "1634", true, "Ryan", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 5, 16, 4, 9, 15, 52, DateTimeKind.Unspecified).AddTicks(1655), "Temizlik Görevlisi" },
                    { 8, "9e1d18ea-f2a2-43d3-8166-5abf46f868b1", null, 1, "Kendra.Larson68@yahoo.com", 3, "Kendra", 28.636739020532340m, "5501", true, "Larson", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 2, 16, 11, 43, 6, 618, DateTimeKind.Unspecified).AddTicks(9533), "Temizlik Görevlisi" },
                    { 3, "69c199e2-4d83-424c-a63d-43c48e347d81", null, 4, "Pat.Miller27@gmail.com", 3, "Pat", 21.449939888645870m, "2805", true, "Miller", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 9, 16, 21, 5, 1, 688, DateTimeKind.Unspecified).AddTicks(995), "Resepsiyonist" },
                    { 2, "6251bfd1-6a86-468e-b521-d2bd5bd1fab1", null, 4, "Eddie14@yahoo.com", 3, "Eddie", 23.755418180374160m, "9193", true, "Christiansen", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 6, 27, 12, 54, 44, 131, DateTimeKind.Unspecified).AddTicks(541), "Resepsiyonist" },
                    { 1, "4f7ce9a5-6295-4cbb-8f7e-b39ccd7d2601", null, 4, "Jeremy.Cassin4@yahoo.com", 3, "Jeremy", 29.447189727540680m, "4657", true, "Cassin", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 11, 17, 12, 48, 19, 617, DateTimeKind.Unspecified).AddTicks(3176), "Resepsiyonist" },
                    { 10, "4a0a01c7-e573-4d15-b581-52dfb20a9e72", null, 1, "Veronica.Nitzsche76@yahoo.com", 3, "Veronica", 25.060012571075940m, "5054", true, "Nitzsche", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 11, 1, 1, 42, 0, 192, DateTimeKind.Unspecified).AddTicks(9364), "Temizlik Görevlisi" }
                });

            migrationBuilder.InsertData(
                table: "FacilitiesOfRooms",
                columns: new[] { "RoomFacilityID", "RoomTypeID", "CreatedDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 2, null, null },
                    { 2, 2, null, null },
                    { 3, 2, null, null },
                    { 4, 2, null, null },
                    { 5, 2, null, null },
                    { 1, 3, null, null },
                    { 2, 3, null, null },
                    { 6, 5, null, null },
                    { 5, 5, null, null },
                    { 4, 5, null, null },
                    { 1, 5, null, null },
                    { 2, 5, null, null },
                    { 4, 1, null, null },
                    { 3, 3, null, null },
                    { 4, 3, null, null },
                    { 5, 3, null, null },
                    { 6, 3, null, null },
                    { 1, 4, null, null },
                    { 2, 4, null, null },
                    { 3, 4, null, null },
                    { 3, 5, null, null },
                    { 3, 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "FacilitiesOfRooms",
                columns: new[] { "RoomFacilityID", "RoomTypeID", "CreatedDate", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, null, null },
                    { 4, 4, null, null },
                    { 6, 7, null, null },
                    { 5, 7, null, null },
                    { 4, 7, null, null },
                    { 3, 7, null, null },
                    { 2, 7, null, null },
                    { 1, 7, null, null },
                    { 2, 1, null, null },
                    { 5, 4, null, null },
                    { 6, 6, null, null },
                    { 5, 6, null, null },
                    { 4, 6, null, null },
                    { 3, 6, null, null },
                    { 2, 6, null, null },
                    { 1, 6, null, null }
                });

            migrationBuilder.InsertData(
                table: "HomePageSlides",
                columns: new[] { "ID", "CreatedDate", "HomePageID", "ModifiedDate", "PictureName", "PictureUrl" },
                values: new object[,]
                {
                    { 1, null, 1, null, "Slide1", "https://www.almira.com.tr/images/genel1.jpg" },
                    { 3, null, 1, null, "Slide3", "https://www.almira.com.tr/images/gallery/almira/07.jpg" },
                    { 2, null, 1, null, "Slide2", "https://www.almira.com.tr/images/gallery/almira/04.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "ID", "AboutusID", "CreatedDate", "ModifiedDate", "PictureName", "PictureUrl" },
                values: new object[,]
                {
                    { 7, 1, null, null, "Görsel7", "/img/gallery/room-presidential-suite.jpg" },
                    { 5, 1, null, null, "Görsel5", "/img/gallery/room-triple-superrior.jpg" },
                    { 4, 1, null, null, "Görsel4", "/img/gallery/room-triple.jpg" },
                    { 3, 1, null, null, "Görsel3", "/img/gallery/room-double-superrior.jpg" },
                    { 2, 1, null, null, "Görsel2", "/img/gallery/room-double.jpg" },
                    { 6, 1, null, null, "Görsel6", "/img/gallery/room-family.jpg" },
                    { 1, 1, null, null, "Görsel1", "/img/gallery/room-single.jpg" }
                });

            migrationBuilder.InsertData(
                table: "RoomPictures",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "PictureUrl", "RoomTypeID" },
                values: new object[,]
                {
                    { 5, null, null, "/img/roomtypes/room-triple-superrior.jpg", 5 },
                    { 7, null, null, "/img/roomtypes/room-presidential-suite.jpg", 7 },
                    { 6, null, null, "/img/roomtypes/room-family.jpg", 6 },
                    { 3, null, null, "/img/roomtypes/room-double-superrior.jpg", 3 },
                    { 1, null, null, "/img/roomtypes/room-single.jpg", 1 },
                    { 4, null, null, "/img/roomtypes/room-triple.jpg", 4 },
                    { 2, null, null, "/img/roomtypes/room-double.jpg", 2 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedDate", "Description", "FloorNumber", "ModifiedDate", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 21, null, null, 2, null, "120", 5, 1 },
                    { 22, null, null, 2, null, "121", 5, 1 },
                    { 23, null, null, 2, null, "122", 5, 1 },
                    { 24, null, null, 2, null, "123", 5, 1 },
                    { 25, null, null, 2, null, "124", 5, 1 },
                    { 26, null, null, 2, null, "125", 5, 1 },
                    { 12, null, null, 1, null, "111", 5, 4 },
                    { 10, null, null, 1, null, "109", 5, 1 },
                    { 28, null, null, 2, null, "127", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedDate", "Description", "FloorNumber", "ModifiedDate", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 29, null, null, 2, null, "128", 5, 1 },
                    { 30, null, null, 2, null, "129", 5, 1 },
                    { 57, null, null, 3, null, "156", 5, 5 },
                    { 56, null, null, 3, null, "155", 5, 5 },
                    { 55, null, null, 3, null, "154", 5, 5 },
                    { 27, null, null, 2, null, "126", 5, 1 },
                    { 9, null, null, 1, null, "108", 5, 1 },
                    { 7, null, null, 1, null, "106", 5, 1 },
                    { 54, null, null, 3, null, "153", 5, 5 },
                    { 77, null, null, 4, null, "176", 5, 7 },
                    { 76, null, null, 4, null, "175", 5, 6 },
                    { 75, null, null, 4, null, "174", 5, 6 },
                    { 74, null, null, 4, null, "173", 5, 6 },
                    { 73, null, null, 4, null, "172", 5, 6 },
                    { 72, null, null, 4, null, "171", 5, 6 },
                    { 71, null, null, 4, null, "170", 5, 6 },
                    { 8, null, null, 1, null, "107", 5, 1 },
                    { 60, null, null, 3, null, "159", 5, 5 },
                    { 58, null, null, 3, null, "157", 5, 5 },
                    { 1, null, null, 1, null, "100", 5, 1 },
                    { 2, null, null, 1, null, "101", 5, 1 },
                    { 3, null, null, 1, null, "102", 5, 1 },
                    { 4, null, null, 1, null, "103", 5, 1 },
                    { 5, null, null, 1, null, "104", 5, 1 },
                    { 6, null, null, 1, null, "105", 5, 1 },
                    { 59, null, null, 3, null, "158", 5, 5 },
                    { 53, null, null, 3, null, "152", 5, 5 },
                    { 32, null, null, 2, null, "131", 5, 2 },
                    { 11, null, null, 1, null, "110", 5, 4 },
                    { 49, null, null, 3, null, "148", 5, 3 },
                    { 50, null, null, 3, null, "149", 5, 3 },
                    { 61, null, null, 4, null, "160", 5, 3 },
                    { 17, null, null, 1, null, "116", 5, 4 },
                    { 63, null, null, 4, null, "162", 5, 3 },
                    { 64, null, null, 4, null, "163", 5, 3 },
                    { 65, null, null, 4, null, "164", 5, 3 },
                    { 48, null, null, 3, null, "147", 5, 3 },
                    { 66, null, null, 4, null, "165", 5, 3 },
                    { 68, null, null, 4, null, "167", 5, 3 },
                    { 69, null, null, 4, null, "168", 5, 3 },
                    { 70, null, null, 4, null, "169", 5, 3 },
                    { 16, null, null, 1, null, "115", 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedDate", "Description", "FloorNumber", "ModifiedDate", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 15, null, null, 1, null, "114", 5, 4 },
                    { 14, null, null, 1, null, "113", 5, 4 },
                    { 13, null, null, 1, null, "112", 5, 4 },
                    { 67, null, null, 4, null, "166", 5, 3 },
                    { 47, null, null, 3, null, "146", 5, 3 },
                    { 46, null, null, 3, null, "145", 5, 3 },
                    { 45, null, null, 3, null, "144", 5, 3 },
                    { 33, null, null, 2, null, "132", 5, 2 },
                    { 34, null, null, 2, null, "133", 5, 2 },
                    { 35, null, null, 2, null, "134", 5, 2 },
                    { 36, null, null, 2, null, "135", 5, 2 },
                    { 37, null, null, 2, null, "136", 5, 2 },
                    { 38, null, null, 2, null, "137", 5, 2 },
                    { 39, null, null, 2, null, "138", 5, 2 },
                    { 40, null, null, 2, null, "139", 5, 2 },
                    { 52, null, null, 3, null, "151", 5, 5 },
                    { 51, null, null, 3, null, "150", 5, 5 },
                    { 20, null, null, 1, null, "119", 5, 4 },
                    { 19, null, null, 1, null, "118", 5, 4 },
                    { 18, null, null, 1, null, "117", 5, 4 },
                    { 41, null, null, 3, null, "140", 5, 3 },
                    { 42, null, null, 3, null, "141", 5, 3 },
                    { 43, null, null, 3, null, "142", 5, 3 },
                    { 44, null, null, 3, null, "143", 5, 3 },
                    { 31, null, null, 2, null, "130", 5, 2 },
                    { 62, null, null, 4, null, "161", 5, 3 }
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
