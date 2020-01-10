using System;

namespace pluralsight_courses.Domain
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        private User() {}
        public User(
            Guid id,
            string firstName,
            string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        
    }
}