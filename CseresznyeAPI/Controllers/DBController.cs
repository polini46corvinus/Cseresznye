using Cseresznye.Data;
using Cseresznye.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CseresznyeAPI.Controllers
{
    [Route("api/autoalkatresz")]
    [ApiController]
    public class DBController : ControllerBase
    {
        // összes termék lekérdezése
        [HttpGet]
        public IActionResult Get()
        {
            AlkatreszDbContext context = new AlkatreszDbContext();
            var termekek = (from x in context.Termek
                            select x).ToList();
            return Ok(termekek);
        }

        // egy ügyfél lekérdezése
        [HttpGet("{ugyfelNev}")]
        public IActionResult Get(string ugyfelNev)
        {
            AlkatreszDbContext context = new AlkatreszDbContext();
            var ugyfel = (from x in context.Ugyfel
                          where x.Nev.Contains(ugyfelNev.ToLower())
                          select x).ToList();
            if (ugyfel != null)
            {
                return Ok(ugyfel);
            }
            else
            {
                return NotFound("Ilyen nevű ügyfél nincs");
            }
        }

        // új ÜGYFÉL hozzáadása
        [HttpPost]
        public void Post([FromBody] Ugyfel ujUgyfel)
        {
            AlkatreszDbContext context = new AlkatreszDbContext();
            context.Ugyfel.Add(ujUgyfel);
            context.SaveChanges();
        }

        // egy termék törlése
        [HttpDelete("{torlendoTermek}")]
        public void Delete(int torlendoTermek)
        {
            AlkatreszDbContext context = new AlkatreszDbContext();
            var torlendo = (from x in context.Termek
                            where x.TermekId == torlendoTermek
                            select x).FirstOrDefault();
            if (torlendo != null)
            {
                context.Termek.Remove(torlendo);
                context.SaveChanges();
            }
        }
    }
}
