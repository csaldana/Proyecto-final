/*
 * Creado por SharpDevelop.
 * Usuario: jonathan
 * Fecha: 09/12/2013
 * Hora: 11:17 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto
{
	partial class MenuConsulta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.butConsultaCliente = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.butConsultaComania = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.butConsultapoliza = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.Consultaagente = new System.Windows.Forms.Button();
			this.butSalir = new System.Windows.Forms.Button();
			this.butActualizar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Consulta Clientes";
			// 
			// butConsultaCliente
			// 
			this.butConsultaCliente.Location = new System.Drawing.Point(13, 39);
			this.butConsultaCliente.Name = "butConsultaCliente";
			this.butConsultaCliente.Size = new System.Drawing.Size(75, 23);
			this.butConsultaCliente.TabIndex = 1;
			this.butConsultaCliente.Text = "Consultar";
			this.butConsultaCliente.UseVisualStyleBackColor = true;
			this.butConsultaCliente.Click += new System.EventHandler(this.ButConsultaClienteClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(120, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Consuta Compañia";
			// 
			// butConsultaComania
			// 
			this.butConsultaComania.Location = new System.Drawing.Point(120, 39);
			this.butConsultaComania.Name = "butConsultaComania";
			this.butConsultaComania.Size = new System.Drawing.Size(75, 23);
			this.butConsultaComania.TabIndex = 3;
			this.butConsultaComania.Text = "Consulta";
			this.butConsultaComania.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Consulta de poliza";
			// 
			// butConsultapoliza
			// 
			this.butConsultapoliza.Location = new System.Drawing.Point(12, 93);
			this.butConsultapoliza.Name = "butConsultapoliza";
			this.butConsultapoliza.Size = new System.Drawing.Size(75, 23);
			this.butConsultapoliza.TabIndex = 5;
			this.butConsultapoliza.Text = "Consulta";
			this.butConsultapoliza.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(120, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Consulta de agente";
			// 
			// Consultaagente
			// 
			this.Consultaagente.Location = new System.Drawing.Point(120, 92);
			this.Consultaagente.Name = "Consultaagente";
			this.Consultaagente.Size = new System.Drawing.Size(75, 23);
			this.Consultaagente.TabIndex = 7;
			this.Consultaagente.Text = "Consulta";
			this.Consultaagente.UseVisualStyleBackColor = true;
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(197, 226);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(75, 23);
			this.butSalir.TabIndex = 9;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			this.butSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// butActualizar
			// 
			this.butActualizar.Location = new System.Drawing.Point(105, 226);
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.Size = new System.Drawing.Size(75, 23);
			this.butActualizar.TabIndex = 10;
			this.butActualizar.Text = "Actualizar";
			this.butActualizar.UseVisualStyleBackColor = true;
			this.butActualizar.Click += new System.EventHandler(this.ButActualizarClick);
			// 
			// MenuConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 408);
			this.Controls.Add(this.butActualizar);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.Consultaagente);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.butConsultapoliza);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.butConsultaComania);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.butConsultaCliente);
			this.Controls.Add(this.label1);
			this.Name = "MenuConsulta";
			this.Text = "MenuConsulta";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button butActualizar;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.Button Consultaagente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button butConsultapoliza;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butConsultaComania;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butConsultaCliente;
		private System.Windows.Forms.Label label1;
	}
}
