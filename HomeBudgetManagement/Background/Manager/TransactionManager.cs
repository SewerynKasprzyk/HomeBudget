using Database;
using Database.Entities;
using System.Collections.Generic;

namespace Model.Manager
{
    public class TransactionManager
    {
        private TransactionService _transactionService;
        private Transaction transaction;
        public TransactionManager() 
        { 
            _transactionService = new TransactionService(new HomeManagementDbContext());
        }

        public void ManageTransaction(Transaction transaction)
        {
            this.transaction = transaction;
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactionService.Add(transaction);
            //BalanceManager balanceManager = new BalanceManager();
            //balanceManager.SubBalance(transaction.Value);
        }

        public List<Transaction> GetAll()
        {
            return _transactionService.GetAll();
        }
    }
}
