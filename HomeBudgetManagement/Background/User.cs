using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class User
    {
        public User(String name, String surname, String password, int accessLevel)
        {
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.accessLevel = accessLevel; // 0 indicates user have guest access level
        }

        public User()
        {
            this.id = "null";
            this.name = "Guest";
            this.surname = null;
            this.password = null;
            this.accessLevel = 0;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
        public int AccessLevel { get => accessLevel; set => accessLevel = value; }
        public string Login { get => login; set => login = value; }

        private String id;
        private String login;
        private String name;
        private String surname;
        private String password;
        private int accessLevel;
    }
}
