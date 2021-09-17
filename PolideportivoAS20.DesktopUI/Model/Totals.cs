namespace PolideportivoAS20.DesktopUI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Totals
    {
        [Key]
        public int Total_id { get; set; }

        public string total_placa { get; set; }

        public double total_matenimiento { get; set; }

        public double total_producto { get; set; }

        [StringLength(128)]
        public string Vehiculo_Placa_Vehiculo { get; set; }

        public virtual Vehiculoes Vehiculoes { get; set; }
    }
}
