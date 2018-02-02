using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index(Result result) =>
            View("Result", result);

        public ViewResult List() => View("result",
            new Result {Controller = nameof(CustomerController), Action = nameof(List)});
    }
}
