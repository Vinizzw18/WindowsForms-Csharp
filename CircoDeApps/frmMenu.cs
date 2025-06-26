using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CICLOAPPS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            frmSplash splash = new frmSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxBuscaCEP_Click(object sender, EventArgs e)
        {
            foreach(Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmBuscaCEP)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmBuscaCEP buscaCEP = new frmBuscaCEP();
            buscaCEP.Show();
        }

    }
}
