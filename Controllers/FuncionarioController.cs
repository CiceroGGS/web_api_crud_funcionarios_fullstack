using Microsoft.AspNetCore.Mvc;

namespace WebApiFuncionario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("oi");
        }
    }
}