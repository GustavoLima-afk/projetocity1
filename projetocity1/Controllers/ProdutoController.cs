using Microsoft.AspNetCore.Mvc;
using projetocity1.Models;
using projetocity1.Repositorio;

namespace projetocity1.Controllers
{
    public class ProdutoController : Controller
    {
        /*construtor*/
        private readonly ProdutoRepositorio _produtoRepositorio;

        public ProdutoController(ProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepositorio.AdicionarProduto(produto);
                return RedirectToAction("Cadastro");
            }
            return View(produto);
        }
    }
}

