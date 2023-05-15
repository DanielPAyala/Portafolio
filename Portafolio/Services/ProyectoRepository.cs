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
                new ProyectoDTO
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/img/amazon.png"
                },
                new ProyectoDTO
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/img/nyt.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/img/reddit.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en línea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/img/steam.png"
                }
            };
        }
    }
}
