using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traxon_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Made By Darklost", "Credits",
    System.Windows.Forms.MessageBoxButtons.OK,
    System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
            button2.Visible = true;
            button3.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start f2 = new Start();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Sorry, but this feature is currently disabled. You can choose the normal option. This Feature Will Be Released Soon..", "Feature Are Not Enabled",
    System.Windows.Forms.MessageBoxButtons.OK,
    System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
