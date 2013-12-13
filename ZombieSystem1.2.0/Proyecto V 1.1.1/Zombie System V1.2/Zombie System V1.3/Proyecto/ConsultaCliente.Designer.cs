/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 10/12/2013
 * Time: 05:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class ConsultaCliente
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.butSalir = new System.Windows.Forms.Button();
			this.butActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 107);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(498, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(296, 263);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(75, 23);
			this.butSalir.TabIndex = 1;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			// 
			// butActualizar
			// 
			this.butActualizar.Location = new System.Drawing.Point(215, 263);
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.Size = new System.Drawing.Size(75, 23);
			this.butActualizar.TabIndex = 2;
			this.butActualizar.Text = "Actualizar";
			this.butActualizar.UseVisualStyleBackColor = true;
			this.butActualizar.Click += new System.EventHandler(this.ButActualizarClick);
			// 
			// ConsultaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 302);
			this.Controls.Add(this.butActualizar);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ConsultaCliente";
			this.Text = "ConsultaCliente";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button butActualizar;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
