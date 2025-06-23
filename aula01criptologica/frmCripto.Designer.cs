namespace aula01criptologica
{
    partial class frmCripto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblDigitePalavra = new Label();
            label2 = new Label();
            lblLetra = new Label();
            lblPalavraCripto = new Label();
            lblPalavraAcerto = new Label();
            lblAcertouErrou = new Label();
            btnJogar = new Button();
            btnVerificar = new Button();
            btnFechar = new Button();
            txtPalavra = new TextBox();
            txtTentativas = new TextBox();
            txtLetra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.handheld_game_console;
            pictureBox1.Location = new Point(430, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDigitePalavra
            // 
            lblDigitePalavra.AutoSize = true;
            lblDigitePalavra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDigitePalavra.Location = new Point(12, 4);
            lblDigitePalavra.Name = "lblDigitePalavra";
            lblDigitePalavra.Size = new Size(156, 21);
            lblDigitePalavra.TabIndex = 1;
            lblDigitePalavra.Text = "Digite uma palavra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 2;
            label2.Text = "Tentativas";
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLetra.Location = new Point(12, 177);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(48, 21);
            lblLetra.TabIndex = 3;
            lblLetra.Text = "Letra";
            // 
            // lblPalavraCripto
            // 
            lblPalavraCripto.AutoSize = true;
            lblPalavraCripto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavraCripto.Location = new Point(12, 283);
            lblPalavraCripto.Name = "lblPalavraCripto";
            lblPalavraCripto.Size = new Size(118, 21);
            lblPalavraCripto.TabIndex = 4;
            lblPalavraCripto.Text = "Palavra Cripto";
            // 
            // lblPalavraAcerto
            // 
            lblPalavraAcerto.AutoSize = true;
            lblPalavraAcerto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavraAcerto.Location = new Point(12, 339);
            lblPalavraAcerto.Name = "lblPalavraAcerto";
            lblPalavraAcerto.Size = new Size(121, 21);
            lblPalavraAcerto.TabIndex = 5;
            lblPalavraAcerto.Text = "Palavra Acerto";
            // 
            // lblAcertouErrou
            // 
            lblAcertouErrou.AutoSize = true;
            lblAcertouErrou.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAcertouErrou.Location = new Point(12, 392);
            lblAcertouErrou.Name = "lblAcertouErrou";
            lblAcertouErrou.Size = new Size(115, 21);
            lblAcertouErrou.TabIndex = 6;
            lblAcertouErrou.Text = "Acertou Errou";
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.Green;
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogar.ForeColor = Color.White;
            btnJogar.Location = new Point(277, 12);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(125, 55);
            btnJogar.TabIndex = 7;
            btnJogar.Text = "JOGAR";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.RoyalBlue;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(106, 184);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(117, 54);
            btnVerificar.TabIndex = 8;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(517, 369);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(169, 61);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtPalavra
            // 
            txtPalavra.Location = new Point(12, 28);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(259, 23);
            txtPalavra.TabIndex = 10;
            // 
            // txtTentativas
            // 
            txtTentativas.Location = new Point(12, 92);
            txtTentativas.Name = "txtTentativas";
            txtTentativas.Size = new Size(88, 23);
            txtTentativas.TabIndex = 11;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(12, 201);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(88, 23);
            txtLetra.TabIndex = 12;
            // 
            // frmCripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLetra);
            Controls.Add(txtTentativas);
            Controls.Add(txtPalavra);
            Controls.Add(btnFechar);
            Controls.Add(btnVerificar);
            Controls.Add(btnJogar);
            Controls.Add(lblAcertouErrou);
            Controls.Add(lblPalavraAcerto);
            Controls.Add(lblPalavraCripto);
            Controls.Add(lblLetra);
            Controls.Add(label2);
            Controls.Add(lblDigitePalavra);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCripto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criptologica";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDigitePalavra;
        private Label label2;
        private Label lblLetra;
        private Label lblPalavraCripto;
        private Label lblPalavraAcerto;
        private Label lblAcertouErrou;
        private Button btnJogar;
        private Button btnVerificar;
        private Button btnFechar;
        private TextBox txtPalavra;
        private TextBox txtTentativas;
        private TextBox txtLetra;
    }
}
