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
    public partial class appform : Form
    {
        public Panel loadPanel;
        loginForm logForm;
        
        public appform()
        {
            InitializeComponent();
            loadPanel = new System.Windows.Forms.Panel();
            loadPanel.Location = new System.Drawing.Point(2, 0);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new System.Drawing.Size(this.Width, this.Height);
            loadPanel.TabIndex = 0;
            Controls.Add(loadPanel);
        }

        private void appform_Load(object sender, EventArgs e)
        {
            logForm = new loginForm(this);
            logForm.TopLevel = false;
            loadPanel.Controls.Add(logForm);
            logForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            logForm.Dock = DockStyle.Fill;
            logForm.Show();
        }
    }
}
