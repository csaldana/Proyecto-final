/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 06/12/2013
 * Time: 12:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Compañias
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compañias));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.butGuardar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.butSalir = new System.Windows.Forms.Button();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.textTipoSeguro = new System.Windows.Forms.TextBox();
			this.textCovertura = new System.Windows.Forms.TextBox();
			this.textPrecio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textTelefono = new System.Windows.Forms.TextBox();
			this.Correo = new System.Windows.Forms.Label();
			this.textCorreo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textid = new System.Windows.Forms.TextBox();
			this.butActualizar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Compañia";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(176, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tipo de seguro";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cobertura";
			// 
			// butGuardar
			// 
			this.butGuardar.Location = new System.Drawing.Point(104, 395);
			this.butGuardar.Name = "butGuardar";
			this.butGuardar.Size = new System.Drawing.Size(75, 23);
			this.butGuardar.TabIndex = 6;
			this.butGuardar.Text = "Guardar";
			this.butGuardar.UseVisualStyleBackColor = true;
			this.butGuardar.Click += new System.EventHandler(this.ButGuardarClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(176, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Precio";
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(590, 395);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(75, 23);
			this.butSalir.TabIndex = 9;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			this.butSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(12, 79);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(100, 20);
			this.textNombre.TabIndex = 10;
			// 
			// textTipoSeguro
			// 
			this.textTipoSeguro.Location = new System.Drawing.Point(176, 30);
			this.textTipoSeguro.Name = "textTipoSeguro";
			this.textTipoSeguro.Size = new System.Drawing.Size(100, 20);
			this.textTipoSeguro.TabIndex = 11;
			this.textTipoSeguro.TextChanged += new System.EventHandler(this.TextTipoSeguroTextChanged);
			// 
			// textCovertura
			// 
			this.textCovertura.Location = new System.Drawing.Point(12, 140);
			this.textCovertura.Name = "textCovertura";
			this.textCovertura.Size = new System.Drawing.Size(100, 20);
			this.textCovertura.TabIndex = 12;
			// 
			// textPrecio
			// 
			this.textPrecio.Location = new System.Drawing.Point(176, 79);
			this.textPrecio.Name = "textPrecio";
			this.textPrecio.Size = new System.Drawing.Size(100, 20);
			this.textPrecio.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(176, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Telefono";
			// 
			// textTelefono
			// 
			this.textTelefono.Location = new System.Drawing.Point(176, 140);
			this.textTelefono.Name = "textTelefono";
			this.textTelefono.Size = new System.Drawing.Size(100, 20);
			this.textTelefono.TabIndex = 15;
			// 
			// Correo
			// 
			this.Correo.Location = new System.Drawing.Point(330, 9);
			this.Correo.Name = "Correo";
			this.Correo.Size = new System.Drawing.Size(100, 23);
			this.Correo.TabIndex = 16;
			this.Correo.Text = "Correo";
			// 
			// textCorreo
			// 
			this.textCorreo.Location = new System.Drawing.Point(330, 30);
			this.textCorreo.Name = "textCorreo";
			this.textCorreo.Size = new System.Drawing.Size(100, 20);
			this.textCorreo.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "ID de Compañía";
			// 
			// textid
			// 
			this.textid.Location = new System.Drawing.Point(13, 30);
			this.textid.Name = "textid";
			this.textid.Size = new System.Drawing.Size(100, 20);
			this.textid.TabIndex = 19;
			// 
			// butActualizar
			// 
			this.butActualizar.Location = new System.Drawing.Point(12, 395);
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.Size = new System.Drawing.Size(75, 23);
			this.butActualizar.TabIndex = 20;
			this.butActualizar.Text = "Actualizar";
			this.butActualizar.UseVisualStyleBackColor = true;
			this.butActualizar.Click += new System.EventHandler(this.ButActualizarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 180);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(652, 209);
			this.dataGridView1.TabIndex = 21;
			// 
			// Compañias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(677, 430);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.butActualizar);
			this.Controls.Add(this.textid);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textCorreo);
			this.Controls.Add(this.Correo);
			this.Controls.Add(this.textTelefono);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textPrecio);
			this.Controls.Add(this.textCovertura);
			this.Controls.Add(this.textTipoSeguro);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.butGuardar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Compañias";
			this.Text = "Alta de Compañías";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button butActualizar;
		private System.Windows.Forms.TextBox textid;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textCorreo;
		private System.Windows.Forms.Label Correo;
		private System.Windows.Forms.TextBox textTelefono;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textPrecio;
		private System.Windows.Forms.TextBox textCovertura;
		private System.Windows.Forms.TextBox textTipoSeguro;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button butGuardar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
