using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CICLOAPPS
{
    public partial class frmBuscaCEP : Form
    {
        public frmBuscaCEP()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCEP.Text + "/json");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indísponivel!", "Erro HTTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (Stream webstream = ChecaServidor.GetResponseStream())
            {
                if (webstream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webstream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                        string[] substrings = response.Split('\n');
                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                if (substring.Contains(":"))
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor.Length >= 2 && valor[0].Trim().Replace("\"", "") == "erro")
                                    {
                                        MessageBox.Show("CEP não encontrado!");
                                        txtCEP.Text = string.Empty;
                                        txtCEP.Focus();
                                        return;
                                    }
                                }
                            }
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblEndereco.Text = valor[1];
                            }
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblComplemento.Text = valor[1];
                            }
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblBairro.Text = valor[1];
                            }
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblCidade.Text = valor[1];
                            }
                            if (cont == 7)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                lblUF.Text = valor[1];
                            }
                            cont++;
                        }
                    }
                }

            }
        }
    }
}
