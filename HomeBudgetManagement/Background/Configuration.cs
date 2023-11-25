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
        public bool FirstConfiguration(String firstLogin, String firstName, String firstSurname, String firstPassword, String confirmFirstPassword)
        {
            if (!performed)
            {

                if (confirmFirstPassword == firstPassword) 
                {
                    User adminUser = new User(firstName, firstSurname, firstLogin, firstPassword, 2);
                    UserList.AddToList(adminUser);
                    performed = true;
                    return true;
                }
            }

            return false;
        }
    }
}
