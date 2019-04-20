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
using System.Web.Script.Serialization;

namespace ProjectFCI
{
    public partial class admin : Form
    {
        appform appForm;
        int count = 0, buffer = 0;
        WebClient client = new WebClient();
        string select_faculty1;
        string degree;
        string employee_usrename;
        string employee_password;
        JavaScriptSerializer ser = new JavaScriptSerializer();

        public admin(appform app, string select_faculty1)
        {
            InitializeComponent();
            Opacity = 1;
            this.select_faculty1 = select_faculty1;
            appForm = app;
            timer1.Start();
            employee_usrename = Employee.getInstance().getUsername();
            employee_password = Employee.getInstance().getpassword();
          // MessageBox.Show(employee_password + "    " + employee_usrename);//to test
        }
        public admin()
        {
            InitializeComponent();
            }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
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

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Start();
                timer3.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.01;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewInfoPanal.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            faculty.Text = select_faculty1;
            NameText.ReadOnly = false;
            ID.ReadOnly = false;
            faculty.ReadOnly = true;
            Edit.Visible = false;
            Add.Visible = true;
            Remove.Visible = false;
            //NewPanal.Visible = true;
            NewInfoPanal.Visible = true;
            searchPanal.Visible = false;
            RemoveButtonPanal.Visible = false;
            //List.Height = 371;
            //List.Width = 47;
            //nexto.Location = new Point(-5, -1);
            //secondPanal.Visible = true;
            //thirdPanal.Visible = false;
            //  firstPanal.Visible = true;
            //Logo.Visible = false;
            //Logout.Location = new Point(3, 376);
            Add.Visible = true;
            EditButtonPanal.Visible = false;
            //es1.Text = this.Location.X.ToString();
            //es2.Text = this.Location.Y.ToString();
            //es3.Text = this.Width.ToString();
            //es4.Text = this.Height.ToString();
        }

        private void nexto_Click(object sender, EventArgs e)
        {
            if (List.Height == 744 & List.Width == 206)
            {
                List.Height = 705;
                List.Width = 47;
                nexto.Location = new Point(-5, -1);
                Logout.Location = new Point(3, 376);

                //searchIcon.Visible = false;
                //searchText.Visible = false;
                Logo.Visible = false;

            }
            else
            {
                List.Height = 744;
                List.Width = 206;
                nexto.Location = new Point(161, 3);
                Logout.Location = new Point(162, 379);
                Logo.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NameText.ReadOnly = false;
            ID.ReadOnly = false;
            faculty.ReadOnly = false;
            searchText.Text = "";
            Edit.Visible = true;
            Add.Visible = false;
            Remove.Visible = false;
            UserPassPanal.Visible = false;
            //List.Height = 371;
            //List.Width = 47;
            NewInfoPanal.Visible = false;
            //nexto.Location = new Point(-5, -1);
         //   NewInfoPanal.Visible = true;
            searchPanal.Visible = true;
        //    Edit.Visible = true;
            Add.Visible = false;
            RemoveButtonPanal.Visible = false;
            //secondPanal.Visible = true;
            //thirdPanal.Visible = false;
            //  firstPanal.Visible = true;
            //Logo.Visible = false;
            //Logout.Location = new Point(3, 376);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            searchText.Text = "";
            Edit.Visible = false;
            Add.Visible = false;
            Remove.Visible = true;
            UserPassPanal.Visible = false;
            NewInfoPanal.Visible = false;
            //List.Height = 371;
            //List.Width = 47;
           
            //nexto.Location = new Point(-5, -1);
            searchPanal.Visible = true;

            //secondPanal.Visible = true;
            //thirdPanal.Visible = false;
            //  firstPanal.Visible = true;
            Add.Visible = false;
            Edit.Visible = false;
            RemoveButtonPanal.Visible = true;
            //Logo.Visible = false;
            //Logout.Location = new Point(3, 376);
            NameText.ReadOnly = true;
            ID.ReadOnly = true;
            faculty.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameText.Text != "" && ID.Text != "" && PasswordText.Text != "" && (r1.Checked == false || r2.Checked == false))
            {
                if (r1.Checked==true)
                {
                    degree = "admin";
                }
                else if (r2.Checked==true)
                {
                    degree = "user";
                }
                else
                    degree = "";

            }
            else
            {
                status.ForeColor = System.Drawing.Color.Red;
                status.Text = "Wrong";
            }
            NameText.Text = "";
            ID.Text = "";
            PasswordText.Text = "";
            r1.Checked = false;
            r2.Checked = false;
        }

        //Supdateemployee

