using Database.Entities;
using System;

namespace HomeBudgetManagement.Model.ConfigurationContext
{
    public class Configuration
    {
        public static int AccessLevel { get; set; } = 0;
        public static User LoggedUser { get; set; } = null;
        public static bool Performed { get; set; } = false;

        /*public bool FirstConfiguration(String firstLogin, String firstName, String firstSurname, String firstPassword, String confirmFirstPassword)
        {
            if (!Performed)
            {
                if (confirmFirstPassword == firstPassword)
                {
                    User adminUser = new User();

                    Performed = true;
                    return true;
                }
            }

            return false;
        }*/



    }
}