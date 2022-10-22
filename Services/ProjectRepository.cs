using Portafolio.Models;

namespace Portafolio.Services
{

    public interface IProjectRepository
    {
        List<Project> GetAll();
        Project GetById(int id);
    }

    public class ProjectRepository : IProjectRepository
    {
        public List<Project> GetAll()
        {
            return new List<Project>()
            {
                new Project(){
                    Title="Amazon",
                    Description="E-Commerce realizado en ASP.NET Core",
                    ImageUrl="/images/amazon.png",
                    Link="https://amazon.com"
                },
                new Project(){
                    Title="NewYork Times",
                    Description="Paginas de noticias en React Js",
                    ImageUrl="/images/nyt.png",
                    Link="https://nytimes.com"
                },
                new Project(){
                    Title="Mi Portafolio",
                    Description="Mi Portafolio de proyectos web",
                    ImageUrl="/images/portafolio.png",
                    Link="https://localhost:7082/"
                },
                new Project(){
                    Title="Reddit",
                    Description="Red social para compartir en comunidades",
                    ImageUrl="/images/reddit.png",
                    Link="https://reddit.com"
                },
                new Project(){
                    Title="Steam",
                    Description="Tienda en linea para comprar videojuegos",
                    ImageUrl="/images/steam.png",
                    Link="https://store.steampowered.com"
                }
            };
        }

        public Project GetById(int id)
        {
            return new Project() { };
        }
    }
}
