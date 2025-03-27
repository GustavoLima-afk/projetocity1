using Microsoft.AspNetCore.Mvc;

namespace projetocity1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
