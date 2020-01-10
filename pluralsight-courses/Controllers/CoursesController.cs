using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pluralsight_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        //private ICoursesService _coursesService;
        [HttpGet("hello")]
        public async Task<ActionResult<string>> Hello()
        {
            return Ok("Hello");
        }
    }
}