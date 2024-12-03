using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudianteController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "producto1", "producto2" };
        }
    }
}
