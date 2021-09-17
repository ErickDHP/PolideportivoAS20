using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Entidades
{
    public class oReporteTotal
    {
        public int Total_id { get; set; }
        public string total_placa { get; set; }
        public double total_matenimiento { get; set; }
        public double total_producto { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
