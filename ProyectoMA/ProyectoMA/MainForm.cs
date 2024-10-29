/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 24/10/2024
 * Time: 07:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMA
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnfisicaClick(object sender, EventArgs e)
		{
			Fisica Fisica = new Fisica();
			Fisica.Show();
		}
	}
}
