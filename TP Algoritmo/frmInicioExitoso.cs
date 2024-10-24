using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Algoritmo
{
    public partial class frmInicioExitoso : Form
    {
        public frmInicioExitoso()
        {
            InitializeComponent();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void lblNivelU_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreBD_Click(object sender, EventArgs e)
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

                        }

                    //mostrar el nombre de usuario
                }
            }
            finally
            {

            }
            }

        private void lblNivelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
