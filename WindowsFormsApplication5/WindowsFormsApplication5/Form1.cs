using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Filing;
using Checks;
namespace WindowsFormsApplication5
{
    public partial class Start_Data_Visualization : Form
    {
        public Start_Data_Visualization()
        {
            InitializeComponent();
        }        
        string guestLoginPath = @"Z:\WindowsFormsApplication5\'Start Data Visualization' Form Files\GuestLogin.txt";
        string signInPath= @"Z:\WindowsFormsApplication5\'Start Data Visualization' Form Files\SignIn.txt";
        string signUpPath = @"Z:\WindowsFormsApplication5\'Start Data Visualization' Form Files\SignUp.txt";
        Writing objGuestloginWriting = new Writing();
        Writing objSignupWriting = new Writing();
        Writing objSignInWriting = new Writing();
        checkString objcheckNames = new checkString();
        bool flagNames = false;
        bool[] validationFlag = new bool[4];
        bool writeflag = false;
        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\HelpPage.html";
            linkLabelGeneralHelp.Links.Add(link);
            panelSignup.Visible = false;
            panelGuestLogin.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string registerUserName = textBoxUserName.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string registerUserPassword = textBoxPassword.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxconfirmpass_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelsignup_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxEmailGuest_TextChanged(object sender, EventArgs e)
        {
            string guestEmail = textBoxEmailGuest.Text;
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string[] sign_In = { userName, password };
            
            //foreach (string item in readingFile)
            //{
            //    if (textBoxUserName.Text == item && textBoxPassword.Text == item + 3 )
            //    {
            //Form2 open = new Form2();
            //open.Show();
            //    }
            //}           
            Connection open = new Connection();
            open.Show();
        }

        private void panelSignup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonCancel_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmailGuest_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmailGuest_MouseClick(object sender, MouseEventArgs e)
        {

            textBoxEmailGuest.Text = null;

        }

        private void textBoxEmailGuest_MouseHover(object sender, EventArgs e)
        {
            textBoxEmailGuest.Text = null;
        }

        private void textBoxEmailGuest_MouseLeave(object sender, EventArgs e)
        {
        }

