using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pluralsight_courses.Domain
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
        bool UserExists(Guid id);
        User FindById(Guid userId);
        User FindByFirstAndLastName(string firstName, string lastName);
    }
}