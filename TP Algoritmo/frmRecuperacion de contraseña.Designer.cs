namespace TP_Algoritmo
{
    partial class frmRecupero
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtRepeatNewPass = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(64, 54);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(251, 20);
            this.txtMail.TabIndex = 0;
            this.txtMail.Text = "Correo electronico (asociado a la cuenta)";
            this.txtMail.UseWaitCursor = true;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(64, 91);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(250, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "Codigo de seguridad enviado al correo";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(64, 128);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(132, 20);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.Text = "Nueva Contraseña";
            // 
            // txtRepeatNewPass
            // 
            this.txtRepeatNewPass.Location = new System.Drawing.Point(64, 164);
            this.txtRepeatNewPass.Name = "txtRepeatNewPass";
            this.txtRepeatNewPass.Size = new System.Drawing.Size(132, 20);
            this.txtRepeatNewPass.TabIndex = 3;
            this.txtRepeatNewPass.Text = "Repetir contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(239, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guargar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(322, 54);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(52, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmRecupero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 310);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRepeatNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtMail);
            this.Name = "frmRecupero";
            this.Text = "Recupero de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtRepeatNewPass;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEnviar;
    }
}