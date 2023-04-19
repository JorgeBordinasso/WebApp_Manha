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

            ClienteViewModel novo2 = new ClienteViewModel();
            novo.Nome = "Pedro";
            novo.Id = 11;
            novo.Telefone = "16997777947";

            ClienteViewModel novo3 = new ClienteViewModel();
            novo.Nome = "Fernando";
            novo.Id = 12;
            novo.Telefone = "16997777947";


            List<ClienteViewModel> lista = new List<ClienteViewModel>();
            lista.Add(novo);
            lista.Add(novo2);
            lista.Add(novo3);

            return View(lista);
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
