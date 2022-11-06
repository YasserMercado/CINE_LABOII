namespace Cine.Formularios
{
    partial class FrmClientes
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
            this.dtRecurrentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtClientesAgostoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodosLosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRecurrentesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtClientesAgostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesAgostoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtClientesAgostoTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtTodosLosClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodosLosClientesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTodosLosClientesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRecurrentesBindingSource
            // 
            this.dtRecurrentesBindingSource.DataMember = "dtRecurrentes";
            this.dtRecurrentesBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtClientesAgostoBindingSource1
            // 
            this.dtClientesAgostoBindingSource1.DataMember = "dtClientesAgosto";
            this.dtClientesAgostoBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodosLosClientesBindingSource
            // 
            this.dtTodosLosClientesBindingSource.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource.DataSource = this.dsCine;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtRecurrentesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptRecurrentes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(205, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(682, 520);
            this.reportViewer1.TabIndex = 2;
            // 
            // dtRecurrentesTableAdapter
            // 
            this.dtRecurrentesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Recurrentes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "De Agosto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "dsClientesAgosto";
            reportDataSource2.Value = this.dtClientesAgostoBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptClientesAgosto.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(205, 43);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(682, 520);
            this.reportViewer2.TabIndex = 5;
            // 
            // dtClientesAgostoBindingSource
            // 
            this.dtClientesAgostoBindingSource.DataMember = "dtClientesAgosto";
            this.dtClientesAgostoBindingSource.DataSource = this.dsCine;
            // 
            // dtClientesAgostoTableAdapter
            // 
            this.dtClientesAgostoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DSTodosLosClientes";
            reportDataSource3.Value = this.dtTodosLosClientesBindingSource1;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTodosLosClientes.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(205, 43);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(682, 520);
            this.reportViewer3.TabIndex = 6;
            // 
            // dtTodosLosClientesBindingSource1
            // 
            this.dtTodosLosClientesBindingSource1.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodosLosClientesTableAdapter
            // 
            this.dtTodosLosClientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(178, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 660);
            this.panel1.TabIndex = 7;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(945, 645);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dtRecurrentesBindingSource;
        private Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter dtRecurrentesTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource1;
        private Reportes.dsCineTableAdapters.dtClientesAgostoTableAdapter dtClientesAgostoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource1;
        private Reportes.dsCineTableAdapters.dtTodosLosClientesTableAdapter dtTodosLosClientesTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}