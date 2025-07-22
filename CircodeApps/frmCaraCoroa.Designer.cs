namespace CircodeApps
{
    partial class frmCaraCoroa
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
            btnJogar = new Button();
            lblResultado = new Label();
            pbxMoeda = new PictureBox();
            btnFechar = new Button();
            lblPlacar = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxMoeda).BeginInit();
            SuspendLayout();
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.MidnightBlue;
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJogar.ForeColor = Color.White;
            btnJogar.Location = new Point(285, 12);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(152, 61);
            btnJogar.TabIndex = 0;
            btnJogar.Text = "JOGAR";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.MidnightBlue;
            lblResultado.Location = new Point(12, 327);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 25);
            lblResultado.TabIndex = 1;
            // 
            // pbxMoeda
            // 
            pbxMoeda.Image = Properties.Resources.coroa1;
            pbxMoeda.Location = new Point(12, 12);
            pbxMoeda.Name = "pbxMoeda";
            pbxMoeda.Size = new Size(267, 274);
            pbxMoeda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMoeda.TabIndex = 2;
            pbxMoeda.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(285, 94);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(152, 61);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblPlacar
            // 
            lblPlacar.AutoSize = true;
            lblPlacar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacar.ForeColor = Color.Red;
            lblPlacar.Location = new Point(12, 371);
            lblPlacar.Name = "lblPlacar";
            lblPlacar.Size = new Size(0, 25);
            lblPlacar.TabIndex = 4;
            // 
            // frmCaraCoroa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 453);
            Controls.Add(lblPlacar);
            Controls.Add(btnFechar);
            Controls.Add(pbxMoeda);
            Controls.Add(lblResultado);
            Controls.Add(btnJogar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCaraCoroa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCaraCoroa";
            ((System.ComponentModel.ISupportInitialize)pbxMoeda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJogar;
        private Label lblResultado;
        private PictureBox pbxMoeda;
        private Button btnFechar;
        private Label lblPlacar;
    }
}