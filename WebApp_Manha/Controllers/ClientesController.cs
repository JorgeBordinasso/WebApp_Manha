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
            if(model.Id > 0)
            {
                int indice = lista.FindIndex(a => a.Id == model.Id); 
                lista[indice] = model;

            }
            else
            {
                Random random = new Random();
                model.Id = random.Next(1,9999);
                lista.Add(model);
            }



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
            ClienteViewModel cliente = lista.Find(a => a.Id == id);
           
            if (cliente != null)
            {
                return View(cliente);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }

        public IActionResult Excluir(int id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == id);
            if(cliente != null)
            {
                lista.Remove(cliente);

            }
            return RedirectToAction("Lista");
        }

        public IActionResult Compras(int id)
        {
            return View();
        }
    }
}
