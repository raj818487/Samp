using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SAMP.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccReqStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccReqStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AIType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Amenity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsBoolean = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<int>(type: "integer", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<int>(type: "integer", nullable: false),
                    TwoFactorEnabled = table.Column<int>(type: "integer", nullable: false),
                    LockoutEnd = table.Column<string>(type: "text", nullable: true),
                    LockoutEnabled = table.Column<int>(type: "integer", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                    CounterId = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    UtsavId = table.Column<int>(type: "integer", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    ConsentedAt = table.Column<string>(type: "text", nullable: true),
                    SevaDepartment = table.Column<string>(type: "text", nullable: true),
                    EnforceChangePassword = table.Column<int>(type: "integer", nullable: false),
                    BookingPrefix = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Continent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataProtectionKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FriendlyName = table.Column<string>(type: "text", nullable: true),
                    Xml = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataProtectionKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "text", nullable: false),
                    DeviceCode = table.Column<string>(type: "text", nullable: false),
                    SubjectId = table.Column<string>(type: "text", nullable: true),
                    SessionId = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreationTime = table.Column<string>(type: "text", nullable: false),
                    Expiration = table.Column<string>(type: "text", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<string>(type: "text", nullable: false),
                    Use = table.Column<string>(type: "text", nullable: true),
                    Algorithm = table.Column<string>(type: "text", nullable: false),
                    IsX509Certificate = table.Column<int>(type: "integer", nullable: false),
                    DataProtected = table.Column<int>(type: "integer", nullable: false),
                    Data = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemCache",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    AbsoluteExpiration = table.Column<string>(type: "text", nullable: true),
                    AbsoluteExpirationRelativeToNow = table.Column<string>(type: "text", nullable: true),
                    SlidingExpiration = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemCache", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    SubjectId = table.Column<string>(type: "text", nullable: true),
                    SessionId = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreationTime = table.Column<string>(type: "text", nullable: false),
                    Expiration = table.Column<string>(type: "text", nullable: true),
                    ConsumedTime = table.Column<string>(type: "text", nullable: true),
                    Data = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SQL = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReqTransMode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReqTransMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestMode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomGroupType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomGroupType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AITypeAmenity",
                columns: table => new
                {
                    AITypeId = table.Column<int>(type: "integer", nullable: false),
                    AmenityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AITypeAmenity", x => new { x.AITypeId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_AITypeAmenity_AIType_AITypeId",
                        column: x => x.AITypeId,
                        principalTable: "AIType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AITypeAmenity_Amenity_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "Utsav",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsMandir = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Address1 = table.Column<string>(type: "text", nullable: true),
                    Address2 = table.Column<string>(type: "text", nullable: true),
                    Address3 = table.Column<string>(type: "text", nullable: true),
                    AreaOrMilestone = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    StartsOn = table.Column<string>(type: "text", nullable: false),
                    EndsOn = table.Column<string>(type: "text", nullable: false),
                    DefaultArrivalAt = table.Column<string>(type: "text", nullable: true),
                    DefaultDepartureAt = table.Column<string>(type: "text", nullable: true),
                    WebAccReqPrefix = table.Column<string>(type: "text", nullable: true),
                    LastDownloadedWebAccReqId = table.Column<int>(type: "integer", nullable: true),
                    Lat = table.Column<decimal>(type: "numeric(12,8)", nullable: true),
                    Long = table.Column<decimal>(type: "numeric(12,8)", nullable: true),
                    LocationUrl = table.Column<string>(type: "text", nullable: true),
                    IsClosed = table.Column<int>(type: "integer", nullable: false),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true),
                    StandardCheckinTime = table.Column<string>(type: "text", nullable: true),
                    StandardCheckoutTime = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utsav", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utsav_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utsav_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    ContinentId = table.Column<int>(type: "integer", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Continent_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<string>(type: "text", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: false),
                    Src = table.Column<string>(type: "text", nullable: true),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_ImageType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ImageType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AITypeInventory",
                columns: table => new
                {
                    AITypeId = table.Column<int>(type: "integer", nullable: false),
                    InventoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AITypeInventory", x => new { x.AITypeId, x.InventoryId });
                    table.ForeignKey(
                        name: "FK_AITypeInventory_AIType_AITypeId",
                        column: x => x.AITypeId,
                        principalTable: "AIType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AITypeInventory_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportRoles",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportRoles", x => new { x.ReportId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_ReportRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportRoles_Report_ReportId",
                        column: x => x.ReportId,
                        principalTable: "Report",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoomGroupType",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RGTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_UserRoomGroupType_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoomGroupType_RoomGroupType_RGTypeId",
                        column: x => x.RGTypeId,
                        principalTable: "RoomGroupType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: true),
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    IsSatsangi = table.Column<int>(type: "integer", nullable: false),
                    PrimaryMobile = table.Column<string>(type: "text", nullable: false),
                    IsPriMobWhatsApp = table.Column<int>(type: "integer", nullable: false),
                    BackupMobile = table.Column<string>(type: "text", nullable: true),
                    IsBkpMobWhatsApp = table.Column<int>(type: "integer", nullable: true),
                    Landline1 = table.Column<string>(type: "text", nullable: true),
                    Landline2 = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    AddressLine1 = table.Column<string>(type: "text", nullable: true),
                    AddressLine2 = table.Column<string>(type: "text", nullable: true),
                    AddressLine3 = table.Column<string>(type: "text", nullable: true),
                    AreaOrMilestone = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Counter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Alias = table.Column<string>(type: "text", nullable: true),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counter_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Counter_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Counter_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: true),
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    RGTypeId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NegCheckInTime = table.Column<string>(type: "text", nullable: true),
                    NegCheckOutTime = table.Column<string>(type: "text", nullable: true),
                    MinOccupancyRoomCount = table.Column<int>(type: "integer", nullable: true),
                    CancellationNoticeHours = table.Column<decimal>(type: "numeric(5,2)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "text", nullable: true),
                    AddressLine2 = table.Column<string>(type: "text", nullable: true),
                    AddressLine3 = table.Column<string>(type: "text", nullable: true),
                    AreaOrMilestone = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    IsPermanent = table.Column<int>(type: "integer", nullable: false),
                    MandirUtsavId = table.Column<int>(type: "integer", nullable: true),
                    Lat = table.Column<decimal>(type: "numeric(12,8)", nullable: true),
                    Long = table.Column<decimal>(type: "numeric(12,8)", nullable: true),
                    LocationUrl = table.Column<string>(type: "text", nullable: true),
                    UtsavDistance = table.Column<double>(type: "double precision", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    AvailableFrom = table.Column<string>(type: "text", nullable: true),
                    AvailableUpto = table.Column<string>(type: "text", nullable: true),
                    LocationQuality = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true),
                    IsReadOnly = table.Column<int>(type: "integer", nullable: true),
                    DisplayId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomGroup_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroup_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroup_RoomGroupType_RGTypeId",
                        column: x => x.RGTypeId,
                        principalTable: "RoomGroupType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroup_Utsav_MandirUtsavId",
                        column: x => x.MandirUtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroup_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WebAccReq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    WebReqId = table.Column<string>(type: "text", nullable: false),
                    Honorific = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    NativePlace = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Mobile = table.Column<string>(type: "text", nullable: false),
                    WhatsApp = table.Column<string>(type: "text", nullable: true),
                    LocalPhone = table.Column<string>(type: "text", nullable: true),
                    GentsCount = table.Column<int>(type: "integer", nullable: true),
                    LadiesCount = table.Column<int>(type: "integer", nullable: true),
                    ChildrenCount = table.Column<int>(type: "integer", nullable: true),
                    ArrivalDate = table.Column<string>(type: "text", nullable: true),
                    ArrivalTime = table.Column<string>(type: "text", nullable: true),
                    DepatureDate = table.Column<string>(type: "text", nullable: true),
                    DepatureTime = table.Column<string>(type: "text", nullable: true),
                    TransportMode = table.Column<string>(type: "text", nullable: true),
                    IsKeepingVehicle = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    RequestedAt = table.Column<string>(type: "text", nullable: true),
                    DownloadedAt = table.Column<string>(type: "text", nullable: true),
                    ImportedAt = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebAccReq", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebAccReq_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactPhone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<string>(type: "text", nullable: true),
                    IsWhatsApp = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactPhone_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CounterRoomGroup",
                columns: table => new
                {
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    CounterId = table.Column<int>(type: "integer", nullable: false),
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounterRoomGroup", x => new { x.UtsavId, x.CounterId, x.RoomGroupId });
                    table.ForeignKey(
                        name: "FK_CounterRoomGroup_Counter_CounterId",
                        column: x => x.CounterId,
                        principalTable: "Counter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CounterRoomGroup_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CounterRoomGroup_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: true),
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false),
                    HouseTypeId = table.Column<int>(type: "integer", nullable: false),
                    AvailableFrom = table.Column<string>(type: "text", nullable: false),
                    AvailableTo = table.Column<string>(type: "text", nullable: false),
                    OccupancyType = table.Column<string>(type: "text", nullable: false),
                    IsClosed = table.Column<int>(type: "integer", nullable: false),
                    IsSatsangi = table.Column<int>(type: "integer", nullable: false),
                    IsWholeFamilyInSeva = table.Column<int>(type: "integer", nullable: false),
                    IsVerified = table.Column<int>(type: "integer", nullable: false),
                    IsFavourite = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    AddressLine1 = table.Column<string>(type: "text", nullable: true),
                    AddressLine2 = table.Column<string>(type: "text", nullable: true),
                    AddressLine3 = table.Column<string>(type: "text", nullable: true),
                    AreaOrMilestone = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    Lat = table.Column<decimal>(type: "numeric(12,8)", nullable: true),
                    Long = table.Column<decimal>(type: "numeric(12,8)", nullable: true),
                    LocationUrl = table.Column<string>(type: "text", nullable: true),
                    UtsavDistance = table.Column<double>(type: "double precision", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    LocationQuality = table.Column<string>(type: "text", nullable: true),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.Id);
                    table.ForeignKey(
                        name: "FK_House_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_House_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_House_HouseType_HouseTypeId",
                        column: x => x.HouseTypeId,
                        principalTable: "HouseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_House_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueryRoomGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    RGTypeId = table.Column<int>(type: "integer", nullable: false),
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SQL = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryRoomGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryRoomGroup_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryRoomGroup_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryRoomGroup_RoomGroupType_RGTypeId",
                        column: x => x.RGTypeId,
                        principalTable: "RoomGroupType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryRoomGroup_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryRoomGroup_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomGroupAmenity",
                columns: table => new
                {
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false),
                    AmenityId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomGroupAmenity", x => new { x.RoomGroupId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_RoomGroupAmenity_Amenity_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroupAmenity_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomGroupContact",
                columns: table => new
                {
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false),
                    ContactTypeId = table.Column<int>(type: "integer", nullable: false),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    IsDefault = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomGroupContact", x => new { x.RoomGroupId, x.ContactTypeId, x.ContactId });
                    table.ForeignKey(
                        name: "FK_RoomGroupContact_ContactType_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroupContact_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomGroupContact_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoomGroup",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_UserRoomGroup_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoomGroup_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WebAccReqDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WebAccReqId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    Relation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebAccReqDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebAccReqDetail_WebAccReq_WebAccReqId",
                        column: x => x.WebAccReqId,
                        principalTable: "WebAccReq",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true, defaultValue: "C")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haribhakt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    StateId = table.Column<int>(type: "integer", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haribhakt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haribhakt_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Haribhakt_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HouseAmenity",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "integer", nullable: false),
                    AmenityId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseAmenity", x => new { x.HouseId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_HouseAmenity_Amenity_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HouseAmenity_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HouseContact",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "integer", nullable: false),
                    ContactTypeId = table.Column<int>(type: "integer", nullable: false),
                    ContactId = table.Column<int>(type: "integer", nullable: false),
                    IsDefault = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseContact", x => new { x.HouseId, x.ContactTypeId, x.ContactId });
                    table.ForeignKey(
                        name: "FK_HouseContact_ContactType_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HouseContact_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HouseContact_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HouseInventory",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "integer", nullable: false),
                    InventoryId = table.Column<int>(type: "integer", nullable: false),
                    ReqOwner = table.Column<int>(type: "integer", nullable: false),
                    ReqUtara = table.Column<int>(type: "integer", nullable: false),
                    Actual = table.Column<int>(type: "integer", nullable: true),
                    WindUp = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseInventory", x => new { x.HouseId, x.InventoryId });
                    table.ForeignKey(
                        name: "FK_HouseInventory_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HouseInventory_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UniqueId = table.Column<string>(type: "text", nullable: true),
                    RoomGroupId = table.Column<int>(type: "integer", nullable: false),
                    HouseId = table.Column<int>(type: "integer", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: true),
                    BHK = table.Column<int>(type: "integer", nullable: true),
                    Deposit = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    Prefix = table.Column<string>(type: "text", nullable: true),
                    RoomNo = table.Column<int>(type: "integer", nullable: true),
                    Postfix = table.Column<string>(type: "text", nullable: true),
                    FloorId = table.Column<int>(type: "integer", nullable: true),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    OccupancyType = table.Column<string>(type: "text", nullable: false),
                    IsDormitory = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    DefaultRate = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    RTIsPrivate = table.Column<int>(type: "integer", nullable: true),
                    RTGentsCount = table.Column<int>(type: "integer", nullable: false),
                    RTLadiesCount = table.Column<int>(type: "integer", nullable: false),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true),
                    OriginalCapacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Floor_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_House_HouseId",
                        column: x => x.HouseId,
                        principalTable: "House",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_RoomGroup_RoomGroupId",
                        column: x => x.RoomGroupId,
                        principalTable: "RoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_RoomStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "RoomStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleQueryRoomGroup",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    QueryRoomGroupId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleQueryRoomGroup", x => new { x.RoleId, x.QueryRoomGroupId });
                    table.ForeignKey(
                        name: "FK_RoleQueryRoomGroup_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleQueryRoomGroup_QueryRoomGroup_QueryRoomGroupId",
                        column: x => x.QueryRoomGroupId,
                        principalTable: "QueryRoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccReq",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UtsavId = table.Column<int>(type: "integer", nullable: false),
                    BookingRefNo = table.Column<string>(type: "text", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: true),
                    NativePlace = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PrimaryMobile = table.Column<string>(type: "text", nullable: false),
                    IsPriMobWhatsApp = table.Column<int>(type: "integer", nullable: false),
                    BackupMobile = table.Column<string>(type: "text", nullable: true),
                    IsBkpMobWhatsApp = table.Column<int>(type: "integer", nullable: false),
                    LocalPhone = table.Column<string>(type: "text", nullable: true),
                    IsLocalPhoneWhatsApp = table.Column<int>(type: "integer", nullable: false),
                    GentsCount = table.Column<int>(type: "integer", nullable: false),
                    LadiesCount = table.Column<int>(type: "integer", nullable: false),
                    ChildrenCount = table.Column<int>(type: "integer", nullable: false),
                    DeptName = table.Column<string>(type: "text", nullable: true),
                    ReqTransModeId = table.Column<int>(type: "integer", nullable: true),
                    IsKeepingVehicle = table.Column<int>(type: "integer", nullable: false),
                    GuestRemarks = table.Column<string>(type: "text", nullable: true),
                    Reference = table.Column<string>(type: "text", nullable: true),
                    OfficeRemarks = table.Column<string>(type: "text", nullable: true),
                    ExpCheckInTime = table.Column<string>(type: "text", nullable: false),
                    ExpCheckOutTime = table.Column<string>(type: "text", nullable: false),
                    Deposit = table.Column<decimal>(type: "numeric(12,2)", nullable: true),
                    PaidRent = table.Column<decimal>(type: "numeric(12,2)", nullable: true),
                    ReturnedDeposit = table.Column<decimal>(type: "numeric(12,2)", nullable: true),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true),
                    ConsentedAt = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    HaribhaktId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccReq", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccReq_AccReqStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AccReqStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReq_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReq_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReq_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReq_ReqTransMode_ReqTransModeId",
                        column: x => x.ReqTransModeId,
                        principalTable: "ReqTransMode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReq_Utsav_UtsavId",
                        column: x => x.UtsavId,
                        principalTable: "Utsav",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceIssue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    IsCritical = table.Column<int>(type: "integer", nullable: false),
                    LostOrDamagedQuantity = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    InventoryId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceIssue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssue_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssue_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssue_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceIssue_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomAmenity",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    AmenityId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenity", x => new { x.RoomId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_RoomAmenity_Amenity_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomAmenity_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomCleaningStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    CleaningStatus = table.Column<int>(type: "integer", nullable: false),
                    ModifiedAt = table.Column<string>(type: "text", nullable: false),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCleaningStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomCleaningStatus_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomCleaningStatus_AspNetUsers_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomCleaningStatus_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomInventory",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    InventoryId = table.Column<int>(type: "integer", nullable: false),
                    ReqOwner = table.Column<int>(type: "integer", nullable: false),
                    ReqUtara = table.Column<int>(type: "integer", nullable: false),
                    Actual = table.Column<int>(type: "integer", nullable: true),
                    WindUp = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInventory", x => new { x.RoomId, x.InventoryId });
                    table.ForeignKey(
                        name: "FK_RoomInventory_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomInventory_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccDetail",
                columns: table => new
                {
                    AccReqId = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    IsPrivate = table.Column<int>(type: "integer", nullable: false),
                    GentsCount = table.Column<int>(type: "integer", nullable: false),
                    LadiesCount = table.Column<int>(type: "integer", nullable: false),
                    CounterCheckInTime = table.Column<string>(type: "text", nullable: true),
                    ActCheckInTime = table.Column<string>(type: "text", nullable: true),
                    CounterCheckOutTime = table.Column<string>(type: "text", nullable: true),
                    AllotedById = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccDetail", x => new { x.AccReqId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_AccDetail_AccReq_AccReqId",
                        column: x => x.AccReqId,
                        principalTable: "AccReq",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccDetail_AspNetUsers_AllotedById",
                        column: x => x.AllotedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccDetail_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccReqDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccReqId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: true),
                    RelationId = table.Column<int>(type: "integer", nullable: true),
                    MobileNumber = table.Column<string>(type: "text", nullable: true),
                    Remarks = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccReqDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccReqDetail_AccReq_AccReqId",
                        column: x => x.AccReqId,
                        principalTable: "AccReq",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReqDetail_Relation_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Relation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccReqToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InviteeName = table.Column<string>(type: "text", nullable: true),
                    InviterCityId = table.Column<int>(type: "integer", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    HashToken = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<string>(type: "text", nullable: true),
                    ModifiedAt = table.Column<string>(type: "text", nullable: true),
                    ModifiedById = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    LastAccessedAt = table.Column<string>(type: "text", nullable: true),
                    LastAccessedIp = table.Column<string>(type: "text", nullable: true),
                    AccReqId = table.Column<int>(type: "integer", nullable: true),
                    InviteeCityId = table.Column<int>(type: "integer", nullable: true),
                    InviteePhone = table.Column<string>(type: "text", nullable: true),
                    Reference = table.Column<string>(type: "text", nullable: true),
                    TrackingNumber = table.Column<string>(type: "text", nullable: true),
                    UtsavId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccReqToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccReqToken_AccReq_AccReqId",
                        column: x => x.AccReqId,
                        principalTable: "AccReq",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccReqToken_City_InviterCityId",
                        column: x => x.InviterCityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreAllotment",
                columns: table => new
                {
                    AccReqId = table.Column<int>(type: "integer", nullable: false),
                    QueryRoomGroupId = table.Column<int>(type: "integer", nullable: false),
                    IsPrivate = table.Column<int>(type: "integer", nullable: false),
                    AllowPrivateDormitory = table.Column<int>(type: "integer", nullable: false),
                    ExpCheckInTime = table.Column<string>(type: "text", nullable: false),
                    ExpCheckOutTime = table.Column<string>(type: "text", nullable: false),
                    AllotedAt = table.Column<string>(type: "text", nullable: false),
                    AllotedById = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<int>(type: "integer", nullable: false),
                    IsAuto = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreAllotment", x => x.AccReqId);
                    table.ForeignKey(
                        name: "FK_PreAllotment_AccReq_AccReqId",
                        column: x => x.AccReqId,
                        principalTable: "AccReq",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreAllotment_AspNetUsers_AllotedById",
                        column: x => x.AllotedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreAllotment_QueryRoomGroup_QueryRoomGroupId",
                        column: x => x.QueryRoomGroupId,
                        principalTable: "QueryRoomGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreAllotmentDetail",
                columns: table => new
                {
                    AccReqId = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    GentsCount = table.Column<int>(type: "integer", nullable: false),
                    LadiesCount = table.Column<int>(type: "integer", nullable: false),
                    IsExplicit = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreAllotmentDetail", x => new { x.AccReqId, x.RoomId });
                    table.ForeignKey(
                        name: "FK_PreAllotmentDetail_AccReq_AccReqId",
                        column: x => x.AccReqId,
                        principalTable: "AccReq",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreAllotmentDetail_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccDetail_AccReqId",
                table: "AccDetail",
                column: "AccReqId");

            migrationBuilder.CreateIndex(
                name: "IX_AccDetail_ActCheckInTime",
                table: "AccDetail",
                column: "ActCheckInTime");

            migrationBuilder.CreateIndex(
                name: "IX_AccDetail_AllotedById",
                table: "AccDetail",
                column: "AllotedById");

            migrationBuilder.CreateIndex(
                name: "IX_AccDetail_CounterCheckInTime",
                table: "AccDetail",
                column: "CounterCheckInTime");

            migrationBuilder.CreateIndex(
                name: "IX_AccDetail_CounterCheckOutTime",
                table: "AccDetail",
                column: "CounterCheckOutTime");

            migrationBuilder.CreateIndex(
                name: "IX_AccDetail_RoomId",
                table: "AccDetail",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_BookingRefNo",
                table: "AccReq",
                column: "BookingRefNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_Category",
                table: "AccReq",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_CityId",
                table: "AccReq",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_CreatedAt",
                table: "AccReq",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_CreatedById",
                table: "AccReq",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_ExpCheckInTime",
                table: "AccReq",
                column: "ExpCheckInTime");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_ExpCheckOutTime",
                table: "AccReq",
                column: "ExpCheckOutTime");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_HaribhaktId",
                table: "AccReq",
                column: "HaribhaktId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_ModifiedAt",
                table: "AccReq",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_ModifiedById",
                table: "AccReq",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_ReqTransModeId",
                table: "AccReq",
                column: "ReqTransModeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_StatusId",
                table: "AccReq",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReq_UtsavId",
                table: "AccReq",
                column: "UtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqDetail_AccReqId",
                table: "AccReqDetail",
                column: "AccReqId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqDetail_RelationId",
                table: "AccReqDetail",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqStatus_Name",
                table: "AccReqStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_AccReqId",
                table: "AccReqToken",
                column: "AccReqId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_CreatedAt",
                table: "AccReqToken",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_CreatedById",
                table: "AccReqToken",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_HashToken",
                table: "AccReqToken",
                column: "HashToken");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_InviterCityId",
                table: "AccReqToken",
                column: "InviterCityId");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_ModifiedAt",
                table: "AccReqToken",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AccReqToken_ModifiedById",
                table: "AccReqToken",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_AITypeAmenity_AITypeId",
                table: "AITypeAmenity",
                column: "AITypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AITypeAmenity_AmenityId",
                table: "AITypeAmenity",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_AITypeInventory_AITypeId",
                table: "AITypeInventory",
                column: "AITypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AITypeInventory_InventoryId",
                table: "AITypeInventory",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Amenity_Name",
                table: "Amenity",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_AspNetRoles_Name",
                table: "AspNetRoles",
                column: "Name",
                unique: true);

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
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_Name",
                table: "City",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_City_Type",
                table: "City",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UniqueId",
                table: "Contact",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UtsavId",
                table: "Contact",
                column: "UtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPhone_ContactId",
                table: "ContactPhone",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactType_Name",
                table: "ContactType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Continent_Name",
                table: "Continent",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Counter_CreatedAt",
                table: "Counter",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Counter_CreatedById",
                table: "Counter",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Counter_ModifiedAt",
                table: "Counter",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Counter_ModifiedById",
                table: "Counter",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Counter_UtsavId",
                table: "Counter",
                column: "UtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_CounterRoomGroup_CounterId",
                table: "CounterRoomGroup",
                column: "CounterId");

            migrationBuilder.CreateIndex(
                name: "IX_CounterRoomGroup_RoomGroupId",
                table: "CounterRoomGroup",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ContinentId",
                table: "Country",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Name",
                table: "Country",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Floor_Name",
                table: "Floor",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Haribhakt_CountryId",
                table: "Haribhakt",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Haribhakt_StateId",
                table: "Haribhakt",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Haribhakt_UniqueId",
                table: "Haribhakt",
                column: "UniqueId");

            migrationBuilder.CreateIndex(
                name: "IX_House_AvailableFrom",
                table: "House",
                column: "AvailableFrom");

            migrationBuilder.CreateIndex(
                name: "IX_House_AvailableTo",
                table: "House",
                column: "AvailableTo");

            migrationBuilder.CreateIndex(
                name: "IX_House_CreatedAt",
                table: "House",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_House_CreatedById",
                table: "House",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_House_HouseTypeId",
                table: "House",
                column: "HouseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_House_ModifiedAt",
                table: "House",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_House_ModifiedById",
                table: "House",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_House_RoomGroupId",
                table: "House",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_House_UniqueId",
                table: "House",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HouseAmenity_AmenityId",
                table: "HouseAmenity",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseAmenity_HouseId",
                table: "HouseAmenity",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseContact_ContactId",
                table: "HouseContact",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseContact_ContactTypeId",
                table: "HouseContact",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseContact_HouseId",
                table: "HouseContact",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseInventory_HouseId",
                table: "HouseInventory",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseInventory_InventoryId",
                table: "HouseInventory",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_OwnerId",
                table: "Image",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_Src",
                table: "Image",
                column: "Src");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TypeId",
                table: "Image",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_UniqueId",
                table: "Image",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImageType_Name",
                table: "ImageType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssue_CreatedById",
                table: "MaintenanceIssue",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssue_InventoryId",
                table: "MaintenanceIssue",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssue_ModifiedById",
                table: "MaintenanceIssue",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceIssue_RoomId",
                table: "MaintenanceIssue",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PreAllotment_AllotedById",
                table: "PreAllotment",
                column: "AllotedById");

            migrationBuilder.CreateIndex(
                name: "IX_PreAllotment_QueryRoomGroupId",
                table: "PreAllotment",
                column: "QueryRoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PreAllotmentDetail_RoomId",
                table: "PreAllotmentDetail",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_CreatedAt",
                table: "QueryRoomGroup",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_CreatedById",
                table: "QueryRoomGroup",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_ModifiedAt",
                table: "QueryRoomGroup",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_ModifiedById",
                table: "QueryRoomGroup",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_Name",
                table: "QueryRoomGroup",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_RGTypeId",
                table: "QueryRoomGroup",
                column: "RGTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_RoomGroupId",
                table: "QueryRoomGroup",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryRoomGroup_UtsavId",
                table: "QueryRoomGroup",
                column: "UtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_Relation_Name",
                table: "Relation",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReportRoles_RoleId",
                table: "ReportRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ReqTransMode_Name",
                table: "ReqTransMode",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestMode_Name",
                table: "RequestMode",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleQueryRoomGroup_QueryRoomGroupId",
                table: "RoleQueryRoomGroup",
                column: "QueryRoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_CreatedAt",
                table: "Room",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Room_CreatedById",
                table: "Room",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Room_FloorId",
                table: "Room",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Grade",
                table: "Room",
                column: "Grade");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HouseId",
                table: "Room",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_ModifiedAt",
                table: "Room",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Room_ModifiedById",
                table: "Room",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomGroupId",
                table: "Room",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_StatusId",
                table: "Room",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_UniqueId",
                table: "Room",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UIX_BuildingId_RoomNo",
                table: "Room",
                column: "RoomNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenity_AmenityId",
                table: "RoomAmenity",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomAmenity_RoomId",
                table: "RoomAmenity",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCleaningStatus_CreatedById",
                table: "RoomCleaningStatus",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCleaningStatus_ModifiedById",
                table: "RoomCleaningStatus",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCleaningStatus_RoomId",
                table: "RoomCleaningStatus",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_CreatedAt",
                table: "RoomGroup",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_CreatedById",
                table: "RoomGroup",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_MandirUtsavId",
                table: "RoomGroup",
                column: "MandirUtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_ModifiedAt",
                table: "RoomGroup",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_ModifiedById",
                table: "RoomGroup",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_Name",
                table: "RoomGroup",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_RGTypeId",
                table: "RoomGroup",
                column: "RGTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_UniqueId",
                table: "RoomGroup",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroup_UtsavId",
                table: "RoomGroup",
                column: "UtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroupAmenity_AmenityId",
                table: "RoomGroupAmenity",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroupAmenity_RoomGroupId",
                table: "RoomGroupAmenity",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroupContact_ContactId",
                table: "RoomGroupContact",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroupContact_ContactTypeId",
                table: "RoomGroupContact",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroupContact_RoomGroupId",
                table: "RoomGroupContact",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomGroupType_Name",
                table: "RoomGroupType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomInventory_InventoryId",
                table: "RoomInventory",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInventory_RoomId",
                table: "RoomInventory",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomStatus_Name",
                table: "RoomStatus",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_State_Name",
                table: "State",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoomGroup_RoomGroupId",
                table: "UserRoomGroup",
                column: "RoomGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoomGroup_UserId",
                table: "UserRoomGroup",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoomGroupType_RGTypeId",
                table: "UserRoomGroupType",
                column: "RGTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoomGroupType_UserId",
                table: "UserRoomGroupType",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_CreatedAt",
                table: "Utsav",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_CreatedById",
                table: "Utsav",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_DefaultArrivalAt",
                table: "Utsav",
                column: "DefaultArrivalAt");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_DefaultDepartureAt",
                table: "Utsav",
                column: "DefaultDepartureAt");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_EndsOn",
                table: "Utsav",
                column: "EndsOn");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_ModifiedAt",
                table: "Utsav",
                column: "ModifiedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_ModifiedById",
                table: "Utsav",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_StartsOn",
                table: "Utsav",
                column: "StartsOn");

            migrationBuilder.CreateIndex(
                name: "IX_Utsav_UniqueId",
                table: "Utsav",
                column: "UniqueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WebAccReq_DownloadedAt",
                table: "WebAccReq",
                column: "DownloadedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WebAccReq_ImportedAt",
                table: "WebAccReq",
                column: "ImportedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WebAccReq_RequestedAt",
                table: "WebAccReq",
                column: "RequestedAt");

            migrationBuilder.CreateIndex(
                name: "IX_WebAccReq_UtsavId",
                table: "WebAccReq",
                column: "UtsavId");

            migrationBuilder.CreateIndex(
                name: "IX_WebAccReq_WebReqId",
                table: "WebAccReq",
                column: "WebReqId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WebAccReqDetail_WebAccReqId",
                table: "WebAccReqDetail",
                column: "WebAccReqId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccDetail");

            migrationBuilder.DropTable(
                name: "AccReqDetail");

            migrationBuilder.DropTable(
                name: "AccReqToken");

            migrationBuilder.DropTable(
                name: "AITypeAmenity");

            migrationBuilder.DropTable(
                name: "AITypeInventory");

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
                name: "ContactPhone");

            migrationBuilder.DropTable(
                name: "CounterRoomGroup");

            migrationBuilder.DropTable(
                name: "DataProtectionKeys");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Haribhakt");

            migrationBuilder.DropTable(
                name: "HouseAmenity");

            migrationBuilder.DropTable(
                name: "HouseContact");

            migrationBuilder.DropTable(
                name: "HouseInventory");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "MaintenanceIssue");

            migrationBuilder.DropTable(
                name: "MemCache");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "PreAllotment");

            migrationBuilder.DropTable(
                name: "PreAllotmentDetail");

            migrationBuilder.DropTable(
                name: "ReportRoles");

            migrationBuilder.DropTable(
                name: "RequestMode");

            migrationBuilder.DropTable(
                name: "RoleQueryRoomGroup");

            migrationBuilder.DropTable(
                name: "RoomAmenity");

            migrationBuilder.DropTable(
                name: "RoomCleaningStatus");

            migrationBuilder.DropTable(
                name: "RoomGroupAmenity");

            migrationBuilder.DropTable(
                name: "RoomGroupContact");

            migrationBuilder.DropTable(
                name: "RoomInventory");

            migrationBuilder.DropTable(
                name: "UserRoomGroup");

            migrationBuilder.DropTable(
                name: "UserRoomGroupType");

            migrationBuilder.DropTable(
                name: "WebAccReqDetail");

            migrationBuilder.DropTable(
                name: "Relation");

            migrationBuilder.DropTable(
                name: "AIType");

            migrationBuilder.DropTable(
                name: "Counter");

            migrationBuilder.DropTable(
                name: "ImageType");

            migrationBuilder.DropTable(
                name: "AccReq");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "QueryRoomGroup");

            migrationBuilder.DropTable(
                name: "Amenity");

            migrationBuilder.DropTable(
                name: "ContactType");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "WebAccReq");

            migrationBuilder.DropTable(
                name: "AccReqStatus");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "ReqTransMode");

            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "House");

            migrationBuilder.DropTable(
                name: "RoomStatus");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "HouseType");

            migrationBuilder.DropTable(
                name: "RoomGroup");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "RoomGroupType");

            migrationBuilder.DropTable(
                name: "Utsav");

            migrationBuilder.DropTable(
                name: "Continent");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
