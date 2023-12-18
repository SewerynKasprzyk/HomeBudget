using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public static class AccountList
    {
        public static void AddToList(Account acc)
        {
            if (acc is null)
            {
                throw new ArgumentNullException(nameof(acc));
            }
            else
            {
                Accounts.Add(acc);
            }
        }

        //Demo
        static AccountList()
        { 
            foreach (var user in UserList.Users) 
            {
                Accounts.Add(new Account(user.Id));
            }
        }

        public static List<Account> Accounts { get; set; }
        //private static List<Account> accounts;
    }
}
