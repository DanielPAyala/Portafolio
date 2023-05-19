using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;
using System.Reflection;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProyectoRepository _proyectoRepository;
        private readonly IEmailSendGridService _emailSendGridService;

        public HomeController(ILogger<HomeController> logger, IProyectoRepository proyectoRepository, IEmailSendGridService emailSendGridService)
        {
            _logger = logger;
            _proyectoRepository = proyectoRepository;
            _emailSendGridService = emailSendGridService;
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

        public IActionResult Gracias()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel model)
        {
            await _emailSendGridService.Enviar(model);
            return RedirectToAction("Gracias");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}