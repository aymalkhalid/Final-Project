using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\HelpPage.html";
            linkLabelHelp.Links.Add(link);   
                    
        }
        string text = @"Z:\WindowsFormsApplication5\WindowsFormsApplication5\SignUpfile.txt";
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
            string signUpFirstName = textBoxFirstName.Text;
            string signUpLastName = textBoxLastName.Text;
            string signupEmail = textBoxEmail.Text;
            string signUpPassword = textBoxpass.Text;
            string signUpConfirmPassword = textBoxconfirmpass.Text;
            string[] signedUser = {signUpFirstName,signUpLastName,signupEmail,signUpPassword};            
            if (signUpConfirmPassword == signUpPassword)
            {
                using (StreamWriter outputFile = new StreamWriter(text, true))
                {
                    foreach (string item in signedUser)
                    {
                        outputFile.WriteLine(item);
                    }
                }
                MessageBox.Show("Congratulations On Signing Up");
            }
            
        }

        private void textBoxEmailGuest_TextChanged(object sender, EventArgs e)
        {
            string guestEmail = textBoxEmailGuest.Text;
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            string[] readingFile = File.ReadAllLines(text, Encoding.UTF8);
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
            MessageBox.Show("It Will terminate The Form");

        }

        private void buttonCancel_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
