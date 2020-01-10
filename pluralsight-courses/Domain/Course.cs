using System;

namespace pluralsight_courses.Domain
{
    public class Course
    {
        public Guid CourseId { get; }
        public User Author { get; }
        public string Title { get; }
        public TimeSpan Duration { get; }

        public Course(
            Guid courseId,
            User author,
            string title,
            TimeSpan duration)
        {
            CourseId = courseId;
            Author = author;
            Title = title;
            Duration = duration;
        }
    }
}