/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/11/2013
 * Time: 07:08 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Panel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.butConsultas = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(41, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 100);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(219, 55);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(125, 100);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// butConsultas
			// 
			this.butConsultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butConsultas.BackgroundImage")));
			this.butConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.butConsultas.Location = new System.Drawing.Point(397, 55);
			this.butConsultas.Name = "butConsultas";
			this.butConsultas.Size = new System.Drawing.Size(125, 100);
			this.butConsultas.TabIndex = 2;
			this.butConsultas.UseVisualStyleBackColor = true;
			this.butConsultas.Click += new System.EventHandler(this.ButConsultasClick);
			// 
			// button4
			// 
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.Location = new System.Drawing.Point(126, 200);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(125, 100);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.Location = new System.Drawing.Point(307, 200);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(125, 100);
			this.button5.TabIndex = 4;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.Location = new System.Drawing.Point(437, 320);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(125, 100);
			this.button6.TabIndex = 5;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(84, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Captura";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(235, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Registro de pagos";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(437, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Consultas";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(164, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Reportes";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(345, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Catálogo";
			// 
			// Panel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 432);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.butConsultas);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Panel";
			this.Text = "Menú principal";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button butConsultas;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
