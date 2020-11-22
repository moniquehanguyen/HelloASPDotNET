using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    // [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /hello/welcome/
        // [HttpGet]
        // [Route("/helloworld/welcome/{name?}")]

        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        [HttpPost]
        [Route("/hello")]
        public IActionResult Message(string name = "World", string lang ="en")
        {
            if (lang == "it")
            {
                return Content("<h1>Ciao " + name + "!</h1>", "text/html");
            }
            else if (lang == "fr")
            {
                return Content("<h1>Bonjour " + name + "!</h1>", "text/html");
            }
            else if (lang == "sp")
            {
                return Content("<h1>Hola " + name + "!</h1>", "text/html");
            }
            else if (lang == "gr")
            {
                return Content("<h1>Hallo " + name + "!</h1>", "text/html");
            }
            else
            {
                return Content("<h1>Hello " + name + "!</h1>", "text/html");
            }
        }
    }
}
