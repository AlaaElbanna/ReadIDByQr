using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MetroFramework.Forms;
namespace ProjectFCI
{
    public partial class Form2 : Form
    {
        List<Panel> listPanal = new List<Panel>();
        int index;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listPanal.Add(firstPanal);
            listPanal.Add(secondPanal);
            listPanal[index].BringToFront();
            firstPanal.Visible = true;
            secondPanal.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //141; 371
            if (List.Height == 394 & List.Width == 155)
            {
                List.Height = 371;
                List.Width = 37;
                //159; 204
                next.Location = new Point(6,181);
            }
            else
            {
                //6; 181
                List.Height = 394;
                List.Width = 155 ;
                next.Location = new Point(6, 181);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void firstPanal_MouseMove(object sender, MouseEventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 37;
            //159; 204
         //   next.Location = new Point(6, 181);
            secondPanal.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 37;
            //159; 204
            next.Location = new Point(6, 181);
            secondPanal.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 37;
            //159; 204
            next.Location = new Point(6, 181);
        }

   
        private void textBox30_Click(object sender, EventArgs e)
        {
            rect1.BorderColor = Color.Red;
            re1.Visible = true;
            o1.Visible = false;
        }

        private void textBox29_Click(object sender, EventArgs e)
        {
            rect2.BorderColor = Color.Red;
            red2.Visible = true;
            o2.Visible = false;
        }

        private void textBox30_Enter(object sender, EventArgs e)
        {
            rect1.BorderColor = Color.Red;
            re1.Visible = true;
            o1.Visible = false;
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

  
     
    }
}
