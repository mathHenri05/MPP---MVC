using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prjMVC.Migrations
{
    public partial class AddCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(NomeCategoria, Descricao) " +
                "VALUES('Natural', 'Ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categoria(NomeCategoria, Descricao) " +
                "VALUES('Natural', 'Ingredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
