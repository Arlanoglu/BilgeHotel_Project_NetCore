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
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    HourlyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MonthlySalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LeavingWorkDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReasonForLeaving = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmployeeStatus = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
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
                name: "EmployeesShifts",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_EmployeesShifts", x => new { x.EmployeeID, x.ShiftID });
                    table.ForeignKey(
                        name: "FK_EmployeesShifts_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesShifts_Shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "Shifts",
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
                    Month = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                    OverTimeHour = table.Column<TimeSpan>(type: "time", nullable: true),
                    IsHoliday = table.Column<bool>(type: "bit", nullable: false),
                    Holiday = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_WorkSchedules_Shifts_ShiftID",
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
                    CheckInDate = table.Column<DateTime>(type: "date", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "date", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegistrationType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CheckInTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CheckOutTime = table.Column<TimeSpan>(type: "time", nullable: false, defaultValue: new TimeSpan(0, 14, 0, 0, 0)),
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
                name: "Guests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TurkeyCitizen = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IdCardFrontSideImage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IdCardBackSideImage = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
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
                    table.PrimaryKey("PK_Guests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Guests_Registrations_RegistrationID",
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
                    Number = table.Column<int>(type: "int", nullable: false),
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
                    { "3920b0ec-725e-4b34-ab67-27c7f816936d", "4bd1d090-495b-46f8-8242-f55346f9a029", "resepsiyon", "RESEPSİYON" },
                    { "bcf7061b-0a59-426a-9b49-f520e1b4849b", "b217e723-5459-4904-801f-feaf65acdf5f", "admin", "ADMİN" },
                    { "c62f42df-2d75-4102-b281-a8637f2cb0a1", "dce3e625-08d9-420b-b1c0-0c1176edada5", "user", "USER" },
                    { "75d8b242-e230-4fe8-ad20-b8e818d97957", "c775447f-106a-4096-b80d-f8e21dfb8f26", "insankaynaklari", "İNSANKAYNAKLARİ" },
                    { "3a2aebe3-6100-4ece-b2be-8bfec2e2c329", "4a9724bc-0e64-4ea8-9e68-d045e51b906c", "yardimcihizmetler", "YARDİMCİHİZMETLER" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ID", "Adress", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Email", "Facebook", "Fax", "Instagram", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Phone1", "Phone2", "Twitter" },
                values: new object[] { 1, "078 Carter Lake, Lake Aaliyah, Czech Republic", null, null, null, null, null, "Jerome59@yahoo.com", "https://www.facebook.com/bilgehotel", "05454526235", "https://www.instagram.com/bilgehotel", null, null, null, null, null, "05454526235", null, "https://www.twitter.com/bilgehotel" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 5, null, null, null, null, null, "Yönetim", null, null, null, null, null, null },
                    { 6, null, null, null, null, null, "İnsan Kaynakları", null, null, null, null, null, null },
                    { 3, null, null, null, null, null, "Mutfak", null, null, null, null, null, null },
                    { 1, null, null, null, null, null, "Yardımcı Hizmetler", null, null, null, null, null, null },
                    { 4, null, null, null, null, null, "Resepsiyon", null, null, null, null, null, null },
                    { 2, null, null, null, null, null, "Bilgi İşlem", null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ExtraServices",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Price", "ServiceName" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, 600m, "Sauna" });

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
                    { 7, null, null, null, null, null, "Yatak odası, yemek yeme alanına sahip oturma salonu ve iki ayrı banyosuyla 85 m² olan geniş kullanım alanı, şehir ve dağ manzarası ile konforu sunuyor.Rahatlamak ve keyif almak için özel olarak tasarlanan jakuzili banyoda ruhunuzu ve bedeninizi dinlendirebilir, gününüzü keyifle noktalayabilirsiniz.", null, null, null, null, null, 1, 2, 2500m, "Presidential Suite" },
                    { 4, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda üç adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 3, 1500m, "Triple Room" },
                    { 5, null, null, null, null, null, "25 - 30 m² Triple Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet tek kişilik, bir adet iki kişilik yatak bulunmaktadır.", null, null, null, null, null, 2, 3, 1500m, "Triple Superior Room" },
                    { 3, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda iki kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 2, 1050m, "Double Superior Room" },
                    { 2, null, null, null, null, null, "20 - 25 m² Double Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik iki adet yatak bulunmaktadır.", null, null, null, null, null, 2, 2, 1050m, "Double Room" },
                    { 6, null, null, null, null, null, "30 - 35 m² Family Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda bir adet çift kişilik, iki adet tek kişilik yatak bulunmaktadır.", null, null, null, null, null, 3, 4, 1900m, "Family Room" },
                    { 1, null, null, null, null, null, "15 - 20 m² Single Room’da ihtiyaç duyabileceğiniz her şey sizin için düşünülmüştür. Park, şehir ve dağ manzaralı odalar iş ve tatil seyahatleriniz için ideal bir seçenek. Kullanışlı, modern bir tasarıma sahip odalarda tek kişilik bir adet yatak bulunmaktadır.", null, null, null, null, null, 1, 1, 600m, "Single Room" }
                });

            migrationBuilder.InsertData(
                table: "ServicePacks",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PackName", "PackPrice" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Bu pakette sabah kahvaltısı, öğle yemeği ve akşam yemekleri konaklama ücretine dahildir.", null, null, null, null, null, "Tam Pansiyon", 200m },
                    { 2, null, null, null, null, null, "Bu pakette konaklama süresince 3 öğün yemekler, 5 çayı ve atıştırmalıklarla gün boyunca içecekler (alkolsüz içeceklerle - yerli alkollü içecekler) konaklama ücretine dahildir. Otellerdeki aktiviteler bu konseptte dahil değildir.", null, null, null, null, null, "Her Şey Dahil", 500m }
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
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "PhoneNumber", "ReasonForLeaving", "StartDateOfWork", "Title", "UserID" },
                values: new object[,]
                {
                    { 5, null, null, null, null, null, null, 4, "Harold90@yahoo.com", 3, "Harold", 192.970398600665110m, "3143", true, "Hickle", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 1, 19, 19, 52, 0, 56, DateTimeKind.Unspecified).AddTicks(3942), "Resepsiyonist", 0 },
                    { 27, null, null, null, null, null, null, 3, "Hubert_Raynor@hotmail.com", 3, "Hubert", 198.072353935834190m, "7797", true, "Raynor", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 7, 29, 22, 51, 37, 35, DateTimeKind.Unspecified).AddTicks(6585), "Aşçı", 0 },
                    { 28, null, null, null, null, null, null, 3, "Steven.Ritchie@gmail.com", 3, "Steven", 193.552643984347880m, "4622", true, "Ritchie", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 11, 16, 11, 22, 18, 401, DateTimeKind.Unspecified).AddTicks(4472), "Aşçı", 0 },
                    { 29, null, null, null, null, null, null, 3, "Patsy8@gmail.com", 3, "Patsy", 196.860464781923440m, "2538", true, "Ondricka", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 12, 11, 13, 36, 6, 819, DateTimeKind.Unspecified).AddTicks(2008), "Aşçı", 0 },
                    { 30, null, null, null, null, null, null, 3, "Ben_Jacobi48@yahoo.com", 3, "Ben", 190.3813310202124210m, "3539", true, "Jacobi", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 4, 24, 23, 1, 43, 612, DateTimeKind.Unspecified).AddTicks(7438), "Garson", 0 },
                    { 31, null, null, null, null, null, null, 3, "Audrey_Franecki@gmail.com", 3, "Audrey", 190.5507930231051490m, "4175", true, "Franecki", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 10, 16, 6, 11, 55, 143, DateTimeKind.Unspecified).AddTicks(7239), "Garson", 0 },
                    { 32, null, null, null, null, null, null, 3, "Darla.Cummerata@yahoo.com", 3, "Darla", 197.796420505175560m, "3164", true, "Cummerata", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 4, 3, 12, 52, 35, 521, DateTimeKind.Unspecified).AddTicks(241), "Garson", 0 },
                    { 34, null, null, null, null, null, null, 3, "Wilbert_Champlin@hotmail.com", 3, "Wilbert", 197.300378669658850m, "8092", true, "Champlin", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 8, 4, 6, 7, 53, 666, DateTimeKind.Unspecified).AddTicks(3672), "Garson", 0 },
                    { 35, null, null, null, null, null, null, 3, "Alton39@gmail.com", 3, "Alton", 193.771197411125150m, "1679", true, "Ernser", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 6, 7, 8, 17, 59, 347, DateTimeKind.Unspecified).AddTicks(9680), "Garson", 0 },
                    { 36, null, null, null, null, null, null, 3, "Isabel.Renner@yahoo.com", 3, "Isabel", 191.160787656512480m, "3592", true, "Renner", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2022, 1, 26, 17, 10, 0, 119, DateTimeKind.Unspecified).AddTicks(9025), "Garson", 0 },
                    { 37, null, null, null, null, null, null, 3, "Gwen_Kautzer13@yahoo.com", 3, "Gwen", 192.190790377646120m, "2903", true, "Kautzer", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 3, 13, 23, 4, 58, 950, DateTimeKind.Unspecified).AddTicks(3441), "Garson", 0 },
                    { 38, null, null, null, null, null, null, 3, "Guy_Sporer@hotmail.com", 3, "Guy", 193.971531020464160m, "3630", true, "Sporer", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 10, 31, 10, 14, 25, 399, DateTimeKind.Unspecified).AddTicks(8114), "Garson", 0 },
                    { 39, null, null, null, null, null, null, 3, "Sheri_Effertz44@gmail.com", 3, "Sheri", 191.702000602009710m, "7672", true, "Effertz", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 4, 1, 16, 51, 21, 945, DateTimeKind.Unspecified).AddTicks(5101), "Garson", 0 },
                    { 40, null, null, null, null, null, null, 3, "Antonio_Brown@hotmail.com", 3, "Antonio", 191.397884055691720m, "9662", true, "Brown", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 8, 16, 0, 8, 20, 93, DateTimeKind.Unspecified).AddTicks(2439), "Garson", 0 },
                    { 41, null, null, null, null, null, null, 3, "Timmy14@yahoo.com", 3, "Timmy", 199.695814070150170m, "9640", true, "Grady", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2022, 1, 12, 10, 56, 10, 246, DateTimeKind.Unspecified).AddTicks(9916), "Garson", 0 },
                    { 42, null, null, null, null, null, null, 3, "Todd.Kozey20@hotmail.com", 3, "Todd", 199.215161557875180m, "2016", true, "Kozey", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 9, 12, 18, 49, 26, 28, DateTimeKind.Unspecified).AddTicks(4844), "Garson", 0 },
                    { 1, null, null, null, null, null, null, 4, "Cristina58@yahoo.com", 3, "Cristina", 199.83309752300060m, "5792", true, "Fadel", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 9, 8, 12, 2, 52, 951, DateTimeKind.Unspecified).AddTicks(6519), "Resepsiyonist", 0 },
                    { 2, null, null, null, null, null, null, 4, "Leonard28@gmail.com", 3, "Leonard", 194.489049582969890m, "2191", true, "Kuhlman", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 2, 7, 23, 57, 2, 825, DateTimeKind.Unspecified).AddTicks(4252), "Resepsiyonist", 0 },
                    { 3, null, null, null, null, null, null, 4, "Shari91@gmail.com", 3, "Shari", 199.226226689864990m, "6131", true, "Breitenberg", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 4, 2, 19, 24, 56, 751, DateTimeKind.Unspecified).AddTicks(6442), "Resepsiyonist", 0 },
                    { 4, null, null, null, null, null, null, 4, "Kayla.Stark@hotmail.com", 3, "Kayla", 195.030575932483460m, "8011", true, "Stark", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 11, 23, 20, 15, 44, 892, DateTimeKind.Unspecified).AddTicks(8376), "Resepsiyonist", 0 },
                    { 6, null, null, null, null, null, null, 4, "Alexander.Sipes73@yahoo.com", 3, "Alexander", 193.117337717263650m, "2766", true, "Sipes", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 6, 7, 6, 38, 16, 267, DateTimeKind.Unspecified).AddTicks(7769), "Resepsiyonist", 0 },
                    { 7, null, null, null, null, null, null, 4, "Kelvin.Wolf10@hotmail.com", 3, "Kelvin", 198.993333950170010m, "4383", true, "Wolf", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 4, 22, 22, 29, 14, 919, DateTimeKind.Unspecified).AddTicks(7854), "Resepsiyonist", 0 },
                    { 45, null, null, null, null, null, null, 5, "Edith_Metz10@gmail.com", 0, "Edith", 192.835410802082820m, "9292", true, "Metz", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2022, 3, 1, 17, 45, 13, 185, DateTimeKind.Unspecified).AddTicks(8133), "Müdür", 0 },
                    { 46, null, null, null, null, null, null, 6, "Elvira_Veum@hotmail.com", 1, "Elvira", 190.9919454767331230m, "4351", true, "Veum", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 11, 22, 5, 10, 44, 95, DateTimeKind.Unspecified).AddTicks(1640), "İnsan Kaynakları Müdürü", 0 },
                    { 26, null, null, null, null, null, null, 3, "Gene_Denesik@gmail.com", 3, "Gene", 196.785239817940280m, "4589", true, "Denesik", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 2, 23, 19, 7, 18, 299, DateTimeKind.Unspecified).AddTicks(5155), "Aşçı", 0 },
                    { 25, null, null, null, null, null, null, 3, "Dolores33@yahoo.com", 3, "Dolores", 195.032178617563180m, "9732", true, "Mills", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2022, 1, 17, 16, 16, 16, 621, DateTimeKind.Unspecified).AddTicks(3132), "Aşçı", 0 },
                    { 33, null, null, null, null, null, null, 3, "Lori_Lemke@gmail.com", 3, "Lori", 194.833176031165370m, "2976", true, "Lemke", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 1, 8, 5, 23, 52, 582, DateTimeKind.Unspecified).AddTicks(421), "Garson", 0 },
                    { 23, null, null, null, null, null, null, 3, "Jane.Kunde@hotmail.com", 3, "Jane", 197.086754272266640m, "5357", true, "Kunde", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 9, 16, 20, 6, 11, 857, DateTimeKind.Unspecified).AddTicks(8166), "Aşçı", 0 },
                    { 24, null, null, null, null, null, null, 3, "Janet_Swift37@gmail.com", 3, "Janet", 194.224104277893950m, "7874", true, "Swift", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 7, 31, 19, 31, 46, 47, DateTimeKind.Unspecified).AddTicks(4048), "Aşçı", 0 },
                    { 8, null, null, null, null, null, null, 1, "Laverne_Ortiz@yahoo.com", 3, "Laverne", 193.917284451386560m, "1909", true, "Ortiz", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 9, 19, 3, 49, 11, 437, DateTimeKind.Unspecified).AddTicks(1247), "Temizlik Görevlisi", 0 },
                    { 9, null, null, null, null, null, null, 1, "Virginia.Metz92@gmail.com", 3, "Virginia", 197.302365595149980m, "8554", true, "Metz", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 6, 26, 22, 12, 25, 246, DateTimeKind.Unspecified).AddTicks(4545), "Temizlik Görevlisi", 0 },
                    { 10, null, null, null, null, null, null, 1, "Ida70@yahoo.com", 3, "Ida", 191.894776952403960m, "3851", true, "Gottlieb", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2022, 3, 3, 14, 13, 29, 832, DateTimeKind.Unspecified).AddTicks(9244), "Temizlik Görevlisi", 0 },
                    { 11, null, null, null, null, null, null, 1, "Stacy.Lakin56@gmail.com", 3, "Stacy", 190.236663380747970m, "8198", true, "Lakin", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 8, 18, 8, 54, 7, 231, DateTimeKind.Unspecified).AddTicks(5596), "Temizlik Görevlisi", 0 },
                    { 13, null, null, null, null, null, null, 1, "Kim59@yahoo.com", 3, "Kim", 192.955089981181120m, "3914", true, "Mitchell", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 9, 18, 0, 9, 50, 878, DateTimeKind.Unspecified).AddTicks(4550), "Temizlik Görevlisi", 0 },
                    { 14, null, null, null, null, null, null, 1, "Ronnie.Welch@yahoo.com", 3, "Ronnie", 190.02714888193977480m, "2640", true, "Welch", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 9, 11, 3, 34, 46, 984, DateTimeKind.Unspecified).AddTicks(1768), "Temizlik Görevlisi", 0 },
                    { 15, null, null, null, null, null, null, 1, "Lynda89@hotmail.com", 3, "Lynda", 193.504294726766780m, "4404", true, "Little", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 11, 17, 22, 15, 53, 160, DateTimeKind.Unspecified).AddTicks(5341), "Temizlik Görevlisi", 0 },
                    { 16, null, null, null, null, null, null, 1, "Wilfred.Terry@gmail.com", 3, "Wilfred", 196.45776043946750m, "6070", true, "Terry", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 12, 31, 10, 42, 50, 938, DateTimeKind.Unspecified).AddTicks(9146), "Temizlik Görevlisi", 0 },
                    { 12, null, null, null, null, null, null, 1, "Ricky41@hotmail.com", 3, "Ricky", 193.848237713728210m, "4757", true, "Franecki", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 1, 7, 16, 43, 32, 136, DateTimeKind.Unspecified).AddTicks(1819), "Temizlik Görevlisi", 0 },
                    { 18, null, null, null, null, null, null, 1, "Marie23@yahoo.com", 3, "Marie", 191.973338998841750m, "2806", true, "Reichel", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2021, 9, 29, 23, 50, 9, 992, DateTimeKind.Unspecified).AddTicks(205), "Temizlik Görevlisi", 0 },
                    { 43, null, null, null, null, null, null, 1, "Edmund.Olson@hotmail.com", 3, "Edmund", 193.062750847573740m, "4495", true, "Olson", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 4, 10, 9, 46, 48, 313, DateTimeKind.Unspecified).AddTicks(7501), "Elektirikçi", 0 },
                    { 44, null, null, null, null, null, null, 2, "Clark.Klocko85@gmail.com", 3, "Clark", 199.440064956173330m, "7348", true, "Klocko", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 9, 15, 6, 16, 40, 857, DateTimeKind.Unspecified).AddTicks(3755), "Bilgi İşlem Sorumlusu", 0 },
                    { 19, null, null, null, null, null, null, 3, "Elisa.Grady@gmail.com", 3, "Elisa", 194.206947560518490m, "2250", true, "Grady", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 6, 19, 22, 36, 52, 941, DateTimeKind.Unspecified).AddTicks(4423), "Aşçı", 0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "AppUserId", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "DepartmentID", "Email", "EmployeeStatus", "FirstName", "HourlyRate", "IdentificationNumber", "IsActive", "LastName", "LeavingWorkDate", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "MonthlySalary", "PhoneNumber", "ReasonForLeaving", "StartDateOfWork", "Title", "UserID" },
                values: new object[,]
                {
                    { 20, null, null, null, null, null, null, 3, "Todd68@gmail.com", 3, "Todd", 193.864532049682240m, "6543", true, "Dickinson", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 11, 5, 9, 52, 42, 911, DateTimeKind.Unspecified).AddTicks(8358), "Aşçı", 0 },
                    { 21, null, null, null, null, null, null, 3, "Sophie57@gmail.com", 3, "Sophie", 195.932842048785110m, "5670", true, "Conroy", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 6, 22, 18, 43, 58, 156, DateTimeKind.Unspecified).AddTicks(6409), "Aşçı", 0 },
                    { 17, null, null, null, null, null, null, 1, "Danielle.Bartell@hotmail.com", 3, "Danielle", 198.93967993973740m, "1533", true, "Bartell", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2019, 12, 6, 11, 50, 39, 880, DateTimeKind.Unspecified).AddTicks(333), "Temizlik Görevlisi", 0 },
                    { 22, null, null, null, null, null, null, 3, "Francisco1@yahoo.com", 3, "Francisco", 195.491105851480320m, "8885", true, "Swaniawski", null, null, null, null, null, null, null, "05454526235", null, new DateTime(2020, 8, 27, 11, 9, 46, 554, DateTimeKind.Unspecified).AddTicks(3876), "Aşçı", 0 }
                });

            migrationBuilder.InsertData(
                table: "FacilitiesOfRooms",
                columns: new[] { "RoomFacilityID", "RoomTypeID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 5, 4, null, null, null, null, null, null, null, null, null, null },
                    { 1, 5, null, null, null, null, null, null, null, null, null, null },
                    { 2, 5, null, null, null, null, null, null, null, null, null, null },
                    { 3, 5, null, null, null, null, null, null, null, null, null, null },
                    { 6, 5, null, null, null, null, null, null, null, null, null, null },
                    { 5, 5, null, null, null, null, null, null, null, null, null, null },
                    { 1, 2, null, null, null, null, null, null, null, null, null, null },
                    { 1, 6, null, null, null, null, null, null, null, null, null, null },
                    { 4, 5, null, null, null, null, null, null, null, null, null, null },
                    { 2, 2, null, null, null, null, null, null, null, null, null, null },
                    { 1, 4, null, null, null, null, null, null, null, null, null, null },
                    { 4, 2, null, null, null, null, null, null, null, null, null, null },
                    { 5, 2, null, null, null, null, null, null, null, null, null, null },
                    { 4, 4, null, null, null, null, null, null, null, null, null, null },
                    { 3, 3, null, null, null, null, null, null, null, null, null, null },
                    { 4, 3, null, null, null, null, null, null, null, null, null, null },
                    { 5, 3, null, null, null, null, null, null, null, null, null, null },
                    { 6, 3, null, null, null, null, null, null, null, null, null, null },
                    { 3, 4, null, null, null, null, null, null, null, null, null, null },
                    { 2, 4, null, null, null, null, null, null, null, null, null, null },
                    { 2, 6, null, null, null, null, null, null, null, null, null, null },
                    { 3, 2, null, null, null, null, null, null, null, null, null, null },
                    { 3, 6, null, null, null, null, null, null, null, null, null, null },
                    { 1, 3, null, null, null, null, null, null, null, null, null, null },
                    { 5, 6, null, null, null, null, null, null, null, null, null, null },
                    { 2, 3, null, null, null, null, null, null, null, null, null, null },
                    { 6, 7, null, null, null, null, null, null, null, null, null, null },
                    { 4, 6, null, null, null, null, null, null, null, null, null, null },
                    { 2, 1, null, null, null, null, null, null, null, null, null, null },
                    { 3, 1, null, null, null, null, null, null, null, null, null, null },
                    { 4, 1, null, null, null, null, null, null, null, null, null, null },
                    { 5, 7, null, null, null, null, null, null, null, null, null, null },
                    { 1, 1, null, null, null, null, null, null, null, null, null, null },
                    { 3, 7, null, null, null, null, null, null, null, null, null, null },
                    { 4, 7, null, null, null, null, null, null, null, null, null, null },
                    { 1, 7, null, null, null, null, null, null, null, null, null, null },
                    { 6, 6, null, null, null, null, null, null, null, null, null, null },
                    { 2, 7, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "HomePageSlides",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "HomePageID", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PictureName", "PictureUrl" },
                values: new object[,]
                {
                    { 3, null, null, null, null, null, 1, null, null, null, null, null, "Slide3", "https://www.almira.com.tr/images/gallery/almira/07.jpg" },
                    { 2, null, null, null, null, null, 1, null, null, null, null, null, "Slide2", "https://www.almira.com.tr/images/gallery/almira/04.jpg" },
                    { 1, null, null, null, null, null, 1, null, null, null, null, null, "Slide1", "https://www.almira.com.tr/images/genel1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "ID", "AboutusID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PictureName", "PictureUrl" },
                values: new object[,]
                {
                    { 7, 1, null, null, null, null, null, null, null, null, null, null, "Görsel7", "/img/gallery/room-presidential-suite.jpg" },
                    { 6, 1, null, null, null, null, null, null, null, null, null, null, "Görsel6", "/img/gallery/room-family.jpg" },
                    { 5, 1, null, null, null, null, null, null, null, null, null, null, "Görsel5", "/img/gallery/room-triple-superrior.jpg" },
                    { 4, 1, null, null, null, null, null, null, null, null, null, null, "Görsel4", "/img/gallery/room-triple.jpg" },
                    { 3, 1, null, null, null, null, null, null, null, null, null, null, "Görsel3", "/img/gallery/room-double-superrior.jpg" },
                    { 2, 1, null, null, null, null, null, null, null, null, null, null, "Görsel2", "/img/gallery/room-double.jpg" },
                    { 1, 1, null, null, null, null, null, null, null, null, null, null, "Görsel1", "/img/gallery/room-single.jpg" }
                });

            migrationBuilder.InsertData(
                table: "RoomPictures",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "PictureUrl", "RoomTypeID" },
                values: new object[,]
                {
                    { 5, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-triple-superrior.jpg", 5 },
                    { 6, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-family.jpg", 6 },
                    { 4, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-triple.jpg", 4 },
                    { 3, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-double-superrior.jpg", 3 },
                    { 7, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-presidential-suite.jpg", 7 },
                    { 2, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-double.jpg", 2 },
                    { 1, null, null, null, null, null, null, null, null, null, null, "/img/roomtypes/room-single.jpg", 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 58, null, null, null, null, null, null, 3, null, null, null, null, null, "157", 5, 5 },
                    { 57, null, null, null, null, null, null, 3, null, null, null, null, null, "156", 5, 5 },
                    { 56, null, null, null, null, null, null, 3, null, null, null, null, null, "155", 5, 5 },
                    { 55, null, null, null, null, null, null, 3, null, null, null, null, null, "154", 5, 5 },
                    { 54, null, null, null, null, null, null, 3, null, null, null, null, null, "153", 5, 5 },
                    { 53, null, null, null, null, null, null, 3, null, null, null, null, null, "152", 5, 5 },
                    { 52, null, null, null, null, null, null, 3, null, null, null, null, null, "151", 5, 5 },
                    { 51, null, null, null, null, null, null, 3, null, null, null, null, null, "150", 5, 5 },
                    { 24, null, null, null, null, null, null, 2, null, null, null, null, null, "123", 5, 1 },
                    { 25, null, null, null, null, null, null, 2, null, null, null, null, null, "124", 5, 1 },
                    { 26, null, null, null, null, null, null, 2, null, null, null, null, null, "125", 5, 1 },
                    { 27, null, null, null, null, null, null, 2, null, null, null, null, null, "126", 5, 1 },
                    { 28, null, null, null, null, null, null, 2, null, null, null, null, null, "127", 5, 1 },
                    { 29, null, null, null, null, null, null, 2, null, null, null, null, null, "128", 5, 1 },
                    { 30, null, null, null, null, null, null, 2, null, null, null, null, null, "129", 5, 1 },
                    { 59, null, null, null, null, null, null, 3, null, null, null, null, null, "158", 5, 5 },
                    { 60, null, null, null, null, null, null, 3, null, null, null, null, null, "159", 5, 5 },
                    { 23, null, null, null, null, null, null, 2, null, null, null, null, null, "122", 5, 1 },
                    { 22, null, null, null, null, null, null, 2, null, null, null, null, null, "121", 5, 1 },
                    { 1, null, null, null, null, null, null, 1, null, null, null, null, null, "100", 5, 1 },
                    { 2, null, null, null, null, null, null, 1, null, null, null, null, null, "101", 5, 1 },
                    { 3, null, null, null, null, null, null, 1, null, null, null, null, null, "102", 5, 1 },
                    { 4, null, null, null, null, null, null, 1, null, null, null, null, null, "103", 5, 1 },
                    { 5, null, null, null, null, null, null, 1, null, null, null, null, null, "104", 5, 1 },
                    { 6, null, null, null, null, null, null, 1, null, null, null, null, null, "105", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 76, null, null, null, null, null, null, 4, null, null, null, null, null, "175", 5, 6 },
                    { 75, null, null, null, null, null, null, 4, null, null, null, null, null, "174", 5, 6 },
                    { 74, null, null, null, null, null, null, 4, null, null, null, null, null, "173", 5, 6 },
                    { 73, null, null, null, null, null, null, 4, null, null, null, null, null, "172", 5, 6 },
                    { 72, null, null, null, null, null, null, 4, null, null, null, null, null, "171", 5, 6 },
                    { 71, null, null, null, null, null, null, 4, null, null, null, null, null, "170", 5, 6 },
                    { 7, null, null, null, null, null, null, 1, null, null, null, null, null, "106", 5, 1 },
                    { 8, null, null, null, null, null, null, 1, null, null, null, null, null, "107", 5, 1 },
                    { 9, null, null, null, null, null, null, 1, null, null, null, null, null, "108", 5, 1 },
                    { 10, null, null, null, null, null, null, 1, null, null, null, null, null, "109", 5, 1 },
                    { 21, null, null, null, null, null, null, 2, null, null, null, null, null, "120", 5, 1 },
                    { 20, null, null, null, null, null, null, 1, null, null, null, null, null, "119", 5, 4 },
                    { 40, null, null, null, null, null, null, 2, null, null, null, null, null, "139", 5, 2 },
                    { 19, null, null, null, null, null, null, 1, null, null, null, null, null, "118", 5, 4 },
                    { 17, null, null, null, null, null, null, 1, null, null, null, null, null, "116", 5, 4 },
                    { 61, null, null, null, null, null, null, 4, null, null, null, null, null, "160", 5, 3 },
                    { 50, null, null, null, null, null, null, 3, null, null, null, null, null, "149", 5, 3 },
                    { 49, null, null, null, null, null, null, 3, null, null, null, null, null, "148", 5, 3 },
                    { 48, null, null, null, null, null, null, 3, null, null, null, null, null, "147", 5, 3 },
                    { 47, null, null, null, null, null, null, 3, null, null, null, null, null, "146", 5, 3 },
                    { 46, null, null, null, null, null, null, 3, null, null, null, null, null, "145", 5, 3 },
                    { 45, null, null, null, null, null, null, 3, null, null, null, null, null, "144", 5, 3 },
                    { 44, null, null, null, null, null, null, 3, null, null, null, null, null, "143", 5, 3 },
                    { 43, null, null, null, null, null, null, 3, null, null, null, null, null, "142", 5, 3 },
                    { 42, null, null, null, null, null, null, 3, null, null, null, null, null, "141", 5, 3 },
                    { 41, null, null, null, null, null, null, 3, null, null, null, null, null, "140", 5, 3 },
                    { 36, null, null, null, null, null, null, 2, null, null, null, null, null, "135", 5, 2 },
                    { 37, null, null, null, null, null, null, 2, null, null, null, null, null, "136", 5, 2 },
                    { 38, null, null, null, null, null, null, 2, null, null, null, null, null, "137", 5, 2 },
                    { 39, null, null, null, null, null, null, 2, null, null, null, null, null, "138", 5, 2 },
                    { 62, null, null, null, null, null, null, 4, null, null, null, null, null, "161", 5, 3 },
                    { 18, null, null, null, null, null, null, 1, null, null, null, null, null, "117", 5, 4 },
                    { 63, null, null, null, null, null, null, 4, null, null, null, null, null, "162", 5, 3 },
                    { 65, null, null, null, null, null, null, 4, null, null, null, null, null, "164", 5, 3 },
                    { 16, null, null, null, null, null, null, 1, null, null, null, null, null, "115", 5, 4 },
                    { 15, null, null, null, null, null, null, 1, null, null, null, null, null, "114", 5, 4 },
                    { 14, null, null, null, null, null, null, 1, null, null, null, null, null, "113", 5, 4 },
                    { 13, null, null, null, null, null, null, 1, null, null, null, null, null, "112", 5, 4 },
                    { 12, null, null, null, null, null, null, 1, null, null, null, null, null, "111", 5, 4 },
                    { 11, null, null, null, null, null, null, 1, null, null, null, null, null, "110", 5, 4 },
                    { 31, null, null, null, null, null, null, 2, null, null, null, null, null, "130", 5, 2 },
                    { 64, null, null, null, null, null, null, 4, null, null, null, null, null, "163", 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "FloorNumber", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "RoomNumber", "RoomStatus", "RoomTypeID" },
                values: new object[,]
                {
                    { 32, null, null, null, null, null, null, 2, null, null, null, null, null, "131", 5, 2 },
                    { 34, null, null, null, null, null, null, 2, null, null, null, null, null, "133", 5, 2 },
                    { 35, null, null, null, null, null, null, 2, null, null, null, null, null, "134", 5, 2 },
                    { 70, null, null, null, null, null, null, 4, null, null, null, null, null, "169", 5, 3 },
                    { 69, null, null, null, null, null, null, 4, null, null, null, null, null, "168", 5, 3 },
                    { 68, null, null, null, null, null, null, 4, null, null, null, null, null, "167", 5, 3 },
                    { 67, null, null, null, null, null, null, 4, null, null, null, null, null, "166", 5, 3 },
                    { 66, null, null, null, null, null, null, 4, null, null, null, null, null, "165", 5, 3 },
                    { 77, null, null, null, null, null, null, 4, null, null, null, null, null, "176", 5, 7 },
                    { 33, null, null, null, null, null, null, 2, null, null, null, null, null, "132", 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "ID", "AboutusID", "ContactID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "HomePageID", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "SmtpEmail", "SmtpHost", "SmtpPassword", "SmtpPort" },
                values: new object[] { 1, 1, 1, null, null, null, null, null, 1, null, null, null, null, null, "the.mstfa@gmail.com", "smtp.gmail.com", "Mustafa.2525774", 587 });

            migrationBuilder.InsertData(
                table: "EmployeesShifts",
                columns: new[] { "EmployeeID", "ShiftID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 8, 1, null, null, null, null, null, null, null, null, null, null },
                    { 30, 1, null, null, null, null, null, null, null, null, null, null },
                    { 31, 1, null, null, null, null, null, null, null, null, null, null },
                    { 32, 1, null, null, null, null, null, null, null, null, null, null },
                    { 33, 1, null, null, null, null, null, null, null, null, null, null },
                    { 34, 1, null, null, null, null, null, null, null, null, null, null },
                    { 35, 1, null, null, null, null, null, null, null, null, null, null },
                    { 36, 1, null, null, null, null, null, null, null, null, null, null },
                    { 37, 2, null, null, null, null, null, null, null, null, null, null },
                    { 39, 2, null, null, null, null, null, null, null, null, null, null },
                    { 40, 2, null, null, null, null, null, null, null, null, null, null },
                    { 41, 2, null, null, null, null, null, null, null, null, null, null },
                    { 42, 2, null, null, null, null, null, null, null, null, null, null },
                    { 1, 1, null, null, null, null, null, null, null, null, null, null },
                    { 2, 1, null, null, null, null, null, null, null, null, null, null },
                    { 3, 1, null, null, null, null, null, null, null, null, null, null },
                    { 4, 2, null, null, null, null, null, null, null, null, null, null },
                    { 5, 2, null, null, null, null, null, null, null, null, null, null },
                    { 6, 3, null, null, null, null, null, null, null, null, null, null },
                    { 7, 3, null, null, null, null, null, null, null, null, null, null },
                    { 29, 2, null, null, null, null, null, null, null, null, null, null },
                    { 28, 2, null, null, null, null, null, null, null, null, null, null },
                    { 38, 2, null, null, null, null, null, null, null, null, null, null },
                    { 26, 2, null, null, null, null, null, null, null, null, null, null },
                    { 9, 1, null, null, null, null, null, null, null, null, null, null },
                    { 10, 1, null, null, null, null, null, null, null, null, null, null },
                    { 11, 1, null, null, null, null, null, null, null, null, null, null },
                    { 12, 1, null, null, null, null, null, null, null, null, null, null },
                    { 13, 1, null, null, null, null, null, null, null, null, null, null },
                    { 27, 2, null, null, null, null, null, null, null, null, null, null },
                    { 14, 2, null, null, null, null, null, null, null, null, null, null },
                    { 16, 2, null, null, null, null, null, null, null, null, null, null },
                    { 17, 2, null, null, null, null, null, null, null, null, null, null },
                    { 18, 2, null, null, null, null, null, null, null, null, null, null },
                    { 15, 2, null, null, null, null, null, null, null, null, null, null },
                    { 20, 1, null, null, null, null, null, null, null, null, null, null },
                    { 44, 1, null, null, null, null, null, null, null, null, null, null },
                    { 25, 2, null, null, null, null, null, null, null, null, null, null },
                    { 24, 1, null, null, null, null, null, null, null, null, null, null },
                    { 23, 1, null, null, null, null, null, null, null, null, null, null },
                    { 19, 1, null, null, null, null, null, null, null, null, null, null },
                    { 22, 1, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "EmployeesShifts",
                columns: new[] { "EmployeeID", "ShiftID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername" },
                values: new object[,]
                {
                    { 43, 1, null, null, null, null, null, null, null, null, null, null },
                    { 21, 1, null, null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "HotelServices",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "IconPicture", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "ServiceName", "SettingID" },
                values: new object[,]
                {
                    { 7, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/hizli-c-in-c-out.jpg", null, null, null, null, null, "Hızlı C in / C out", 1 },
                    { 13, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/ucretsiz-acik-kapali-otopark.jpg", null, null, null, null, null, "Ücretsiz Açık / Kapalı Otopark", 1 },
                    { 9, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/bebek-karyolasi.jpg", null, null, null, null, null, "Bebek Karyolası", 1 },
                    { 10, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/aile-odasi.jpg", null, null, null, null, null, "Aile Odası", 1 },
                    { 11, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/sicak-kahvalti.jpg", null, null, null, null, null, "Sıcak Kahvaltı", 1 },
                    { 12, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/merkezi-konum.jpg", null, null, null, null, null, "Merkezi Konum", 1 },
                    { 6, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/bagaj-depolama.jpg", null, null, null, null, null, "Bagaj Depolama", 1 },
                    { 8, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/kuru-temizleme.jpg", null, null, null, null, null, "Kuru Temizleme", 1 },
                    { 5, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/toplanti-olanaklari-max-10.jpg", null, null, null, null, null, "Toplantı Olanakları", 1 },
                    { 15, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/cay-kahve-hizmeti.jpg", null, null, null, null, null, "Çay - Kahve Hizmeti", 1 },
                    { 3, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/camasir-yikama.jpg", null, null, null, null, null, "Çamaşır Yıkama", 1 },
                    { 2, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/ucretsiz-wi-fi.jpg", null, null, null, null, null, "Ücretsiz Wifi", 1 },
                    { 1, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/oda-servisi.jpg", null, null, null, null, null, "Oda Servisi", 1 },
                    { 14, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/utu-hizmeti.jpg", null, null, null, null, null, "Ütü Hizmeti", 1 },
                    { 4, null, null, null, null, null, null, "https://roof264.com/media/image/mobil/oda-ici-kasa.jpg", null, null, null, null, null, "Kasa", 1 }
                });

            migrationBuilder.InsertData(
                table: "Salaries",
                columns: new[] { "ID", "BeenPaid", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Description", "EmployeeID", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "Month", "MonthlySalary", "PaymentDate" },
                values: new object[,]
                {
                    { 2, true, null, null, null, null, null, null, 2, null, null, null, null, null, "Şubat", 5500m, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, false, null, null, null, null, null, null, 1, null, null, null, null, null, "Mart", 5000m, null },
                    { 1, true, null, null, null, null, null, null, 1, null, null, null, null, null, "Şubat", 5000m, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, false, null, null, null, null, null, null, 2, null, null, null, null, null, "Mart", 5500m, null }
                });

            migrationBuilder.InsertData(
                table: "WorkSchedules",
                columns: new[] { "ID", "CreatedBy", "CreatedComputerName", "CreatedDate", "CreatedIP", "CreatedUserName", "Date", "Description", "EmployeeID", "HaveOverTime", "Holiday", "IsHoliday", "ModifiedBy", "ModifiedComputerName", "ModifiedDate", "ModifiedIP", "ModifiedUsername", "OverTimeHour", "ShiftID", "TimesWorked", "TotalWorkTime" },
                values: new object[,]
                {
                    { 2, null, null, null, null, null, new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, null, false, null, null, null, null, null, null, 1, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 1, null, null, null, null, null, new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 2, true, null, null, null, null, null, null, 1, new TimeSpan(0, 8, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) }
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
                name: "IX_EmployeesShifts_ShiftID",
                table: "EmployeesShifts",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitiesOfRooms_RoomTypeID",
                table: "FacilitiesOfRooms",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_RegistrationID",
                table: "Guests",
                column: "RegistrationID");

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkSchedules_ShiftID",
                table: "WorkSchedules",
                column: "ShiftID");
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
                name: "Guests");

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
                name: "Settings");

            migrationBuilder.DropTable(
                name: "ExtraServices");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Shifts");

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
                name: "RoomTypes");
        }
    }
}
