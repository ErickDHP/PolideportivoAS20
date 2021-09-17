using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Entidades
{
    public class oReporteMantenimiento
    {
        [Key]
        public int Placa_Vehiculo { get; set; }
        public string Placa { get; set; }
        public string Mantenimiento_tipo { get; set; }
        public string Mantenimiento_especificacion { get; set; }
        public string Mantenimiento_descripcion { get; set; }
        public string Mantenimiento_producto { get; set; }
        public double Mantenimiento_subtotal { get; set; }
        public double Mantenimiento_igv { get; set; }
        public double Mantenimiento_total { get; set; }
        public double Mantenimiento_costo { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
