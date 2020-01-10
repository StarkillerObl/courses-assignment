using System;

namespace pluralsight_courses.Domain
{
    public interface ICoursesService
    {
        void Apply(Guid courseId, Guid userId);
    }
}