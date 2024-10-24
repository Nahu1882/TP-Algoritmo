using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmo
{
    public class ConsultasGenericas
    {
        public DataTable ObtenerUsuario(string usuario, string contrasena)
        {
            using (OleDbConnection connection = new Conexion().GetConnection())
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(query, oConn))
                    //    {
                    //        using (OleDbDataReader reader = command.ExecuteReader())

                    //            if (reader.Read())
                    //            {
                    //                string email = reader["Email"].ToString();
                    //                string contraseña = reader["Contraseña"].ToString();
                    //                if (txtCorreoNombre.Text == email && txtPass.Text == contraseña)
                    //                {
                    //                    frmInicioExitoso frmInicioCorrecto = new frmInicioExitoso();
                    //                    this.Hide();
                    //                    frmInicioCorrecto.Show();
                    //                }
                    //                else if (txtCorreoNombre.Text != email && txtPass.Text == contraseña)
                    //                {
                    //                    MessageBox.Show("el mail ingresado es incorrecto");
                    //                    txtCorreoNombre.Clear();
                    //                    txtPass.Clear();
                    //                }
                    //                else if (txtCorreoNombre.Text == email && txtPass.Text != contraseña)
                    //                {
                    //                    MessageBox.Show("la contraseña ingresada es incorrecta");
                    //                    txtCorreoNombre.Clear();
                    //                    txtPass.Clear();
                    //                }
                    //            }
                    //            else
                    //            {
                    //                MessageBox.Show("los datos ingresados son incorrectos");
                    //                txtCorreoNombre.Clear();
                    //                txtPass.Clear();
                    //            }
                    //        Consol
                    string consulta = "SELECT Email, Contraseña FROM BDLogin";
                using (OleDbCommand command = new OleDbCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    DataTable dataTable = new DataTable();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }
        //public bool VerifyLogin(string email, string password)
        //{
        //    using (SqlConnection connection = OpenConnection())
        //    {
        //        if (connection != null)
        //        {
        //            try
        //            {
        //                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";

        //                using (SqlCommand cmd = new SqlCommand(query, connection))
        //                {
        //                    // Parámetros para evitar inyecciones SQL
        //                    cmd.Parameters.AddWithValue("@Email", email);
        //                    cmd.Parameters.AddWithValue("@Password", password);

        //                    int userCount = (int)cmd.ExecuteScalar();

        //                    return userCount > 0; // Devuelve true si existe un usuario con ese email y contraseña
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("Error en la verificación del login: " + ex.Message);
        //                return false;
        //            }
        //            finally
        //            {
        //                CloseConnection(connection);
        //            }
        //        }
        //        return false;
        //    }
    }
    }

