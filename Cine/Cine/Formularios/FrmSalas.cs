using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Formularios
{
    public partial class FrmSalas : Form
    {
        public FrmSalas()
        {
            InitializeComponent();
            EsconderReportes();
        }

        private void EsconderReportes()
        {
            rptButacasVip.Hide();
            rptMenosDe10.Hide();
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtMenos10Butacas' Puede moverla o quitarla según sea necesario.
            this.dtMenos10ButacasTableAdapter.Fill(this.dsCine.dtMenos10Butacas);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsButacasVip' Puede moverla o quitarla según sea necesario.
            this.dsButacasVipTableAdapter.Fill(this.dsCine.dsButacasVip);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsDescuentoTarjeta' Puede moverla o quitarla según sea necesario.
            this.dsDescuentoTarjetaTableAdapter.Fill(this.dsCine.dsDescuentoTarjeta);

            this.rptButacasVip.RefreshReport();
            this.rptMenosDe10.RefreshReport();
        }

        private void btnMenosDe10_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptMenosDe10.Show();
        }

        private void btnButacasVip_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptButacasVip.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }
    }
}
