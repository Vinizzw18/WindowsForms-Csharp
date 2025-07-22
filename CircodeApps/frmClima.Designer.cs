namespace CircodeApps
{
    partial class frmClima
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
            btnPesquisar = new Button();
            txtCidade = new TextBox();
            label1 = new Label();
            btnFechar = new Button();
            lblCidade = new Label();
            lblTemperatura = new Label();
            lblDescricao = new Label();
            lblUmidade = new Label();
            lblPressao = new Label();
            lblPais = new Label();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.MidnightBlue;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(338, 55);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(159, 52);
            btnPesquisar.TabIndex = 0;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(32, 68);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(287, 27);
            txtCidade.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 2;
            label1.Text = "DIGITE UMA CIDADE";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(338, 132);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(159, 52);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCidade.ForeColor = Color.MidnightBlue;
            lblCidade.Location = new Point(32, 225);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(0, 23);
            lblCidade.TabIndex = 4;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.BackColor = Color.Transparent;
            lblTemperatura.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperatura.ForeColor = Color.MidnightBlue;
            lblTemperatura.Location = new Point(32, 273);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(0, 23);
            lblTemperatura.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.MidnightBlue;
            lblDescricao.Location = new Point(32, 324);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(0, 23);
            lblDescricao.TabIndex = 6;
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.BackColor = Color.Transparent;
            lblUmidade.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUmidade.ForeColor = Color.MidnightBlue;
            lblUmidade.Location = new Point(32, 374);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(0, 23);
            lblUmidade.TabIndex = 7;
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.BackColor = Color.Transparent;
            lblPressao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPressao.ForeColor = Color.MidnightBlue;
            lblPressao.Location = new Point(32, 422);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(0, 23);
            lblPressao.TabIndex = 8;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.BackColor = Color.Transparent;
            lblPais.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPais.ForeColor = Color.MidnightBlue;
            lblPais.Location = new Point(32, 471);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(0, 23);
            lblPais.TabIndex = 9;
            // 
            // frmClima
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tempo1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(542, 532);
            Controls.Add(lblPais);
            Controls.Add(lblPressao);
            Controls.Add(lblUmidade);
            Controls.Add(lblDescricao);
            Controls.Add(lblTemperatura);
            Controls.Add(lblCidade);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Controls.Add(txtCidade);
            Controls.Add(btnPesquisar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmClima";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClima";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private TextBox txtCidade;
        private Label label1;
        private Button btnFechar;
        private Label lblCidade;
        private Label lblTemperatura;
        private Label lblDescricao;
        private Label lblUmidade;
        private Label lblPressao;
        private Label lblPais;
    }
}