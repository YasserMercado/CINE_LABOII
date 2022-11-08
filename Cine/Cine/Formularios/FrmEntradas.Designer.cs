namespace Cine.Formularios
{
    partial class FrmEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradas));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsDescuentoTarjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtVentaOnlineBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentasxRangoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnVentaPorRango = new Cine.Botones.buttonPersonalizado();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnVentaOnline = new Cine.Botones.buttonPersonalizado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDescuentoTarjeta = new Cine.Botones.buttonPersonalizado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.rptDescuentoTarjeta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtVentaOnlineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentaOnlineBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentasxRangoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentasxRangoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDescuentoTarjetaTableAdapter = new Cine.Reportes.dsCineTableAdapters.dsDescuentoTarjetaTableAdapter();
            this.dtVentaOnlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentaOnlineTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtVentaOnlineTableAdapter();
            this.dtVentasxRangoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtVentasxRangoTableAdapter();
            this.dtTo5VendidasAgostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentasxRangoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rptVentaOnline = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtVentaOnlineBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.rptVentaPorRango = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentoTarjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCineBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo5VendidasAgostoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDescuentoTarjetaBindingSource
            // 
            this.dsDescuentoTarjetaBindingSource.DataMember = "dsDescuentoTarjeta";
            this.dsDescuentoTarjetaBindingSource.DataSource = this.dsCine;
            // 
            // dsCine
            // 
            this.dsCine.DataSetName = "dsCine";
            this.dsCine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtVentaOnlineBindingSource3
            // 
            this.dtVentaOnlineBindingSource3.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource3.DataSource = this.dsCine;
            // 
            // dtVentasxRangoBindingSource3
            // 
            this.dtVentasxRangoBindingSource3.DataMember = "dtVentasxRango";
            this.dtVentasxRangoBindingSource3.DataSource = this.dsCineBindingSource;
            // 
            // dsCineBindingSource
            // 
            this.dsCineBindingSource.DataSource = this.dsCine;
            this.dsCineBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 601);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(40, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "CinemaReport Alpha Version";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnVentaPorRango);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 300);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 53);
            this.panel8.TabIndex = 18;
            // 
            // btnVentaPorRango
            // 
            this.btnVentaPorRango.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnVentaPorRango.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnVentaPorRango.BorderRadius = 3;
            this.btnVentaPorRango.BorderSize = 1;
            this.btnVentaPorRango.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaPorRango.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVentaPorRango.FlatAppearance.BorderSize = 0;
            this.btnVentaPorRango.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnVentaPorRango.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnVentaPorRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaPorRango.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnVentaPorRango.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnVentaPorRango.Location = new System.Drawing.Point(0, 0);
            this.btnVentaPorRango.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentaPorRango.Name = "btnVentaPorRango";
            this.btnVentaPorRango.Size = new System.Drawing.Size(250, 53);
            this.btnVentaPorRango.TabIndex = 12;
            this.btnVentaPorRango.Text = "Venta Por Rango";
            this.btnVentaPorRango.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnVentaPorRango.UseVisualStyleBackColor = false;
            this.btnVentaPorRango.Click += new System.EventHandler(this.btnVentaPorRango_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 288);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 12);
            this.panel7.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnVentaOnline);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 235);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 53);
            this.panel6.TabIndex = 16;
            // 
            // btnVentaOnline
            // 
            this.btnVentaOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnVentaOnline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnVentaOnline.BorderRadius = 3;
            this.btnVentaOnline.BorderSize = 1;
            this.btnVentaOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVentaOnline.FlatAppearance.BorderSize = 0;
            this.btnVentaOnline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnVentaOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnVentaOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaOnline.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnVentaOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnVentaOnline.Location = new System.Drawing.Point(0, 0);
            this.btnVentaOnline.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentaOnline.Name = "btnVentaOnline";
            this.btnVentaOnline.Size = new System.Drawing.Size(250, 53);
            this.btnVentaOnline.TabIndex = 12;
            this.btnVentaOnline.Text = "Venta Online";
            this.btnVentaOnline.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnVentaOnline.UseVisualStyleBackColor = false;
            this.btnVentaOnline.Click += new System.EventHandler(this.btnVentaOnline_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 223);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 12);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDescuentoTarjeta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 53);
            this.panel4.TabIndex = 14;
            // 
            // btnDescuentoTarjeta
            // 
            this.btnDescuentoTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnDescuentoTarjeta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDescuentoTarjeta.BorderRadius = 3;
            this.btnDescuentoTarjeta.BorderSize = 1;
            this.btnDescuentoTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuentoTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDescuentoTarjeta.FlatAppearance.BorderSize = 0;
            this.btnDescuentoTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnDescuentoTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnDescuentoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentoTarjeta.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDescuentoTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDescuentoTarjeta.Location = new System.Drawing.Point(0, 0);
            this.btnDescuentoTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuentoTarjeta.Name = "btnDescuentoTarjeta";
            this.btnDescuentoTarjeta.Size = new System.Drawing.Size(250, 53);
            this.btnDescuentoTarjeta.TabIndex = 11;
            this.btnDescuentoTarjeta.Text = "Descuento Tarjeta";
            this.btnDescuentoTarjeta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnDescuentoTarjeta.UseVisualStyleBackColor = false;
            this.btnDescuentoTarjeta.Click += new System.EventHandler(this.btnDescuentoTarjeta_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 24);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 146);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1056, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(13, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // rptDescuentoTarjeta
            // 
            reportDataSource1.Name = "dsDescuentoTarjeta";
            reportDataSource1.Value = this.dsDescuentoTarjetaBindingSource;
            this.rptDescuentoTarjeta.LocalReport.DataSources.Add(reportDataSource1);
            this.rptDescuentoTarjeta.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptDescuentoTarjeta.rdlc";
            this.rptDescuentoTarjeta.Location = new System.Drawing.Point(256, 31);
            this.rptDescuentoTarjeta.Name = "rptDescuentoTarjeta";
            this.rptDescuentoTarjeta.ServerReport.BearerToken = null;
            this.rptDescuentoTarjeta.Size = new System.Drawing.Size(813, 564);
            this.rptDescuentoTarjeta.TabIndex = 11;
            // 
            // dtVentaOnlineBindingSource1
            // 
            this.dtVentaOnlineBindingSource1.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource1.DataSource = this.dsCineBindingSource;
            // 
            // dtVentaOnlineBindingSource2
            // 
            this.dtVentaOnlineBindingSource2.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource2.DataSource = this.dsCineBindingSource;
            // 
            // dtVentasxRangoBindingSource
            // 
            this.dtVentasxRangoBindingSource.DataMember = "dtVentasxRango";
            this.dtVentasxRangoBindingSource.DataSource = this.dsCine;
            // 
            // dtVentasxRangoBindingSource1
            // 
            this.dtVentasxRangoBindingSource1.DataMember = "dtVentasxRango";
            this.dtVentasxRangoBindingSource1.DataSource = this.dsCine;
            // 
            // dsDescuentoTarjetaTableAdapter
            // 
            this.dsDescuentoTarjetaTableAdapter.ClearBeforeFill = true;
            // 
            // dtVentaOnlineBindingSource
            // 
            this.dtVentaOnlineBindingSource.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource.DataSource = this.dsCine;
            // 
            // dtVentaOnlineTableAdapter
            // 
            this.dtVentaOnlineTableAdapter.ClearBeforeFill = true;
            // 
            // dtVentasxRangoTableAdapter
            // 
            this.dtVentasxRangoTableAdapter.ClearBeforeFill = true;
            // 
            // dtTo5VendidasAgostoBindingSource
            // 
            this.dtTo5VendidasAgostoBindingSource.DataMember = "dtTo5VendidasAgosto";
            this.dtTo5VendidasAgostoBindingSource.DataSource = this.dsCine;
            // 
            // dtVentasxRangoBindingSource2
            // 
            this.dtVentasxRangoBindingSource2.DataMember = "dtVentasxRango";
            this.dtVentasxRangoBindingSource2.DataSource = this.dsCine;
            // 
            // rptVentaOnline
            // 
            this.rptVentaOnline.DocumentMapWidth = 26;
            reportDataSource2.Name = "dsVentaOnline";
            reportDataSource2.Value = this.dtVentaOnlineBindingSource;
            this.rptVentaOnline.LocalReport.DataSources.Add(reportDataSource2);
            this.rptVentaOnline.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptVentaOnline.rdlc";
            this.rptVentaOnline.Location = new System.Drawing.Point(256, 31);
            this.rptVentaOnline.Name = "rptVentaOnline";
            this.rptVentaOnline.ServerReport.BearerToken = null;
            this.rptVentaOnline.Size = new System.Drawing.Size(813, 564);
            this.rptVentaOnline.TabIndex = 12;
            // 
            // dtVentaOnlineBindingSource4
            // 
            this.dtVentaOnlineBindingSource4.DataMember = "dtVentaOnline";
            this.dtVentaOnlineBindingSource4.DataSource = this.dsCine;
            // 
            // rptVentaPorRango
            // 
            reportDataSource3.Name = "dsVentasxRango";
            reportDataSource3.Value = this.dtVentasxRangoBindingSource;
            this.rptVentaPorRango.LocalReport.DataSources.Add(reportDataSource3);
            this.rptVentaPorRango.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptVentasxRango.rdlc";
            this.rptVentaPorRango.Location = new System.Drawing.Point(256, 31);
            this.rptVentaPorRango.Name = "rptVentaPorRango";
            this.rptVentaPorRango.ServerReport.BearerToken = null;
            this.rptVentaPorRango.Size = new System.Drawing.Size(813, 564);
            this.rptVentaPorRango.TabIndex = 13;
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1075, 601);
            this.Controls.Add(this.rptVentaPorRango);
            this.Controls.Add(this.rptVentaOnline);
            this.Controls.Add(this.rptDescuentoTarjeta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPeliculas";
            this.Load += new System.EventHandler(this.FrmEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDescuentoTarjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCineBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo5VendidasAgostoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentasxRangoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentaOnlineBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private Botones.buttonPersonalizado btnVentaPorRango;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Botones.buttonPersonalizado btnVentaOnline;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Botones.buttonPersonalizado btnDescuentoTarjeta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer rptDescuentoTarjeta;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dsCineBindingSource;
        private System.Windows.Forms.BindingSource dsDescuentoTarjetaBindingSource;
        private Reportes.dsCineTableAdapters.dsDescuentoTarjetaTableAdapter dsDescuentoTarjetaTableAdapter;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource1;
        private Reportes.dsCineTableAdapters.dtVentaOnlineTableAdapter dtVentaOnlineTableAdapter;
        private System.Windows.Forms.BindingSource dtVentasxRangoBindingSource;
        private System.Windows.Forms.BindingSource dtVentasxRangoBindingSource1;
        private Reportes.dsCineTableAdapters.dtVentasxRangoTableAdapter dtVentasxRangoTableAdapter;
        private System.Windows.Forms.BindingSource dtTo5VendidasAgostoBindingSource;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource2;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource3;
        private System.Windows.Forms.BindingSource dtVentasxRangoBindingSource2;
        private System.Windows.Forms.BindingSource dtVentasxRangoBindingSource3;
        private Microsoft.Reporting.WinForms.ReportViewer rptVentaOnline;
        private System.Windows.Forms.BindingSource dtVentaOnlineBindingSource4;
        private Microsoft.Reporting.WinForms.ReportViewer rptVentaPorRango;
    }
}