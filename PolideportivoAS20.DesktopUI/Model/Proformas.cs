namespace PolideportivoAS20.DesktopUI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proformas
    {
        [Key]
        public int id_proforma { get; set; }

        public string veiculo_placa { get; set; }

        [StringLength(128)]
        public string Vehiculo_Placa_Vehiculo { get; set; }

        public virtual Vehiculoes Vehiculoes { get; set; }
    }
}
