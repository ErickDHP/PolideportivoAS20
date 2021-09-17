using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAS20.DesktopUI
{
    public partial class frm_reporte_placa : Form
    {
        public string buscar;
        public frm_reporte_placa()
        {
            InitializeComponent();
        }

        private void frm_reporte_placa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            /*using (Model.Model1 db = new Model.Model1())
            {
                var lst = (from d in db.Vehiculoes
                           select new Model.ViewModel.vehiculo
                           {
                               Dueño_Vehiculo = d.Dueño_Vehiculo,
                               Unidad_Vehiculo = d.Unidad_Vehiculo,
                               Placa_Vehiculo = d.Placa_Vehiculo,
                               Responsable_Vehiculo = d.Responsable_Vehiculo,
                               Modelo_Vehiculo = d.Modelo_Vehiculo,
                               Fecha_Vehiculo = d.Fecha_Vehiculo,
                               Kilometraje_Vehiculo = d.Kilometraje_Vehiculo,
                               Entrega_Vehiculo = d.Entrega_Vehiculo,
                               Garantia_Vehiculo = d.Garantia_Vehiculo,
                               MotorGarantia_Vehiculo = d.MotorGarantia_Vehiculo,

                           }).AsQueryable();
                if (!buscar.Equals(""))
                {
                    lst = lst.Where(d => d.Placa_Vehiculo.Contains(buscar));
                }
                oReporteVehiculoBindingSource.DataSource = lst.ToList();
            }

            using (Model.Model1 db = new Model.Model1())
            {
                var lst = (from d in db.Mantenimientoes
                           select new Model.ViewModel.Matenimiento
                           {
                               Mantenimiento_descripcion = d.Mantenimiento_descripcion,
                               Mantenimiento_especificacion = d.Mantenimiento_especificacion,
                               Mantenimiento_tipo = d.Mantenimiento_tipo,
                               Mantenimiento_igv = d.Mantenimiento_igv,
                               Mantenimiento_subtotal = d.Mantenimiento_subtotal,
                               Mantenimiento_total = d.Mantenimiento_total,
                               Placa_Vehiculo = d.Placa_Vehiculo,
                               Placa = d.Placa,
                               Mantenimiento_producto = d.Mantenimiento_producto,
                               Mantenimiento_costo = d.Mantenimiento_costo
                           }).AsQueryable();
                if (!buscar.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa.Contains(buscar));
                }
                oReporteMantenimientoBindingSource.DataSource = lst.ToList();
            }
            reportViewer1.RefreshReport();


            using (Model.Model1 db = new Model.Model1())
            {
                var lst = (from d in db.Productoes
                           select new Model.ViewModel.Producto
                           {
                               Nombre_producto = d.Nombre_producto,
                               Precio_producto = d.Precio_producto,
                               Vehiculo_id = d.Vehiculo_id
                           }).AsQueryable();
                if (!buscar.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Vehiculo_id.Contains(buscar));
                }
                oReporteProductoBindingSource.DataSource = lst.ToList();
            }
            this.reportViewer1.RefreshReport();

            using (Model.Model1 db = new Model.Model1())
            {
                var lst = (from d in db.Totals
                           select new Model.ViewModel.Total
                           {
                               total_producto = d.total_producto,
                               total_matenimiento = d.total_matenimiento,
                               total_placa = d.total_placa
                           }).AsQueryable();
                if (!buscar.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.total_placa.Contains(buscar));
                }
                oReporteProductoBindingSource.DataSource = lst.ToList();
            }
            this.reportViewer1.RefreshReport();*/
        }
    }
}
