namespace _2012142670_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministradorEquipoes",
                c => new
                    {
                        AdministradorEquipoId = c.Int(nullable: false, identity: true),
                        MarcaEquipo = c.String(),
                        Cantidad = c.Int(nullable: false),
                        EquipoCelular_EquipoCelularId = c.Int(),
                    })
                .PrimaryKey(t => t.AdministradorEquipoId)
                .ForeignKey("dbo.EquipoCelulars", t => t.EquipoCelular_EquipoCelularId)
                .Index(t => t.EquipoCelular_EquipoCelularId);
            
            CreateTable(
                "dbo.EquipoCelulars",
                c => new
                    {
                        EquipoCelularId = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.EquipoCelularId);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        TrabajadorId = c.Int(nullable: false),
                        EstadoEvaluacion = c.Byte(nullable: false),
                        TipoEvaluacion = c.Byte(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                        CentroAtencionId = c.Int(nullable: false),
                        LineaTelefonicaId = c.Int(nullable: false),
                        EquipoCelularId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluacionId)
                .ForeignKey("dbo.CentroAtencions", t => t.CentroAtencionId, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.EquipoCelulars", t => t.EquipoCelularId, cascadeDelete: true)
                .ForeignKey("dbo.LineaTelefonicas", t => t.LineaTelefonicaId, cascadeDelete: true)
                .ForeignKey("dbo.Plans", t => t.PlanId, cascadeDelete: true)
                .ForeignKey("dbo.Trabajadors", t => t.TrabajadorId, cascadeDelete: true)
                .Index(t => t.TrabajadorId)
                .Index(t => t.ClienteId)
                .Index(t => t.PlanId)
                .Index(t => t.CentroAtencionId)
                .Index(t => t.LineaTelefonicaId)
                .Index(t => t.EquipoCelularId);
            
            CreateTable(
                "dbo.CentroAtencions",
                c => new
                    {
                        CentroAtencionId = c.Int(nullable: false, identity: true),
                        NombreCentroAtencion = c.String(),
                        Direccion = c.String(),
                        Telefono = c.Int(nullable: false),
                        UbigeoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CentroAtencionId)
                .ForeignKey("dbo.Ubigeos", t => t.UbigeoId, cascadeDelete: true)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        DistritoId = c.Int(nullable: false),
                        Direccion_DireccionId = c.Int(),
                    })
                .PrimaryKey(t => t.UbigeoId)
                .ForeignKey("dbo.Distritoes", t => t.DistritoId, cascadeDelete: true)
                .ForeignKey("dbo.Direccions", t => t.Direccion_DireccionId)
                .Index(t => t.DistritoId)
                .Index(t => t.Direccion_DireccionId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                        nomDistrito = c.String(),
                        ProvinciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistritoId)
                .ForeignKey("dbo.Provincias", t => t.ProvinciaId, cascadeDelete: true)
                .Index(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        nomProvincia = c.String(),
                        DepartamentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinciaId)
                .ForeignKey("dbo.Departamentoes", t => t.DepartamentoId, cascadeDelete: true)
                .Index(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        departamento = c.String(),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DNI = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.LineaTelefonicas",
                c => new
                    {
                        LineaTelefonicaId = c.Int(nullable: false, identity: true),
                        NumeroLinea = c.Int(nullable: false),
                        TipoLinea = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.LineaTelefonicaId);
            
            CreateTable(
                "dbo.AdministradorLineas",
                c => new
                    {
                        AdministradorLineaId = c.Int(nullable: false, identity: true),
                        NombreLinea = c.String(),
                        LineasTelefonica_LineaTelefonicaId = c.Int(),
                    })
                .PrimaryKey(t => t.AdministradorLineaId)
                .ForeignKey("dbo.LineaTelefonicas", t => t.LineasTelefonica_LineaTelefonicaId)
                .Index(t => t.LineasTelefonica_LineaTelefonicaId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        NombrePlan = c.String(),
                        TipoPlan = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.PlanId);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        TrabajadorId = c.Int(nullable: false, identity: true),
                        NombreTrabajador = c.String(),
                        TipoTrabajador = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.TrabajadorId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        Precio = c.Int(nullable: false),
                        TipoPago = c.Byte(nullable: false),
                        EvaluacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.Evaluacions", t => t.EvaluacionId, cascadeDelete: true)
                .Index(t => t.EvaluacionId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                        FechaContrato = c.DateTime(nullable: false),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContratoId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        nombredireccion = c.String(),
                        CentroAtencion_CentroAtencionId = c.Int(),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("dbo.CentroAtencions", t => t.CentroAtencion_CentroAtencionId)
                .Index(t => t.CentroAtencion_CentroAtencionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ubigeos", "Direccion_DireccionId", "dbo.Direccions");
            DropForeignKey("dbo.Direccions", "CentroAtencion_CentroAtencionId", "dbo.CentroAtencions");
            DropForeignKey("dbo.Ventas", "EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.Contratoes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Evaluacions", "TrabajadorId", "dbo.Trabajadors");
            DropForeignKey("dbo.Evaluacions", "PlanId", "dbo.Plans");
            DropForeignKey("dbo.Evaluacions", "LineaTelefonicaId", "dbo.LineaTelefonicas");
            DropForeignKey("dbo.AdministradorLineas", "LineasTelefonica_LineaTelefonicaId", "dbo.LineaTelefonicas");
            DropForeignKey("dbo.Evaluacions", "EquipoCelularId", "dbo.EquipoCelulars");
            DropForeignKey("dbo.Evaluacions", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Evaluacions", "CentroAtencionId", "dbo.CentroAtencions");
            DropForeignKey("dbo.CentroAtencions", "UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Ubigeos", "DistritoId", "dbo.Distritoes");
            DropForeignKey("dbo.Distritoes", "ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.Provincias", "DepartamentoId", "dbo.Departamentoes");
            DropForeignKey("dbo.AdministradorEquipoes", "EquipoCelular_EquipoCelularId", "dbo.EquipoCelulars");
            DropIndex("dbo.Direccions", new[] { "CentroAtencion_CentroAtencionId" });
            DropIndex("dbo.Contratoes", new[] { "VentaId" });
            DropIndex("dbo.Ventas", new[] { "EvaluacionId" });
            DropIndex("dbo.AdministradorLineas", new[] { "LineasTelefonica_LineaTelefonicaId" });
            DropIndex("dbo.Provincias", new[] { "DepartamentoId" });
            DropIndex("dbo.Distritoes", new[] { "ProvinciaId" });
            DropIndex("dbo.Ubigeos", new[] { "Direccion_DireccionId" });
            DropIndex("dbo.Ubigeos", new[] { "DistritoId" });
            DropIndex("dbo.CentroAtencions", new[] { "UbigeoId" });
            DropIndex("dbo.Evaluacions", new[] { "EquipoCelularId" });
            DropIndex("dbo.Evaluacions", new[] { "LineaTelefonicaId" });
            DropIndex("dbo.Evaluacions", new[] { "CentroAtencionId" });
            DropIndex("dbo.Evaluacions", new[] { "PlanId" });
            DropIndex("dbo.Evaluacions", new[] { "ClienteId" });
            DropIndex("dbo.Evaluacions", new[] { "TrabajadorId" });
            DropIndex("dbo.AdministradorEquipoes", new[] { "EquipoCelular_EquipoCelularId" });
            DropTable("dbo.Direccions");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Trabajadors");
            DropTable("dbo.Plans");
            DropTable("dbo.AdministradorLineas");
            DropTable("dbo.LineaTelefonicas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Provincias");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Ubigeos");
            DropTable("dbo.CentroAtencions");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.EquipoCelulars");
            DropTable("dbo.AdministradorEquipoes");
        }
    }
}
