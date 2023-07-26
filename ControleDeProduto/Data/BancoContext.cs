using ControleDeProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeProduto.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
