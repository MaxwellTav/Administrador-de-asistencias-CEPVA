﻿using Microsoft.AspNetCore.Mvc;

namespace Administrador_de_asistencias_CEPVA.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult RegistNewUser()
        {
            return View();
        }


    }
}
