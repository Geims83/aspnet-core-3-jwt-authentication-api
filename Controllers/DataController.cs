using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;
using Newtonsoft.Json;
using System;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private IUserService _userService;

        public DataController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpPost]
        public IActionResult PostData(PostData model)
        {
            Console.Write(JsonConvert.SerializeObject(model));

            return Ok();
        }
        
    }
}
