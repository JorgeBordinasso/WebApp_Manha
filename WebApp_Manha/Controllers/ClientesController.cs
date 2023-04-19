using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClienteViewModel> lista = new List<ClienteViewModel>();
        public IActionResult Lista()
        {   
            //ClienteViewModel novo = new ClienteViewModel();
            //novo.Nome = "Jorge Henrique";
            //novo.Id = 10;
            //novo.Telefone = "16997777947";

            //ClienteViewModel novo2 = new ClienteViewModel();
            //novo2.Nome = "Pedro";
            //novo2.Id = 11;
            //novo2.Telefone = "16997777947";

            //ClienteViewModel novo3 = new ClienteViewModel();
            //novo3.Nome = "Fernando";
            //novo3.Id = 12;
            //novo3.Telefone = "16997777947";


            
            //lista.Add(novo);
            //lista.Add(novo2);
            //lista.Add(novo3);

            return View(lista);
        }

        [HttpPost]
        public IActionResult SalvarDados(ClienteViewModel model)
        {
            lista.Add(model);
            return RedirectToAction("Lista");
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
