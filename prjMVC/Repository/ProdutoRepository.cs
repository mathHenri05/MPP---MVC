using Microsoft.EntityFrameworkCore;
using prjMVC.Context;
using prjMVC.Models;
using prjMVC.Repository.Interfaces;
namespace prjMVC.Repository

{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext varcontext;
        public ProdutoRepository(AppDbContext contexto)
        {
            varcontext = contexto;
        }
        public IEnumerable<Produto> Produtos => varcontext.Produtos.Include(c =>
        c.Categoria);
        public IEnumerable<Produto> ProdutosPreferidos => varcontext.Produtos.
         Where(l => l.IsLanchePreferido)
         .Include(c => c.Categoria);
        public Produto GetProdutoById(int ProdutoId)
        {
            return varcontext.Produtos.FirstOrDefault(l => l.ProdutoId ==
            ProdutoId);
        }
    }
}
