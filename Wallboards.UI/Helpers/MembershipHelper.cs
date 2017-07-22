using System.Web;
using Wallboards.UI.Models;

namespace Wallboards.UI.Helpers
{
    public static class MembershipHelper
    {
        private const string USER_KEY = "_USER_";
         
        public static UserData User
        {
            get { return (UserData)HttpContext.Current.Session[USER_KEY]; }
        }

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