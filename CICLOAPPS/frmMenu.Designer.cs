namespace CICLOAPPS
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxViagem = new System.Windows.Forms.PictureBox();
            this.pbxCaraCoroa = new System.Windows.Forms.PictureBox();
            this.pbxCPF = new System.Windows.Forms.PictureBox();
            this.pbxClima = new System.Windows.Forms.PictureBox();
            this.pbxBuscaCEP = new System.Windows.Forms.PictureBox();
            this.pbxCalculadora = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaraCoroa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculadora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "BUSCAR CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CLIMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "VALIDAR CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "CARA OU COROA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "VIAGEM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "SAIR";
            // 
            // pbxSair
            // 
            this.pbxSair.Image = global::CICLOAPPS.Properties.Resources.close;
            this.pbxSair.Location = new System.Drawing.Point(523, 225);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(128, 125);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 13;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // pbxViagem
            // 
            this.pbxViagem.Image = global::CICLOAPPS.Properties.Resources.route;
            this.pbxViagem.Location = new System.Drawing.Point(322, 225);
            this.pbxViagem.Name = "pbxViagem";
            this.pbxViagem.Size = new System.Drawing.Size(128, 125);
            this.pbxViagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxViagem.TabIndex = 11;
            this.pbxViagem.TabStop = false;
            // 
            // pbxCaraCoroa
            // 
            this.pbxCaraCoroa.Image = global::CICLOAPPS.Properties.Resources.coin;
            this.pbxCaraCoroa.Location = new System.Drawing.Point(121, 225);
            this.pbxCaraCoroa.Name = "pbxCaraCoroa";
            this.pbxCaraCoroa.Size = new System.Drawing.Size(128, 125);
            this.pbxCaraCoroa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCaraCoroa.TabIndex = 9;
            this.pbxCaraCoroa.TabStop = false;
            // 
            // pbxCPF
            // 
            this.pbxCPF.Image = global::CICLOAPPS.Properties.Resources.verification;
            this.pbxCPF.Location = new System.Drawing.Point(602, 25);
            this.pbxCPF.Name = "pbxCPF";
            this.pbxCPF.Size = new System.Drawing.Size(128, 125);
            this.pbxCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCPF.TabIndex = 7;
            this.pbxCPF.TabStop = false;
            // 
            // pbxClima
            // 
            this.pbxClima.Image = global::CICLOAPPS.Properties.Resources.weather;
            this.pbxClima.Location = new System.Drawing.Point(406, 25);
            this.pbxClima.Name = "pbxClima";
            this.pbxClima.Size = new System.Drawing.Size(128, 125);
            this.pbxClima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClima.TabIndex = 5;
            this.pbxClima.TabStop = false;
            // 
            // pbxBuscaCEP
            // 
            this.pbxBuscaCEP.Image = global::CICLOAPPS.Properties.Resources.search__1_;
            this.pbxBuscaCEP.Location = new System.Drawing.Point(215, 25);
            this.pbxBuscaCEP.Name = "pbxBuscaCEP";
            this.pbxBuscaCEP.Size = new System.Drawing.Size(128, 125);
            this.pbxBuscaCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscaCEP.TabIndex = 3;
            this.pbxBuscaCEP.TabStop = false;
            this.pbxBuscaCEP.Click += new System.EventHandler(this.pbxBuscaCEP_Click);
            // 
            // pbxCalculadora
            // 
            this.pbxCalculadora.Image = global::CICLOAPPS.Properties.Resources.calculator;
            this.pbxCalculadora.Location = new System.Drawing.Point(31, 25);
            this.pbxCalculadora.Name = "pbxCalculadora";
            this.pbxCalculadora.Size = new System.Drawing.Size(128, 125);
            this.pbxCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalculadora.TabIndex = 1;
            this.pbxCalculadora.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbxViagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxCaraCoroa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxClima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxBuscaCEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxCalculadora);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaraCoroa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscaCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCalculadora;
        private System.Windows.Forms.PictureBox pbxBuscaCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxClima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxCaraCoroa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxViagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.Label label7;
    }
}

