using System.Collections.Generic;
using Domain.Contracts;
using Domain.Models;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        User IUserService.GetUser(int id)
        {
            return new User
            {
                ID = 1,
                Email = $"user{id}@name.actual",
                Name = $"User Name {id}",
            };
        }

        IEnumerable<User> IUserService.ListUsers()
        {
            return new[]
            {
                new User { ID = 1, Email = "user1@name.actual", Name = "User Name 1" },
                new User { ID = 2, Email = "user2@name.actual", Name = "User Name 2" },
                new User { ID = 3, Email = "user3@name.actual", Name = "User Name 3" },
            };
        }
    }
}
