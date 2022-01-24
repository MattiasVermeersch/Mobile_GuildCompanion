using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class UpdateSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArenaCharacter",
                keyColumns: new[] { "ArenaId", "CharacterId" },
                keyValues: new object[] { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") });

            migrationBuilder.InsertData(
                table: "ArenaCharacter",
                columns: new[] { "ArenaId", "CharacterId" },
                values: new object[] { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") });

            migrationBuilder.UpdateData(
                table: "Arenas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0001-0000-0000-000000000000"),
                columns: new[] { "Date", "IsWon" },
                values: new object[] { new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Arenas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0002-0000-0000-000000000000"),
                columns: new[] { "Date", "IsWon" },
                values: new object[] { new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Arenas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0003-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "731730e3-0b51-4642-8f07-ff17300fc29c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "ba53be18-830e-4a07-98e4-f37ee6ae0c05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "ee737fe6-35b4-4278-a65b-811d34f866da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004",
                column: "ConcurrencyStamp",
                value: "b5a29aeb-3600-488a-ade3-b2ce8109bba4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1976, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "3185cf98-fb1c-4e66-964b-22f989b4fc90", false, "AQAAAAEAACcQAAAAEIxUAL31J9BqQHRh1UvPSY2SGU7P0X+nVNSkCzxf/vs5nChLwkXsKtJP8uYdMbNJeA==", "6e6b1c87-5cdb-4978-995a-70a33cf604b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "eee72374-4af8-477f-be96-be2805bc0d46", "AQAAAAEAACcQAAAAEO+mXl/tLhNi4A/TiMXkbbmJCpH4C21V2vdO4YbJZ2kUwAVcSf1BAC4QqmIa8Hx+7Q==", "88b868c1-31b2-4436-9de0-5b3e7bd0bd09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1984, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "b44c8aa8-a0ba-4303-8032-ca2bc312b611", "AQAAAAEAACcQAAAAEFk2UmwExyEhXPZQ6rKkT9xfiX+ri7fQ3pg07rtmq3uxDwibER1ourDpA0FH9+D3OA==", "05b8c971-9e62-4e60-8069-c7f58de31968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1978, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "2841f638-5060-4930-a359-4d45b214310a", "AQAAAAEAACcQAAAAEFc3C2FRELBwG43RuPhCFCyS3Ibf/4ziAER5ZTd5vYgNsy21rxcPMC8vX2xDMCNVLA==", "61508882-d919-438a-9fe7-c10cedae2c5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "4418cfbd-3c99-4111-96db-2118531e47d5", false, "AQAAAAEAACcQAAAAEHWozJtp9zsPi/Qk4AGLNsxD4X8XaqGgyD5Lev/b42JDDVhOK0eDNp0iuBluDfQpng==", "de1d93d3-d1b6-4f50-84a9-593ece9a858a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1983, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "72b83e2f-2b51-4a82-bfbe-12ca59fc2ed2", false, "AQAAAAEAACcQAAAAEEkhgBAGa13bGdU4Rf6EiwDVlP7yFIjxHB87585YIVZTfsXWjw5VzpiP8j99Hz7KVA==", "62805887-8f33-4e10-b0d2-cadfe4568bc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "665aaa72-afbd-436f-ba3b-8edf4c39473f", true, "AQAAAAEAACcQAAAAEAKNgx+FQdklbN+6+qzXYIZxpzGVAUD3ealc6ZkAMeVjHPHG/kKyoM9nafsjm3cOjw==", "07da99b7-a798-4ac6-ad85-0b02cb8f6cec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "2c474edd-eb01-4143-b8bf-5bd5a319412a", "AQAAAAEAACcQAAAAECWFonujoyhgUC02U4KSC///vXYpyGugxnXegD7d2X5ijpyEzjI1rbCF54leWxpvWQ==", "8454491d-c9f6-4e7d-b667-ccbc283c174f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "4b2c3f51-a2bc-4488-9ba4-3925cd1ebfba", "AQAAAAEAACcQAAAAEDRGhzla75fLagDkBayHXxSaFpcUsWck1U7iIunvwkeGzhuDBHrgY6iH8zLkUaQpNQ==", "be2f2801-151f-4759-8bc5-36d832b808a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "6de714e8-3a70-4934-857f-b029f5d30ffb", "AQAAAAEAACcQAAAAEJ18uDKTJleC0ZeSru3eVhcgu2MUAEW6t435+r7W9L/Ari318o3GhFLpyws7wIsvng==", "0f850dee-40dc-420b-8e59-5fb2560786cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "f0a5e758-d416-4b64-990e-4e8da6f68c33", "AQAAAAEAACcQAAAAEP3bb+F6Zr4M1Fd0NBvK6pK6aBPEQ3S13Pd9bfqfIj5/xf+9RYsLXI6NLz3DsIjhKg==", "7befca6f-bea4-430f-ba38-8c29e01675a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1971, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "b7ddb4ab-7e1e-4128-ac70-f90fd4e52451", "AQAAAAEAACcQAAAAEPYrb0TuT3WCAsGFG+QVxy+nPo7e0/LWEx/YRFVibyyyMWgW4R8chXDtDorE4leCVQ==", "9701e54f-cf49-43ec-80b2-cfe7ac4bb607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "737a593e-a8be-4ce2-ae4a-07a849395c11", "AQAAAAEAACcQAAAAEOSTUfZDWslQlf38Q14hvm2XThKIVN30M+4Ak5HqWEtY5hfFDuz32DaOfNblsgWEPw==", "30e76815-c691-47a8-abb2-d07a3cae41a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "2b7e95b7-d7f6-4527-afbb-008c82ae468b", "AQAAAAEAACcQAAAAED8muEwBzSTdULgAr8ZLAHnoOTz8kt98IGK5oSfTwTSq3aXBmI3VoZdkvB/wxgBGEg==", "ec1a1fc6-48e1-46da-aa99-c972de43a6b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1978, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "990d93a5-c3cd-46e1-8361-303face2ad95", "AQAAAAEAACcQAAAAEJmYDJPUJf3/UMxwz0d8KOfwbWW3PLZ+xJsmPSUPDFpweD8EWohIYhGK8IUvu1do0A==", "1ba0f94d-17ee-47f2-8029-39cbdaa85daf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1990, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "eb5190d2-c50c-46d1-b6c1-247ef5a25434", "AQAAAAEAACcQAAAAEEmmeZg82OLyn2xcCkyU6EvOMJdN+hYybleiAPXEVfJ8ZsMjGDM83tks13CfXNN2ow==", "ac3be5c8-d505-4fe4-b271-d05fb4c3acf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "7de4763c-10de-4b85-bdaf-8aa56a223066", false, "AQAAAAEAACcQAAAAEGC6+HxCBaZPHWaeL6XOxs9pBZiEs0UUrJOcm+PCF0DfHRrRB9WqUccNK43p4Tit4Q==", "45c6e161-9204-4215-9b6c-3eea1e1fded5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1997, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "bbb6e568-bee2-48d3-9af1-818c417042aa", "AQAAAAEAACcQAAAAEIOGUrjgOQ3FFAaaFDJ2EOyF2tjBerZ+XGOVPCBJD4Di44Su7t+6l8IM/Heo4ys0hw==", "14e71f4e-50d3-4c83-beb6-19fc1e89d4e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "346a49f2-5762-4f20-886c-427bede51a17", true, "AQAAAAEAACcQAAAAEONosYT+Q4yef8Myx/SEShGu1sysDhSCrjQavcpRJQVJ/074fw/2+unhLtw1feEa3g==", "7cd210b1-1d32-42c9-b39b-143a017a063f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "11a90ad5-1978-4929-a79a-62ef3790eb90", "AQAAAAEAACcQAAAAEBu6uEYc0MEy8mHxYsJnaC5AIHpNxTTxvOrw0uKn6CZlvdVe2Cu+Y9NVED9fJRIaKA==", "d0d60b3f-95c0-4a2e-a68d-0ba100c1f13e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "ef9641fa-1313-4144-84ea-bd8a71c211f7", false, "AQAAAAEAACcQAAAAEMgP7vdcbGs2XBkofVIH7DYf6QcPQQRmM+dwdBtVuWwus+G7jkuqSTJ0b19xyaebHw==", "577676a3-f8d5-4220-af56-ef189917c382" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "24608215-0849-4a07-abfe-fb7700940d2a", "AQAAAAEAACcQAAAAEEQrcDUScfF6V8mo5Ff1B032Zuj73Wz6U7WlaTD6lBd6jWPfkcY5ucWRg+nei+JkHw==", "ea589a7a-cdaf-4a87-8015-157e205ec9d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "39f548ef-38de-489c-b922-b95c55a77ed8", "AQAAAAEAACcQAAAAEOZKy8nh+S7tWY1lxVO1Tpet4Y79XGi0APuGW0HFXwKK75e8LTwHibuSRfcL8iGfPQ==", "33ad9d76-32f4-4198-9abd-02dcfafd8651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "e0d29ef9-f344-4005-bcaf-c333d45a0809", "AQAAAAEAACcQAAAAEMqGdli3LV6vN8re6zKm2ir32GQ7bGsUPDATtYRX3PYSABTFUsO3T90HWtVVyJvKbQ==", "c90b1892-e488-4ebd-beca-266e95485a20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "0f254cc1-2dc4-4f99-9155-a53d8197af32", "AQAAAAEAACcQAAAAEM0TW4VNOb60q6K6T8SkNwx/rJ61E3pyLSTxFqPR0SjDs4L3Ue5YnGXpl+49gidoyg==", "4d892149-f9c6-491e-87d4-ac026dc138df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "d2e527c5-5d65-4ce7-85b8-e3c37d6941b8", "AQAAAAEAACcQAAAAEKm6eiKCLtnu+CoRk4gPtxmW/1GujM0XgsW2oOSNCK2bDxW1aY7GjqmOTzJT6d1aFQ==", "59223b03-ea6e-43bd-b96c-dd9ebff1be66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1979, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "808060ef-c872-4a77-bb5e-837486bf307a", "AQAAAAEAACcQAAAAEPNN2ZASOtkANNgp3sunCcLhjnvOFDy2dK6oINBXy+bwTGqSVGV8FlGBlCL3XFnVVA==", "4b05d375-11ff-409c-9a36-aff8fb96d0d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0cd7fd24-1cab-431b-b141-bf8294780962", false, "AQAAAAEAACcQAAAAEBmvQikRVbq43taAf9jn7qv3m0WlfllVwDDb3UK7cYPUbbbkbpdvB/OD7bNSA2nmGA==", "0b6cf3cc-55e7-4b0b-b0db-b4621dd802a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1973, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "2d8bf954-0318-45f7-b02e-9cdf9327607f", "AQAAAAEAACcQAAAAEHqwRq85ysQhL8EJZhmiGiGJi2Pv2dMb8U2RnUTHCG0+UXUFbuSLXdqcOhPfVMJORg==", "b2affb12-c0a7-4c48-84f3-cb3026ee2c0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1985, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "e5028359-e906-48ea-83ea-ca6dede7d327", "AQAAAAEAACcQAAAAEPrvBd/zLroJNRSkElwBx1BrpMlh6YiYSXURaDlyDEglJEiRzwynJmngEoY1yP1DZQ==", "ff0aca21-08c9-4c5b-8ae9-810f67156799" });

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0001-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0002-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0003-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0004-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0005-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "DungeonCharacter",
                columns: new[] { "DungeonId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "RaidCharacter",
                columns: new[] { "RaidId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2022, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanctum of Domination" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2022, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanctum of Domination" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanctum of Domination" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanctum of Domination" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanctum of Domination" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArenaCharacter",
                keyColumns: new[] { "ArenaId", "CharacterId" },
                keyValues: new object[] { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0013-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") });

            migrationBuilder.DeleteData(
                table: "DungeonCharacter",
                keyColumns: new[] { "DungeonId", "CharacterId" },
                keyValues: new object[] { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.DeleteData(
                table: "RaidCharacter",
                keyColumns: new[] { "RaidId", "CharacterId" },
                keyValues: new object[] { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") });

            migrationBuilder.InsertData(
                table: "ArenaCharacter",
                columns: new[] { "ArenaId", "CharacterId" },
                values: new object[] { new Guid("00000000-0001-0000-0000-000000000000"), new Guid("00000000-0000-0000-0008-000000000000") });

            migrationBuilder.UpdateData(
                table: "Arenas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0001-0000-0000-000000000000"),
                columns: new[] { "Date", "IsWon" },
                values: new object[] { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Arenas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0002-0000-0000-000000000000"),
                columns: new[] { "Date", "IsWon" },
                values: new object[] { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Arenas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0003-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "58d4d0b8-9068-42ba-8984-eaa2b702b556");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000002",
                column: "ConcurrencyStamp",
                value: "3b51afd4-bb35-4635-ace8-1ed112d53981");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000003",
                column: "ConcurrencyStamp",
                value: "0a3bcda5-5005-43e2-bc12-c5e9cf69d5e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-000000000004",
                column: "ConcurrencyStamp",
                value: "ddd7e507-efdc-4a58-8348-5654de0285e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "67b2e934-2f3f-487d-9bfa-22143364aaf4", true, "AQAAAAEAACcQAAAAEE2MqhLvWJ/RANI57wihcKzYRjsUlbae/15B5HRt/T70NnPzk/CVpXRmj6m8vXT7GQ==", "1a94e148-dcb3-49d8-a12f-3f9befaaf9da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "2acbbe23-b45a-40db-b79a-edc3fbac8f54", "AQAAAAEAACcQAAAAEDW7z6yLkFXcTEVicIDShIkeTkYbamnfpoaHVqucxJcUzzP+2g09TJYutY8vjAB65w==", "53f9bd8c-891f-4138-8aac-c31472fdce3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "92c0ed1e-68f8-4b16-8109-a22b207be44a", "AQAAAAEAACcQAAAAEH5d66DBysbT3wPmLm0EiFByACRkEqKl/R2j78zj5L7bfNf1Lk/4VPIvUuDfSjykCg==", "88047215-e623-45d1-997b-36a9fc9e82ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1975, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "415c687d-181e-43da-bf17-457fac0a2ddb", "AQAAAAEAACcQAAAAECcJM9XQmZkj58kotgjXrLbLj32ytg4fOPStRfbbmtaybYza6iFhV5UAbx90g4fUlg==", "f495d8ca-a8de-42ae-95bb-4915c019b54a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "77aa0003-5d3e-4026-81f1-ac52adeb52aa", true, "AQAAAAEAACcQAAAAEFVoecwxU2cfQH8nPT9ABTvvV7wZ4boxL3DWrhXvMkjlrgPE1S0P3oXC0XkDK6ELYw==", "431cd7cf-ad96-4569-b63b-89c2ca25cb55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "60f1e765-02a9-434e-99ea-da13691ab038", true, "AQAAAAEAACcQAAAAEJY9obtjzSxQYD95hK3PlP+R1+JMtByyKTNfzcsegkQLE0kZ0BY90kEeN9urIieWkA==", "9e616bfc-1d88-412b-97cd-378ccb6bf175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "ed9d209a-b389-4eeb-bb24-b3ece61aa6f8", false, "AQAAAAEAACcQAAAAEHNPn2USyevdpipFVNROd1zehPGxg6JQ89s8g4PxchbgfvgBaqhTz8WReL87m/nwtA==", "6783a88d-e907-453b-b6f4-1223bb6a0d0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1976, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "b55785c8-82fc-45cd-bc4c-9358dde12929", "AQAAAAEAACcQAAAAEBV9MJqK6LXHSDwYMiYYfLM7uOyRfb2JCUQyuZ2tWVydeaO5cZhnRTs/fpcNYBxbcg==", "96937c38-c3fc-4e4b-8a06-0f8e96212f11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1991, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "59737250-b0f3-4d28-a7a8-7bf2407ec2f6", "AQAAAAEAACcQAAAAELQd4vLwkqM2PYWDmtVU0PT9HSHjYnyghfA8XPMp2Gc6BwCBjDT6Yxftjul7wg1FBQ==", "f51e9bdd-d858-4115-8a42-bc9a8c987896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "6f745242-9ece-4690-a7af-9d7be2e08dd8", "AQAAAAEAACcQAAAAENYZKO7gvcz+QdSWc0GlWIHH1oy68NYYAvqu6vcf+QCinHBssp5D80eVuqAqiolujw==", "c1451956-f9fb-482c-be88-9e163aba76bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2000, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "f30685ef-a6a6-4433-99f5-51a1e9e3dad2", "AQAAAAEAACcQAAAAEA+5p6Dyb/WBkINOskJi2zkt9MmbjznAICJ91LW/YGd8ZLkcKQ3XwibTXCxHYn3Pmw==", "5cf90957-3a33-447d-b9cc-2a40ab0262bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "a0740ca8-6e31-4bdf-b962-470151d60689", "AQAAAAEAACcQAAAAEPxEopLz97+cjmaiEWn3NLhEjggpgG8fSEcKwpR57FFLRk9sxxFJqn28/M5MiUvEkQ==", "07a6a480-8f28-4735-8fc1-53f95614f64f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1972, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "eb67608d-b42e-47f1-8021-fefb26cf3407", "AQAAAAEAACcQAAAAEGHoEf8xNOAGda50Jfbzi2FulE0d7hAxxaonTdkNCtwspjfP9NcN0bXg2TK3mUObLg==", "d6f0d89e-b324-4513-8ebc-4b2c731acb13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1977, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "35bfcd6d-26ed-4fa8-b488-4951cf981438", "AQAAAAEAACcQAAAAELfDgDRq74PC0qVSMHlxlyRjbiM86ptMkeNuVmWKO2DekNTIUnZWx1hcUkD1IwW08Q==", "c106b1dc-4636-4060-8251-181d6f482a82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1974, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "c1d47682-346e-47f0-ab02-36a0b34cd441", "AQAAAAEAACcQAAAAED6KlZMatuH1WzIAXcGpsZQsuMmvZduDDHeJ0bhvjpZ4ku7uWJzSU/oA3vZMP7VIGw==", "1db84d01-b470-4bc7-bb71-e272391a9901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "af2fc919-efee-4cdd-855d-5948b5f1a435", "AQAAAAEAACcQAAAAEL6hGAdIJhymDg9Z4v8rYYrlkj2Uj8ZcJp6tRsQjUIMvift20x6mtMh+rI08X+smbg==", "f053bc9f-7709-4ded-a221-a453baa67be5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "930cf85b-9ebe-4acb-b029-356217ad1319", true, "AQAAAAEAACcQAAAAEAMuzi+3IniWUtRSoUbwuudxZU0YjVYzEtzeUZeJ3ylK8upCpFwum4OFxGsfj/FqRg==", "c4e2f2b3-5f87-4ca7-b55f-5a3381e79aa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1973, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "f0509e34-9d98-4e3b-82b9-200747de0ea3", "AQAAAAEAACcQAAAAEI9WZ7Qtg4+lX712rpz5DmxDA7JLwHq63wxN/Zi1mkS8NO69wEBUq50bPG8+7hWfDQ==", "54866d0f-0e14-4320-8351-b8af6379d145" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "669c65cd-c9ec-4567-b95d-9baf625df17e", false, "AQAAAAEAACcQAAAAENRmu5rXz+bcQv6dBmwbfXBRy4ZTmw6M7O3gGsP0eof/jsI3R6yFCtc+/TtxcKM7MA==", "8fb9bc7e-c7ac-425d-b433-4bdb0c5c0287" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1982, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "4510ad96-67c4-4ed6-a280-6477e274ba66", "AQAAAAEAACcQAAAAEKDXNS3lpeEzOY4eHFQ71KKe3BJgphSNPyj4VvS7HThixe02lFSLAP6/f2dRRnvC4A==", "2018f434-c152-4eed-9cec-ddee1ed4ba7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1981, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "c87211a9-ea25-49a3-a64e-49755a989d76", true, "AQAAAAEAACcQAAAAEI9RrzOgqz04p4iycRG2iTS4xwLo7FjhlnVHuIn2zKeYbPY105rJJ26vWocUigwduw==", "37492842-aab3-4f80-a9e2-18824aa77d98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1996, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "699c294e-bf4e-4951-bc60-6e401ff8d4c1", "AQAAAAEAACcQAAAAEOa2l3JltfbANbrZGnaXai/7cbwnhmN4NUG70V0FRd1gP7mo5uKJaMY2GiI13WowUQ==", "70c34373-bcf3-40ac-bea5-b3e2068e17b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasselt", "66acb3f7-9ca6-489d-b11f-e30125e639ce", "AQAAAAEAACcQAAAAEGlnmE8BbWuhcN0w4IQL9Yjr/8XKVWKrD7xlIkOTwq2aJ0PrICFLGmqMqTi6OUAx2A==", "e4b63c65-6460-41fd-94b5-10cf87f22db6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antwerpen", "553c2ec3-d730-4d04-986c-0bfee646c728", "AQAAAAEAACcQAAAAEDOylYSJB8/WO68z2C/qaZZ11zTNnB5fMXyHmkfKJmN/hl+MHQ45UVWFMQ6sRDjDNg==", "965b0f0f-e70a-4553-8b46-290f41e14a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "6590a0bf-3df9-4ac2-a4c1-e2041fb42e02", "AQAAAAEAACcQAAAAEKVt7YKNDySZcNyTboNfmASoCq6VXs0TXISfCuyzWZ+D+mU/0MCHgAa1hvcUafUnAg==", "72efeccc-5cdb-43b7-b1ed-5846991eee59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1992, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "26f43a11-1b8a-4b7f-a3a8-d72768120f9e", "AQAAAAEAACcQAAAAEFFzeEILFHFUTGPjoSCjZBhs3BJ5hXTMAXBEUJSpXF+oMihcV5JDgRiNv9FSdTRhHg==", "b65c244e-dcdf-4179-a7fc-1f04425576bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1994, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "7386a97c-3018-4e9a-a10b-22bd487ddf2a", "AQAAAAEAACcQAAAAEDg+7JY7rr6iEVR5iilIxfjE161QBYvrZZu+JXiroLec/hZkY7aLK0O6JdpvR9xuUA==", "b29fe10b-d1f7-4ec5-8fe2-fdfc663ad8f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1998, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "040813a5-c5a4-4201-943c-fb869b5eb160", true, "AQAAAAEAACcQAAAAEOAMjaU11WmGnyRksOBHAg2NQhvsJvI5hywUafW/LnLtrJ9/tXxE0oSN+mztrBlpQw==", "ceea70f3-d7b2-4efe-a4b3-dd24d4eb0dfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1976, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "bd4085f6-3f82-43d1-955f-202309577091", "AQAAAAEAACcQAAAAELPyupi8E9MXJgdabuYMm4QemOFxrjTI1qF1BuClwqxlKyeOuzXcQXxBrK6kcm0bfw==", "e60e7d53-a7c7-46c9-b2ea-c2593118820b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "BirthDate", "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(1995, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussel", "0643af10-acef-417c-b835-1c2d38fa5f50", "AQAAAAEAACcQAAAAECH27HwuLC7qJKOgLJUuP1hTDpPgeHkBzqKKfFehAUq7Y82VFr1/+Ks3PruY9+ysfg==", "09a34d7f-f679-4198-bc3d-aa37fbe6ea78" });

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0001-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0002-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0003-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0004-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Battlegrounds",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0005-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "DungeonCharacter",
                columns: new[] { "DungeonId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("00000005-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0014-000000000000") },
                    { new Guid("00000004-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0015-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0025-000000000000") },
                    { new Guid("00000003-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000002-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") },
                    { new Guid("00000001-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0020-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000002-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000003-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dungeons",
                keyColumn: "Id",
                keyValue: new Guid("00000004-0000-0000-0000-000000000000"),
                column: "Date",
                value: new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "RaidCharacter",
                columns: new[] { "RaidId", "CharacterId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("20000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("30000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("40000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("50000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caste Nathria" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caste Nathria" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("30000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caste Nathria" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("40000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caste Nathria" });

            migrationBuilder.UpdateData(
                table: "Raids",
                keyColumn: "Id",
                keyValue: new Guid("50000000-0000-0000-0000-000000000000"),
                columns: new[] { "Date", "InstanceName" },
                values: new object[] { new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caste Nathria" });
        }
    }
}
