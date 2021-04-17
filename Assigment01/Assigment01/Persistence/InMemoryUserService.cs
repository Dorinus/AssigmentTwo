using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace FileData
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    Password = "admin",
                    UserName = "admin",
                    SecurityLevel = 1,
                    Role = "admin"
                    
                },
                new User
                {
                    Password = "user",
                    UserName = "user",
                    SecurityLevel = 3,
                    Role = "user"
                },
                new User
                {
                    Password = "moderator",
                    UserName = "moderator",
                    SecurityLevel = 2,
                    Role = "moderator"
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}