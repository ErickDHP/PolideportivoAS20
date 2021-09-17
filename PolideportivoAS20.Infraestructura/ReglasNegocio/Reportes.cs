using PolideportivoAS20.Core.Entidades;
using PolideportivoAS20.Core.Repositorios;
using PolideportivoAS20.Infraestructura.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolideportivoAS20.Infraestructura.ReglasNegocio
{
    public class Reportes : IReportes
    {
        Contexto_PolideportivoAS20_BD contexto;
        public IQueryable<oReporteVehiculo> oReporteVehiculos()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.vehiculo.Select(u => new oReporteVehiculo()
            {
                Dueño_Vehiculo = u.Dueño_Vehiculo,
                Unidad_Vehiculo = u.Unidad_Vehiculo,
                Placa_Vehiculo = u.Placa_Vehiculo,
                Responsable_Vehiculo = u.Responsable_Vehiculo,
                Modelo_Vehiculo = u.Modelo_Vehiculo,
                Fecha_Vehiculo = u.Fecha_Vehiculo,
                Kilometraje_Vehiculo = u.Kilometraje_Vehiculo,
                Entrega_Vehiculo = u.Entrega_Vehiculo,
                Garantia_Vehiculo = u.Garantia_Vehiculo,
                MotorGarantia_Vehiculo = u.MotorGarantia_Vehiculo
            }).AsQueryable<oReporteVehiculo>();
        }

        IQueryable<oReporteMantenimiento> IReportes.oReporteMantenimiento()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.manteniminetos.Select(u => new oReporteMantenimiento()
            {
                Placa_Vehiculo = u.Placa_Vehiculo,
                Placa = u.Placa,
                Mantenimiento_tipo = u.Mantenimiento_tipo,
                Mantenimiento_descripcion = u.Mantenimiento_descripcion,
                Mantenimiento_especificacion = u.Mantenimiento_especificacion,
                Mantenimiento_igv = u.Mantenimiento_igv,
                Mantenimiento_subtotal = u.Mantenimiento_subtotal,
                Mantenimiento_total = u.Mantenimiento_total
            }).AsQueryable<oReporteMantenimiento>();
        }

        IQueryable<oReporteProducto> IReportes.oReporteProductos()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.productos.Select(u => new oReporteProducto()
            {
                id = u.id,
                Nombre_producto = u.Nombre_producto,
                Precio_producto = u.Precio_producto,
                Vehiculo_id = u.Vehiculo_id
            }).AsQueryable<oReporteProducto>();
        }

        IQueryable<oReporteTotal> IReportes.oReporteTotals()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.totals.Select(u => new oReporteTotal()
            {
                Total_id = u.Total_id,
                total_placa = u.total_placa,
                total_matenimiento = u.total_matenimiento,
                total_producto = u.total_producto
            }).AsQueryable<oReporteTotal>();
        }

        IQueryable<oReporteProforma> IReportes.oReporteProforma()
        {
            contexto = new Contexto_PolideportivoAS20_BD();
            return contexto.proformas.Select(u => new oReporteProforma()
            {
                id_proforma = u.id_proforma,
                veiculo_placa = u.veiculo_placa
            }).AsQueryable<oReporteProforma>();
        }
    }
}
