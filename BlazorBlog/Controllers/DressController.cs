using BlazorBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class DressController : ControllerBase
    {
        private static Dress dress = new Dress();
        
        [HttpGet]        
        public ActionResult<Dress> Get() { return Ok(dress); }
    }
}