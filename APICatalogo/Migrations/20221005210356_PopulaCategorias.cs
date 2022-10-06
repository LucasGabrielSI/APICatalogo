using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categorias(Nome, ImagemUrl) values('Bebida', 'bebidas.jpg')");
            migrationBuilder.Sql("insert into categorias(Nome, ImagemUrl) values('Lanches', 'lanches.jpg')");
            migrationBuilder.Sql("insert into categorias(Nome, ImagemUrl) values('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from categorias");
        }
    }
}
