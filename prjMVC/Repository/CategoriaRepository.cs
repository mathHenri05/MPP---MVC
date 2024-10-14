using prjMVC.Context;
using prjMVC.Models;
using prjMVC.Repository.Interfaces;

namespace prjMVC.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext varcontext;
        public CategoriaRepository(AppDbContext context)
        {
            varcontext = context;
        }
        public IEnumerable<Categoria> Categorias => varcontext.Categorias;
    }
}
