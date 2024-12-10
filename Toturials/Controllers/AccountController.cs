using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Toturials.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Toturials.Controllers
{
  

    public class AccountController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AccountController(AppDbContext dbContext)
        {
            
            _dbContext = dbContext;
        }

        public IActionResult Login()
        {
            return View("Login");
        }
       
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Vérifier les informations d'identification de l'utilisateur dans la base de données
                    var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);

                    if (existingUser != null)
                    {

                        // Utiliser UserViewModel pour stocker les données de l'utilisateur
                        var userViewModel = new UserViewModel
                        {
                            FirstName = existingUser.FirstName,
                            LastName = existingUser.LastName,
                            UserName = existingUser.UserName
                        };

                        // Stocker le modèle dans ViewBag
                        HttpContext.Session.SetObject("UserViewModel", userViewModel);

                        return RedirectToAction("Home", "Home");// Rediriger vers la page d'accueil après la connexion
                    }
                    else
                    {
                        // L'utilisateur n'est pas trouvé dans la base de données, afficher un message d'erreur
                        TempData["ErrorMessage"] = "Invalid username or password. Please try again.";
                        return RedirectToAction("Login");
                    }
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = $"An error occurred: {ex.Message}";
                    return RedirectToAction("Login");
                }
            }

            // Si le modèle n'est pas valide, retournez à la page Login avec les erreurs
            return View(user);
        }


        public IActionResult SignUp()
        {
            return PartialView("SignUp");
        }

       
            [HttpPost]
            public IActionResult SignUp(User newUser)
            {
                if (ModelState.IsValid)
                {
                try
                    {
                    //Vérifier si le compte existe déjà
                   var existingUser = _dbContext.Users.FirstOrDefault(u => u.UserName == newUser.UserName);

                    if (existingUser != null)
                    {
                        TempData["ErrorMessage"] = "Account with this email already exists.";
                        return RedirectToAction("SignUp");
                    }

                    // Utilisez _dbContext pour ajouter le nouvel utilisateur à la base de données
                    _dbContext.Users.Add(newUser);
                        _dbContext.SaveChanges();

                        TempData["SuccessMessage"] = "Account created successfully. You can now log in.";
                        return RedirectToAction("SignUp");
                    }
                    catch (Exception ex)
                    {
                        TempData["ErrorMessage"] = $"An error occurred";
                   
                    return RedirectToAction("SignUp");
                    }
                }

                // Si le modèle n'est pas valide, retournez à la page SignUp avec les erreurs
                return View(newUser);
        }
      
    }
}


