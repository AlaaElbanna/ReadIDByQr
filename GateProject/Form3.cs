using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GateProject
{
    public partial class Form3 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=student_id");
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("insert into UnAllowed values(@a,@b,@c,@d,@e,@f)",con);
            cmd.Parameters.AddWithValue("@a", textBox1.Text);
            cmd.Parameters.AddWithValue("@b", textBox2.Text);
            cmd.Parameters.AddWithValue("@c", textBox3.Text);
            cmd.Parameters.AddWithValue("@d", textBox4.Text);
            cmd.Parameters.AddWithValue("@e", textBox5.Text);
            cmd.Parameters.AddWithValue("@f", textBox6.Text);
            cmd.ExecuteNonQuery();
           
        }

    }
}
