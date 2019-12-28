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
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApplication5
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            webBrowser1.ScrollBarsEnabled = false;
            ImageListfunc();

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
            LinkLabel.Link linkStatic = new LinkLabel.Link();
            linkStatic.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\Static_Chart.html";
            linkLabel_Help_On_Static_Charts.Links.Add(linkStatic);
            LinkLabel.Link linkRealTime = new LinkLabel.Link();
            linkRealTime.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\Real_Time_Chart.html";
            linkLabel_Help_Real_Time_Charts.Links.Add(linkRealTime);
            string videoPath = @"Z:\WindowsFormsApplication5\Html_HelpPages\HtmlLiveChart.html";
            webBrowser1.Navigate(videoPath);
            //image list
     
      
        }

        public void ImageListfunc()
        {


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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTryStatic_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelSample_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void tableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            ControlSetFocus(tableLayoutPanel1);
        }
        public void ControlSetFocus(Control control)
        {
            // Set focus to the control, if it can receive focus.
            if (control.CanFocus)
            {
                control.Focus();
            }
        }
        private void pictureBoxpieChartstatic_MouseHover(object sender, EventArgs e)
        {
            ControlSetFocus(pictureBoxpieChartstatic);
        }

        private void labelBarGraphdef_Click(object sender, EventArgs e)
        {

        }

        private void labelLineGraphHeading_Click(object sender, EventArgs e)
        {
            Data_Form_Line_Graph opendD_F_L_graph = new Data_Form_Line_Graph();
            opendD_F_L_graph.Show();
        }

        private void linkLabel_Help_Real_Time_Charts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void axShockwaveFlash_Real_Time_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxLine_Click(object sender, EventArgs e)
        {
            Data_Form_Line_Graph opendD_F_L_graph = new Data_Form_Line_Graph();
            opendD_F_L_graph.Show();
        }

        private void linkLabel_Help_On_Static_Charts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void labelPieChartheading_Click(object sender, EventArgs e)
        {
            Bar_Chart open = new Bar_Chart();
            open.Show();
        }

        private void labelBar_Graphheading_Click(object sender, EventArgs e)
        {

            Pie_Chart open = new Pie_Chart();
            open.Show();
        }

        private void pictureBoxPie_Click(object sender, EventArgs e)
        {
            Pie_Chart open = new Pie_Chart();
            open.Show();
        }

        private void pictureBoxColumn_Click(object sender, EventArgs e)
        {
            Bar_Chart open = new Bar_Chart();
            open.Show();
        }

        private void buttonDataBase_Click(object sender, EventArgs e)
        {
            DataBase open = new DataBase();
            open.Show();
        }
    }
}
