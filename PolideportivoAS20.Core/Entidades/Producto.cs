using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Entidades
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public string Vehiculo_id { get; set; }
        public string Nombre_producto { get; set; }
        public double Precio_producto { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
