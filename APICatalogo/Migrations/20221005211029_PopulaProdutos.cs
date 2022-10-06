using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations {
    public partial class PopulaProdutos : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.Sql("insert into produtos(" +
              "Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
              "values('Coca-cola', 'Refrigerante de cola 350ml', '5.45', 'cocacola.jpg', '50', now(), 1)");
            migrationBuilder.Sql("insert into produtos(" +
              "Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
              "values('Misto quente', 'Pão com queijo e presunto assado na chapa.', '4.00', 'mistoquente.jpg', '13', now(), 2)");
            migrationBuilder.Sql("insert into produtos(" +
              "Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
              "values('Sundae', 'Copo com 300ml, sabor balniha com calda de chocolate.', '3.50', 'sundae.jpg', '05', now(), 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.Sql("delete from produtos");
        }
    }
}
