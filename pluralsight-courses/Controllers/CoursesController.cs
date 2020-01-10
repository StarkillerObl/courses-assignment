using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pluralsight_courses.Domain;

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
    }
}