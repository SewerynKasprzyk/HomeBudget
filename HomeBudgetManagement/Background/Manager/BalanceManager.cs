using Database;
using Database.Entities;
using HomeBudgetManagement.Model.ConfigurationContext;
using System.Collections.Generic;
using System.Linq;

namespace Model.Manager
{
    public class BalanceManager
    {
        private BalanceService _balanceService;
        private UserService _userService;

        public BalanceManager()
        {
            var db = new HomeManagementDbContext();
            _userService = new UserService(db);
            _balanceService = new BalanceService(db);
        }

        public Balance AddBalance(decimal value)
        {
            var user = _userService.GetUser(Configuration.LoggedUserID);
            var currentBalance = _userService.GetUserBalance(Configuration.LoggedUserID);
            currentBalance.Value += value;
            _balanceService.Update(currentBalance);

            return currentBalance;
        }

        public Balance SubBalance(decimal value)
        {
            var user = _userService.GetUser(Configuration.LoggedUserID);
            var currentBalance = _userService.GetUserBalance(Configuration.LoggedUserID);
            currentBalance.Value -= value;
            _balanceService.Update(currentBalance);

            return currentBalance;
        }

        public bool UpdateBalance(Balance oldBalace, decimal value)
        {
            oldBalace.Value = value;
            _balanceService.Update(oldBalace);
            return true;
        }

        public Balance GetBalance() 
        {
            var balance = _userService.GetUserBalance(Configuration.LoggedUserID);
            return balance; 
        }

        public bool DeleteBalance(int id)
        {
            _balanceService.Delete(id);
            return true;
        }

        public List<Balance> GetAllMyBalances()
        {
            return _balanceService.GetAll().Where(b => b.User.Id == Configuration.LoggedUserID).ToList();
        }
    }
}
