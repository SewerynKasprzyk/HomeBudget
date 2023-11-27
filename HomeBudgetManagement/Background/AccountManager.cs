using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class AccountManager
    {
        private User user;

        public AccountManager(String userId)
        {
            user = UserList.FindUser(userId);
        }

    }
}
