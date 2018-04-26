using System.Collections.Generic;
using Domain.Models;

namespace Domain.Contracts
{
    public interface IUserService
    {
        User GetUser(int id);

        IEnumerable<User> ListUsers();
    }
}
