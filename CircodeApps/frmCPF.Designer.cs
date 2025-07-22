namespace CircodeApps
{
    partial class frmCPF
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
            btnVerificar = new Button();
            btnFechar = new Button();
            lblResultado = new Label();
            mtxtCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(25, 59);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "DIGITE O CPF";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.MidnightBlue;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(335, 31);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(156, 57);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(335, 115);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(156, 57);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.DarkGreen;
            lblResultado.Location = new Point(168, 243);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 28);
            lblResultado.TabIndex = 4;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Location = new Point(25, 85);
            mtxtCpf.Mask = "000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(279, 27);
            mtxtCpf.TabIndex = 5;
            mtxtCpf.KeyPress += mtxtCpf_KeyPress;
            // 
            // frmCPF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(517, 334);
            Controls.Add(mtxtCpf);
            Controls.Add(lblResultado);
            Controls.Add(btnFechar);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCPF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCPF";
            Load += frmCPF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVerificar;
        private Button btnFechar;
        private Label lblResultado;
        private MaskedTextBox mtxtCpf;
    }
}