/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 29/10/2024
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoMA
{
	partial class Fisica
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fisica));
			this.LblFisica = new System.Windows.Forms.Label();
			this.LblTransformadorees = new System.Windows.Forms.Label();
			this.LblFormulas = new System.Windows.Forms.Label();
			this.LblTemperatura = new System.Windows.Forms.Label();
			this.LblF = new System.Windows.Forms.Label();
			this.LblPeso = new System.Windows.Forms.Label();
			this.LblKg = new System.Windows.Forms.Label();
			this.LblTon = new System.Windows.Forms.Label();
			this.LblK = new System.Windows.Forms.Label();
			this.Txtgrados = new System.Windows.Forms.TextBox();
			this.TxtGramos = new System.Windows.Forms.TextBox();
			this.TxtMetros = new System.Windows.Forms.TextBox();
			this.LblCm = new System.Windows.Forms.Label();
			this.LblKm = new System.Windows.Forms.Label();
			this.LblDistancias = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Btn1 = new System.Windows.Forms.Button();
			this.Btn3 = new System.Windows.Forms.Button();
			this.Btn2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// LblFisica
			// 
			this.LblFisica.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFisica.Location = new System.Drawing.Point(210, 9);
			this.LblFisica.Name = "LblFisica";
			this.LblFisica.Size = new System.Drawing.Size(113, 56);
			this.LblFisica.TabIndex = 0;
			this.LblFisica.Text = "Fisica";
			// 
			// LblTransformadorees
			// 
			this.LblTransformadorees.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTransformadorees.Location = new System.Drawing.Point(57, 72);
			this.LblTransformadorees.Name = "LblTransformadorees";
			this.LblTransformadorees.Size = new System.Drawing.Size(150, 23);
			this.LblTransformadorees.TabIndex = 1;
			this.LblTransformadorees.Text = "Transformadores";
			// 
			// LblFormulas
			// 
			this.LblFormulas.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFormulas.Location = new System.Drawing.Point(369, 72);
			this.LblFormulas.Name = "LblFormulas";
			this.LblFormulas.Size = new System.Drawing.Size(100, 23);
			this.LblFormulas.TabIndex = 2;
			this.LblFormulas.Text = "Formulas";
			// 
			// LblTemperatura
			// 
			this.LblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTemperatura.Location = new System.Drawing.Point(69, 110);
			this.LblTemperatura.Name = "LblTemperatura";
			this.LblTemperatura.Size = new System.Drawing.Size(100, 23);
			this.LblTemperatura.TabIndex = 3;
			this.LblTemperatura.Text = "°C a °F y °K";
			// 
			// LblF
			// 
			this.LblF.Location = new System.Drawing.Point(38, 183);
			this.LblF.Name = "LblF";
			this.LblF.Size = new System.Drawing.Size(106, 23);
			this.LblF.TabIndex = 4;
			this.LblF.Text = "°F= ";
			// 
			// LblPeso
			// 
			this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPeso.Location = new System.Drawing.Point(69, 221);
			this.LblPeso.Name = "LblPeso";
			this.LblPeso.Size = new System.Drawing.Size(100, 23);
			this.LblPeso.TabIndex = 5;
			this.LblPeso.Text = "g a Kg y Ton";
			// 
			// LblKg
			// 
			this.LblKg.Location = new System.Drawing.Point(38, 301);
			this.LblKg.Name = "LblKg";
			this.LblKg.Size = new System.Drawing.Size(106, 23);
			this.LblKg.TabIndex = 6;
			this.LblKg.Text = "Kg= ";
			// 
			// LblTon
			// 
			this.LblTon.Location = new System.Drawing.Point(150, 301);
			this.LblTon.Name = "LblTon";
			this.LblTon.Size = new System.Drawing.Size(106, 23);
			this.LblTon.TabIndex = 7;
			this.LblTon.Text = "Ton= ";
			// 
			// LblK
			// 
			this.LblK.Location = new System.Drawing.Point(150, 183);
			this.LblK.Name = "LblK";
			this.LblK.Size = new System.Drawing.Size(106, 23);
			this.LblK.TabIndex = 8;
			this.LblK.Text = "°K= ";
			// 
			// Txtgrados
			// 
			this.Txtgrados.Location = new System.Drawing.Point(85, 136);
			this.Txtgrados.Name = "Txtgrados";
			this.Txtgrados.Size = new System.Drawing.Size(46, 20);
			this.Txtgrados.TabIndex = 9;
			// 
			// TxtGramos
			// 
			this.TxtGramos.Location = new System.Drawing.Point(85, 256);
			this.TxtGramos.Name = "TxtGramos";
			this.TxtGramos.Size = new System.Drawing.Size(46, 20);
			this.TxtGramos.TabIndex = 10;
			// 
			// TxtMetros
			// 
			this.TxtMetros.Location = new System.Drawing.Point(85, 375);
			this.TxtMetros.Name = "TxtMetros";
			this.TxtMetros.Size = new System.Drawing.Size(46, 20);
			this.TxtMetros.TabIndex = 14;
			// 
			// LblCm
			// 
			this.LblCm.Location = new System.Drawing.Point(150, 420);
			this.LblCm.Name = "LblCm";
			this.LblCm.Size = new System.Drawing.Size(106, 23);
			this.LblCm.TabIndex = 13;
			this.LblCm.Text = "Cm= ";
			// 
			// LblKm
			// 
			this.LblKm.Location = new System.Drawing.Point(38, 420);
			this.LblKm.Name = "LblKm";
			this.LblKm.Size = new System.Drawing.Size(104, 23);
			this.LblKm.TabIndex = 12;
			this.LblKm.Text = "Km= ";
			// 
			// LblDistancias
			// 
			this.LblDistancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDistancias.Location = new System.Drawing.Point(69, 340);
			this.LblDistancias.Name = "LblDistancias";
			this.LblDistancias.Size = new System.Drawing.Size(100, 23);
			this.LblDistancias.TabIndex = 11;
			this.LblDistancias.Text = "m a Km y cm";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(339, 109);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(155, 97);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(347, 215);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "V= Velocidad";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(347, 238);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "d= Distancia";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(347, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "t= Tiempo";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(339, 287);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(155, 97);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(357, 444);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "v= Volumen";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(357, 421);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "m= Masa";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(357, 398);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "p= Densidad";
			// 
			// Btn1
			// 
			this.Btn1.Location = new System.Drawing.Point(210, 134);
			this.Btn1.Name = "Btn1";
			this.Btn1.Size = new System.Drawing.Size(46, 23);
			this.Btn1.TabIndex = 23;
			this.Btn1.Text = "Hacer";
			this.Btn1.UseVisualStyleBackColor = true;
			this.Btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// Btn3
			// 
			this.Btn3.Location = new System.Drawing.Point(210, 373);
			this.Btn3.Name = "Btn3";
			this.Btn3.Size = new System.Drawing.Size(46, 23);
			this.Btn3.TabIndex = 24;
			this.Btn3.Text = "Hacer";
			this.Btn3.UseVisualStyleBackColor = true;
			this.Btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// Btn2
			// 
			this.Btn2.Location = new System.Drawing.Point(210, 254);
			this.Btn2.Name = "Btn2";
			this.Btn2.Size = new System.Drawing.Size(46, 23);
			this.Btn2.TabIndex = 25;
			this.Btn2.Text = "Hacer";
			this.Btn2.UseVisualStyleBackColor = true;
			this.Btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// Fisica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 467);
			this.Controls.Add(this.Btn2);
			this.Controls.Add(this.Btn3);
			this.Controls.Add(this.Btn1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TxtMetros);
			this.Controls.Add(this.LblCm);
			this.Controls.Add(this.LblKm);
			this.Controls.Add(this.LblDistancias);
			this.Controls.Add(this.TxtGramos);
			this.Controls.Add(this.Txtgrados);
			this.Controls.Add(this.LblK);
			this.Controls.Add(this.LblTon);
			this.Controls.Add(this.LblKg);
			this.Controls.Add(this.LblPeso);
			this.Controls.Add(this.LblF);
			this.Controls.Add(this.LblTemperatura);
			this.Controls.Add(this.LblFormulas);
			this.Controls.Add(this.LblTransformadorees);
			this.Controls.Add(this.LblFisica);
			this.Name = "Fisica";
			this.Text = "Fisica";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button Btn2;
		private System.Windows.Forms.Button Btn3;
		private System.Windows.Forms.Button Btn1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label LblDistancias;
		private System.Windows.Forms.Label LblKm;
		private System.Windows.Forms.Label LblCm;
		private System.Windows.Forms.TextBox TxtMetros;
		private System.Windows.Forms.TextBox TxtGramos;
		private System.Windows.Forms.TextBox Txtgrados;
		private System.Windows.Forms.Label LblK;
		private System.Windows.Forms.Label LblTon;
		private System.Windows.Forms.Label LblKg;
		private System.Windows.Forms.Label LblPeso;
		private System.Windows.Forms.Label LblF;
		private System.Windows.Forms.Label LblTemperatura;
		private System.Windows.Forms.Label LblFormulas;
		private System.Windows.Forms.Label LblTransformadorees;
		private System.Windows.Forms.Label LblFisica;
	}
}
