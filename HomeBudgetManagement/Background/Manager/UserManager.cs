using Database;
using Database.Entities;
using Database.Enums;
using HomeBudgetManagement.Model.ConfigurationContext;
using System;

namespace Model.Manager
{
    public class UserManager
    {
        private UserService _userService;
        private User _user;

        public UserManager()
        {
            _userService = new UserService(new HomeManagementDbContext());
        }
        public UserManager(User user)
        {
            _userService = new UserService(new HomeManagementDbContext());
            _user = user;
        }

        public void AddUser(String login)
        {
                _userService.CreateUser(new User()
                {
                    Login = login,
                    Password = "",
                    Role = Role.User
                });
        }   

        public bool ChangePassword(String password, String confirmPassword)
        {
            //use validate method
            if (Validation.Validate(_user.Login, password, confirmPassword)) 
            {
                _user.Password = password;
                _userService.UpdateUser(_user);
                return true;
            }
            else 
            { 
                return false; 
            }  
        }

        public bool LoginProcess(String username, String password)
        {
            foreach(User user in _userService.GetAllUsers())
            {
                if (user.Login ==  username && user.Password == password) 
                { 
                    Configuration.LoggedUser = user;
                    Configuration.AccessLevel = user.Role;
                    return true;
                }
            }
            return false;
        }

        public void Logout()
        {
            Configuration.LoggedUser = null;
            Configuration.AccessLevel = Role.Guest;
        }
    }
}
