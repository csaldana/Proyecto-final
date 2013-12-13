/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 10/12/2013
 * Time: 05:28 p.m.
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
	/// Description of ConsultaCliente.
	/// </summary>
	public partial class ConsultaCliente : Form
	{
		public ConsultaCliente()
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
		
		
		
		void ButActualizarClick(object sender, EventArgs e)
		{
			this.mysql();
		}
	}
	}
    