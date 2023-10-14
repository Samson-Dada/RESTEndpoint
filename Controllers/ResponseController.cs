using Endpoint.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
      
        [HttpGet("message")]
        public ActionResult<Response> GetMessage()
        {
            var Response = new Response
            {
                Message = "Automate all the things Dolapo !",
                Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds()
            };

            return  Ok(Response);
        }
    }
}
