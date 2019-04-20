using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFCI
{
    public partial class Form4 : Form
    {
        int count = 0, buffer = 0;
        public Form4()
        {
            InitializeComponent();
            Opacity = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.01;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(buffer==3)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                //studentForm f3 = new studentForm(new appform());
               // f3.Show();
                //loginForm f = new loginForm();
                ///f.Show();
                Hide();
                timer3.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.01;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
