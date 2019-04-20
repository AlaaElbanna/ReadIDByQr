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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //158; 371
            //0; 371
            //162; 379
            //3; 376
            if (List.Height == 419 & List.Width == 206)
            {
                List.Height = 418;
                List.Width = 46;
                nexto.Location = new Point(-5,-1);
                Logout.Location = new Point(3, 376);

                searchIcon.Visible = false;
                searchText.Visible = false;
                Logo.Visible = false;
            }
            else
            {
                List.Height = 419;
                List.Width = 206;
                nexto.Location = new Point(161, 3);
                Logout.Location = new Point(162, 379);

                searchIcon.Visible = true;
                searchText.Visible = true;
                Logo.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 47;
            nexto.Location = new Point(-5, -1);
            secondPanal.Visible = true;
            thirdPanal.Visible = false;
          //  firstPanal.Visible = true;
            searchIcon.Visible = false;
            searchText.Visible = false;
            Logo.Visible = false;
            Logout.Location = new Point(3, 376);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            List.Height = 371;
            List.Width = 47;
            nexto.Location = new Point(-5, -1);
            secondPanal.Visible = true;
            thirdPanal.Visible = true;
            forthPanal.Visible = false;
            searchIcon.Visible = false;
            searchText.Visible = false;
            Logo.Visible = false;
            Logout.Location = new Point(3, 376);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 47;
            nexto.Location = new Point(-5, -1);
            thirdPanal.Visible = true;
            forthPanal.Visible = true;
            searchIcon.Visible = false;
            searchText.Visible = false;
            Logo.Visible = false;
            Logout.Location = new Point(3, 376);
        }

        private void firstPanal_MouseMove(object sender, MouseEventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void t1_Click(object sender, EventArgs e)
        {
            //rect1.BorderColor = Color.Red;
            re1.Visible = true;
            o1.Visible = false;
            if (t1.Text == "Name")
            {
                t1.Text = "";
                t1.ForeColor = Color.Black;

            }
        }

        private void t2_Click(object sender, EventArgs e)
        {
            //rect2.BorderColor = Color.Red;
            red2.Visible = true;
            o2.Visible = false;
            if (t2.Text == "Faculty")
            {
                t2.Text = "";
                t2.ForeColor = Color.Black;

            }
        }

        private void t3_Click(object sender, EventArgs e)
        {
           // rect3.BorderColor = Color.Red;
            red3.Visible = true;
            o3.Visible = false;
            if (t3.Text == "Grade")
            {
                t3.Text = "";
                t3.ForeColor = Color.Black;

            }
        }

        private void t4_Click(object sender, EventArgs e)
        {
            ///rect4.BorderColor = Color.Red;
            red4.Visible = true;
            o4.Visible = false;
            if (t4.Text == "City")
            {
                t4.Text = "";
                t4.ForeColor = Color.Black;

            }
        }

        private void t5_Click(object sender, EventArgs e)
        {
           // rect5.BorderColor = Color.Red;
            red5.Visible = true;
            o5.Visible = false;
            if (t5.Text == "System")
            {
                t5.Text = "";
                t5.ForeColor = Color.Black;

            }
        }

        private void t6_Click(object sender, EventArgs e)
        {
          ///  rect6.BorderColor = Color.Red;
            red6.Visible = true;
            o6.Visible = false;
            if (t6.Text == "Status")
            {
                t6.Text = "";
                t6.ForeColor = Color.Black;

            }
        }

        private void t7_Click(object sender, EventArgs e)
        {
          //  rect7.BorderColor = Color.Red;
            red7.Visible = true;
            o7.Visible = false;
            if (t7.Text == "Date")
            {
                t7.Text = "";
                t7.ForeColor = Color.Black;

            }
        }

        private void t8_Click(object sender, EventArgs e)
        {
            ///rect8.BorderColor = Color.Red;
            red8.Visible = true;
            o8.Visible = false;
            if (t8.Text == "Password")
            {
                t8.Text = "";
                t8.ForeColor = Color.Black;

            }
        }

        private void t9_Click(object sender, EventArgs e)
        {
           /// rect9.BorderColor = Color.Red;
            red9.Visible = true;
            o9.Visible = false;
            if (t9.Text == "Username")
            {
                t9.Text = "";
                t9.ForeColor = Color.Black;

            }
        }

        private void t10_Click(object sender, EventArgs e)
        {
            //rect10.BorderColor = Color.Red;
            red10.Visible = true;
            o10.Visible = false;
            if (t10.Text == "ID")
            {
                t10.Text = "";
                t10.ForeColor = Color.Black;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            secondPanal.Visible = false;
            firstPanal.Visible = true;
            thirdPanal.Visible = false;


        }

        private void t1_Leave(object sender, EventArgs e)
        {
           // rect1.BorderColor = Color.Black;
            re1.Visible = false;
            o1.Visible = true;
            if (t1.Text == "")
            {

                t1.Text = "Name";
                t1.ForeColor = Color.DarkGray;
            }
        }

        private void t2_Leave(object sender, EventArgs e)
        {
            //rect2.BorderColor = Color.Black;
            red2.Visible = false;
            o2.Visible = true;
            if (t2.Text == "")
            {

                t2.Text = "Faculty";
                t2.ForeColor = Color.DarkGray;
            }
        }

        private void t3_Leave(object sender, EventArgs e)
        {
            //rect3.BorderColor = Color.Black;
            red3.Visible = false;
            o3.Visible = true;
            if (t3.Text == "")
            {

                t3.Text = "Grade";
                t3.ForeColor = Color.DarkGray;
            }
        }

        private void t4_Leave(object sender, EventArgs e)
        {
            //rect4.BorderColor = Color.Black;
            red4.Visible = false;
            o4.Visible = true;
            if (t4.Text == "")
            {

                t4.Text = "City";
                t4.ForeColor = Color.DarkGray;
            }
        }

        private void t5_Leave(object sender, EventArgs e)
        {
            //rect5.BorderColor = Color.Black;
            red5.Visible = false;
            o5.Visible = true;
            if (t5.Text == "")
            {

                t5.Text = "System";
                t5.ForeColor = Color.DarkGray;
            }
        }

        private void t6_Leave(object sender, EventArgs e)
        {
            //rect6.BorderColor = Color.Black;
            red6.Visible = false;
            o6.Visible = true;
            if (t6.Text == "")
            {
                t6.Text = "Status";
                t6.ForeColor = Color.DarkGray;
            }
        }

        private void t7_Leave(object sender, EventArgs e)
        {
           // rect7.BorderColor = Color.Black;
            red7.Visible = false;
            o7.Visible = true;
            if (t7.Text == "")
            {
                t7.Text = "Date";
                t7.ForeColor = Color.DarkGray;
            }
        }

        private void t8_Leave(object sender, EventArgs e)
        {
            //rect8.BorderColor = Color.Black;
            red8.Visible = false;
            o8.Visible = true;
            if (t8.Text == "")
            {
                t8.Text = "Password";
                t8.ForeColor = Color.DarkGray;
            }
        }

        private void t9_Leave(object sender, EventArgs e)
        {
            //rect9.BorderColor = Color.Black;
            red9.Visible = false;
            o9.Visible = true;
            if (t9.Text == "")
            {
                t9.Text = "Username";
                t9.ForeColor = Color.DarkGray;
            }
        }

        private void t10_Leave(object sender, EventArgs e)
        {
            
            //rect10.BorderColor = Color.Black;
            red10.Visible = false;
            o10.Visible = true;
            if (t10.Text == "")
            {
                t10.Text = "ID";
                t10.ForeColor = Color.DarkGray;
            }
        }

        private void personalPic_Click(object sender, EventArgs e)
        {
            //rect11.BorderColor = Color.Red;
        }

        private void t11_Click(object sender, EventArgs e)
        {
           // rect12.BorderColor = Color.Red;
            r11.Visible = true;
            o11.Visible = false;
            if (t11.Text == "Name")
            {
                t11.Text = "";
                t11.ForeColor = Color.Black;

            }
        }

        private void t12_Click(object sender, EventArgs e)
        {
            //rect13.BorderColor = Color.Red;
            r12.Visible = true;
            o12.Visible = false;
            if (t12.Text == "City")
            {
                t12.Text = "";
                t12.ForeColor = Color.Black;

            }
        }

        private void t13_Click(object sender, EventArgs e)
        {
          //  rect14.BorderColor = Color.Red;
            r13.Visible = true;
            o13.Visible = false;
            if (t13.Text == "ID")
            {
                t13.Text = "";
                t13.ForeColor = Color.Black;

            }
        }

        private void t14_Click(object sender, EventArgs e)
        {
           // rect16.BorderColor = Color.Red;
            r14.Visible = true;
            o14.Visible = false;
            if (t14.Text == "Grade")
            {
                t14.Text = "";
                t14.ForeColor = Color.Black;

            }
        }

        private void t15_Click(object sender, EventArgs e)
        {
           /// rect17.BorderColor = Color.Red;
            r15.Visible = true;
            o15.Visible = false;
            if (t15.Text == "Status")
            {
                t15.Text = "";
                t15.ForeColor = Color.Black;

            }
        }

        private void t11_Leave(object sender, EventArgs e)
        {
           // rect12.BorderColor = Color.Black;
            r11.Visible = false;
            o11.Visible = true;
            if (t11.Text == "")
            {
                t11.Text = "Name";
                t11.ForeColor = Color.DarkGray;
            }
        }

        private void t12_Leave(object sender, EventArgs e)
        {
            //rect13.BorderColor = Color.Black;
            r12.Visible = false;
            o12.Visible = true;
            if (t12.Text == "")
            {
                t12.Text = "City";
                t12.ForeColor = Color.DarkGray;
            }
        }

        private void t13_Leave(object sender, EventArgs e)
        {
           // rect14.BorderColor = Color.Black;
            r13.Visible = false;
            o13.Visible = true;
            if (t13.Text == "")
            {
                t13.Text = "ID";
                t13.ForeColor = Color.DarkGray;
            }
        }

        private void t14_Leave(object sender, EventArgs e)
        {
           // rect16.BorderColor = Color.Black;
            r14.Visible = false;
            o14.Visible = true;
            if (t14.Text == "")
            {
                t14.Text = "Grade";
                t14.ForeColor = Color.DarkGray;
            }
        }

        private void t15_Leave(object sender, EventArgs e)
        {
            //rect17.BorderColor = Color.Black;
            r15.Visible = false;
            o15.Visible = true;
            if (t15.Text == "")
            {
                t15.Text = "Status";
                t15.ForeColor = Color.DarkGray;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();

        }

      
     
    }
}
