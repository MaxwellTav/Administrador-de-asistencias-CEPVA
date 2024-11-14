using Administrador_de_asistencias_CEPVA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Administrador_de_asistencias_CEPVA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            InitializeViewBags(false, false, false);
            return View();
        }

        /// <summary>
        /// Autom�ticamente oculta o muestra un componente de la p�gina.
        /// </summary>
        /// <param name="_navbar">Esconder� la barra de navegaci�n superior.</param>
        /// <param name="_sidebar">Esconder� la barra lateral, la cu�l est� el men� y dem�s opciones.</param>
        /// <param name="_footer">Esconder� el pie de p�gina.</param>
        void InitializeViewBags(bool _navbar, bool _sidebar, bool _footer)
        {
            ViewBag.HideNavbar = _navbar;
            ViewBag.HideSidebar = _sidebar;
            ViewBag.HideFooter = _footer;
        }
    }
}
