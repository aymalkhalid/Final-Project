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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Excel_WorkBook_Form open = new Excel_WorkBook_Form();
            open.Show();

        }

        private void Connection_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\ConnectionFormHelp.html";
            linkLabelOn_Connection.Links.Add(link);
        }

        private void linkLabelOn_Connection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void buttonfile_Click(object sender, EventArgs e)
        {
            TextFile_WorkBook_Form open = new TextFile_WorkBook_Form();
            open.Show();
        }
    }
}
