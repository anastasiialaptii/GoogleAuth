using AuthTest.AppDbContext;
using AuthTest.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AuthTest.Controllers
{
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private AuthDbContext _dbContext;

        public AuthController(AuthDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("Api/Login/Savesresponse")]
        [HttpPost]
        public object Savesresponse(User user)
        {
            var list = _dbContext.Users.ToList();
            
            foreach (var item in list)
            {
                if (item.id == user.id)
                {
                    return new Response { Message = item.idToken, Status = "Exists" };  
                }
            }

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return new Response { Message = user.idToken,Status="OK" };
        }


        [Route("Api/Login/GetTest")]
        [HttpGet]
        public int GetTest()
        {
            return 5;
        }
    }
}

