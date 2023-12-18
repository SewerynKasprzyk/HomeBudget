using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Background
{
    public class Configuration
    {
        public static int AccessLevel { get => accessLevel; set => accessLevel = value; }

        public bool FirstConfiguration(String firstLogin, String firstName, String firstSurname, String firstPassword, String confirmFirstPassword)
        {
            if (!performed)
            {
                if (confirmFirstPassword == firstPassword) 
                {
                    User adminUser = new User(firstLogin, firstPassword, 2);
                    UserList.AddToList(adminUser);
                    performed = true;
                    return true;
                }
            }

            return false;
        }

        private bool performed = false;
        private static int accessLevel = 0;

    }
}
