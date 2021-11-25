using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arenas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsWon = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arenas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Battlegrounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsWon = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    InstanceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battlegrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dungeons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InstanceName = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    KeyIncrease = table.Column<int>(nullable: true),
                    Succes = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dungeons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raids",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InstanceName = table.Column<string>(nullable: true),
                    Difficulty = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    AvailableBosses = table.Column<int>(nullable: false),
                    BossesKilled = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    ItemLevel = table.Column<int>(nullable: false),
                    ArenaRating = table.Column<int>(nullable: false),
                    BattlegroundRating = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArenaCharacter",
                columns: table => new
                {
                    ArenaId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArenaCharacter", x => new { x.ArenaId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_ArenaCharacter_Arenas_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arenas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArenaCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BattlegroundCharacter",
                columns: table => new
                {
                    BattlegroundId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattlegroundCharacter", x => new { x.BattlegroundId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_BattlegroundCharacter_Battlegrounds_BattlegroundId",
                        column: x => x.BattlegroundId,
                        principalTable: "Battlegrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BattlegroundCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DungeonCharacter",
                columns: table => new
                {
                    DungeonId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DungeonCharacter", x => new { x.DungeonId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_DungeonCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DungeonCharacter_Dungeons_DungeonId",
                        column: x => x.DungeonId,
                        principalTable: "Dungeons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaidCharacter",
                columns: table => new
                {
                    RaidId = table.Column<Guid>(nullable: false),
                    CharacterId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaidCharacter", x => new { x.RaidId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_RaidCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaidCharacter_Raids_RaidId",
                        column: x => x.RaidId,
                        principalTable: "Raids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Arenas",
                columns: new[] { "Id", "Date", "IsWon" },
                values: new object[,]
                {
                    { new Guid("00000000-0001-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("00000000-0002-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("00000000-0003-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("00000000-0004-0000-0000-000000000000"), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-000000000002", "3b51afd4-bb35-4635-ace8-1ed112d53981", "Warlord", "WARLORD" },
                    { "00000000-0000-0000-000000000001", "58d4d0b8-9068-42ba-8984-eaa2b702b556", "Admin", "ADMIN" },
                    { "00000000-0000-0000-000000000003", "0a3bcda5-5005-43e2-bc12-c5e9cf69d5e7", "RaidLeader", "RAIDLEADER" },
                    { "00000000-0000-0000-000000000004", "ddd7e507-efdc-4a58-8348-5654de0285e0", "GuildMember", "GUILDMEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000010", 0, "04 Harbort Point", new DateTime(1987, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "6f745242-9ece-4690-a7af-9d7be2e08dd8", "browena9@springer.com", false, "Broderick Rowena", false, null, "BROWENA9@SPRINGER.COM", "BROWENA9@SPRINGER.COM", null, "AQAAAAEAACcQAAAAENYZKO7gvcz+QdSWc0GlWIHH1oy68NYYAvqu6vcf+QCinHBssp5D80eVuqAqiolujw==", null, false, "c1451956-f9fb-482c-be88-9e163aba76bd", false, "browena9@springer.com" },
                    { "00000000-0000-0000-0000-000000000012", 0, "6 Scofield Drive", new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "a0740ca8-6e31-4bdf-b962-470151d60689", "teastamb@phoca.cz", false, "Timi Eastam", false, null, "TEASTAMB@PHOCA.CZ", "TEASTAMB@PHOCA.CZ", null, "AQAAAAEAACcQAAAAEPxEopLz97+cjmaiEWn3NLhEjggpgG8fSEcKwpR57FFLRk9sxxFJqn28/M5MiUvEkQ==", null, false, "07a6a480-8f28-4735-8fc1-53f95614f64f", false, "teastamb@phoca.cz" },
                    { "00000000-0000-0000-0000-000000000013", 0, "9 Chive Alley", new DateTime(1972, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "eb67608d-b42e-47f1-8021-fefb26cf3407", "glidierthc@freewebs.com", false, "Gweneth Lidierth", false, null, "GLIDIERTHC@FREEWEBS.COM", "GLIDIERTHC@FREEWEBS.COM", null, "AQAAAAEAACcQAAAAEGHoEf8xNOAGda50Jfbzi2FulE0d7hAxxaonTdkNCtwspjfP9NcN0bXg2TK3mUObLg==", null, false, "d6f0d89e-b324-4513-8ebc-4b2c731acb13", false, "glidierthc@freewebs.com" },
                    { "00000000-0000-0000-0000-000000000014", 0, "56741 Huxley Lane", new DateTime(1977, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "35bfcd6d-26ed-4fa8-b488-4951cf981438", "lduttond@canalblog.com", false, "Lesya Dutton", false, null, "LDUTTOND@CANALBLOG.COM", "LDUTTOND@CANALBLOG.COM", null, "AQAAAAEAACcQAAAAELfDgDRq74PC0qVSMHlxlyRjbiM86ptMkeNuVmWKO2DekNTIUnZWx1hcUkD1IwW08Q==", null, false, "c106b1dc-4636-4060-8251-181d6f482a82", false, "lduttond@canalblog.com" },
                    { "00000000-0000-0000-0000-000000000015", 0, "4 Blaine Plaza", new DateTime(1974, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "c1d47682-346e-47f0-ab02-36a0b34cd441", "hfyerse@dmoz.org", false, "Hedvige Fyers", false, null, "HFYERSE@DMOZ.ORG", "HFYERSE@DMOZ.ORG", null, "AQAAAAEAACcQAAAAED6KlZMatuH1WzIAXcGpsZQsuMmvZduDDHeJ0bhvjpZ4ku7uWJzSU/oA3vZMP7VIGw==", null, false, "1db84d01-b470-4bc7-bb71-e272391a9901", false, "hfyerse@dmoz.org" },
                    { "00000000-0000-0000-0000-000000000016", 0, "58 Sherman Circle", new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "af2fc919-efee-4cdd-855d-5948b5f1a435", "nhalworthf@ezinearticles.com", true, "Nehemiah Halworth", false, null, "NHALWORTHF@EZINEARTICLES.COM", "NHALWORTHF@EZINEARTICLES.COM", null, "AQAAAAEAACcQAAAAEL6hGAdIJhymDg9Z4v8rYYrlkj2Uj8ZcJp6tRsQjUIMvift20x6mtMh+rI08X+smbg==", null, false, "f053bc9f-7709-4ded-a221-a453baa67be5", false, "nhalworthf@ezinearticles.com" },
                    { "00000000-0000-0000-0000-000000000017", 0, "2572 Nelson Trail", new DateTime(1987, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "930cf85b-9ebe-4acb-b029-356217ad1319", "rphing@europa.eu", true, "Robinetta Phin", false, null, "RPHING@EUROPA.EU", "RPHING@EUROPA.EU", null, "AQAAAAEAACcQAAAAEAMuzi+3IniWUtRSoUbwuudxZU0YjVYzEtzeUZeJ3ylK8upCpFwum4OFxGsfj/FqRg==", null, false, "c4e2f2b3-5f87-4ca7-b55f-5a3381e79aa1", false, "rphing@europa.eu" },
                    { "00000000-0000-0000-0000-000000000018", 0, "45 Onsgard Parkway", new DateTime(1973, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "f0509e34-9d98-4e3b-82b9-200747de0ea3", "cdirrh@ucsd.edu", false, "Correy Dirr", false, null, "CDIRRH@UCSD.EDU", "CDIRRH@UCSD.EDU", null, "AQAAAAEAACcQAAAAEI9WZ7Qtg4+lX712rpz5DmxDA7JLwHq63wxN/Zi1mkS8NO69wEBUq50bPG8+7hWfDQ==", null, false, "54866d0f-0e14-4320-8351-b8af6379d145", false, "cdirrh@ucsd.edu" },
                    { "00000000-0000-0000-0000-000000000019", 0, "197 Longview Way", new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "669c65cd-c9ec-4567-b95d-9baf625df17e", "zferrerasi@cisco.com", false, "Zelda Ferreras", false, null, "ZFERRERASI@CISCO.COM", "ZFERRERASI@CISCO.COM", null, "AQAAAAEAACcQAAAAENRmu5rXz+bcQv6dBmwbfXBRy4ZTmw6M7O3gGsP0eof/jsI3R6yFCtc+/TtxcKM7MA==", null, false, "8fb9bc7e-c7ac-425d-b433-4bdb0c5c0287", false, "zferrerasi@cisco.com" },
                    { "00000000-0000-0000-0000-000000000020", 0, "9 Vahlen Crossing", new DateTime(1982, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "4510ad96-67c4-4ed6-a280-6477e274ba66", "pninnisj@wix.com", false, "Paddy Ninnis", false, null, "PNINNISJ@WIX.COM", "PNINNISJ@WIX.COM", null, "AQAAAAEAACcQAAAAEKDXNS3lpeEzOY4eHFQ71KKe3BJgphSNPyj4VvS7HThixe02lFSLAP6/f2dRRnvC4A==", null, false, "2018f434-c152-4eed-9cec-ddee1ed4ba7e", false, "pninnisj@wix.com" },
                    { "00000000-0000-0000-0000-000000000021", 0, "98 Granby Hill", new DateTime(1981, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "c87211a9-ea25-49a3-a64e-49755a989d76", "jnindk@github.io", true, "Jeanna Nind", false, null, "JNINDK@GITHUB.IO", "JNINDK@GITHUB.IO", null, "AQAAAAEAACcQAAAAEI9RrzOgqz04p4iycRG2iTS4xwLo7FjhlnVHuIn2zKeYbPY105rJJ26vWocUigwduw==", null, false, "37492842-aab3-4f80-a9e2-18824aa77d98", false, "jnindk@github.io" },
                    { "00000000-0000-0000-0000-000000000022", 0, "88 Roxbury Crossing", new DateTime(1996, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "699c294e-bf4e-4951-bc60-6e401ff8d4c1", "drichfordl@economist.com", true, "Darius Richford", false, null, "DRICHFORDL@ECONOMIST.COM", "DRICHFORDL@ECONOMIST.COM", null, "AQAAAAEAACcQAAAAEOa2l3JltfbANbrZGnaXai/7cbwnhmN4NUG70V0FRd1gP7mo5uKJaMY2GiI13WowUQ==", null, false, "70c34373-bcf3-40ac-bea5-b3e2068e17b1", false, "drichfordl@economist.com" },
                    { "00000000-0000-0000-0000-000000000023", 0, "3 Holmberg Hill", new DateTime(1998, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "66acb3f7-9ca6-489d-b11f-e30125e639ce", "lsiebertm@mapy.cz", true, "Lindy Siebert", false, null, "LSIEBERTM@MAPY.CZ", "LSIEBERTM@MAPY.CZ", null, "AQAAAAEAACcQAAAAEGlnmE8BbWuhcN0w4IQL9Yjr/8XKVWKrD7xlIkOTwq2aJ0PrICFLGmqMqTi6OUAx2A==", null, false, "e4b63c65-6460-41fd-94b5-10cf87f22db6", false, "lsiebertm@mapy.cz" },
                    { "00000000-0000-0000-0000-000000000024", 0, "64070 Lakewood Gardens Circle", new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "553c2ec3-d730-4d04-986c-0bfee646c728", "mbaxstaren@mysql.com", false, "Micheil Baxstare", false, null, "MBAXSTAREN@MYSQL.COM", "MBAXSTAREN@MYSQL.COM", null, "AQAAAAEAACcQAAAAEDOylYSJB8/WO68z2C/qaZZ11zTNnB5fMXyHmkfKJmN/hl+MHQ45UVWFMQ6sRDjDNg==", null, false, "965b0f0f-e70a-4553-8b46-290f41e14a95", false, "mbaxstaren@mysql.com" },
                    { "00000000-0000-0000-0000-000000000025", 0, "1 Mesta Court", new DateTime(1995, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "6590a0bf-3df9-4ac2-a4c1-e2041fb42e02", "tklainero@admin.ch", true, "Terrance Klainer", false, null, "TKLAINERO@ADMIN.CH", "TKLAINERO@ADMIN.CH", null, "AQAAAAEAACcQAAAAEKVt7YKNDySZcNyTboNfmASoCq6VXs0TXISfCuyzWZ+D+mU/0MCHgAa1hvcUafUnAg==", null, false, "72efeccc-5cdb-43b7-b1ed-5846991eee59", false, "tklainero@admin.ch" },
                    { "00000000-0000-0000-0000-000000000026", 0, "0 Bashford Plaza", new DateTime(1992, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "26f43a11-1b8a-4b7f-a3a8-d72768120f9e", "klocklessp@un.org", false, "Killian Lockless", false, null, "KLOCKLESSP@UN.ORG", "KLOCKLESSP@UN.ORG", null, "AQAAAAEAACcQAAAAEFFzeEILFHFUTGPjoSCjZBhs3BJ5hXTMAXBEUJSpXF+oMihcV5JDgRiNv9FSdTRhHg==", null, false, "b65c244e-dcdf-4179-a7fc-1f04425576bf", false, "klocklessp@un.org" },
                    { "00000000-0000-0000-0000-000000000027", 0, "79 Fieldstone Drive", new DateTime(1994, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "7386a97c-3018-4e9a-a10b-22bd487ddf2a", "rgabbyq@mozilla.org", true, "Reynold Gabby", false, null, "RGABBYQ@MOZILLA.ORG", "RGABBYQ@MOZILLA.ORG", null, "AQAAAAEAACcQAAAAEDg+7JY7rr6iEVR5iilIxfjE161QBYvrZZu+JXiroLec/hZkY7aLK0O6JdpvR9xuUA==", null, false, "b29fe10b-d1f7-4ec5-8fe2-fdfc663ad8f6", false, "rgabbyq@mozilla.org" },
                    { "00000000-0000-0000-0000-000000000028", 0, "9875 Warner Terrace", new DateTime(1998, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "040813a5-c5a4-4201-943c-fb869b5eb160", "obartar@vistaprint.com", true, "Opaline Barta", false, null, "OBARTAR@VISTAPRINT.COM", "OBARTAR@VISTAPRINT.COM", null, "AQAAAAEAACcQAAAAEOAMjaU11WmGnyRksOBHAg2NQhvsJvI5hywUafW/LnLtrJ9/tXxE0oSN+mztrBlpQw==", null, false, "ceea70f3-d7b2-4efe-a4b3-dd24d4eb0dfb", false, "obartar@vistaprint.com" },
                    { "00000000-0000-0000-0000-000000000029", 0, "189 Fairfield Hill", new DateTime(1976, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "bd4085f6-3f82-43d1-955f-202309577091", "cscocrofts@facebook.com", true, "Concettina Scocroft", false, null, "CSCOCROFTS@FACEBOOK.COM", "CSCOCROFTS@FACEBOOK.COM", null, "AQAAAAEAACcQAAAAELPyupi8E9MXJgdabuYMm4QemOFxrjTI1qF1BuClwqxlKyeOuzXcQXxBrK6kcm0bfw==", null, false, "e60e7d53-a7c7-46c9-b2ea-c2593118820b", false, "cscocrofts@facebook.com" },
                    { "00000000-0000-0000-0000-000000000030", 0, "7918 Jenifer Lane", new DateTime(1995, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "0643af10-acef-417c-b835-1c2d38fa5f50", "pshillt@simplemachines.org", true, "Pooh Shill", false, null, "PSHILLT@SIMPLEMACHINES.ORG", "PSHILLT@SIMPLEMACHINES.ORG", null, "AQAAAAEAACcQAAAAECH27HwuLC7qJKOgLJUuP1hTDpPgeHkBzqKKfFehAUq7Y82VFr1/+Ks3PruY9+ysfg==", null, false, "09a34d7f-f679-4198-bc3d-aa37fbe6ea78", false, "pshillt@simplemachines.org" },
                    { "00000000-0000-0000-0000-000000000011", 0, "97 Rockefeller Circle", new DateTime(2000, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "f30685ef-a6a6-4433-99f5-51a1e9e3dad2", "lgregorioua@storify.com", true, "Lenna Gregoriou", false, null, "LGREGORIOUA@STORIFY.COM", "LGREGORIOUA@STORIFY.COM", null, "AQAAAAEAACcQAAAAEA+5p6Dyb/WBkINOskJi2zkt9MmbjznAICJ91LW/YGd8ZLkcKQ3XwibTXCxHYn3Pmw==", null, false, "5cf90957-3a33-447d-b9cc-2a40ab0262bb", false, "lgregorioua@storify.com" },
                    { "00000000-0000-0000-0000-000000000009", 0, "22114 Carberry Avenue", new DateTime(1991, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "59737250-b0f3-4d28-a7a8-7bf2407ec2f6", "mrispine8@is.gd", true, "Madalena Rispine", false, null, "MRISPINE8@IS.GD", "MRISPINE8@IS.GD", null, "AQAAAAEAACcQAAAAELQd4vLwkqM2PYWDmtVU0PT9HSHjYnyghfA8XPMp2Gc6BwCBjDT6Yxftjul7wg1FBQ==", null, false, "f51e9bdd-d858-4115-8a42-bc9a8c987896", false, "mrispine8@is.gd" },
                    { "00000000-0000-0000-0000-000000000003", 0, "5 Onsgard Parkway", new DateTime(1981, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "92c0ed1e-68f8-4b16-8109-a22b207be44a", "msemeniuk2@prweb.com", false, "Mil Semeniuk", false, null, "MSEMENIUK2@PRWEB.COM", "MSEMENIUK2@PRWEB.COM", null, "AQAAAAEAACcQAAAAEH5d66DBysbT3wPmLm0EiFByACRkEqKl/R2j78zj5L7bfNf1Lk/4VPIvUuDfSjykCg==", null, false, "88047215-e623-45d1-997b-36a9fc9e82ee", false, "msemeniuk2@prweb.com" },
                    { "00000000-0000-0000-0000-000000000007", 0, "39 Morrow Center", new DateTime(1995, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "ed9d209a-b389-4eeb-bb24-b3ece61aa6f8", "gbortolozzi6@friendfeed.com", false, "Giavani Bortolozzi", false, null, "GBORTOLOZZI6@FRIENDFEED.COM", "GBORTOLOZZI6@FRIENDFEED.COM", null, "AQAAAAEAACcQAAAAEHNPn2USyevdpipFVNROd1zehPGxg6JQ89s8g4PxchbgfvgBaqhTz8WReL87m/nwtA==", null, false, "6783a88d-e907-453b-b6f4-1223bb6a0d0b", false, "gbortolozzi6@friendfeed.com" },
                    { "00000000-0000-0000-0000-000000000006", 0, "7 Cody Way", new DateTime(1996, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "60f1e765-02a9-434e-99ea-da13691ab038", "legell5@wikispaces.com", true, "Lucho Egell", false, null, "LEGELL5@WIKISPACES.COM", "LEGELL5@WIKISPACES.COM", null, "AQAAAAEAACcQAAAAEJY9obtjzSxQYD95hK3PlP+R1+JMtByyKTNfzcsegkQLE0kZ0BY90kEeN9urIieWkA==", null, false, "9e616bfc-1d88-412b-97cd-378ccb6bf175", false, "legell5@wikispaces.com" },
                    { "00000000-0000-0000-0000-000000000005", 0, "80 Mcguire Circle", new DateTime(1982, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "77aa0003-5d3e-4026-81f1-ac52adeb52aa", "jingyon4@hao123.com", true, "Jackson Ingyon", false, null, "JINGYON4@HAO123.COM", "JINGYON4@HAO123.COM", null, "AQAAAAEAACcQAAAAEFVoecwxU2cfQH8nPT9ABTvvV7wZ4boxL3DWrhXvMkjlrgPE1S0P3oXC0XkDK6ELYw==", null, false, "431cd7cf-ad96-4569-b63b-89c2ca25cb55", false, "jingyon4@hao123.com" },
                    { "00000000-0000-0000-0000-000000000004", 0, "20 Wayridge Place", new DateTime(1975, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "415c687d-181e-43da-bf17-457fac0a2ddb", "awasbey3@google.it", true, "Aurel Wasbey", false, null, "AWASBEY3@GOOGLE.IT", "AWASBEY3@GOOGLE.IT", null, "AQAAAAEAACcQAAAAECcJM9XQmZkj58kotgjXrLbLj32ytg4fOPStRfbbmtaybYza6iFhV5UAbx90g4fUlg==", null, false, "f495d8ca-a8de-42ae-95bb-4915c019b54a", false, "awasbey3@google.it" },
                    { "00000000-0000-0000-0000-000000000002", 0, "50 Independence Avenue", new DateTime(2000, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "2acbbe23-b45a-40db-b79a-edc3fbac8f54", "cwoodland1@reference.com", false, "Clem Woodland", false, null, "CWOODLAND1@REFERENCE.COM", "CWOODLAND1@REFERENCE.COM", null, "AQAAAAEAACcQAAAAEDW7z6yLkFXcTEVicIDShIkeTkYbamnfpoaHVqucxJcUzzP+2g09TJYutY8vjAB65w==", null, false, "53f9bd8c-891f-4138-8aac-c31472fdce3c", false, "cwoodland1@reference.com" },
                    { "00000000-0000-0000-0000-000000000001", 0, "6 Gale Plaza", new DateTime(1996, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "67b2e934-2f3f-487d-9bfa-22143364aaf4", "ageydon0@marriott.com", true, "Aldwin Geydon", false, null, "AGEYDON0@MARRIOTT.COM", "AGEYDON0@MARRIOTT.COM", null, "AQAAAAEAACcQAAAAEE2MqhLvWJ/RANI57wihcKzYRjsUlbae/15B5HRt/T70NnPzk/CVpXRmj6m8vXT7GQ==", null, false, "1a94e148-dcb3-49d8-a12f-3f9befaaf9da", false, "ageydon0@marriott.com" },
                    { "00000000-0000-0000-0000-000000000008", 0, "3 Monica Plaza", new DateTime(1976, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "b55785c8-82fc-45cd-bc4c-9358dde12929", "cmair7@dion.ne.jp", false, "Casie Mair", false, null, "CMAIR7@DION.NE.JP", "CMAIR7@DION.NE.JP", null, "AQAAAAEAACcQAAAAEBV9MJqK6LXHSDwYMiYYfLM7uOyRfb2JCUQyuZ2tWVydeaO5cZhnRTs/fpcNYBxbcg==", null, false, "96937c38-c3fc-4e4b-8a06-0f8e96212f11", false, "cmair7@dion.ne.jp" }
                });

            migrationBuilder.InsertData(
                table: "Battlegrounds",
                columns: new[] { "Id", "Date", "InstanceName", "IsWon" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0004-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twin Peaks", true },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warsong Gulch", true },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twin Peaks", true },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warsong Gulch", true },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twin Peaks", false }
                });

            migrationBuilder.InsertData(
                table: "Dungeons",
                columns: new[] { "Id", "Date", "Difficulty", "InstanceName", "KeyIncrease", "Succes" },
                values: new object[,]
                {
                    { new Guid("00000008-0000-0000-0000-000000000000"), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic+ 8", "Sanguine Depths", null, false },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic+ 7", "Theater of Pain", 1, true },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic+ 5", "Halls of Atonement", 2, true },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic", "Spires of Ascension", null, true },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mythic", "Plaguefall", null, true },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "The Necrotic Wake", null, true },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Mists of Tirna Scithe", null, true },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "De Other Side", null, true }
                });

            migrationBuilder.InsertData(
                table: "Raids",
                columns: new[] { "Id", "AvailableBosses", "BossesKilled", "Date", "Difficulty", "InstanceName" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000000"), 10, 10, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" },
                    { new Guid("40000000-0000-0000-0000-000000000000"), 10, 4, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" },
                    { new Guid("50000000-0000-0000-0000-000000000000"), 10, 4, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" },
                    { new Guid("30000000-0000-0000-0000-000000000000"), 10, 10, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" },
                    { new Guid("10000000-0000-0000-0000-000000000000"), 10, 10, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroic", "Caste Nathria" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 36, "has-characters", "true", "00000000-0000-0000-0000-000000000018" },
                    { 26, "has-characters", "true", "00000000-0000-0000-0000-000000000013" },
                    { 25, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000013" },
                    { 51, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000026" },
                    { 52, "has-characters", "true", "00000000-0000-0000-0000-000000000026" },
                    { 53, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000027" },
                    { 24, "has-characters", "true", "00000000-0000-0000-0000-000000000012" },
                    { 23, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000012" },
                    { 54, "has-characters", "true", "00000000-0000-0000-0000-000000000027" },
                    { 55, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000028" },
                    { 56, "has-characters", "true", "00000000-0000-0000-0000-000000000028" },
                    { 22, "has-characters", "true", "00000000-0000-0000-0000-000000000011" },
                    { 21, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000011" },
                    { 57, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000029" },
                    { 58, "has-characters", "true", "00000000-0000-0000-0000-000000000029" },
                    { 59, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000030" },
                    { 20, "has-characters", "true", "00000000-0000-0000-0000-000000000010" },
                    { 19, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000010" },
                    { 50, "has-characters", "true", "00000000-0000-0000-0000-000000000025" },
                    { 49, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000025" },
                    { 48, "has-characters", "true", "00000000-0000-0000-0000-000000000024" },
                    { 27, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000014" },
                    { 37, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000019" },
                    { 38, "has-characters", "true", "00000000-0000-0000-0000-000000000019" },
                    { 34, "has-characters", "true", "00000000-0000-0000-0000-000000000017" },
                    { 33, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000017" },
                    { 39, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000020" },
                    { 40, "has-characters", "true", "00000000-0000-0000-0000-000000000020" },
                    { 41, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000021" },
                    { 32, "has-characters", "true", "00000000-0000-0000-0000-000000000016" },
                    { 60, "has-characters", "true", "00000000-0000-0000-0000-000000000030" },
                    { 31, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000016" },
                    { 43, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000022" },
                    { 44, "has-characters", "true", "00000000-0000-0000-0000-000000000022" },
                    { 30, "has-characters", "true", "00000000-0000-0000-0000-000000000015" },
                    { 29, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000015" },
                    { 45, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000023" },
                    { 46, "has-characters", "true", "00000000-0000-0000-0000-000000000023" },
                    { 47, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000024" },
                    { 28, "has-characters", "true", "00000000-0000-0000-0000-000000000014" },
                    { 42, "has-characters", "true", "00000000-0000-0000-0000-000000000021" },
                    { 17, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000009" },
                    { 18, "has-characters", "true", "00000000-0000-0000-0000-000000000009" },
                    { 35, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000018" },
                    { 6, "has-characters", "true", "00000000-0000-0000-0000-000000000003" },
                    { 9, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000005" },
                    { 10, "has-characters", "true", "00000000-0000-0000-0000-000000000005" },
                    { 5, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000003" },
                    { 11, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000006" },
                    { 12, "has-characters", "true", "00000000-0000-0000-0000-000000000006" },
                    { 8, "has-characters", "true", "00000000-0000-0000-0000-000000000004" },
                    { 3, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000002" },
                    { 13, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000007" },
                    { 4, "has-characters", "true", "00000000-0000-0000-0000-000000000002" },
                    { 15, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000008" },
                    { 16, "has-characters", "true", "00000000-0000-0000-0000-000000000008" },
                    { 2, "has-characters", "true", "00000000-0000-0000-0000-000000000001" },
                    { 1, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000001" },
                    { 14, "has-characters", "true", "00000000-0000-0000-0000-000000000007" },
                    { 7, "registration-date", "2021-03-15", "00000000-0000-0000-0000-000000000004" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000024", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000025", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000026", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000023", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000022", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000021", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000027", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000028", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000020", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000029", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-000000000003" },
                    { "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000008", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000010", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000012", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000014", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000016", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000018", "00000000-0000-0000-000000000004" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-000000000003" },
                    { "00000000-0000-0000-0000-000000000030", "00000000-0000-0000-000000000004" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ArenaRating", "BattlegroundRating", "Class", "IsDeleted", "ItemLevel", "Level", "Name", "Role", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0055-000000000000"), 1966, 1297, "Demon Hunter", false, 165, 60, "Falfda", "Dps", "00000000-0000-0000-0000-000000000019" },
                    { new Guid("00000000-0000-0000-0025-000000000000"), 1467, 1230, "Warrior", false, 177, 60, "GilGalad", "Tank", "00000000-0000-0000-0000-000000000009" },
                    { new Guid("00000000-0000-0000-0026-000000000000"), 1804, 1386, "Rogue", false, 169, 60, "Yreleth", "Dps", "00000000-0000-0000-0000-000000000009" },
                    { new Guid("00000000-0000-0000-0027-000000000000"), 1910, 48, "Monk", false, 152, 60, "Bromir", "Dps", "00000000-0000-0000-0000-000000000009" },
                    { new Guid("00000000-0000-0000-0028-000000000000"), 46, 1185, "Druid", false, 152, 60, "Phandalor", "Healer", "00000000-0000-0000-0000-000000000010" },
                    { new Guid("00000000-0000-0000-0029-000000000000"), 618, 944, "Hunter", false, 174, 60, "Myriad", "Dps", "00000000-0000-0000-0000-000000000010" },
                    { new Guid("00000000-0000-0000-0030-000000000000"), 604, 1808, "Paladin", false, 201, 60, "Ithaela", "Dps", "00000000-0000-0000-0000-000000000010" },
                    { new Guid("00000000-0000-0000-0031-000000000000"), 73, 522, "Druid", false, 170, 60, "Malfurion", "Tank", "00000000-0000-0000-0000-000000000011" },
                    { new Guid("00000000-0000-0000-0090-000000000000"), 1095, 271, "Priest", false, 192, 60, "Surest", "Healer", "00000000-0000-0000-0000-000000000030" },
                    { new Guid("00000000-0000-0000-0024-000000000000"), 1401, 890, "Mage", false, 192, 60, "Coolbone", "Dps", "00000000-0000-0000-0000-000000000008" },
                    { new Guid("00000000-0000-0000-0089-000000000000"), 1703, 965, "Priest", false, 173, 60, "Brann", "Healer", "00000000-0000-0000-0000-000000000030" },
                    { new Guid("00000000-0000-0000-0032-000000000000"), 630, 421, "Priest", false, 193, 60, "Faron", "Dps", "00000000-0000-0000-0000-000000000011" },
                    { new Guid("00000000-0000-0000-0033-000000000000"), 505, 976, "Rogue", false, 209, 60, "Krilli", "Dps", "00000000-0000-0000-0000-000000000011" },
                    { new Guid("00000000-0000-0000-0087-000000000000"), 1910, 645, "Mage", false, 206, 60, "Villia", "Dps", "00000000-0000-0000-0000-000000000029" },
                    { new Guid("00000000-0000-0000-0086-000000000000"), 238, 567, "Druid", false, 215, 60, "Alexil", "Dps", "00000000-0000-0000-0000-000000000029" },
                    { new Guid("00000000-0000-0000-0085-000000000000"), 1518, 306, "Hunter", false, 215, 60, "Deinon", "Dps", "00000000-0000-0000-0000-000000000029" },
                    { new Guid("00000000-0000-0000-0034-000000000000"), 1679, 1013, "Hunter", false, 163, 60, "Fandor", "Dps", "00000000-0000-0000-0000-000000000012" },
                    { new Guid("00000000-0000-0000-0035-000000000000"), 1724, 1117, "Monk", false, 203, 60, "Marissa", "Tank", "00000000-0000-0000-0000-000000000012" },
                    { new Guid("00000000-0000-0000-0084-000000000000"), 522, 632, "Demon Hunter", false, 194, 60, "Aayunn", "Dps", "00000000-0000-0000-0000-000000000028" },
                    { new Guid("00000000-0000-0000-0088-000000000000"), 1851, 1809, "Death Knight", false, 221, 60, "Rellan", "Tank", "00000000-0000-0000-0000-000000000030" },
                    { new Guid("00000000-0000-0000-0023-000000000000"), 1029, 296, "Hunter", false, 188, 60, "Umbrion", "Dps", "00000000-0000-0000-0000-000000000008" },
                    { new Guid("00000000-0000-0000-0022-000000000000"), 1309, 2057, "Death Knight", false, 187, 60, "Ashifal", "Dps", "00000000-0000-0000-0000-000000000008" },
                    { new Guid("00000000-0000-0000-0021-000000000000"), 1356, 1849, "Demon Hunter", false, 157, 60, "Malefikh", "Dps", "00000000-0000-0000-0000-000000000007" },
                    { new Guid("00000000-0000-0000-0002-000000000000"), 496, 1812, "Druid", false, 216, 60, "Bauglir", "Dps", "00000000-0000-0000-0000-000000000001" },
                    { new Guid("00000000-0000-0000-0003-000000000000"), 160, 1940, "Priest", false, 215, 60, "Shiroe", "Healer", "00000000-0000-0000-0000-000000000001" },
                    { new Guid("00000000-0000-0000-0004-000000000000"), 1448, 395, "Shaman", false, 166, 60, "Yoriko", "Healer", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("00000000-0000-0000-0005-000000000000"), 1538, 1814, "Warlock", false, 223, 60, "Elen", "Dps", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("00000000-0000-0000-0006-000000000000"), 1788, 1980, "Mage", false, 187, 60, "Tary", "Dps", "00000000-0000-0000-0000-000000000002" },
                    { new Guid("00000000-0000-0000-0007-000000000000"), 1607, 1652, "Warrior", false, 199, 60, "Borugor", "Dps", "00000000-0000-0000-0000-000000000003" },
                    { new Guid("00000000-0000-0000-0008-000000000000"), 1385, 258, "Hunter", false, 222, 60, "Wildstrider", "Dps", "00000000-0000-0000-0000-000000000003" },
                    { new Guid("00000000-0000-0000-0009-000000000000"), 424, 54, "Paladin", false, 200, 60, "Liutasil", "Tank", "00000000-0000-0000-0000-000000000003" },
                    { new Guid("00000000-0000-0000-0010-000000000000"), 38, 538, "Demon Hunter", false, 145, 60, "Aerenthil", "Dps", "00000000-0000-0000-0000-000000000004" },
                    { new Guid("00000000-0000-0000-0011-000000000000"), 1279, 746, "Monk", false, 193, 60, "Ghinin", "Tank", "00000000-0000-0000-0000-000000000004" },
                    { new Guid("00000000-0000-0000-0012-000000000000"), 64, 1586, "Mage", false, 145, 60, "Nuremor", "Dps", "00000000-0000-0000-0000-000000000004" },
                    { new Guid("00000000-0000-0000-0013-000000000000"), 210, 1322, "Shaman", false, 185, 60, "Rhamanji", "Dps", "00000000-0000-0000-0000-000000000005" },
                    { new Guid("00000000-0000-0000-0014-000000000000"), 30, 1825, "Priest", false, 187, 60, "Ebrothil", "Dps", "00000000-0000-0000-0000-000000000005" },
                    { new Guid("00000000-0000-0000-0015-000000000000"), 937, 885, "Rogue", false, 187, 60, "Tyrigon", "Dps", "00000000-0000-0000-0000-000000000005" },
                    { new Guid("00000000-0000-0000-0016-000000000000"), 517, 194, "Paladin", false, 202, 60, "Aeternus", "Healer", "00000000-0000-0000-0000-000000000006" },
                    { new Guid("00000000-0000-0000-0017-000000000000"), 983, 1337, "Monk", false, 201, 60, "Trech", "Healer", "00000000-0000-0000-0000-000000000006" },
                    { new Guid("00000000-0000-0000-0018-000000000000"), 1107, 64, "Shaman", false, 201, 60, "Baradhor", "Healer", "00000000-0000-0000-0000-000000000007" },
                    { new Guid("00000000-0000-0000-0019-000000000000"), 1810, 1648, "Druid", false, 199, 60, "Eranthil", "Healer", "00000000-0000-0000-0000-000000000007" },
                    { new Guid("00000000-0000-0000-0020-000000000000"), 344, 637, "Warlock", false, 139, 60, "Morgoroth", "Dps", "00000000-0000-0000-0000-000000000007" },
                    { new Guid("00000000-0000-0000-0083-000000000000"), 1807, 1995, "Shaman", false, 166, 60, "Bolynn", "Dps", "00000000-0000-0000-0000-000000000028" },
                    { new Guid("00000000-0000-0000-0082-000000000000"), 933, 1695, "Rogue", false, 203, 60, "Orghana", "Dps", "00000000-0000-0000-0000-000000000028" },
                    { new Guid("00000000-0000-0000-0036-000000000000"), 1423, 418, "Hunter", false, 195, 60, "Aokie", "Dps", "00000000-0000-0000-0000-000000000012" },
                    { new Guid("00000000-0000-0000-0037-000000000000"), 151, 723, "Paladin", false, 199, 60, "Laughen", "Healer", "00000000-0000-0000-0000-000000000013" },
                    { new Guid("00000000-0000-0000-0046-000000000000"), 1287, 1675, "Hunter", false, 205, 60, "Meeky", "Dps", "00000000-0000-0000-0000-000000000016" },
                    { new Guid("00000000-0000-0000-0047-000000000000"), 1533, 1541, "Hunter", false, 160, 60, "Feeky", "Dps", "00000000-0000-0000-0000-000000000016" },
                    { new Guid("00000000-0000-0000-0066-000000000000"), 1686, 709, "Mage", false, 209, 60, "Wulaer", "Dps", "00000000-0000-0000-0000-000000000022" },
                    { new Guid("00000000-0000-0000-0065-000000000000"), 547, 1767, "Shaman", false, 226, 60, "Squard", "Dps", "00000000-0000-0000-0000-000000000022" },
                    { new Guid("00000000-0000-0000-0064-000000000000"), 2004, 431, "Monk", false, 212, 60, "Thalgu", "Dps", "00000000-0000-0000-0000-000000000022" },
                    { new Guid("00000000-0000-0000-0048-000000000000"), 1771, 904, "Hunter", false, 190, 60, "Beeky", "Dps", "00000000-0000-0000-0000-000000000016" },
                    { new Guid("00000000-0000-0000-0049-000000000000"), 1654, 85, "Warrior", false, 210, 60, "Sylvar", "Dps", "00000000-0000-0000-0000-000000000017" },
                    { new Guid("00000000-0000-0000-0063-000000000000"), 1291, 517, "Hunter", false, 224, 60, "Caitli", "Dps", "00000000-0000-0000-0000-000000000021" },
                    { new Guid("00000000-0000-0000-0062-000000000000"), 739, 982, "Mage", false, 223, 60, "Cragho", "Dps", "00000000-0000-0000-0000-000000000021" },
                    { new Guid("00000000-0000-0000-0061-000000000000"), 2068, 418, "Demon Hunter", false, 214, 60, "Lyrand", "Tank", "00000000-0000-0000-0000-000000000021" },
                    { new Guid("00000000-0000-0000-0050-000000000000"), 639, 713, "Druid", false, 163, 60, "Laryngo", "Healer", "00000000-0000-0000-0000-000000000017" },
                    { new Guid("00000000-0000-0000-0051-000000000000"), 611, 991, "Rogue", false, 220, 60, "Saveron", "Dps", "00000000-0000-0000-0000-000000000017" },
                    { new Guid("00000000-0000-0000-0060-000000000000"), 306, 1307, "Demon Hunter", false, 208, 60, "Kullem", "Dps", "00000000-0000-0000-0000-000000000020" },
                    { new Guid("00000000-0000-0000-0059-000000000000"), 1645, 1726, "Monk", false, 177, 60, "Elioth", "Healer", "00000000-0000-0000-0000-000000000020" },
                    { new Guid("00000000-0000-0000-0058-000000000000"), 515, 2005, "Shaman", false, 161, 60, "Talade", "Healer", "00000000-0000-0000-0000-000000000020" },
                    { new Guid("00000000-0000-0000-0052-000000000000"), 683, 1868, "Paladin", false, 161, 60, "Landarin", "Healer", "00000000-0000-0000-0000-000000000018" },
                    { new Guid("00000000-0000-0000-0053-000000000000"), 1604, 1119, "Death Knight", false, 158, 60, "Asfaloth", "Dps", "00000000-0000-0000-0000-000000000018" },
                    { new Guid("00000000-0000-0000-0057-000000000000"), 1072, 2055, "Rogue", false, 177, 60, "Lloydyr", "Dps", "00000000-0000-0000-0000-000000000019" },
                    { new Guid("00000000-0000-0000-0056-000000000000"), 1147, 161, "Paladin", false, 202, 60, "Pillia", "Healer", "00000000-0000-0000-0000-000000000019" },
                    { new Guid("00000000-0000-0000-0067-000000000000"), 724, 439, "Paladin", false, 218, 60, "Stumpe", "Dps", "00000000-0000-0000-0000-000000000023" },
                    { new Guid("00000000-0000-0000-0054-000000000000"), 1447, 9, "Rogue", false, 200, 60, "Mimtoth", "Dps", "00000000-0000-0000-0000-000000000018" },
                    { new Guid("00000000-0000-0000-0068-000000000000"), 1903, 1621, "Demon Hunter", false, 159, 60, "Orokki", "Dps", "00000000-0000-0000-0000-000000000023" },
                    { new Guid("00000000-0000-0000-0045-000000000000"), 1707, 1831, "Warrior", false, 164, 60, "Clerence", "Tank", "00000000-0000-0000-0000-000000000015" },
                    { new Guid("00000000-0000-0000-0081-000000000000"), 619, 1214, "Death Knight", false, 174, 60, "Riverh", "Dps", "00000000-0000-0000-0000-000000000027" },
                    { new Guid("00000000-0000-0000-0080-000000000000"), 1609, 1582, "Paladin", false, 182, 60, "Lyoria", "Healer", "00000000-0000-0000-0000-000000000027" },
                    { new Guid("00000000-0000-0000-0079-000000000000"), 1722, 2045, "Monk", false, 175, 60, "Pebble", "Tank", "00000000-0000-0000-0000-000000000027" },
                    { new Guid("00000000-0000-0000-0038-000000000000"), 656, 80, "Druid", false, 189, 60, "Gartand", "Healer", "00000000-0000-0000-0000-000000000013" },
                    { new Guid("00000000-0000-0000-0039-000000000000"), 276, 1873, "Warrior", false, 166, 60, "Variann", "Dps", "00000000-0000-0000-0000-000000000013" },
                    { new Guid("00000000-0000-0000-0078-000000000000"), 1914, 306, "Demon Hunter", false, 201, 60, "Akzelo", "Tank", "00000000-0000-0000-0000-000000000026" },
                    { new Guid("00000000-0000-0000-0077-000000000000"), 241, 803, "Druid", false, 193, 60, "Mocarl", "Tank", "00000000-0000-0000-0000-000000000026" },
                    { new Guid("00000000-0000-0000-0076-000000000000"), 351, 1172, "Shaman", false, 166, 60, "Eunich", "Healer", "00000000-0000-0000-0000-000000000026" },
                    { new Guid("00000000-0000-0000-0040-000000000000"), 147, 1057, "Demon Hunter", false, 176, 60, "Irridan", "Dps", "00000000-0000-0000-0000-000000000014" },
                    { new Guid("00000000-0000-0000-0041-000000000000"), 1265, 357, "Druid", false, 224, 60, "Aralon", "Tank", "00000000-0000-0000-0000-000000000014" },
                    { new Guid("00000000-0000-0000-0075-000000000000"), 161, 685, "Shaman", false, 204, 60, "Statfo", "Healer", "00000000-0000-0000-0000-000000000025" },
                    { new Guid("00000000-0000-0000-0074-000000000000"), 1112, 1, "Priest", false, 173, 60, "Lantis", "Healer", "00000000-0000-0000-0000-000000000025" },
                    { new Guid("00000000-0000-0000-0073-000000000000"), 771, 1822, "Monk", false, 225, 60, "Merlac", "Healer", "00000000-0000-0000-0000-000000000025" },
                    { new Guid("00000000-0000-0000-0042-000000000000"), 401, 626, "Paladin", false, 205, 60, "Sharyn", "Tank", "00000000-0000-0000-0000-000000000014" },
                    { new Guid("00000000-0000-0000-0043-000000000000"), 711, 114, "Hunter", false, 189, 60, "Tharon", "Dps", "00000000-0000-0000-0000-000000000015" },
                    { new Guid("00000000-0000-0000-0072-000000000000"), 862, 169, "Monk", false, 207, 60, "Reming", "Dps", "00000000-0000-0000-0000-000000000024" },
                    { new Guid("00000000-0000-0000-0071-000000000000"), 1876, 515, "Hunter", false, 183, 60, "Bluffw", "Dps", "00000000-0000-0000-0000-000000000024" },
                    { new Guid("00000000-0000-0000-0070-000000000000"), 1857, 1921, "Druid", false, 164, 60, "Zaldim", "Dps", "00000000-0000-0000-0000-000000000024" },
                    { new Guid("00000000-0000-0000-0044-000000000000"), 620, 866, "Rogue", false, 159, 60, "Phyrin", "Dps", "00000000-0000-0000-0000-000000000015" },
                    { new Guid("00000000-0000-0000-0069-000000000000"), 1516, 1267, "Warlock", false, 188, 60, "Sterne", "Dps", "00000000-0000-0000-0000-000000000023" },
                    { new Guid("00000000-0000-0000-0001-000000000000"), 1301, 1079, "Death Knight", false, 165, 60, "Ghortak", "Tank", "00000000-0000-0000-0000-000000000001" }
                });

            migrationBuilder.InsertData(
                table: "ArenaCharacter",
                columns: new[] { "ArenaId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000000-0004-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0003-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0002-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0002-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0003-0000-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("00000000-0004-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0010-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0009-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000000-0008-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0007-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0006-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0005-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "BattlegroundCharacter",
                columns: new[] { "BattlegroundId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0007-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0010-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0006-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "DungeonCharacter",
                columns: new[] { "DungeonId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0029-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0021-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0029-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0022-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0029-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0027-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0021-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0027-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0027-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0021-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0011-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0030-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("00000007-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0011-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") },
                    { new Guid("00000006-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("00000008-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0011-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "RaidCharacter",
                columns: new[] { "RaidId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0024-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0016-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0012-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0019-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0009-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0018-000000000000") },
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArenaCharacter_CharacterId",
                table: "ArenaCharacter",
                column: "CharacterId");

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
                name: "IX_BattlegroundCharacter_CharacterId",
                table: "BattlegroundCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DungeonCharacter_CharacterId",
                table: "DungeonCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_RaidCharacter_CharacterId",
                table: "RaidCharacter",
                column: "CharacterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArenaCharacter");

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
                name: "BattlegroundCharacter");

            migrationBuilder.DropTable(
                name: "DungeonCharacter");

            migrationBuilder.DropTable(
                name: "RaidCharacter");

            migrationBuilder.DropTable(
                name: "Arenas");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Battlegrounds");

            migrationBuilder.DropTable(
                name: "Dungeons");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Raids");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
