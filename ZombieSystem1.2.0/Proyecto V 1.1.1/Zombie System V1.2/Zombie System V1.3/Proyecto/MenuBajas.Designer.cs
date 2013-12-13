/*
 * Creado por SharpDevelop.
 * Usuario: jonathan
 * Fecha: 09/12/2013
 * Hora: 02:40 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto
{
	partial class MenuBajas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBajas));
			this.label1 = new System.Windows.Forms.Label();
			this.butEliminarCliente = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.butEliminarPoliza = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.butEliminarAgente = new System.Windows.Forms.Button();
			this.butSalir = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.butEliminarComapania = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Eliminar Cliente";
			// 
			// butEliminarCliente
			// 
			this.butEliminarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEliminarCliente.BackgroundImage")));
			this.butEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.butEliminarCliente.Location = new System.Drawing.Point(12, 39);
			this.butEliminarCliente.Name = "butEliminarCliente";
			this.butEliminarCliente.Size = new System.Drawing.Size(125, 100);
			this.butEliminarCliente.TabIndex = 1;
			this.butEliminarCliente.UseVisualStyleBackColor = true;
			this.butEliminarCliente.Click += new System.EventHandler(this.ButEliminarClienteClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(195, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Eliminar Poliza";
			// 
			// butEliminarPoliza
			// 
			this.butEliminarPoliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEliminarPoliza.BackgroundImage")));
			this.butEliminarPoliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.butEliminarPoliza.Location = new System.Drawing.Point(195, 39);
			this.butEliminarPoliza.Name = "butEliminarPoliza";
			this.butEliminarPoliza.Size = new System.Drawing.Size(125, 100);
			this.butEliminarPoliza.TabIndex = 3;
			this.butEliminarPoliza.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Eliminar agente";
			// 
			// butEliminarAgente
			// 
			this.butEliminarAgente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEliminarAgente.BackgroundImage")));
			this.butEliminarAgente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.butEliminarAgente.Location = new System.Drawing.Point(12, 185);
			this.butEliminarAgente.Name = "butEliminarAgente";
			this.butEliminarAgente.Size = new System.Drawing.Size(125, 100);
			this.butEliminarAgente.TabIndex = 6;
			this.butEliminarAgente.UseVisualStyleBackColor = true;
			this.butEliminarAgente.Click += new System.EventHandler(this.ButEliminarAgenteClick);
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(327, 324);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(80, 30);
			this.butSalir.TabIndex = 7;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			this.butSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(195, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Eliminar Compañia";
			// 
			// butEliminarComapania
			// 
			this.butEliminarComapania.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butEliminarComapania.BackgroundImage")));
			this.butEliminarComapania.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.butEliminarComapania.Location = new System.Drawing.Point(195, 185);
			this.butEliminarComapania.Name = "butEliminarComapania";
			this.butEliminarComapania.Size = new System.Drawing.Size(125, 100);
			this.butEliminarComapania.TabIndex = 9;
			this.butEliminarComapania.UseVisualStyleBackColor = true;
			this.butEliminarComapania.Click += new System.EventHandler(this.ButEliminarComapaniaClick);
			// 
			// MenuBajas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 366);
			this.Controls.Add(this.butEliminarComapania);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.butEliminarAgente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.butEliminarPoliza);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.butEliminarCliente);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MenuBajas";
			this.Text = "Menú de Bajas";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button butEliminarComapania;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.Button butEliminarAgente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button butEliminarPoliza;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butEliminarCliente;
		private System.Windows.Forms.Label label1;
	}
}
