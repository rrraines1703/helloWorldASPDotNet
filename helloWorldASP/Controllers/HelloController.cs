using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloASP.NET.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            string html = "<form method = 'post' action = '/CreateMessage/'>" +
                 "<input type = 'text' name = 'name'/>" +
                 "<select name = 'language'>" +
                    "<option value='Hello! '>English</option>" +
                    "<option value='Bon Jour! '>French</option>" +
                    "<option value='Hola! '>Spanish</option>" +
                    "<option value='Hallo! '>German</option>" +
                    "<option value='Ciao! '>Italian</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            return Content(html, "text/html");

        }

        [HttpGet("welcome/{name?}")]
        [HttpPost]

        public IActionResult Welcome(string name = "World")
        {
            return Content($"<h1>Welcome {name} !</h1>", "text/html");
        }

        [HttpPost("/CreateMessage/")]
        public IActionResult CreateMessage(string name, string language = "English")
        {
            string html = language + name;
            return Content(html, "text/html");
        }
    }
}