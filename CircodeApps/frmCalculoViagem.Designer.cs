namespace CircodeApps
{
    partial class frmCalculoViagem
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
            btnCalcular = new Button();
            txtCombustivel = new TextBox();
            cbbTipo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lblLitrosGasto = new Label();
            lblGastoTotal = new Label();
            lblTempo = new Label();
            txtAutonomia = new TextBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 0;
            label1.Text = "DISTÂNCIA (Km)";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.MidnightBlue;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(427, 53);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(174, 56);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCombustivel
            // 
            txtCombustivel.Location = new Point(31, 54);
            txtCombustivel.Name = "txtCombustivel";
            txtCombustivel.Size = new Size(275, 23);
            txtCombustivel.TabIndex = 2;
            // 
            // cbbTipo
            // 
            cbbTipo.FormattingEnabled = true;
            cbbTipo.Items.AddRange(new object[] { "ÁLCOOL", "GASOLINA COMUM", "GASOLINA ADITIVADA", "DIESEL" });
            cbbTipo.Location = new Point(31, 127);
            cbbTipo.Name = "cbbTipo";
            cbbTipo.Size = new Size(169, 23);
            cbbTipo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 94);
            label2.Name = "label2";
            label2.Size = new Size(152, 17);
            label2.TabIndex = 4;
            label2.Text = "TIPO DE COMBUSTÍVEL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 169);
            label3.Name = "label3";
            label3.Size = new Size(136, 17);
            label3.TabIndex = 6;
            label3.Text = "AUTONOMIA (Km/L)";
            // 
            // lblLitrosGasto
            // 
            lblLitrosGasto.AutoSize = true;
            lblLitrosGasto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLitrosGasto.Location = new Point(31, 275);
            lblLitrosGasto.Name = "lblLitrosGasto";
            lblLitrosGasto.Size = new Size(0, 17);
            lblLitrosGasto.TabIndex = 7;
            // 
            // lblGastoTotal
            // 
            lblGastoTotal.AutoSize = true;
            lblGastoTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGastoTotal.Location = new Point(31, 332);
            lblGastoTotal.Name = "lblGastoTotal";
            lblGastoTotal.Size = new Size(0, 17);
            lblGastoTotal.TabIndex = 8;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTempo.Location = new Point(31, 391);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(0, 17);
            lblTempo.TabIndex = 9;
            // 
            // txtAutonomia
            // 
            txtAutonomia.Location = new Point(31, 198);
            txtAutonomia.Name = "txtAutonomia";
            txtAutonomia.Size = new Size(275, 23);
            txtAutonomia.TabIndex = 11;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(427, 127);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(174, 56);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmCalculoViagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 513);
            Controls.Add(btnFechar);
            Controls.Add(txtAutonomia);
            Controls.Add(lblTempo);
            Controls.Add(lblGastoTotal);
            Controls.Add(lblLitrosGasto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbbTipo);
            Controls.Add(txtCombustivel);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalculoViagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCalculoViagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalcular;
        private TextBox txtCombustivel;
        private ComboBox cbbTipo;
        private Label label2;
        private Label label3;
        private Label lblLitrosGasto;
        private Label lblGastoTotal;
        private Label lblTempo;
        private TextBox txtAutonomia;
        private Button btnFechar;
    }
}