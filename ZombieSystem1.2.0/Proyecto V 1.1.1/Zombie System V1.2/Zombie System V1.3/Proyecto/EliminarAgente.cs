using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto
{
	/// <summary>
	/// Description of EliminarAgente.
	/// </summary>
	public partial class EliminarAgente : Form
	{
		public EliminarAgente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void mysql()
        {
            string config = "Server=localhost;User ID= root;Database = agenciaseguro"; string query = String.Format("SELECT * FROM {0}", "cliente");

            MySqlConnection conexion = new MySqlConnection(config); conexion.Open();

            MySqlCommand comando = new MySqlCommand(query, conexion); MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            DataTable data = new DataTable(); adapter.Fill(data); dataGridView1.DataSource = data;
        }
		
		void ButListoClick(object sender, EventArgs e)
		{
			DialogResult result;
			Registros registro = new Registros();
			if(registro.eliminarAgentePorId(this.textid.Text)){
			   	result = MessageBox.Show("Operacion Realizada con exito..");
			   	this.textid.Text ="";
			   }
		}
		
		void ButSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ButActualizarClick(object sender, EventArgs e)
		{
			this.mysql();
		}
		
		void EliminarAgenteLoad(object sender, EventArgs e)
		{
			
		}
	}
}
