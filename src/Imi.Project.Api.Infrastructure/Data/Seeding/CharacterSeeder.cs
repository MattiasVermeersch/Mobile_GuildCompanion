using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class CharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0001-000000000000"),
                    Name = "Ghortak",
                    Class = "Death Knight",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 165,
                    ArenaRating = 1301,
                    BattlegroundRating = 1079,
                    UserId = "00000000-0000-0000-0000-000000000001"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0002-000000000000"),
                    Name = "Bauglir",
                    Class = "Druid",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 216,
                    ArenaRating = 496,
                    BattlegroundRating = 1812,
                    UserId = "00000000-0000-0000-0000-000000000001"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0003-000000000000"),
                    Name = "Shiroe",
                    Class = "Priest",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 215,
                    ArenaRating = 160,
                    BattlegroundRating = 1940,
                    UserId = "00000000-0000-0000-0000-000000000001"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0004-000000000000"),
                    Name = "Yoriko",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 166,
                    ArenaRating = 1448,
                    BattlegroundRating = 395,
                    UserId = "00000000-0000-0000-0000-000000000002"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0005-000000000000"),
                    Name = "Elen",
                    Class = "Warlock",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 223,
                    ArenaRating = 1538,
                    BattlegroundRating = 1814,
                    UserId = "00000000-0000-0000-0000-000000000002"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0006-000000000000"),
                    Name = "Tary",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 1788,
                    BattlegroundRating = 1980,
                    UserId = "00000000-0000-0000-0000-000000000002"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0007-000000000000"),
                    Name = "Borugor",
                    Class = "Warrior",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 199,
                    ArenaRating = 1607,
                    BattlegroundRating = 1652,
                    UserId = "00000000-0000-0000-0000-000000000003"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0008-000000000000"),
                    Name = "Wildstrider",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 222,
                    ArenaRating = 1385,
                    BattlegroundRating = 258,
                    UserId = "00000000-0000-0000-0000-000000000003"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0009-000000000000"),
                    Name = "Liutasil",
                    Class = "Paladin",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 200,
                    ArenaRating = 424,
                    BattlegroundRating = 54,
                    UserId = "00000000-0000-0000-0000-000000000003"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0010-000000000000"),
                    Name = "Aerenthil",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 145,
                    ArenaRating = 38,
                    BattlegroundRating = 538,
                    UserId = "00000000-0000-0000-0000-000000000004"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0011-000000000000"),
                    Name = "Ghinin",
                    Class = "Monk",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 193,
                    ArenaRating = 1279,
                    BattlegroundRating = 746,
                    UserId = "00000000-0000-0000-0000-000000000004"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0012-000000000000"),
                    Name = "Nuremor",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 145,
                    ArenaRating = 64,
                    BattlegroundRating = 1586,
                    UserId = "00000000-0000-0000-0000-000000000004"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0013-000000000000"),
                    Name = "Rhamanji",
                    Class = "Shaman",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 185,
                    ArenaRating = 210,
                    BattlegroundRating = 1322,
                    UserId = "00000000-0000-0000-0000-000000000005"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0014-000000000000"),
                    Name = "Ebrothil",
                    Class = "Priest",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 30,
                    BattlegroundRating = 1825,
                    UserId = "00000000-0000-0000-0000-000000000005"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0015-000000000000"),
                    Name = "Tyrigon",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 937,
                    BattlegroundRating = 885,
                    UserId = "00000000-0000-0000-0000-000000000005"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0016-000000000000"),
                    Name = "Aeternus",
                    Class = "Paladin",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 202,
                    ArenaRating = 517,
                    BattlegroundRating = 194,
                    UserId = "00000000-0000-0000-0000-000000000006"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0017-000000000000"),
                    Name = "Trech",
                    Class = "Monk",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 201,
                    ArenaRating = 983,
                    BattlegroundRating = 1337,
                    UserId = "00000000-0000-0000-0000-000000000006"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    Name = "Baradhor",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 201,
                    ArenaRating = 1107,
                    BattlegroundRating = 64,
                    UserId = "00000000-0000-0000-0000-000000000007"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0019-000000000000"),
                    Name = "Eranthil",
                    Class = "Druid",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 199,
                    ArenaRating = 1810,
                    BattlegroundRating = 1648,
                    UserId = "00000000-0000-0000-0000-000000000007"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0020-000000000000"),
                    Name = "Morgoroth",
                    Class = "Warlock",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 139,
                    ArenaRating = 344,
                    BattlegroundRating = 637,
                    UserId = "00000000-0000-0000-0000-000000000007"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0021-000000000000"),
                    Name = "Malefikh",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 157,
                    ArenaRating = 1356,
                    BattlegroundRating = 1849,
                    UserId = "00000000-0000-0000-0000-000000000007"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    Name = "Ashifal",
                    Class = "Death Knight",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 1309,
                    BattlegroundRating = 2057,
                    UserId = "00000000-0000-0000-0000-000000000008"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0023-000000000000"),
                    Name = "Umbrion",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 188,
                    ArenaRating = 1029,
                    BattlegroundRating = 296,
                    UserId = "00000000-0000-0000-0000-000000000008"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0024-000000000000"),
                    Name = "Coolbone",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 192,
                    ArenaRating = 1401,
                    BattlegroundRating = 890,
                    UserId = "00000000-0000-0000-0000-000000000008"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0025-000000000000"),
                    Name = "GilGalad",
                    Class = "Warrior",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 177,
                    ArenaRating = 1467,
                    BattlegroundRating = 1230,
                    UserId = "00000000-0000-0000-0000-000000000009"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0026-000000000000"),
                    Name = "Yreleth",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 169,
                    ArenaRating = 1804,
                    BattlegroundRating = 1386,
                    UserId = "00000000-0000-0000-0000-000000000009"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0027-000000000000"),
                    Name = "Bromir",
                    Class = "Monk",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 152,
                    ArenaRating = 1910,
                    BattlegroundRating = 48,
                    UserId = "00000000-0000-0000-0000-000000000009"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0028-000000000000"),
                    Name = "Phandalor",
                    Class = "Druid",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 152,
                    ArenaRating = 46,
                    BattlegroundRating = 1185,
                    UserId = "00000000-0000-0000-0000-000000000010"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0029-000000000000"),
                    Name = "Myriad",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 174,
                    ArenaRating = 618,
                    BattlegroundRating = 944,
                    UserId = "00000000-0000-0000-0000-000000000010"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0030-000000000000"),
                    Name = "Ithaela",
                    Class = "Paladin",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 201,
                    ArenaRating = 604,
                    BattlegroundRating = 1808,
                    UserId = "00000000-0000-0000-0000-000000000010"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0031-000000000000"),
                    Name = "Malfurion",
                    Class = "Druid",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 170,
                    ArenaRating = 73,
                    BattlegroundRating = 522,
                    UserId = "00000000-0000-0000-0000-000000000011"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0032-000000000000"),
                    Name = "Faron",
                    Class = "Priest",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 193,
                    ArenaRating = 630,
                    BattlegroundRating = 421,
                    UserId = "00000000-0000-0000-0000-000000000011"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0033-000000000000"),
                    Name = "Krilli",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 209,
                    ArenaRating = 505,
                    BattlegroundRating = 976,
                    UserId = "00000000-0000-0000-0000-000000000011"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0034-000000000000"),
                    Name = "Fandor",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 163,
                    ArenaRating = 1679,
                    BattlegroundRating = 1013,
                    UserId = "00000000-0000-0000-0000-000000000012"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0035-000000000000"),
                    Name = "Marissa",
                    Class = "Monk",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 203,
                    ArenaRating = 1724,
                    BattlegroundRating = 1117,
                    UserId = "00000000-0000-0000-0000-000000000012"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0036-000000000000"),
                    Name = "Aokie",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 195,
                    ArenaRating = 1423,
                    BattlegroundRating = 418,
                    UserId = "00000000-0000-0000-0000-000000000012"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0037-000000000000"),
                    Name = "Laughen",
                    Class = "Paladin",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 199,
                    ArenaRating = 151,
                    BattlegroundRating = 723,
                    UserId = "00000000-0000-0000-0000-000000000013"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0038-000000000000"),
                    Name = "Gartand",
                    Class = "Druid",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 189,
                    ArenaRating = 656,
                    BattlegroundRating = 80,
                    UserId = "00000000-0000-0000-0000-000000000013"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0039-000000000000"),
                    Name = "Variann",
                    Class = "Warrior",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 166,
                    ArenaRating = 276,
                    BattlegroundRating = 1873,
                    UserId = "00000000-0000-0000-0000-000000000013"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0040-000000000000"),
                    Name = "Irridan",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 176,
                    ArenaRating = 147,
                    BattlegroundRating = 1057,
                    UserId = "00000000-0000-0000-0000-000000000014"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0041-000000000000"),
                    Name = "Aralon",
                    Class = "Druid",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 224,
                    ArenaRating = 1265,
                    BattlegroundRating = 357,
                    UserId = "00000000-0000-0000-0000-000000000014"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0042-000000000000"),
                    Name = "Sharyn",
                    Class = "Paladin",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 205,
                    ArenaRating = 401,
                    BattlegroundRating = 626,
                    UserId = "00000000-0000-0000-0000-000000000014"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0043-000000000000"),
                    Name = "Tharon",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 189,
                    ArenaRating = 711,
                    BattlegroundRating = 114,
                    UserId = "00000000-0000-0000-0000-000000000015"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0044-000000000000"),
                    Name = "Phyrin",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 159,
                    ArenaRating = 620,
                    BattlegroundRating = 866,
                    UserId = "00000000-0000-0000-0000-000000000015"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0045-000000000000"),
                    Name = "Clerence",
                    Class = "Warrior",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 164,
                    ArenaRating = 1707,
                    BattlegroundRating = 1831,
                    UserId = "00000000-0000-0000-0000-000000000015"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0046-000000000000"),
                    Name = "Meeky",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 205,
                    ArenaRating = 1287,
                    BattlegroundRating = 1675,
                    UserId = "00000000-0000-0000-0000-000000000016"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0047-000000000000"),
                    Name = "Feeky",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 160,
                    ArenaRating = 1533,
                    BattlegroundRating = 1541,
                    UserId = "00000000-0000-0000-0000-000000000016"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0048-000000000000"),
                    Name = "Beeky",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 190,
                    ArenaRating = 1771,
                    BattlegroundRating = 904,
                    UserId = "00000000-0000-0000-0000-000000000016"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0049-000000000000"),
                    Name = "Sylvar",
                    Class = "Warrior",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 210,
                    ArenaRating = 1654,
                    BattlegroundRating = 85,
                    UserId = "00000000-0000-0000-0000-000000000017"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0050-000000000000"),
                    Name = "Laryngo",
                    Class = "Druid",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 163,
                    ArenaRating = 639,
                    BattlegroundRating = 713,
                    UserId = "00000000-0000-0000-0000-000000000017"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0051-000000000000"),
                    Name = "Saveron",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 220,
                    ArenaRating = 611,
                    BattlegroundRating = 991,
                    UserId = "00000000-0000-0000-0000-000000000017"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0052-000000000000"),
                    Name = "Landarin",
                    Class = "Paladin",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 161,
                    ArenaRating = 683,
                    BattlegroundRating = 1868,
                    UserId = "00000000-0000-0000-0000-000000000018"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0053-000000000000"),
                    Name = "Asfaloth",
                    Class = "Death Knight",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 158,
                    ArenaRating = 1604,
                    BattlegroundRating = 1119,
                    UserId = "00000000-0000-0000-0000-000000000018"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0054-000000000000"),
                    Name = "Mimtoth",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 200,
                    ArenaRating = 1447,
                    BattlegroundRating = 9,
                    UserId = "00000000-0000-0000-0000-000000000018"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0055-000000000000"),
                    Name = "Falfda",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 165,
                    ArenaRating = 1966,
                    BattlegroundRating = 1297,
                    UserId = "00000000-0000-0000-0000-000000000019"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0056-000000000000"),
                    Name = "Pillia",
                    Class = "Paladin",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 202,
                    ArenaRating = 1147,
                    BattlegroundRating = 161,
                    UserId = "00000000-0000-0000-0000-000000000019"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0057-000000000000"),
                    Name = "Lloydyr",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 177,
                    ArenaRating = 1072,
                    BattlegroundRating = 2055,
                    UserId = "00000000-0000-0000-0000-000000000019"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0058-000000000000"),
                    Name = "Talade",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 161,
                    ArenaRating = 515,
                    BattlegroundRating = 2005,
                    UserId = "00000000-0000-0000-0000-000000000020"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0059-000000000000"),
                    Name = "Elioth",
                    Class = "Monk",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 177,
                    ArenaRating = 1645,
                    BattlegroundRating = 1726,
                    UserId = "00000000-0000-0000-0000-000000000020"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0060-000000000000"),
                    Name = "Kullem",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 208,
                    ArenaRating = 306,
                    BattlegroundRating = 1307,
                    UserId = "00000000-0000-0000-0000-000000000020"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0061-000000000000"),
                    Name = "Lyrand",
                    Class = "Demon Hunter",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 214,
                    ArenaRating = 2068,
                    BattlegroundRating = 418,
                    UserId = "00000000-0000-0000-0000-000000000021"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0062-000000000000"),
                    Name = "Cragho",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 223,
                    ArenaRating = 739,
                    BattlegroundRating = 982,
                    UserId = "00000000-0000-0000-0000-000000000021"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0063-000000000000"),
                    Name = "Caitli",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 224,
                    ArenaRating = 1291,
                    BattlegroundRating = 517,
                    UserId = "00000000-0000-0000-0000-000000000021"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0064-000000000000"),
                    Name = "Thalgu",
                    Class = "Monk",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 212,
                    ArenaRating = 2004,
                    BattlegroundRating = 431,
                    UserId = "00000000-0000-0000-0000-000000000022"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0065-000000000000"),
                    Name = "Squard",
                    Class = "Shaman",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 226,
                    ArenaRating = 547,
                    BattlegroundRating = 1767,
                    UserId = "00000000-0000-0000-0000-000000000022"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0066-000000000000"),
                    Name = "Wulaer",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 209,
                    ArenaRating = 1686,
                    BattlegroundRating = 709,
                    UserId = "00000000-0000-0000-0000-000000000022"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0067-000000000000"),
                    Name = "Stumpe",
                    Class = "Paladin",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 218,
                    ArenaRating = 724,
                    BattlegroundRating = 439,
                    UserId = "00000000-0000-0000-0000-000000000023"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0068-000000000000"),
                    Name = "Orokki",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 159,
                    ArenaRating = 1903,
                    BattlegroundRating = 1621,
                    UserId = "00000000-0000-0000-0000-000000000023"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0069-000000000000"),
                    Name = "Sterne",
                    Class = "Warlock",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 188,
                    ArenaRating = 1516,
                    BattlegroundRating = 1267,
                    UserId = "00000000-0000-0000-0000-000000000023"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0070-000000000000"),
                    Name = "Zaldim",
                    Class = "Druid",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 164,
                    ArenaRating = 1857,
                    BattlegroundRating = 1921,
                    UserId = "00000000-0000-0000-0000-000000000024"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0071-000000000000"),
                    Name = "Bluffw",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 183,
                    ArenaRating = 1876,
                    BattlegroundRating = 515,
                    UserId = "00000000-0000-0000-0000-000000000024"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0072-000000000000"),
                    Name = "Reming",
                    Class = "Monk",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 207,
                    ArenaRating = 862,
                    BattlegroundRating = 169,
                    UserId = "00000000-0000-0000-0000-000000000024"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0073-000000000000"),
                    Name = "Merlac",
                    Class = "Monk",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 225,
                    ArenaRating = 771,
                    BattlegroundRating = 1822,
                    UserId = "00000000-0000-0000-0000-000000000025"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0074-000000000000"),
                    Name = "Lantis",
                    Class = "Priest",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 173,
                    ArenaRating = 1112,
                    BattlegroundRating = 1,
                    UserId = "00000000-0000-0000-0000-000000000025"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0075-000000000000"),
                    Name = "Statfo",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 204,
                    ArenaRating = 161,
                    BattlegroundRating = 685,
                    UserId = "00000000-0000-0000-0000-000000000025"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0076-000000000000"),
                    Name = "Eunich",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 166,
                    ArenaRating = 351,
                    BattlegroundRating = 1172,
                    UserId = "00000000-0000-0000-0000-000000000026"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0077-000000000000"),
                    Name = "Mocarl",
                    Class = "Druid",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 193,
                    ArenaRating = 241,
                    BattlegroundRating = 803,
                    UserId = "00000000-0000-0000-0000-000000000026"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0078-000000000000"),
                    Name = "Akzelo",
                    Class = "Demon Hunter",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 201,
                    ArenaRating = 1914,
                    BattlegroundRating = 306,
                    UserId = "00000000-0000-0000-0000-000000000026"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0079-000000000000"),
                    Name = "Pebble",
                    Class = "Monk",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 175,
                    ArenaRating = 1722,
                    BattlegroundRating = 2045,
                    UserId = "00000000-0000-0000-0000-000000000027"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0080-000000000000"),
                    Name = "Lyoria",
                    Class = "Paladin",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 182,
                    ArenaRating = 1609,
                    BattlegroundRating = 1582,
                    UserId = "00000000-0000-0000-0000-000000000027"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0081-000000000000"),
                    Name = "Riverh",
                    Class = "Death Knight",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 174,
                    ArenaRating = 619,
                    BattlegroundRating = 1214,
                    UserId = "00000000-0000-0000-0000-000000000027"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0082-000000000000"),
                    Name = "Orghana",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 203,
                    ArenaRating = 933,
                    BattlegroundRating = 1695,
                    UserId = "00000000-0000-0000-0000-000000000028"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0083-000000000000"),
                    Name = "Bolynn",
                    Class = "Shaman",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 166,
                    ArenaRating = 1807,
                    BattlegroundRating = 1995,
                    UserId = "00000000-0000-0000-0000-000000000028"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0084-000000000000"),
                    Name = "Aayunn",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 194,
                    ArenaRating = 522,
                    BattlegroundRating = 632,
                    UserId = "00000000-0000-0000-0000-000000000028"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0085-000000000000"),
                    Name = "Deinon",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 215,
                    ArenaRating = 1518,
                    BattlegroundRating = 306,
                    UserId = "00000000-0000-0000-0000-000000000029"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0086-000000000000"),
                    Name = "Alexil",
                    Class = "Druid",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 215,
                    ArenaRating = 238,
                    BattlegroundRating = 567,
                    UserId = "00000000-0000-0000-0000-000000000029"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0087-000000000000"),
                    Name = "Villia",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 206,
                    ArenaRating = 1910,
                    BattlegroundRating = 645,
                    UserId = "00000000-0000-0000-0000-000000000029"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0088-000000000000"),
                    Name = "Rellan",
                    Class = "Death Knight",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 221,
                    ArenaRating = 1851,
                    BattlegroundRating = 1809,
                    UserId = "00000000-0000-0000-0000-000000000030"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0089-000000000000"),
                    Name = "Brann",
                    Class = "Priest",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 173,
                    ArenaRating = 1703,
                    BattlegroundRating = 965,
                    UserId = "00000000-0000-0000-0000-000000000030"
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0090-000000000000"),
                    Name = "Surest",
                    Class = "Priest",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 192,
                    ArenaRating = 1095,
                    BattlegroundRating = 271,
                    UserId = "00000000-0000-0000-0000-000000000030"
                }
            );
        }
    }
}
