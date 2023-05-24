using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Entidades;

namespace WebApp_Manha.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto db;

        public CategoriasController(Contexto _db) 
        {
            this.db= _db;
        }


        
        public IActionResult Lista()
        {
            return View(db.Categorias.ToList());
          
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar() 
        {
            return View();
        }

        [HttpPost]

        public IActionResult SalvarDados(Categorias dados) 
        {
            db.Categorias.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
