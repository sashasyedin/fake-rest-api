using System.Collections.Generic;
using Bogus;
using Domain.Contracts;
using Domain.Models;

namespace Domain.Services.Fake
{
    public class UserService : IUserService
    {
        private const int MaxNumber = 10;

        private readonly Faker<User> _faker;

        public UserService()
        {
            _faker = new Faker<User>()
                .StrictMode(true)
                .RuleFor(u => u.ID, f => f.Random.Int(1, MaxNumber))
                .RuleFor(u => u.Email, f => f.Person.Email)
                .RuleFor(u => u.Name, f => f.Person.FullName);
        }

        public User GetUser(int id) => _faker.Generate();

        public IEnumerable<User> ListUsers() => _faker.Generate(MaxNumber);
    }
}
