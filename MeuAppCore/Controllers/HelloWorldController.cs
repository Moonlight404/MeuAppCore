using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeuAppCore.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        string[] movies = new string[] {
            "A rede social",
            "Harry Potter",
            "Avatar",
            "Ladrão de raios"
        };

        string[] fotos = new string[]
        {
            "https://upload.wikimedia.org/wikipedia/pt/b/b2/A_Rede_Social.png",
            "https://static1.purebreak.com.br/articles/6/91/90/6/@/353206-de-harry-potter-a-descendentes-faca-diapo-1.jpg",
            "https://i.correiobraziliense.com.br/D7nA7yEBHX5e3Qgc7iQ7nMJYM5I=/675x/smart/imgsapp2.correiobraziliense.com.br/app/noticia_127983242361/2019/10/04/794834/20191004154953157610i.jpg",
            "https://http2.mlstatic.com/percy-jackson-e-os-olimpianos-o-ladro-de-raios-D_NQ_NP_656736-MLB28873887615_122018-F.jpg"
        };

        string[] autor = new string[]
        {
            "Ben Mezrich",
            "J. K. Rowling",
            "James Cameron",
            "Rick Riordan"
        };

        public IActionResult Welcome()
        {
            ViewData["filme"] = movies;
            ViewData["autor"] = autor;
            ViewData["fotos"] = fotos;
            ViewData["NumTimes"] = movies.Length;

            return View();
        }
    }
}
