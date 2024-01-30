using Database;
using Database.Entities;
using Database.Enums;
using HomeBudgetManagement.Model.ConfigurationContext;
using System;
using System.Collections.Generic;

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

        public void ManageUser(User user)
        {
            _user = user;
        }   

        public User AddUser(User user)
        {
            var user2 = _userService.CreateUser(user);

            return user2;
        }

        public User FindUserByID(long id)
        {
            return _userService.GetUser(id);
        }

        public User GetLoggedUser()
        {
            return _userService.GetUser(Configuration.LoggedUserID);
        }

        public User CreateFirstAdmin(String firstLogin, String firstPassword)
        {
            var user = _userService.CreateUser(new User()
            {
                Limit = 100000000000,
                Login = firstLogin,
                Password = firstPassword,
                Role = Role.Admin,
            });

            return user;
        }

        public void GiveAccess()
        {
            _user.Role = Role.Admin;
            _userService.UpdateUser(_user);
        }

        public void TakeAccess()
        {
            _user.Role = Role.User;
            _userService.UpdateUser(_user);
        }   

        public void DeleteUser()
        {
            _userService.DeleteUser(_user.Id);
        }
        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
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
                    Configuration.LoggedUserID = user.Id;
                    Configuration.AccessLevel = user.Role;
                    return true;
                }
            }
            return false;
        }

        public void Logout()
        {
            Configuration.LoggedUserID = 0;
            Configuration.AccessLevel = Role.Guest;
        }
    }
}
