/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 29/10/2024
 * Time: 07:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMA
{
	/// <summary>
	/// Description of Fisica.
	/// </summary>
	public partial class Fisica : Form
	{
		public Fisica()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Btn1Click(object sender, EventArgs e)
		{
			double gradosc = double.Parse(Txtgrados.Text);
			double gradosf = (gradosc*9/5)+32;
			double gradosk = gradosc + 273.15;
			LblF.Text += gradosf.ToString();
			LblK.Text += gradosk.ToString();
		}
		
		
		void Btn2Click(object sender, EventArgs e)
		{
			double gramos = double.Parse(TxtGramos.Text);
			double Kilos = gramos/1000;
			double Ton= Kilos/1000;
			LblKg.Text += Kilos.ToString();
			LblTon.Text += Ton.ToString();
		}
		
		
		void Btn3Click(object sender, EventArgs e)
		{
			double metros = double.Parse(TxtMetros.Text);
			double Km = metros/1000;
			double Cm = metros*100;
			LblKm.Text += Km.ToString();
			LblCm.Text += Cm.ToString();
		}
	}
}
