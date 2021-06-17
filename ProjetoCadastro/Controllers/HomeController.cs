using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoCadastro.Models;
using System.Web.Mvc;

namespace ProjetoCadastro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ProdutoView()
        {
            var produto = new Produto();
            return View(produto);
        }
        [HttpPost]
        
        public ActionResult ProdutoView(Produto produto)
        {
            if (ModelState.IsValid)
            {
                return View("ResultadoView", produto);
            }
            return View(produto);
        }

        public ActionResult ResultadoView(Produto produto)
        {
            return View(produto);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}