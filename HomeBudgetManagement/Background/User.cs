using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class User
    {
        User(String name, String surname, String password)
        {
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.accessLevel = 0; // 0 indicates user have guest access level
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Password { get => password; set => password = value; }
        public int AccessLevel { get => accessLevel; set => accessLevel = value; }

        private String id;
        private String name;
        private String surname;
        private String password;
        private int accessLevel;
    }
}
