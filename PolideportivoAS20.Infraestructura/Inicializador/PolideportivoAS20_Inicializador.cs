using PolideportivoAS20.Core.Entidades;
using PolideportivoAS20.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Infraestructura.Inicializador
{
    class PolideportivoAS20_Inicializador : DropCreateDatabaseAlways<Contexto_PolideportivoAS20_BD>
    {
        protected override void Seed(Contexto_PolideportivoAS20_BD context)
        {
            context.vehiculo.Add(new Vehiculo { Dueño_Vehiculo = "Nombre Usuario" });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
