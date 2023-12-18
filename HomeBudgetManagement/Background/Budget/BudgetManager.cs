using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background.Budget
{
    public class BudgetManager
    {
        public BudgetManager() { }

        public String ShowAccountsInBox()
        {
            foreach (Account item in AccountList.Accounts)
            {
                return item.AccountName + " " + item.AccountSurname;
            }
            return "nie wczytano listy";
        }

        public String ShowCategoriesInBox()
        {
            foreach (Category item in CategoryList.Categories)
            {
                return item.Name + ": " + item.Value;
            }

            return "nie wczytano listy";
        }

        public String ShowUserDetails(String name)
        {
            int id = 0;

            foreach(Account item in AccountList.Accounts)
            { 
                if (name == item.AccountName)
                {
                    id = int.Parse(item.AccountId);
                    break;
                }
                else
                {
                    return "no user";
                }
            }

            if (id != 0)
            {
                foreach (Category item in CategoryList.Categories)
                {
                    if (id == item.Id)
                    {
                        return item.Name + ": " + item.Value;
                    }
                }
            }
            else
            {
                return "user no category";
            }

            return "udalo sie";
        }

        public String ShowAllBudget()
        {
            float allBudget = 0;

            foreach (Budget item in BudgetList.Budgets)
            {
                allBudget += item.BudegtValue;
            }
            return "Budget is: " + allBudget;
        }
    }
}
