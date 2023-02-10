﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileMonitoring.Shared;

namespace MobileMonitoring.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Get all users
        /// </summary>
        /// <param name="monitCont"></param>
        /// <returns>List of users with user company name</returns>
        [HttpGet]
        public IEnumerable<UserDto> Get([FromServices] MonitoringContext monitCont) => monitCont.Users.Select(user => new UserDto(user));

    }
}
