﻿using WebApp_Manha.Entidades;

namespace WebApp_Manha.Models
{
    public class NovoProdutoModelView : Produtos
    {
        public NovoProdutoModelView()
        {

            ListaCategorias = new List<Categorias>();
        }
        public List<Categorias> ListaCategorias { get; set; }
    }
}