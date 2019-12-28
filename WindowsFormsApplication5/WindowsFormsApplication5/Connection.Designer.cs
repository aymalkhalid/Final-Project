namespace WindowsFormsApplication5
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.panelConnect = new System.Windows.Forms.Panel();
            this.linkLabelOn_Connection = new System.Windows.Forms.LinkLabel();
            this.labelServer = new System.Windows.Forms.Label();
            this.buttonDataBase = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxpieChartstatic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelReal_Time_Charts = new System.Windows.Forms.Label();
            this.label_Static_Charts = new System.Windows.Forms.Label();
            this.linkLabel_Help_Real_Time_Charts = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Help_On_Static_Charts = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain_Header = new System.Windows.Forms.PictureBox();
            this.panel_Try_Grap = new System.Windows.Forms.Panel();
            this.labelLine_Graph_ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelpie__chartdef = new System.Windows.Forms.Label();
            this.labelBarGraphdef = new System.Windows.Forms.Label();
            this.pictureBoxPie = new System.Windows.Forms.PictureBox();
            this.labelPieChart = new System.Windows.Forms.Label();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxColumn = new System.Windows.Forms.PictureBox();
            this.labelPieChartheading = new System.Windows.Forms.Label();
            this.labelLineGraphHeading = new System.Windows.Forms.Label();
            this.PanelSample = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.photoList = new System.Windows.Forms.ImageList(this.components);
            this.panelConnect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpieChartstatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain_Header)).BeginInit();
            this.panel_Try_Grap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).BeginInit();
            this.PanelSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConnect
            // 
            this.panelConnect.BackColor = System.Drawing.Color.SteelBlue;
            this.panelConnect.Controls.Add(this.linkLabelOn_Connection);
            this.panelConnect.Controls.Add(this.labelServer);
            this.panelConnect.Controls.Add(this.buttonDataBase);
            this.panelConnect.Controls.Add(this.buttonExcel);
            this.panelConnect.Controls.Add(this.labelFile);
            this.panelConnect.Controls.Add(this.labelConnect);
            this.panelConnect.ForeColor = System.Drawing.Color.Black;
            this.panelConnect.Location = new System.Drawing.Point(14, 6);
            this.panelConnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(486, 954);
            this.panelConnect.TabIndex = 3;
            // 
            // linkLabelOn_Connection
            // 
            this.linkLabelOn_Connection.AutoSize = true;
            this.linkLabelOn_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.linkLabelOn_Connection.LinkColor = System.Drawing.Color.Black;
            this.linkLabelOn_Connection.Location = new System.Drawing.Point(4, 626);
            this.linkLabelOn_Connection.Name = "linkLabelOn_Connection";
            this.helpProvider1.SetShowHelp(this.linkLabelOn_Connection, true);
            this.linkLabelOn_Connection.Size = new System.Drawing.Size(472, 96);
            this.linkLabelOn_Connection.TabIndex = 5;
            this.linkLabelOn_Connection.TabStop = true;
            this.linkLabelOn_Connection.Text = "->Confused on which file to choose?\r\n-> where to start at?\r\nClick Here or Press F" +
    "1 for Help!\r\n";
            this.linkLabelOn_Connection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOn_Connection_LinkClicked);
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelServer.ForeColor = System.Drawing.Color.White;
            this.labelServer.Location = new System.Drawing.Point(24, 340);
            this.labelServer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(177, 42);
            this.labelServer.TabIndex = 3;
            this.labelServer.Text = "DataBase";
            // 
            // buttonDataBase
            // 
            this.buttonDataBase.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDataBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDataBase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDataBase.FlatAppearance.BorderSize = 2;
            this.buttonDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F);
            this.buttonDataBase.Image = ((System.Drawing.Image)(resources.GetObject("buttonDataBase.Image")));
            this.buttonDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataBase.Location = new System.Drawing.Point(0, 432);
            this.buttonDataBase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDataBase.Name = "buttonDataBase";
            this.buttonDataBase.Size = new System.Drawing.Size(476, 103);
            this.buttonDataBase.TabIndex = 3;
            this.buttonDataBase.Text = "DataBase";
            this.buttonDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDataBase.UseVisualStyleBackColor = false;
            this.buttonDataBase.Click += new System.EventHandler(this.buttonDataBase_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExcel.BackColor = System.Drawing.Color.LightCyan;
            this.buttonExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonExcel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcel.Image")));
            this.buttonExcel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonExcel.Location = new System.Drawing.Point(5, 145);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(475, 110);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "                 Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelFile.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelFile.Location = new System.Drawing.Point(17, 80);
            this.labelFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(255, 40);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "For Excel Files";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.labelConnect.Location = new System.Drawing.Point(5, 28);
            this.labelConnect.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(419, 52);
            this.labelConnect.TabIndex = 0;
            this.labelConnect.Text = "Explore  WorkBooks";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Z:\\WindowsFormsApplication5\\Html_HelpPages\\ConnectionFormHelp.html";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.13443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.86558F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxpieChartstatic, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 635);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 314);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.tableLayoutPanel1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(326, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 308);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxpieChartstatic
            // 
            this.pictureBoxpieChartstatic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxpieChartstatic.Image")));
            this.pictureBoxpieChartstatic.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxpieChartstatic.Name = "pictureBoxpieChartstatic";
            this.pictureBoxpieChartstatic.Size = new System.Drawing.Size(307, 308);
            this.pictureBoxpieChartstatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxpieChartstatic.TabIndex = 8;
            this.pictureBoxpieChartstatic.TabStop = false;
            this.pictureBoxpieChartstatic.MouseHover += new System.EventHandler(this.pictureBoxpieChartstatic_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(687, 638);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(297, 308);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // labelReal_Time_Charts
            // 
            this.labelReal_Time_Charts.AutoSize = true;
            this.labelReal_Time_Charts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(237)))));
            this.labelReal_Time_Charts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelReal_Time_Charts.Location = new System.Drawing.Point(4, 64);
            this.labelReal_Time_Charts.Name = "labelReal_Time_Charts";
            this.labelReal_Time_Charts.Size = new System.Drawing.Size(265, 37);
            this.labelReal_Time_Charts.TabIndex = 8;
            this.labelReal_Time_Charts.Text = "Real Time Charts";
            // 
            // label_Static_Charts
            // 
            this.label_Static_Charts.AutoSize = true;
            this.label_Static_Charts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(237)))));
            this.label_Static_Charts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Static_Charts.Location = new System.Drawing.Point(17, 569);
            this.label_Static_Charts.Name = "label_Static_Charts";
            this.label_Static_Charts.Size = new System.Drawing.Size(201, 37);
            this.label_Static_Charts.TabIndex = 9;
            this.label_Static_Charts.Text = "Static Charts";
            // 
            // linkLabel_Help_Real_Time_Charts
            // 
            this.linkLabel_Help_Real_Time_Charts.AutoSize = true;
            this.linkLabel_Help_Real_Time_Charts.BackColor = System.Drawing.Color.SteelBlue;
            this.linkLabel_Help_Real_Time_Charts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Help_Real_Time_Charts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Help_Real_Time_Charts.Location = new System.Drawing.Point(291, 70);
            this.linkLabel_Help_Real_Time_Charts.Name = "linkLabel_Help_Real_Time_Charts";
            this.linkLabel_Help_Real_Time_Charts.Size = new System.Drawing.Size(425, 29);
            this.linkLabel_Help_Real_Time_Charts.TabIndex = 10;
            this.linkLabel_Help_Real_Time_Charts.TabStop = true;
            this.linkLabel_Help_Real_Time_Charts.Text = "Get Help On What is Realtime Charts ?";
            this.linkLabel_Help_Real_Time_Charts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Help_Real_Time_Charts_LinkClicked);
            // 
            // linkLabel_Help_On_Static_Charts
            // 
            this.linkLabel_Help_On_Static_Charts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_Help_On_Static_Charts.AutoSize = true;
            this.linkLabel_Help_On_Static_Charts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Help_On_Static_Charts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Help_On_Static_Charts.Location = new System.Drawing.Point(242, 577);
            this.linkLabel_Help_On_Static_Charts.Name = "linkLabel_Help_On_Static_Charts";
            this.linkLabel_Help_On_Static_Charts.Size = new System.Drawing.Size(372, 29);
            this.linkLabel_Help_On_Static_Charts.TabIndex = 11;
            this.linkLabel_Help_On_Static_Charts.TabStop = true;
            this.linkLabel_Help_On_Static_Charts.Text = "Get Help On what  is Static Charts";
            this.linkLabel_Help_On_Static_Charts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Help_On_Static_Charts_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(527, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 951);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxMain_Header
            // 
            this.pictureBoxMain_Header.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain_Header.Image")));
            this.pictureBoxMain_Header.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMain_Header.Name = "pictureBoxMain_Header";
            this.pictureBoxMain_Header.Size = new System.Drawing.Size(1028, 52);
            this.pictureBoxMain_Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain_Header.TabIndex = 16;
            this.pictureBoxMain_Header.TabStop = false;
            // 
            // panel_Try_Grap
            // 
            this.panel_Try_Grap.Controls.Add(this.labelLine_Graph_);
            this.panel_Try_Grap.Controls.Add(this.label6);
            this.panel_Try_Grap.Controls.Add(this.labelpie__chartdef);
            this.panel_Try_Grap.Controls.Add(this.labelBarGraphdef);
            this.panel_Try_Grap.Controls.Add(this.pictureBoxPie);
            this.panel_Try_Grap.Controls.Add(this.labelPieChart);
            this.panel_Try_Grap.Controls.Add(this.pictureBoxLine);
            this.panel_Try_Grap.Controls.Add(this.pictureBoxColumn);
            this.panel_Try_Grap.Controls.Add(this.labelPieChartheading);
            this.panel_Try_Grap.Controls.Add(this.labelLineGraphHeading);
            this.panel_Try_Grap.ForeColor = System.Drawing.SystemColors.MenuText;
            this.panel_Try_Grap.Location = new System.Drawing.Point(1652, 6);
            this.panel_Try_Grap.Name = "panel_Try_Grap";
            this.panel_Try_Grap.Size = new System.Drawing.Size(271, 951);
            this.panel_Try_Grap.TabIndex = 17;
            // 
            // labelLine_Graph_
            // 
            this.labelLine_Graph_.AutoSize = true;
            this.labelLine_Graph_.Location = new System.Drawing.Point(10, 73);
            this.labelLine_Graph_.Name = "labelLine_Graph_";
            this.labelLine_Graph_.Size = new System.Drawing.Size(258, 140);
            this.labelLine_Graph_.TabIndex = 26;
            this.labelLine_Graph_.Text = "Line graphs show dependent data, \r\nparticularly trends over time.\r\n--------------" +
    "--Example----------------\r\nLine graphs depict a point value\r\nfor each category, " +
    "\r\nwhich are joined in a line. \r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Click Below To Try";
            // 
            // labelpie__chartdef
            // 
            this.labelpie__chartdef.AutoSize = true;
            this.labelpie__chartdef.Location = new System.Drawing.Point(1, 658);
            this.labelpie__chartdef.Name = "labelpie__chartdef";
            this.labelpie__chartdef.Size = new System.Drawing.Size(256, 120);
            this.labelpie__chartdef.TabIndex = 25;
            this.labelpie__chartdef.Text = "A pie chart is cut up into segments.\r\nThe whole breaks down into parts.\r\n--------" +
    "--------Example----------------\r\nSome Data \r\nSales figures for a year, \r\nbroken " +
    "down by quarters";
            // 
            // labelBarGraphdef
            // 
            this.labelBarGraphdef.AutoSize = true;
            this.labelBarGraphdef.Location = new System.Drawing.Point(6, 357);
            this.labelBarGraphdef.Name = "labelBarGraphdef";
            this.labelBarGraphdef.Size = new System.Drawing.Size(238, 120);
            this.labelBarGraphdef.TabIndex = 24;
            this.labelBarGraphdef.Text = "Bar Graphs show numbers that, \r\nare independent of each other.\r\n----------------E" +
    "xample----------------\r\nSome Data \r\nCategory 1 4.1,Category 2 2.5\r\nCategory 3 3." +
    "5,Category 4 4.7\r\n";
            this.labelBarGraphdef.Click += new System.EventHandler(this.labelBarGraphdef_Click);
            // 
            // pictureBoxPie
            // 
            this.pictureBoxPie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPie.Image")));
            this.pictureBoxPie.Location = new System.Drawing.Point(5, 781);
            this.pictureBoxPie.Name = "pictureBoxPie";
            this.pictureBoxPie.Size = new System.Drawing.Size(263, 165);
            this.pictureBoxPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPie.TabIndex = 23;
            this.pictureBoxPie.TabStop = false;
            this.pictureBoxPie.Click += new System.EventHandler(this.pictureBoxPie_Click);
            // 
            // labelPieChart
            // 
            this.labelPieChart.AutoSize = true;
            this.labelPieChart.BackColor = System.Drawing.Color.SteelBlue;
            this.labelPieChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPieChart.ForeColor = System.Drawing.Color.Black;
            this.labelPieChart.Location = new System.Drawing.Point(8, 626);
            this.labelPieChart.Name = "labelPieChart";
            this.labelPieChart.Size = new System.Drawing.Size(133, 32);
            this.labelPieChart.TabIndex = 17;
            this.labelPieChart.Text = "Pie Chart";
            this.labelPieChart.Click += new System.EventHandler(this.labelBar_Graphheading_Click);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(10, 216);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(243, 95);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 18;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
            // 
            // pictureBoxColumn
            // 
            this.pictureBoxColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColumn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColumn.Image")));
            this.pictureBoxColumn.Location = new System.Drawing.Point(3, 477);
            this.pictureBoxColumn.Name = "pictureBoxColumn";
            this.pictureBoxColumn.Size = new System.Drawing.Size(250, 129);
            this.pictureBoxColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColumn.TabIndex = 22;
            this.pictureBoxColumn.TabStop = false;
            this.pictureBoxColumn.Click += new System.EventHandler(this.pictureBoxColumn_Click);
            // 
            // labelPieChartheading
            // 
            this.labelPieChartheading.AutoSize = true;
            this.labelPieChartheading.BackColor = System.Drawing.Color.SteelBlue;
            this.labelPieChartheading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPieChartheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPieChartheading.ForeColor = System.Drawing.Color.Black;
            this.labelPieChartheading.Location = new System.Drawing.Point(8, 325);
            this.labelPieChartheading.Name = "labelPieChartheading";
            this.labelPieChartheading.Size = new System.Drawing.Size(145, 32);
            this.labelPieChartheading.TabIndex = 16;
            this.labelPieChartheading.Text = "Bar Graph";
            this.labelPieChartheading.Click += new System.EventHandler(this.labelPieChartheading_Click);
            // 
            // labelLineGraphHeading
            // 
            this.labelLineGraphHeading.AutoSize = true;
            this.labelLineGraphHeading.BackColor = System.Drawing.Color.SteelBlue;
            this.labelLineGraphHeading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLineGraphHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLineGraphHeading.ForeColor = System.Drawing.Color.Black;
            this.labelLineGraphHeading.Location = new System.Drawing.Point(8, 32);
            this.labelLineGraphHeading.Name = "labelLineGraphHeading";
            this.labelLineGraphHeading.Size = new System.Drawing.Size(156, 32);
            this.labelLineGraphHeading.TabIndex = 15;
            this.labelLineGraphHeading.Text = "Line Graph";
            this.labelLineGraphHeading.Click += new System.EventHandler(this.labelLineGraphHeading_Click);
            // 
            // PanelSample
            // 
            this.PanelSample.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelSample.Controls.Add(this.webBrowser1);
            this.PanelSample.Controls.Add(this.pictureBox3);
            this.PanelSample.Controls.Add(this.textBoxUrl);
            this.PanelSample.Controls.Add(this.pictureBoxMain_Header);
            this.PanelSample.Controls.Add(this.linkLabel_Help_On_Static_Charts);
            this.PanelSample.Controls.Add(this.linkLabel_Help_Real_Time_Charts);
            this.PanelSample.Controls.Add(this.label_Static_Charts);
            this.PanelSample.Controls.Add(this.labelReal_Time_Charts);
            this.PanelSample.Controls.Add(this.tableLayoutPanel1);
            this.PanelSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PanelSample.Location = new System.Drawing.Point(600, 6);
            this.PanelSample.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PanelSample.Name = "PanelSample";
            this.PanelSample.Size = new System.Drawing.Size(1034, 954);
            this.PanelSample.TabIndex = 4;
            this.PanelSample.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSample_Paint);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(11, 117);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(859, 418);
            this.webBrowser1.TabIndex = 21;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(321, 439);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(362, 26);
            this.textBoxUrl.TabIndex = 20;
            this.textBoxUrl.Text = "https://www.youtube.com/watch?v=ZSzMW14BIvI";
            this.textBoxUrl.Visible = false;
            // 
            // photoList
            // 
            this.photoList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.photoList.ImageSize = new System.Drawing.Size(16, 16);
            this.photoList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.PanelSample);
            this.Controls.Add(this.panelConnect);
            this.Controls.Add(this.panel_Try_Grap);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Connection";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Connection_Load);
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpieChartstatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain_Header)).EndInit();
            this.panel_Try_Grap.ResumeLayout(false);
            this.panel_Try_Grap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).EndInit();
            this.PanelSample.ResumeLayout(false);
            this.PanelSample.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Button buttonDataBase;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.LinkLabel linkLabelOn_Connection;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxpieChartstatic;
        private System.Windows.Forms.Label labelReal_Time_Charts;
        private System.Windows.Forms.Label label_Static_Charts;
        private System.Windows.Forms.LinkLabel linkLabel_Help_Real_Time_Charts;
        private System.Windows.Forms.LinkLabel linkLabel_Help_On_Static_Charts;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxMain_Header;
        private System.Windows.Forms.Panel panel_Try_Grap;
        private System.Windows.Forms.Label labelBarGraphdef;
        private System.Windows.Forms.PictureBox pictureBoxPie;
        private System.Windows.Forms.Label labelPieChart;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxColumn;
        private System.Windows.Forms.Label labelPieChartheading;
        private System.Windows.Forms.Label labelLineGraphHeading;
        private System.Windows.Forms.Panel PanelSample;
        private System.Windows.Forms.Label labelpie__chartdef;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLine_Graph_;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ImageList photoList;
    }
}