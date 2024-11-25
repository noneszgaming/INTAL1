using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlasAPlaningPokerre
{
	public partial class Form1 : Form
	{
		private int totalSeconds;
		private bool User1 = false;
		private bool User2 = false;
		private bool User3 = false;
		private int ossz = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 60; i++)
			{
				this.comboBox1.Items.Add(i.ToString());
				this.comboBox2.Items.Add(i.ToString());
			}
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 5;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			User1 = !User1;
			if (User1)
			{
				button1.Text = "Szavazo 1 Ready";
				ossz++;
			}
			else
			{
				button1.Text = "Szavazo 1 Unready";
				ossz--;
			}
			ellenorzo();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			User2 = !User2;
			if (User2)
			{
				button2.Text = "Szavazo 2 Ready";
				ossz++;
			}
			else
			{
				button2.Text = "Szavazo 2 Unready";
				ossz--;
			}
			ellenorzo();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (totalSeconds > 0)
			{
				totalSeconds--;
				int minutes = totalSeconds / 60;
				int seconds = totalSeconds - (minutes * 60);
				this.label3.Text = minutes.ToString() + ":" + seconds.ToString();
			}
			else
			{
				this.timer1.Stop();
				MessageBox.Show("Eredmények");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			User3 = !User3;
			if (User3)
			{
				button3.Text = "Szavazo 3 Ready";
				ossz++;
			}
			else
			{
				button3.Text = "Szavazo 3 Unready";
				ossz--;
			}
			ellenorzo();
		}

		private void leszamlalo()
		{
			int minutes = int.Parse(this.comboBox1.SelectedItem.ToString());
			int seceonds = int.Parse(this.comboBox2.SelectedItem.ToString());

			totalSeconds = (minutes * 60) + seceonds;
			this.timer1.Enabled = true;
		}

		private void megallito()
		{
			totalSeconds = 0;
			this.timer1.Enabled = false;
			this.label3.Text = this.comboBox1.SelectedItem.ToString() + ":" + this.comboBox2.SelectedItem.ToString();
		}

		private void ellenorzo()
		{
			label4.Text = ossz.ToString() + "/3";
			if (User1 && User2 && User3)
			{
				leszamlalo();
			}
			else
			{
				megallito();
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
