using System.Collections.Generic;
using System.Web;
using Wallboards.UI.Models;

namespace Wallboards.UI.Helpers
{
    public static class MembershipHelper
    {
        private const string USER_KEY = "_USER_";
        
        public static IList<UserData> Users=new List<UserData>();

        static MembershipHelper()
        {
            Users.Add(new UserData{Role = Roles.CENTER,UserName = "center",Password = "123456"});
            Users.Add(new UserData{Role = Roles.IT,UserName = "it",Password = "123456"});
            Users.Add(new UserData{Role = Roles.ANALYTIC,UserName = "analytic", Password = "123456"}); 
        }
        
        public static UserData User => (UserData)HttpContext.Current.Session[USER_KEY];

        public static void SignIn(UserData data)
        {
            HttpContext.Current.Session[USER_KEY] = data;
        }

        public static void SignOut()
        {
            HttpContext.Current.Session[USER_KEY] = null;
        }

        public static bool IsAuthorize()
        {
            return HttpContext.Current.Session[USER_KEY] != null;
        } 
          
    }
}