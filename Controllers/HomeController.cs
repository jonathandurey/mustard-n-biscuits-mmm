using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EBBModels.Models;
using EBBServices.Interfaces;
using EBBServices.Implementations;

namespace EbbMvcDemo.Controllers
{
    public class HomeController : Controller
    {

        private INominationService _nominationService => new NominationService();
        private IUserService userService = new UserSerivce();



        public IActionResult Index()
        {
            return Package();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return Package();
            // return RedirectToAction("NominationList", "Nomination", new { id = 1 });
            // var model = new LoginViewModel() { Title = "Log in to GASTAR", SubTitle = "Please enter your credentials." };
            // return View(model);
        }

        [HttpGet]
        public IActionResult Package()
        {
            PackageViewModel model = new PackageViewModel();
            return View("Package", model);
        }

        [HttpPost]
        public IActionResult SearchPackage(PackageViewModel model)
        {
            model =_nominationService.GetPackage(model.ID);
            return View(nameof(Package), model);
        }


        [HttpPost]
        public IActionResult SavePackage(PackageViewModel model)
        {
            var resp = _nominationService.SavePackage(model);
            model.ErrorMessages = resp.ErrorMessages;
            return SearchPackage(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            //return Dashboard();

            return Package();
           // return RedirectToAction("NominationList", "Nomination", new { id = 1 });
            //redirect to an existing EBB Page here;
            //return View(model);

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
