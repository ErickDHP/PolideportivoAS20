using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Entidades
{
    public class Proforma
    {
        [Key]
        public int id_proforma { get; set; }
        public string veiculo_placa { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }

}

