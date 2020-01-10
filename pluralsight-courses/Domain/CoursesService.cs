using System;
using System.ComponentModel;

namespace pluralsight_courses.Domain
{
    public class CoursesService : ICoursesService
    {
        private ICoursesRepository _coursesRepository;
        private IUsersRepository _userRepository;

        public CoursesService()
        {
            Initialize();
        }
        public bool Apply(Guid courseId, Guid userId)
        {
            if(!_coursesRepository.CourseExists(courseId)) throw new ArgumentException();
            if(!_userRepository.UserExists(userId)) throw new ArgumentException();
            
            throw new NotImplementedException();
        }

        private void Initialize()
        {
            
        }
    }
}