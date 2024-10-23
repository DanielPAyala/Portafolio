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
                new() {
                    Titulo = "Pipes App",
                    Descripcion = "Listado de pipes comunes y personalizados",
                    Link = "https://danielpayala.github.io/pipes-app/",
                    ImagenURL = "/img/projects/pipes-app.png",
                    Repo = "https://github.com/DanielPAyala/pipes-app/tree/develop",
                    TipoProyectoDto = new() { Id = 1, Nombre = "Angular" }
                },
                new() {
                    Titulo = "Portafolio",
                    Descripcion = "Landing Page",
                    Link = "https://portafoliocarlosporras.azurewebsites.net/",
                    ImagenURL = "/img/projects/portafolio.png",
                    Repo = "https://github.com/DanielPAyala/Portafolio",
                    TipoProyectoDto = new() { Id = 2, Nombre = "ASP.NET Core" }
                },
                new() {
                    Titulo = "Country App",
                    Descripcion = "Single Page Application",
                    Link = "https://danielpayala.github.io/country-app",
                    ImagenURL = "/img/projects/countries-app.png",
                    Repo = "https://github.com/DanielPAyala/country-app",
                    TipoProyectoDto = new() { Id = 1, Nombre = "Angular" }
                },
                new() {
                    Titulo = "Gifs Apps",
                    Descripcion = "Buscador de gifs",
                    Link = "https://danielpayala.github.io/gifs-app/",
                    ImagenURL = "/img/projects/gifs-app.png",
                    Repo = "https://github.com/DanielPAyala/gifs-app/tree/develop",
                    TipoProyectoDto = new () { Id = 1, Nombre = "Angular" }
                },
                new() {
                    Titulo = "DBZ Personajes",
                    Descripcion = "Profundizar un poco más en los módulos, FormsModule, ngModel, @Inputs, @outputs, Servicios, Métodos en servicios",
                    Link = "https://danielpayala.github.io/angular-bases-deploy/",
                    ImagenURL = "/img/projects/dbz-personajes.png",
                    Repo = "https://github.com/DanielPAyala/angular-bases-deploy",
                    TipoProyectoDto = new() { Id = 1, Nombre = "Angular" }
                },
                new()
                {
                    Titulo = "Carrito de Compras",
                    Descripcion = "Aprendizaje de fundamentos de React, incluyendo componentes, eventos y estado, creando un carrito de compras real. Creación de Hooks personalizados, implementación de cantidades y precios, y transformación del código a TypeScript.",
                    Link = "https://guitarla-ts-f4496a.netlify.app/",
                    ImagenURL = "/img/projects/guitarla.png",
                    Repo = "https://github.com/DanielPAyala/react_guitarla-ts",
                    TipoProyectoDto = new() { Id = 3, Nombre = "React" }
                },
                new()
                {
                    Titulo = "Calculadora de Propinas y Consumos",
                    Descripcion = "Proyecto ideal para restaurantes, permitiendo generar una orden con consumos y elegir la propina a dejar. Simulación de guardado de información y generación de órdenes con propinas.",
                    Link = "https://calculadora-propinas-ab3e69.netlify.app/",
                    ImagenURL = "/img/projects/calculadora-propinas.png",
                    Repo = "https://github.com/DanielPAyala/react_calculadora-propinas",
                    TipoProyectoDto = new() { Id = 3, Nombre = "React" }
                },
                new()
                {
                    Titulo = "Contador de Calorías y Ejercicios",
                    Descripcion = "Desarrollo de un formulario para leer, procesar y validar datos, utilizando useReducer para manejar estados complejos. Procesamiento y validación de formularios para gestión de calorías y ejercicios.",
                    Link = "https://calorie-tracker-f05f15.netlify.app/",
                    ImagenURL = "/img/projects/calorie-tracker.png",
                    Repo = "https://github.com/DanielPAyala/react_calorie-tracker",
                    TipoProyectoDto = new() { Id = 3, Nombre = "React" }
                },
                new()
                {
                    Titulo = "Control de Gastos y Presupuestos",
                    Descripcion = "Implementación de Context API para tener un estado global sin dependencias y evitar pasar props por cada componente. Funcionalidades de filtrado de gastos por categoría, calendario de fechas de gastos, gráficas y más.",
                    Link = "https://control-gastos-517b07.netlify.app/",
                    ImagenURL = "/img/projects/control-gastos.png",
                    Repo = "https://github.com/DanielPAyala/expense-control-contextapi",
                    TipoProyectoDto = new() { Id = 3, Nombre = "React" }
                }
            };
        }
    }
}
