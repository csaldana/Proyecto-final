using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public class MySql
    {
        protected MySqlConnection myConnection;

        public MySql()
        {
        }
        protected void abrirConexion()
        {
            string connectionString =
                "Server=localhost;" +
                "Database = agenciaseguro;" +
                "User = root;" +
                "Password = ;" +
                "Pooling = false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }

        protected void cerrarConexion()
        {

            this.myConnection.Close();
            this.myConnection = null;
        }
    }
}
