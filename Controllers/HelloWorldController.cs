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



        public string Index()
        {
            return "This is my default action...";
        }


        //
        // GET: /HelloWorld/Welcome/


        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        

        public int Number()         /* GET https://localhost:#####/HelloWorld/Number/   in address bar -- assuming some these methods can be called through the UI by way of link - now i get it  */
        {
            return 99;
        }

    }
}
