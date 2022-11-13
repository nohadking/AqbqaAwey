using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infarstuructre.Migrations
{
    public partial class dataBaceAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActiveUser = table.Column<bool>(type: "bit", nullable: false),
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
                name: "TbAboutusAboutUsPages",
                columns: table => new
                {
                    IdAboutUsPage = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    PictureAboutUs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindTravelProfessional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodReviewByClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WantToDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShareTravelLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShareTravelProvence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcellentGuides = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbAboutusAboutUsPages", x => x.IdAboutUsPage);
                });

            migrationBuilder.CreateTable(
                name: "TbGuideTourguideinformations",
                columns: table => new
                {
                    IdTourguideinformation = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    TourGuideName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourGuidePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplorerTeamLead = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectDirection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Savemoneytime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BestTouristGuide = table.Column<bool>(type: "bit", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbGuideTourguideinformations", x => x.IdTourguideinformation);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeBannerMains",
                columns: table => new
                {
                    IdBannerMain = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    VideoTrack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntrey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeBannerMains", x => x.IdBannerMain);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeBuckectListsDescriptions",
                columns: table => new
                {
                    IdBuckectLists = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    BuckectListsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entrytimeanddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DtatEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeBuckectListsDescriptions", x => x.IdBuckectLists);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeCategorieSbuckects",
                columns: table => new
                {
                    IdcategoriesBuckect = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CategoriesBuckect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entrytimeanddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DtatEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeCategorieSbuckects", x => x.IdcategoriesBuckect);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeFooterData",
                columns: table => new
                {
                    IdFooterData = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    LogoCom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoboxZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailComp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteCo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebooklink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagramlink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkyou = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entrytimeanddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEnyry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeFooterData", x => x.IdFooterData);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeFooterLatestNews",
                columns: table => new
                {
                    IdlatestNews = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    TextArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEnyry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeFooterLatestNews", x => x.IdlatestNews);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeGetToKnowUs",
                columns: table => new
                {
                    IdGetToKnowUs = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntrey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeGetToKnowUs", x => x.IdGetToKnowUs);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeOurPartners",
                columns: table => new
                {
                    IdOurPartners = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeOurPartners", x => x.IdOurPartners);
                });

            migrationBuilder.CreateTable(
                name: "TbHomePhotoGalleryTrips",
                columns: table => new
                {
                    IdPhotoGalleryTrips = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IDtripsSchedule = table.Column<int>(type: "int", nullable: true),
                    PictureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomePhotoGalleryTrips", x => x.IdPhotoGalleryTrips);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeProvinces",
                columns: table => new
                {
                    IdProvinces = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ProvincesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeProvinces", x => x.IdProvinces);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeTopDestinations",
                columns: table => new
                {
                    IdTopDestinations = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntrey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeTopDestinations", x => x.IdTopDestinations);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeTourguidedescriptions",
                columns: table => new
                {
                    IdTourguidedescription = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Tourguidedescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeTourguidedescriptions", x => x.IdTourguidedescription);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeTripCategories",
                columns: table => new
                {
                    IdTripCategories = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntrey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeTripCategories", x => x.IdTripCategories);
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
                name: "TbHomeDtripsSchedules",
                columns: table => new
                {
                    IDtripsSchedule = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTripCategories = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdcategoriesBuckect = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceIncludes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceDoesNotInclude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceAfterDiscount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CleanlinessRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilitiesRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoneyRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiCeratio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeDtripsSchedules", x => x.IDtripsSchedule);
                    table.ForeignKey(
                        name: "FK_TbHomeDtripsSchedules_TbHomeCategorieSbuckects_IdcategoriesBuckect",
                        column: x => x.IdcategoriesBuckect,
                        principalTable: "TbHomeCategorieSbuckects",
                        principalColumn: "IdcategoriesBuckect",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbHomeDtripsSchedules_TbHomeTripCategories_IdTripCategories",
                        column: x => x.IdTripCategories,
                        principalTable: "TbHomeTripCategories",
                        principalColumn: "IdTripCategories",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbHomeVedogalleries",
                columns: table => new
                {
                    Idvedogallery = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IDtripsSchedule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vidoname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbHomeVedogalleries", x => x.Idvedogallery);
                    table.ForeignKey(
                        name: "FK_TbHomeVedogalleries_TbHomeDtripsSchedules_IDtripsSchedule",
                        column: x => x.IDtripsSchedule,
                        principalTable: "TbHomeDtripsSchedules",
                        principalColumn: "IDtripsSchedule",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbSeRatingData",
                columns: table => new
                {
                    IdRatingData = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IDtripsSchedule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameClint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailClint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Views = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryTimeAndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSeRatingData", x => x.IdRatingData);
                    table.ForeignKey(
                        name: "FK_TbSeRatingData_TbHomeDtripsSchedules_IDtripsSchedule",
                        column: x => x.IDtripsSchedule,
                        principalTable: "TbHomeDtripsSchedules",
                        principalColumn: "IDtripsSchedule",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_TbHomeDtripsSchedules_IdcategoriesBuckect",
                table: "TbHomeDtripsSchedules",
                column: "IdcategoriesBuckect");

            migrationBuilder.CreateIndex(
                name: "IX_TbHomeDtripsSchedules_IdTripCategories",
                table: "TbHomeDtripsSchedules",
                column: "IdTripCategories");

            migrationBuilder.CreateIndex(
                name: "IX_TbHomeVedogalleries_IDtripsSchedule",
                table: "TbHomeVedogalleries",
                column: "IDtripsSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_TbSeRatingData_IDtripsSchedule",
                table: "TbSeRatingData",
                column: "IDtripsSchedule");
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
                name: "TbAboutusAboutUsPages");

            migrationBuilder.DropTable(
                name: "TbGuideTourguideinformations");

            migrationBuilder.DropTable(
                name: "TbHomeBannerMains");

            migrationBuilder.DropTable(
                name: "TbHomeBuckectListsDescriptions");

            migrationBuilder.DropTable(
                name: "TbHomeFooterData");

            migrationBuilder.DropTable(
                name: "TbHomeFooterLatestNews");

            migrationBuilder.DropTable(
                name: "TbHomeGetToKnowUs");

            migrationBuilder.DropTable(
                name: "TbHomeOurPartners");

            migrationBuilder.DropTable(
                name: "TbHomePhotoGalleryTrips");

            migrationBuilder.DropTable(
                name: "TbHomeProvinces");

            migrationBuilder.DropTable(
                name: "TbHomeTopDestinations");

            migrationBuilder.DropTable(
                name: "TbHomeTourguidedescriptions");

            migrationBuilder.DropTable(
                name: "TbHomeVedogalleries");

            migrationBuilder.DropTable(
                name: "TbSeRatingData");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TbHomeDtripsSchedules");

            migrationBuilder.DropTable(
                name: "TbHomeCategorieSbuckects");

            migrationBuilder.DropTable(
                name: "TbHomeTripCategories");
        }
    }
}
