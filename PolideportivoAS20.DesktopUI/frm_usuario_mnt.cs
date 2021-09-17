using PolideportivoAS20.Core.Entidades;
using PolideportivoAS20.Infraestructura.ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PolideportivoAS20.DesktopUI
{

    public partial class frm_usuario_mnt : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;initial catalog=ubigeos;Integrated Security=true;");
        private BindingSource bindingSource_usuario = new BindingSource();
        private UsuarioRN usuarioRN;
        private string buscarvariable;
        public bool estado;
        public string posicion;
        private int id;
        public frm_usuario_mnt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            #region Bloque que valida los objetos de entrada
            if (string.IsNullOrEmpty(vh_dueño.Text) || string.IsNullOrEmpty(vh_unidad.Text) || string.IsNullOrEmpty(vh_placa.Text)
                || string.IsNullOrEmpty(vh_respon.Text) || string.IsNullOrEmpty(vh_modelo.Text) || string.IsNullOrEmpty(vh_kilometraje.Text)
                || string.IsNullOrEmpty(vh_entrega.Text) || string.IsNullOrEmpty(vh_garantia.Text)
                )
            {
                panel2.BackColor = Color.FromArgb(219, 81, 69);
                MessageBox.Show("Completa los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(panel2, "Completa los Datos");
                return;
            }
            else
            {
                errorProvider1.SetError(panel2, string.Empty);
                panel2.BackColor = Color.FromArgb(255, 255, 255);
            }
            #endregion

            #region Haciendo datos persistentes en el contexto (BD)
            if (estado)
            {
                usuarioRN = new UsuarioRN();
                Vehiculo usuario = new Vehiculo
                {
                    Dueño_Vehiculo = vh_dueño.Text,
                    Unidad_Vehiculo = vh_unidad.Text,
                    Placa_Vehiculo = vh_placa.Text,
                    Responsable_Vehiculo = vh_respon.Text,
                    Modelo_Vehiculo = vh_modelo.Text,
                    Kilometraje_Vehiculo = vh_kilometraje.Text,
                    Entrega_Vehiculo = vh_entrega.Text,
                    Garantia_Vehiculo = vh_garantia.Text,
                    MotorGarantia_Vehiculo = vh_MotorGarantia.Text,
                    Fecha_Vehiculo = DateTime.Now.ToShortDateString(),
                };
                usuarioRN.AgregarUsuario(usuario);

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Desea agregar mantenimiento?", "Agregar", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    frm_mantenimiento impre = new frm_mantenimiento();
                    impre.buscar = vh_placa.Text;
                    impre.ShowDialog();
                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("Datos Guardados");
                }

            }
            else
            {
                Vehiculo usuario = usuarioRN.BuscarUsuario(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                usuario.Dueño_Vehiculo = vh_dueño.Text;
                usuario.Unidad_Vehiculo = vh_unidad.Text;
                usuario.Placa_Vehiculo = vh_placa.Text;
                usuario.Placa_Vehiculo = vh_placa.Text;
                usuario.Responsable_Vehiculo = vh_respon.Text;
                usuario.Modelo_Vehiculo = vh_modelo.Text;
                usuario.Kilometraje_Vehiculo = vh_kilometraje.Text;
                usuario.Garantia_Vehiculo = vh_garantia.Text;

                usuarioRN.ModificarUsuario(usuario);
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("¿Desea agregar mantenimiento?", "Agregar", botones, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    frm_mantenimiento impre = new frm_mantenimiento();
                    impre.buscar = vh_placa.Text;
                    impre.ShowDialog();
                }
                else if (dr == DialogResult.No)
                {
                    MessageBox.Show("Datos actualizados con éxito...");
                }

            }

            {
                Proforma proforma = new Proforma
                {
                    veiculo_placa = vh_placa.Text
                };
                usuarioRN.AgregarProforma(proforma);
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estado = true;
            panel2.Enabled = true;
            vh_dueño.Focus();

            vh_dueño.ResetText();
            vh_unidad.Clear();
            vh_placa.Clear();
            vh_respon.Clear();
            vh_modelo.Clear();
            vh_kilometraje.Clear();
            vh_entrega.Clear();
            vh_garantia.Clear();
        }

        private void frm_reserva_mnt_Load(object sender, EventArgs e)
        {
            usuarioRN = new UsuarioRN();
            bindingSource_usuario.DataSource = usuarioRN.ListarUsuario();
            bindingNavigator1.BindingSource = bindingSource_usuario;

            dataGridView1.DataSource = bindingSource_usuario;
            dataGridView1.AutoResizeColumns();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_reserva_mnt_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    estado = false;
                    Vehiculo usuario = usuarioRN.BuscarUsuario(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    vh_dueño.Text = usuario.Dueño_Vehiculo;
                    vh_unidad.Text = usuario.Unidad_Vehiculo;
                    vh_placa.Text = usuario.Placa_Vehiculo;
                    vh_respon.Text = usuario.Responsable_Vehiculo;
                    vh_modelo.Text = usuario.Modelo_Vehiculo;
                    vh_kilometraje.Text = usuario.Kilometraje_Vehiculo;
                    vh_entrega.Text = usuario.Entrega_Vehiculo;
                    vh_garantia.Text = usuario.Garantia_Vehiculo;

                    tabControl1.SelectedTab = tabPage2;
                }
            }
        }

       
        private void toolStripButton2_Click(object sender, EventArgs e)
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
                if (!buscarplaca.Text.Trim().Equals(""))
                {
                    lst = lst.Where(d => d.Placa_Vehiculo.Contains(buscarplaca.Text.Trim()));
                    buscarvariable = buscarplaca.Text;
                }
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                estado = false;
                Vehiculo usuario = usuarioRN.BuscarUsuario(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                usuarioRN.EliminarUsuario(usuario);
                MessageBox.Show("Datos eliminados con Exito");

            }
            else
            {
                MessageBox.Show("No existen Datos Aún");
            }

        }

        private void buscarnombre_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

