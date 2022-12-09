using Microsoft.AspNetCore.Mvc;
using WebApplication_DO0SKP.JokeModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_DO0SKP.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET: api/<JokeController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Jokes.ToList());
        }

        // GET api/<JokeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var keresettvicc = (from x in context.Jokes
                                where x.JokeSk == id
                                select x).FirstOrDefault();
            return Ok(keresettvicc);
        }

        // POST api/<JokeController>
        [HttpPost]
        public void Post([FromBody] Joke újVicc)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            context.Jokes.Add(újVicc);
            context.SaveChanges();
        }

        // PUT api/<JokeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JokeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FunnyDatabaseContext ctx = new FunnyDatabaseContext();
            var törlendő = (from x in ctx.Jokes
                            where x.JokeSk == id
                            select x).FirstOrDefault();
            ctx.Remove(törlendő);
            ctx.SaveChanges();
        }
    }
}
