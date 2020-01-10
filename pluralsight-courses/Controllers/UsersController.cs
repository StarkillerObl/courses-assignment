using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pluralsight_courses.Domain;

namespace pluralsight_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController
    {
        private IUsersRepository _repository;

        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
            => 
                _repository
                    .GetAllUsers()
                    .ToList();
    }
}