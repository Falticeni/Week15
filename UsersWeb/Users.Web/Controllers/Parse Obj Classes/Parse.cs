using BusinessLogic;
using Users.Web.Models;
using System.Collections.Generic;

namespace Users.Web.Controllers.Classes
{
    public static class Parse
    {
        public static UserViewModel ParseSingleUser(this User u)
        {
            UserViewModel user = new UserViewModel();
            user.Id = u.Id;
            user.Username = u.Username;
            user.Email = u.Email;
            user.Description = u.Description;
            user.City = u.City;
            user.Street = u.Street;

            return user;
        }

        public static List<UserViewModel> GetData(this IUserRepository userRepository)
        {
            List<UserViewModel> userViewModelList = new List<UserViewModel>();
            foreach (var user in userRepository.GetUsers())
            {
                UserViewModel userViewModel = new UserViewModel
                {
                    Id = user.Id,
                    Username = user.Username,
                    Email = user.Email,
                    Description = user.Description,
                    City = user.City,
                    Street = user.Street
                };
                userViewModelList.Add(userViewModel);
            }
            return userViewModelList;
        }
    }
}