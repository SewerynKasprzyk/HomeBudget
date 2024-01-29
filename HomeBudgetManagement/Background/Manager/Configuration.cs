using Background.Manager;
using Database;
using Database.Entities;
using Database.Enums;
using System;

namespace HomeBudgetManagement.Model.ConfigurationContext
{
    public static class Configuration
    {
        public static int AccessLevel { get; set; } = 0;
        public static User LoggedUser { get; set; } = null;
        public static bool Performed { get; set; } = false;

        public static bool FirstConfiguration(String firstLogin, String firstName, String firstSurname, String firstPassword, String confirmFirstPassword)
        {    
             if (!Performed)
             {
                 if (Validation.Validate(firstLogin, firstPassword, confirmFirstPassword))
                 {
                     UserService service = new UserService(new HomeManagementDbContext());

                     var user = service.CreateUser(new User()
                     {
                         Limit = 100000000000,
                         Login = firstLogin,
                         Password = firstPassword,
                         Role = Role.Admin,
                     });

                     LoggedUser = user;
                     return true;
                 }
                 return false;
             }
             return false;
        }

        public static void SelfConfig()
        {
            UserService service = new UserService(new HomeManagementDbContext());

            foreach (var user in service.GetAllUsers())
            {
                if(user.Role == Role.Admin)
                {
                    Performed = true;
                    return;
                }

                Performed = false;
            }
        }
    }
}