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
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
            rptTop5Agosto.Hide();
        }

        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTo5VendidasAgosto' Puede moverla o quitarla según sea necesario.
            this.dtTo5VendidasAgostoTableAdapter.Fill(this.dsCine.dtTo5VendidasAgosto);

            this.rptTop5Agosto.RefreshReport();
        }

        private void btnDescuentoTarjeta_Click(object sender, EventArgs e)
        {
            rptTop5Agosto.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }
    }
}
