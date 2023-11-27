using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    internal static class AccountList
    {
        public static void AddToList(Account acc)
        {
            if (acc is null)
            {
                throw new ArgumentNullException(nameof(acc));
            }
            else
            {
                accounts.Add(acc);
            }
        }
        internal static List<Account> Accounts { get => accounts; set => accounts = value; }

        //Demo
        static AccountList()
        { 
            foreach (var user in UserList.Users) 
            {
                accounts.Add(new Account(user.Id));
            }
        }

        private static List<Account> accounts;
    }
}
