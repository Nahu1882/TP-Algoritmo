using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_Algoritmo
{
    public partial class frmRegistro : Form
    {

        public frmRegistro()
        {
            InitializeComponent();
        }
        public void MsgError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MsgError("Complete el campo nombre");
                return;
            }
            else if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
            {
                MsgError("El nombre solo debe contener letras");
                return;
            }
            else if (txtApellido.Text == "")
            {
                MsgError("Complete el campo texto");
                return;
            }
            else if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z]+$"))
            {
                MsgError("El apellido solo debe contener letras");
                return;
            }
            else if (txtNombreUsuario.Text == "")
            {
                MsgError("Complete el campo nombre de usuario");
                return;
            }
            else if (txtMail.Text == "")
            {
                MsgError("Complete el campo correo electronico");
                return;
            }
            else if (!txtMail.Text.Contains("@") || !txtMail.Text.Contains("."))
            {
                MsgError("ingresó un correo electronico no valido");
                return;
            }
            else if (txtPass.Text == "")
            {
                MsgError("Complete el campo contraseña");
                return;
            }
            else if(!Regex.IsMatch(txtPass.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                MsgError("La contraseña debe contener al menos una mayúscula, una minúscula, un número y un carácter especial");
                return;
            }
            else if (txtRepeatPass.Text == "")
            {
                MsgError("Complete el campo repetir contraseña");
                return;
            }

            if (txtPass.Text != txtRepeatPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string NombreUsuario = txtNombreUsuario.Text;
            string Email = txtMail.Text;
            string Contraseña = txtPass.Text;
            string TipoDeUsuario = "cliente";
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;

            string Cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database1.accdb";

            OleDbConnection oConn = new OleDbConnection(Cadena);
            oConn = new OleDbConnection(Cadena);

            try
            {
                oConn.Open();
                string query = "INSERT INTO BDLogin (NombreUsuario, Email, Contraseña, TipoDeUsuario, Nombre, Apellido) VALUES (?, ?, ?, ?, ?, ?)";

                using (OleDbCommand command = new OleDbCommand(query, oConn))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Contraseña", Contraseña);
                    command.Parameters.AddWithValue("@TipoDeUsuario", TipoDeUsuario);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);


                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreUsuario = reader["NombreUsuario"].ToString();
                            string email = reader["Email"].ToString();
                            string contraseña = reader["Contraseña"].ToString();
                            string tipoDeUsuario = reader["TipoDeUsuario"].ToString();

                            MessageBox.Show($"Nombre: {nombreUsuario}, Email: {email}, Contraseña: {contraseña}, tipoDeUsuario: {tipoDeUsuario}");
                        }
                    }
                }

                MessageBox.Show("Conectado a la base de datos.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            oConn.Close();


            MessageBox.Show("Usuario registrado exitosamente.");
            this.Close();

            frmLogin frmVolverLogin = new frmLogin();
            this.Hide();
            frmVolverLogin.Show();


        }
    }
}
