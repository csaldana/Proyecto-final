/*
 * Creado por SharpDevelop.
 * Usuario: jonathan
 * Fecha: 12/12/2013
 * Hora: 06:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto
{
	partial class EliminarPoliza
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
			this.butEliminar = new System.Windows.Forms.Button();
			this.butActualizar = new System.Windows.Forms.Button();
			this.ButSalir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// butEliminar
			// 
			this.butEliminar.Location = new System.Drawing.Point(13, 299);
			this.butEliminar.Name = "butEliminar";
			this.butEliminar.Size = new System.Drawing.Size(75, 23);
			this.butEliminar.TabIndex = 0;
			this.butEliminar.Text = "Eliminar";
			this.butEliminar.UseVisualStyleBackColor = true;
			this.butEliminar.Click += new System.EventHandler(this.ButEliminarClick);
			// 
			// butActualizar
			// 
			this.butActualizar.Location = new System.Drawing.Point(95, 299);
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.Size = new System.Drawing.Size(75, 23);
			this.butActualizar.TabIndex = 1;
			this.butActualizar.Text = "Actualizar";
			this.butActualizar.UseVisualStyleBackColor = true;
			this.butActualizar.Click += new System.EventHandler(this.ButActualizarClick);
			// 
			// ButSalir
			// 
			this.ButSalir.Location = new System.Drawing.Point(440, 299);
			this.ButSalir.Name = "ButSalir";
			this.ButSalir.Size = new System.Drawing.Size(75, 23);
			this.ButSalir.TabIndex = 3;
			this.ButSalir.Text = "Salir";
			this.ButSalir.UseVisualStyleBackColor = true;
			this.ButSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 105);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(502, 179);
			this.dataGridView1.TabIndex = 4;
			// 
			// textid
			// 
			this.textid.Location = new System.Drawing.Point(13, 30);
			this.textid.Name = "textid";
			this.textid.Size = new System.Drawing.Size(100, 20);
			this.textid.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Numero de Poliza";
			// 
			// EliminarPoliza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 334);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textid);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ButSalir);
			this.Controls.Add(this.butActualizar);
			this.Controls.Add(this.butEliminar);
			this.Name = "EliminarPoliza";
			this.Text = "EliminarPoliza";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textid;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button ButSalir;
		private System.Windows.Forms.Button butActualizar;
		private System.Windows.Forms.Button butEliminar;
	}
}
