/*
 * Creado por SharpDevelop.
 * Usuario: jonathan
 * Fecha: 09/12/2013
 * Hora: 11:17 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of MenuConsulta.
	/// </summary>
	public partial class MenuConsulta : Form
	{
		public MenuConsulta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ButActualizarClick(object sender, EventArgs e)
		{
			
		}
		
		void ButConsultaClienteClick(object sender, EventArgs e)
		{
			ConsultaCliente cliente = new ConsultaCliente();
			cliente.Show();
}
	}
}
