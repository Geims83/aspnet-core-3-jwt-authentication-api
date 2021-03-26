using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {

        private readonly ILogger<DataController> _logger;
        private IUserService _userService;

        public DataController(IUserService userService, ILogger<DataController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [Authorize]
        [HttpPost]
        public IActionResult PostData(List<PostData> model)
        {
            foreach (var item in model)
                _logger.LogInformation(JsonConvert.SerializeObject(item));

            return Ok();
        }
        
    }
}
