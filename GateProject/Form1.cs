using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GateProject
{
    
    public partial class Form1 : Form
    {
        int count = 0, buffer = 0;
      
        public Form1()
        {
           
                InitializeComponent();
                Opacity = 1;
                timer1.Start();
            
        }

   
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 1)
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

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (buffer == 3)
            {
                timer3.Start();
                timer2.Stop();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
                timer3.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.01;
            }
        }

       
    }
}
