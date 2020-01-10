using System;
using System.Collections;
using System.Collections.Generic;

namespace pluralsight_courses.Domain
{
    public interface ICoursesRepository
    {
        IEnumerable<Course> GetAllCourses();
        void AddCourse(Course course);
        bool CourseExists(Guid id);
        Course FindById(Guid id);
    }
}