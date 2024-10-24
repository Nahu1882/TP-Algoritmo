namespace TP_Algoritmo
{
    partial class frmRegistro
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(187, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(60, 111);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(227, 20);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(59, 149);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(227, 20);
            this.txtMail.TabIndex = 3;
            this.txtMail.Text = "Correo elecronico";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(60, 187);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(227, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "Contraseña";
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(60, 228);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(227, 20);
            this.txtRepeatPass.TabIndex = 5;
            this.txtRepeatPass.Text = "Repetir contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(211, 270);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 379);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}