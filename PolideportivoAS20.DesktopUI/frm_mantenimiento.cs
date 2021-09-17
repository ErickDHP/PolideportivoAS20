using PolideportivoAS20.Core.Entidades;
using PolideportivoAS20.Infraestructura.ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolideportivoAS20.DesktopUI
{
    public partial class frm_mantenimiento : Form
    {
        private double subtotal;
        private double igv;
        private double CostoProducto;
        private double total;
        public bool estado;
        private UsuarioRN usuarioRN;
        SqlConnection con = new SqlConnection(@"Data Source=.;initial catalog=LermoChoy_Operaciones ;Integrated Security=true;");
        public string buscar;
        public frm_mantenimiento()
        {
            InitializeComponent();
            cargar_datos();
        }

        public void cargar_datos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id_Mantenimiento, Nombre_Mantenimiento FROM Mantenimiento", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre_Mantenimiento"] = "SELECCIONE UNA OPCION";
            dt.Rows.InsertAt(fila, 0);

            cbx_Mantenimiento.ValueMember = "id_Mantenimiento";
            cbx_Mantenimiento.DisplayMember = "Nombre_Mantenimiento";
            cbx_Mantenimiento.DataSource = dt;
        }

        public void cargar_sistema(string id_mnt)
        {
            con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Sistema WHERE id_Mantenimiento = @id_mnt", con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sistema WHERE id_mnt = @id_mnt", con);
            cmd.Parameters.AddWithValue("id_mnt", id_mnt);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            DataRow dr = dt.NewRow();
            dr["Nombre_Sistema"] = "SELECCIONE UNA OPCION";
            dt.Rows.InsertAt(dr, 0);

            cbx_Sistema.ValueMember = "id_Sistema";
            cbx_Sistema.DisplayMember = "Nombre_Sistema";
            cbx_Sistema.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_mantenimiento_Load(object sender, EventArgs e)
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
                if (!buscar.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa_Vehiculo.Equals(buscar.Trim()));
                    placa.Text = buscar;
                }
            }
        }

        public void precio()
        {
            subtotal = int.Parse(tbxsubtotal.Text);
            igv = subtotal * 0.18;
            total = subtotal + igv;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            precio();
            tbxigv.Text = "" + igv;
            txbtotal.Text = "" + total;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            #region Bloque que valida los objetos de entrada
            if (string.IsNullOrEmpty(cbx_Mantenimiento.Text) || string.IsNullOrEmpty(cbx_Sistema.Text) || string.IsNullOrEmpty(txbDescripcion.Text) ||
                string.IsNullOrEmpty(tbxsubtotal.Text) || string.IsNullOrEmpty(tbxigv.Text) || string.IsNullOrEmpty(txbtotal.Text))
            {
                panel1.BackColor = Color.FromArgb(219, 81, 69);
                MessageBox.Show("Completa los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(panel1, "Completa los Datos");
                return;
            }
            else
            {
                errorProvider1.SetError(panel1, string.Empty);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }
            #endregion

            {
                usuarioRN = new UsuarioRN();
                Mantenimiento mantenimineto1 = new Mantenimiento
                {

                    Placa = placa.Text,
                    Mantenimiento_tipo = cbx_Mantenimiento.Text,
                    Mantenimiento_especificacion = cbx_Sistema.Text,
                    Mantenimiento_descripcion = txbDescripcion.Text,
                    Mantenimiento_subtotal = subtotal,
                    Mantenimiento_igv = igv,
                    Mantenimiento_total = total,
                };
                usuarioRN.AgregarMantenimiento(mantenimineto1);
                MessageBox.Show("Datos Guardados");
            }

            {
                usuarioRN = new UsuarioRN();
                Total totalrn = new Total
                {
                    total_placa = placa.Text,
                    total_matenimiento = total, 
                };
                usuarioRN.AgregarTotal(totalrn);
            }
        }

        private void cbx_Mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Mantenimiento.SelectedIndex.ToString() != null)
            {
                string id_departamento = cbx_Mantenimiento.SelectedValue.ToString();
                cargar_sistema(id_departamento);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txbProducto.Clear();
            costoProd.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CostoProducto = int.Parse(costoProd.Text);
            #region Bloque que valida los objetos de entrada
            if (string.IsNullOrEmpty(txbProducto.Text) || string.IsNullOrEmpty(costoProd.Text))
            {
                panel1.BackColor = Color.FromArgb(219, 81, 69);
                MessageBox.Show("Completa los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(panel1, "Completa los Datos");
                return;
            }
            else
            {
                errorProvider1.SetError(panel1, string.Empty);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
            }
            #endregion

            {
                usuarioRN = new UsuarioRN();
                Producto producto = new Producto
                {
                    Vehiculo_id = placa.Text,
                    Nombre_producto = txbProducto.Text,
                    Precio_producto = CostoProducto
                };
                usuarioRN.AgregarProducto(producto);
                MessageBox.Show("Datos Guardados");
            }

            {
                usuarioRN = new UsuarioRN();
                Total totalrn = new Total
                {
                    total_placa = placa.Text,
                    total_producto = CostoProducto,
                };
                usuarioRN.AgregarTotal(totalrn);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbDescripcion.Clear();
            tbxsubtotal.Clear();
            tbxigv.Clear();
            txbtotal.Clear();
        }
    }
}
