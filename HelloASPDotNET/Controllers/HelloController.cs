using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/hello'>" +
                "<input type='text' name='name' />" +
                "<select name='lang'>" +
                "<option value=''>Choose a language</option>" +
                "<option value='en'>English</option>" +
                "<option value='fr'>French</option>" +
                "<option value='sp'>Spanish</option>" +
                "<option value='gr'>German</option>" +
                "<option value='it'>Italian</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
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

        [HttpGet("hello/{name?}/{lang?}")]
        [HttpPost("hello")]
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
