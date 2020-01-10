using System;
using System.Collections;
using System.Collections.Generic;

namespace pluralsight_courses.Domain
{
    public interface ICoursesRepository
    {
        IEnumerable<Course> GetAllCourses();
        bool CourseExists(Guid id);
    }
}