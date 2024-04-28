using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class DressController : ControllerBase
    {
        private static Dress dress = new Dress();

        public IActionResult Get() { return Ok(dress); }
    }
}