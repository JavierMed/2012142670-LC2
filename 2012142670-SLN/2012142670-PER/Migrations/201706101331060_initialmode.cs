namespace _2012142670_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Direccions", "CentroAtencion_CentroAtencionId", "dbo.CentroAtencions");
            DropForeignKey("dbo.Ubigeos", "Direccion_DireccionId", "dbo.Direccions");
            DropIndex("dbo.Ubigeos", new[] { "Direccion_DireccionId" });
            DropIndex("dbo.Direccions", new[] { "CentroAtencion_CentroAtencionId" });
            DropColumn("dbo.Ubigeos", "Direccion_DireccionId");
            DropTable("dbo.Direccions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        nombredireccion = c.String(),
                        CentroAtencion_CentroAtencionId = c.Int(),
                    })
                .PrimaryKey(t => t.DireccionId);
            
            AddColumn("dbo.Ubigeos", "Direccion_DireccionId", c => c.Int());
            CreateIndex("dbo.Direccions", "CentroAtencion_CentroAtencionId");
            CreateIndex("dbo.Ubigeos", "Direccion_DireccionId");
            AddForeignKey("dbo.Ubigeos", "Direccion_DireccionId", "dbo.Direccions", "DireccionId");
            AddForeignKey("dbo.Direccions", "CentroAtencion_CentroAtencionId", "dbo.CentroAtencions", "CentroAtencionId");
        }
    }
}
