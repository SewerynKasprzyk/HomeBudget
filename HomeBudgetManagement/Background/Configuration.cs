using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Background
{
    public class Configuration
    {
        private bool performed = false;
        public void FirstConfiguration(String firstLogin, String firstName, String firstSurname, String firstPassword, String confirmFirstPassword)
        {
            if (!performed)
            {
                //User adminUser = new User();
                //adminUser.AccessLevel = 2;
                //adminUser.Id = "1Admin";

                //adminUser.Login = firstLogin;
                //adminUser.Name = firstName;
                //adminUser.Surname = firstSurname;
                //adminUser.Password = firstPassword;

                if (confirmFirstPassword != firstPassword) 
                {
                    //Login error
                    performed = false;
                }

                else
                {
                    User adminUser = new User(firstName, firstSurname, firstPassword, 2);
                    UserList.AddToList(adminUser);
                    performed = true;
                } 
            } 
        }
    }
}
