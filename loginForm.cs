using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;

namespace ProjectFCI
{
    public partial class loginForm : Form
    {
        public string faculty_name;
        appform appForm;
        WebClient client = new WebClient();
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://studentid.000webhostapp.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public loginForm(appform app)
        {
            InitializeComponent();
            CheckForInternetConnection();
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("Sorry No Internet , Try Again Later");
                Application.Exit();
            }
            else
            {
                string url = "https://studentid.000webhostapp.com/ServerTest.php";//see the employee number in database
                string req = client.DownloadString(url);
                if (req.ToLower() == "fail")
                {
                    panel1.Visible = true;
                    r1.Checked = true;
                }
                else
                {
                    panel1.Visible = true;
                    LogPanal.Visible = true;
                }
                appForm = app;
            }
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            choicePanal.Visible = true;
            LoginPanal.Visible = true;
            adminPanal.Enabled = true;

        }
       
        // start button for admin and user

        private void button5_Click(object sender, EventArgs e)
        {
            labelerror.Visible =false;
            //Username Text
            if (adminUser.Text == "")
            {
                adminUser.Text = "Username";
                adminUser.ForeColor = Color.LightGray;

            }

            //Password Text
            if (adminPass.Text == "")
            {
                adminPass.Text = "Password";
                adminPass.ForeColor = Color.LightGray;

            }
            string req="";
            if ((adminUser.Text != "" || adminUser.Text != "Username") && (adminPass.Text != "" || adminUser.Text != "Password") && comboBox2.Text != "")
            {
                try
                {
                       req = client.DownloadString("https://studentid.000webhostapp.com/Sloginform.php?employee_username=" + adminUser.Text + "&employee_password=" + adminPass.Text);
                      
               }
                catch
                {
                    button5_Click(sender, e);
                }

                if (req == "Admin")// if(true)
                {
                    Employee.getInstance().setUserName(adminUser.Text);
                    Employee.getInstance().setPassword(adminPass.Text);

                    appForm.loadPanel.Controls.Remove(this);
                    admin adminform;
                    adminform = new admin(appForm, comboBox2.SelectedItem.ToString());
                    adminform.TopLevel = false;
                    appForm.loadPanel.Controls.Add(adminform);
                    adminform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    adminform.Dock = DockStyle.Fill;
                    adminform.Show();

                }
                else if (req == "User")
                {
                    Employee.getInstance().setUserName(adminUser.Text);
                    Employee.getInstance().setPassword(adminPass.Text);

                    appForm.loadPanel.Controls.Remove(this);
                    studentForm stuform;
                    stuform = new studentForm(appForm, comboBox2.SelectedItem.ToString());
                    stuform.TopLevel = false;
                    appForm.loadPanel.Controls.Add(stuform);
                    stuform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    stuform.Dock = DockStyle.Fill;
                    stuform.Show();

                }
                    else
                {
                   labelerror.Visible = true;

                }

            }
                else
                {
                    if (adminUser.Text == "Username"||adminUser.Text=="")
                    {
                        r1error.Visible = true;
                        p1error.Visible = true;
                    }

                    if (adminPass.Text == "Password" || adminPass.Text == "********")
                    {
                        r2error.Visible = true;
                        p2error.Visible = true;
                    }
                    if (comboBox2.Text == "")
                    {
                        r3error.Visible = true;
                        p3error.Visible = true;
                    }
                    labelerror.Visible = false;
                }


            }
           
        

        private void adminUser_Click(object sender, EventArgs e)
        {
            if (adminUser.Text == "Username")
            {
                adminUser.Text = "";
                adminUser.ForeColor = Color.Black;
                r1error.Visible = false;
                p1error.Visible = false;
            }
        }

        private void adminPass_Click(object sender, EventArgs e)
        {
            if (adminPass.Text == "********")
            {
                adminPass.Text = "";
                adminPass.ForeColor = Color.Black;
                r2error.Visible = false;
                p2error.Visible = false;

            }
        }

        private void adminUser_Leave(object sender, EventArgs e)
        {
            if (adminUser.Text == "")
            {
                adminUser.Text = "Username";
                adminUser.ForeColor = Color.LightGray;

            }
        }

        private void adminPass_Leave(object sender, EventArgs e)
        {
            if (adminPass.Text == "")
            {
                adminPass.Text = "********";
                adminPass.ForeColor = Color.LightGray;

            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            r3error.Visible = false;
            p3error.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string GeneratePassword()
        {
            string strPwdchar = "abcdefghijklmnopqrstuvwxyz0123456789#+@&$ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string strPwd = "";
            Random rnd = new Random();
            for (int i = 0; i <= 7; i++)
            {
                int iRandom = rnd.Next(0, strPwdchar.Length - 1);
                strPwd += strPwdchar.Substring(iRandom, 1);
            }
            return strPwd;
        }
        private bool isNumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!(num[i] >= '0' && num[i] <= '9'))
                    return false;
            }
            return true;
        }

        ////add the frist employee 
        private void Add_Click(object sender, EventArgs e)
        {
            NameText.ReadOnly = false;
            ID.ReadOnly = false;
            faculty.ReadOnly = false;
            errID.Visible = false;
            errName.Visible = false;
            errFaculty.Visible = false;

            if (NameText.Text != "" && ID.Text != "" &&ID.Text.Length==14&& faculty.Text != ""&&isNumber(ID.Text))
            {
                string pass = GeneratePassword();
                string[] newname = NameText.Text.Split(' ');
                string username;
                if (newname.Length >= 2)
                {
                    username = newname[0] + "." + newname[1] + ID.Text[0] + "14";
                }
                else
                {
                    username = newname[0] + ID.Text[0] + "14";
                }
               // MessageBox.Show(pass + "   " + username);
             
                ///load gif wait result
                string url = "https://studentid.000webhostapp.com/Sinsertemployee.php?employee_name=" + NameText.Text + "&employee_national_id=" + ID.Text + "&placeORfaculty=" + faculty.Text + "&employee_username=" + username + "&employee_password=" + pass + "&employee_privilege=Admin&employee_logged=1";
                //new addFristemployee.php file 
                string  req = client.DownloadString(url);
                if (req.ToLower() == "success")
                {
                    //MessageBox.Show("su");
                    //  NewInfoPanal.Visible = true;
                    Employee.getInstance().setUserName(username);
                    Employee.getInstance().setPassword(pass);
                    UserPassPanal.Visible = true;
                    Add.Visible = false;
                    OK.Visible = true;
                    Username.Text = username;
                    label6.Text = pass;
                }
                else
                {
                    MessageBox.Show("there is an error ,try agian.");
                }

            }
            else
            {
                if (NameText.Text == "Name")
                {
                    errName.Visible = true;
                }

                if (ID.Text == "ID")
                {
                    errID.Visible = true;
                }
                if (faculty.Text == "Faculty")
                {
                    errFaculty.Visible = true;
                }

                
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            appForm.loadPanel.Controls.Remove(this);
            admin adminform;
            adminform = new admin(appForm,faculty.Text);
            adminform.TopLevel = false;
            appForm.loadPanel.Controls.Add(adminform);
            adminform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            adminform.Dock = DockStyle.Fill;
            adminform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click_1(object sender, EventArgs e)
        {
            appForm.loadPanel.Controls.Remove(this);
            admin adminform;
            adminform = new admin(appForm, faculty.Text);
            adminform.TopLevel = false;
            appForm.loadPanel.Controls.Add(adminform);
            adminform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            adminform.Dock = DockStyle.Fill;
            adminform.Show();
        }



    }
    
}
