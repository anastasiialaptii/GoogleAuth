using AuthTest.AppDbContext;
using AuthTest.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;

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
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return new Response
            { Status = "Error", Message = "Invalid Data." };
        }
    }
}

