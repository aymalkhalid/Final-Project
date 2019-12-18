using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Filing;
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
        Writing guestloginWriting = new Writing();
        Writing signupWriting = new Writing();
        Writing signInWriting = new Writing();
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
                        guestloginWriting.writeLinesGuestLoginIn(guestLoginPath, guestLoginArray);
                        
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
            if (textBoxFirstName.Text != null && textBoxLastName.Text !=null && textBoxEmail !=null && textBoxpass !=null && textBoxconfirmpass !=null)
            {
                if (textBoxpass.Text == textBoxconfirmpass.Text)
                {
                    string checkFName = textBoxFirstName.Text;
                    string checkLName = textBoxLastName.Text;
                    string[] checkNames = { checkFName, checkLName };
                    foreach (string item in checkNames)
                    {
                        for (int i = 0; i < item.Length; i++)
                        {

                        }

                    }
                    try
                    {
                        string fName = textBoxFirstName.Text;
                        string lName = textBoxLastName.Text;
                        string email = textBoxEmail.Text;
                        string password = textBoxpass.Text;
                        string confirmPass = textBoxconfirmpass.Text;
                        string[] signUp = { fName, lName, email, password, confirmPass };
                        signupWriting.writeLinesUserLoginIn(signUpPath, signUp);
                    }
                    catch (Exception e)
                    {

                        throw;
                    }
                }             
          }
            else
            {

            }

        } // functionEnd
            
            }

        }
    }
}
