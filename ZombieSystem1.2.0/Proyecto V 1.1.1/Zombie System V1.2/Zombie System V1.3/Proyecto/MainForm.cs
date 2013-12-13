
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	public partial class MainForm : Form  {
	
            private string usuario = "Agente";
			private string contraseña = "666";
	
				public MainForm()	{
				
			InitializeComponent();
		}
		
		void Label1Click(object sender, EventArgs e)
		{	
			
	     	}
		
		void Button1Click(object sender, EventArgs e){
		
			if (textBox1.Text == usuario && textBox2.Text == contraseña)
			{
				MessageBox.Show("Bienvenido al sistema");
				
				Panel p= new Panel(); 
				p.Show();
				
				this.Visible = false;
			
			}
		
			else {
			
				MessageBox.Show("Usuario o contraseña incorrectos");
		
			}
		
		
	}
}
}