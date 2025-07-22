using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps
{
    public partial class frmCaraCoroa : Form
    {
        int contadorCara = 0;
        int contadorCoroa = 0;
        Random random = new Random();
        public frmCaraCoroa()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int resultado = random.Next(0, 2);
            if (resultado == 0)
            {
                lblResultado.Text = "CARA";
                pbxMoeda.Image = Properties.Resources.cara;
                contadorCara++;
            }
            else
            {
                lblResultado.Text = "COROA";
                pbxMoeda.Image = Properties.Resources.coroa;
                contadorCoroa++;
            }
            AtualizarPLacar();
        }

        private void AtualizarPLacar()
        {
            lblPlacar.Text = $"Placar\nCara: {contadorCara}\nCoroa: {contadorCoroa}";
        }
    }
}
