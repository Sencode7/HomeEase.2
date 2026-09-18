using HomeEase.Models;
using HomeEase.Services;
using HomeEase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeEase.Controllers
{
    public class UsersController : Controller
    {
        private readonly LandlordService _landlordService;

        public UsersController(LandlordService landlordService)
        {
            _landlordService = landlordService;
        }


        [HttpGet]
        public IActionResult landlordHome()
        { 
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Convert ViewModel data to Landlord
            var landlord = new Landlord
            {
                FullName = model.Input.FullName,
                Email = model.Input.Email,
                ContactNumber = model.Input.ContactNumber,
                Password = model.Input.Password
            };

            await _landlordService.SaveLandlord(landlord);

            return RedirectToAction("LandlordHome", "Users");
        }
    }

}

