using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Constants
{
    public static class ApiConstants
    {
        //URL's
        public static string ApiBaseUrl = "https://localhost:8001/api";

        public static string ApiLoginUrl = $"{ApiBaseUrl}/api/Auth/login";
        public static string ApiRegisterUrl = $"{ApiBaseUrl}/api/Auth/register";

        public static string ApiUsersUrl = $"{ApiBaseUrl}/Users";

        public static string ApiCharactersUrl = $"{ApiBaseUrl}/Characters";

        public static string ApiArenasUrl = $"{ApiBaseUrl}/Arenas";
        public static string ApiBattlegroundsUrl = $"{ApiBaseUrl}/Battlegrounds";
        public static string ApiDungeonsUrl = $"{ApiBaseUrl}/Dungeons";
        public static string ApiRaidsUrl = $"{ApiBaseUrl}/Raids";

        public static string Character = "/character";

        //token
        public static string TokeyKey = "token";
    }
}
