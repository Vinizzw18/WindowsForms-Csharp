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
    public partial class frmCPF : Form
    {
        public frmCPF()
        {
            InitializeComponent();
        }

        private void frmCPF_Load(object sender, EventArgs e)
        {
            this.ActiveControl = mtxtCpf;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string cpf = mtxtCpf.Text.Trim();
            bool valido = ValidarCPF(cpf);
            if (valido == true)
            {
                lblResultado.Text = "CPF Válido!";
            }
            else
            {
                lblResultado.Text = "CPF Inválido!";
            }
            mtxtCpf.Text = "";
            mtxtCpf.Focus();
        }

        public static bool ValidarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());
            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
                return false;
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);
            int primeiroDigito = soma % 11;
            primeiroDigito = (primeiroDigito < 2) ? 0 : 11 - primeiroDigito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);
            int segundoDigito = soma % 11;
            segundoDigito = (segundoDigito < 2) ? 0 : 11 - segundoDigito;
            return cpf[9] - '0' == primeiroDigito && cpf[10] - '0' == segundoDigito;
        }

        private void mtxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnVerificar.PerformClick();
            }
        }
    }
}
