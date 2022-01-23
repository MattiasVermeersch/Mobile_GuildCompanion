using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Project.Mobile.Domain.Constants
{
    public static class ApiConstants
    {
        //URL's
        public static string ApiBaseUrl = "http://192.168.0.152:5000/api";

        public static string ApiLoginUrl = $"{ApiBaseUrl}/Auth/login";
        public static string ApiRegisterUrl = $"{ApiBaseUrl}/Auth/register";

        public static string ApiUsersUrl = $"{ApiBaseUrl}/Users";

        public static string ApiCharactersUrl = $"{ApiBaseUrl}/Characters";

        public static string ApiArenasUrl = $"{ApiBaseUrl}/Arenas";
        public static string ApiBattlegroundsUrl = $"{ApiBaseUrl}/Battlegrounds";
        public static string ApiDungeonsUrl = $"{ApiBaseUrl}/Dungeons";
        public static string ApiRaidsUrl = $"{ApiBaseUrl}/Raids";

        public static string Character = "character";
        public static string Characters = "characters";

        //For Secure Storage
        public static string TokenKey = "token";
        public static string UserKey = "userId";
    }
}
