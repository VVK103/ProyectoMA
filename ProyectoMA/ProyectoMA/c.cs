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
		SoundPlayer sax;			
		SoundPlayer trompeta;
		SoundPlayer sonido;			
		SoundPlayer tambor;
		SoundPlayer violin;
		void Button4Click(object sender, EventArgs e)
		{

			SoundPlayer sax=new SoundPlayer();
			sax.SoundLocation="C:/Users/CC2_PC32/ProyectoMA/ProyectoMA/guitarra.wav";
			sax.Play();			
		}
		
		void Button3Click(object sender, EventArgs e)
		{

			SoundPlayer trompeta=new SoundPlayer();
			trompeta.SoundLocation="C:/Users/CC2_PC32/ProyectoMA/ProyectoMA/guitarra.wav";
			trompeta.Play();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			SoundPlayer sonido=new SoundPlayer();
			sonido.SoundLocation="C:/Users/CC2_PC32/ProyectoMA/ProyectoMA/guitarra.wav";
			sonido.Play();
		}
		
		void Button2Click(object sender, EventArgs e)
		{

			SoundPlayer tambor=new SoundPlayer();
			tambor.SoundLocation="C:/Users/CC2_PC32/ProyectoMA/ProyectoMA/guitarra.wav";
			tambor.Play();			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			SoundPlayer violin=new SoundPlayer();
			violin.SoundLocation="C:/Users/CC2_PC32/ProyectoMA/ProyectoMA/guitarra.wav";
			violin.Play();			
		}
	}
}
