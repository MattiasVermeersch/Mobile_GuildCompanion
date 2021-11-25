using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {
        const string Password = "Test123?";

        //IdentityRoles
        //Admin
        const string AdminRoleId = "00000000-0000-0000-000000000001";
        const string AdminRoleName = "Admin";

        //Warlord
        const string WarlordRoleId = "00000000-0000-0000-000000000002";
        const string WarlordRoleName = "Warlord";

        //RaidLeader
        const string RaidLeaderRoleId = "00000000-0000-0000-000000000003";
        const string RaidLeaderRoleName = "RaidLeader";

        //Base role
        const string BaseRoleId = "00000000-0000-0000-000000000004";
        const string BaseRoleName = "GuildMember";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = AdminRoleId,
                    Name = AdminRoleName,
                    NormalizedName = AdminRoleName.ToUpper()
                },
                new IdentityRole
                {
                    Id = WarlordRoleId,
                    Name = WarlordRoleName,
                    NormalizedName = WarlordRoleName.ToUpper()
                },
                new IdentityRole
                {
                    Id = RaidLeaderRoleId,
                    Name = RaidLeaderRoleName,
                    NormalizedName = RaidLeaderRoleName.ToUpper()
                },
                new IdentityRole
                {
                    Id = BaseRoleId,
                    Name = BaseRoleName,
                    NormalizedName = BaseRoleName.ToUpper()
                });

            //Users data, courtesy of mockaroo.com
            List<string> identifiers = new List<string>() 
            { 
                "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000002",
                "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000004",
                "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000006",
                "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-0000-000000000008",
                "00000000-0000-0000-0000-000000000009", "00000000-0000-0000-0000-000000000010",
                "00000000-0000-0000-0000-000000000011", "00000000-0000-0000-0000-000000000012",
                "00000000-0000-0000-0000-000000000013", "00000000-0000-0000-0000-000000000014",
                "00000000-0000-0000-0000-000000000015", "00000000-0000-0000-0000-000000000016",
                "00000000-0000-0000-0000-000000000017", "00000000-0000-0000-0000-000000000018",
                "00000000-0000-0000-0000-000000000019", "00000000-0000-0000-0000-000000000020",
                "00000000-0000-0000-0000-000000000021", "00000000-0000-0000-0000-000000000022",
                "00000000-0000-0000-0000-000000000023", "00000000-0000-0000-0000-000000000024",
                "00000000-0000-0000-0000-000000000025", "00000000-0000-0000-0000-000000000026",
                "00000000-0000-0000-0000-000000000027", "00000000-0000-0000-0000-000000000028",
                "00000000-0000-0000-0000-000000000029", "00000000-0000-0000-0000-000000000030"
            };

            List<string> userEmails = new List<string>() 
            {
                "ageydon0@marriott.com", "cwoodland1@reference.com",
                "msemeniuk2@prweb.com",  "awasbey3@google.it",
                "jingyon4@hao123.com", "legell5@wikispaces.com",
                "gbortolozzi6@friendfeed.com", "cmair7@dion.ne.jp",
                "mrispine8@is.gd", "browena9@springer.com",
                "lgregorioua@storify.com", "teastamb@phoca.cz",
                "glidierthc@freewebs.com", "lduttond@canalblog.com",
                "hfyerse@dmoz.org", "nhalworthf@ezinearticles.com",
                "rphing@europa.eu", "cdirrh@ucsd.edu",
                "zferrerasi@cisco.com", "pninnisj@wix.com",
                "jnindk@github.io", "drichfordl@economist.com",
                "lsiebertm@mapy.cz", "mbaxstaren@mysql.com",
                "tklainero@admin.ch", "klocklessp@un.org",
                "rgabbyq@mozilla.org", "obartar@vistaprint.com",
                "cscocrofts@facebook.com", "pshillt@simplemachines.org"
            };

            List<string> userFullNames = new List<string>()
            {
                "Aldwin Geydon", "Clem Woodland", "Mil Semeniuk", "Aurel Wasbey",
                "Jackson Ingyon", "Lucho Egell", "Giavani Bortolozzi",
                "Casie Mair", "Madalena Rispine", "Broderick Rowena",
                "Lenna Gregoriou", "Timi Eastam", "Gweneth Lidierth",
                "Lesya Dutton", "Hedvige Fyers", "Nehemiah Halworth",
                "Robinetta Phin", "Correy Dirr", "Zelda Ferreras",
                "Paddy Ninnis", "Jeanna Nind", "Darius Richford",
                "Lindy Siebert", "Micheil Baxstare", "Terrance Klainer",
                "Killian Lockless", "Reynold Gabby", "Opaline Barta",
                "Concettina Scocroft", "Pooh Shill"
            };

            List<string> userAddresses = new List<string>()
            {
                "6 Gale Plaza", "50 Independence Avenue", "5 Onsgard Parkway",
                "20 Wayridge Place", "80 Mcguire Circle", "7 Cody Way", "39 Morrow Center",
                "3 Monica Plaza", "22114 Carberry Avenue", "04 Harbort Point", "97 Rockefeller Circle",
                "6 Scofield Drive", "9 Chive Alley", "56741 Huxley Lane", "4 Blaine Plaza", "58 Sherman Circle",
                "2572 Nelson Trail", "45 Onsgard Parkway", "197 Longview Way", "9 Vahlen Crossing", "98 Granby Hill",
                "88 Roxbury Crossing", "3 Holmberg Hill", "64070 Lakewood Gardens Circle", "1 Mesta Court",
                "0 Bashford Plaza", "79 Fieldstone Drive", "9875 Warner Terrace", "189 Fairfield Hill",
                "7918 Jenifer Lane"
            };

            List<string> cities = new List<string>() { "Brugge", "Gent", "Antwerpen", "Hasselt", "Brussel" };

            List<User> newUsers = new List<User>();
            Random random = new Random();
            IPasswordHasher<User> passwordHasher = new PasswordHasher<User>();

            for (int i = 0; i < identifiers.Count; i++)
            {
                string userName = userEmails[i];

                int cityIndex = random.Next(5);
                int randomDay = random.Next(1, 28);
                int randomMonth = random.Next(1, 13);
                int randomYear = random.Next(1970, 2001);

                bool confirmed = random.Next(2) > 0.5;

                User newUser = new User
                {
                    Id = identifiers[i],
                    UserName = userName,
                    NormalizedUserName = userName.ToUpper(),
                    Email = userName,
                    NormalizedEmail = userName.ToUpper(),
                    EmailConfirmed = confirmed,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    City = cities[cityIndex],
                    BirthDate = new DateTime(randomYear, randomMonth, randomDay),
                    Address = userAddresses[i],
                    FullName = userFullNames[i],
                };

                newUser.PasswordHash = passwordHasher.HashPassword(newUser, Password);

                newUsers.Add(newUser);
            }

            foreach (User user in newUsers)
            {
                modelBuilder.Entity<User>().HasData(user);
            };

            //adding roles to some users
            string roleId;
            int firstClaimId = 0;
            int secondClaimId = 0;
            foreach (var id in identifiers)
            {
                int index = identifiers.IndexOf(id);
                
                switch (index)
                {
                    case 0:
                        roleId = AdminRoleId;
                        break;
                    case 1:
                    case 2:
                        roleId = RaidLeaderRoleId;
                        break;
                    case 3:
                    case 4:
                        roleId = WarlordRoleId;
                        break;
                    default:
                        roleId = BaseRoleId;
                        break;
                }

                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = id
                });

                secondClaimId = (index + 1) * 2;
                firstClaimId = secondClaimId - 1;

                modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                    new IdentityUserClaim<string>
                    {
                        Id = firstClaimId,
                        UserId = id,
                        ClaimType = "registration-date",
                        ClaimValue = new DateTime(2021, 3, 15).ToString("yyyy-MM-dd")
                    },
                    new IdentityUserClaim<string>
                    {
                        Id = secondClaimId,
                        UserId = id,
                        ClaimType = "has-characters",
                        ClaimValue = "true"
                    }
                );
            }
        }
    }
}
