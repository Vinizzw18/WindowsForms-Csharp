namespace CircodeApps
{
    partial class frmBuscaCEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnPesquisar = new Button();
            txtCEP = new TextBox();
            btnFechar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblUF = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblComplemento = new Label();
            lblEndereco = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 0;
            label1.Text = "Digite um CEP";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(319, 41);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(185, 62);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(34, 60);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(261, 27);
            txtCEP.TabIndex = 2;
            txtCEP.KeyPress += txtCEP_KeyPress;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(319, 122);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(185, 62);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 249);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 4;
            label2.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 314);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 5;
            label3.Text = "Complemento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 381);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 6;
            label4.Text = "Bairro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 458);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 7;
            label5.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 519);
            label6.Name = "label6";
            label6.Size = new Size(36, 23);
            label6.TabIndex = 8;
            label6.Text = "UF:";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(194, 519);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(0, 20);
            lblUF.TabIndex = 13;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(194, 458);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 20);
            lblCidade.TabIndex = 12;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(194, 381);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(0, 20);
            lblBairro.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(194, 314);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(0, 20);
            lblComplemento.TabIndex = 10;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(194, 249);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(0, 20);
            lblEndereco.TabIndex = 9;
            // 
            // frmBuscaCEP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(545, 562);
            Controls.Add(lblUF);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblComplemento);
            Controls.Add(lblEndereco);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFechar);
            Controls.Add(txtCEP);
            Controls.Add(btnPesquisar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBuscaCEP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBuscaCEP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPesquisar;
        private TextBox txtCEP;
        private Button btnFechar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblUF;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblComplemento;
        private Label lblEndereco;
    }
}