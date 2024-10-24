namespace TP_Algoritmo
{
    partial class frmInicioExitoso
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
            this.lblNivelUsuario = new System.Windows.Forms.Label();
            this.lblNivelU = new System.Windows.Forms.Label();
            this.lblNombreBD = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNivelUsuario
            // 
            this.lblNivelUsuario.AutoSize = true;
            this.lblNivelUsuario.Location = new System.Drawing.Point(144, 83);
            this.lblNivelUsuario.Name = "lblNivelUsuario";
            this.lblNivelUsuario.Size = new System.Drawing.Size(10, 13);
            this.lblNivelUsuario.TabIndex = 7;
            this.lblNivelUsuario.Text = "-";
            this.lblNivelUsuario.Click += new System.EventHandler(this.lblNivelUsuario_Click);
            // 
            // lblNivelU
            // 
            this.lblNivelU.AutoSize = true;
            this.lblNivelU.Location = new System.Drawing.Point(55, 83);
            this.lblNivelU.Name = "lblNivelU";
            this.lblNivelU.Size = new System.Drawing.Size(83, 13);
            this.lblNivelU.TabIndex = 6;
            this.lblNivelU.Text = "Usuario de nivel";
            this.lblNivelU.Click += new System.EventHandler(this.lblNivelU_Click);
            // 
            // lblNombreBD
            // 
            this.lblNombreBD.AutoSize = true;
            this.lblNombreBD.Location = new System.Drawing.Point(131, 60);
            this.lblNombreBD.Name = "lblNombreBD";
            this.lblNombreBD.Size = new System.Drawing.Size(10, 13);
            this.lblNombreBD.TabIndex = 5;
            this.lblNombreBD.Text = "-";
            this.lblNombreBD.Click += new System.EventHandler(this.lblNombreBD_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(55, 60);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(69, 13);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Bienvenido!!!";
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // frmInicioExitoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 553);
            this.Controls.Add(this.lblNivelUsuario);
            this.Controls.Add(this.lblNivelU);
            this.Controls.Add(this.lblNombreBD);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "frmInicioExitoso";
            this.Text = "InicioExitoso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivelUsuario;
        private System.Windows.Forms.Label lblNivelU;
        private System.Windows.Forms.Label lblNombreBD;
        private System.Windows.Forms.Label lblBienvenido;
    }
}