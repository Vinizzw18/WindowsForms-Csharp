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
    public partial class frmCalc : Form
    {
        double primeiroNumero = 0;
        string operador = "";
        bool novoNumero = true;
        bool virgulaDigitada = false;
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            lblConta.Text = "0";
            if (!novoNumero)
            {
                btnApagar.Visible = false;
            }
            else
            {
                btnApagar.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (novoNumero)
            {
                lblConta.Text = btn.Text;
                novoNumero = false;
                virgulaDigitada = false;
            }
            else
            {
                if (lblConta.Text == "0" && btn.Text == "0")
                {
                    return;
                }
                if (lblConta.Text == "0" && btn.Text != "0")
                {
                    lblConta.Text = btn.Text;
                }
                else
                {
                    lblConta.Text += btn.Text;
                }
            }
            if (operador == "")
            {
                lblResultado.Text = lblConta.Text;
            }
            else
            {
                string primeiroNumStr = primeiroNumero.ToString();
                if (primeiroNumStr.Contains("."))
                {
                    primeiroNumStr = primeiroNumStr.Replace(".", ",");
                }
                lblResultado.Text = $"{primeiroNumStr} {operador} {lblConta.Text}";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!virgulaDigitada)
            {
                if (lblConta.Text == "" || novoNumero)
                {
                    lblConta.Text = "0, ";
                    novoNumero = false;
                }
                else
                {
                    lblConta.Text += ",";
                }
                virgulaDigitada = true;
            }
            if (operador == "")
            {
                lblResultado.Text = lblConta.Text;
            }
            else
            {
                string primeiroNumStr = primeiroNumero.ToString();
                if (primeiroNumStr.Contains("."))
                {
                    primeiroNumStr = primeiroNumStr.Replace(".", ",");
                }
                lblResultado.Text = $"{primeiroNumStr} {operador} {lblConta.Text}";
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!novoNumero && operador != "")
            {
                CalcularResultado();
            }
            primeiroNumero = double.Parse(lblConta.Text);
            operador = btn.Text;
            novoNumero = true;
            string primeiroNumStr = primeiroNumero.ToString();
            if (primeiroNumStr.Contains("."))
            {
                primeiroNumStr = primeiroNumStr.Replace(".", ",");

            }
            lblResultado.Text = $"{primeiroNumStr} {operador}";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string segundoNumeroText = lblConta.Text;
            string operadorAnterior = operador;
            CalcularResultado();
            string primeiroNumStr = primeiroNumero.ToString();
            if (primeiroNumStr.Contains("."))
            {
                primeiroNumStr = primeiroNumStr.Replace(".", ",");
            }
            lblResultado.Text = $"{primeiroNumStr} {operadorAnterior} {segundoNumeroText}";
            operador = "";
            novoNumero = true;
            virgulaDigitada = false;
        }
        private void CalcularResultado()
        {
            if (operador == "" || novoNumero)
            {
                return;
            }
            double segundoNumero = double.Parse(lblConta.Text);
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;
                case "x":
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                    else
                    {
                        MessageBox.Show("Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblConta.Text = "0";
                        primeiroNumero = 0;
                        operador = "";
                        novoNumero = true;
                        virgulaDigitada = false;
                        lblResultado.Text = "0";
                        return;
                    }
                    break;
            }
            lblConta.Text = resultado.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!novoNumero && operador != "")
            {
                CalcularResultado();
            }
            primeiroNumero = double.Parse(lblConta.Text);
            operador = btn.Text;
            novoNumero = true;
            string primeiroNumStr = primeiroNumero.ToString();
            if (primeiroNumStr.Contains("."))
            {
                primeiroNumStr = primeiroNumStr.Replace(".", ",");

            }
            lblResultado.Text = $"{primeiroNumStr} {operador}";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!novoNumero && operador != "")
            {
                CalcularResultado();
            }
            primeiroNumero = double.Parse(lblConta.Text);
            operador = btn.Text;
            novoNumero = true;
            string primeiroNumStr = primeiroNumero.ToString();
            if (primeiroNumStr.Contains("."))
            {
                primeiroNumStr = primeiroNumStr.Replace(".", ",");

            }
            lblResultado.Text = $"{primeiroNumStr} {operador}";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!novoNumero && operador != "")
            {
                CalcularResultado();
            }
            primeiroNumero = double.Parse(lblConta.Text);
            operador = btn.Text;
            novoNumero = true;
            string primeiroNumStr = primeiroNumero.ToString();
            if (primeiroNumStr.Contains("."))
            {
                primeiroNumStr = primeiroNumStr.Replace(".", ",");

            }
            lblResultado.Text = $"{primeiroNumStr} {operador}";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!novoNumero)
            {
                if (lblConta.Text == "")
                {
                    lblConta.Text = lblConta.Text.Substring(0, lblConta.Text.Length - 1);
                    lblResultado.Text = lblResultado.Text.Substring(0, lblResultado.Text.Length - 1);
                }
                else if (lblConta.Text.Length == 1)
                {
                    lblConta.Text = "0";
                    lblResultado.Text = "0";
                }
                else
                {
                    return;
                }
            }
            else
            {

            }
        }
    }
}
