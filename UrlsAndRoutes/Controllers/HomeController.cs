using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string id) =>
            View("Result", new Result {Controller = nameof(HomeController), Action = nameof(Index), Id = id});
 
    }
}
