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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelExcelFile = new System.Windows.Forms.Label();
            this.panelOpenMSExcel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxScatterPlot = new System.Windows.Forms.PictureBox();
            this.pictureBoxStackedArea = new System.Windows.Forms.PictureBox();
            this.pictureBoxPie = new System.Windows.Forms.PictureBox();
            this.pictureBoxRow = new System.Windows.Forms.PictureBox();
            this.pictureBoxStacked = new System.Windows.Forms.PictureBox();
            this.pictureBoxColumn = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.labelColumnChart = new System.Windows.Forms.Label();
            this.labelLineChart = new System.Windows.Forms.Label();
            this.labelStackedChart = new System.Windows.Forms.Label();
            this.labelRowChart = new System.Windows.Forms.Label();
            this.labelStackedArea = new System.Windows.Forms.Label();
            this.labelPieChart = new System.Windows.Forms.Label();
            this.labelScatterPlot = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panelOpenMSExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftSide.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScatterPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStackedArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStacked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nullLogFactoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonOpen.Location = new System.Drawing.Point(999, 20);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(343, 67);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "...Browse";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelExcelFile
            // 
            this.labelExcelFile.AutoSize = true;
            this.labelExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelExcelFile.Location = new System.Drawing.Point(342, 20);
            this.labelExcelFile.Name = "labelExcelFile";
            this.labelExcelFile.Size = new System.Drawing.Size(674, 73);
            this.labelExcelFile.TabIndex = 1;
            this.labelExcelFile.Text = "Edit Your File in Excel ";
            // 
            // panelOpenMSExcel
            // 
            this.panelOpenMSExcel.Controls.Add(this.pictureBox1);
            this.panelOpenMSExcel.Controls.Add(this.labelExcelFile);
            this.panelOpenMSExcel.Controls.Add(this.buttonOpen);
            this.panelOpenMSExcel.Location = new System.Drawing.Point(0, 948);
            this.panelOpenMSExcel.Name = "panelOpenMSExcel";
            this.panelOpenMSExcel.Size = new System.Drawing.Size(1934, 120);
            this.panelOpenMSExcel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.Controls.Add(this.tableLayoutPanel1);
            this.panelLeftSide.Controls.Add(this.panel1);
            this.panelLeftSide.Location = new System.Drawing.Point(0, 12);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(384, 941);
            this.panelLeftSide.TabIndex = 8;
            this.panelLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44973F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxScatterPlot, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStackedArea, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxPie, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRow, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStacked, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxColumn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelColumnChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLineChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStackedChart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRowChart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelStackedArea, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPieChart, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelScatterPlot, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 439);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.60896F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.99593F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 499);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pictureBoxScatterPlot
            // 
            this.pictureBoxScatterPlot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScatterPlot.Image")));
            this.pictureBoxScatterPlot.Location = new System.Drawing.Point(112, 391);
            this.pictureBoxScatterPlot.Name = "pictureBoxScatterPlot";
            this.pictureBoxScatterPlot.Size = new System.Drawing.Size(263, 105);
            this.pictureBoxScatterPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScatterPlot.TabIndex = 23;
            this.pictureBoxScatterPlot.TabStop = false;
            // 
            // pictureBoxStackedArea
            // 
            this.pictureBoxStackedArea.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStackedArea.Image")));
            this.pictureBoxStackedArea.Location = new System.Drawing.Point(112, 334);
            this.pictureBoxStackedArea.Name = "pictureBoxStackedArea";
            this.pictureBoxStackedArea.Size = new System.Drawing.Size(263, 51);
            this.pictureBoxStackedArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStackedArea.TabIndex = 22;
            this.pictureBoxStackedArea.TabStop = false;
            // 
            // pictureBoxPie
            // 
            this.pictureBoxPie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPie.Image")));
            this.pictureBoxPie.Location = new System.Drawing.Point(112, 266);
            this.pictureBoxPie.Name = "pictureBoxPie";
            this.pictureBoxPie.Size = new System.Drawing.Size(263, 62);
            this.pictureBoxPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPie.TabIndex = 21;
            this.pictureBoxPie.TabStop = false;
            // 
            // pictureBoxRow
            // 
            this.pictureBoxRow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRow.Image")));
            this.pictureBoxRow.Location = new System.Drawing.Point(112, 198);
            this.pictureBoxRow.Name = "pictureBoxRow";
            this.pictureBoxRow.Size = new System.Drawing.Size(263, 62);
            this.pictureBoxRow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRow.TabIndex = 20;
            this.pictureBoxRow.TabStop = false;
            // 
            // pictureBoxStacked
            // 
            this.pictureBoxStacked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStacked.Image")));
            this.pictureBoxStacked.Location = new System.Drawing.Point(112, 133);
            this.pictureBoxStacked.Name = "pictureBoxStacked";
            this.pictureBoxStacked.Size = new System.Drawing.Size(263, 56);
            this.pictureBoxStacked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStacked.TabIndex = 19;
            this.pictureBoxStacked.TabStop = false;
            // 
            // pictureBoxColumn
            // 
            this.pictureBoxColumn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColumn.Image")));
            this.pictureBoxColumn.Location = new System.Drawing.Point(112, 74);
            this.pictureBoxColumn.Name = "pictureBoxColumn";
            this.pictureBoxColumn.Size = new System.Drawing.Size(263, 53);
            this.pictureBoxColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColumn.TabIndex = 11;
            this.pictureBoxColumn.TabStop = false;
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(112, 3);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(263, 65);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 10;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
            // 
            // labelColumnChart
            // 
            this.labelColumnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelColumnChart.Location = new System.Drawing.Point(3, 71);
            this.labelColumnChart.Name = "labelColumnChart";
            this.labelColumnChart.Size = new System.Drawing.Size(100, 59);
            this.labelColumnChart.TabIndex = 15;
            this.labelColumnChart.Text = "Column\r\nChart";
            // 
            // labelLineChart
            // 
            this.labelLineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLineChart.Location = new System.Drawing.Point(3, 0);
            this.labelLineChart.Name = "labelLineChart";
            this.labelLineChart.Size = new System.Drawing.Size(100, 71);
            this.labelLineChart.TabIndex = 13;
            this.labelLineChart.Text = "Line\r\nChart";
            // 
            // labelStackedChart
            // 
            this.labelStackedChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStackedChart.Location = new System.Drawing.Point(3, 130);
            this.labelStackedChart.Name = "labelStackedChart";
            this.labelStackedChart.Size = new System.Drawing.Size(100, 65);
            this.labelStackedChart.TabIndex = 16;
            this.labelStackedChart.Text = "Stacked\r\nChart";
            // 
            // labelRowChart
            // 
            this.labelRowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRowChart.Location = new System.Drawing.Point(3, 195);
            this.labelRowChart.Name = "labelRowChart";
            this.labelRowChart.Size = new System.Drawing.Size(100, 65);
            this.labelRowChart.TabIndex = 10;
            this.labelRowChart.Text = "Row\r\nChart";
            // 
            // labelStackedArea
            // 
            this.labelStackedArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStackedArea.Location = new System.Drawing.Point(3, 331);
            this.labelStackedArea.Name = "labelStackedArea";
            this.labelStackedArea.Size = new System.Drawing.Size(103, 57);
            this.labelStackedArea.TabIndex = 12;
            this.labelStackedArea.Text = "Stacked\r\nArea";
            this.labelStackedArea.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelPieChart
            // 
            this.labelPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPieChart.Location = new System.Drawing.Point(3, 263);
            this.labelPieChart.Name = "labelPieChart";
            this.labelPieChart.Size = new System.Drawing.Size(94, 60);
            this.labelPieChart.TabIndex = 17;
            this.labelPieChart.Text = "Pie\r\nChart";
            this.labelPieChart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelScatterPlot
            // 
            this.labelScatterPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScatterPlot.Location = new System.Drawing.Point(3, 388);
            this.labelScatterPlot.Name = "labelScatterPlot";
            this.labelScatterPlot.Size = new System.Drawing.Size(100, 71);
            this.labelScatterPlot.TabIndex = 18;
            this.labelScatterPlot.Text = "Scatter Plot";
            this.labelScatterPlot.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 430);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelSelectChart
            // 
            this.labelSelectChart.AutoSize = true;
            this.labelSelectChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSelectChart.Location = new System.Drawing.Point(7, 374);
            this.labelSelectChart.Name = "labelSelectChart";
            this.labelSelectChart.Size = new System.Drawing.Size(192, 37);
            this.labelSelectChart.TabIndex = 17;
            this.labelSelectChart.Text = "Select Chart";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowse.Location = new System.Drawing.Point(-1, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(377, 49);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFilePath.Location = new System.Drawing.Point(4, 125);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(114, 29);
            this.labelFilePath.TabIndex = 18;
            this.labelFilePath.Text = "File Path:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFileName.Location = new System.Drawing.Point(3, 55);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(131, 29);
            this.labelFileName.TabIndex = 12;
            this.labelFileName.Text = "File Name:";
            // 
            // comboBoxSheetSelected
            // 
            this.comboBoxSheetSelected.FormattingEnabled = true;
            this.comboBoxSheetSelected.Location = new System.Drawing.Point(-1, 298);
            this.comboBoxSheetSelected.Name = "comboBoxSheetSelected";
            this.comboBoxSheetSelected.Size = new System.Drawing.Size(378, 28);
            this.comboBoxSheetSelected.TabIndex = 13;
            this.comboBoxSheetSelected.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFilePath.Location = new System.Drawing.Point(3, 158);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(378, 35);
            this.textBoxFilePath.TabIndex = 19;
            // 
            // labelSelected_Sheet
            // 
            this.labelSelected_Sheet.AutoSize = true;
            this.labelSelected_Sheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelected_Sheet.Location = new System.Drawing.Point(4, 266);
            this.labelSelected_Sheet.Name = "labelSelected_Sheet";
            this.labelSelected_Sheet.Size = new System.Drawing.Size(191, 29);
            this.labelSelected_Sheet.TabIndex = 15;
            this.labelSelected_Sheet.Text = "Sheet_Selected:";
            // 
            // textBoxfilename
            // 
            this.textBoxfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxfilename.Location = new System.Drawing.Point(3, 87);
            this.textBoxfilename.Name = "textBoxfilename";
            this.textBoxfilename.ReadOnly = true;
            this.textBoxfilename.Size = new System.Drawing.Size(378, 35);
            this.textBoxfilename.TabIndex = 14;
            // 
            // textBoxFileType
            // 
            this.textBoxFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFileType.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxFileType.Location = new System.Drawing.Point(3, 228);
            this.textBoxFileType.Name = "textBoxFileType";
            this.textBoxFileType.ReadOnly = true;
            this.textBoxFileType.Size = new System.Drawing.Size(378, 35);
            this.textBoxFileType.TabIndex = 17;
            this.textBoxFileType.TextChanged += new System.EventHandler(this.textBoxFileType_TextChanged);
            // 
            // labelfileType
            // 
            this.labelfileType.AutoSize = true;
            this.labelfileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelfileType.Location = new System.Drawing.Point(3, 196);
            this.labelfileType.Name = "labelfileType";
            this.labelfileType.Size = new System.Drawing.Size(121, 29);
            this.labelfileType.TabIndex = 16;
            this.labelfileType.Text = "File Type:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewExcel);
            this.panel3.Location = new System.Drawing.Point(390, 584);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1533, 358);
            this.panel3.TabIndex = 9;
            // 
            // dataGridViewExcel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewExcel.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(7, 0);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.ReadOnly = true;
            this.dataGridViewExcel.RowTemplate.Height = 28;
            this.dataGridViewExcel.Size = new System.Drawing.Size(1527, 355);
            this.dataGridViewExcel.TabIndex = 11;
            // 
            // labelExcelTable
            // 
            this.labelExcelTable.AutoSize = true;
            this.labelExcelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelExcelTable.Location = new System.Drawing.Point(390, 541);
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
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(606, 90);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(875, 355);
            this.cartesianChart1.TabIndex = 14;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Excel_WorkBook_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.cartesianChart1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftSide.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScatterPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStackedArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStacked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
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
        private DataGridView dataGridViewExcel;
        private Label labelExcelTable;
        private TextBox textBoxFileType;
        private Label labelfileType;
        private Label labelFilePath;
        private TextBox textBoxFilePath;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelColumnChart;
        private Label labelLineChart;
        private Label labelStackedChart;
        private Label labelRowChart;
        private Label labelStackedArea;
        private Label labelPieChart;
        private Label labelSelectChart;
        private Label labelScatterPlot;
        private PictureBox pictureBoxScatterPlot;
        private PictureBox pictureBoxStackedArea;
        private PictureBox pictureBoxPie;
        private PictureBox pictureBoxRow;
        private PictureBox pictureBoxStacked;
        private PictureBox pictureBoxColumn;
        private PictureBox pictureBoxLine;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}