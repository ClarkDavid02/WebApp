using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstSem.Web.Infrastructures.Domain.Enums;

namespace WebAppFirstSem.Web.Infrastructures.Domain.Helpers
{
    public static class WebUser
    {
        public static Guid? UserId { get; set; }

        public static string UserName { get; set; }

        public static List<Role> Roles { get; set; }

        public static void GetUser(Guid? Id, string userName, List<Role> roles)
        {

            Roles = roles;
            UserId = Id;
            UserName = userName;
        }

    }
}

