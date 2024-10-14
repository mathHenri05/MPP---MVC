using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prjMVC.Migrations
{
    public partial class AddProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Fusca', 'Carro compacto clássico', 'O Volkswagen Fusca é um ícone dos carros compactos com design único e motor traseiro.', 20000, 'https://example.com/fusca.jpg', 'https://example.com/fusca_thumb.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Civic', 'Sedan confiável', 'O Honda Civic é conhecido por sua durabilidade e eficiência de combustível, ideal para o uso diário.', 30000, 'https://example.com/civic.jpg', 'https://example.com/civic_thumb.jpg', 1, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Mustang', 'Esportivo americano', 'O Ford Mustang é um carro esportivo com um motor potente e design agressivo.', 50000, 'https://example.com/mustang.jpg', 'https://example.com/mustang_thumb.jpg', 1, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Camaro', 'Muscle car moderno', 'O Chevrolet Camaro combina estilo moderno com desempenho excepcional, ideal para entusiastas.', 55000, 'https://example.com/camaro.jpg', 'https://example.com/camaro_thumb.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Corolla', 'Sedan econômico', 'O Toyota Corolla é um carro confiável e econômico, ideal para quem busca eficiência e conforto.', 25000, 'https://example.com/corolla.jpg', 'https://example.com/corolla_thumb.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('A4', 'Sedan de luxo', 'O Audi A4 oferece um equilíbrio perfeito entre desempenho e conforto, com um interior luxuoso e tecnologia avançada.', 45000, 'https://example.com/a4.jpg', 'https://example.com/a4_thumb.jpg', 1, 0, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('X5', 'SUV premium', 'O BMW X5 combina capacidade off-road com conforto e luxo, sendo ideal para aventuras e viagens.', 65000, 'https://example.com/x5.jpg', 'https://example.com/x5_thumb.jpg', 0, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Prius', 'Híbrido econômico', 'O Toyota Prius é um carro híbrido que oferece excelente economia de combustível e um design futurista.', 28000, 'https://example.com/prius.jpg', 'https://example.com/prius_thumb.jpg', 0, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Wrangler', 'SUV robusto', 'O Jeep Wrangler é famoso por sua robustez e capacidade off-road, ideal para quem adora aventuras ao ar livre.', 40000, 'https://example.com/wrangler.jpg', 'https://example.com/wrangler_thumb.jpg', 0, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
            "VALUES ('Chiron', 'Supercarro de luxo', 'O Bugatti Chiron é um supercarro com desempenho incomparável e um design sofisticado, representando o auge da engenharia automotiva.', 3000000, 'https://example.com/chiron.jpg', 'https://example.com/chiron_thumb.jpg', 1, 0, 1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
