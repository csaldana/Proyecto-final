/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 05/12/2013
 * Time: 11:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Cliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
			this.label1 = new System.Windows.Forms.Label();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textApellp = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textapellm = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textFechaN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textCorreo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textCalle = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textNumInt = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textNumExt = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textCP = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textcolonia = new System.Windows.Forms.TextBox();
			this.textMunicipio = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textEstado = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.ButGuardar = new System.Windows.Forms.Button();
			this.textid = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.butSalir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(37, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(37, 69);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(151, 20);
			this.textNombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(220, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido paterno";
			// 
			// textApellp
			// 
			this.textApellp.Location = new System.Drawing.Point(220, 69);
			this.textApellp.Name = "textApellp";
			this.textApellp.Size = new System.Drawing.Size(100, 20);
			this.textApellp.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(354, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido materno";
			// 
			// textapellm
			// 
			this.textapellm.Location = new System.Drawing.Point(354, 69);
			this.textapellm.Name = "textapellm";
			this.textapellm.Size = new System.Drawing.Size(100, 20);
			this.textapellm.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(501, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Fecha de nacimiento";
			// 
			// textFechaN
			// 
			this.textFechaN.Location = new System.Drawing.Point(501, 69);
			this.textFechaN.Name = "textFechaN";
			this.textFechaN.Size = new System.Drawing.Size(100, 20);
			this.textFechaN.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(632, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Teléfono";
			// 
			// textTelefono
			// 
			this.textTelefono.Location = new System.Drawing.Point(632, 69);
			this.textTelefono.Name = "textTelefono";
			this.textTelefono.Size = new System.Drawing.Size(136, 20);
			this.textTelefono.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(37, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Correo Electrónico";
			// 
			// textCorreo
			// 
			this.textCorreo.Location = new System.Drawing.Point(37, 131);
			this.textCorreo.Name = "textCorreo";
			this.textCorreo.Size = new System.Drawing.Size(138, 20);
			this.textCorreo.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(202, 105);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Calle";
			// 
			// textCalle
			// 
			this.textCalle.Location = new System.Drawing.Point(202, 131);
			this.textCalle.Name = "textCalle";
			this.textCalle.Size = new System.Drawing.Size(136, 20);
			this.textCalle.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(474, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Número Interior";
			// 
			// textNumInt
			// 
			this.textNumInt.Location = new System.Drawing.Point(354, 131);
			this.textNumInt.Name = "textNumInt";
			this.textNumInt.Size = new System.Drawing.Size(100, 20);
			this.textNumInt.TabIndex = 17;
			this.textNumInt.TextChanged += new System.EventHandler(this.TextNumIntTextChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(354, 105);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 18;
			this.label10.Text = "Número Exterior";
			// 
			// textNumExt
			// 
			this.textNumExt.Location = new System.Drawing.Point(474, 131);
			this.textNumExt.Name = "textNumExt";
			this.textNumExt.Size = new System.Drawing.Size(100, 20);
			this.textNumExt.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(288, 171);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Código postal";
			// 
			// textCP
			// 
			this.textCP.Location = new System.Drawing.Point(288, 197);
			this.textCP.Name = "textCP";
			this.textCP.Size = new System.Drawing.Size(100, 20);
			this.textCP.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(591, 105);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "Colonia";
			// 
			// textcolonia
			// 
			this.textcolonia.Location = new System.Drawing.Point(591, 131);
			this.textcolonia.Name = "textcolonia";
			this.textcolonia.Size = new System.Drawing.Size(177, 20);
			this.textcolonia.TabIndex = 23;
			// 
			// textMunicipio
			// 
			this.textMunicipio.Location = new System.Drawing.Point(37, 197);
			this.textMunicipio.Name = "textMunicipio";
			this.textMunicipio.Size = new System.Drawing.Size(100, 20);
			this.textMunicipio.TabIndex = 24;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(37, 171);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 25;
			this.label13.Text = "Municipio";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(157, 171);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 26;
			this.label14.Text = "Estado";
			// 
			// textEstado
			// 
			this.textEstado.Location = new System.Drawing.Point(157, 197);
			this.textEstado.Name = "textEstado";
			this.textEstado.Size = new System.Drawing.Size(100, 20);
			this.textEstado.TabIndex = 27;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(628, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 28;
			// 
			// ButGuardar
			// 
			this.ButGuardar.Location = new System.Drawing.Point(672, 540);
			this.ButGuardar.Name = "ButGuardar";
			this.ButGuardar.Size = new System.Drawing.Size(75, 24);
			this.ButGuardar.TabIndex = 29;
			this.ButGuardar.Text = "Guardar";
			this.ButGuardar.UseVisualStyleBackColor = true;
			this.ButGuardar.Click += new System.EventHandler(this.Botguardar);
			// 
			// textid
			// 
			this.textid.Location = new System.Drawing.Point(105, 7);
			this.textid.Name = "textid";
			this.textid.Size = new System.Drawing.Size(68, 20);
			this.textid.TabIndex = 30;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(1, 7);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 31;
			this.label15.Text = "Número de Cliente";
			this.label15.Click += new System.EventHandler(this.Label15Click);
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(753, 540);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(75, 24);
			this.butSalir.TabIndex = 32;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			this.butSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 235);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(781, 299);
			this.dataGridView1.TabIndex = 33;
			// 
			// buActualizar
			// 
			this.buActualizar.Location = new System.Drawing.Point(591, 540);
			this.buActualizar.Name = "buActualizar";
			this.buActualizar.Size = new System.Drawing.Size(75, 24);
			this.buActualizar.TabIndex = 34;
			this.buActualizar.Text = "Actualizar";
			this.buActualizar.UseVisualStyleBackColor = true;
			this.buActualizar.Click += new System.EventHandler(this.BuActualizarClick);
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 576);
			this.Controls.Add(this.buActualizar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.textid);
			this.Controls.Add(this.ButGuardar);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textEstado);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textMunicipio);
			this.Controls.Add(this.textcolonia);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textCP);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textNumExt);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textNumInt);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textCalle);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textCorreo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textTelefono);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textFechaN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textapellm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textApellp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cliente";
			this.Text = "Alta de Clientes";
			this.Load += new System.EventHandler(this.ClienteLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buActualizar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textid;
		private System.Windows.Forms.Button ButGuardar;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textEstado;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textMunicipio;
		private System.Windows.Forms.TextBox textcolonia;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textCP;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textNumExt;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textNumInt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textCalle;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textCorreo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textTelefono;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textFechaN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textapellm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textApellp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label label1;
		
		
	}
}
