using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto
{
	/// <summary>
	/// Description of Agente.
	/// </summary>
	public partial class Agente : Form
	{
		public Agente()
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
            string config = "Server=localhost;User ID= root;Database = agenciaseguro"; string query = String.Format("SELECT * FROM {0}", "agente");

            MySqlConnection conexion = new MySqlConnection(config); conexion.Open();

            MySqlCommand comando = new MySqlCommand(query, conexion); MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            DataTable data = new DataTable(); adapter.Fill(data); dataGridView1.DataSource = data;
        }
		
		void ButGuardaAgenteClick(object sender, EventArgs e)
		{
			this.insertarNuevo();
		}
		private void  insertarNuevo(){
			DialogResult result;
			Registros registro = new Registros();
			if(registro.insertarRegistroAgente(this.textid.Text, this.textNombre.Text, 
			                                   this.textApellp.Text, this.textApellm.Text, 
			                                   this.textTelefono.Text, this.textCorreo.Text)){
				
				result = MessageBox.Show("Operacion realizada con exito..");
				
				this.textid.Text = "";
				this.textNombre.Text = "";
				this.textApellp.Text = "";
				this.textApellm.Text = "";
				this.textTelefono.Text = "";
				this.textCorreo.Text = "";
			}
		}
		
		void TextApellpTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ButSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ButActualizarClick(object sender, EventArgs e)
		{
			this.mysql();
		}
	}
}
