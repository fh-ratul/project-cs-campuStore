using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampuStore
{
    public static class SessionData
    {
        public static int LoggedInUserId { get; set; }
        public static string LoggedInUserName { get; set; }
        public static string LoggedInUserEmail { get; set; }
        public static string LoggedInUserPass { get; set; }

    }
}
