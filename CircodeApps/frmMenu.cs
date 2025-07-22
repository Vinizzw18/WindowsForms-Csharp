namespace CircodeApps
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

        private void pbxFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbxBuscaCEP_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
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

        private void pbxClima_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmClima)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmClima clima = new frmClima();
            clima.Show();
        }

        private void pbxCaraCoroa_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmCaraCoroa)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmCaraCoroa caraCoroa = new frmCaraCoroa();
            caraCoroa.Show();
        }

        private void pbxCPF_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmCPF)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmCPF cpf = new frmCPF();
            cpf.Show();
        }

        private void pbxDestino_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmClima)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmCalculoViagem viagem = new frmCalculoViagem();
            viagem.Show();
        }

        private void pbxCalculadora_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in Application.OpenForms)
            {
                if (formAberto is frmCalc)
                {
                    formAberto.Focus();
                    return;
                }
            }
            frmCalc calculadora = new frmCalc();
            calculadora.Show();
        }
    }
}
