using HomeEase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeEase.Controllers
{
    public class UsersController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

   
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