        private void buttonGuestlogin_Click(object sender, EventArgs e)
        {
              if (textBoxEmailGuest.Text != null)
            {
                string guestEmail = textBoxEmailGuest.Text;
                try
                {
                    var addr = new System.Net.Mail.MailAddress(guestEmail);
                    string check = addr.Address;
                    
                    if (check == guestEmail && guestEmail != "Email")
                    {
                        guestEmail.ToLower();
                        string date = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
                        string[] guestLoginArray = { guestEmail,date};
                        objGuestloginWriting.writeLinesGuestLoginIn(guestLoginPath, guestLoginArray);
                        
                    }                   
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Enter A Correct Email or Sign Up ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

           }
            else
                {
                    
                        //MessageBox.Show(error.Message, "Enter A Correct Email or Sign Up ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            
        }

        private void pictureBoxSignUp_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            pictureBoxSignUp.Visible = false;
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }
       
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (validationFlag.Length == 4)
                {
                    foreach (bool item in validationFlag)
                    {
                        if (item == true)
                        {
                            writeflag = true;
                            
                        }
                        else
                        {
                            writeflag = false;                          
                        }
                    }
                    if (writeflag == false)
                    {
                        MessageBox.Show("Some of the Fields is empty");
                    }
                 
                }               
                if (writeflag == true)
                {
                            string fName = textBoxFirstName.Text;
                            string lName = textBoxLastName.Text;
                            string email = textBoxEmail.Text;
                            string password = textBoxpass.Text;
                            string confirmPass = textBoxconfirmpass.Text;
                            string[] signUp = { fName, lName, email, password, confirmPass };
                    objSignupWriting.writeLinesUserLoginIn(signUpPath,signUp);

                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Check The Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } // functionEnd

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBoxFirstName.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxFirstName, "Empty");
            }
            else if (textBoxFirstName.Text != string.Empty)
            {
                string checkFName = textBoxFirstName.Text;
                foreach (char item in checkFName)
                {
                    if (char.IsLetter(item))
                    {
                        flagNames = true;
                    }
                }
                if (flagNames == false)
                {
                    errorProvider1.SetError(textBoxFirstName, @"First Name Contains 'numbers or special character");
                }
                else if (flagNames == true)
                {
                    errorProvider2.SetError(textBoxFirstName, "Valid");
                    validationFlag[0] = true;
                }
            }           
                //        string checkLName = textBoxLastName.Text;
                //        string[] checkNames = { checkFName, checkLName };
                //        foreach (string item in checkNames)
                //        {
                //            foreach (char c in item)
                //            {
                //                if (char.IsLetter(c))
                //                {
                //                    flagNames = true;
                //                }
                //            }           
            }

        private void textBoxLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (textBoxLastName.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxLastName, "Empty");
            }
            else if (textBoxLastName.Text != string.Empty)
            {
                string lastName  = textBoxLastName.Text;
                foreach (char item in lastName)
                {
                    if (char.IsLetter(item))
                    {
                        flagNames = true;
                    }
                }
                if (flagNames == false)
                {
                    errorProvider1.SetError(textBoxLastName, @"First Name Contains 'numbers or special character");
                }
                else if (flagNames == true)
                {
                    errorProvider2.SetError(textBoxLastName, "Valid");
                    validationFlag[1] = true;
                }
            }            
        }

        private void textBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(textBoxEmail.ToString());
                string check = addr.Address;
                if (check == textBoxEmail.Text)
                {
                    errorProvider2.SetError(textBoxEmail, "Valid");
                    validationFlag[2] = true;
                }
                else if (check != textBoxEmail.Text)
                {
                    errorProvider1.SetError(textBoxEmail, "Invalid");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Enter A Correct Email ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void textBoxpass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool flagLetter = false;
            bool flagDigit = false;
            string checkpassword = textBoxpass.Text;
            if (checkpassword != string.Empty)
            {
                foreach (char item in checkpassword)
                {
                    if (char.IsLetter(item))
                    {
                        flagLetter = true;
                    }
                    else if (!char.IsLetter(item))
                    {
                        flagLetter = false;
                    }
                    else if (char.IsDigit(item))
                    {
                        flagDigit = true;
                    }
                    else if (!char.IsDigit(item))
                    {
                        flagDigit = false;
                    }
                }
            }
            else if (checkpassword == string.Empty)
            {
                errorProvider1.SetError(textBoxpass,"Empty");
            }
            if (flagLetter == true)
            {
                errorProvider1.SetError(textBoxpass, "Contains Only Letter");
            }
            else if (flagDigit == true)
            {
                errorProvider1.SetError(textBoxpass, "Contains Only Digits");
            }
            else if (checkpassword.Length < 5)
            {
                errorProvider1.SetError(textBoxpass, "Must Contain less than 5 characters");
            }
            else if (checkpassword.Length > 5)
            {
                errorProvider2.SetError(textBoxpass, "Valid");
                validationFlag[3] = true;
            }
        }

        private void textBoxconfirmpass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool flagLetter = false;
            bool flagDigit = false;
            string checkpassword = textBoxconfirmpass.Text;
            if (checkpassword != string.Empty)
            {
                foreach (char item in checkpassword)
                {
                    if (char.IsLetter(item))
                    {
                        flagLetter = true;
                    }
                    else if (!char.IsLetter(item))
                    {
                        flagLetter = false;
                    }
                    else if (char.IsDigit(item))
                    {
                        flagDigit = true;
                    }
                    else if (!char.IsDigit(item))
                    {
                        flagDigit = false;
                    }
                }
                if (flagLetter == true)
                {
                    errorProvider1.SetError(textBoxconfirmpass, "Contains Only Letter");
                }
                else if (flagDigit == true)
                {
                    errorProvider1.SetError(textBoxconfirmpass, "Contains Only Digits");
                }
            }
            else if (checkpassword == string.Empty)
            {
                errorProvider1.SetError(textBoxconfirmpass, "Empty");
            }
         
            else if (checkpassword.Length < 5)
            {
                errorProvider1.SetError(textBoxconfirmpass, "Must Contain More than 5 characters");
            }
            if (textBoxconfirmpass.Text == textBoxPassword.Text)
            {
                errorProvider2.SetError(textBoxconfirmpass, "Valid");
                validationFlag[4] = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSignin.Visible = false;
            panelGuestLogin.Visible = true;
        }
    }
    }

