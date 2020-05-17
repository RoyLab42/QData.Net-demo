using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyLab.QData.Demo.Data;
using RoyLab.QData.Demo.Model;

namespace RoyLab.QData.Demo.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly DbContext dbContext;

        public UserController(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Query([FromQuery] string selector, [FromQuery] string filter, [FromQuery] string orderBy)
        {
            var result = dbContext.Set<UserModel>()
                .QueryDynamic(selector, filter, orderBy);
            return Ok(result);
        }
    }
}