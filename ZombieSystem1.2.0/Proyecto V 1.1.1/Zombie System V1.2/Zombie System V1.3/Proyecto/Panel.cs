
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	
	public partial class Panel : Form
	{
		
		
		public Panel()
		{
			
			InitializeComponent();
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
            Polizas poliza = new Polizas();
            poliza.Show();
            
            
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Reportes reportes = new Reportes();
			reportes.Show();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Catalogo catalogo = new Catalogo();
			catalogo.Show();
			
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		void ButConsultasClick(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Reegistros registro = new Reegistros();
			registro.Show();
		}
	}
}
