namespace PolideportivoAS20.DesktopUI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mantenimientoes
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

        [StringLength(128)]
        public string Vehiculo_Placa_Vehiculo { get; set; }

        public virtual Vehiculoes Vehiculoes { get; set; }
    }
}
