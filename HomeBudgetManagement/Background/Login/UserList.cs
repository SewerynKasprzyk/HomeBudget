using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public static class UserList
    {
        static UserList()
        {
            users = new List<User>();
            DemoInit();
        }
        public static List<User> Users { get => users; set => users = value; }

        public static void AddToList(User user)
        { 
            users.Add(user);
        }

        public static void RemoveFromList(String id)
        {
            users.Remove(FindUser(id));
        }

        public static User FindUser(String userId)
        {
            foreach (User user in users)
            {
                if (userId == user.Id)
                {  return user; }
            }

            return null;
        }

        public static void DemoInit()
        { 
            AddToList(new User("user", "user", 1));
            AddToList(new User("admin", "admin", 2));
        }

        private static List<User> users;
    }
}
