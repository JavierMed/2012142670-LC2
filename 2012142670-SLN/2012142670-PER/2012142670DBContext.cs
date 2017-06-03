using _2012142670_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012142670_PER.EntityTypeConfiguration;

namespace _2012142670_PER
{
    public class _2012142670DBContext:DbContext
    {
        public DbSet<AdministradorEquipo> AdministradorEquipo { get; set; }
        public DbSet<EquipoCelular> EquipoCelular { get; set; }
        public DbSet<LineaTelefonica> LineaTelefonica { get; set; }
        public DbSet<AdministradorLinea> AdministradorLinea { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Ubigeo> Ubigeo { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<CentroAtencion> CentroAtencion { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Evaluacion> Evaluacion { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            #region AdministradorLineaConfiguration
            
            #endregion



            modelBuilder.Configurations.Add(new EquipoCelularConfiguration());
            modelBuilder.Configurations.Add(new LineaTelefonicaConfiguration());
            modelBuilder.Configurations.Add(new DistritoConfiguration());
            modelBuilder.Configurations.Add(new ProvinciaConfiguration());
            modelBuilder.Configurations.Add(new DepartamentoConfiguration());
            //modelBuilder.Configurations.Add(new UbigeoConfiguration());
            modelBuilder.Configurations.Add(new CentroAtencionConfiguration());
            modelBuilder.Configurations.Add(new ContratoConfiguration());
            modelBuilder.Configurations.Add(new VentaConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EvaluacionConfiguration());
            modelBuilder.Configurations.Add(new PlanConfiguration());
            modelBuilder.Configurations.Add(new TrabajadorConfiguration());



            base.OnModelCreating(modelBuilder);
        }

    }
}
