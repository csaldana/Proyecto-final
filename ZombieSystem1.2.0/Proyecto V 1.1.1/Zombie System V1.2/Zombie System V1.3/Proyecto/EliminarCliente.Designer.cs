/*
 * Creado por SharpDevelop.
 * Usuario: jonathan
 * Fecha: 09/12/2013
 * Hora: 02:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto
{
	partial class EliminarCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCliente));
			this.textid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.butListo = new System.Windows.Forms.Button();
			this.butSalir = new System.Windows.Forms.Button();
			this.butActualizar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textid
			// 
			this.textid.Location = new System.Drawing.Point(12, 54);
			this.textid.Name = "textid";
			this.textid.Size = new System.Drawing.Size(100, 20);
			this.textid.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID de Cliente";
			// 
			// butListo
			// 
			this.butListo.Location = new System.Drawing.Point(93, 324);
			this.butListo.Name = "butListo";
			this.butListo.Size = new System.Drawing.Size(75, 23);
			this.butListo.TabIndex = 2;
			this.butListo.Text = "Eliminar";
			this.butListo.UseVisualStyleBackColor = true;
			this.butListo.Click += new System.EventHandler(this.ButListoClick);
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(488, 324);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(75, 23);
			this.butSalir.TabIndex = 3;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			this.butSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// butActualizar
			// 
			this.butActualizar.Location = new System.Drawing.Point(12, 324);
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.Size = new System.Drawing.Size(75, 23);
			this.butActualizar.TabIndex = 4;
			this.butActualizar.Text = "Actualizar";
			this.butActualizar.UseVisualStyleBackColor = true;
			this.butActualizar.Click += new System.EventHandler(this.ButActualizarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 80);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(551, 238);
			this.dataGridView1.TabIndex = 5;
			// 
			// EliminarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 359);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.butActualizar);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.butListo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EliminarCliente";
			this.Text = "Eliminar Cliente";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button butActualizar;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.Button butListo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textid;
	}
}
