using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pluralsight_courses.Domain;
using pluralsight_courses.Dto;

namespace pluralsight_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICoursesRepository _coursesRepository;
        private ICoursesService _coursesService;

        public CoursesController(
            ICoursesRepository coursesRepository,
            ICoursesService coursesService)
        {
            _coursesRepository = coursesRepository;
            _coursesService = coursesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAllCourses()
            => _coursesRepository
                .GetAllCourses()
                .ToList();

        [HttpPost("{courseid}/apply")]
        public ActionResult ApplyForCourse(
            [FromRoute] Guid courseid,
            [FromBody] ApplyForCourseDto dto)
        {
            try
            {
                _coursesService
                    .Apply(courseid, dto.UserId);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return Problem();
            }

            return Ok();
        }

        [HttpGet("{courseid}/getapplied")]
        public ActionResult<IEnumerable<User>> GetAppliedUsers([FromRoute] Guid courseId)
        =>
            _coursesRepository
                .GetAllCourses()
                .First(course => course.CourseId == courseId)
                .AppliedUsers;
    }
}