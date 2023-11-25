using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class Login
    {
        //return user
        //if Authenticate failed returns basic user with access level 0
        public User Authenticate(string login, string password)
        {
            List<User> users = UserList.Users;

            foreach (User user in users) 
            { 
                if(user.Login == login && user.Password == password)
                {
                    return user;
                }
            }

            return new User();
        }
    }
}
