using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProyectoRepository _proyectoRepository;

        public HomeController(ILogger<HomeController> logger, IProyectoRepository proyectoRepository)
        {
            _logger = logger;
            _proyectoRepository = proyectoRepository;
        }

        public IActionResult Index()
        {
            var proyectos = _proyectoRepository.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {   
            var proyectos = _proyectoRepository.ObtenerProyectos();
            return View(proyectos);
        }

        public IActionResult Contacto()
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