namespace Cine
{
    partial class frmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button10 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtRecurrentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCine = new Cine.Reportes.dsCine();
            this.dtRecurrentesTableAdapter = new Cine.Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSalas = new Cine.Botones.buttonPersonalizado();
            this.btnPeliculas = new Cine.Botones.buttonPersonalizado();
            this.btnFunciones = new Cine.Botones.buttonPersonalizado();
            this.btnEntradas = new Cine.Botones.buttonPersonalizado();
            this.button1 = new Cine.Botones.buttonPersonalizado();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(35, 2);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(235, 34);
            this.button10.TabIndex = 9;
            this.button10.Text = "Mas Vendidas Agosto";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button10);
            this.panel11.Location = new System.Drawing.Point(439, 720);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(293, 42);
            this.panel11.TabIndex = 3;
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
            // dtRecurrentesTableAdapter
            // 
            this.dtRecurrentesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 406);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(63, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "CinemaReport Alpha Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(624, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "HOME";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1013, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel12.Controls.Add(this.btnCerrar);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.btnSalas);
            this.panel12.Controls.Add(this.btnPeliculas);
            this.panel12.Controls.Add(this.btnFunciones);
            this.panel12.Controls.Add(this.btnEntradas);
            this.panel12.Controls.Add(this.button1);
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1040, 406);
            this.panel12.TabIndex = 12;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel12_MouseDown);
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnSalas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSalas.BorderRadius = 3;
            this.btnSalas.BorderSize = 1;
            this.btnSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSalas.Location = new System.Drawing.Point(702, 82);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(180, 130);
            this.btnSalas.TabIndex = 11;
            this.btnSalas.Text = "SALAS";
            this.btnSalas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnSalas.UseVisualStyleBackColor = false;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnPeliculas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnPeliculas.BorderRadius = 3;
            this.btnPeliculas.BorderSize = 1;
            this.btnPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnPeliculas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnPeliculas.Location = new System.Drawing.Point(489, 82);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(180, 130);
            this.btnPeliculas.TabIndex = 10;
            this.btnPeliculas.Text = "PELICULAS";
            this.btnPeliculas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnPeliculas.UseVisualStyleBackColor = false;
            // 
            // btnFunciones
            // 
            this.btnFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnFunciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFunciones.BorderRadius = 3;
            this.btnFunciones.BorderSize = 1;
            this.btnFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunciones.FlatAppearance.BorderSize = 0;
            this.btnFunciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunciones.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnFunciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFunciones.Location = new System.Drawing.Point(820, 254);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(180, 130);
            this.btnFunciones.TabIndex = 9;
            this.btnFunciones.Text = "FUNCIONES";
            this.btnFunciones.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnFunciones.UseVisualStyleBackColor = false;
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.btnEntradas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnEntradas.BorderRadius = 3;
            this.btnEntradas.BorderSize = 1;
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.btnEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnEntradas.Location = new System.Drawing.Point(599, 254);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(180, 130);
            this.btnEntradas.TabIndex = 8;
            this.btnEntradas.Text = "ENTRADAS";
            this.btnEntradas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.btnEntradas.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button1.BorderRadius = 3;
            this.button1.BorderSize = 1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(0)))), ((int)(((byte)(19)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(60)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button1.Location = new System.Drawing.Point(386, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 130);
            this.button1.TabIndex = 7;
            this.button1.Text = "CLIENTES";
            this.button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(55)))));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 406);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmHome_MouseDown);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecurrentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Reportes.dsCine dsCine;
        private System.Windows.Forms.BindingSource dtRecurrentesBindingSource;
        private Reportes.dsCineTableAdapters.dtRecurrentesTableAdapter dtRecurrentesTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Botones.buttonPersonalizado button1;
        private Botones.buttonPersonalizado btnEntradas;
        private Botones.buttonPersonalizado btnFunciones;
        private Botones.buttonPersonalizado btnPeliculas;
        private Botones.buttonPersonalizado btnSalas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel12;
    }
}

