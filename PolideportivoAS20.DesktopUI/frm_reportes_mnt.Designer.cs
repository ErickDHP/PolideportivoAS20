namespace PolideportivoAS20.DesktopUI
{
    partial class frm_reportes_mnt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reportes_mnt));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.oReporteMantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oReporteProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oReporteVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oReporteTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oReporteProformaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Placa = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteMantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteProformaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // oReporteMantenimientoBindingSource
            // 
            this.oReporteMantenimientoBindingSource.DataSource = typeof(PolideportivoAS20.Core.Entidades.oReporteMantenimiento);
            // 
            // oReporteProductoBindingSource
            // 
            this.oReporteProductoBindingSource.DataSource = typeof(PolideportivoAS20.Core.Entidades.oReporteProducto);
            // 
            // oReporteVehiculoBindingSource
            // 
            this.oReporteVehiculoBindingSource.DataSource = typeof(PolideportivoAS20.Core.Entidades.oReporteVehiculo);
            // 
            // oReporteTotalBindingSource
            // 
            this.oReporteTotalBindingSource.DataSource = typeof(PolideportivoAS20.Core.Entidades.oReporteTotal);
            // 
            // oReporteProformaBindingSource
            // 
            this.oReporteProformaBindingSource.DataSource = typeof(PolideportivoAS20.Core.Entidades.oReporteProforma);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 71);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Clientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Placa);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(1, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 71);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(67, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese la placa del vehículo";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(568, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar para Imprimir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Placa
            // 
            this.Placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Placa.Location = new System.Drawing.Point(300, 26);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(244, 20);
            this.Placa.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Mantenimiento";
            reportDataSource1.Value = this.oReporteMantenimientoBindingSource;
            reportDataSource2.Name = "Producto";
            reportDataSource2.Value = this.oReporteProductoBindingSource;
            reportDataSource3.Name = "Vehiculo";
            reportDataSource3.Value = this.oReporteVehiculoBindingSource;
            reportDataSource4.Name = "Totales";
            reportDataSource4.Value = this.oReporteTotalBindingSource;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.oReporteProformaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PolideportivoAS20.DesktopUI.ReportePlaca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(823, 365);
            this.reportViewer1.TabIndex = 8;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frm_reportes_mnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 522);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_reportes_mnt";
            this.Load += new System.EventHandler(this.frm_reportes_mnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oReporteMantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteProformaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Placa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource oReporteMantenimientoBindingSource;
        private System.Windows.Forms.BindingSource oReporteProductoBindingSource;
        private System.Windows.Forms.BindingSource oReporteVehiculoBindingSource;
        private System.Windows.Forms.BindingSource oReporteTotalBindingSource;
        private System.Windows.Forms.BindingSource oReporteProformaBindingSource;
    }
}