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
            this.labelUserNameEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.linkLabelGeneralHelp = new System.Windows.Forms.LinkLabel();
            this.panelGuestLogin = new System.Windows.Forms.Panel();
            this.textBoxEmailGuest = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonGuestlogin = new System.Windows.Forms.Button();
            this.panelSignin = new System.Windows.Forms.Panel();
            this.textBoxEmailUser = new System.Windows.Forms.TextBox();
            this.textBoxPasswordUser = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSignUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.textBoxSignUpFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSignUPLastName = new System.Windows.Forms.TextBox();
            this.textBoxSignupEmail = new System.Windows.Forms.TextBox();
            this.textBoxSignuppass = new System.Windows.Forms.TextBox();
            this.textBoxSignUpconfirmpass = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.labelConfirmpass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUserSignIn = new System.Windows.Forms.Button();
            this.labelGuest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelWhatIsDataVisualization = new System.Windows.Forms.Label();
            this.panelGuestLogin.SuspendLayout();
            this.panelSignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserNameEmail
            // 
            this.labelUserNameEmail.AutoSize = true;
            this.labelUserNameEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUserNameEmail.Location = new System.Drawing.Point(27, 27);
            this.labelUserNameEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserNameEmail.Name = "labelUserNameEmail";
            this.labelUserNameEmail.Size = new System.Drawing.Size(206, 32);
            this.labelUserNameEmail.TabIndex = 2;
            this.labelUserNameEmail.Text = "Email_Address";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(56, 69);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(139, 32);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // linkLabelGeneralHelp
            // 
            this.linkLabelGeneralHelp.AutoSize = true;
            this.linkLabelGeneralHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabelGeneralHelp.Location = new System.Drawing.Point(107, 143);
            this.linkLabelGeneralHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGeneralHelp.Name = "linkLabelGeneralHelp";
            this.linkLabelGeneralHelp.Size = new System.Drawing.Size(69, 26);
            this.linkLabelGeneralHelp.TabIndex = 6;
            this.linkLabelGeneralHelp.TabStop = true;
            this.linkLabelGeneralHelp.Text = "Help?";
            this.linkLabelGeneralHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // panelGuestLogin
            // 
            this.panelGuestLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelGuestLogin.Controls.Add(this.textBoxEmailGuest);
            this.panelGuestLogin.Controls.Add(this.labelStatus);
            this.panelGuestLogin.Controls.Add(this.buttonGuestlogin);
            this.panelGuestLogin.Location = new System.Drawing.Point(588, 682);
            this.panelGuestLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGuestLogin.Name = "panelGuestLogin";
            this.panelGuestLogin.Size = new System.Drawing.Size(446, 163);
            this.panelGuestLogin.TabIndex = 9;
            // 
            // textBoxEmailGuest
            // 
            this.textBoxEmailGuest.AcceptsReturn = true;
            this.textBoxEmailGuest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmailGuest.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEmailGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailGuest.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailGuest.Location = new System.Drawing.Point(102, 26);
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
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStatus.Location = new System.Drawing.Point(270, 64);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 29);
            this.labelStatus.TabIndex = 18;
            // 
            // buttonGuestlogin
            // 
            this.buttonGuestlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuestlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuestlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGuestlogin.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonGuestlogin.Location = new System.Drawing.Point(148, 91);
            this.buttonGuestlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuestlogin.Name = "buttonGuestlogin";
            this.buttonGuestlogin.Size = new System.Drawing.Size(206, 57);
            this.buttonGuestlogin.TabIndex = 12;
            this.buttonGuestlogin.Text = "Guest Login";
            this.buttonGuestlogin.UseVisualStyleBackColor = false;
            this.buttonGuestlogin.Click += new System.EventHandler(this.buttonGuestlogin_Click);
            // 
            // panelSignin
            // 
            this.panelSignin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSignin.Controls.Add(this.textBoxEmailUser);
            this.panelSignin.Controls.Add(this.textBoxPasswordUser);
            this.panelSignin.Controls.Add(this.buttonLogin);
            this.panelSignin.Controls.Add(this.labelUserNameEmail);
            this.panelSignin.Controls.Add(this.labelPassword);
            this.panelSignin.Controls.Add(this.linkLabelGeneralHelp);
            this.panelSignin.Location = new System.Drawing.Point(557, 620);
            this.panelSignin.Name = "panelSignin";
            this.panelSignin.Size = new System.Drawing.Size(540, 185);
            this.panelSignin.TabIndex = 11;
            this.panelSignin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignin_Paint);
            // 
            // textBoxEmailUser
            // 
            this.textBoxEmailUser.AcceptsReturn = true;
            this.textBoxEmailUser.AcceptsTab = true;
            this.textBoxEmailUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmailUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxEmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailUser.Location = new System.Drawing.Point(255, 27);
            this.textBoxEmailUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmailUser.Name = "textBoxEmailUser";
            this.textBoxEmailUser.Size = new System.Drawing.Size(255, 35);
            this.textBoxEmailUser.TabIndex = 20;
            // 
            // textBoxPasswordUser
            // 
            this.textBoxPasswordUser.AcceptsReturn = true;
            this.textBoxPasswordUser.AcceptsTab = true;
            this.textBoxPasswordUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxPasswordUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxPasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPasswordUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordUser.Location = new System.Drawing.Point(255, 69);
            this.textBoxPasswordUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordUser.Name = "textBoxPasswordUser";
            this.textBoxPasswordUser.PasswordChar = '*';
            this.textBoxPasswordUser.Size = new System.Drawing.Size(255, 35);
            this.textBoxPasswordUser.TabIndex = 21;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogin.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonLogin.Location = new System.Drawing.Point(268, 127);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(206, 55);
            this.buttonLogin.TabIndex = 20;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1964, 405);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxSignUp
            // 
            this.pictureBoxSignUp.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSignUp.Image")));
            this.pictureBoxSignUp.Location = new System.Drawing.Point(796, 6);
            this.pictureBoxSignUp.Name = "pictureBoxSignUp";
            this.pictureBoxSignUp.Size = new System.Drawing.Size(383, 64);
            this.pictureBoxSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSignUp.TabIndex = 12;
            this.pictureBoxSignUp.TabStop = false;
            this.pictureBoxSignUp.Click += new System.EventHandler(this.pictureBoxSignUp_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.BackgroundImage")));
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1790, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(104, 74);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 13;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // textBoxSignUpFirstName
            // 
            this.textBoxSignUpFirstName.AcceptsReturn = true;
            this.textBoxSignUpFirstName.AcceptsTab = true;
            this.textBoxSignUpFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSignUpFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxSignUpFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSignUpFirstName.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignUpFirstName.Location = new System.Drawing.Point(349, 54);
            this.textBoxSignUpFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSignUpFirstName.Name = "textBoxSignUpFirstName";
            this.textBoxSignUpFirstName.Size = new System.Drawing.Size(341, 35);
            this.textBoxSignUpFirstName.TabIndex = 0;
            this.textBoxSignUpFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBoxSignUpFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirstName_Validating);
            this.textBoxSignUpFirstName.Validated += new System.EventHandler(this.textBoxFirstName_Validated);
            // 
            // textBoxSignUPLastName
            // 
            this.textBoxSignUPLastName.AcceptsReturn = true;
            this.textBoxSignUPLastName.AcceptsTab = true;
            this.textBoxSignUPLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSignUPLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxSignUPLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSignUPLastName.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignUPLastName.Location = new System.Drawing.Point(349, 101);
            this.textBoxSignUPLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSignUPLastName.Name = "textBoxSignUPLastName";
            this.textBoxSignUPLastName.Size = new System.Drawing.Size(341, 35);
            this.textBoxSignUPLastName.TabIndex = 1;
            this.textBoxSignUPLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            this.textBoxSignUPLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // textBoxSignupEmail
            // 
            this.textBoxSignupEmail.AcceptsReturn = true;
            this.textBoxSignupEmail.AcceptsTab = true;
            this.textBoxSignupEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSignupEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxSignupEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSignupEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignupEmail.Location = new System.Drawing.Point(349, 152);
            this.textBoxSignupEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSignupEmail.MaxLength = 30;
            this.textBoxSignupEmail.Name = "textBoxSignupEmail";
            this.textBoxSignupEmail.Size = new System.Drawing.Size(341, 35);
            this.textBoxSignupEmail.TabIndex = 10;
            this.textBoxSignupEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxSignupEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxSignuppass
            // 
            this.textBoxSignuppass.AcceptsReturn = true;
            this.textBoxSignuppass.AcceptsTab = true;
            this.textBoxSignuppass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSignuppass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxSignuppass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSignuppass.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignuppass.Location = new System.Drawing.Point(349, 207);
            this.textBoxSignuppass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSignuppass.Name = "textBoxSignuppass";
            this.textBoxSignuppass.PasswordChar = '*';
            this.textBoxSignuppass.Size = new System.Drawing.Size(341, 35);
            this.textBoxSignuppass.TabIndex = 10;
            this.textBoxSignuppass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            this.textBoxSignuppass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxpass_Validating);
            // 
            // textBoxSignUpconfirmpass
            // 
            this.textBoxSignUpconfirmpass.AcceptsReturn = true;
            this.textBoxSignUpconfirmpass.AcceptsTab = true;
            this.textBoxSignUpconfirmpass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxSignUpconfirmpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxSignUpconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSignUpconfirmpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxSignUpconfirmpass.Location = new System.Drawing.Point(349, 269);
            this.textBoxSignUpconfirmpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSignUpconfirmpass.Name = "textBoxSignUpconfirmpass";
            this.textBoxSignUpconfirmpass.PasswordChar = '*';
            this.textBoxSignUpconfirmpass.Size = new System.Drawing.Size(341, 35);
            this.textBoxSignUpconfirmpass.TabIndex = 11;
            this.textBoxSignUpconfirmpass.TextChanged += new System.EventHandler(this.textBoxconfirmpass_TextChanged);
            this.textBoxSignUpconfirmpass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxconfirmpass_Validating);
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelFN.Location = new System.Drawing.Point(82, 60);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(152, 32);
            this.labelFN.TabIndex = 12;
            this.labelFN.Text = "First Name";
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLN.Location = new System.Drawing.Point(82, 107);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(151, 32);
            this.labelLN.TabIndex = 13;
            this.labelLN.Text = "Last Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEmail.Location = new System.Drawing.Point(82, 158);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(87, 32);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelpass.Location = new System.Drawing.Point(82, 213);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(139, 32);
            this.labelpass.TabIndex = 15;
            this.labelpass.Text = "Password";
            // 
            // labelConfirmpass
            // 
            this.labelConfirmpass.AutoSize = true;
            this.labelConfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelConfirmpass.Location = new System.Drawing.Point(82, 269);
            this.labelConfirmpass.Name = "labelConfirmpass";
            this.labelConfirmpass.Size = new System.Drawing.Size(245, 32);
            this.labelConfirmpass.TabIndex = 16;
            this.labelConfirmpass.Text = "Confirm Password";
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
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SignUpButton.Location = new System.Drawing.Point(400, 352);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(193, 49);
            this.SignUpButton.TabIndex = 19;
            this.SignUpButton.Text = "Sign up !";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // panelSignup
            // 
            this.panelSignup.AutoScroll = true;
            this.panelSignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSignup.Controls.Add(this.SignUpButton);
            this.panelSignup.Controls.Add(this.pictureBox1);
            this.panelSignup.Controls.Add(this.labelConfirmpass);
            this.panelSignup.Controls.Add(this.labelpass);
            this.panelSignup.Controls.Add(this.labelEmail);
            this.panelSignup.Controls.Add(this.labelLN);
            this.panelSignup.Controls.Add(this.labelFN);
            this.panelSignup.Controls.Add(this.textBoxSignUpconfirmpass);
            this.panelSignup.Controls.Add(this.textBoxSignuppass);
            this.panelSignup.Controls.Add(this.textBoxSignupEmail);
            this.panelSignup.Controls.Add(this.textBoxSignUPLastName);
            this.panelSignup.Controls.Add(this.textBoxSignUpFirstName);
            this.panelSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSignup.Location = new System.Drawing.Point(1128, 413);
            this.panelSignup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(778, 460);
            this.panelSignup.TabIndex = 8;
            this.panelSignup.Visible = false;
            this.panelSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignup_Paint);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeftChanged += new System.EventHandler(this.errorProvider1_RightToLeftChanged);
            // 
            // ValidationProvider
            // 
            this.ValidationProvider.ContainerControl = this;
            this.ValidationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidationProvider.Icon")));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUserSignIn);
            this.panel1.Controls.Add(this.labelGuest);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Controls.Add(this.pictureBoxSignUp);
            this.panel1.Location = new System.Drawing.Point(12, 919);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 82);
            this.panel1.TabIndex = 15;
            // 
            // buttonUserSignIn
            // 
            this.buttonUserSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonUserSignIn.Location = new System.Drawing.Point(1329, 6);
            this.buttonUserSignIn.Name = "buttonUserSignIn";
            this.buttonUserSignIn.Size = new System.Drawing.Size(320, 50);
            this.buttonUserSignIn.TabIndex = 17;
            this.buttonUserSignIn.Text = "User Login";
            this.buttonUserSignIn.UseVisualStyleBackColor = true;
            this.buttonUserSignIn.Click += new System.EventHandler(this.buttonUserSignIn_Click);
            // 
            // labelGuest
            // 
            this.labelGuest.AutoSize = true;
            this.labelGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelGuest.Location = new System.Drawing.Point(14, 19);
            this.labelGuest.Name = "labelGuest";
            this.labelGuest.Size = new System.Drawing.Size(379, 37);
            this.labelGuest.TabIndex = 16;
            this.labelGuest.Text = "Using For the First Time?";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(420, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guest Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelHeading.Location = new System.Drawing.Point(27, 462);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(362, 32);
            this.labelHeading.TabIndex = 16;
            this.labelHeading.Text = "What is Data Visualization?";
            // 
            // labelWhatIsDataVisualization
            // 
            this.labelWhatIsDataVisualization.AutoSize = true;
            this.labelWhatIsDataVisualization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWhatIsDataVisualization.Location = new System.Drawing.Point(7, 497);
            this.labelWhatIsDataVisualization.Name = "labelWhatIsDataVisualization";
            this.labelWhatIsDataVisualization.Size = new System.Drawing.Size(625, 174);
            this.labelWhatIsDataVisualization.TabIndex = 17;
            this.labelWhatIsDataVisualization.Text = resources.GetString("labelWhatIsDataVisualization.Text");
            // 
            // Start_Data_Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1908, 1050);
            this.Controls.Add(this.panelSignin);
            this.Controls.Add(this.labelWhatIsDataVisualization);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelGuestLogin);
            this.Controls.Add(this.panelSignup);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Start_Data_Visualization";
            this.Text = "Data Visualiztion Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGuestLogin.ResumeLayout(false);
            this.panelGuestLogin.PerformLayout();
            this.panelSignin.ResumeLayout(false);
            this.panelSignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUserNameEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.LinkLabel linkLabelGeneralHelp;
        private System.Windows.Forms.Panel panelGuestLogin;
        private System.Windows.Forms.Button buttonGuestlogin;
        private System.Windows.Forms.TextBox textBoxEmailGuest;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSignin;
        private System.Windows.Forms.PictureBox pictureBoxSignUp;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.TextBox textBoxSignUpFirstName;
        private System.Windows.Forms.TextBox textBoxSignUPLastName;
        private System.Windows.Forms.TextBox textBoxSignupEmail;
        private System.Windows.Forms.TextBox textBoxSignuppass;
        private System.Windows.Forms.TextBox textBoxSignUpconfirmpass;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Label labelConfirmpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel panelSignup;
        public System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.ErrorProvider ValidationProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGuest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUserSignIn;
        private System.Windows.Forms.Label labelWhatIsDataVisualization;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxEmailUser;
        private System.Windows.Forms.TextBox textBoxPasswordUser;
        private System.Windows.Forms.Label labelStatus;
    }
}

