using PolideportivoAS20.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Infraestructura.Contexto
{
    class Contexto_PolideportivoAS20_BD : DbContext
    {
        public Contexto_PolideportivoAS20_BD() : base("name=Contexto_PolideportivoAS20_BD_Con") { }
        public DbSet<Vehiculo> vehiculo { get; set; }
        public DbSet<Mantenimiento> manteniminetos { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Total> totals { get; set; }
        public DbSet<Proforma> proformas { get; set; }
    }
}
