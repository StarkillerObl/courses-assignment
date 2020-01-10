using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace pluralsight_courses.Domain
{
    public class InMemoryUsersRepository : IUsersRepository
    {
        private List<User> _users = new List<User>()
        {
            new User(
                Guid.NewGuid(),
                "John",
                "Xyz"),
            new User(
                Guid.NewGuid(),
                "Anna",
                "Zyx"),
            new User(
                Guid.Parse("6bbdb409-d44b-4c6a-91af-3bb29b1918ee"),
                "Nigel",
                "Poulton"),
            new User(
                Guid.Parse("f4b3d8fe-7ea4-49f2-87af-31f7f9a8a8ac"),
                "Zoran",
                "Horvat"),
            new User(
                Guid.Parse("6b37078b-e630-48d7-8809-c49c847945c4"),
                "Jason",
                "Roberts")
        };
        public IEnumerable<User> GetAllUsers()
            => _users;

        public bool UserExists(Guid id)
            =>
                _users
                    .Any(user => user.Id == id);
    }
}