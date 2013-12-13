
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public partial class Cliente : Form
	{
		public Cliente()
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
	
		
		
		
		void Botguardar(object sender, EventArgs e)
		{
			this.insertarNuevo();
           			
		}
		private void insertarNuevo(){
			DialogResult result;
			Registros registro = new Registros();
			if(registro.insertarRegistroNuevo(this.textid.Text, this.textNombre.Text,
			                                  this.textApellp.Text , this.textapellm.Text, 
			                                 this.textEstado.Text, this.textMunicipio.Text,
			                                this.textcolonia.Text, this.textCalle.Text, 
			                               this.textNumExt.Text, this.textNumInt.Text,this.textCP.Text,
			                              this.textTelefono.Text, this.textCorreo.Text)){
				
				result = MessageBox.Show("Operacion realizada con exito");
				
				this.textid.Text = "";
				this.textNombre.Text = "";
				this.textApellp.Text = "";
				this.textapellm.Text = "";
				this.textEstado.Text = "";
				this.textMunicipio.Text = "";
				this.textcolonia.Text = "";
				this.textCalle.Text = "";
				this.textNumExt.Text = "";
				this.textNumInt.Text = "";
				this.textCP.Text = "";
				this.textTelefono.Text = "";
				this.textCorreo.Text = "";
				
			}
		
	}
		
		void Label15Click(object sender, EventArgs e)
		{
			
		}
		
		void ButSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BuActualizarClick(object sender, EventArgs e)
		{
			this.mysql();
		}
		
		void TextNumIntTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ClienteLoad(object sender, EventArgs e)
		{
			
		}
}
}
