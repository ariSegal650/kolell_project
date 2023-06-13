using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using server.Data;

namespace server.Controllers
{
    [Route("[controller]")]
    public class test : Controller
    {
         private DataContext _Context { get; }
        public test(DataContext context)
        {
            
        }

        [HttpGet]
       public IActionResult test1()
       {
            return Ok(_Context.videos);
       }
    }
}