using Model.Manager;
using Database.Entities;
using Database.Enums;
using System;

namespace HomeBudgetManagement.Model.ConfigurationContext
{
    public static class Configuration
    {
        public static Role AccessLevel { get; set; } = Role.Guest;
        public static int LoggedUserID { get; set; } = 0;
        public static bool Performed { get; set; } = false;


        public static bool FirstConfiguration(String firstLogin, String firstName, String firstSurname, String firstPassword, String confirmFirstPassword)
        {

            if (!Performed)
            {
                if (!Validation.PasswordCheck(firstPassword))
                {
                throw new Exception("Password does not meet strong password requirements");
                }
                if (Validation.Validate(firstLogin, firstPassword, confirmFirstPassword))
                {
                    UserManager userManager = new UserManager();

                    User user = userManager.CreateFirstAdmin(firstLogin, firstPassword);

                    LoggedUserID = user.Id;
                    AccessLevel = user.Role;         
                    
                    return true;
                }
                else
                {
                throw new Exception("Validate failed. Please chceck your input.");
                }
            }
            return false;
        }

        public static void SelfConfig()
        {
            UserManager userManager = new UserManager();

            foreach (var user in userManager.GetAllUsers())
            {
                if (user.Role == Role.Admin)
                {
                    Performed = true;
                    return;
                }

                Performed = false;
            }
        }
    }
}