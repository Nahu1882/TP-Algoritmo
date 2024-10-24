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
    public partial class frmRecupero : Form
    {
        public frmRecupero()
        {
            InitializeComponent();
            btnEnviar.Enabled = false;
        }
        public void MsgError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                MsgError("Complete el campo correo");
                return;
            }
            else if (txtCodigo.Text != "261")
            {
                if (txtCodigo.Text == "")
                {
                    MsgError("Complete el campo codigo");
                    return;
                }
                else
                {
                    MsgError("el codigo es incorrecto");
                    return;
                }
            }
            else if (txtNewPass.Text == "")
            {
                MsgError("Complete el campo nueva contraseña");
                return;
            }
            else if (!Regex.IsMatch(txtNewPass.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$"))
            {
                MsgError("La contraseña debe contener al menos una mayúscula, una minúscula, un número y un carácter especial");
                return;
            }
            else if (txtRepeatNewPass.Text == "")
            {
                MsgError("Complete el campo repetir contraseña");
                return;
            }

            if (txtNewPass.Text != txtRepeatNewPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            else
            {
                MessageBox.Show("nueva contraseña fue registrada exitosamente.");
                this.Close();

                frmLogin frmVolverLogin = new frmLogin();
                this.Hide();
                frmVolverLogin.Show();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string Cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database1.accdb";

                OleDbConnection oConn = new OleDbConnection(Cadena);
                oConn = new OleDbConnection(Cadena);

                oConn.Open();
                string query = "SELECT Email, Contraseña FROM BDLogin";

                using (OleDbCommand command = new OleDbCommand(query, oConn))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())

                        if (reader.Read())
                        {
                            string email = reader["Email"].ToString();
                            if (email == txtMail.Text)
                            {
                                MessageBox.Show("El codigo es 261");
                            }
                        }
                }
                oConn.Close();
            }
            finally
            {

            }
            try
            {
                string Cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Database1.accdb";

                OleDbConnection oConn = new OleDbConnection(Cadena);
                oConn = new OleDbConnection(Cadena);

                oConn.Open();

                string query = "Update BDLogin SET Contraseña = ?";

                using (OleDbCommand command = new OleDbCommand(query, oConn))
                {
                    command.Parameters.AddWithValue("@Contraseña", txtNewPass.Text);
                }
            }
            finally
            {

            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text.Contains("@") && txtMail.Text.Contains("."))
            {
                btnEnviar.Enabled = true;
            }

        }
    }
}
