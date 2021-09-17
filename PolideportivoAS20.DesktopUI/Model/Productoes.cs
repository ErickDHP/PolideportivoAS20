namespace PolideportivoAS20.DesktopUI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productoes
    {
        public int id { get; set; }

        public string Vehiculo_id { get; set; }

        public string Nombre_producto { get; set; }

        public double Precio_producto { get; set; }

        [StringLength(128)]
        public string Vehiculo_Placa_Vehiculo { get; set; }

        public virtual Vehiculoes Vehiculoes { get; set; }
    }
}
