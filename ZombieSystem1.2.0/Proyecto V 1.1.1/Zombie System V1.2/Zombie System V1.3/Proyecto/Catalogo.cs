/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 05/12/2013
 * Time: 11:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of Catalogo.
	/// </summary>
	public partial class Catalogo : Form
	{
		public Catalogo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			MenuBajas bajas = new MenuBajas();
			bajas.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			cliente.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Compañias companias = new Compañias();
			companias.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Agente agente = new Agente();
			agente.Show();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
