﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        //if user -> acces level is 1 | if powerUser -> acces level is 2
        public static String Authenticate(string login, string password)
        {
            List<User> users = UserList.Users;

            foreach (User user in users) 
            { 
                if(user.Login == login && user.Password == password)
                {
                    Configuration.LoggedUser = user;
                    Configuration.AccessLevel = Configuration.LoggedUser.AccessLevel;

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

        public static void Logout()
        {
            //Powrot do Logowania
            Configuration.AccessLevel = 0;
        }
    }
}