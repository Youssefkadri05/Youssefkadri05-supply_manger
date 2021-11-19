using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supply_manger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = bunifuButton1;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }
        public bool ifFormMinimized = false;
        private void minimized_button_Click(object sender, EventArgs e)
        {
            ifFormMinimized = true;
            this.WindowState = FormWindowState.Minimized;
                 }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
