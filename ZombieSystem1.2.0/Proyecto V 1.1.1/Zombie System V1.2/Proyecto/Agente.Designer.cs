/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 06/12/2013
 * Time: 12:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Agente
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
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textApellp = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textApellm = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textTelefono = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textCorreo = new System.Windows.Forms.TextBox();
			this.butGuardaAgente = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textid = new System.Windows.Forms.TextBox();
			this.butSalir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.butActualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(102, 54);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(100, 20);
			this.textNombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido paterno";
			// 
			// textApellp
			// 
			this.textApellp.Location = new System.Drawing.Point(102, 89);
			this.textApellp.Name = "textApellp";
			this.textApellp.Size = new System.Drawing.Size(100, 20);
			this.textApellp.TabIndex = 3;
			this.textApellp.TextChanged += new System.EventHandler(this.TextApellpTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(268, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido Materno";
			// 
			// textApellm
			// 
			this.textApellm.Location = new System.Drawing.Point(374, 10);
			this.textApellm.Name = "textApellm";
			this.textApellm.Size = new System.Drawing.Size(100, 20);
			this.textApellm.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(268, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Teléfono";
			// 
			// textTelefono
			// 
			this.textTelefono.Location = new System.Drawing.Point(374, 48);
			this.textTelefono.Name = "textTelefono";
			this.textTelefono.Size = new System.Drawing.Size(100, 20);
			this.textTelefono.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(268, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Correo electrónico";
			// 
			// textCorreo
			// 
			this.textCorreo.Location = new System.Drawing.Point(374, 83);
			this.textCorreo.Name = "textCorreo";
			this.textCorreo.Size = new System.Drawing.Size(100, 20);
			this.textCorreo.TabIndex = 9;
			// 
			// butGuardaAgente
			// 
			this.butGuardaAgente.Location = new System.Drawing.Point(93, 460);
			this.butGuardaAgente.Name = "butGuardaAgente";
			this.butGuardaAgente.Size = new System.Drawing.Size(75, 23);
			this.butGuardaAgente.TabIndex = 10;
			this.butGuardaAgente.Text = "Guargar";
			this.butGuardaAgente.UseVisualStyleBackColor = true;
			this.butGuardaAgente.Click += new System.EventHandler(this.ButGuardaAgenteClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "ID de Agente";
			// 
			// textid
			// 
			this.textid.Location = new System.Drawing.Point(102, 13);
			this.textid.Name = "textid";
			this.textid.Size = new System.Drawing.Size(100, 20);
			this.textid.TabIndex = 12;
			// 
			// butSalir
			// 
			this.butSalir.Location = new System.Drawing.Point(633, 460);
			this.butSalir.Name = "butSalir";
			this.butSalir.Size = new System.Drawing.Size(75, 23);
			this.butSalir.TabIndex = 13;
			this.butSalir.Text = "Salir";
			this.butSalir.UseVisualStyleBackColor = true;
			this.butSalir.Click += new System.EventHandler(this.ButSalirClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(24, 155);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(684, 288);
			this.dataGridView1.TabIndex = 14;
			// 
			// butActualizar
			// 
			this.butActualizar.Location = new System.Drawing.Point(12, 460);
			this.butActualizar.Name = "butActualizar";
			this.butActualizar.Size = new System.Drawing.Size(75, 23);
			this.butActualizar.TabIndex = 15;
			this.butActualizar.Text = "Actualizar";
			this.butActualizar.UseVisualStyleBackColor = true;
			this.butActualizar.Click += new System.EventHandler(this.ButActualizarClick);
			// 
			// Agente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(720, 495);
			this.Controls.Add(this.butActualizar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.butSalir);
			this.Controls.Add(this.textid);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.butGuardaAgente);
			this.Controls.Add(this.textCorreo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textTelefono);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textApellm);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textApellp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "Agente";
			this.Text = "Alta de Agentes";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button butActualizar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button butSalir;
		private System.Windows.Forms.TextBox textid;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button butGuardaAgente;
		private System.Windows.Forms.TextBox textCorreo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textTelefono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textApellm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textApellp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label label1;
	}
}
