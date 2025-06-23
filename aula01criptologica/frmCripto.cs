using static System.Console;
using static System.Convert;
using static System.Environment;
using System;
namespace aula01criptologica
{
    public partial class frmCripto : Form
    {
        private string PalavraSecreta;
        private char[] palavrasecretaarray;
        private int tentativasRestantes;
        public frmCripto()
        {
            InitializeComponent();
            ResetGame();
        }
        private void ResetGame()
        {
            PalavraSecreta = "";
            palavrasecretaarray = null;
            tentativasRestantes = 0;
            txtPalavra.Text = string.Empty;
            txtTentativas.Text = string.Empty;
            txtLetra.Text = string.Empty;
            lblPalavraCripto.Text = "";
            lblPalavraAcerto.Text = "";
            lblAcertouErrou.Text = "";
            txtPalavra.Enabled = true;
            this.ActiveControl = txtPalavra;
            txtTentativas.Enabled = true;
            btnJogar.Enabled = true;
            txtLetra.Enabled = false;
            btnVerificar.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (tentativasRestantes <= 0)
            {
                MessageBox.Show("O jogo acabou!", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
                return;
            }
            if (string.IsNullOrEmpty(txtLetra.Text) || txtLetra.Text.Length != 1)
            {
                MessageBox.Show("Por favor, digite apenas UMA letra!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLetra.Text = string.Empty;
                txtLetra.Focus();
                return;
            }
            char letraDigitada = char.ToUpper(txtLetra.Text[0]);
            bool acertouLetra = false;
            for(int i = 0; i < PalavraSecreta.Length; i++)
            {
                if (PalavraSecreta[i] == letraDigitada && palavrasecretaarray[i] == '_')
                {
                    palavrasecretaarray[i] = letraDigitada;
                    acertouLetra = true;
                    txtLetra.Text = "";
                }
            }
            lblPalavraCripto.Text = $"Palavra ({PalavraSecreta.Length} letras): {new string(palavrasecretaarray)}";
            lblPalavraAcerto.Text = new string(palavrasecretaarray);
            if (acertouLetra)
            {
                lblAcertouErrou.Text = "Acertou!!! Tentativas restantes: " + tentativasRestantes;
                if (new string(palavrasecretaarray) == PalavraSecreta)
                {
                    MessageBox.Show($"Parabéns!!! Você acertou a palavra: {PalavraSecreta}", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }

            }
            else
            {
                tentativasRestantes--;
                lblAcertouErrou.Text = $"Errou! Tentativas restantes: {tentativasRestantes}";
                if (tentativasRestantes <= 0)
                {
                    MessageBox.Show($"Acabou!!! A palavra era: {PalavraSecreta}", "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetGame();
                }
            }
            txtLetra.Text = "";
            txtLetra.Focus();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (string .IsNullOrEmpty(txtPalavra.Text))
            {
                MessageBox.Show("Por favor, digite uma palavra secreta!", "Palavra Secreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PalavraSecreta = txtPalavra.Text.Trim().ToUpper();
            if (!int.TryParse(txtTentativas.Text, out tentativasRestantes) || tentativasRestantes <= 0)
            {
                MessageBox.Show("Por favor, digite um número de tentativas maior que zero e seja válida!", "Tentativas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentativas.Text = string.Empty;
                this.ActiveControl = txtTentativas;
                return;
            }
            palavrasecretaarray = new char[PalavraSecreta.Length];
            for (int i = 0; i < PalavraSecreta.Length; i++)
            {
                palavrasecretaarray[i] = '_';
            }
            lblPalavraCripto.Text = $"Palavra ({PalavraSecreta.Length} letras): {new string(palavrasecretaarray)} ";
            lblPalavraAcerto.Text = new string(palavrasecretaarray);
            txtPalavra.Enabled = false;
            txtTentativas.Enabled = false;
            btnJogar.Enabled = false;
            txtLetra.Enabled = true;
            btnVerificar.Enabled = true;
            txtLetra.Focus();
            lblAcertouErrou.Text = $"Tentativas restantes: {tentativasRestantes}";
            txtPalavra.Text = " ";
            txtTentativas.Text = "";
        }
    }
}
