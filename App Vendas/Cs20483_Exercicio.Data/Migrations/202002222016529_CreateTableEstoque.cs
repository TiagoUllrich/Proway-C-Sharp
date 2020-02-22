namespace Cs20483_Exercicio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableEstoque : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Short(nullable: false),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .Index(t => t.Produto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoques", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.Estoques", new[] { "Produto_Id" });
            DropTable("dbo.Estoques");
        }
    }
}
