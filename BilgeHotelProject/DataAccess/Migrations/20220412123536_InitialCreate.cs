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
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c0f51077-fc42-4f22-bc1f-accd5aa7d2ab", "mutfak", "MUTFAK" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "47705f65-3c53-4a62-be81-ca8619b44d32", "bilgi islem", "BILGI ISLEM" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "416aaf83-fcf6-4d8b-aadd-d0653b57a6c0", "yardimci hizmetler", "YARDIMCI HIZMETLER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "7df74857-a523-4dec-86b5-c80ce751aee4", "insan kaynaklari", "INSAN KAYNAKLARI" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "e8b1cedc-95de-44bd-bab0-19f174ca06d8", "resepsiyon", "RESEPSIYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "7ef6fefa-3ac8-4b2b-9fac-c4f650f79ac1", "admin", "ADMIN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "08b2b36f-c20a-4d39-b98e-b41f44d873cc", "user", "USER" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "cbaf6b00-0f2c-47c1-9a68-6f0efdade2b2", "muhasebe", "MUHASEBE" },
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "0c9b2ffd-6c77-4b87-bb61-f1d5d374ee42", "valilik", "VALILIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d72443b1-e09d-407b-a89f-aa9eb12d68bb", 0, null, "6b880537-b6c0-4d55-ae7c-869cd8343a2e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Myra_Sanford@gmail.com", true, "Myra", "Sanford", false, null, "MYRA_SANFORD@GMAIL.COM", "MYRA_SANFORD@GMAIL.COM", "AO3+7C+48cTzC2gF0FlIzurah1D7Irs4q7S37FGniRRPlbyRK9S5zSC82BebbOEi+w==", "05111111111", false, "e6380da2-5d10-4dd9-ab39-96ce1d6398bc", false, "Myra_Sanford@gmail.com" },
                    { "c856561d-8afd-407d-9716-2b97926137bd", 0, null, "c846cae2-e66b-43b8-82cd-84dee07e8d15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van87@gmail.com", true, "Van", "Olson", false, null, "VAN87@GMAIL.COM", "VAN87@GMAIL.COM", "AMO7pFEE1FxpwlgL+C72MLGr3mhr4o9xvFfTDbD3Kc6PYkusTWH+IMuvdXky9cvVdA==", "05111111111", false, "b0f28347-ebca-4c4a-afff-617f3d6007d5", false, "Van87@gmail.com" },
                    { "4e0f7e63-8ee5-49f3-b504-70d63f0248f4", 0, null, "e1868cbc-6348-4b8f-bfe1-250258cfbcf8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terrance84@gmail.com", true, "Terrance", "Treutel", false, null, "TERRANCE84@GMAIL.COM", "TERRANCE84@GMAIL.COM", "AO5LWaO4Zu8drLStC+2n61TkOO28RTTuuj4/rLJmKz8Rx3ZZhWQmLsbY0jtZg2LRyQ==", "05111111111", false, "4df8b896-27d8-46a8-aded-7eca66498ec3", false, "Terrance84@gmail.com" },
                    { "b2a6c8bc-0c16-4853-bb9b-d2367d5d80ff", 0, null, "a0c150ee-e464-40e1-838e-9062806618bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margarita_Marquardt@hotmail.com", true, "Margarita", "Marquardt", false, null, "MARGARITA_MARQUARDT@HOTMAIL.COM", "MARGARITA_MARQUARDT@HOTMAIL.COM", "ANcWfFCAkyixeAzR+DAWB5UusdZMlz0aenqfCNHGs+tTYjcvd/z2zYb0ZSlLqe9VfA==", "05111111111", false, "b36c3ad9-379f-4ff9-805e-729ef625fc17", false, "Margarita_Marquardt@hotmail.com" },
                    { "d1f937e2-9636-4e34-ae03-8f519c74f6b4", 0, null, "3e132e8a-e77e-44c9-ae63-7be7ec185aaa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irma19@yahoo.com", true, "Irma", "Bogisich", false, null, "IRMA19@YAHOO.COM", "IRMA19@YAHOO.COM", "ACzPqpCLPt/Sb1MKGtrPHaY3GackWtieLQa/plb5xUARpSTRu5UaPpODpwaBOVj54w==", "05111111111", false, "fbdd3d55-6b48-443a-af7a-7eb7b1471123", false, "Irma19@yahoo.com" },
                    { "ef47c999-718f-46f6-bb26-821a17acf8bd", 0, null, "8f94715e-b136-48e2-ba07-df4098d21e8d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flora35@yahoo.com", true, "Flora", "Cartwright", false, null, "FLORA35@YAHOO.COM", "FLORA35@YAHOO.COM", "AD2KF82r41Ek2pAFZc3zLPBmoJ+suGsTtHO7lPq9Eqn2IBcpt6YWp9MyOW5zJ6MuoQ==", "05111111111", false, "a8fc714a-93e0-4ea8-ab22-33311243b96b", false, "Flora35@yahoo.com" },
                    { "aa076299-5538-4c74-b5d9-213c86b95b92", 0, null, "dff779aa-ed3e-4b33-b79f-66e638ea9e99", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guy_Reichert@yahoo.com", true, "Guy", "Reichert", false, null, "GUY_REICHERT@YAHOO.COM", "GUY_REICHERT@YAHOO.COM", "AKRAMSW8NAw/INMFnPkD2pXp3xyDBZhZQxmEXwEz1Tr8wBtopWcr4rzUfO5zjf2PqQ==", "05111111111", false, "badb30e1-c9f0-44d0-948a-bd0d45eb6b6c", false, "Guy_Reichert@yahoo.com" },
                    { "bcba45ac-8b10-421d-bbfc-9f84693c5543", 0, null, "200332ef-f220-410b-a5a9-0294503acac8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jesus77@gmail.com", true, "Jesus", "Lakin", false, null, "JESUS77@GMAIL.COM", "JESUS77@GMAIL.COM", "ADT2cHOTPWGEzzhJJkdSWY0XSVF6rnPvTAuzPCXmb4IX1CffDBLKHh8Pbtxx2nFJow==", "05111111111", false, "a638d8e6-6ec5-4b3d-9454-a06f5ef4f613", false, "Jesus77@gmail.com" },
                    { "c2e88d4c-2e17-46bc-a803-d3626368b987", 0, null, "5c32e270-b8ef-4091-b4fe-701a8af1554f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geneva41@yahoo.com", true, "Geneva", "Marquardt", false, null, "GENEVA41@YAHOO.COM", "GENEVA41@YAHOO.COM", "AO5OpcGRV+QAhaJbTQSdz4B82y0Ese2dA7AnubV1i1Ro6xm9DtY9hq3YlQl6vKJKvA==", "05111111111", false, "8926c62f-2510-482e-8a26-d1917fabde51", false, "Geneva41@yahoo.com" },
                    { "35a0908c-b318-4161-a36b-815b51965b43", 0, null, "8dd2fbbe-9876-47b0-bf0c-980d0502fc12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toni.Jacobs72@gmail.com", true, "Toni", "Jacobs", false, null, "TONI.JACOBS72@GMAIL.COM", "TONI.JACOBS72@GMAIL.COM", "AC5jaB5I+iNusVY3PefsNitiwWbHXA/ZgcFBYB+290f3Vfy8iycmCLFO5BVKsLPCVg==", "05111111111", false, "08d5a068-e859-4c5e-a0a2-7d219d474252", false, "Toni.Jacobs72@gmail.com" },
                    { "ea805a6b-7f70-4725-a90a-882f8a5ba7e5", 0, null, "6ae16dec-9cb4-47e0-8c03-b0953b176e7b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruben.Renner50@gmail.com", true, "Ruben", "Renner", false, null, "RUBEN.RENNER50@GMAIL.COM", "RUBEN.RENNER50@GMAIL.COM", "AJAUsu3bvAJ+qrOvHiLMm3YVZWmZxCj1GgiTrtY3YUTp5DTgQliHhu4+U4oM81w2oA==", "05111111111", false, "d5c02c05-1b2e-4b9f-8f3d-8a3f50b56549", false, "Ruben.Renner50@gmail.com" },
                    { "db17ac3c-c23e-4133-88be-64f5fed9f8c2", 0, null, "91b71d0f-fda1-43e7-b8a8-25f0ef9d3366", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kate_Halvorson@yahoo.com", true, "Kate", "Halvorson", false, null, "KATE_HALVORSON@YAHOO.COM", "KATE_HALVORSON@YAHOO.COM", "AGPpEzD591X/YKWWBPqkfKOEWDOG6unhhFjQNU2XmL/HSLMtEz9P73SuRCXHP2uTxA==", "05111111111", false, "dced23c7-6649-491a-ac7e-34801f5edb62", false, "Kate_Halvorson@yahoo.com" },
                    { "4a5a1e16-0b3b-4a13-83bd-b5380230c533", 0, null, "d8207bc8-36e9-4553-9ffa-ff9f4643337b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ida_Ruecker@yahoo.com", true, "Ida", "Ruecker", false, null, "IDA_RUECKER@YAHOO.COM", "IDA_RUECKER@YAHOO.COM", "AIZsmzu2SxtkGpc09XU0gNmDBafEc9mwMceboCufFmEhGQzy2jiFdptjbwpBP6dcOA==", "05111111111", false, "a5175ba1-02dd-4474-8633-c7d2a5272d72", false, "Ida_Ruecker@yahoo.com" },
                    { "89141d1c-1ff6-41e1-8a07-27114f05aabc", 0, null, "eec3ab34-23b0-446e-9ce8-6b7ca476cc41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tina.Zieme@yahoo.com", true, "Tina", "Zieme", false, null, "TINA.ZIEME@YAHOO.COM", "TINA.ZIEME@YAHOO.COM", "APh5Kds1TOB0l9qVGNQdAdJJ5xZ8SDJ6NwqH9jjvPH2a7dOyygsof5JOp1eCMeinMA==", "05111111111", false, "25f33451-ba8d-4ee4-803e-32a6e38c66aa", false, "Tina.Zieme@yahoo.com" },
                    { "fc80d00c-604e-42cc-bc5c-8689671971b7", 0, null, "1a0686a3-6e6e-4fa5-ab8c-d5b7db467426", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "valilik@bilgehotel.com", true, "Bilge", "Hotel", false, null, "VALILIK@BILGEHOTEL.COM", "VALILIK@BILGEHOTEL.COM", "ADqrhNBzHv5Xn72jGD2ZKuIMtlDlIHreNM8+ZljPV/3cRG4wCzQEf+eHh65UKCsuvg==", "05111111111", false, "bfdd7bbb-41c0-4de7-aa59-78de9a8e3506", false, "valilik@bilgehotel.com" },
                    { "d9328fea-c2d5-4961-9d35-a537d2aee8e1", 0, null, "5791468a-e95f-4ff2-a3db-f0c909870445", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frank.Corwin@yahoo.com", true, "Frank", "Corwin", false, null, "FRANK.CORWIN@YAHOO.COM", "FRANK.CORWIN@YAHOO.COM", "AL4lE5NQ19cM2BnT/AocVOCd1vEn5mcfJOkj+g9ItsLTu1rXAqQ5IrwYjSVao44LhA==", "05111111111", false, "99a927b2-61ff-4c60-baf2-eb615731cef2", false, "Frank.Corwin@yahoo.com" },
                    { "5dd7d960-1035-4f49-a64c-65601a54f81c", 0, null, "44688d93-7b0c-4b8e-9f37-7d8b468bc227", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helen_Orn@hotmail.com", true, "Helen", "Orn", false, null, "HELEN_ORN@HOTMAIL.COM", "HELEN_ORN@HOTMAIL.COM", "AJvkL43S4AdA/ns9DGx0752GCxwvKNF8unRZoSHzFEoDztphJKdSLsHnH9TnNMYOow==", "05111111111", false, "5f105802-dc97-4455-9980-509e67c78af9", false, "Helen_Orn@hotmail.com" },
                    { "7f61ead1-2e40-491b-a56c-c9b94e12d7f2", 0, null, "a3da8095-e256-4c04-98e8-0173188ef38f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adrian.Maggio@gmail.com", true, "Adrian", "Maggio", false, null, "ADRIAN.MAGGIO@GMAIL.COM", "ADRIAN.MAGGIO@GMAIL.COM", "AJOmC4fUPUqh/60c4Zkc+463j8LD5O8BHlBhUG2ibtK6+QLMT0idQtsYdrkjCNc34A==", "05111111111", false, "d38abed2-33d5-42b4-97ac-54c6b8dae2bc", false, "Adrian.Maggio@gmail.com" },
                    { "1671bf5b-88a7-41aa-924b-30b88454d8ce", 0, null, "96917c41-6514-43f1-b87d-5e4eda3ceaf9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suzanne_Waters@hotmail.com", true, "Suzanne", "Waters", false, null, "SUZANNE_WATERS@HOTMAIL.COM", "SUZANNE_WATERS@HOTMAIL.COM", "ABkc7/s+9XSKToXeB+gGS1yCMlweacnPxNTbuJj8S16yVVLadYfR0V0byZ59Uq67Rg==", "05111111111", false, "ea20a57b-d7d1-4425-b14b-d35e757a5e9d", false, "Suzanne_Waters@hotmail.com" },
                    { "f756ced7-3ef9-412a-94dc-60bfa7d21f7f", 0, null, "76caaeec-411e-4ae8-93f7-f743ee0e1db9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alicia_Johns32@gmail.com", true, "Alicia", "Johns", false, null, "ALICIA_JOHNS32@GMAIL.COM", "ALICIA_JOHNS32@GMAIL.COM", "AMp+z4Ux2tObc/l5tmkvVZmJ+bP+HuA8TM7AneGuUqKJmED7lXTxNuuyycCTSMWkXQ==", "05111111111", false, "ce34f7ce-9c2d-41af-bbcc-b8747e3def50", false, "Alicia_Johns32@gmail.com" },
                    { "49bd90aa-aecf-40a9-96c1-63348daaa649", 0, null, "802d537e-f57f-4714-855d-93f3577534e0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eunice96@yahoo.com", true, "Eunice", "Marquardt", false, null, "EUNICE96@YAHOO.COM", "EUNICE96@YAHOO.COM", "AOWCcENYkha3SGq6gPDnRS4uLOjPIsIp8BNAJa1XFQjaQl5fhAfaO6nbvhLLJIrZHA==", "05111111111", false, "3de5506e-5be4-416c-be2a-c2b7619de041", false, "Eunice96@yahoo.com" },
                    { "59eeb20f-0799-474a-bc79-98166a917f14", 0, null, "7df99027-8cce-4836-8701-149430189384", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rachael_Leannon@hotmail.com", true, "Rachael", "Leannon", false, null, "RACHAEL_LEANNON@HOTMAIL.COM", "RACHAEL_LEANNON@HOTMAIL.COM", "AK2eFsmrdBH3OsWzLypwMyRMxyxZ6EhYrY18YsHbuu3H5/DJErP2Z5B3OCRh0cj9EQ==", "05111111111", false, "87b64627-3543-4c1c-adb2-7cdb07b4aaa0", false, "Rachael_Leannon@hotmail.com" },
                    { "045901b2-e6b5-4d10-a3d9-304b61fea438", 0, null, "3bca9aac-59d7-4160-ad93-05893bbb561b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruth.King@hotmail.com", true, "Ruth", "King", false, null, "RUTH.KING@HOTMAIL.COM", "RUTH.KING@HOTMAIL.COM", "AP07gakmG0h6ytlkHOtyEmmbzly24WpqTLVeUOpGYswRSGlhPkMq0YDvQcq6FqGPQw==", "05111111111", false, "01f00c27-79fb-409c-8e9d-be39cd3438d0", false, "Ruth.King@hotmail.com" },
                    { "35fcdaad-8538-4294-bc58-01b84ab7b57f", 0, null, "904d843a-c03c-4da2-8477-d78a86d208e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duane60@hotmail.com", true, "Duane", "Mayer", false, null, "DUANE60@HOTMAIL.COM", "DUANE60@HOTMAIL.COM", "AJ87KJqaktVBJoaSOzFzFf1MdokdxanOs6ILEC/lNffF++T98AFxnk7haaoqT19EDA==", "05111111111", false, "0279dae2-4533-49e0-ac33-7c7e1564dd72", false, "Duane60@hotmail.com" },
                    { "526499a4-da0f-4ecc-8349-374cddc8ee87", 0, null, "e56b7041-a6e0-4feb-a6c6-1e7b0e8f2144", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Todd_Larson@gmail.com", true, "Todd", "Larson", false, null, "TODD_LARSON@GMAIL.COM", "TODD_LARSON@GMAIL.COM", "ADwHq/UmVLXQoAx5z1LsjBo2scVhydamXWNLH0lLN46+BsFsAJWtPhbyAENotmiHhw==", "05111111111", false, "1e6814d2-7fa8-4905-98a8-bb1b95158579", false, "Todd_Larson@gmail.com" },
                    { "b3a1be30-48a3-409c-aaa0-f2e642334fa7", 0, null, "93327f02-7a26-4320-80dc-10f40e80a05f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordan_Ryan27@hotmail.com", true, "Jordan", "Ryan", false, null, "JORDAN_RYAN27@HOTMAIL.COM", "JORDAN_RYAN27@HOTMAIL.COM", "AIaRKjslYM1L2yGepa4vOXmBh60no8D3TKuW+SHqTzWM+Ozic3KZ2MBTTQalQsisOg==", "05111111111", false, "238bd70a-4625-4b2d-b438-4c2df341af59", false, "Jordan_Ryan27@hotmail.com" },
                    { "fb83e155-239d-4d8c-bceb-c36f15d4dcbe", 0, null, "a9714278-4043-4c53-8fce-749f60188350", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "June44@hotmail.com", true, "June", "Nienow", false, null, "JUNE44@HOTMAIL.COM", "JUNE44@HOTMAIL.COM", "AFMbHL7LBaF0BA9ncbesMVmj8kr21qXHVIqufGWSbbHCn0DHGdwCcbc/mz8gjOlAMg==", "05111111111", false, "b404a75c-9293-4e48-be37-cedfcb2ce70d", false, "June44@hotmail.com" },
                    { "6bec7dc0-6d0e-48f8-ba7f-ff825d9abf83", 0, null, "19fe22a3-7b1c-46f9-b0fb-11dfd92fa030", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gina55@hotmail.com", true, "Gina", "Kertzmann", false, null, "GINA55@HOTMAIL.COM", "GINA55@HOTMAIL.COM", "AKnSO8LOltlucfYcKKxGGdCrNUmSE5VKPlysMB9LvYp+bjTeTykIYY14sUj5MvWtNg==", "05111111111", false, "0ed09aca-42b7-4dc8-b79c-b7247b49c85c", false, "Gina55@hotmail.com" },
                    { "f823fce0-0cd0-4afb-be80-dcee68b9adc0", 0, null, "5acd6a98-752a-4659-b21e-57bf6bc2f9f3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thelma32@gmail.com", true, "Thelma", "Marquardt", false, null, "THELMA32@GMAIL.COM", "THELMA32@GMAIL.COM", "AFroGv+55KyItUvP7620/micTByWoAlsDSOJ+dh3Y3eUQXAfaz4xmzyB8CltKA0jjw==", "05111111111", false, "1438c15e-1df0-46df-85dd-8dbc5d554eb5", false, "Thelma32@gmail.com" },
                    { "ea7342fc-e1ef-47a6-a220-fa9135c30a2b", 0, null, "d66e2388-4773-4faa-aed8-7dd75e52e922", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Priscilla.Rempel53@yahoo.com", true, "Priscilla", "Rempel", false, null, "PRISCILLA.REMPEL53@YAHOO.COM", "PRISCILLA.REMPEL53@YAHOO.COM", "AK0GUEom260WriwkOtw6CNKb05fPIVnHXGda/Jy8NeTebyFxZ6qTjvMimWOMHfVqPQ==", "05111111111", false, "0907eee6-2e63-4ad2-8529-ef606bc12467", false, "Priscilla.Rempel53@yahoo.com" },
                    { "0673e3a9-d62c-4a0d-b1d7-73caa081fa50", 0, null, "224646a4-8e10-4274-b4af-a68d1c63b27b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abel63@gmail.com", true, "Abel", "Reynolds", false, null, "ABEL63@GMAIL.COM", "ABEL63@GMAIL.COM", "AF21KRnfa5N5MMUKPXs8pS/jSWS4Rb2iCLN6TiWNfSsnyifS7j5jdG7k62PW8UYDxw==", "05111111111", false, "545e2960-0c13-4467-a83a-511189e5f999", false, "Abel63@gmail.com" },
                    { "95492ce8-841a-43a2-84b2-f683ce1ee634", 0, null, "0f107305-a9b8-4772-9c9e-412340cb9944", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ella49@hotmail.com", true, "Ella", "Beatty", false, null, "ELLA49@HOTMAIL.COM", "ELLA49@HOTMAIL.COM", "ADO07q45qHPrN2l7TlQmu2Ep9Pc1tCyp2ajWPYhsKppBTqh/VhK4aIawizFR+GTccQ==", "05111111111", false, "f277efd8-79c2-4404-97eb-3fbf4be68d3a", false, "Ella49@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivationKey", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05de0c15-001d-4963-aa3f-c631a0b63182", 0, null, "74935187-7b30-4eee-9d9c-4831f9380334", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lauren.Heller21@gmail.com", true, "Lauren", "Heller", false, null, "LAUREN.HELLER21@GMAIL.COM", "LAUREN.HELLER21@GMAIL.COM", "AP+nxTPRJlpLo/tTf29AQdyryzvaDL37mMxWlZ8Zb6AanrgPgrrAXz30NxOIieM+8g==", "05111111111", false, "3263953e-a630-4f98-a9ad-f94b9f4bf3de", false, "Lauren.Heller21@gmail.com" },
                    { "631bcd2a-a888-465d-92fa-cdd3917538c1", 0, null, "203fcc04-85fa-4633-a456-067f42757cbb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather.Wuckert@yahoo.com", true, "Heather", "Wuckert", false, null, "HEATHER.WUCKERT@YAHOO.COM", "HEATHER.WUCKERT@YAHOO.COM", "AObiueT6qTmStl/n+bLXj91/NWnnokE9OXtv5f10gsU26jUruli/3rV0XWzs2SXcZQ==", "05111111111", false, "988443ba-9b2e-41bf-9c0b-15e78c380a6d", false, "Heather.Wuckert@yahoo.com" },
                    { "194cd3b8-0428-4200-b389-28a517042651", 0, null, "e7282f96-39e8-4fa2-8d6e-2223e9742f79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessie_Koss@hotmail.com", true, "Jessie", "Koss", false, null, "JESSIE_KOSS@HOTMAIL.COM", "JESSIE_KOSS@HOTMAIL.COM", "ANH15W4eusg/W1PSbjLuO1UT6a4LM2OsmHU/l6kiqyQ3Cgp6wwvEgEIvJSYT6civDA==", "05111111111", false, "e64d5af1-8cfa-4852-a9d0-769e9283ca6b", false, "Jessie_Koss@hotmail.com" },
                    { "ade1fbf6-b4ba-4a1f-8da6-704f1a23b72b", 0, null, "40fc4e99-7ab1-4a37-b51a-7ccb0ef2ce88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James_Stanton77@hotmail.com", true, "James", "Stanton", false, null, "JAMES_STANTON77@HOTMAIL.COM", "JAMES_STANTON77@HOTMAIL.COM", "ANa94RpOkXtWjDJgJM7mj4MASy/+jEeqOqj9KUBUuEuzKwF6by4Phk4p1uZlUg2bVw==", "05111111111", false, "7121ff4a-34fd-4958-b4e5-2e0ff5aeb2e5", false, "James_Stanton77@hotmail.com" },
                    { "7d2ef3c4-df55-4165-8bcf-947a2511565f", 0, null, "f1ff9c69-87af-475c-b50d-7706a62c0aed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan20@yahoo.com", true, "Nathan", "Stamm", false, null, "NATHAN20@YAHOO.COM", "NATHAN20@YAHOO.COM", "APqKiG9Eoge9lvWvqOipAxGInAFrY6Pi9OhmN/wmqj5frxAI0civL1qQQWLaS3ol4g==", "05111111111", false, "1b6a80bf-6828-4d97-bd29-24538c34c39c", false, "Nathan20@yahoo.com" },
                    { "da28e3a2-2e42-4656-a04c-30cd132b13a4", 0, null, "318380b9-9d01-4a40-b701-ca17aaeaec9a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wallace50@gmail.com", true, "Wallace", "Murphy", false, null, "WALLACE50@GMAIL.COM", "WALLACE50@GMAIL.COM", "AIo+K0HghpPSzC+jnbNPR1OWhleDjItvJlR5Hlz/4OU8BrdUSfd/el9wXCa1+xJGrQ==", "05111111111", false, "0f044a89-a7f8-491c-8973-4a30ceba5ff9", false, "Wallace50@gmail.com" },
                    { "71014e4a-276d-485f-b4f9-171836360e62", 0, null, "541d676a-79f6-4eee-8fd4-12aee381ca50", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terry47@hotmail.com", true, "Terry", "Senger", false, null, "TERRY47@HOTMAIL.COM", "TERRY47@HOTMAIL.COM", "AKYGAARvBN5M94K0JBF4BdvlGFzacVzLSzEkZNXmJtFQK8pifXp6407aoDsbGB5B9A==", "05111111111", false, "6f2f648d-cb39-44a2-9b1a-6600c5ad7426", false, "Terry47@hotmail.com" },
                    { "78253540-e3da-48a3-9397-8f92b611add5", 0, null, "bb2d3742-5dd3-421d-90d1-5a8ca54c8d74", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosalie7@gmail.com", true, "Rosalie", "Ritchie", false, null, "ROSALIE7@GMAIL.COM", "ROSALIE7@GMAIL.COM", "AEADoLET/TYNjYosj3ut+5/Ad/VfcPKyrab5N2o7wo+1Wq+1mIGYKc1MX5Mzgftr2g==", "05111111111", false, "afd547f5-60b2-4f98-9787-0664036b5a57", false, "Rosalie7@gmail.com" },
                    { "bccbf7f9-4692-4c99-b4fa-039ff3ac9acb", 0, null, "e1f4d6d8-ded0-4c97-ac5c-7bdf64ffc75e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carmen31@hotmail.com", true, "Carmen", "Nienow", false, null, "CARMEN31@HOTMAIL.COM", "CARMEN31@HOTMAIL.COM", "ACGZVbqMMRcZL2WAy9r6GXCS9P6T6q3iiigsEPgX0TBWVlw/OCQnRboiB5NKex1zuw==", "05111111111", false, "bcc08cb9-8806-4f3d-adb5-50a931442d4b", false, "Carmen31@hotmail.com" },
                    { "72bb2a5a-37a9-459c-a44a-1c5ffcf3f25a", 0, null, "937935e4-7d5d-4114-9138-bead85ee84ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony_Corkery@hotmail.com", true, "Anthony", "Corkery", false, null, "ANTHONY_CORKERY@HOTMAIL.COM", "ANTHONY_CORKERY@HOTMAIL.COM", "ACR86D4Ylu6/h3ohtvgGDxaERs75KMWLYgakkPggf5+GYa8U//n9TkIxiv8ngUeaIw==", "05111111111", false, "0571f9d9-1ee8-4b8b-8778-4c5d00ef9932", false, "Anthony_Corkery@hotmail.com" },
                    { "0e0376f3-e53d-4124-8891-1a154f6306d4", 0, null, "5dbf8048-f290-4d29-9c7d-8f610353f612", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janie_Feil16@gmail.com", true, "Janie", "Feil", false, null, "JANIE_FEIL16@GMAIL.COM", "JANIE_FEIL16@GMAIL.COM", "ADdrnpayjqljCbEPfoS4YSM7kJS9qFTj8WSlmVclN4ttsJIYKAwwv01q9L+B5jdbiA==", "05111111111", false, "4f6b6275-41ee-4de9-a8b0-66cf2892d25d", false, "Janie_Feil16@gmail.com" },
                    { "b77dbdfd-3760-426c-94e6-93e0084c5475", 0, null, "3f79b27c-308e-480a-84b4-ae07cf70d1b1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christina.Stracke77@gmail.com", true, "Christina", "Stracke", false, null, "CHRISTINA.STRACKE77@GMAIL.COM", "CHRISTINA.STRACKE77@GMAIL.COM", "AFi15HQ+VoKVDpjeq4VtRdzhtndOJjN6U/NgxH7TKBzW6Hm+bP5GrDPH9vARCyohfg==", "05111111111", false, "ae597662-a325-46bc-9c4e-4995e817d0be", false, "Christina.Stracke77@gmail.com" },
                    { "6aa57f41-b80c-4db1-a0ca-3be90c92d757", 0, null, "0708a933-f20c-469b-a270-5ca0c6b46bc7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dorothy12@gmail.com", true, "Dorothy", "Bartoletti", false, null, "DOROTHY12@GMAIL.COM", "DOROTHY12@GMAIL.COM", "APsv2hBRgdBztpZeEJEynezgVS6HNfh6PgucVjJnFsOfxZC2VDSA/vduwo/KPfr+uA==", "05111111111", false, "1b0611de-4826-4922-bc82-156f57f23378", false, "Dorothy12@gmail.com" },
                    { "420027fa-8a44-4d72-bbc1-b8b76f020096", 0, null, "f6e48482-a5c2-4dbc-a0c5-171af5f3be15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sheri_Gaylord@hotmail.com", true, "Sheri", "Gaylord", false, null, "SHERI_GAYLORD@HOTMAIL.COM", "SHERI_GAYLORD@HOTMAIL.COM", "AB3CnTCTL36cafJ10J5x2oQIqpfheIlrJ4WY7q3Uagu7cLPIHSpLTvSgfXEuvZQs6w==", "05111111111", false, "4d8a97f7-6923-4126-bba6-66f9509e2a2b", false, "Sheri_Gaylord@hotmail.com" },
                    { "2a81cd22-95e4-4f88-994c-07f4b22d14b4", 0, null, "a67e8944-3b16-4753-9924-e67b3091e604", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest_Baumbach15@hotmail.com", true, "Forrest", "Baumbach", false, null, "FORREST_BAUMBACH15@HOTMAIL.COM", "FORREST_BAUMBACH15@HOTMAIL.COM", "AP6dVhvG0whYeAhEPKdiUQZODP/rSlXCJ4rvQVlUvaKDDeqBdDKOOoDphvdgmIlgcw==", "05111111111", false, "1de45cb2-ab5b-4b87-a8df-281b9e9ee413", false, "Forrest_Baumbach15@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedDate", "Email", "Facebook", "Fax", "Instagram", "ModifiedDate", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "4436 Gutmann Viaduct, Jarodton, Portugal", null, "Joanna54@hotmail.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

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
                values: new object[] { 1, null, null, "mailadres@gmail.com", "smtp.gmail.com", "Sifre", 587 });

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
                    { "faf7c5c9-62cc-4c83-8f95-d51395940793", "fc80d00c-604e-42cc-bc5c-8689671971b7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "72bb2a5a-37a9-459c-a44a-1c5ffcf3f25a" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0e0376f3-e53d-4124-8891-1a154f6306d4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b77dbdfd-3760-426c-94e6-93e0084c5475" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6aa57f41-b80c-4db1-a0ca-3be90c92d757" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "194cd3b8-0428-4200-b389-28a517042651" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "35fcdaad-8538-4294-bc58-01b84ab7b57f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ea805a6b-7f70-4725-a90a-882f8a5ba7e5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c856561d-8afd-407d-9716-2b97926137bd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4e0f7e63-8ee5-49f3-b504-70d63f0248f4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b2a6c8bc-0c16-4853-bb9b-d2367d5d80ff" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d1f937e2-9636-4e34-ae03-8f519c74f6b4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ef47c999-718f-46f6-bb26-821a17acf8bd" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "aa076299-5538-4c74-b5d9-213c86b95b92" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bcba45ac-8b10-421d-bbfc-9f84693c5543" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "c2e88d4c-2e17-46bc-a803-d3626368b987" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "35a0908c-b318-4161-a36b-815b51965b43" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "db17ac3c-c23e-4133-88be-64f5fed9f8c2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "59eeb20f-0799-474a-bc79-98166a917f14" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "89141d1c-1ff6-41e1-8a07-27114f05aabc" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "bccbf7f9-4692-4c99-b4fa-039ff3ac9acb" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "5dd7d960-1035-4f49-a64c-65601a54f81c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "78253540-e3da-48a3-9397-8f92b611add5" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "da28e3a2-2e42-4656-a04c-30cd132b13a4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "5dd7d960-1035-4f49-a64c-65601a54f81c" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7f61ead1-2e40-491b-a56c-c9b94e12d7f2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "1671bf5b-88a7-41aa-924b-30b88454d8ce" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f756ced7-3ef9-412a-94dc-60bfa7d21f7f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "045901b2-e6b5-4d10-a3d9-304b61fea438" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "2a81cd22-95e4-4f88-994c-07f4b22d14b4" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d9328fea-c2d5-4961-9d35-a537d2aee8e1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "49bd90aa-aecf-40a9-96c1-63348daaa649" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "d72443b1-e09d-407b-a89f-aa9eb12d68bb" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "b3a1be30-48a3-409c-aaa0-f2e642334fa7" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "fb83e155-239d-4d8c-bceb-c36f15d4dcbe" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "6bec7dc0-6d0e-48f8-ba7f-ff825d9abf83" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "f823fce0-0cd0-4afb-be80-dcee68b9adc0" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ea7342fc-e1ef-47a6-a220-fa9135c30a2b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "0673e3a9-d62c-4a0d-b1d7-73caa081fa50" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "95492ce8-841a-43a2-84b2-f683ce1ee634" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "05de0c15-001d-4963-aa3f-c631a0b63182" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "631bcd2a-a888-465d-92fa-cdd3917538c1" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "ade1fbf6-b4ba-4a1f-8da6-704f1a23b72b" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "420027fa-8a44-4d72-bbc1-b8b76f020096" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "7d2ef3c4-df55-4165-8bcf-947a2511565f" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "71014e4a-276d-485f-b4f9-171836360e62" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "7f61ead1-2e40-491b-a56c-c9b94e12d7f2" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "526499a4-da0f-4ecc-8349-374cddc8ee87" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "f756ced7-3ef9-412a-94dc-60bfa7d21f7f" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "71014e4a-276d-485f-b4f9-171836360e62" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "78253540-e3da-48a3-9397-8f92b611add5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bccbf7f9-4692-4c99-b4fa-039ff3ac9acb" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "72bb2a5a-37a9-459c-a44a-1c5ffcf3f25a" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "0e0376f3-e53d-4124-8891-1a154f6306d4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b77dbdfd-3760-426c-94e6-93e0084c5475" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "6aa57f41-b80c-4db1-a0ca-3be90c92d757" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "526499a4-da0f-4ecc-8349-374cddc8ee87" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "194cd3b8-0428-4200-b389-28a517042651" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "35fcdaad-8538-4294-bc58-01b84ab7b57f" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "da28e3a2-2e42-4656-a04c-30cd132b13a4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ea805a6b-7f70-4725-a90a-882f8a5ba7e5" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4e0f7e63-8ee5-49f3-b504-70d63f0248f4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "b2a6c8bc-0c16-4853-bb9b-d2367d5d80ff" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "d1f937e2-9636-4e34-ae03-8f519c74f6b4" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ef47c999-718f-46f6-bb26-821a17acf8bd" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "aa076299-5538-4c74-b5d9-213c86b95b92" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "1671bf5b-88a7-41aa-924b-30b88454d8ce" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c2e88d4c-2e17-46bc-a803-d3626368b987" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "35a0908c-b318-4161-a36b-815b51965b43" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "c856561d-8afd-407d-9716-2b97926137bd" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "7d2ef3c4-df55-4165-8bcf-947a2511565f" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "bcba45ac-8b10-421d-bbfc-9f84693c5543" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "ade1fbf6-b4ba-4a1f-8da6-704f1a23b72b" },
                    { "a98546c7-b529-4836-8d88-6af9667d8008", "420027fa-8a44-4d72-bbc1-b8b76f020096" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "045901b2-e6b5-4d10-a3d9-304b61fea438" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "2a81cd22-95e4-4f88-994c-07f4b22d14b4" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "d9328fea-c2d5-4961-9d35-a537d2aee8e1" },
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "89141d1c-1ff6-41e1-8a07-27114f05aabc" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "49bd90aa-aecf-40a9-96c1-63348daaa649" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "d72443b1-e09d-407b-a89f-aa9eb12d68bb" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "b3a1be30-48a3-409c-aaa0-f2e642334fa7" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "fb83e155-239d-4d8c-bceb-c36f15d4dcbe" },
                    { "4353147a-1b09-492f-87aa-6b467d30e7e0", "89141d1c-1ff6-41e1-8a07-27114f05aabc" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "f823fce0-0cd0-4afb-be80-dcee68b9adc0" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "6bec7dc0-6d0e-48f8-ba7f-ff825d9abf83" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "59eeb20f-0799-474a-bc79-98166a917f14" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "db17ac3c-c23e-4133-88be-64f5fed9f8c2" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "631bcd2a-a888-465d-92fa-cdd3917538c1" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "95492ce8-841a-43a2-84b2-f683ce1ee634" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "0673e3a9-d62c-4a0d-b1d7-73caa081fa50" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "ea7342fc-e1ef-47a6-a220-fa9135c30a2b" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "05de0c15-001d-4963-aa3f-c631a0b63182" },
                    { "0cd03d09-4264-4f6e-b0d8-e18fe9c03aa1", "4a5a1e16-0b3b-4a13-83bd-b5380230c533" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedDate", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedDate", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 44, "59eeb20f-0799-474a-bc79-98166a917f14", null, 2, "Rachael_Leannon@hotmail.com", 3, "Rachael", 21.49357538274190m, "6329", true, "Leannon", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 11, 1, 15, 22, 10, 344, DateTimeKind.Unspecified).AddTicks(9990), "Bilgi İşlem Sorumlusu" },
                    { 32, "35fcdaad-8538-4294-bc58-01b84ab7b57f", null, 3, "Duane60@hotmail.com", 3, "Duane", 27.392793105632440m, "6751", true, "Mayer", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 1, 17, 9, 56, 40, 86, DateTimeKind.Unspecified).AddTicks(6412), "Garson" },
                    { 43, "db17ac3c-c23e-4133-88be-64f5fed9f8c2", null, 1, "Kate_Halvorson@yahoo.com", 3, "Kate", 22.331172922780350m, "6450", true, "Halvorson", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 11, 10, 8, 50, 40, 959, DateTimeKind.Unspecified).AddTicks(2655), "Elektirikçi" },
                    { 36, "b2a6c8bc-0c16-4853-bb9b-d2367d5d80ff", null, 3, "Margarita_Marquardt@hotmail.com", 3, "Margarita", 22.122419100311780m, "6866", true, "Marquardt", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 8, 22, 10, 25, 21, 719, DateTimeKind.Unspecified).AddTicks(7354), "Garson" },
                    { 35, "4e0f7e63-8ee5-49f3-b504-70d63f0248f4", null, 3, "Terrance84@gmail.com", 3, "Terrance", 22.864772478521230m, "6195", true, "Treutel", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 5, 2, 29, 6, 588, DateTimeKind.Unspecified).AddTicks(4353), "Garson" },
                    { 34, "c856561d-8afd-407d-9716-2b97926137bd", null, 3, "Van87@gmail.com", 3, "Van", 28.043909393271390m, "6392", true, "Olson", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 2, 22, 21, 0, 52, 705, DateTimeKind.Unspecified).AddTicks(8407), "Garson" },
                    { 33, "ea805a6b-7f70-4725-a90a-882f8a5ba7e5", null, 3, "Ruben.Renner50@gmail.com", 3, "Ruben", 20.4254487065716870m, "2464", true, "Renner", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 1, 17, 11, 33, 6, 507, DateTimeKind.Unspecified).AddTicks(5878), "Garson" },
                    { 23, "71014e4a-276d-485f-b4f9-171836360e62", null, 3, "Terry47@hotmail.com", 3, "Terry", 29.25541631842750m, "1367", true, "Senger", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 1, 30, 19, 28, 20, 874, DateTimeKind.Unspecified).AddTicks(1708), "Aşçı" },
                    { 30, "526499a4-da0f-4ecc-8349-374cddc8ee87", null, 3, "Todd_Larson@gmail.com", 3, "Todd", 28.602791958769220m, "3299", true, "Larson", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 4, 4, 5, 26, 56, 551, DateTimeKind.Unspecified).AddTicks(8336), "Garson" },
                    { 24, "78253540-e3da-48a3-9397-8f92b611add5", null, 3, "Rosalie7@gmail.com", 3, "Rosalie", 27.34738476916560m, "9941", true, "Ritchie", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 8, 6, 20, 28, 26, 69, DateTimeKind.Unspecified).AddTicks(492), "Aşçı" },
                    { 45, "4a5a1e16-0b3b-4a13-83bd-b5380230c533", null, 5, "Ida_Ruecker@yahoo.com", 0, "Ida", 23.084803355431560m, "7971", true, "Ruecker", null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2020, 10, 7, 18, 21, 41, 675, DateTimeKind.Unspecified).AddTicks(7499), "Müdür" },
                    { 22, "da28e3a2-2e42-4656-a04c-30cd132b13a4", null, 3, "Wallace50@gmail.com", 3, "Wallace", 27.378935142131030m, "9120", true, "Murphy", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 8, 25, 18, 39, 38, 841, DateTimeKind.Unspecified).AddTicks(987), "Aşçı" },
                    { 21, "7d2ef3c4-df55-4165-8bcf-947a2511565f", null, 3, "Nathan20@yahoo.com", 3, "Nathan", 21.146503245060570m, "5491", true, "Stamm", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 15, 17, 15, 38, 476, DateTimeKind.Unspecified).AddTicks(7734), "Aşçı" },
                    { 20, "420027fa-8a44-4d72-bbc1-b8b76f020096", null, 3, "Sheri_Gaylord@hotmail.com", 3, "Sheri", 25.237705011497120m, "5626", true, "Gaylord", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 11, 17, 1, 54, 5, 682, DateTimeKind.Unspecified).AddTicks(2026), "Aşçı" },
                    { 19, "ade1fbf6-b4ba-4a1f-8da6-704f1a23b72b", null, 3, "James_Stanton77@hotmail.com", 3, "James", 23.666020884954380m, "6438", true, "Stanton", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 15, 8, 48, 30, 721, DateTimeKind.Unspecified).AddTicks(8128), "Aşçı" },
                    { 13, "f823fce0-0cd0-4afb-be80-dcee68b9adc0", null, 1, "Thelma32@gmail.com", 3, "Thelma", 21.264176900155920m, "8151", true, "Marquardt", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 2, 18, 1, 56, 54, 571, DateTimeKind.Unspecified).AddTicks(6858), "Temizlik Görevlisi" },
                    { 31, "194cd3b8-0428-4200-b389-28a517042651", null, 3, "Jessie_Koss@hotmail.com", 3, "Jessie", 26.834664534234750m, "4853", true, "Koss", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 1, 16, 7, 45, 46, 647, DateTimeKind.Unspecified).AddTicks(7838), "Garson" },
                    { 46, "89141d1c-1ff6-41e1-8a07-27114f05aabc", null, 6, "Tina.Zieme@yahoo.com", 1, "Tina", 20.4477218261210820m, "6002", true, "Zieme", null, null, 10000m, 0m, "05454526235", null, 1, new DateTime(2021, 11, 15, 0, 26, 4, 735, DateTimeKind.Unspecified).AddTicks(586), "İnsan Kaynakları Müdürü" },
                    { 17, "05de0c15-001d-4963-aa3f-c631a0b63182", null, 1, "Lauren.Heller21@gmail.com", 3, "Lauren", 21.602168503032140m, "3764", true, "Heller", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 3, 14, 7, 22, 44, 45, DateTimeKind.Unspecified).AddTicks(3094), "Temizlik Görevlisi" },
                    { 5, "045901b2-e6b5-4d10-a3d9-304b61fea438", null, 4, "Ruth.King@hotmail.com", 3, "Ruth", 20.04682548811977050m, "3771", true, "King", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 1, 8, 11, 9, 47, 549, DateTimeKind.Unspecified).AddTicks(3471), "Resepsiyonist" },
                    { 12, "6bec7dc0-6d0e-48f8-ba7f-ff825d9abf83", null, 1, "Gina55@hotmail.com", 3, "Gina", 26.108181684328330m, "2325", true, "Kertzmann", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 1, 27, 3, 25, 26, 506, DateTimeKind.Unspecified).AddTicks(4395), "Temizlik Görevlisi" },
                    { 7, "d9328fea-c2d5-4961-9d35-a537d2aee8e1", null, 4, "Frank.Corwin@yahoo.com", 3, "Frank", 20.1489123935573330m, "1498", true, "Corwin", null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2021, 1, 9, 0, 34, 46, 595, DateTimeKind.Unspecified).AddTicks(1241), "Resepsiyonist" },
                    { 6, "2a81cd22-95e4-4f88-994c-07f4b22d14b4", null, 4, "Forrest_Baumbach15@hotmail.com", 3, "Forrest", 20.2664008505020290m, "3304", true, "Baumbach", null, null, 0m, 12m, "05454526235", null, 3, new DateTime(2019, 2, 19, 23, 6, 32, 333, DateTimeKind.Unspecified).AddTicks(9263), "Resepsiyonist" },
                    { 42, "35a0908c-b318-4161-a36b-815b51965b43", null, 3, "Toni.Jacobs72@gmail.com", 3, "Toni", 29.539894619742360m, "6997", true, "Jacobs", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 8, 22, 7, 47, 32, 788, DateTimeKind.Unspecified).AddTicks(1200), "Garson" },
                    { 41, "c2e88d4c-2e17-46bc-a803-d3626368b987", null, 3, "Geneva41@yahoo.com", 3, "Geneva", 26.657941521451780m, "9216", true, "Marquardt", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 1, 5, 19, 31, 47, 975, DateTimeKind.Unspecified).AddTicks(9114), "Garson" },
                    { 40, "bcba45ac-8b10-421d-bbfc-9f84693c5543", null, 3, "Jesus77@gmail.com", 3, "Jesus", 21.593686897118430m, "5772", true, "Lakin", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 11, 5, 12, 20, 23, 422, DateTimeKind.Unspecified).AddTicks(8463), "Garson" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedDate", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedDate", "MonthlySalary", "OvertimePay", "PhoneNumber", "ReasonForLeaving", "ShiftID", "StartDateOfWork", "Title" },
                values: new object[,]
                {
                    { 39, "aa076299-5538-4c74-b5d9-213c86b95b92", null, 3, "Guy_Reichert@yahoo.com", 3, "Guy", 25.978699287389730m, "3010", true, "Reichert", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 3, 2, 5, 4, 36, 244, DateTimeKind.Unspecified).AddTicks(8356), "Garson" },
                    { 38, "ef47c999-718f-46f6-bb26-821a17acf8bd", null, 3, "Flora35@yahoo.com", 3, "Flora", 27.017441181008440m, "6973", true, "Cartwright", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 6, 18, 13, 27, 35, 629, DateTimeKind.Unspecified).AddTicks(1717), "Garson" },
                    { 37, "d1f937e2-9636-4e34-ae03-8f519c74f6b4", null, 3, "Irma19@yahoo.com", 3, "Irma", 27.827687537217370m, "4845", true, "Bogisich", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 12, 1, 0, 47, 42, 218, DateTimeKind.Unspecified).AddTicks(6840), "Garson" },
                    { 28, "b77dbdfd-3760-426c-94e6-93e0084c5475", null, 3, "Christina.Stracke77@gmail.com", 3, "Christina", 24.149962339620090m, "6003", true, "Stracke", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 9, 18, 21, 24, 11, 217, DateTimeKind.Unspecified).AddTicks(2272), "Aşçı" },
                    { 27, "0e0376f3-e53d-4124-8891-1a154f6306d4", null, 3, "Janie_Feil16@gmail.com", 3, "Janie", 21.351232436183480m, "6206", true, "Feil", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 4, 15, 0, 49, 38, 223, DateTimeKind.Unspecified).AddTicks(6805), "Aşçı" },
                    { 26, "72bb2a5a-37a9-459c-a44a-1c5ffcf3f25a", null, 3, "Anthony_Corkery@hotmail.com", 3, "Anthony", 26.589826679131870m, "2325", true, "Corkery", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 11, 22, 8, 46, 4, 319, DateTimeKind.Unspecified).AddTicks(5099), "Aşçı" },
                    { 25, "bccbf7f9-4692-4c99-b4fa-039ff3ac9acb", null, 3, "Carmen31@hotmail.com", 3, "Carmen", 28.168016415167610m, "9688", true, "Nienow", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 8, 13, 21, 35, 10, 578, DateTimeKind.Unspecified).AddTicks(9263), "Aşçı" },
                    { 18, "631bcd2a-a888-465d-92fa-cdd3917538c1", null, 1, "Heather.Wuckert@yahoo.com", 3, "Heather", 24.922303503808710m, "8111", true, "Wuckert", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2022, 1, 29, 19, 4, 3, 763, DateTimeKind.Unspecified).AddTicks(8022), "Temizlik Görevlisi" },
                    { 16, "95492ce8-841a-43a2-84b2-f683ce1ee634", null, 1, "Ella49@hotmail.com", 3, "Ella", 24.74720865243450m, "7624", true, "Beatty", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2020, 8, 17, 23, 47, 13, 946, DateTimeKind.Unspecified).AddTicks(7449), "Temizlik Görevlisi" },
                    { 15, "0673e3a9-d62c-4a0d-b1d7-73caa081fa50", null, 1, "Abel63@gmail.com", 3, "Abel", 29.192401426468230m, "6371", true, "Reynolds", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 3, 28, 0, 12, 29, 388, DateTimeKind.Unspecified).AddTicks(2741), "Temizlik Görevlisi" },
                    { 14, "ea7342fc-e1ef-47a6-a220-fa9135c30a2b", null, 1, "Priscilla.Rempel53@yahoo.com", 3, "Priscilla", 20.1275551366282420m, "2916", true, "Rempel", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 2, 14, 5, 8, 6, 234, DateTimeKind.Unspecified).AddTicks(4977), "Temizlik Görevlisi" },
                    { 4, "f756ced7-3ef9-412a-94dc-60bfa7d21f7f", null, 4, "Alicia_Johns32@gmail.com", 3, "Alicia", 21.166174361093980m, "4820", true, "Johns", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2019, 11, 12, 15, 19, 6, 758, DateTimeKind.Unspecified).AddTicks(341), "Resepsiyonist" },
                    { 29, "6aa57f41-b80c-4db1-a0ca-3be90c92d757", null, 3, "Dorothy12@gmail.com", 3, "Dorothy", 29.405897864795240m, "1885", true, "Bartoletti", null, null, 0m, 12m, "05454526235", null, 2, new DateTime(2021, 8, 12, 3, 42, 11, 568, DateTimeKind.Unspecified).AddTicks(8958), "Aşçı" },
                    { 11, "fb83e155-239d-4d8c-bceb-c36f15d4dcbe", null, 1, "June44@hotmail.com", 3, "June", 21.801148528140570m, "8766", true, "Nienow", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 2, 4, 23, 24, 1, 899, DateTimeKind.Unspecified).AddTicks(9591), "Temizlik Görevlisi" },
                    { 9, "d72443b1-e09d-407b-a89f-aa9eb12d68bb", null, 1, "Myra_Sanford@gmail.com", 3, "Myra", 20.08356103677468420m, "1765", true, "Sanford", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 7, 25, 6, 40, 15, 693, DateTimeKind.Unspecified).AddTicks(1905), "Temizlik Görevlisi" },
                    { 8, "49bd90aa-aecf-40a9-96c1-63348daaa649", null, 1, "Eunice96@yahoo.com", 3, "Eunice", 27.875614263059390m, "6764", true, "Marquardt", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2021, 7, 30, 4, 23, 16, 768, DateTimeKind.Unspecified).AddTicks(3609), "Temizlik Görevlisi" },
                    { 3, "1671bf5b-88a7-41aa-924b-30b88454d8ce", null, 4, "Suzanne_Waters@hotmail.com", 3, "Suzanne", 24.945367921583990m, "8632", true, "Waters", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2022, 3, 25, 6, 19, 3, 60, DateTimeKind.Unspecified).AddTicks(2562), "Resepsiyonist" },
                    { 2, "7f61ead1-2e40-491b-a56c-c9b94e12d7f2", null, 4, "Adrian.Maggio@gmail.com", 3, "Adrian", 26.129202212267180m, "3782", true, "Maggio", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 29, 12, 35, 48, 231, DateTimeKind.Unspecified).AddTicks(8708), "Resepsiyonist" },
                    { 1, "5dd7d960-1035-4f49-a64c-65601a54f81c", null, 4, "Helen_Orn@hotmail.com", 3, "Helen", 20.7868209810866140m, "4094", true, "Orn", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2019, 3, 25, 15, 9, 44, 99, DateTimeKind.Unspecified).AddTicks(5220), "Resepsiyonist" },
                    { 10, "b3a1be30-48a3-409c-aaa0-f2e642334fa7", null, 1, "Jordan_Ryan27@hotmail.com", 3, "Jordan", 27.310395998559140m, "2479", true, "Ryan", null, null, 0m, 12m, "05454526235", null, 1, new DateTime(2020, 7, 16, 22, 15, 2, 948, DateTimeKind.Unspecified).AddTicks(804), "Temizlik Görevlisi" }
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
