using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Entidades
{
    public class Vehiculo
    {
        [Key]
        public string Placa_Vehiculo { get; set; }
        public string Dueño_Vehiculo { get; set; }
        public string Unidad_Vehiculo { get; set; }
        public string Responsable_Vehiculo { get; set; }
        public string Modelo_Vehiculo { get; set; }
        public string Fecha_Vehiculo { get; set; }
        public string Kilometraje_Vehiculo { get; set; }
        public string Entrega_Vehiculo { get; set; }
        public string Garantia_Vehiculo { get; set; }
        public string MotorGarantia_Vehiculo { get; set; }
        public ICollection<Mantenimiento> manteniminetos { get; set; }
        public ICollection<Producto> productos { get; set; }
        public ICollection<Total> totals { get; set; }
    }
}
