using System;
using System.ComponentModel;
using System.Linq;

namespace pluralsight_courses.Domain
{
    public class CoursesService : ICoursesService
    {
        private ICoursesRepository _coursesRepository;
        private IUsersRepository _userRepository;

        public CoursesService(
            ICoursesRepository coursesRepository,
            IUsersRepository userRepository)
        {
            _coursesRepository = coursesRepository;
            _userRepository = userRepository;
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
            void AddNigelPoultonCourses()
            {
                var author =
                    _userRepository
                        .GetAllUsers()
                        .First(user => user.FirstName == "Nigel" 
                                       && user.LastName == "Poulton");

                _coursesRepository.AddCourse(
                    new Course(
                        Guid.NewGuid(),
                        author,
                        "Docker Deep Dive",
                        new TimeSpan(4, 40, 0)));
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.NewGuid(),
                        author,
                        "Docker and Kubernetes: The Big Picture",
                        new TimeSpan(1,47,0)));
            }
            void AddZoranHorvatCourses()
            {
                var author =
                    _userRepository
                        .GetAllUsers()
                        .First(user => user.FirstName == "Zoran"
                                       && user.LastName == "Horvat");
                
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.NewGuid(),
                        author,
                        "Making Your C# COde More Functional",
                        new TimeSpan(3,54,0)));
            }

            void AddJasonRobertsCourses()
            {
                var author =
                    _userRepository
                        .GetAllUsers()
                        .First(user => user.FirstName == "Jason"
                                       && user.LastName == "Roberts");
                
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.NewGuid(),
                        author,
                        "Building Concurrent Applications with the Actor Model in Akka.NET",
                        new TimeSpan(3,23,0)));
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.NewGuid(),
                        author,
                        "Building Reactive Concurrent WPF Applications with Akka.NET",
                        new TimeSpan(1,31,0)));
            }
            AddNigelPoultonCourses();
            AddZoranHorvatCourses();
            AddJasonRobertsCourses();
        }
    }
}