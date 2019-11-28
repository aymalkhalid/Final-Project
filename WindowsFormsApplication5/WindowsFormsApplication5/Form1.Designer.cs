namespace WindowsFormsApplication5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSignin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.textBoxconfirmpass = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelsignup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGuestlogin = new System.Windows.Forms.Button();
            this.textBoxEmailGuest = new System.Windows.Forms.TextBox();
            this.panelSignup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSignin
            // 
            this.buttonSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSignin.Location = new System.Drawing.Point(502, 539);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(75, 31);
            this.buttonSignin.TabIndex = 0;
            this.buttonSignin.Text = "Sign In";
            this.buttonSignin.UseVisualStyleBackColor = true;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(635, 539);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseHover += new System.EventHandler(this.buttonCancel_MouseHover);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUserName.Location = new System.Drawing.Point(461, 415);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(100, 24);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "UserName";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(461, 469);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(92, 24);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(579, 419);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(139, 20);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(579, 473);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(139, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabelHelp.Location = new System.Drawing.Point(583, 545);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(46, 18);
            this.linkLabelHelp.TabIndex = 6;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "Help?";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.MinimumSize = new System.Drawing.Size(20, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(1273, 242);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelSignup
            // 
            this.panelSignup.AutoScroll = true;
            this.panelSignup.BackColor = System.Drawing.Color.Coral;
            this.panelSignup.Controls.Add(this.textBoxconfirmpass);
            this.panelSignup.Controls.Add(this.textBoxpass);
            this.panelSignup.Controls.Add(this.textBoxEmail);
            this.panelSignup.Controls.Add(this.textBoxLastName);
            this.panelSignup.Controls.Add(this.textBoxFirstName);
            this.panelSignup.Location = new System.Drawing.Point(12, 340);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(198, 166);
            this.panelSignup.TabIndex = 8;
            this.panelSignup.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSignup_Paint);
            // 
            // textBoxconfirmpass
            // 
            this.textBoxconfirmpass.AcceptsReturn = true;
            this.textBoxconfirmpass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxconfirmpass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxconfirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxconfirmpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxconfirmpass.Location = new System.Drawing.Point(3, 134);
            this.textBoxconfirmpass.Name = "textBoxconfirmpass";
            this.textBoxconfirmpass.Size = new System.Drawing.Size(188, 26);
            this.textBoxconfirmpass.TabIndex = 11;
            this.textBoxconfirmpass.Text = "Confirm Password";
            this.textBoxconfirmpass.UseWaitCursor = true;
            this.textBoxconfirmpass.TextChanged += new System.EventHandler(this.textBoxconfirmpass_TextChanged);
            // 
            // textBoxpass
            // 
            this.textBoxpass.AcceptsReturn = true;
            this.textBoxpass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxpass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxpass.ForeColor = System.Drawing.Color.Black;
            this.textBoxpass.Location = new System.Drawing.Point(3, 103);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(188, 26);
            this.textBoxpass.TabIndex = 10;
            this.textBoxpass.Text = "Password";
            this.textBoxpass.UseWaitCursor = true;
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AcceptsReturn = true;
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmail.Location = new System.Drawing.Point(3, 67);
            this.textBoxEmail.MaxLength = 30;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(188, 26);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.UseWaitCursor = true;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AcceptsReturn = true;
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLastName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLastName.ForeColor = System.Drawing.Color.Black;
            this.textBoxLastName.Location = new System.Drawing.Point(3, 35);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(188, 26);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.Text = "Last Name";
            this.textBoxLastName.UseWaitCursor = true;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AcceptsReturn = true;
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxFirstName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Black;
            this.textBoxFirstName.Location = new System.Drawing.Point(3, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(188, 26);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "First Name";
            this.textBoxFirstName.UseWaitCursor = true;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelsignup
            // 
            this.labelsignup.Image = ((System.Drawing.Image)(resources.GetObject("labelsignup.Image")));
            this.labelsignup.Location = new System.Drawing.Point(33, 539);
            this.labelsignup.Name = "labelsignup";
            this.labelsignup.Size = new System.Drawing.Size(138, 53);
            this.labelsignup.TabIndex = 9;
            this.labelsignup.Click += new System.EventHandler(this.labelsignup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.buttonGuestlogin);
            this.panel1.Controls.Add(this.textBoxEmailGuest);
            this.panel1.Location = new System.Drawing.Point(1038, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // buttonGuestlogin
            // 
            this.buttonGuestlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuestlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonGuestlogin.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonGuestlogin.Location = new System.Drawing.Point(8, 43);
            this.buttonGuestlogin.Name = "buttonGuestlogin";
            this.buttonGuestlogin.Size = new System.Drawing.Size(175, 49);
            this.buttonGuestlogin.TabIndex = 12;
            this.buttonGuestlogin.Text = "Guest Login";
            this.buttonGuestlogin.UseVisualStyleBackColor = false;
            // 
            // textBoxEmailGuest
            // 
            this.textBoxEmailGuest.AcceptsReturn = true;
            this.textBoxEmailGuest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxEmailGuest.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxEmailGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmailGuest.ForeColor = System.Drawing.Color.Black;
            this.textBoxEmailGuest.Location = new System.Drawing.Point(8, 4);
            this.textBoxEmailGuest.MaxLength = 30;
            this.textBoxEmailGuest.Name = "textBoxEmailGuest";
            this.textBoxEmailGuest.Size = new System.Drawing.Size(188, 26);
            this.textBoxEmailGuest.TabIndex = 11;
            this.textBoxEmailGuest.Text = "Email";
            this.textBoxEmailGuest.UseWaitCursor = true;
            this.textBoxEmailGuest.TextChanged += new System.EventHandler(this.textBoxEmailGuest_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1272, 610);
            this.Controls.Add(this.labelsignup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSignin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Data Visualiztion Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxconfirmpass;
        private System.Windows.Forms.Label labelsignup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGuestlogin;
        private System.Windows.Forms.TextBox textBoxEmailGuest;
    }
}

