using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Background
{
    public static class Login
    {
        //return user
        //if Authenticate failed returns basic user with access level 0
        public static String Authenticate(string login, string password)
        {
            List<User> users = UserList.Users;

            foreach (User user in users) 
            { 
                if(user.Login == login && user.Password == password)
                {
                    return user.Id;
                }
            }

            return null;
        }

        /*
         * (?=.*[a-z]) - Musi zawierać co najmniej jedną małą literę.
         * (?=.*[A-Z]) - Musi zawierać co najmniej jedną dużą literę.
         * (?=.*\d) - Musi zawierać co najmniej jedną cyfrę.
         * (?=.*[^a-zA-Z\d]) - Musi zawierać co najmniej jeden znak specjalny.
         * .{8,} - Całkowita długość hasła musi być co najmniej 8 znaków. 
         */
        public static bool IsPassworCorrect(String password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$";
           
            return Regex.IsMatch(password, pattern);
        }

        //Test Logout

        static void Logout()
        {
            //Powrot do Logowania
            Configuration.AccessLevel = 0;
        }
    }
}
