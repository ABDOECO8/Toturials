using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Toturials.Models;

namespace Toturials.Controllers
{
    public class HomeController : Controller
    {

        // GET: /<controller>/
        public IActionResult Home()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }

            // Utilisez userViewModel dans votre vue
            return View(userViewModel);
        }
        public IActionResult Python()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }
            return PartialView("Python", userViewModel);
        }

        public IActionResult Go()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }
            return PartialView("Go", userViewModel);
        }


        public IActionResult Swift()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }
            return PartialView("Swift", userViewModel);
        }


        public IActionResult JavaScript()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }
            return PartialView("JavaScript", userViewModel);
        }


        public IActionResult TypeScript()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }
            return PartialView("TypeScript", userViewModel);
        }


        public IActionResult Csharp()
        {
            var userViewModel = HttpContext.Session.GetObject<UserViewModel>("UserViewModel");

            // Assurez-vous que l'utilisateur est connecté
            if (userViewModel == null)
            {
                // Redirigez vers la page de connexion si l'utilisateur n'est pas connecté
                return RedirectToAction("Login");
            }
            return PartialView("Csharp",userViewModel);
        }


    }
}

