using Microsoft.EntityFrameworkCore;
using WebApp_Manha.Entidades;

namespace WebApp_Manha
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> opt ) :base( opt ) 
        {}

        public DbSet<Produtos> PRODUTOS{ get; set; }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<PermissaoEntidade> PERMISSAO{ get; set;}
    }
}
