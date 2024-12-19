using Microsoft.AspNetCore.Mvc;

namespace VU_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniqueStringController : Controller
    {
        [HttpGet]
        public ActionResult UniqueString() {
          
            string UnqString = Guid.NewGuid().ToString(); 

            return Ok(new { UniqueString = UnqString });  
        
        }
    }
}
