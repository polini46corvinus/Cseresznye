using Cseresznye.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CseresznyeAPI.Controllers
{
    [Route("api/ugyfel")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int ugyfelId)
        {
            AlkatreszDbContext context = new AlkatreszDbContext();
            var ugyfel = (from x in context.Ugyfel
                          where x.Ugyfelid == ugyfelId
                          select x).FirstOrDefault();
            if (ugyfel != null)
            {
                return Ok(ugyfel);
            }
            else
            {
                return NotFound("Ügyfél nem található");
            }
        }
    }
}
