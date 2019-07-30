using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUserByid(int id);
        void EditUserFromList(int id, string username, string email, string description, string city, string street, User.Category categoryId);
        void Delete(int id);
        void AddUser(string username, string email, string description, string city, string street, User.Category categoryId);
    }
}
