using prjMVC.Models;

namespace prjMVC.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutosPreferidos { get; }
        Produto GetProdutoById(int ProdutoId);
    }
}
