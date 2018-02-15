using Microsoft.AspNetCore.Mvc;

namespace ModelBindingBugDemo.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
	        const string cmd = @"POST /api/test HTTP/1.1
Host: localhost:26730
Content-Type: application/json
Cache-Control: no-cache

{
	""User"": 
	{
		""UserSid"": ""S-1-5-21-1004336348-1177238915-682003330-512""
	}
}";

	        return Ok("Execute the following command in your favorite API dev environment:\n\n" + cmd);
        }
		
	    [HttpPost]
	    public IActionResult Post([FromBody]ComplexObject obj)
	    {
		    return Ok();
	    }
	}
}
