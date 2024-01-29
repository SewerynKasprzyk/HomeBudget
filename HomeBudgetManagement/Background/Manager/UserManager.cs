using Database;
using Database.Entities;
using System;
using System.Threading;

namespace Background
{
    public class UserManager
    {
        private UserService _userService;
        private User _user;

        public UserManager(User user)
        {
            _userService = new UserService(new HomeManagementDbContext());
            _user = user;
        }

        public bool ChangePassword(String password, String confirmPassword)
        {
            //use validate method
            if (true) 
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
    }
}
