using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Formularios
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            EsconderReportes();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void EsconderReportes()
        {
            reportViewer1.Hide();
            reportViewer2.Hide();
            reportViewer3.Hide();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTodosLosClientes' Puede moverla o quitarla según sea necesario.
            this.dtTodosLosClientesTableAdapter.Fill(this.dsCine.dtTodosLosClientes);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClientesAgosto' Puede moverla o quitarla según sea necesario.
            //this.dtClientesAgostoTableAdapter.Fill(this.dsCine.dtClientesAgosto);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtRecurrentes' Puede moverla o quitarla según sea necesario.
            this.dtRecurrentesTableAdapter.Fill(this.dsCine.dtRecurrentes);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    EsconderReportes();
        //    reportViewer3.Show();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    EsconderReportes();
        //    reportViewer1.Show();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    EsconderReportes();
        //    reportViewer2.Show();
        //}

        private void FrmClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EsconderReportes();
            reportViewer3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EsconderReportes();
            reportViewer1.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            EsconderReportes();
            reportViewer2.Show();
        }
    }
}
