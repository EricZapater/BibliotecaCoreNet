using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BibliotecaCoreNet.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET:/HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET : /HelloWorld/Welcome
        public string Welcome(string name, int numtimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}. Numtimes {numtimes}");
        }

    }
}