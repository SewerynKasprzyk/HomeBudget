using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Background.Manager
{
    public static class Validation
    {
        public static bool LoginCheck(string login)
        {
            if(Regex.IsMatch(login, "[ąćęłńóśźżĄĆĘŁŃÓŚŹŻ]"))
            {
                return false;
            }
            if (login.Length < 3)
            {
                return false;
            }
            return true;
        }
        
        public static bool PasswordCheck(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return false;
            }
            if(!Regex.IsMatch(password, "[a-z]"))
            {
                return false;
            }
            if (!Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]"))
            {
                return false;
            }
            return true;
        }
      
        public static bool Validate(string login, string password, string confPass)
        {
            if(password == confPass && LoginCheck(login) && PasswordCheck(password))
            {
                return true;
            }     
            return false;
        }
        
    }
}
