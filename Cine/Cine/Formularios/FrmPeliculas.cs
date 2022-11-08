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
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
            EsconderReportes();
        }

        private void EsconderReportes()
        {
            rptMasVistas.Hide();
            rptSpielberg.Hide();
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtRecaudacionSpielberg' Puede moverla o quitarla según sea necesario.
            this.dtRecaudacionSpielbergTableAdapter.Fill(this.dsCine.dtRecaudacionSpielberg);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClasificaiconesMasVistas' Puede moverla o quitarla según sea necesario.
            this.dtClasificaiconesMasVistasTableAdapter.Fill(this.dsCine.dtClasificaiconesMasVistas);

            this.rptMasVistas.RefreshReport();
            this.rptSpielberg.RefreshReport();
        }

        private void btnMasVistas_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptMasVistas.Show();
        }

        private void btnSpielberg_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptSpielberg.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }
    }
}
