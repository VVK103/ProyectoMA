/*
 * Created by SharpDevelop.
 * User: CC2_PC32
 * Date: 29/10/2024
 * Time: 07:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace ProyectoMA
{
	/// <summary>
	/// Description of c.
	/// </summary>
	public partial class c : Form
	{
		public c()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		SoundPlayer guitarra;
		void Button4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			SoundPlayer sonido=new SoundPlayer();
			sonido.SoundLocation="C:/Users/CC2_PC32/ProyectoMA/ProyectoMA/guitarra.wav";
			guitarra.Play();
		}
	}
}
