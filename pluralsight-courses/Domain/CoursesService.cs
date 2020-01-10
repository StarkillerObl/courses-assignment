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
        public void Apply(Guid courseId, Guid userId)
        {
            //basic guard clauses
            if(!_coursesRepository.CourseExists(courseId)) throw new ArgumentException();
            if(!_userRepository.UserExists(userId)) throw new ArgumentException();

            var user = _userRepository.FindById(userId);
            var course = _coursesRepository.FindById(courseId);

            //this prevents the user from applying multiple times
            //I could also consider throwing something like UserAlreadyAppliedException in this case
            if(!CheckIfUserHasAlreadyApplied(user,course)) course.AppliedUsers.Add(user); 
        }

        private bool CheckIfUserHasAlreadyApplied(User user, Course course)
            =>
                course
                    .AppliedUsers
                    .Any(appliedUser => appliedUser.Id == user.Id);
        
        /// <summary>
        /// Fills course repository with data
        /// </summary>
        private void Initialize()
        {
            void AddNigelPoultonCourses()
            {
                var author =
                    _userRepository
                        .FindByFirstAndLastName("Nigel","Poulton");

                _coursesRepository.AddCourse(
                    new Course(
                        Guid.Parse("9d401e07-3018-4aef-a62e-ca0ec308e59e"),
                        author,
                        "Docker Deep Dive",
                        new TimeSpan(4, 40, 0)));
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.Parse("0a5bbe6a-424d-40c5-82ef-55e221d754b1"),
                        author,
                        "Docker and Kubernetes: The Big Picture",
                        new TimeSpan(1,47,0)));
            }
            void AddZoranHorvatCourses()
            {
                var author =
                    _userRepository
                        .FindByFirstAndLastName("Zoran", "Horvat");
                
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.Parse("1025d48c-8004-4115-96fc-f94e96382d41"),
                        author,
                        "Making Your C# COde More Functional",
                        new TimeSpan(3,54,0)));
            }
            void AddJasonRobertsCourses()
            {
                var author =
                    _userRepository
                        .FindByFirstAndLastName("Jason","Roberts");

                _coursesRepository.AddCourse(
                    new Course(
                        Guid.Parse("37f80df6-ca68-4860-a7d0-21df29cdbd5f"),
                        author,
                        "Building Concurrent Applications with the Actor Model in Akka.NET",
                        new TimeSpan(3,23,0)));
                _coursesRepository.AddCourse(
                    new Course(
                        Guid.Parse("580f3c04-c5fb-4006-af6d-751cc3228a80"),
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