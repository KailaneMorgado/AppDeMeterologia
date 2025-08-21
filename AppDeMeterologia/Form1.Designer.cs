namespace AppDeMeterologia
{
    partial class fmTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTela));
            this.lblClima = new System.Windows.Forms.Label();
            this.lblGraus = new System.Windows.Forms.Label();
            this.txbClima = new System.Windows.Forms.TextBox();
            this.picboxClima = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClima
            // 
            this.lblClima.AutoSize = true;
            this.lblClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClima.Location = new System.Drawing.Point(110, 29);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(385, 31);
            this.lblClima.TabIndex = 0;
            this.lblClima.Text = "Digite a Temperatura em °C:";
            // 
            // lblGraus
            // 
            this.lblGraus.AutoSize = true;
            this.lblGraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraus.Location = new System.Drawing.Point(152, 121);
            this.lblGraus.Name = "lblGraus";
            this.lblGraus.Size = new System.Drawing.Size(53, 31);
            this.lblGraus.TabIndex = 1;
            this.lblGraus.Text = "°C:";
            // 
            // txbClima
            // 
            this.txbClima.Location = new System.Drawing.Point(238, 133);
            this.txbClima.Name = "txbClima";
            this.txbClima.Size = new System.Drawing.Size(106, 20);
            this.txbClima.TabIndex = 2;
            this.txbClima.TextChanged += new System.EventHandler(this.txbClima_TextChanged);
            this.txbClima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbClima_KeyDown_1);
            this.txbClima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClima_KeyPress);
            // 
            // picboxClima
            // 
            this.picboxClima.Location = new System.Drawing.Point(190, 196);
            this.picboxClima.Name = "picboxClima";
            this.picboxClima.Size = new System.Drawing.Size(211, 192);
            this.picboxClima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxClima.TabIndex = 3;
            this.picboxClima.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(205, 405);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(14, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = " ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificar.Location = new System.Drawing.Point(253, 158);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click_1);
            // 
            // fmTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 464);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.picboxClima);
            this.Controls.Add(this.txbClima);
            this.Controls.Add(this.lblGraus);
            this.Controls.Add(this.lblClima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clima";
            ((System.ComponentModel.ISupportInitialize)(this.picboxClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.Label lblGraus;
        private System.Windows.Forms.TextBox txbClima;
        private System.Windows.Forms.PictureBox picboxClima;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnVerificar;
    }
}

