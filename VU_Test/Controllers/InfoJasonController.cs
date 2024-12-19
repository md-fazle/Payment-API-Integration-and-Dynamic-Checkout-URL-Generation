using Microsoft.AspNetCore.Mvc;
using VU_Test.Models;

namespace VU_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoJasonController : Controller
    {
        [HttpGet]
        [Route("GenInfo")]
         public IActionResult GenInfoJason() {

            var infoJason = InfoJasonModel.GenerateRandom();  
            
            
            return Ok(infoJason); 
        }
    }
}
