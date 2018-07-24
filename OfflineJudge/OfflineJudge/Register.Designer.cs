namespace OfflineJudge
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Form1DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UserLabel = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OJLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.repasswordBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CountryDropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.institutionlist = new Bunifu.Framework.UI.BunifuDropdown();
            this.label8 = new System.Windows.Forms.Label();
            this.emailBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OJLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 39);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "OFFLINE JUDGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(638, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(664, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1DragControl
            // 
            this.Form1DragControl.Fixed = true;
            this.Form1DragControl.Horizontal = true;
            this.Form1DragControl.TargetControl = this.panel1;
            this.Form1DragControl.Vertical = true;
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 10;
            this.FormElipse.TargetControl = this;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(202, 88);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(68, 21);
            this.UserLabel.TabIndex = 17;
            this.UserLabel.Text = "User ID";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.name.BorderColorFocused = System.Drawing.Color.White;
            this.name.BorderColorIdle = System.Drawing.Color.White;
            this.name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.name.BorderThickness = 1;
            this.name.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.isPassword = false;
            this.name.Location = new System.Drawing.Point(271, 88);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 27);
            this.name.TabIndex = 16;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.OnValueChanged += new System.EventHandler(this.userid_OnValueChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.LoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Register";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SeaShell;
            this.LoginButton.IdleBorderThickness = 2;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.LoginButton.IdleForecolor = System.Drawing.Color.White;
            this.LoginButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.LoginButton.Location = new System.Drawing.Point(206, 359);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(476, 43);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // OJLogo
            // 
            this.OJLogo.Image = ((System.Drawing.Image)(resources.GetObject("OJLogo.Image")));
            this.OJLogo.Location = new System.Drawing.Point(12, 55);
            this.OJLogo.Name = "OJLogo";
            this.OJLogo.Size = new System.Drawing.Size(179, 135);
            this.OJLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OJLogo.TabIndex = 12;
            this.OJLogo.TabStop = false;
            this.OJLogo.Click += new System.EventHandler(this.OJLogo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.passwordBox.BorderColorFocused = System.Drawing.Color.White;
            this.passwordBox.BorderColorIdle = System.Drawing.Color.White;
            this.passwordBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.passwordBox.BorderThickness = 1;
            this.passwordBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.isPassword = true;
            this.passwordBox.Location = new System.Drawing.Point(299, 242);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(383, 27);
            this.passwordBox.TabIndex = 20;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // repasswordBox
            // 
            this.repasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.repasswordBox.BorderColorFocused = System.Drawing.Color.White;
            this.repasswordBox.BorderColorIdle = System.Drawing.Color.White;
            this.repasswordBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.repasswordBox.BorderThickness = 1;
            this.repasswordBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.repasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repasswordBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.repasswordBox.ForeColor = System.Drawing.Color.White;
            this.repasswordBox.isPassword = true;
            this.repasswordBox.Location = new System.Drawing.Point(351, 300);
            this.repasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.repasswordBox.MaxLength = 32767;
            this.repasswordBox.Name = "repasswordBox";
            this.repasswordBox.Size = new System.Drawing.Size(331, 27);
            this.repasswordBox.TabIndex = 22;
            this.repasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.repasswordBox.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox2_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(202, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Insititution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(456, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Country";
            // 
            // CountryDropDown
            // 
            this.CountryDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.CountryDropDown.BorderRadius = 1;
            this.CountryDropDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountryDropDown.DisabledColor = System.Drawing.Color.Transparent;
            this.CountryDropDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryDropDown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CountryDropDown.items = new string[] {
        "Bangladesh",
        "Russia",
        "Argentina",
        "India",
        "Nepal",
        "China"};
            this.CountryDropDown.Location = new System.Drawing.Point(531, 88);
            this.CountryDropDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountryDropDown.Name = "CountryDropDown";
            this.CountryDropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.CountryDropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.CountryDropDown.selectedIndex = -1;
            this.CountryDropDown.Size = new System.Drawing.Size(152, 27);
            this.CountryDropDown.TabIndex = 26;
            this.CountryDropDown.onItemSelected += new System.EventHandler(this.CountryDropDown_onItemSelected);
            // 
            // institutionlist
            // 
            this.institutionlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.institutionlist.BorderRadius = 1;
            this.institutionlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.institutionlist.DisabledColor = System.Drawing.Color.Transparent;
            this.institutionlist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institutionlist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.institutionlist.items = new string[] {
        "Patukhali Science and Technology University",
        "Jessore Science and Technology University",
        "Sylhet Science and Technology University",
        "Noakhali Science and Technology University",
        "Hajee Danesh Science and Technology University",
        "Mawlana Bhashai Science and Technology University",
        "Bangladesh University of Engineering and Technology",
        "Rajshahi University of Engineering and Technology",
        "Khulna University of Engineering and Technology",
        "Chattagram University of Engineering and Technology"};
            this.institutionlist.Location = new System.Drawing.Point(299, 141);
            this.institutionlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.institutionlist.Name = "institutionlist";
            this.institutionlist.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.institutionlist.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.institutionlist.selectedIndex = -1;
            this.institutionlist.Size = new System.Drawing.Size(384, 27);
            this.institutionlist.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(202, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.emailBox.BorderColorFocused = System.Drawing.Color.White;
            this.emailBox.BorderColorIdle = System.Drawing.Color.White;
            this.emailBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.emailBox.BorderThickness = 1;
            this.emailBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.emailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.isPassword = false;
            this.emailBox.Location = new System.Drawing.Point(299, 190);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.MaxLength = 32767;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(383, 27);
            this.emailBox.TabIndex = 29;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(695, 434);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.institutionlist);
            this.Controls.Add(this.CountryDropDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repasswordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.OJLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OJLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl Form1DragControl;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.Label UserLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox name;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private System.Windows.Forms.PictureBox OJLogo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox repasswordBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown CountryDropDown;
        private Bunifu.Framework.UI.BunifuDropdown institutionlist;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox emailBox;


    }
}