using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(65, Color.Black);
            pictureBox2.BackColor = Color.FromArgb(65, Color.Black);
            panel2.BackColor = Color.FromArgb(65, Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;

                }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;

            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Image black_icon = new Bitmap(@"data\Images\dxOS1.png");
            pictureBox2.BackgroundImage = black_icon;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Image white_icon = new Bitmap(@"data\Images\dxOS2.png");
            pictureBox2.BackgroundImage = white_icon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Image exit_icon2 = new Bitmap(@"data\Images\kapat2.png");
            pictureBox1.BackgroundImage = exit_icon2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Image exit_icon1 = new Bitmap(@"data\Images\kapat.png");
            pictureBox1.BackgroundImage = exit_icon1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("explorer.exe", "https://31cekenayi.glitch.me/");

        }
            
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            String statement = "netsh advfirewall set privateprofile state off";
            System.Diagnostics.Process.Start("CMD.exe", statement);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String statement = "netsh advfirewall set privateprofile state off";
            System.Diagnostics.Process.Start("CMD.exe", statement);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://31cekenayi.glitch.me/");
        }

        private void cmdTaskbar_Click(object sender, EventArgs e)
        {
            String statement = "netsh advfirewall set privateprofile state off";
            System.Diagnostics.Process.Start("CMD.exe", statement);
        }

        private void ieTaskbar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://31cekenayi.glitch.me/");
        }
    }
}
