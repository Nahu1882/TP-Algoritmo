using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_Algoritmo
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        public void MsgError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistro frmLlevarARegistro = new frmRegistro();
            this.Hide();
            frmLlevarARegistro.Show();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtCorreoNombre.Clear();
            txtPass.Clear();
        }

        private void btnIncicio_Click(object sender, EventArgs e)
        {

            string usuario = txtCorreoNombre.Text;
            string contrasena = txtPass.Text;

            if (txtCorreoNombre.Text == "")
            {
                MsgError("Complete el campo correo");
            }
            else if (txtPass.Text == "")
            {
                MsgError("Complete el campo contraseña");
            }


            try
            {
                Conexion oConn = new Conexion();

                oConn.OpenConnection();

                string query = "SELECT Email, Contraseña FROM BDLogin";

                using (OleDbCommand command = new OleDbCommand(query, oConn))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())

                        if (reader.Read())
                        {
                            string email = reader["Email"].ToString();
                            string contraseña = reader["Contraseña"].ToString();
                            if (txtCorreoNombre.Text == email && txtPass.Text == contraseña)
                            {
                                frmInicioExitoso frmInicioCorrecto = new frmInicioExitoso();
                                this.Hide();
                                frmInicioCorrecto.Show();
                            }
                            else if (txtCorreoNombre.Text != email && txtPass.Text == contraseña)
                            {
                                MessageBox.Show("el mail ingresado es incorrecto");
                                txtCorreoNombre.Clear();
                                txtPass.Clear();
                            }
                            else if (txtCorreoNombre.Text == email && txtPass.Text != contraseña)
                            {
                                MessageBox.Show("la contraseña ingresada es incorrecta");
                                txtCorreoNombre.Clear();
                                txtPass.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("los datos ingresados son incorrectos");
                            txtCorreoNombre.Clear();
                            txtPass.Clear();
                        }
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }


            private void btnRecuperar_Click(object sender, EventArgs e)
        {
            frmRecupero frmRecuperacion = new frmRecupero();
            this.Hide();
            frmRecuperacion.Show();
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    } 
}
