namespace WindowsFormsApplication5
{
    partial class Start_Data_Visualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Data_Visualization));
            this.buttonSignin = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelGeneralHelp = new System.Windows.Forms.LinkLabel();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelConfirmpass = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.textBoxconfirmpass = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.panelGuestLogin = new System.Windows.Forms.Panel();
            this.buttonGuestlogin = new System.Windows.Forms.Button();
            this.textBoxEmailGuest = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSignin = new System.Windows.Forms.Panel();
            this.pictureBoxSignUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.errorProviderSignUp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGuestLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSignin
            // 
            this.buttonSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSignin.Location = new System.Drawing.Point(201, 131);
            this.buttonSignin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(130, 49);
            this.buttonSignin.TabIndex = 0;
            this.buttonSignin.Text = "Sign In";
            this.buttonSignin.UseVisualStyleBackColor = true;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUserName.Location = new System.Drawing.Point(16, 20);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(156, 32);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(16, 69);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(139, 32);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxUserName.Location = new System.Drawing.Point(192, 27);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(206, 26);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(192, 75);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(206, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // linkLabelGeneralHelp
            // 
            this.linkLabelGeneralHelp.AutoSize = true;
            this.linkLabelGeneralHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabelGeneralHelp.Location = new System.Drawing.Point(431, 143);
            this.linkLabelGeneralHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGeneralHelp.Name = "linkLabelGeneralHelp";
            this.linkLabelGeneralHelp.Size = new System.Drawing.Size(69, 26);
            this.linkLabelGeneralHelp.TabIndex = 6;
            this.linkLabelGeneralHelp.TabStop = true;
            this.linkLabelGeneralHelp.Text = "Help?";
            this.linkLabelGeneralHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // panelSignup
            // 
            this.panelSignup.AutoScroll = true;
            this.panelSignup.BackColor = System.Drawing.Color.LightGray;
            this.panelSignup.Controls.Add(this.SignUpButton);
            this.panelSignup.Controls.Add(this.pictureBox1);
            this.panelSignup.Controls.Add(this.labelConfirmpass);
            this.panelSignup.Controls.Add(this.labelpass);
            this.panelSignup.Controls.Add(this.labelEmail);
            this.panelSignup.Controls.Add(this.labelLN);
            this.panelSignup.Controls.Add(this.labelFN);
            this.panelSignup.Controls.Add(this.textBoxconfirmpass);
            this.panelSignup.Controls.Add(this.textBoxpass);
            this.panelSignup.Controls.Add(this.textBoxEmail);
            this.panelSignup.Controls.Add(this.textBoxLastName);
            this.panelSignup.Controls.Add(this.textBoxFirstName);
            this.panelSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSignup.Location = new System.Drawing.Point(1118, 429);
            this.panelSignup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(778, 485);
            this.panelSignup.TabIndex = 8;
            this.panelSignup.Visible = false;
            this.panelSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignup_Paint);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SignUpButton.Location = new System.Drawing.Point(320, 314);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(186, 49);
            this.SignUpButton.TabIndex = 19;
            this.SignUpButton.Text = "Sign up !";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelConfirmpass
            // 
            this.labelConfirmpass.AutoSize = true;
            this.labelConfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelConfirmpass.Location = new System.Drawing.Point(53, 257);
            this.labelConfirmpass.Name = "labelConfirmpass";
            this.labelConfirmpass.Size = new System.Drawing.Size(245, 32);
            this.labelConfirmpass.TabIndex = 16;
            this.labelConfirmpass.Text = "Confirm Password";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelpass.Location = new System.Drawing.Point(53, 214);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(139, 32);
            this.labelpass.TabIndex = 15;
            this.labelpass.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEmail.Location = new System.Drawing.Point(53, 159);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(87, 32);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLN.Location = new System.Drawing.Point(53, 108);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(151, 32);
            this.labelLN.TabIndex = 13;
            this.labelLN.Text = "Last Name";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFN.Location = new System.Drawing.Point(53, 61);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(152, 32);
            this.labelFN.TabIndex = 12;
            this.labelFN.Text = "First Name";
            // 
            // textBoxconfirmpass
            // 
            this.textBoxconfirmpass.AcceptsReturn = true;
            this.textBoxconfirmpass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxconfirmpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxconfirmpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxconfirmpass.Location = new System.Drawing.Point(320, 253);
            this.textBoxconfirmpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxconfirmpass.Name = "textBoxconfirmpass";
            this.textBoxconfirmpass.PasswordChar = '*';
            this.textBoxconfirmpass.Size = new System.Drawing.Size(341, 35);
            this.textBoxconfirmpass.TabIndex = 11;
            this.textBoxconfirmpass.TextChanged += new System.EventHandler(this.textBoxconfirmpass_TextChanged);
            // 
            // textBoxpass
            // 
            this.textBoxpass.AcceptsReturn = true;
            this.textBoxpass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxpass.Location = new System.Drawing.Point(320, 208);
            this.textBoxpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(341, 35);
            this.textBoxpass.TabIndex = 10;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AcceptsReturn = true;
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(320, 153);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.MaxLength = 30;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(341, 35);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AcceptsReturn = true;
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLastName.ForeColor = System.Drawing.Color.Black;
            this.textBoxLastName.Location = new System.Drawing.Point(320, 102);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(341, 35);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AcceptsReturn = true;
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Black;
            this.textBoxFirstName.Location = new System.Drawing.Point(320, 55);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(341, 35);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panelGuestLogin
            // 
            this.panelGuestLogin.BackColor = System.Drawing.Color.LightGray;
            this.panelGuestLogin.Controls.Add(this.buttonGuestlogin);
            this.panelGuestLogin.Controls.Add(this.textBoxEmailGuest);
            this.panelGuestLogin.Location = new System.Drawing.Point(91, 449);
            this.panelGuestLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGuestLogin.Name = "panelGuestLogin";
            this.panelGuestLogin.Size = new System.Drawing.Size(527, 151);
            this.panelGuestLogin.TabIndex = 9;
            // 
            // buttonGuestlogin
            // 
            this.buttonGuestlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuestlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuestlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGuestlogin.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonGuestlogin.Location = new System.Drawing.Point(72, 64);
            this.buttonGuestlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuestlogin.Name = "buttonGuestlogin";
            this.buttonGuestlogin.Size = new System.Drawing.Size(205, 56);
            this.buttonGuestlogin.TabIndex = 12;
            this.buttonGuestlogin.Text = "Guest Login";
            this.buttonGuestlogin.UseVisualStyleBackColor = false;
            this.buttonGuestlogin.Click += new System.EventHandler(this.buttonGuestlogin_Click);
            // 
            // textBoxEmailGuest
            // 
            this.textBoxEmailGuest.AcceptsReturn = true;
            this.textBoxEmailGuest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmailGuest.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEmailGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailGuest.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailGuest.Location = new System.Drawing.Point(22, 19);
            this.textBoxEmailGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmailGuest.MaxLength = 30;
            this.textBoxEmailGuest.Name = "textBoxEmailGuest";
            this.textBoxEmailGuest.Size = new System.Drawing.Size(280, 35);
            this.textBoxEmailGuest.TabIndex = 11;
            this.textBoxEmailGuest.Text = "Email";
            this.textBoxEmailGuest.Click += new System.EventHandler(this.textBoxEmailGuest_Click);
            this.textBoxEmailGuest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmailGuest_MouseClick);
            this.textBoxEmailGuest.TextChanged += new System.EventHandler(this.textBoxEmailGuest_TextChanged);
            this.textBoxEmailGuest.MouseLeave += new System.EventHandler(this.textBoxEmailGuest_MouseLeave);
            this.textBoxEmailGuest.MouseHover += new System.EventHandler(this.textBoxEmailGuest_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1898, 405);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panelSignin
            // 
            this.panelSignin.BackColor = System.Drawing.Color.LightGray;
            this.panelSignin.Controls.Add(this.labelUserName);
            this.panelSignin.Controls.Add(this.buttonSignin);
            this.panelSignin.Controls.Add(this.labelPassword);
            this.panelSignin.Controls.Add(this.linkLabelGeneralHelp);
            this.panelSignin.Controls.Add(this.textBoxUserName);
            this.panelSignin.Controls.Add(this.textBoxPassword);
            this.panelSignin.Location = new System.Drawing.Point(91, 682);
            this.panelSignin.Name = "panelSignin";
            this.panelSignin.Size = new System.Drawing.Size(527, 205);
            this.panelSignin.TabIndex = 11;
            // 
            // pictureBoxSignUp
            // 
            this.pictureBoxSignUp.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSignUp.Image")));
            this.pictureBoxSignUp.Location = new System.Drawing.Point(670, 458);
            this.pictureBoxSignUp.Name = "pictureBoxSignUp";
            this.pictureBoxSignUp.Size = new System.Drawing.Size(402, 142);
            this.pictureBoxSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSignUp.TabIndex = 12;
            this.pictureBoxSignUp.TabStop = false;
            this.pictureBoxSignUp.Click += new System.EventHandler(this.pictureBoxSignUp_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.BackgroundImage")));
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(688, 750);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(235, 137);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 13;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // errorProviderSignUp
            // 
            this.errorProviderSignUp.BlinkRate = 200;
            this.errorProviderSignUp.ContainerControl = this;
            // 
            // Start_Data_Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1908, 938);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxSignUp);
            this.Controls.Add(this.panelSignin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelGuestLogin);
            this.Controls.Add(this.panelSignup);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Start_Data_Visualization";
            this.Text = "Data Visualiztion Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGuestLogin.ResumeLayout(false);
            this.panelGuestLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSignin.ResumeLayout(false);
            this.panelSignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelGeneralHelp;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxconfirmpass;
        private System.Windows.Forms.Panel panelGuestLogin;
        private System.Windows.Forms.Button buttonGuestlogin;
        private System.Windows.Forms.TextBox textBoxEmailGuest;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelConfirmpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSignin;
        private System.Windows.Forms.PictureBox pictureBoxSignUp;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.ErrorProvider errorProviderSignUp;
    }
}

