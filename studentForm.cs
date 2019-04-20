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
using System.IO;
using System.Web.Script.Serialization;
//using System.Web.Script.Services;

namespace ProjectFCI
{
    public partial class studentForm : Form
    {
        appform appForm;
        WebClient client = new WebClient();
     //   ser
        string picPath;
        string faculty_name;
        string employee_username;
        string employee_password;
        JavaScriptSerializer ser = new JavaScriptSerializer();
        int flag = 0;

        public studentForm(appform app, string facultyName)
        {
            InitializeComponent();
            appForm = app;
            this.faculty_name = facultyName;
            employee_username = Employee.getInstance().getUsername();
            employee_password = Employee.getInstance().getpassword();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            t2.Text = faculty_name;
            t2.ReadOnly = true;
            
            //List.Height = 371;
            //List.Width = 47;
            //nexto.Location = new Point(-5, -1);
            NewPanal.Visible = true;
            EditPanal.Visible = false;
            //ShowPanal.Visible = false;
            //  firstPanal.Visible = true;
           // Logo.Visible = false;
            //Logout.Location = new Point(3, 376);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchText.Text = "";
            UserPassPanal.Visible = false;
            //List.Height = 371;
            //List.Width = 47;
            //nexto.Location = new Point(-5, -1);
            NewPanal.Visible = true;
            EditPanal.Visible = true;
            studentInfoPanal.Visible = false;
            //ShowPanal.Visible = false;
            //Logo.Visible = false;
            //Logout.Location = new Point(3, 376);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserPassPanal.Visible = false;
            //List.Height = 371;
            //List.Width = 47;
            //nexto.Location = new Point(-5, -1);
            NewPanal.Visible = true;
            EditPanal.Visible = true;
            //ShowPanal.Visible = true;
            //Logo.Visible = false;
            //Logout.Location = new Point(3, 376);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            appForm.loadPanel.Controls.Remove(this);
            loginForm logForm;
            logForm = new loginForm(appForm);
            logForm.TopLevel = false;
            appForm.loadPanel.Controls.Add(logForm);
            logForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            logForm.Dock = DockStyle.Fill;
            logForm.Show();
        }

        private void nexto_Click(object sender, EventArgs e)
        {
            //206; 705
            // 47; 705
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

        private void t1_Enter(object sender, EventArgs e)
        {
            rect1.BorderColor = Color.Orange;
            re1.Visible = true;
            o1.Visible = false;
            p1error.Visible = false;
            if (t1.Text == "Name")
            {
                t1.Text = "";
                t1.ForeColor = Color.Black;
                ;

            }
        }

        private void t2_Enter(object sender, EventArgs e)
        {
            p2error.Visible = false;
            rect2.BorderColor = Color.Orange;
            red2.Visible = true;
            o2.Visible = false;
            if (t2.Text == "Faculty")
            {
                t2.Text = "";
                t2.ForeColor = Color.Black;

            }
        }

        private void t3_Enter(object sender, EventArgs e)
        {
            p3error.Visible = false;
            rect3.BorderColor = Color.Orange;
            red3.Visible = true;
            o3.Visible = false;
            if (t3.Text == "Grade")
            {
                t3.Text = "";
                t3.ForeColor = Color.Black;

            }
        }

        private void t4_Enter(object sender, EventArgs e)
        {
            p4error.Visible = false;
            rect4.BorderColor = Color.Orange;
            red4.Visible = true;
            o4.Visible = false;
            if (t4.Text == "City")
            {
                t4.Text = "";
                t4.ForeColor = Color.Black;

            }
        }

        private void t5_Enter(object sender, EventArgs e)
        {
            //rect5.BorderColor = Color.Orange;
            //    red5.Visible = true;
            //   o5.Visible = false;
            //    if (t5.Text == "System")
            //    {
            //         t5.Text = "";
            //         t5.ForeColor = Color.Black;
            //
            //    }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            p5error.Visible = false;
            rect6.BorderColor = Color.Orange;
            //  red6.Visible = true;
            //o6.Visible = false;
            if (comboBox1.Text == "choose")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;

            }
        }

        private void t7_Enter(object sender, EventArgs e)
        {
            p6error.Visible = false;
            rect7.BorderColor = Color.Orange;
            red7.Visible = true;
            o7.Visible = false;
            if (t7.Text == "SSN")
            {
                t7.Text = "";
                t7.ForeColor = Color.Black;

            }
        }

