namespace CircodeApps
{
    partial class frmMenu
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
            pbxCalculadora = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pbxBuscaCEP = new PictureBox();
            label3 = new Label();
            pbxClima = new PictureBox();
            label4 = new Label();
            pbxCPF = new PictureBox();
            label5 = new Label();
            pbxCaraCoroa = new PictureBox();
            label6 = new Label();
            pbxDestino = new PictureBox();
            label7 = new Label();
            pbxFechar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxCalculadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscaCEP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCPF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCaraCoroa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFechar).BeginInit();
            SuspendLayout();
            // 
            // pbxCalculadora
            // 
            pbxCalculadora.Image = Properties.Resources.calculadora;
            pbxCalculadora.Location = new Point(30, 20);
            pbxCalculadora.Margin = new Padding(3, 2, 3, 2);
            pbxCalculadora.Name = "pbxCalculadora";
            pbxCalculadora.Size = new Size(168, 165);
            pbxCalculadora.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCalculadora.TabIndex = 0;
            pbxCalculadora.TabStop = false;
            pbxCalculadora.Click += pbxCalculadora_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(35, 188);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(279, 188);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 3;
            label2.Text = "BUSCA CEP";
            // 
            // pbxBuscaCEP
            // 
            pbxBuscaCEP.Image = Properties.Resources.mailbox;
            pbxBuscaCEP.Location = new Point(256, 20);
            pbxBuscaCEP.Margin = new Padding(3, 2, 3, 2);
            pbxBuscaCEP.Name = "pbxBuscaCEP";
            pbxBuscaCEP.Size = new Size(168, 165);
            pbxBuscaCEP.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBuscaCEP.TabIndex = 2;
            pbxBuscaCEP.TabStop = false;
            pbxBuscaCEP.Click += pbxBuscaCEP_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(526, 188);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "TEMPO";
            // 
            // pbxClima
            // 
            pbxClima.Image = Properties.Resources.aplicativo_de_clima;
            pbxClima.Location = new Point(482, 20);
            pbxClima.Margin = new Padding(3, 2, 3, 2);
            pbxClima.Name = "pbxClima";
            pbxClima.Size = new Size(168, 165);
            pbxClima.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxClima.TabIndex = 4;
            pbxClima.TabStop = false;
            pbxClima.Click += pbxClima_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(732, 188);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 7;
            label4.Text = "VALIDA CPF";
            // 
            // pbxCPF
            // 
            pbxCPF.Image = Properties.Resources.arquivo;
            pbxCPF.Location = new Point(712, 20);
            pbxCPF.Margin = new Padding(3, 2, 3, 2);
            pbxCPF.Name = "pbxCPF";
            pbxCPF.Size = new Size(168, 165);
            pbxCPF.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCPF.TabIndex = 6;
            pbxCPF.TabStop = false;
            pbxCPF.Click += pbxCPF_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(142, 397);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 9;
            label5.Text = "CARA OU COROA";
            // 
            // pbxCaraCoroa
            // 
            pbxCaraCoroa.Image = Properties.Resources.moeda_de_dolar;
            pbxCaraCoroa.Location = new Point(148, 230);
            pbxCaraCoroa.Margin = new Padding(3, 2, 3, 2);
            pbxCaraCoroa.Name = "pbxCaraCoroa";
            pbxCaraCoroa.Size = new Size(168, 165);
            pbxCaraCoroa.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCaraCoroa.TabIndex = 8;
            pbxCaraCoroa.TabStop = false;
            pbxCaraCoroa.Click += pbxCaraCoroa_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(431, 397);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 11;
            label6.Text = "VIAGEM";
            // 
            // pbxDestino
            // 
            pbxDestino.Image = Properties.Resources.destino;
            pbxDestino.Location = new Point(374, 230);
            pbxDestino.Margin = new Padding(3, 2, 3, 2);
            pbxDestino.Name = "pbxDestino";
            pbxDestino.Size = new Size(168, 165);
            pbxDestino.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxDestino.TabIndex = 10;
            pbxDestino.TabStop = false;
            pbxDestino.Click += pbxDestino_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(658, 397);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 13;
            label7.Text = "SAIR";
            // 
            // pbxFechar
            // 
            pbxFechar.Image = Properties.Resources.sair;
            pbxFechar.Location = new Point(600, 230);
            pbxFechar.Margin = new Padding(3, 2, 3, 2);
            pbxFechar.Name = "pbxFechar";
            pbxFechar.Size = new Size(168, 165);
            pbxFechar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFechar.TabIndex = 12;
            pbxFechar.TabStop = false;
            pbxFechar.Click += pbxFechar_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(913, 439);
            Controls.Add(label7);
            Controls.Add(pbxFechar);
            Controls.Add(label6);
            Controls.Add(pbxDestino);
            Controls.Add(label5);
            Controls.Add(pbxCaraCoroa);
            Controls.Add(label4);
            Controls.Add(pbxCPF);
            Controls.Add(label3);
            Controls.Add(pbxClima);
            Controls.Add(label2);
            Controls.Add(pbxBuscaCEP);
            Controls.Add(label1);
            Controls.Add(pbxCalculadora);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxCalculadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBuscaCEP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClima).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCPF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCaraCoroa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFechar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCalculadora;
        private Label label1;
        private Label label2;
        private PictureBox pbxBuscaCEP;
        private Label label3;
        private PictureBox pbxClima;
        private Label label4;
        private PictureBox pbxCPF;
        private Label label5;
        private PictureBox pbxCaraCoroa;
        private Label label6;
        private PictureBox pbxDestino;
        private Label label7;
        private PictureBox pbxFechar;
    }
}
