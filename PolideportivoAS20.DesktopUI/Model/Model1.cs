using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PolideportivoAS20.DesktopUI.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Mantenimientoes> Mantenimientoes { get; set; }
        public virtual DbSet<Productoes> Productoes { get; set; }
        public virtual DbSet<Proformas> Proformas { get; set; }
        public virtual DbSet<Totals> Totals { get; set; }
        public virtual DbSet<Vehiculoes> Vehiculoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculoes>()
                .HasMany(e => e.Mantenimientoes)
                .WithOptional(e => e.Vehiculoes)
                .HasForeignKey(e => e.Vehiculo_Placa_Vehiculo);

            modelBuilder.Entity<Vehiculoes>()
                .HasMany(e => e.Productoes)
                .WithOptional(e => e.Vehiculoes)
                .HasForeignKey(e => e.Vehiculo_Placa_Vehiculo);

            modelBuilder.Entity<Vehiculoes>()
                .HasMany(e => e.Proformas)
                .WithOptional(e => e.Vehiculoes)
                .HasForeignKey(e => e.Vehiculo_Placa_Vehiculo);

            modelBuilder.Entity<Vehiculoes>()
                .HasMany(e => e.Totals)
                .WithOptional(e => e.Vehiculoes)
                .HasForeignKey(e => e.Vehiculo_Placa_Vehiculo);
        }
    }
}
