using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void PanelSample_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Demo_Load(object sender, EventArgs e)
        {
            LinkLabel.Link linkStatic = new LinkLabel.Link();
            linkStatic.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\Static_Chart.html";
            linkLabel_Help_On_Static_Charts.Links.Add(linkStatic);
            LinkLabel.Link linkRealTime = new LinkLabel.Link();
            linkRealTime.LinkData = @"Z:\WindowsFormsApplication5\Html_HelpPages\Real_Time_Chart.html";
            linkLabel_Help_Real_Time_Charts.Links.Add(linkRealTime);
            string videoPath = @"Z:\WindowsFormsApplication5\Html_HelpPages\HtmlLiveChart.html";
            webBrowser1.Navigate(videoPath);
        }

        private void labelLineGraphHeading_Click(object sender, EventArgs e)
        {
            Data_Form_Line_Graph opendD_F_L_graph = new Data_Form_Line_Graph();
            opendD_F_L_graph.Show();
        }

        private void pictureBoxLine_Click(object sender, EventArgs e)
        {
            Data_Form_Line_Graph opendD_F_L_graph = new Data_Form_Line_Graph();
            opendD_F_L_graph.Show();
        }

        private void labelPieChartheading_Click(object sender, EventArgs e)
        {
            Bar_Chart open = new Bar_Chart();
            open.Show();
        }

        private void pictureBoxColumn_Click(object sender, EventArgs e)
        {
            Bar_Chart open = new Bar_Chart();
            open.Show();
        }

        private void labelPieChart_Click(object sender, EventArgs e)
        {

            Pie_Chart open = new Pie_Chart();
            open.Show();
        }

        private void pictureBoxPie_Click(object sender, EventArgs e)
        {

            Pie_Chart open = new Pie_Chart();
            open.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Demo close= new Demo();
            close.Close();
            Start_Data_Visualization back = new Start_Data_Visualization();
            back.Show();
        }
    }
}
