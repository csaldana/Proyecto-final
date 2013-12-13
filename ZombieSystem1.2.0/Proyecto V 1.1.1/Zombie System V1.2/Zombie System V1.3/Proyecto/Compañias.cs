/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 06/12/2013
 * Time: 12:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto
{
	/// <summary>
	/// Description of Compañias.
	/// </summary>
	public partial class Compañias : Form
	{
		public Compañias()
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
		
		void ButSalirClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
		
		void ButGuardarClick(object sender, EventArgs e)
		{
			this.insertarNuevo();
		}
		
		private void insertarNuevo(){
			DialogResult result;
			Registros registro = new Registros();
			if(registro.insertarRegistroCompanias(this.textid.Text, this.textNombre.Text,
			                                      this.textTelefono.Text, this.textCorreo.Text,
			                                     this.textTipoSeguro.Text, this.textCovertura.Text,
			                                    this.textPrecio.Text)){
				result = MessageBox.Show("Operacion realizada con exito..");
				
				this.textid.Text = "";
				this.textNombre.Text ="";
				this.textTelefono.Text ="";
				this.textCorreo.Text = "";
				this.textTipoSeguro.Text = "";
				this.textCovertura.Text = "";
				this.textPrecio.Text = "";
				
				
			}
		}
		
		void ButActualizarClick(object sender, EventArgs e)
		{
			this.mysql();
		}
		
		void TextTipoSeguroTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
