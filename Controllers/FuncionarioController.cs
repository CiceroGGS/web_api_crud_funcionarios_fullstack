using Microsoft.AspNetCore.Mvc;

namespace WebApi_Funcionarios.Controllers
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