        private void t8_Enter(object sender, EventArgs e)
        {
            //   rect8.BorderColor = Color.Orange;
            //   red8.Visible = true;
            //   o8.Visible = false;
            //   if (t8.Text == "Password")
            //   {
            //       t8.Text = "";
            //       t8.ForeColor = Color.Black;

            //    }
        }

        private void t9_Enter(object sender, EventArgs e)
        {
            //  rect9.BorderColor = Color.Orange;
            ///  red9.Visible = true;
            //   o9.Visible = false;
            //  if (t9.Text == "Username")
            //   {
            //        t9.Text = "";
            //       t9.ForeColor = Color.Black;

            //    }
        }

        private void t10_Enter(object sender, EventArgs e)
        {
            p7error.Visible = false;
            rect10.BorderColor = Color.Orange;
            red10.Visible = true;
            o10.Visible = false;
            if (t10.Text == "ID")
            {
                t10.Text = "";
                t10.ForeColor = Color.Black;

            }
        }

        private void t1_Leave(object sender, EventArgs e)
        {
            rect1.BorderColor = Color.Black;
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
            rect2.BorderColor = Color.Black;
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
            rect3.BorderColor = Color.Black;
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
            rect4.BorderColor = Color.Black;
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
            //   rect5.BorderColor = Color.Black;
            //   red5.Visible = false;
            //   o5.Visible = true;
            //   if (t5.Text == "")
            //    {

            //         t5.Text = "System";
            //        t5.ForeColor = Color.DarkGray;
            //     }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            rect6.BorderColor = Color.Black;
            // red6.Visible = false;
            // o6.Visible = true;
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "choose";
                comboBox1.ForeColor = Color.DarkGray;
            }
        }

        private void t7_Leave(object sender, EventArgs e)
        {
            rect7.BorderColor = Color.Black;
            red7.Visible = false;
            o7.Visible = true;
            if (t7.Text == "")
            {
                t7.Text = "Student number";
                t7.ForeColor = Color.DarkGray;
            }
        }

        private void t8_Leave(object sender, EventArgs e)
        {
            //  rect8.BorderColor = Color.Black;
            //  red8.Visible = false;
            //  o8.Visible = true;
            //   if (t8.Text == "")
            //     {
            ///        t8.Text = "Password";
            //       t8.ForeColor = Color.DarkGray;
            //    }
        }

        private void t9_Leave(object sender, EventArgs e)
        {
            // rect9.BorderColor = Color.Black;
            // red9.Visible = false;
            //  o9.Visible = true;
            //   if (t9.Text == "")
            //   {
            //       t9.Text = "Username";
            //       t9.ForeColor = Color.DarkGray;
            //    }
        }

