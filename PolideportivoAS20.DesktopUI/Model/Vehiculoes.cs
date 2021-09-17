namespace PolideportivoAS20.DesktopUI.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehiculoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculoes()
        {
            Mantenimientoes = new HashSet<Mantenimientoes>();
            Productoes = new HashSet<Productoes>();
            Proformas = new HashSet<Proformas>();
            Totals = new HashSet<Totals>();
        }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mantenimientoes> Mantenimientoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productoes> Productoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proformas> Proformas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Totals> Totals { get; set; }
    }
}
