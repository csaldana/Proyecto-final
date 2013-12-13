using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of MenuBajas.
	/// </summary>
	public partial class MenuBajas : Form
	{
		public MenuBajas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButEliminarClienteClick(object sender, EventArgs e)
		{
			EliminarCliente cliente = new EliminarCliente();
			cliente.Show();
		}
		
		void ButEliminarAgenteClick(object sender, EventArgs e)
		{
			EliminarAgente agente = new EliminarAgente();
			agente.Show();
		}
		
		void ButSalirClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
		
		void ButEliminarComapaniaClick(object sender, EventArgs e)
		{
			EliminarCompanias companias = new EliminarCompanias();
			companias.Show();
		}
	}
}
