
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Proyecto
{
	
	public partial class Polizas : Form
	{
		private string id;
		public Polizas()
		{
			
			InitializeComponent();
			
	
		}
		 
		
               

		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		public void insertarNuevo(){
			DialogResult result;
			Registros registro = new Registros();
			if(registro.insertarRegistroPoliza(this.textid.Text, this.textidAgente.Text,
			                                   this.textidCompania.Text, this.textidCliente.Text,
			                                   this.textNombre.Text, this.textApell_p.Text,
			                                   this.textApell_m.Text, this.textCalle.Text,
			                                   this.textColonia.Text, this.textNumExt.Text,
			                                   this.textNumInt.Text,this.textMunicipio.Text,
			                                   this.textEstado.Text, this.textTelefono.Text,
			                                   this.textCP.Text, this.textRFC.Text,
			                                   this.textCorreo.Text,this.textMarca.Text,this.textTipo.Text,
			                                   this.textModelo.Text, this.textSerie.Text,
			                                   this.textplacas.Text, this.textCovertura.Text,
			                                   this.textNombreCompania.Text, this.textClavevehiculo.Text)){
				
				result = MessageBox.Show("Operacion Realizada con exito");
				
				this.textid.Text = "";
				this.textidCliente.Text = "";
				this.textidCompania.Text = "";
				this.textidAgente.Text = "";
				this.textNombre.Text = "";
				this.textApell_p.Text = "";
			    this.textApell_m.Text = "";
			    this.textCalle.Text = "";
			    this.textColonia.Text = "";
			    this.textNumExt.Text = "";
			    this.textNumInt.Text = "";
			    this.textMunicipio.Text = "";
			    this.textEstado.Text ="";
			    this.textTelefono.Text = "";
			    this.textCP.Text = "";
			    this.textRFC.Text = "";
			    this.textCorreo.Text = "";
			    this.textMarca.Text = "";
			    this.textTipo.Text = "";
			    this.textModelo.Text = "";
			    this.textSerie.Text = "";
			    this.textplacas.Text = "";
			    this.textCovertura.Text = "";
			    this.textNombreCompania.Text ="";
			    this.textClavevehiculo.Text = "";
			
				
			}
			   
		}
		private void mostrardatos(){
			
			Registros registro = new Registros();
			registro reg=registro.obtenerPorid(this.textidCliente.Text);
		
			if(reg.id!=""){
				
				this.textNombre.Text = reg.Nombre;
				this.textApell_p.Text = reg.Apell_P;
				this.textApell_m.Text = reg.Apell_M;
				this.textEstado.Text = reg.Estado;
				this.textMunicipio.Text = reg.Municipio;
				this.textColonia.Text = reg.Colonia;
				this.textCalle.Text = reg.Calle;
				this.textNumExt.Text = reg.NumExt;
				this.textNumInt.Text = reg.NumInt;
				this.textCP.Text = reg.CP;
				this.textTelefono.Text = reg.Telefono;
				this.textCorreo.Text = reg.Correo;
				this.textRFC.Text = reg.RFC;
				
		    }
          

        } 
		
		public void Button7Click(object sender, EventArgs e)
		{
			this.insertarNuevo();
		}
		void Button8Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			this.mostrardatos();
		}
		
		void TextidAgenteTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
