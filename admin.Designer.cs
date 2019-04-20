namespace ProjectFCI
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.List = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectFaculty = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectUser = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectName = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.NameText = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.searchPanal = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.EditButtonPanal = new System.Windows.Forms.Panel();
            this.Edit = new System.Windows.Forms.Button();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.RemoveButtonPanal = new System.Windows.Forms.Panel();
            this.Remove = new System.Windows.Forms.Button();
            this.NewInfoPanal = new System.Windows.Forms.Panel();
            this.UserPassPanal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.RectErrorSearch = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trueIcon = new System.Windows.Forms.PictureBox();
            this.errCheck = new System.Windows.Forms.PictureBox();
            this.errFaculty = new System.Windows.Forms.PictureBox();
            this.errID = new System.Windows.Forms.PictureBox();
            this.errName = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.nexto = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.searchIcon = new System.Windows.Forms.Button();
            this.List.SuspendLayout();
            this.panel2.SuspendLayout();
            this.searchPanal.SuspendLayout();
            this.NewInfoPanal.SuspendLayout();
            this.UserPassPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.Logo);
            this.List.Controls.Add(this.Logout);
            this.List.Controls.Add(this.nexto);
            this.List.Controls.Add(this.button6);
            this.List.Controls.Add(this.button5);
            this.List.Controls.Add(this.button4);
            this.List.Dock = System.Windows.Forms.DockStyle.Left;
            this.List.Location = new System.Drawing.Point(0, 0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(206, 705);
            this.List.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(4, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 58);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(51, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Student";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 10);
            this.panel1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectFaculty,
            this.rectUser,
            this.rectName});
            this.shapeContainer1.Size = new System.Drawing.Size(1153, 418);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectFaculty
            // 
            this.rectFaculty.Location = new System.Drawing.Point(220, 170);
            this.rectFaculty.Name = "rectFaculty";
            this.rectFaculty.Size = new System.Drawing.Size(240, 1);
            // 
            // rectUser
            // 
            this.rectUser.Location = new System.Drawing.Point(222, 126);
            this.rectUser.Name = "rectUser";
            this.rectUser.Size = new System.Drawing.Size(237, 1);
            // 
            // rectName
            // 
            this.rectName.Location = new System.Drawing.Point(219, 79);
            this.rectName.Name = "rectName";
            this.rectName.Size = new System.Drawing.Size(240, 1);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NameText.ForeColor = System.Drawing.Color.DarkGray;
            this.NameText.Location = new System.Drawing.Point(220, 62);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(239, 18);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "Username";
            this.NameText.Enter += new System.EventHandler(this.NameText_Enter);
            this.NameText.Leave += new System.EventHandler(this.NameText_Leave);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ID.ForeColor = System.Drawing.Color.DarkGray;
            this.ID.Location = new System.Drawing.Point(223, 109);
            this.ID.MaxLength = 14;
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(237, 18);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            this.ID.Enter += new System.EventHandler(this.usernameText_Enter);
            this.ID.Leave += new System.EventHandler(this.usernameText_Leave);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.status.Location = new System.Drawing.Point(641, 534);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 23);
            this.status.TabIndex = 15;
            // 
            // searchPanal
            // 
            this.searchPanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.searchPanal.Controls.Add(this.ErrorLabel);
            this.searchPanal.Controls.Add(this.searchIcon);
            this.searchPanal.Controls.Add(this.searchText);
            this.searchPanal.Controls.Add(this.shapeContainer2);
            this.searchPanal.Location = new System.Drawing.Point(209, 12);
            this.searchPanal.Name = "searchPanal";
            this.searchPanal.Size = new System.Drawing.Size(1145, 171);
            this.searchPanal.TabIndex = 16;
            this.searchPanal.Visible = false;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.White;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(308, 92);
            this.searchText.MaxLength = 14;
            this.searchText.Multiline = true;
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(397, 27);
            this.searchText.TabIndex = 16;
            this.searchText.Enter += new System.EventHandler(this.searchText_Enter);
            // 
            // EditButtonPanal
            // 
            this.EditButtonPanal.Location = new System.Drawing.Point(435, 330);
            this.EditButtonPanal.Name = "EditButtonPanal";
            this.EditButtonPanal.Size = new System.Drawing.Size(165, 79);
            this.EditButtonPanal.TabIndex = 17;
            this.EditButtonPanal.Visible = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(630, 288);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(127, 52);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Visible = false;
            this.Edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.r1.Location = new System.Drawing.Point(651, 125);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(64, 20);
            this.r1.TabIndex = 18;
            this.r1.TabStop = true;
            this.r1.Text = "admin";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.r2.Location = new System.Drawing.Point(586, 125);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(55, 20);
            this.r2.TabIndex = 19;
            this.r2.TabStop = true;
            this.r2.Text = "User";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // RemoveButtonPanal
            // 
            this.RemoveButtonPanal.Location = new System.Drawing.Point(625, 341);
            this.RemoveButtonPanal.Name = "RemoveButtonPanal";
            this.RemoveButtonPanal.Size = new System.Drawing.Size(170, 68);
            this.RemoveButtonPanal.TabIndex = 20;
            this.RemoveButtonPanal.Visible = false;
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(630, 346);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(127, 52);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // NewInfoPanal
            // 
            this.NewInfoPanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.NewInfoPanal.Controls.Add(this.trueIcon);
            this.NewInfoPanal.Controls.Add(this.UserPassPanal);
            this.NewInfoPanal.Controls.Add(this.errCheck);
            this.NewInfoPanal.Controls.Add(this.errFaculty);
            this.NewInfoPanal.Controls.Add(this.errID);
            this.NewInfoPanal.Controls.Add(this.errName);
            this.NewInfoPanal.Controls.Add(this.Remove);
            this.NewInfoPanal.Controls.Add(this.button1);
            this.NewInfoPanal.Controls.Add(this.faculty);
            this.NewInfoPanal.Controls.Add(this.Add);
            this.NewInfoPanal.Controls.Add(this.Edit);
            this.NewInfoPanal.Controls.Add(this.button8);
            this.NewInfoPanal.Controls.Add(this.button3);
            this.NewInfoPanal.Controls.Add(this.RemoveButtonPanal);
            this.NewInfoPanal.Controls.Add(this.r2);
            this.NewInfoPanal.Controls.Add(this.r1);
            this.NewInfoPanal.Controls.Add(this.status);
            this.NewInfoPanal.Controls.Add(this.ID);
            this.NewInfoPanal.Controls.Add(this.NameText);
            this.NewInfoPanal.Controls.Add(this.shapeContainer1);
            this.NewInfoPanal.Controls.Add(this.EditButtonPanal);
            this.NewInfoPanal.Location = new System.Drawing.Point(209, 189);
            this.NewInfoPanal.Name = "NewInfoPanal";
            this.NewInfoPanal.Size = new System.Drawing.Size(1153, 418);
            this.NewInfoPanal.TabIndex = 13;
            this.NewInfoPanal.Visible = false;
            // 
            // UserPassPanal
            // 
            this.UserPassPanal.Controls.Add(this.label4);
            this.UserPassPanal.Controls.Add(this.label3);
            this.UserPassPanal.Controls.Add(this.OK);
            this.UserPassPanal.Controls.Add(this.label2);
            this.UserPassPanal.Controls.Add(this.label1);
            this.UserPassPanal.Controls.Add(this.Username);
            this.UserPassPanal.Location = new System.Drawing.Point(154, 44);
            this.UserPassPanal.Name = "UserPassPanal";
            this.UserPassPanal.Size = new System.Drawing.Size(691, 184);
            this.UserPassPanal.TabIndex = 27;
            this.UserPassPanal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(202, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(202, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Username : ";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(542, 133);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(127, 48);
            this.OK.TabIndex = 28;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(295, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Done";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(340, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Gray;
            this.Username.Location = new System.Drawing.Point(340, 55);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(132, 23);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username  ";
            // 
            // faculty
            // 
            this.faculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.faculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faculty.Font = new System.Drawing.Font("Tahoma", 10F);
            this.faculty.ForeColor = System.Drawing.Color.DarkGray;
            this.faculty.Location = new System.Drawing.Point(220, 153);
            this.faculty.Multiline = true;
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(239, 18);
            this.faculty.TabIndex = 25;
            this.faculty.Text = "faculty";
            this.faculty.Click += new System.EventHandler(this.Faculty_Click);
            this.faculty.Leave += new System.EventHandler(this.Faculty_Leave);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(193)))), ((int)(((byte)(130)))));
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(630, 234);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 48);
            this.Add.TabIndex = 24;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // RectErrorSearch
            // 
            this.RectErrorSearch.BorderColor = System.Drawing.Color.Red;
            this.RectErrorSearch.Location = new System.Drawing.Point(306, 89);
            this.RectErrorSearch.Name = "RectErrorSearch";
            this.RectErrorSearch.Size = new System.Drawing.Size(428, 32);
            this.RectErrorSearch.Visible = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.RectErrorSearch});
            this.shapeContainer2.Size = new System.Drawing.Size(1145, 171);
            this.shapeContainer2.TabIndex = 18;
            this.shapeContainer2.TabStop = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(459, 124);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(152, 18);
            this.ErrorLabel.TabIndex = 93;
            this.ErrorLabel.Text = "Plz Enter Correct Data";
            this.ErrorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectFCI.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(1189, 566);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // trueIcon
            // 
            this.trueIcon.BackgroundImage = global::ProjectFCI.Properties.Resources.Feedbin_Icon_check_svg;
            this.trueIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trueIcon.Location = new System.Drawing.Point(208, 251);
            this.trueIcon.Name = "trueIcon";
            this.trueIcon.Size = new System.Drawing.Size(130, 99);
            this.trueIcon.TabIndex = 98;
            this.trueIcon.TabStop = false;
            this.trueIcon.Visible = false;
            // 
            // errCheck
            // 
            this.errCheck.BackgroundImage = global::ProjectFCI.Properties.Resources._11;
            this.errCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.errCheck.Location = new System.Drawing.Point(721, 125);
            this.errCheck.Name = "errCheck";
            this.errCheck.Size = new System.Drawing.Size(27, 19);
            this.errCheck.TabIndex = 97;
            this.errCheck.TabStop = false;
            this.errCheck.Visible = false;
            // 
            // errFaculty
            // 
            this.errFaculty.BackgroundImage = global::ProjectFCI.Properties.Resources._11;
            this.errFaculty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.errFaculty.Location = new System.Drawing.Point(465, 153);
            this.errFaculty.Name = "errFaculty";
            this.errFaculty.Size = new System.Drawing.Size(27, 19);
            this.errFaculty.TabIndex = 96;
            this.errFaculty.TabStop = false;
            this.errFaculty.Visible = false;
            // 
            // errID
            // 
            this.errID.BackgroundImage = global::ProjectFCI.Properties.Resources._11;
            this.errID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.errID.Location = new System.Drawing.Point(463, 111);
            this.errID.Name = "errID";
            this.errID.Size = new System.Drawing.Size(27, 19);
            this.errID.TabIndex = 95;
            this.errID.TabStop = false;
            this.errID.Visible = false;
            // 
            // errName
            // 
            this.errName.BackgroundImage = global::ProjectFCI.Properties.Resources._11;
            this.errName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.errName.Location = new System.Drawing.Point(462, 61);
            this.errName.Name = "errName";
            this.errName.Size = new System.Drawing.Size(27, 19);
            this.errName.TabIndex = 94;
            this.errName.TabStop = false;
            this.errName.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjectFCI.Properties.Resources.r71;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 26;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::ProjectFCI.Properties.Resources.r91;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(185, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 26);
            this.button8.TabIndex = 23;
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ProjectFCI.Properties.Resources.r11;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(185, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 26);
            this.button3.TabIndex = 21;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectFCI.Properties.Resources._16683215_1401925719870829_1507120486_n1;
            this.pictureBox2.Location = new System.Drawing.Point(1, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjectFCI.Properties.Resources.creative_logo_animations_33;
            this.Logo.Location = new System.Drawing.Point(-101, -96);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(277, 217);
            this.Logo.TabIndex = 20;
            this.Logo.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.BackgroundImage = global::ProjectFCI.Properties.Resources.logw;
            this.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(161, 440);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(41, 40);
            this.Logout.TabIndex = 18;
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // nexto
            // 
            this.nexto.FlatAppearance.BorderSize = 0;
            this.nexto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.nexto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nexto.Image = global::ProjectFCI.Properties.Resources.menuG;
            this.nexto.Location = new System.Drawing.Point(161, 3);
            this.nexto.Name = "nexto";
            this.nexto.Size = new System.Drawing.Size(55, 36);
            this.nexto.TabIndex = 12;
            this.nexto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nexto.UseVisualStyleBackColor = true;
            this.nexto.Click += new System.EventHandler(this.nexto_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::ProjectFCI.Properties.Resources.showw;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(2, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(204, 41);
            this.button6.TabIndex = 15;
            this.button6.Text = "Remove";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ProjectFCI.Properties.Resources.editw;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 41);
            this.button5.TabIndex = 14;
            this.button5.Text = "Edit";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(145)))), ((int)(((byte)(83)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ProjectFCI.Properties.Resources.addccw;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(4, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "New";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.White;
            this.searchIcon.BackgroundImage = global::ProjectFCI.Properties.Resources.searchG;
            this.searchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchIcon.FlatAppearance.BorderSize = 0;
            this.searchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchIcon.Location = new System.Drawing.Point(701, 92);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(33, 27);
            this.searchIcon.TabIndex = 17;
            this.searchIcon.UseVisualStyleBackColor = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1354, 705);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewInfoPanal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.List);
            this.Controls.Add(this.searchPanal);
            this.Name = "admin";
            this.Text = "admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.List.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.searchPanal.ResumeLayout(false);
            this.searchPanal.PerformLayout();
            this.NewInfoPanal.ResumeLayout(false);
            this.NewInfoPanal.PerformLayout();
            this.UserPassPanal.ResumeLayout(false);
            this.UserPassPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trueIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel List;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button nexto;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Logo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectPass;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectUser;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectName;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel searchPanal;
        private System.Windows.Forms.Button searchIcon;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Panel EditButtonPanal;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.Panel RemoveButtonPanal;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Panel NewInfoPanal;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel UserPassPanal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button OK;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectFaculty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox faculty;
        private System.Windows.Forms.PictureBox errCheck;
        private System.Windows.Forms.PictureBox errFaculty;
        private System.Windows.Forms.PictureBox errID;
        private System.Windows.Forms.PictureBox errName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RectErrorSearch;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.PictureBox trueIcon;
    }
}