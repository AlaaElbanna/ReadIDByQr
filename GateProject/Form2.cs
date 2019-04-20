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
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.Web.Script.Serialization;
using System.Threading;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace GateProject
{
    public partial class Form2 : Form
    {
        int count = 0, buffer = 0;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        MySqlConnection con;
        MySqlCommand cmd;
        Form3 f = new Form3();
        public Form2()
        {
            InitializeComponent();
            Opacity = 1;
            timer1.Start();
            HomePanal.Visible = true;
            con = new MySqlConnection("server=localhost;database=student_id;uid=root;pwd=root;");
         }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("delete from UnAllowed where enddate=@a",con);
            cmd.Parameters.AddWithValue("@a", DateTime.Now.ToString("yyyy.MM.dd"));
            cmd.ExecuteNonQuery();
                CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (CaptureDevice.Count < 1)
                {
                    MessageBox.Show("VideoInputDevice not found");
                    Application.Exit();
                }
                FinalFrame = new VideoCaptureDevice();
            
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            ////156; 646
            //1; 646
            if (List.Height == 695 & List.Width == 206)
            {
                List.Height = 695;
                List.Width = 47;
                nexto.Location = new System.Drawing.Point(-5, -1);
                //Logout.Location = new System.Drawing.Point(3,646);
                Logo.Visible = false;

            }
            else
            {
              //  List.Height = 695;
               // List.Width = 206;
               // nexto.Location = new System.Drawing.Point(161, 3);
           //     Logout.Location = new System.Drawing.Point(156,646);
            //    Logo.Visible = true;

            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //saveListPanal.Visible = true;
            //r1.Visible = true;
            //r2.Visible = true;
            //r3.Visible = true;
            //AddPanal.Visible = true;
           // saveListPanal.Visible = true;
     //       RemovePanal.Visible = true;
        //    StudentPanal.Visible = true;
            ScanPanel.Visible = false;
            List.Height = 695;
            List.Width = 47;
            nexto.Location = new System.Drawing.Point(-5, -1);
          //  Logout.Location = new System.Drawing.Point(3, 376);
            Logo.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 47;
            //AddPanal.Visible = true;
       //     UpdatePanal.Visible = false;
        //    RemovePanal.Visible = false;
            nexto.Location = new System.Drawing.Point(-5, -1);
             //Logout.Location = new System.Drawing.Point(3, 376);
             Logo.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 47;
            //AddPanal.Visible = true;
            //UpdatePanal.Visible = true;
            nexto.Location = new System.Drawing.Point(-5, -1);
            //Logout.Location = new System.Drawing.Point(3, 376);
            Logo.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List.Height = 371;
            List.Width = 47;
            nexto.Location = new System.Drawing.Point(-5, -1);
            //Logout.Location = new System.Drawing.Point(3, 376);
            //UpdatePanal.Visible = true;
         //   RemovePanal.Visible = true;
            Logo.Visible = false;
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

       

       
        private void button3_Click_2(object sender, EventArgs e)
        {
            //DataPanal1.Visible = true;
            if (button3.BackColor != System.Drawing.Color.Red)
            {
                timer4.Enabled = true;
                timer4.Start();
                button3.BackColor = System.Drawing.Color.Red;
                if (!FinalFrame.IsRunning)
                    FinalFrame.Start();


            }
            else
            {
                button3.BackColor = System.Drawing.Color.DarkGreen;
                timer4.Enabled = false;
                timer4.Stop();
                FinalFrame.Stop();
            }
        }
              private void button2_Click_1(object sender, EventArgs e)
        {
            //AddPanal.Visible = true;
            savePanal.Visible = true;
            ScanPanel.Visible = true;
            button3.Visible = true;
          //  StudentPanal.Visible = true;
      ////////////////////////////////////////            
            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start(); 
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
            // throw new NotImplementedException (); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            savePanal.Visible = true;
            ScanPanel.Visible = true;
            pictureBox1.Visible = false;
            button3.Visible = false;
            if(FinalFrame.IsRunning==true)
            {
                FinalFrame.Stop();
            }
        }
        private byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        
        }
       
        private void timer4_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox2.Image);
              
            try
            {
                string decoded = result.ToString().Trim();
                MessageBox.Show(decoded);
                if (decoded != "")
                {
                    timer4.Stop();
                   
                    DataPanal1.Visible = true;
                     using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //keys' specifications
                    String xmlKeyString = "<RSAKeyValue><Modulus>n96UjtBruy3w+7f3t1VF0pwQxx1wvbxBGAxOe/Hm+pXgXt54z+GvJnLDKO4NAhp3Jb/k8ozK9osO5FlXTEnWTNYjyxgWZJU6ArQ7HmHZCtVCp6HKPvzjeh1T7epA3ElAv4mUyTEmkJwooMi1ELQplXAP3m8E3iFa9x5nMnfvAae1c8o6jt31ASXJiPM896OEwkTylNrO/+egWrkEW0ezURSjHWA0LDOv7dNNHoTtFmohoY4gfF9GDfxRU+d0v0uWXnbWDCoc3Fk5jhp7sNyLw0DMBfuGxeMoTj/1fYEj9CSRg2zRAhyQtZGR/SdXpGhh8/O9VYwFvSzgSqYKAWH7VQ==</Modulus><Exponent>AQAB</Exponent><P>vhcQ51OsvuveZ5bUBbHd4kWK9HdOz8guscqQJHFtwFxhqZn8MbOUuPUwVLj0n7Y/3F+tziIKK+fQPlFOGeWRXOEXmk/B71WiPn/8TdDEZH+dU1LI7VwzOPbZASlBjTrt8Bq/aVkrzLxzi0iz7TW/MGjIfpE9dvXfzgILQkfoKbU=</P><Q>100LWChI5cxOJzN9NZakdSqVLHQpcf/FI3Tcfz8e+G0Zoa58ftLHu5jeiDssHjOu3tQjnbH1rswij12w7qZWwmSywDbyTNnwt/fYKfwAjdVTmEYRsLx7js6bMJTBwNmECmaBvh5uUXW/JaVGl1Aesz5MyAOryhHLHu6lnY/XDyE=</Q><DP>c5LGnj8LmpECCe10P3ojM72gfH5FlqNZcJN+DApC9l+0qU+MPBO5arL4japeYPSH407w95FOqd8ph5obaDdhqBzbIuE3QnLIUEO0fQNfRNMqLkz5CQezxQCgc8pHprybig5ZLo4eyT4S6i5r5t90vNQYgot/2WIojrJDcisSBrk=</DP><DQ>CEkEuL3EIGO+Vi/bD6beaUvcNbu6pJJtKbIjkhoBvRmltN0cGV1PJl75oVB1oCvo/NY5EKZ6h+F/Kvk2B9kK2aw6XL9Aj8iLROkavnLeKpcdAm0f3SdDsfkta68tzZgRRr0vHPvazvOzCWXU05nXtJofJktN3xbUNDqG0QtqAUE=</DQ><InverseQ>l3IlFkdyI+qZNONdzk2up6SdhGNI0JQLqU1z33lhx5659VANxkXW0O0AsCvEjLDGMCRTmBrUS3J4VBpWwj1pqhfEfCV2kk4zGmSxrwW0o08BXYpNueJvPauzWwQcrLJq/SteN2Y40CTuhXXQ0fiooLez294CDa+hdGU8I4REOCg=</InverseQ><D>CY2EjYBv64xRec0dTipthL9Nc68d6+x/luxcqo8tc5GjSa/xV/n+8WUf+xu3EcYwkpl5Q11n3wcMrFbtU+eWmK/0DWr3+D8q1ftci/0h+cHSsjnFSscUNa63yOqQ68jXHQrfezfcENM6oe7pqODxxNZLJcoMUv9QaZ36tyXlACbOhCQBMc5JcS7ZVIem4kbb0oHU4xJP6MUWgMqrJ7s1WgcZm+Ul9Ucw6vujOIPqMLYtTEc0zq8oTEXvb0THJblJZiNKXJLLCoVCACb4t7de9EaYHRU/ag1265MCHvi/NVcn1a9JDyJ/2BCXkgSmQeKEgls0YornW7GImnpp8E544Q==</D></RSAKeyValue>";
 //loading keys' specifications from the xml file
                    RSA.FromXmlString(xmlKeyString);
                    var encryptedData = Convert.FromBase64String(decoded);
                    var decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true) , false);
                    String decryptedResString = System.Text.Encoding.UTF8.GetString(decryptedData);
                    string[] split = decryptedResString.Split(';');
                    if (split[0] == "5bvD3.8BMs")
                    {
                        textBox10.Text = split[1];//name
                        textBox9.Text = split[2];//city
                        textBox8.Text = split[3];//grade
                        textBox7.Text = split[4];//id
                        P1.Visible = true;
                        p2.Visible = false;
                    }
                    else
                    {
                       
                    }

                   }
            
             
                  

                       
                    }
                    else
                        MessageBox.Show("error");

                }


            catch (Exception ex)
            {
                P1.Visible = false;
                p2.Visible = true;
            } 
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            savePanal.Visible = true;
            ScanPanel.Visible = true;
            pictureBox1.Visible = false;
            button3.Visible = false;
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

       
         
      

        private void button6_Click(object sender, EventArgs e)
        {
            DataPanal1.Visible = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalFrame.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
