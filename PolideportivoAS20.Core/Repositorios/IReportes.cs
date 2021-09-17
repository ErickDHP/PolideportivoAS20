using PolideportivoAS20.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Core.Repositorios
{
    public interface IReportes 
    {
        IQueryable<oReporteVehiculo> oReporteVehiculos();
        IQueryable<oReporteMantenimiento> oReporteMantenimiento();
        IQueryable<oReporteProducto> oReporteProductos();
        IQueryable<oReporteTotal> oReporteTotals();
        IQueryable<oReporteProforma> oReporteProforma();
    }
}
