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
        public static List<User> Users { get => users; set => users = value; }

        public static void AddToList(User user)
        { 
            users.Add(user);
        }

        public static void RemoveFromList(String id)
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

        private static List<User> users;
    }
}
