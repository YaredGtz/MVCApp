using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        //Get: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        //Method Get use: /HelloWorld/Welcome/
        //Requires using System.text.Encodings.Web
        //Get: /HelloWorld/Welcome?name=Yared&numTimes=31
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    //return "This is  the Welcome action method";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}
    }
}
