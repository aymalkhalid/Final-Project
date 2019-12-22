using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Filing;
using Checks;
using System.Collections.Generic;
using System.Linq;

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
        string passwordRetrived = "";
        string emailRetrived = "";
        bool fNFlag = false;
        bool lNFlag = false;
        bool passwordFlag = false;
        bool confirmPasswordFlag = false;
        bool emailflag = false;
        bool[] validationFlag = new bool[4];
        bool connectionFormFlag = false;
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
            string registerUserName = textBoxEmailUser.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string registerUserPassword = textBoxPasswordUser.Text;
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
            panelSignin.Visible = false;
            panelGuestLogin.Visible = false;
            panelSignup.Visible = true;
          //  pictureBoxSignUp.Visible = false;
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
                if (fNFlag == true && lNFlag == true && passwordFlag == true && confirmPasswordFlag == true && emailflag == true)
                {
                    string fName = textBoxSignUpFirstName.Text;
                    string lName = textBoxSignUPLastName.Text;
                    string email = textBoxSignupEmail.Text.ToLower();
                    string password = textBoxSignuppass.Text;
                    string confirmPass = textBoxSignUpconfirmpass.Text;
                    string[] signUp = { fName, lName, email, password, confirmPass };
                    objSignupWriting.writeLinesUserLoginIn(signUpPath, signUp);
                    panelSignin.Visible = true;
                    panelSignup.Visible = false;
                    labelStatus.Text = "Congratulations On Signing Up Press The Button Below To Sign_IN";
                    //}
                }
                else 
                {
                    MessageBox.Show("Some Of the Fields are Empty",
                 "Important Note",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
                }

                //if (validationFlag.Length == 4)
                //{
                //    foreach (bool item in validationFlag)
                //    {
                //        if (item == true)
                //        {
                //            writeflag = true;

                //        }
                //        else
                //        {
                //            writeflag = false;                          
                //        }
                //    }
                //    if (writeflag == false)
                //    {
                //        MessageBox.Show("Some of the Fields are empty");
                //    }

                //}               
                //if (writeflag == true)
                //{                                   
                //    string[] reading = File.ReadAllLines(signUpPath, Encoding.UTF8);
                //    //objSignInWriting.writeLinesUserLoginIn(signInPath, reading);
                //    List<string> readingList = reading.ToList();
                //    int indexOFEmail = 0;
                //     foreach (string item in readingList)
                //        {
                //            if (item == textBoxEmailUser.Text)
                //            {
                //                indexOFEmail = readingList.IndexOf(textBoxSignupEmail.Text);
                //            }
                //        }             
                //        emailRetrived = reading[indexOFEmail];
                //    //if (emailRetrived == textBoxSignupEmail.Text)
                //    //{
                //        string fName = textBoxSignUpFirstName.Text;
                //        string lName = textBoxSignUPLastName.Text;
                //        string email = textBoxSignupEmail.Text.ToLower();
                //        string password = textBoxSignuppass.Text;
                //        string confirmPass = textBoxSignUpconfirmpass.Text;
                //        string[] signUp = { fName, lName, email, password, confirmPass };
                //        objSignupWriting.writeLinesUserLoginIn(signUpPath, signUp);
                //        panelSignin.Visible = true;
                //        panelSignup.Visible = false;
                //        labelStatus.Text = "Congratulations On Signing Up Press The Button Below To Sign_IN";
                //    //}
                //}
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Some OF the fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (textBoxSignUpFirstName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxSignUpFirstName, "Empty");
            }
            else if (textBoxSignUpFirstName.Text != string.Empty)
            {
                string checkFName = textBoxSignUpFirstName.Text;
                foreach (char item in checkFName)
                {
                    if (char.IsLetter(item))
                    {
                        fNFlag = true;
                    }
                }
                if (fNFlag == false)
                {
                    errorProvider.SetError(textBoxSignUpFirstName, @"First Name Contains 'numbers or special character");
                }
                else if (fNFlag == true)
                {
                    ValidationProvider.SetError(textBoxSignUpFirstName, "Valid");
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

            if (textBoxSignUPLastName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxSignUPLastName, "Empty");
            }
            else if (textBoxSignUPLastName.Text != string.Empty)
            {
                string lastName  = textBoxSignUPLastName.Text;
                foreach (char item in lastName)
                {
                    if (char.IsLetter(item))
                    {
                        lNFlag = true;
                    }
                }
                if (lNFlag == false)
                {
                    errorProvider.SetError(textBoxSignUPLastName, @"First Name Contains 'numbers or special character");
                }
                else if (lNFlag == true)
                {
                    ValidationProvider.SetError(textBoxSignUPLastName, "Valid");
                    validationFlag[1] = true;
                }
            }            
        }

        private void textBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                string[] reading = File.ReadAllLines(signUpPath, Encoding.UTF8);
                //objSignInWriting.writeLinesUserLoginIn(signInPath, reading);
                List<string> readingList = reading.ToList();
                int indexOFEmail = 0;
                foreach (string item in readingList)
                {
                    if (item == textBoxSignupEmail.Text)
                    {
                        indexOFEmail = readingList.IndexOf(textBoxSignupEmail.Text);
                    }
                }
                emailRetrived = reading[indexOFEmail];
                var addressVerification = new System.Net.Mail.MailAddress(textBoxSignupEmail.Text);
                string check = addressVerification.Address;
                if (check == emailRetrived)
                {
                    errorProvider.SetError(textBoxSignupEmail, "Already In Use");
                }
               else  if (check == textBoxSignupEmail.Text)
                {
                    ValidationProvider.SetError(textBoxSignupEmail, "Valid");
                   emailflag = true;
                }
                else if (check != textBoxSignupEmail.Text)
                {
                    errorProvider.SetError(textBoxSignupEmail, "Invalid");
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
            string checkpassword = textBoxSignuppass.Text;
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
                errorProvider.SetError(textBoxSignuppass,"Empty");
            }
            if (flagLetter == true)
            {
                errorProvider.SetError(textBoxSignuppass, "Contains Only Letter");
            }
            else if (flagDigit == true)
            {
                errorProvider.SetError(textBoxSignuppass, "Contains Only Digits");
            }
            else if (checkpassword.Length < 5)
            {
                errorProvider.SetError(textBoxSignuppass, "Must Contain less than 5 characters");
            }
            else if (checkpassword.Length > 5)
            {
                ValidationProvider.SetError(textBoxSignuppass, "Valid");
                passwordFlag = true;
            }
        }

        private void textBoxconfirmpass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool flagLetter = false;
            bool flagDigit = false;
            string checkpassword = textBoxSignUpconfirmpass.Text;
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
                    errorProvider.SetError(textBoxSignUpconfirmpass, "Contains Only Letter");
                }
                else if (flagDigit == true)
                {
                    errorProvider.SetError(textBoxSignUpconfirmpass, "Contains Only Digits");
                }
            }
            else if (checkpassword == string.Empty)
            {
                errorProvider.SetError(textBoxSignUpconfirmpass, "Empty");
            }
         
            else if (checkpassword.Length < 5)
            {
                errorProvider.SetError(textBoxSignUpconfirmpass, "Must Contain More than 5 characters");
            }
            if (textBoxSignUpconfirmpass.Text == textBoxSignuppass.Text)
            {
                ValidationProvider.SetError(textBoxSignUpconfirmpass, "Valid");
                confirmPasswordFlag = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSignin.Visible = false;
            panelSignup.Visible = false;
            panelGuestLogin.Visible = true;
        }

        private void buttonUserSignIn_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = false;
            panelGuestLogin.Visible = false;
            panelSignin.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //string userName_Email = textBoxEmailUser.Text;
            //string userNamePassword = textBoxPasswordUser.Text;
            //string date = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
            //string[] sign_In = { userName_Email, userNamePassword, date };
            //string[] reading = File.ReadAllLines(signUpPath, Encoding.UTF8);
            ////objSignInWriting.writeLinesUserLoginIn(signInPath, reading);
            //List<string> readingList = reading.ToList();
            //int indexOFEmail = 0;
            //try
            //{
            //    foreach (string item in readingList)
            //    {
            //        if (item == userName_Email)
            //        {
            //           indexOFEmail = readingList.IndexOf(userName_Email);                        
            //        }
            //    }
            //    int indexOFPassword = indexOFEmail + 1;
            //    emailRetrived= reading[indexOFEmail];
            //    passwordRetrived = reading[indexOFPassword];                
            //    if (emailRetrived == userName_Email && passwordRetrived == userNamePassword)
            //    {

            //        objSignInWriting.writeLinesUserLoginIn(signInPath, sign_In);
            //        connectionFormFlag = true;
            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message, "Enter A Correct Email or Check PassWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //try
            //{                    
            //    var addr = new System.Net.Mail.MailAddress(textBoxEmailUser.Text.ToString());
            //    string check = addr.Address;
            //    if (check == textBoxEmailUser.Text && check ==emailRetrived)
            //    {
            //        ValidationProvider.SetError(textBoxEmailUser, "Valid");
            //    }
            //    else if (textBoxEmailUser.Text == string.Empty )
            //    {
            //        errorProvider.SetError(textBoxEmailUser, "Empty");
            //    }
            //    else if (check != textBoxEmailUser.Text || check != emailRetrived)
            //    {
            //        errorProvider.SetError(textBoxEmailUser, "Invalid");
            //    }
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message, "Enter A Correct Email ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //try
            //{
            //    if (userNamePassword == passwordRetrived)
            //    {
            //        ValidationProvider.SetError(textBoxPasswordUser, "Valid");
            //    }
            //    else if (userNamePassword != passwordRetrived)
            //    {
            //        errorProvider.SetError(textBoxPasswordUser, "Invalid");
            //    }
            //    else if (userNamePassword == string.Empty)
            //    {
            //        errorProvider.SetError(textBoxPasswordUser,"Empty");
            //    }
            //}
            //catch (Exception error)
            //{

            //    MessageBox.Show(error.Message, "Enter A Correct Email ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (connectionFormFlag == true)
            //{
                Connection open = new Connection();
               open.Show();
            //}
        }

        private void panelSignin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

