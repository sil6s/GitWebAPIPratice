﻿// Silas Curry
//10/24/2024
using Microsoft.AspNetCore.Mvc;

namespace GitWebAPIPratice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Name = "Silas Curry" });
        }
    }
}