using Microsoft.AspNetCore.Mvc;
using Model1.Models;

namespace Model1.Controllers
{
    [ApiController]
       
    public class RestauranController(MapDbContext db) : ControllerBase 
    {
        [HttpGet("system/restaurant")]
        public ApiResult List()
        {

        }
        
            
    }
}
