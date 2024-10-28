/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 24/10/2024
 * Time: 07:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoMA
{
	partial class MainForm
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
			this.Btnmatematicas = new System.Windows.Forms.Button();
			this.Btningles = new System.Windows.Forms.Button();
			this.Btnfisica = new System.Windows.Forms.Button();
			this.Btnmateria1 = new System.Windows.Forms.Button();
			this.Btnmateria2 = new System.Windows.Forms.Button();
			this.Lblmaterias = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btnmatematicas
			// 
			this.Btnmatematicas.Location = new System.Drawing.Point(196, 62);
			this.Btnmatematicas.Name = "Btnmatematicas";
			this.Btnmatematicas.Size = new System.Drawing.Size(105, 38);
			this.Btnmatematicas.TabIndex = 0;
			this.Btnmatematicas.Text = "Matematicas";
			this.Btnmatematicas.UseVisualStyleBackColor = true;
			// 
			// Btningles
			// 
			this.Btningles.Location = new System.Drawing.Point(196, 106);
			this.Btningles.Name = "Btningles";
			this.Btningles.Size = new System.Drawing.Size(105, 38);
			this.Btningles.TabIndex = 1;
			this.Btningles.Text = "Ingles";
			this.Btningles.UseVisualStyleBackColor = true;
			this.Btningles.Click += new System.EventHandler(this.BtninglesClick);
			// 
			// Btnfisica
			// 
			this.Btnfisica.Location = new System.Drawing.Point(196, 150);
			this.Btnfisica.Name = "Btnfisica";
			this.Btnfisica.Size = new System.Drawing.Size(105, 38);
			this.Btnfisica.TabIndex = 2;
			this.Btnfisica.Text = "Fisica";
			this.Btnfisica.UseVisualStyleBackColor = true;
			// 
			// Btnmateria1
			// 
			this.Btnmateria1.Location = new System.Drawing.Point(196, 194);
			this.Btnmateria1.Name = "Btnmateria1";
			this.Btnmateria1.Size = new System.Drawing.Size(105, 38);
			this.Btnmateria1.TabIndex = 3;
			this.Btnmateria1.Text = "Materia 1";
			this.Btnmateria1.UseVisualStyleBackColor = true;
			// 
			// Btnmateria2
			// 
			this.Btnmateria2.Location = new System.Drawing.Point(196, 238);
			this.Btnmateria2.Name = "Btnmateria2";
			this.Btnmateria2.Size = new System.Drawing.Size(105, 38);
			this.Btnmateria2.TabIndex = 4;
			this.Btnmateria2.Text = "Materia 2";
			this.Btnmateria2.UseVisualStyleBackColor = true;
			// 
			// Lblmaterias
			// 
			this.Lblmaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblmaterias.Location = new System.Drawing.Point(201, 18);
			this.Lblmaterias.Name = "Lblmaterias";
			this.Lblmaterias.Size = new System.Drawing.Size(100, 23);
			this.Lblmaterias.TabIndex = 5;
			this.Lblmaterias.Text = "Materias";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 435);
			this.Controls.Add(this.Lblmaterias);
			this.Controls.Add(this.Btnmateria2);
			this.Controls.Add(this.Btnmateria1);
			this.Controls.Add(this.Btnfisica);
			this.Controls.Add(this.Btningles);
			this.Controls.Add(this.Btnmatematicas);
			this.Name = "MainForm";
			this.Text = "Menu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label Lblmaterias;
		private System.Windows.Forms.Button Btnmateria2;
		private System.Windows.Forms.Button Btnmateria1;
		private System.Windows.Forms.Button Btnfisica;
		private System.Windows.Forms.Button Btningles;
		private System.Windows.Forms.Button Btnmatematicas;
	}
}
