using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IProyectoRepository
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class ProyectoRepository : IProyectoRepository
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>
            {
                new ProyectoDTO {
                    Titulo = "Pipes App",
                    Descripcion = "Listado de pipes comunes y personalizados",
                    Link = "https://danielpayala.github.io/pipes-app/",
                    ImagenURL = "/img/projects/pipes-app.png",
                    Repo = "https://github.com/DanielPAyala/pipes-app/tree/develop"
                },
                new ProyectoDTO
                {
                    Titulo = "Portafolio",
                    Descripcion = "Landing Page",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/img/projects/portafolio.png",
                    Repo = "https://github.com/DanielPAyala/Portafolio"
                },
                new ProyectoDTO
                {
                    Titulo = "Country App",
                    Descripcion = "Single Page Application",
                    Link = "https://danielpayala.github.io/country-app",
                    ImagenURL = "/img/projects/countries-app.png",
                    Repo = "https://github.com/DanielPAyala/country-app"
                },
                new ProyectoDTO
                {
                    Titulo = "Gifs Apps",
                    Descripcion = "Buscador de gifs",
                    Link = "https://danielpayala.github.io/gifs-app/",
                    ImagenURL = "/img/projects/gifs-app.png",
                    Repo = "https://github.com/DanielPAyala/gifs-app/tree/develop"
                },
                new ProyectoDTO
                {
                    Titulo = "DBZ Personajes",
                    Descripcion = "Profundizar un poco más en los módulos, FormsModule, ngModel, @Inputs, @outputs, Servicios, Métodos en servicios",
                    Link = "https://danielpayala.github.io/angular-bases-deploy/",
                    ImagenURL = "/img/projects/dbz-personajes.png",
                    Repo = "https://github.com/DanielPAyala/angular-bases-deploy"
                }
            };
        }
    }
}
