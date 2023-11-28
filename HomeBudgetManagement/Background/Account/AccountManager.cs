using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    public class AccountManager
    {
        public AccountManager(String userId)
        {
            this.verificated = false;
            this.userId = userId;
            this.ManageAccount(this.userId);
        }

        public void ManageAccount(String userId)
        {
            this.account.AccountId = UserList.FindUser(userId).Id;

            int index = 0;
            foreach (var account in AccountList.Accounts)
            {
                if (account.AccountId == this.account.AccountId)
                {
                    this.account = account;
                    this.verificated = true;
                    this.index = index;
                    return;
                }

                this.verificated = false;
                index++;
            }
        }

        public void ChangeName(String name)
        {
            this.ReloadAcc();
            this.account.AccountName = name;
            this.SaveAcc();
        }

        public void ChangeSurname(String surname)
        {
            this.ReloadAcc();
            this.account.AccountSurname = surname;
            this.SaveAcc();
        }

        public bool ChangePassword(String password)
        {
            if (Login.IsPassworCorrect(password))
            {
                UserList.Users[index].Password = password;
                return true;
            }

            return false;
        }

        public void Delete()
        {
            AccountList.Accounts.RemoveAt(this.index);
        }

        public void GivePower()
        {
            UserList.Users[index].AccessLevel = 2;
        }

        //demo
        public bool addUser(String login, String password, String name, String surname, int power, String demoUserId)
        {
            if (!Login.IsPassworCorrect(password))
            { return false; }
            else
            {
                Account acc = new Account(demoUserId);
                acc.AccountName = name;
                acc.AccountSurname = surname;

                User user = new User();
                user.Login = login;
                user.Password = password;
                user.Id = demoUserId;
                user.AccessLevel = power;

                AccountList.AddToList(acc);
                UserList.AddToList(user);
                return true;
            }
        }


        public bool addUser(String login, String password, String name, String surname, int power)
        {
            if (!Login.IsPassworCorrect(password))
            { return false; }
            else
            {
                Account acc = new Account();
                acc.AccountName = name;
                acc.AccountSurname = surname;

                User user = new User();
                user.Login = login;
                user.Password = password;
                user.AccessLevel= power;

                return true;
            }
        }

        private void ReloadAcc()
        {
            this.account = AccountList.Accounts[index];
        }

        private void SaveAcc()
        {
            AccountList.Accounts[index] = account;
        }

        private String userId;
        private int index = -1;
        private Account account;
        private bool verificated;
    }
}
