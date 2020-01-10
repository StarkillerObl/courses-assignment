using System;

namespace pluralsight_courses.Domain
{
    public interface ICoursesService
    {
        bool Apply(Guid courseId, Guid userId);
    }
}