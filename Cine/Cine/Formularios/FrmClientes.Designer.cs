﻿namespace Cine.Formularios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource22 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource23 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource24 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.dtRecurrentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtClientesAgostoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodosLosClientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtTodosLosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRecurrentesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtClientesAgostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtClientesAgostoTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtClientesAgostoTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtTodosLosClientesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtTodosLosClientesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new Cine.Botones.buttonPersonalizado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new Cine.Botones.buttonPersonalizado();
            this.button3 = new Cine.Botones.buttonPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
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
            // dtTodosLosClientesBindingSource1
            // 
            this.dtTodosLosClientesBindingSource1.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource1.DataSource = this.dsCine;
            // 
            // dtTodosLosClientesBindingSource
            // 
            this.dtTodosLosClientesBindingSource.DataMember = "dtTodosLosClientes";
            this.dtTodosLosClientesBindingSource.DataSource = this.dsCine;
            // 
            // reportViewer1
            // 
            reportDataSource22.Name = "DataSet1";
            reportDataSource22.Value = this.dtRecurrentesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource22);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptRecurrentes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(346, 92);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(909, 640);
            this.reportViewer1.TabIndex = 2;
            // 
            // dtRecurrentesTableAdapter
            // 
            this.dtRecurrentesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource23.Name = "dsClientesAgosto";
            reportDataSource23.Value = this.dtClientesAgostoBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource23);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptClientesAgosto.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(346, 92);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(909, 640);
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
            reportDataSource24.Name = "DSTodosLosClientes";
            reportDataSource24.Value = this.dtTodosLosClientesBindingSource1;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource24);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Cine.Reportes.rptTodosLosClientes.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(346, 92);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(909, 640);
            this.reportViewer3.TabIndex = 6;
            // 
            // dtTodosLosClientesTableAdapter
            // 
            this.dtTodosLosClientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 740);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button1.BorderRadius = 3;
            this.button1.BorderSize = 1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "TODOS";
            this.button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 180);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 30);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 65);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 275);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 15);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(333, 65);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 355);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 15);
            this.panel7.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 370);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(333, 65);
            this.panel8.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button2.BorderRadius = 3;
            this.button2.BorderSize = 1;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(333, 65);
            this.button2.TabIndex = 12;
            this.button2.Text = "FRECUENTES";
            this.button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button3.BorderRadius = 3;
            this.button3.BorderSize = 1;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(333, 65);
            this.button3.TabIndex = 12;
            this.button3.Text = "DE AGOSTO";
            this.button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(53, 714);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "CinemaReport Alpha Version";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1233, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1260, 740);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmClientes";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmClientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTodosLosClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientesAgostoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dtRecurrentesBindingSource;
        private Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter dtRecurrentesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource;
        private System.Windows.Forms.BindingSource dtClientesAgostoBindingSource1;
        private Reportes.dsCineTableAdapters.dtClientesAgostoTableAdapter dtClientesAgostoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource;
        private System.Windows.Forms.BindingSource dtTodosLosClientesBindingSource1;
        private Reportes.dsCineTableAdapters.dtTodosLosClientesTableAdapter dtTodosLosClientesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Botones.buttonPersonalizado button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private Botones.buttonPersonalizado button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Botones.buttonPersonalizado button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}