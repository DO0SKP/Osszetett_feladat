using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_DO0SKP.Controllers
{
    
    
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult m2(string szoveg)
        {
            return Ok(szoveg.ToUpper());
        }
    }
    
}
