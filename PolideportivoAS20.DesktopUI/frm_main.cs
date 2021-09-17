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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            abrirformulariohijo(new frm_usuario_mnt());
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            abrirformulariohijo(new frm_usuario_mnt());
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            abrirformulariohijo(new frm_reportes_mnt());
            this.Cursor = Cursors.Default;
        }

        private void abrirformulariohijo(object forhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);

            Form fh = forhijo as Form;
            fh.TopLevel = false;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }
    }
}
