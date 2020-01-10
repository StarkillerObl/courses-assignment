using System;
using System.Collections.Generic;
using System.Linq;

namespace pluralsight_courses.Domain
{
    public class InMemoryCoursesRepository : ICoursesRepository
    {
        private List<Course> _courses = new List<Course>();

        public IEnumerable<Course> GetAllCourses()
            => _courses;

        public void AddCourse(Course course)
            => _courses.Add(course);

        public bool CourseExists(Guid id)
            =>
                _courses
                    .Any(course => course.CourseId == id);
    }
}