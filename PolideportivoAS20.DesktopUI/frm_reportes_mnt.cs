using PolideportivoAS20.Infraestructura.ReglasNegocio;
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
    public partial class frm_reportes_mnt : Form
    {
        Reportes reportes;
        public string buscarvariable;
        public frm_reportes_mnt()
        {
            InitializeComponent();
        }

        private void buscaporplaca()
        {
            using (Model.Model1 db = new Model.Model1())
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
                if (!Placa.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa_Vehiculo.Contains(Placa.Text.Trim()));
                    buscarvariable = Placa.Text;
                }
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
                               Placa = d.Placa
                           }).AsQueryable();
                if (!Placa.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa.Contains(Placa.Text.Trim()));
                    buscarvariable = Placa.Text;
                }
            }

            using (Model.Model1 db = new Model.Model1())
            {
                var lst = (from d in db.Productoes
                           select new Model.ViewModel.Producto
                           {
                               id = d.id,
                               Nombre_producto = d.Nombre_producto,
                               Precio_producto = d.Precio_producto,
                               Vehiculo_id = d.Vehiculo_id
                           }).AsQueryable();

                if (!Placa.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Vehiculo_id.Contains(Placa.Text.Trim()));
                    buscarvariable = Placa.Text;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Placa.Text))
            {
                Placa.BackColor = Color.FromArgb(219, 81, 69);
                MessageBox.Show("Completa los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(Placa, "Completa los Datos");
                return;
            }
            else
            {
                using (Model.Model1 db = new Model.Model1())
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
                    if (!Placa.Text.Trim().Equals(""))
                    {
                        lst = lst.Where(d => d.Placa_Vehiculo.Contains(Placa.Text.Trim()));
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
                    if (!Placa.Text.Trim().Equals(""))
                    {
                        lst = lst.Where(d => d.Placa.Contains(Placa.Text.Trim()));
                    }
                    oReporteMantenimientoBindingSource.DataSource = lst.ToList();
                }

                using (Model.Model1 db = new Model.Model1())
                {
                    var lst = (from d in db.Productoes
                               select new Model.ViewModel.Producto
                               {
                                   Nombre_producto = d.Nombre_producto,
                                   Precio_producto = d.Precio_producto,
                                   Vehiculo_id = d.Vehiculo_id
                               }).AsQueryable();
                    if (!Placa.Text.Trim().Equals(""))
                    {
                        lst = lst.Where(d => d.Vehiculo_id.Contains(Placa.Text.Trim()));
                    }
                    oReporteProductoBindingSource.DataSource = lst.ToList();
                }
                reportViewer1.RefreshReport();

                using (Model.Model1 db = new Model.Model1())
                {
                    var lst = (from d in db.Totals
                               select new Model.ViewModel.Total
                               {
                                   total_producto = d.total_producto,
                                   total_matenimiento = d.total_matenimiento,
                                   total_placa = d.total_placa
                               }).AsQueryable();
                    if (!Placa.Text.Trim().Equals(""))
                    {
                        lst = lst.Where(d => d.total_placa.Contains(Placa.Text.Trim()));
                    }
                    oReporteTotalBindingSource.DataSource = lst.ToList();
                }

                using (Model.Model1 db = new Model.Model1())
                {
                    var lst = (from d in db.Proformas
                               select new Model.ViewModel.Proforma
                               {
                                   id_proforma = d.id_proforma,
                                   veiculo_placa = d.veiculo_placa
                               }).AsQueryable();
                    if (!Placa.Text.Trim().Equals(""))
                    {
                        lst = lst.Where(d => d.veiculo_placa.Contains(Placa.Text.Trim()));
                    }
                    oReporteProformaBindingSource.DataSource = lst.ToList();
                }
                reportViewer1.RefreshReport();
            }
        }

        private void frm_reportes_mnt_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }

}