        private void button2_Click(object sender, EventArgs e)
        {
            NameText.ReadOnly = false;
            ID.ReadOnly = false;
            faculty.ReadOnly = false;
            searchText.Text = "";
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

            if (r1.Checked == false && r2.Checked == false)
            {
                errCheck.Visible = true;
            }
            
            if (r1.Checked)
            {
                degree = "Admin";
            }
            else if (r2.Checked)
            {
                degree = "User";
            }
            else
                degree = "";
  
               if (NameText.Text != "" && faculty.Text != "" && (r1.Checked == false || r2.Checked == false)&&ID.Text.Length==14&&isNumber(ID.Text) )
                {
                    string req = client.DownloadString("https://studentid.000webhostapp.com/Supdateemployee.php?employee_name=" + NameText.Text + "&employee_national_id=" + ID.Text + "&placeORfaculty=" + faculty.Text + "&employee_privilege=" + degree);

                    if (req == "success") 
                    {
                        status.ForeColor = System.Drawing.Color.Green;
                        status.Text = "Successful";
                        //MessageBox.Show("Successful");
                        trueIcon.Visible = true;
                    }
                    else
                    {
                        status.ForeColor = System.Drawing.Color.Red;
                        status.Text = "errorin conncation ,try agian.";

                    }
                }
            
            else
            {

                MessageBox.Show("enter data");
            }
            NameText.Text = "";
            faculty.Text = "";
            ID.Text = "";
            r1.Checked=false;
            r2.Checked = false;
                //bs.EndEdit();
            //da.Update(ds);
          
        }

        ///Ssearchemployee

        private void searchIcon_Click(object sender, EventArgs e)
        {
            
            if (searchText.Text != ""&&searchText.Text.Length==14&&isNumber(searchText.Text))
            {
                
           //     char[] delimiterChars = { '\u0020', '{', ',', ':', '\t', '\"', '\'', '}' };
                string req = client.DownloadString("https://studentid.000webhostapp.com/Ssearchemployee.php?employee_national_id=" + searchText.Text);
               if (req.ToLower() != "fail")
                {
                    NewInfoPanal.Visible = true;
                    emplo JSONObj = ser.Deserialize<emplo>(req); //JSON decoded
                    
                    NameText.Text = JSONObj.employee_name;//name
                    ID.Text = JSONObj.employee_national_id;
                    faculty.Text = select_faculty1;
                    if (JSONObj.employee_privilege == "Admin")
                        r1.Checked = true;
                    else
                        r2.Checked = true;
                }
                else
                {
                    MessageBox.Show("false");
                }
            }
            else
            {
                //MessageBox.Show("not exist");
                RectErrorSearch.Visible = true;
                ErrorLabel.Visible = true;

            }

        }

        //Sdeleteemployee

        private void remove_Click(object sender, EventArgs e)
        {
            NameText.ReadOnly = true;
            ID.ReadOnly = true;
            faculty.ReadOnly = true;
            searchText.Text = "";    
            string req = client.DownloadString("https://studentid.000webhostapp.com/Sdeleteemployee.php?employee_national_id=" + ID.Text);

                if (req.ToLower() == "success")
                {
                    //MessageBox.Show("deleted");
                    trueIcon.Visible = true;
                }
                else
                {
                    MessageBox.Show("false");
               }
                NameText.Text = "";
                faculty.Text = "";
                ID.Text = "";
                r1.Checked = false;
                r2.Checked = false;
        }

        private void NameText_Enter(object sender, EventArgs e)
        {
            rectName.BorderColor = Color.Orange;
            rectName.Visible = true;
            //o1.Visible = false;
            if (NameText.Text == "Username")
            {
                NameText.Text = "";
                NameText.ForeColor = Color.Black;

            }
        }

