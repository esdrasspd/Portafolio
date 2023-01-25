using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositorioProyectos //creando interface
    {
        List<Proyecto> ObtenerProyectos(); //se agrega la función de obtener los proyectos
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto
            {
                Titulo = "Manejo de Presupuesto",
                Descripcion = "Aplicación web para llevar el control de presupuestos. Hecha en ASP.NET Core",
                Link = "https://manejopresupuesto1.azurewebsites.net/",
                ImagenURL = "/imagenes/manejopresupuesto.jpg",
                Web = true
            },
            new Proyecto
            {
                Titulo = "Clientes",
                Descripcion = "Aplicación web para llevar registro de clientes. Hecha en Java y Spring Boot",
                Link = "https://amazon.com",
                ImagenURL = "/imagenes/clientes.jpg",
                Web = false
            },
            new Proyecto
            {
                Titulo = "Formain",
                Descripcion = "Sistema de escritorio POS hecho en Java",
                ImagenURL = "/imagenes/formain.jpg",
                Web = false,
            },
            new Proyecto
            {
                Titulo = "Servicios Contables Ola",
                Descripcion = "Sistema de escritorio para llevar el control de una oficina contable llamada Ola. Realizado en Java.",
                ImagenURL = "/imagenes/ola.jpg",
                Web = false,
            },
            new Proyecto
            {
                Titulo = "Supercampeones",
                Descripcion = "Sistema de escritorio que permite almacenar diferentes equipos de fútbol. Hecha en C++ y .NET Framework.",
                ImagenURL = "/imagenes/supercampeones.jpg",
                Web = false,
            },
            new Proyecto
            {
                Titulo = "Dinner",
                Descripcion = "Aplicación móvil para poder llevar el control de las comidas pedidas en un restaurante o comedor. Hecha en Dart y Flutter.",
                ImagenURL = "/imagenes/dinner1.jpg",
                Web = false,
            },
            new Proyecto
            {
                Titulo = "Películas en cine",
                Descripcion = "Aplicación móvil para poder ver las películas populares en los cines. Hecha en Dart y Flutter.",
                ImagenURL = "/imagenes/peliculas.jpg",
                Web = false,
            },
                };

        }


    }
}
