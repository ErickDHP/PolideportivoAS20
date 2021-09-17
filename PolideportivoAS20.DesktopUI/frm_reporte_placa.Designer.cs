
namespace PolideportivoAS20.DesktopUI
{
    partial class frm_reporte_placa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.oReporteMantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oReporteProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oReporteVehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.oReporteTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oReporteMantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteVehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteTotalBindingSource)).BeginInit();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Mantenimiento";
            reportDataSource1.Value = this.oReporteMantenimientoBindingSource;
            reportDataSource2.Name = "Producto";
            reportDataSource2.Value = this.oReporteProductoBindingSource;
            reportDataSource3.Name = "Vehiculo";
            reportDataSource3.Value = this.oReporteVehiculoBindingSource;
            reportDataSource4.Name = "Totales";
            reportDataSource4.Value = this.oReporteTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PolideportivoAS20.DesktopUI.ReportePlaca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // oReporteTotalBindingSource
            // 
            this.oReporteTotalBindingSource.DataSource = typeof(PolideportivoAS20.Core.Entidades.oReporteTotal);
            // 
            // frm_reporte_placa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_reporte_placa";
            this.Text = "frm_reporte_placa";
            this.Load += new System.EventHandler(this.frm_reporte_placa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oReporteMantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteVehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oReporteTotalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource oReporteMantenimientoBindingSource;
        private System.Windows.Forms.BindingSource oReporteProductoBindingSource;
        private System.Windows.Forms.BindingSource oReporteVehiculoBindingSource;
        private System.Windows.Forms.BindingSource oReporteTotalBindingSource;
    }
}