        private void t10_Leave(object sender, EventArgs e)
        {
            rect10.BorderColor = Color.Black;
            red10.Visible = false;
            o10.Visible = true;
            if (t10.Text == "")
            {
                t10.Text = "ID";
                t10.ForeColor = Color.DarkGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1error.Visible = false;
            p2error.Visible = false;
            p3error.Visible = false;
            p4error.Visible = false;
            p5error.Visible = false;
            p6error.Visible = false;
            p7error.Visible = false;

            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            //t5.Text = "";
            comboBox1.Text = "";
            t7.Text = "";
            //  t8.Text = "";
            //  t9.Text = "";
            t10.Text = "";
            if (t1.Text == "")
            {

                t1.Text = "Name";
                t1.ForeColor = Color.DarkGray;
            }
            if (t2.Text == "")
            {

                t2.Text = "Faculty";
                t2.ForeColor = Color.DarkGray;
            }
            if (t3.Text == "")
            {

                t3.Text = "Grade";
                t3.ForeColor = Color.DarkGray;
            }
            if (t4.Text == "")
            {

                t4.Text = "City";
                t4.ForeColor = Color.DarkGray;
            }
            // if (t5.Text == "")
            //  {

            //     t5.Text = "System";
            //     t5.ForeColor = Color.DarkGray;
            // }
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "choose";
                comboBox1.ForeColor = Color.DarkGray;
            }
            if (t7.Text == "")
            {
                t7.Text = "SSN";
                t7.ForeColor = Color.DarkGray;
            }
            // if (t8.Text == "")
            //  {
            //     t8.Text = "Password";
            //     t8.ForeColor = Color.DarkGray;
            // }
            //  if (t9.Text == "")
            //  {
            //      t9.Text = "Username";
            //     t9.ForeColor = Color.DarkGray;
            //  }
            if (t10.Text == "")
            {
                t10.Text = "ID";
                t10.ForeColor = Color.DarkGray;
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

            t11.Visible = true;
            labelName.Visible = false;
            t11.Text = labelName.Text;
            rect12.Visible = true;
            rect12.BorderColor = System.Drawing.Color.Green;
        }

        private void labelCity_Click(object sender, EventArgs e)
        {
            t12.Visible = true;
            labelCity.Visible = false;
            t12.Text = labelCity.Text;
            rect13.Visible = true;
            rect13.BorderColor = System.Drawing.Color.Green;
        }

        private void labelGrade_Click(object sender, EventArgs e)
        {
            t14.Visible = true;
            labelGrade.Visible = false;
            t14.Text = labelGrade.Text;
            rect16.Visible = true;
            rect16.BorderColor = System.Drawing.Color.Green;
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            t15.Visible = true;
            labelStatus.Visible = false;
            t15.Text = labelStatus.Text;
            rect17.Visible = true;
            rect17.BorderColor = System.Drawing.Color.Green;
        }

        private void labelStatus_Leave(object sender, EventArgs e)
        {
            t15.Visible = false;
            labelStatus.Visible = true;
            labelStatus.Text = t15.Text;
            rect17.Visible = false;
        }

        private void labelGrade_Leave(object sender, EventArgs e)
        {
            t14.Visible = false;
            labelGrade.Visible = true;
            labelGrade.Text = t14.Text;
            rect16.Visible = false;
        }

        private void labelCity_Leave(object sender, EventArgs e)
        {
            t12.Visible = false;
            labelCity.Visible = true;
            labelCity.Text = t12.Text;
            rect13.Visible = false;
        }

        private void labelName_Leave(object sender, EventArgs e)
        {
            t11.Visible = false;
            labelName.Visible = true;
            labelName.Text = t11.Text;
            rect12.Visible = false;
        }

        //Edit

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
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
       
        ///Ssearchstudent
        private void searchIcon_Click(object sender, EventArgs e)
        {
            RectErrorSearch.Visible = false;
            ErrorLabel.Visible = false;
            if (searchText.Text != "" && searchText.Text.Length == 14 && isNumber(searchText.Text))
            {
                studentInfoPanal.Visible = true;
                string req = client.DownloadString("https://studentid.000webhostapp.com/Ssearchstudent.php?student_national_id=" + searchText.Text + "&employee_username=" + employee_username + "&employee_password=" + employee_password);

                if (req.ToLower() != "")
                {
                    student JSONObj = ser.Deserialize<student>(req); //JSON decoded
                    byte[] imageData = client.DownloadData(JSONObj.student_img); //DownloadData function from her

                    MemoryStream stream = new MemoryStream(imageData);
                    pictureBox11.Image = Image.FromStream(stream);
                    stream.Close();

                    t11.Text = JSONObj.student_name;//name
                    t12.Text = JSONObj.address;//city
                    t13.Text = JSONObj.student_id;//id
                    t14.Text = JSONObj.student_grade;//grade
                    t15.Text = JSONObj.student_state;//status*/

                    // var JSONObj = ser.Deserialize<Dictionary<string, string>>(req); //JSON decoded
                    /*var JSONObj = ser.Deserialize<Dictionary<string, string>>(req); //JSON decoded

                    byte[] imageData = client.DownloadData(JSONObj["student_img"]); //DownloadData function from her

                    MemoryStream stream = new MemoryStream(imageData);
                    pictureBox11.Image = Image.FromStream(stream);
                    stream.Close();
                       
                    /*byte[] imageData = client.DownloadData(JSONObj["student_img"]); //DownloadData function from her

                    MemoryStream stream = new MemoryStream(imageData);
                    pictureBox11.Image = Image.FromStream(stream);
                    stream.Close();*/

                    /* var JSONObj = ser.Deserialize<Dictionary<string, string>>(req); //JSON decoded
                  textBox1.Text = JSONObj["student_name"];//name
                  textBox2.Text = JSONObj["address"];//city
                  textBox3.Text = JSONObj["student_grade"];//grade
                  textBox4.Text = JSONObj["student_id"];//id
                  textBox5.Text = JSONObj["student_state"];//status

                    labelName.Text = JSONObj["student_name"];//name
                    labelCity.Text = JSONObj["address"];//city
                    IDlabel.Text = JSONObj["student_id"];//id
                    labelGrade.Text = JSONObj["student_grade"];//grade
                    labelStatus.Text = JSONObj["student_state"];//status*/
                }

                else
                {
                    MessageBox.Show("this student not exist");

                }
            }
            else
            {
                RectErrorSearch.Visible = true;
                ErrorLabel.Visible = true;

            }

        }

        private void IDlabel_Leave(object sender, EventArgs e)
        {
            t13.Visible = false;
            IDlabel.Visible = true;
            IDlabel.Text = t13.Text;
            rect14.Visible = false;
        }

        private void IDlabel_Click(object sender, EventArgs e)
        {
            t13.Visible = true;
            IDlabel.Visible = false;
            t13.Text = IDlabel.Text;
            rect14.Visible = true;
            rect14.BorderColor = System.Drawing.Color.Green;
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
        /// add button
        private void button2_Click(object sender, EventArgs e)
        {
            if (t1.Text != "Name" && t7.Text != "SSN" && t2.Text != "Faculty" && t3.Text != "Grade" && t4.Text != "City" && t10.Text != "ID"&& personalPic.Image != null)
            {
                string pass = GeneratePassword();
                string[] newname = t1.Text.Split(' ');
                string username =newname[0]+"147" ;
                if (newname.Length >= 2 && t7.Text.Length>2)
                {
                    username = newname[0] + newname[1] + t7.Text[0] + t7.Text[1] + t7.Text[2];
                }
                string datenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                /////upload image 
                client.Headers.Add("Content-Type", "binary/octet-stream");
                try
                {
                  /*  var filePath = Server.MapPath("~/Images/" + filename);
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }*/
                    byte[] result = client.UploadFile("http://studentid.000webhostapp.com/uploadimagetoserver.php", "POST", picPath);
                    string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
                ////////////////////////////////////// 
                string[] nameofPath = picPath.Split('\\');
                string nameofPc = nameofPath[nameofPath.Length - 1];
                string nameofPic = "https://studentid.000webhostapp.com/Images/" + nameofPc;
                //MessageBox.Show(nameofPic);
                String url = "https://studentid.000webhostapp.com/Sinsertstudent.php?student_national_id=" + t7.Text + "&student_id=" + t10.Text + "&student_name=" + t1.Text + "&address=" + t4.Text + "&student_grade=" + t3.Text + "&faculty_name=" + t2.Text + "&student_state=Allowed&employee_username=" + employee_username + "&employee_password=" + employee_password + "&student_username=" + username + "&student_password=" + pass + "&student_logged=0&registeration_date=" + datenow + "&student_img="+nameofPc;
                string req = client.DownloadString(url);
                
                if (req == "success")
                {
                    NewPanal.Visible = true;
                   // studentInfoPanal.Visible = true;
                    UserPassPanal.Visible = true;
                    Username.Text = username;
                    label1.Text = pass;

                }
                else
                {
                    MessageBox.Show("error");
                }
            }

            else
            {
               // MessageBox.Show("PLZ Entr Ur corrct data");
                p1error.Visible = true;
                p2error.Visible = true;
                p3error.Visible = true;
                p4error.Visible = true;
                p5error.Visible = true;
                p6error.Visible = true;
                p7error.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewPanal.Visible = true;
            UserPassPanal.Visible = false;
        }

        private void personalPic_Click(object sender, EventArgs e)
        {
            
        }

        ///edit 
        
        private void button7_Click_1(object sender, EventArgs e)
        {
         /*   if()
            t11.Text=labelName.Text ;
             t12.Text=labelCity.Text;
             t13.Text=IDlabel.Text;
             t14.Text = labelGrade.Text;
             t15.Text=labelStatus.Text;
            */


            if (t11.Text == "")
            {
                err11.Visible = true;
                rect12.Visible = true;
                rect12.BorderColor = System.Drawing.Color.Red;
            }
            else if (t12.Text == "")
            {
                err12.Visible = true;
                rect13.Visible = true;
                rect13.BorderColor = System.Drawing.Color.Red;
            }
            else if (t13.Text == "")
            {
                err13.Visible = true;
                rect14.Visible = true;
                rect14.BorderColor = System.Drawing.Color.Red;
            }
            else if (t14.Text == "")
            {
                err14.Visible = true;
                rect16.Visible = true;
                rect16.BorderColor = System.Drawing.Color.Red;
            }
            else if (t15.Text == "")
            {
                err15.Visible = true;
                rect17.Visible = true;
                rect17.BorderColor = System.Drawing.Color.Red;
            }
                //|| (t12.Text == "City" || t12.Text == "") || (t13.Text == "ID" || t13.Text == "") || (t14.Text == "Grade" || t14.Text == "") || (t15.Text == "Status" || t15.Text == ""))
            
            else
            {
                /////upload image 
                client.Headers.Add("Content-Type", "binary/octet-stream");
                if (flag == 1)
                {
                    try
                    {
                        byte[] result = client.UploadFile("http://studentid.000webhostapp.com/uploadimagetoserver.php", "POST", picPath);
                        string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                }
                ////////////////////////////////////// 
                string url="https://studentid.000webhostapp.com/Supdatestudent.php?student_national_id=" +searchText.Text+"&student_id="+ t13.Text+"&address="+t12.Text + "&student_name=" + t11.Text + "&student_grade=" + t14.Text + "&student_state=" + t15.Text+"&employee_username="+employee_username+"&employee_password="+employee_password;///

                string req = client.DownloadString(url);
                if(req.ToLower()=="success")
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show(req);
                }
               // MessageBox.Show("Done");
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {

                personalPic.Image = Image.FromFile(op.FileName);
                picPath = op.FileName;
                //MessageBox.Show(picPath);   
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rectPhoto.Visible = true;
            rectPhoto.BorderColor = System.Drawing.Color.Green;
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {

                personalPic.Image = Image.FromFile(op.FileName);
                picPath = op.FileName;
                flag = 1;
                //MessageBox.Show(picPath);   
            }
        }

        private void showAll_CheckedChanged(object sender, EventArgs e)
        {

        }
       

        private void t11_Enter(object sender, EventArgs e)
        {
            //t11.Text = labelName.Text;
            err11.Visible = false;
            rect12.Visible = true;
            rect12.BorderColor = System.Drawing.Color.Green;
        }

        private void t12_Enter(object sender, EventArgs e)
        {
            //t12.Text = labelCity.Text;
            err12.Visible = false;
            rect13.Visible = true;
            rect13.BorderColor = System.Drawing.Color.Green;
        }

        private void t13_Enter(object sender, EventArgs e)
        {
            //t13.Text = IDlabel.Text;
            err13.Visible = false;
            rect14.Visible = true;
            rect14.BorderColor = System.Drawing.Color.Green;
        }

        private void t14_Enter(object sender, EventArgs e)
        {
            //t14.Text = labelGrade.Text;
            err14.Visible = false;
            rect16.Visible = true;
            rect16.BorderColor = System.Drawing.Color.Green;
        }

        private void t15_Enter(object sender, EventArgs e)
        {
            //t15.Text = labelStatus.Text;
            rect17.Visible = true;
            err15.Visible = false;
            rect17.BorderColor = System.Drawing.Color.Green;
        }
        //to return admin to admin form
        private void label5_Click(object sender, EventArgs e)
        {
            appForm.loadPanel.Controls.Remove(this);
            admin f1 ;
            f1 = new admin(appForm, faculty_name);
            f1.TopLevel = false;
            appForm.loadPanel.Controls.Add(f1);
            f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }

        ////remove button
        private void button3_Click(object sender, EventArgs e)
        {
            string req = client.DownloadString("https://studentid.000webhostapp.com/Sdeletestudent.php?student_id=" + IDlabel.Text + "&student_name=" + t11.Text + "&employee_username=" + employee_username + "&employee_password=" + employee_password);

            if (req.ToLower() == "success")
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("fail");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string url = "https://studentid.000webhostapp.com/Sdeletestudent.php?student_national_id=" + searchText.Text +"&employee_username=" + employee_username + "&employee_password=" + employee_password;///

            string req = client.DownloadString(url);
            if (req.ToLower() == "success")
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show(req);
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchText_Click(object sender, EventArgs e)
        {
            RectErrorSearch.Visible = false;
            ErrorLabel.Visible = false;
        }

        private void t11_Leave(object sender, EventArgs e)
        {
            rect12.Visible = false;
        }

        private void t12_Leave(object sender, EventArgs e)
        {
            rect13.Visible = false;
        }

        private void t13_Leave(object sender, EventArgs e)
        {
            rect14.Visible = false;
        }

        private void t14_Leave(object sender, EventArgs e)
        {
            rect16.Visible = false;
        }

        private void t15_Leave(object sender, EventArgs e)
        {
            rect17.Visible = false;
        }

        private void t15_TextChanged(object sender, EventArgs e)
        {

        }

    }
}