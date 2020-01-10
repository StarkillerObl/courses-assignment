using System;

namespace pluralsight_courses.Domain
{
    public class Course
    {
        public Guid CourseId { get; }
        public Guid AuthorId { get; }
        public string Title { get; }
        public TimeSpan Duration { get; }
    }
}