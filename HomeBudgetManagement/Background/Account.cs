﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Background
{
    internal class Account
    {
        public string AccountId { get => accountId; set => accountId = value; }
        public int BudgetId { get => budgetId; set => budgetId = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string AccountSurname { get => accountSurname; set => accountSurname = value; }

        private String accountId;
        private int budgetId;
        private String accountName;
        private String accountSurname;
    }
}