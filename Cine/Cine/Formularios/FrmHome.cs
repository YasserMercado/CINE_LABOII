using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Cine.Reportes;
using Cine.Formularios;

namespace Cine
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes.frmClasificacionesMasVistas Clasificaciones = new Reportes.frmClasificacionesMasVistas();
            Clasificaciones.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)  //Hay que sacarlo
        {
            Reportes.frmClientesAgosto clientesAgosto = new Reportes.frmClientesAgosto();
            clientesAgosto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reportes.frmMenos10Butacas MenosButacas = new Reportes.frmMenos10Butacas();
            MenosButacas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reportes.frmDescuentoTarjeta descuento = new Reportes.frmDescuentoTarjeta();
            descuento.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reportes.frmButacasVip butacasVip = new Reportes.frmButacasVip();
            butacasVip.ShowDialog();    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reportes.frmRecaudacionSpielberg recaudacion = new Reportes.frmRecaudacionSpielberg();
            recaudacion.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reportes.frmVentaOnline online = new Reportes.frmVentaOnline();
            online.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reportes.frmVentaxRango rango = new Reportes.frmVentaxRango();
            rango.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reportes.frmTop5Agosto rango = new Reportes.frmTop5Agosto();
            rango.ShowDialog();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmClientes clientes = new Formularios.FrmClientes();
            clientes.ShowDialog();
        }

        private void frmHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel12_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            frmSugerenciasMejoras mejoras = new frmSugerenciasMejoras();
            mejoras.Show();
        

        }

        
    }
}
