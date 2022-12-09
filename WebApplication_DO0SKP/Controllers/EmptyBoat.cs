using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_DO0SKP.Models;

namespace WebApplication_DO0SKP.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmptyBoat : ControllerBase
    {
        [HttpGet]
        [Route("questions/{sorszam}")]
        public IActionResult kerdesek(int sorszam)
        {
            HajosContext context = new HajosContext();
            var kérdés = (from x in context.Questions
                              where x.QuestionId == sorszam
                              select x).FirstOrDefault();

            if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

            return new JsonResult(kérdés);
        }
    }
}
