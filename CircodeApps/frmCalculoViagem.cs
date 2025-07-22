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
    public partial class frmCalculoViagem : Form
    {
        public frmCalculoViagem()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float alcool = 4.27f;
            float gascomum = 6.28f;
            float gasaditi = 6.50f;
            float diesel = 5.93f;
            float tempo, litros, gasta;
            Int32 distancia = Convert.ToInt32(txtCombustivel.Text.Trim());
            Int32 autonomia = Convert.ToInt32(txtAutonomia.Text.Trim());
            
            if (cbbTipo.Text == "ÁLCOOL")
            {   
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * alcool;
            }
            else if(cbbTipo.Text == "GASOLINA COMUM")
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * gascomum;
            }
            else if (cbbTipo.Text == "GASOLINA ADITIVADA")
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * gasaditi;
            }
            else
            {
                tempo = distancia / 90;
                litros = distancia / autonomia;
                gasta = litros * diesel;
            }
            lblLitrosGasto.Text = $"Litros gastos: {litros.ToString("F")}";
            lblGastoTotal.Text = $"Total: {gasta.ToString("C")}";
            lblTempo.Text = $"Previsão tempo total (90km/h): {tempo.ToString("F")}";
        }
    }
}
