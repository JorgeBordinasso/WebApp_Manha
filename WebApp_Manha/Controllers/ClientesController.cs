using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {   
            ClienteViewModel novo = new ClienteViewModel();
            novo.Nome = "Jorge Henrique";
            novo.Id = 10;
            novo.Telefone = "16997777947";
            return View(novo);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)

        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "o campo nome não pode estar em branco";
            }

            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "o campo telefone não pode estar em branco";
            }
            return View();
        }
        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            return View();
        }
    }
}
