﻿using System;
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
        public static User LoggedUser { get => loggedUser; set => loggedUser = value; }
        public static bool Performed { get => performed; set => performed = value; }

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


        private static bool performed = false;
        private static int accessLevel = 0;
        private static User loggedUser = null;

    }
}