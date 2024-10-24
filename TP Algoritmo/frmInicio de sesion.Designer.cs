namespace TP_Algoritmo
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIncicio = new System.Windows.Forms.Button();
            this.txtCorreoNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEresNuevo = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(49, 39);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(93, 13);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electronico";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(49, 84);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIncicio
            // 
            this.btnIncicio.Location = new System.Drawing.Point(427, 112);
            this.btnIncicio.Name = "btnIncicio";
            this.btnIncicio.Size = new System.Drawing.Size(89, 23);
            this.btnIncicio.TabIndex = 2;
            this.btnIncicio.Text = "Iniciar sesion";
            this.btnIncicio.UseVisualStyleBackColor = true;
            this.btnIncicio.Click += new System.EventHandler(this.btnIncicio_Click);
            // 
            // txtCorreoNombre
            // 
            this.txtCorreoNombre.Location = new System.Drawing.Point(183, 39);
            this.txtCorreoNombre.Name = "txtCorreoNombre";
            this.txtCorreoNombre.Size = new System.Drawing.Size(268, 20);
            this.txtCorreoNombre.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(183, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(268, 20);
            this.txtPass.TabIndex = 4;
            // 
            // lblEresNuevo
            // 
            this.lblEresNuevo.AutoSize = true;
            this.lblEresNuevo.Location = new System.Drawing.Point(351, 223);
            this.lblEresNuevo.Name = "lblEresNuevo";
            this.lblEresNuevo.Size = new System.Drawing.Size(72, 13);
            this.lblEresNuevo.TabIndex = 5;
            this.lblEresNuevo.Text = "Eres nuev@?";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(441, 218);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrate";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(49, 177);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(142, 13);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Has olvidado la contraseña?";
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.Location = new System.Drawing.Point(197, 172);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar.TabIndex = 8;
            this.btnRecuperar.Text = "Recuperar";
            this.btnRecuperar.UseVisualStyleBackColor = true;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // picBox1
            // 
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.Location = new System.Drawing.Point(457, 76);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(37, 21);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 10;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 273);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblEresNuevo);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCorreoNombre);
            this.Controls.Add(this.btnIncicio);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Name = "frmLogin";
            this.Text = "Incio de sesion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIncicio;
        private System.Windows.Forms.TextBox txtCorreoNombre;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEresNuevo;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBox1;
    }
}

