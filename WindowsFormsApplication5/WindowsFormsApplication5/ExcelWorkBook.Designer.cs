using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    partial class Excel_WorkBook_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excel_WorkBook_Form));
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelExcelFile = new System.Windows.Forms.Label();
            this.panelOpenMSExcel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxPie = new System.Windows.Forms.PictureBox();
            this.pictureBoxRow = new System.Windows.Forms.PictureBox();
            this.pictureBoxStacked = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.labelBasicStacked = new System.Windows.Forms.Label();
            this.labelLineChart = new System.Windows.Forms.Label();
            this.labelDoughNutChart = new System.Windows.Forms.Label();
            this.labelPieChart = new System.Windows.Forms.Label();
            this.pictureBoxDoughNut = new System.Windows.Forms.PictureBox();
            this.labelRowChart = new System.Windows.Forms.Label();
            this.pictureBoxColumn = new System.Windows.Forms.PictureBox();
            this.labelColumnChart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelSelectChart = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.comboBoxSheetSelected = new System.Windows.Forms.ComboBox();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelSelected_Sheet = new System.Windows.Forms.Label();
            this.textBoxfilename = new System.Windows.Forms.TextBox();
            this.textBoxFileType = new System.Windows.Forms.TextBox();
            this.labelfileType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.labelExcelTable = new System.Windows.Forms.Label();
            this.nullLogFactoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pieChart_Population = new LiveCharts.WinForms.PieChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChartStacked = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartLine = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_Basic_Row = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartBasicColumn = new LiveCharts.WinForms.CartesianChart();
            this.timerLoadingData = new System.Windows.Forms.Timer(this.components);
            this.panelOpenMSExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftSide.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStacked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoughNut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullLogFactoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonOpen.Location = new System.Drawing.Point(1093, 11);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(343, 58);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "...Browse";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelExcelFile
            // 
            this.labelExcelFile.AutoSize = true;
            this.labelExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelExcelFile.Location = new System.Drawing.Point(408, 8);
            this.labelExcelFile.Name = "labelExcelFile";
            this.labelExcelFile.Size = new System.Drawing.Size(503, 55);
            this.labelExcelFile.TabIndex = 1;
            this.labelExcelFile.Text = "Edit Your File in Excel ";
            // 
            // panelOpenMSExcel
            // 
            this.panelOpenMSExcel.Controls.Add(this.pictureBox2);
            this.panelOpenMSExcel.Controls.Add(this.pictureBox1);
            this.panelOpenMSExcel.Controls.Add(this.labelExcelFile);
            this.panelOpenMSExcel.Controls.Add(this.buttonOpen);
            this.panelOpenMSExcel.Location = new System.Drawing.Point(3, 959);
            this.panelOpenMSExcel.Name = "panelOpenMSExcel";
            this.panelOpenMSExcel.Size = new System.Drawing.Size(1909, 79);
            this.panelOpenMSExcel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1603, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.Controls.Add(this.tableLayoutPanel1);
            this.panelLeftSide.Controls.Add(this.panel1);
            this.panelLeftSide.Location = new System.Drawing.Point(6, 5);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(378, 948);
            this.panelLeftSide.TabIndex = 8;
            this.panelLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44973F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPie, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRow, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStacked, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBasicStacked, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLineChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDoughNutChart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPieChart, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDoughNut, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRowChart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxColumn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelColumnChart, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 500);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.36842F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 445);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pictureBoxPie
            // 
            this.pictureBoxPie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPie.Image")));
            this.pictureBoxPie.Location = new System.Drawing.Point(137, 276);
            this.pictureBoxPie.Name = "pictureBoxPie";
            this.pictureBoxPie.Size = new System.Drawing.Size(213, 59);
            this.pictureBoxPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPie.TabIndex = 21;
            this.pictureBoxPie.TabStop = false;
            this.pictureBoxPie.Click += new System.EventHandler(this.pictureBoxPie_Click);
            // 
            // pictureBoxRow
            // 
            this.pictureBoxRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRow.Image")));
            this.pictureBoxRow.Location = new System.Drawing.Point(137, 205);
            this.pictureBoxRow.Name = "pictureBoxRow";
            this.pictureBoxRow.Size = new System.Drawing.Size(213, 59);
            this.pictureBoxRow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRow.TabIndex = 20;
            this.pictureBoxRow.TabStop = false;
            this.pictureBoxRow.Click += new System.EventHandler(this.pictureBoxRow_Click);
            // 
            // pictureBoxStacked
            // 
            this.pictureBoxStacked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStacked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStacked.Image")));
            this.pictureBoxStacked.Location = new System.Drawing.Point(137, 77);
            this.pictureBoxStacked.Name = "pictureBoxStacked";
            this.pictureBoxStacked.Size = new System.Drawing.Size(213, 50);
            this.pictureBoxStacked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStacked.TabIndex = 11;
            this.pictureBoxStacked.TabStop = false;
            this.pictureBoxStacked.Click += new System.EventHandler(this.pictureBoxStacked_Click);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(137, 3);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(213, 68);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 10;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
            // 
            // labelBasicStacked
            // 
            this.labelBasicStacked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBasicStacked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBasicStacked.Location = new System.Drawing.Point(3, 74);
            this.labelBasicStacked.Name = "labelBasicStacked";
            this.labelBasicStacked.Size = new System.Drawing.Size(128, 56);
            this.labelBasicStacked.TabIndex = 15;
            this.labelBasicStacked.Text = "Stacked \r\nChart";
            this.labelBasicStacked.Click += new System.EventHandler(this.labelBasicStacked_Click);
            // 
            // labelLineChart
            // 
            this.labelLineChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLineChart.Location = new System.Drawing.Point(3, 0);
            this.labelLineChart.Name = "labelLineChart";
            this.labelLineChart.Size = new System.Drawing.Size(100, 67);
            this.labelLineChart.TabIndex = 13;
            this.labelLineChart.Text = "Line\r\nChart";
            this.labelLineChart.Click += new System.EventHandler(this.labelLineChart_Click);
            // 
            // labelDoughNutChart
            // 
            this.labelDoughNutChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDoughNutChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoughNutChart.Location = new System.Drawing.Point(3, 135);
            this.labelDoughNutChart.Name = "labelDoughNutChart";
            this.labelDoughNutChart.Size = new System.Drawing.Size(100, 62);
            this.labelDoughNutChart.TabIndex = 16;
            this.labelDoughNutChart.Text = "Dough Nut";
            this.labelDoughNutChart.Click += new System.EventHandler(this.labelDoughNutChart_Click);
            // 
            // labelPieChart
            // 
            this.labelPieChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPieChart.Location = new System.Drawing.Point(3, 273);
            this.labelPieChart.Name = "labelPieChart";
            this.labelPieChart.Size = new System.Drawing.Size(94, 60);
            this.labelPieChart.TabIndex = 17;
            this.labelPieChart.Text = "Pie\r\nChart";
            this.labelPieChart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelPieChart.Click += new System.EventHandler(this.labelPieChart_Click);
            // 
            // pictureBoxDoughNut
            // 
            this.pictureBoxDoughNut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDoughNut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoughNut.Image")));
            this.pictureBoxDoughNut.Location = new System.Drawing.Point(137, 138);
            this.pictureBoxDoughNut.Name = "pictureBoxDoughNut";
            this.pictureBoxDoughNut.Size = new System.Drawing.Size(213, 56);
            this.pictureBoxDoughNut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoughNut.TabIndex = 19;
            this.pictureBoxDoughNut.TabStop = false;
            this.pictureBoxDoughNut.Click += new System.EventHandler(this.pictureBoxDoughNut_Click);
            // 
            // labelRowChart
            // 
            this.labelRowChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRowChart.Location = new System.Drawing.Point(3, 202);
            this.labelRowChart.Name = "labelRowChart";
            this.labelRowChart.Size = new System.Drawing.Size(100, 65);
            this.labelRowChart.TabIndex = 10;
            this.labelRowChart.Text = "Row\r\nChart";
            // 
            // pictureBoxColumn
            // 
            this.pictureBoxColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColumn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColumn.Image")));
            this.pictureBoxColumn.Location = new System.Drawing.Point(137, 347);
            this.pictureBoxColumn.Name = "pictureBoxColumn";
            this.pictureBoxColumn.Size = new System.Drawing.Size(213, 70);
            this.pictureBoxColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColumn.TabIndex = 22;
            this.pictureBoxColumn.TabStop = false;
            this.pictureBoxColumn.Click += new System.EventHandler(this.pictureBoxColumn_Click);
            // 
            // labelColumnChart
            // 
            this.labelColumnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColumnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelColumnChart.Location = new System.Drawing.Point(3, 344);
            this.labelColumnChart.Name = "labelColumnChart";
            this.labelColumnChart.Size = new System.Drawing.Size(112, 68);
            this.labelColumnChart.TabIndex = 12;
            this.labelColumnChart.Text = "Column\r\nChart";
            this.labelColumnChart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelColumnChart.Click += new System.EventHandler(this.labelColumnChart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.labelSelectChart);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.labelFilePath);
            this.panel1.Controls.Add(this.labelFileName);
            this.panel1.Controls.Add(this.comboBoxSheetSelected);
            this.panel1.Controls.Add(this.textBoxFilePath);
            this.panel1.Controls.Add(this.labelSelected_Sheet);
            this.panel1.Controls.Add(this.textBoxfilename);
            this.panel1.Controls.Add(this.textBoxFileType);
            this.panel1.Controls.Add(this.labelfileType);
            this.panel1.Location = new System.Drawing.Point(11, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 465);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 355);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(332, 26);
            this.progressBar1.TabIndex = 20;
            // 
            // labelSelectChart
            // 
            this.labelSelectChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectChart.Location = new System.Drawing.Point(6, 384);
            this.labelSelectChart.Name = "labelSelectChart";
            this.labelSelectChart.Size = new System.Drawing.Size(257, 62);
            this.labelSelectChart.TabIndex = 17;
            this.labelSelectChart.Text = "Can only Create ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowse.Location = new System.Drawing.Point(-6, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(338, 38);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFilePath.Location = new System.Drawing.Point(4, 128);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(114, 29);
            this.labelFilePath.TabIndex = 18;
            this.labelFilePath.Text = "File Path:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFileName.Location = new System.Drawing.Point(4, 53);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(131, 29);
            this.labelFileName.TabIndex = 12;
            this.labelFileName.Text = "File Name:";
            // 
            // comboBoxSheetSelected
            // 
            this.comboBoxSheetSelected.FormattingEnabled = true;
            this.comboBoxSheetSelected.Location = new System.Drawing.Point(0, 321);
            this.comboBoxSheetSelected.Name = "comboBoxSheetSelected";
            this.comboBoxSheetSelected.Size = new System.Drawing.Size(332, 28);
            this.comboBoxSheetSelected.TabIndex = 13;
            this.comboBoxSheetSelected.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.Location = new System.Drawing.Point(3, 160);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(329, 35);
            this.textBoxFilePath.TabIndex = 19;
            // 
            // labelSelected_Sheet
            // 
            this.labelSelected_Sheet.AutoSize = true;
            this.labelSelected_Sheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelected_Sheet.Location = new System.Drawing.Point(6, 289);
            this.labelSelected_Sheet.Name = "labelSelected_Sheet";
            this.labelSelected_Sheet.Size = new System.Drawing.Size(191, 29);
            this.labelSelected_Sheet.TabIndex = 15;
            this.labelSelected_Sheet.Text = "Sheet_Selected:";
            // 
            // textBoxfilename
            // 
            this.textBoxfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxfilename.Location = new System.Drawing.Point(3, 90);
            this.textBoxfilename.Name = "textBoxfilename";
            this.textBoxfilename.ReadOnly = true;
            this.textBoxfilename.Size = new System.Drawing.Size(329, 35);
            this.textBoxfilename.TabIndex = 14;
            // 
            // textBoxFileType
            // 
            this.textBoxFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFileType.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxFileType.Location = new System.Drawing.Point(3, 241);
            this.textBoxFileType.Name = "textBoxFileType";
            this.textBoxFileType.ReadOnly = true;
            this.textBoxFileType.Size = new System.Drawing.Size(329, 35);
            this.textBoxFileType.TabIndex = 17;
            this.textBoxFileType.TextChanged += new System.EventHandler(this.textBoxFileType_TextChanged);
            // 
            // labelfileType
            // 
            this.labelfileType.AutoSize = true;
            this.labelfileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelfileType.Location = new System.Drawing.Point(1, 198);
            this.labelfileType.Name = "labelfileType";
            this.labelfileType.Size = new System.Drawing.Size(121, 29);
            this.labelfileType.TabIndex = 16;
            this.labelfileType.Text = "File Type:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewExcel);
            this.panel3.Location = new System.Drawing.Point(444, 609);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1468, 344);
            this.panel3.TabIndex = 9;
            // 
            // dataGridViewExcel
            // 
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(6, 3);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.RowTemplate.Height = 28;
            this.dataGridViewExcel.Size = new System.Drawing.Size(1447, 329);
            this.dataGridViewExcel.TabIndex = 0;
            // 
            // labelExcelTable
            // 
            this.labelExcelTable.AutoSize = true;
            this.labelExcelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelExcelTable.Location = new System.Drawing.Point(390, 569);
            this.labelExcelTable.Name = "labelExcelTable";
            this.labelExcelTable.Size = new System.Drawing.Size(477, 37);
            this.labelExcelTable.TabIndex = 12;
            this.labelExcelTable.Text = "Excel File Data in Tabluar Form:";
            this.labelExcelTable.Click += new System.EventHandler(this.label1_Click);
            this.labelExcelTable.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // nullLogFactoryBindingSource
            // 
            this.nullLogFactoryBindingSource.DataSource = typeof(ExcelDataReader.Log.Logger.NullLogFactory);
            // 
            // pieChart_Population
            // 
            this.pieChart_Population.Location = new System.Drawing.Point(390, 12);
            this.pieChart_Population.Name = "pieChart_Population";
            this.pieChart_Population.Size = new System.Drawing.Size(757, 520);
            this.pieChart_Population.TabIndex = 13;
            this.pieChart_Population.Text = "pieChart1";
            this.pieChart_Population.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart_Population_ChildChanged);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(1236, 32);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(661, 507);
            this.pieChart1.TabIndex = 14;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChartStacked
            // 
            this.cartesianChartStacked.Location = new System.Drawing.Point(450, 46);
            this.cartesianChartStacked.Name = "cartesianChartStacked";
            this.cartesianChartStacked.Size = new System.Drawing.Size(1447, 473);
            this.cartesianChartStacked.TabIndex = 15;
            this.cartesianChartStacked.Text = "cartesianChart1";
            // 
            // cartesianChartLine
            // 
            this.cartesianChartLine.Location = new System.Drawing.Point(444, 46);
            this.cartesianChartLine.Name = "cartesianChartLine";
            this.cartesianChartLine.Size = new System.Drawing.Size(1468, 473);
            this.cartesianChartLine.TabIndex = 16;
            this.cartesianChartLine.Text = "cartesianChart1";
            // 
            // cartesianChart_Basic_Row
            // 
            this.cartesianChart_Basic_Row.Location = new System.Drawing.Point(444, 32);
            this.cartesianChart_Basic_Row.Name = "cartesianChart_Basic_Row";
            this.cartesianChart_Basic_Row.Size = new System.Drawing.Size(1417, 473);
            this.cartesianChart_Basic_Row.TabIndex = 17;
            this.cartesianChart_Basic_Row.Text = "cartesianChart1";
            // 
            // cartesianChartBasicColumn
            // 
            this.cartesianChartBasicColumn.Location = new System.Drawing.Point(455, 46);
            this.cartesianChartBasicColumn.Name = "cartesianChartBasicColumn";
            this.cartesianChartBasicColumn.Size = new System.Drawing.Size(1442, 431);
            this.cartesianChartBasicColumn.TabIndex = 18;
            this.cartesianChartBasicColumn.Text = "cartesianChart_Column";
            // 
            // timerLoadingData
            // 
            this.timerLoadingData.Enabled = true;
            this.timerLoadingData.Interval = 10000;
            this.timerLoadingData.Tick += new System.EventHandler(this.timerLoadingData_Tick);
            // 
            // Excel_WorkBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.cartesianChartBasicColumn);
            this.Controls.Add(this.cartesianChart_Basic_Row);
            this.Controls.Add(this.cartesianChartLine);
            this.Controls.Add(this.cartesianChartStacked);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.pieChart_Population);
            this.Controls.Add(this.labelExcelTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelOpenMSExcel);
            this.Name = "Excel_WorkBook_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel_WorkBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkBook_Load);
            this.panelOpenMSExcel.ResumeLayout(false);
            this.panelOpenMSExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftSide.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStacked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoughNut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullLogFactoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelExcelFile;
        private System.Windows.Forms.Panel panelOpenMSExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panel3;
        private BindingSource nullLogFactoryBindingSource;
        private Label labelSelected_Sheet;
        private TextBox textBoxfilename;
        private Label labelFileName;
        private ComboBox comboBoxSheetSelected;
        private Button btnBrowse;
        private Label labelExcelTable;
        private TextBox textBoxFileType;
        private Label labelfileType;
        private Label labelFilePath;
        private TextBox textBoxFilePath;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelBasicStacked;
        private Label labelLineChart;
        private Label labelDoughNutChart;
        private Label labelRowChart;
        private Label labelColumnChart;
        private Label labelPieChart;
        private Label labelSelectChart;
        private PictureBox pictureBoxColumn;
        private PictureBox pictureBoxPie;
        private PictureBox pictureBoxRow;
        private PictureBox pictureBoxStacked;
        private PictureBox pictureBoxLine;
        private LiveCharts.WinForms.PieChart pieChart_Population;
        private PictureBox pictureBoxDoughNut;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChartStacked;
        private DataGridView dataGridViewExcel;
        private LiveCharts.WinForms.CartesianChart cartesianChartLine;
        private LiveCharts.WinForms.CartesianChart cartesianChart_Basic_Row;
        private LiveCharts.WinForms.CartesianChart cartesianChartBasicColumn;
        private ProgressBar progressBar1;
        private Timer timerLoadingData;
        private PictureBox pictureBox2;
    }
}