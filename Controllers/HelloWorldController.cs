using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_movie.Controllers
{
    public class HelloWorldController : Controller
    {

        //
        // GET: /HelloWorld/



        public IActionResult Index()
        {
            //return "This is my default action...";

            return View();

        }


        //
        // GET: /HelloWorld/Welcome/


        public IActionResult Welcome(string name, int ID = 1)
        {
            // return "This is the Welcome action method...";
            // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;
            return View();
        }

        

        public int Number()         /* GET https://localhost:#####/HelloWorld/Number/   in address bar -- assuming some these methods can be called through the UI by way of link - now i get it "URI"  */
        {
            return 99;
        }

    }
}
