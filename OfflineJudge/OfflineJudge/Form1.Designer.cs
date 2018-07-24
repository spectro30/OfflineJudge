namespace OfflineJudge
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Form1DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OJLogo = new System.Windows.Forms.PictureBox();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passwordBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.useridBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.signupbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 0;
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
            // OJLogo
            // 
            this.OJLogo.Image = ((System.Drawing.Image)(resources.GetObject("OJLogo.Image")));
            this.OJLogo.Location = new System.Drawing.Point(27, 96);
            this.OJLogo.Name = "OJLogo";
            this.OJLogo.Size = new System.Drawing.Size(256, 263);
            this.OJLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OJLogo.TabIndex = 1;
            this.OJLogo.TabStop = false;
            this.OJLogo.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SeaShell;
            this.LoginButton.IdleBorderThickness = 2;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.LoginButton.IdleForecolor = System.Drawing.Color.White;
            this.LoginButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.LoginButton.Location = new System.Drawing.Point(317, 252);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(342, 43);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
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
            this.passwordBox.Location = new System.Drawing.Point(411, 168);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(247, 27);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(312, 169);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(95, 22);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(312, 113);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(71, 22);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "User ID";
            // 
            // useridBox
            // 
            this.useridBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.useridBox.BorderColorFocused = System.Drawing.Color.White;
            this.useridBox.BorderColorIdle = System.Drawing.Color.White;
            this.useridBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.useridBox.BorderThickness = 1;
            this.useridBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.useridBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.useridBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.useridBox.ForeColor = System.Drawing.Color.White;
            this.useridBox.isPassword = false;
            this.useridBox.Location = new System.Drawing.Point(411, 112);
            this.useridBox.Margin = new System.Windows.Forms.Padding(4);
            this.useridBox.MaxLength = 32767;
            this.useridBox.Name = "useridBox";
            this.useridBox.Size = new System.Drawing.Size(247, 27);
            this.useridBox.TabIndex = 6;
            this.useridBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Forgot Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.ActiveBorderThickness = 1;
            this.signupbutton.ActiveCornerRadius = 20;
            this.signupbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.signupbutton.ActiveForecolor = System.Drawing.Color.White;
            this.signupbutton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.signupbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signupbutton.BackgroundImage")));
            this.signupbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupbutton.ButtonText = "SignUp";
            this.signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbutton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.Color.SeaShell;
            this.signupbutton.IdleBorderThickness = 2;
            this.signupbutton.IdleCornerRadius = 20;
            this.signupbutton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.signupbutton.IdleForecolor = System.Drawing.Color.White;
            this.signupbutton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(124)))), ((int)(((byte)(176)))));
            this.signupbutton.Location = new System.Drawing.Point(386, 354);
            this.signupbutton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(202, 44);
            this.signupbutton.TabIndex = 9;
            this.signupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupbutton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(445, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "New Here!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(695, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.useridBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.OJLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OJLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl Form1DragControl;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.PictureBox OJLogo;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label UserLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox useridBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 signupbutton;
        private System.Windows.Forms.Label label5;
    }
}

