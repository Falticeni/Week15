using BusinessLogic;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace DataAccess
{
    public class UserRepository : Connection, IUserRepository
    {
        public List<User> usersList = new List<User>();
        public List<User> GetUsers()
        {
            string select = "Select * from USERS";
            SqlCommand selectUser = new SqlCommand(select, sqlConnection);
            sqlConnection.Open();

            var reader = selectUser.ExecuteReader();
            while (reader.Read())
            {
                var c = (int)reader["CategoryId"];
                var id = (int)reader["id"];

                var e = (User.Category)(c);

                User u = new User
                {
                    Id = id,
                    Username = reader["username"] as string,
                    Email = reader["email"] as string,
                    Description = reader["description"] as string,
                    City = reader["City"] as string,
                    Street = reader["Street"] as string,
                    CategoryId = e
                };
                usersList.Add(u);
            }

            sqlConnection.Close();
            return usersList;
        }


        public User GetUserByid(int id)
        {
            User user = new User();
            string sqlString = "Select * From USERS Where Id = @id";
            SqlCommand command = new SqlCommand(sqlString, sqlConnection);
            command.Parameters.Add(new SqlParameter { ParameterName = "id", Value = id });
            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                user.Id = (int)reader["ID"];
                user.Username = reader["USERNAME"] as string;
                user.Email = reader["EMAIL"] as string;
                user.Description = reader["DESCRIPTION"] as string;
                user.City = reader["CITY"] as string;
                user.Street = reader["STREET"] as string;
                user.CategoryId = (User.Category) ((int)reader["categoryid"]); // todo
            }

            sqlConnection.Close();
            return user;
        }


        public void EditUserFromList(int id, string username, string email, string description, string city, string street, User.Category categoryId)
        {
            string edit = "Update Users " +
                "Set Username=@username, Email=@email, Description = @description, City=@city, Street=@street, CategoryId=@categoryId " +
                "Where Id=@id";
            SqlCommand command = new SqlCommand(edit, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddRange(
                new SqlParameter[]
                {
                    new SqlParameter{ParameterName="id", Value=id},
                    new SqlParameter{ParameterName="username", Value=username},
                    new SqlParameter{ParameterName="email", Value=email},
                    new SqlParameter{ParameterName="description", Value=description},
                    new SqlParameter{ParameterName="city", Value=city},
                    new SqlParameter{ParameterName="street", Value=street},
                    new SqlParameter{ParameterName="categoryId", Value=categoryId},
                });
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void AddUser(string username, string email, string description, string city, string street, User.Category categoryId)
        {
            string addUser = @"Insert into USERS (Username, Email, Description, City, Street) values " +
                                "(@username, @email, @description, @city, @street, @categoryId); select cast(scope_identity() as int);";
            SqlCommand command = new SqlCommand(addUser, sqlConnection);
            sqlConnection.Open();
            command.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter{ParameterName="username", Value=username},
                new SqlParameter{ParameterName="email", Value=email},
                new SqlParameter{ParameterName="description", Value=description},
                new SqlParameter{ParameterName="city", Value=city},
                new SqlParameter{ParameterName="street", Value=street},
                new SqlParameter{ParameterName="categoryId", Value=categoryId},
            });
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }


        public void Delete(int id)
        {
            string delete = " Delete from Users where Id=@id";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(delete, sqlConnection);
            command.Parameters.Add(new SqlParameter { ParameterName = "id", Value = id });
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
