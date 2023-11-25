using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public static class UserList
    {
        private static List<User> users;

        public static List<User> Users { get => users; set => users = value; }

        public static void addToList(User user)
        { 
            users.Add(user);
        }

        public static void removeFromList(String id)
        {
            foreach (User user in users)
            {
                if(user.Id == id) 
                {
                    users.Remove(user);
                    return;
                }
            }
    
        }
        
    }
}
