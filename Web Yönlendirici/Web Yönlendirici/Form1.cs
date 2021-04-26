using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Yönlendirici
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.google.com.tr");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.facebook.com");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.instagram.com");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.discord.com");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.web.whatsapp.com");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.web.telegram.org");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.youtube.com");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.twitch.tv");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.microsoft.com");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.apple.com");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.wikipedia.org");
		}

		private void button12_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.spotify.com");
			
		}

		private void button13_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.github.com");
		}

		private void button14_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("www.yandex.com.tr");
		}
	}
}