        private void usernameText_Enter(object sender, EventArgs e)
        {
            rectUser.BorderColor = Color.Orange;
            rectUser.Visible = true;
            //o1.Visible = false;
            if (ID.Text == "ID")
            {
                ID.Text = "";
                ID.ForeColor = Color.Black;

            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            rectPass.BorderColor = Color.Orange;
            rectPass.Visible = true;
            //o1.Visible = false;
            if (PasswordText.Text == "Password")
            {
                PasswordText.Text = "";
                PasswordText.ForeColor = Color.White;

            }
        }

        private void NameText_Leave(object sender, EventArgs e)
        {
            rectName.BorderColor = Color.Black;
           // o1.Visible = true;
            if (NameText.Text == "")
            {
               
                NameText.ForeColor = System.Drawing.Color.DarkGray;
                NameText.Text = "Username";
            }
        }

        private void usernameText_Leave(object sender, EventArgs e)
        {
            rectUser.BorderColor = Color.Black;
            // o1.Visible = true;
            if (ID.Text == "")
            {
               
                ID.ForeColor = System.Drawing.Color.DarkGray;
                ID.Text = "ID";
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            rectPass.BorderColor = Color.Black;
            // o1.Visible = true;
            if (PasswordText.Text == "")
            {
                rectPass.BorderColor = Color.OrangeRed;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Employee.getInstance().setPassword("");
            Employee.getInstance().setUserName("");

            appForm.loadPanel.Controls.Remove(this);
            loginForm f1 = new loginForm(appForm);
            f1 = new loginForm(appForm);
            f1.TopLevel = false;
            appForm.loadPanel.Controls.Add(f1);
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
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

        ///Sinsertemployee
         private bool isNumber(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!(num[i] >= '0' && num[i] <= '9'))
                    return false;
            }
            return true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            NameText.ReadOnly = false;
            ID.ReadOnly = false;
            faculty.ReadOnly = false;
            if(NameText.Text=="Username")
            {
                errName.Visible = true;
            }

            if (ID.Text == "ID")
            {
                errID.Visible = true;
            }
            if (faculty.Text == "faculty")
            {
                errFaculty.Visible = true;
            }

            if (r1.Checked == false && r2.Checked == false)
            {
                errCheck.Visible = true;
            }

            string pass = GeneratePassword();
            string[] newname = NameText.Text.Split(' ');
            string username ;
            if (newname.Length >= 2&&ID.Text.Length>3)
            {
                username = newname[0] + "." + newname[1] + ID.Text[0] + ID.Text[1] + ID.Text[2];
            }
            else
            {
                username = newname[0] + ID.Text[0] +"4";
            }
            //MessageBox.Show(pass+"   "+username);
            if (r1.Checked)
            {
                degree = "Admin";
            }
            else if (r2.Checked)
            {
                degree = "User";
            }
            else
                degree = "";
            ///load gif wait result
            string req ="";
            if (isNumber(ID.Text) && ID.Text.Length == 14 && faculty.Text != "faculty" && NameText.Text != "Username" && ID.Text != "ID")
            {
                req = client.DownloadString("https://studentid.000webhostapp.com/Sinsertemployee.php?employee_name=" + NameText.Text + "&employee_national_id=" + ID.Text + "&placeORfaculty=" + faculty.Text + "&employee_username=" + username + "&employee_password=" + pass + "&employee_privilege=" + degree + "&emp_username=" + employee_usrename + "&emp_password=" + employee_password + "&employee_logged=false;");
                if (req == "success")
                {
                    NewInfoPanal.Visible = true;
                    UserPassPanal.Visible = true;
                    Add.Visible = false;
                    OK.Visible = true;
                    Username.Text = username;
                    label1.Text = pass;
                    errName.Visible = false;
                    errID.Visible = false;
                    errFaculty.Visible = false;
                    errCheck.Visible = false;
            
                }

                else
                {
                    MessageBox.Show("Check for Correct Data");
                }
            }
            else
                MessageBox.Show("Complete the Data");
           
        }

        private void Faculty_Click(object sender, EventArgs e)
        {

            rectFaculty.BorderColor = Color.Orange;
            rectFaculty.Visible = true;
            //o1.Visible = false;
            if (faculty.Text == "Faculty")
            {
                faculty.Text = "";
                faculty.ForeColor = Color.Black;

            }
        }

        private void Faculty_Leave(object sender, EventArgs e)
        {
            rectFaculty.BorderColor = Color.Black;
            rectFaculty.Visible = true;
            //o1.Visible = false;
            if (faculty.Text == "")
            {
                faculty.Text = "Faculty";
                faculty.ForeColor = System.Drawing.Color.DarkGray;
                faculty.ForeColor = Color.White;

            }
        }

        private void OK_Click(object sender, EventArgs e)
        {

            {

                NameText.ForeColor = System.Drawing.Color.DarkGray;
                NameText.Text = "Username";
            }

            {

                ID.ForeColor = System.Drawing.Color.DarkGray;
                ID.Text = "ID";
            }
            Add.Visible = true;
            UserPassPanal.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            appForm.loadPanel.Controls.Remove(this);
            studentForm f1;
            f1 = new studentForm(appForm, select_faculty1);
            f1.TopLevel = false;
            f1.panel1.Visible = true;
            f1.panel1.Visible = true;
            f1.pictureBox1.Image = this.pictureBox1.Image;
            appForm.loadPanel.Controls.Add(f1);
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }

        private void searchText_Enter(object sender, EventArgs e)
        {
            RectErrorSearch.Visible = false;
            ErrorLabel.Visible = false;
            trueIcon.Visible = false;
        }

        }
    }
