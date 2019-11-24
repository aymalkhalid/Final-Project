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
            link.LinkData = @"Z:\WindowsFormsApplication5\WindowsFormsApplication5\HelpPage.html";
            linkLabelHelp.Links.Add(link);
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
            string signUpFirstName = textBoxFirstName.Text;

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            string signUpLastName = textBoxLastName.Text;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string signupEmail = textBoxEmail.Text;
        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {
            string signUpPassword = textBoxpass.Text;
        }

        private void textBoxconfirmpass_TextChanged(object sender, EventArgs e)
        {
            string signUpConfirmPassword = textBoxconfirmpass.Text;
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
            Form2 open = new Form2();
            open.Show();            
        }
    }
}
