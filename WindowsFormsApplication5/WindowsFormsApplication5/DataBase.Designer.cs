namespace WindowsFormsApplication5
{
    partial class DataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.labelExcelTable = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.cartesianChartStacked = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartLine = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart_Basic_Row = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChartBasicColumn = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStacked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoughNut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 622);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(1, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 949);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.tableLayoutPanel1.Controls.Add(this.labelDoughNutChart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPieChart, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDoughNut, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRowChart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxColumn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelColumnChart, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelLineChart, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01629F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84929F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.36842F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 628);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // pictureBoxPie
            // 
            this.pictureBoxPie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPie.Image")));
            this.pictureBoxPie.Location = new System.Drawing.Point(137, 388);
            this.pictureBoxPie.Name = "pictureBoxPie";
            this.pictureBoxPie.Size = new System.Drawing.Size(173, 59);
            this.pictureBoxPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPie.TabIndex = 21;
            this.pictureBoxPie.TabStop = false;
            this.pictureBoxPie.Click += new System.EventHandler(this.pictureBoxPie_Click);
            // 
            // pictureBoxRow
            // 
            this.pictureBoxRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRow.Image")));
            this.pictureBoxRow.Location = new System.Drawing.Point(137, 288);
            this.pictureBoxRow.Name = "pictureBoxRow";
            this.pictureBoxRow.Size = new System.Drawing.Size(173, 59);
            this.pictureBoxRow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRow.TabIndex = 20;
            this.pictureBoxRow.TabStop = false;
            this.pictureBoxRow.Click += new System.EventHandler(this.pictureBoxRow_Click);
            // 
            // pictureBoxStacked
            // 
            this.pictureBoxStacked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStacked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStacked.Image")));
            this.pictureBoxStacked.Location = new System.Drawing.Point(137, 107);
            this.pictureBoxStacked.Name = "pictureBoxStacked";
            this.pictureBoxStacked.Size = new System.Drawing.Size(173, 50);
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
            this.pictureBoxLine.Size = new System.Drawing.Size(173, 68);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLine.TabIndex = 10;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Click += new System.EventHandler(this.pictureBoxLine_Click);
            // 
            // labelBasicStacked
            // 
            this.labelBasicStacked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBasicStacked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBasicStacked.Location = new System.Drawing.Point(3, 104);
            this.labelBasicStacked.Name = "labelBasicStacked";
            this.labelBasicStacked.Size = new System.Drawing.Size(128, 56);
            this.labelBasicStacked.TabIndex = 15;
            this.labelBasicStacked.Text = "Stacked \r\nChart";
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
            // 
            // labelDoughNutChart
            // 
            this.labelDoughNutChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDoughNutChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoughNutChart.Location = new System.Drawing.Point(3, 190);
            this.labelDoughNutChart.Name = "labelDoughNutChart";
            this.labelDoughNutChart.Size = new System.Drawing.Size(100, 62);
            this.labelDoughNutChart.TabIndex = 16;
            this.labelDoughNutChart.Text = "Dough Nut";
            // 
            // labelPieChart
            // 
            this.labelPieChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPieChart.Location = new System.Drawing.Point(3, 385);
            this.labelPieChart.Name = "labelPieChart";
            this.labelPieChart.Size = new System.Drawing.Size(94, 60);
            this.labelPieChart.TabIndex = 17;
            this.labelPieChart.Text = "Pie\r\nChart";
            this.labelPieChart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBoxDoughNut
            // 
            this.pictureBoxDoughNut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDoughNut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDoughNut.Image")));
            this.pictureBoxDoughNut.Location = new System.Drawing.Point(137, 193);
            this.pictureBoxDoughNut.Name = "pictureBoxDoughNut";
            this.pictureBoxDoughNut.Size = new System.Drawing.Size(173, 56);
            this.pictureBoxDoughNut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDoughNut.TabIndex = 19;
            this.pictureBoxDoughNut.TabStop = false;
            this.pictureBoxDoughNut.Click += new System.EventHandler(this.pictureBoxDoughNut_Click);
            // 
            // labelRowChart
            // 
            this.labelRowChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRowChart.Location = new System.Drawing.Point(3, 285);
            this.labelRowChart.Name = "labelRowChart";
            this.labelRowChart.Size = new System.Drawing.Size(100, 65);
            this.labelRowChart.TabIndex = 10;
            this.labelRowChart.Text = "Row\r\nChart";
            // 
            // pictureBoxColumn
            // 
            this.pictureBoxColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColumn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColumn.Image")));
            this.pictureBoxColumn.Location = new System.Drawing.Point(137, 488);
            this.pictureBoxColumn.Name = "pictureBoxColumn";
            this.pictureBoxColumn.Size = new System.Drawing.Size(173, 70);
            this.pictureBoxColumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColumn.TabIndex = 22;
            this.pictureBoxColumn.TabStop = false;
            this.pictureBoxColumn.Click += new System.EventHandler(this.pictureBoxColumn_Click);
            // 
            // labelColumnChart
            // 
            this.labelColumnChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelColumnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelColumnChart.Location = new System.Drawing.Point(3, 485);
            this.labelColumnChart.Name = "labelColumnChart";
            this.labelColumnChart.Size = new System.Drawing.Size(112, 68);
            this.labelColumnChart.TabIndex = 12;
            this.labelColumnChart.Text = "Column\r\nChart";
            this.labelColumnChart.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelExcelTable
            // 
            this.labelExcelTable.AutoSize = true;
            this.labelExcelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelExcelTable.Location = new System.Drawing.Point(411, 582);
            this.labelExcelTable.Name = "labelExcelTable";
            this.labelExcelTable.Size = new System.Drawing.Size(477, 37);
            this.labelExcelTable.TabIndex = 18;
            this.labelExcelTable.Text = "Excel File Data in Tabluar Form:";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(1228, 45);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(683, 414);
            this.pieChart1.TabIndex = 19;
            this.pieChart1.Text = "pieChart1";
            // 
            // pieChart2
            // 
            this.pieChart2.Location = new System.Drawing.Point(496, 45);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(653, 440);
            this.pieChart2.TabIndex = 20;
            this.pieChart2.Text = "pieChart2";
            // 
            // cartesianChartStacked
            // 
            this.cartesianChartStacked.Location = new System.Drawing.Point(470, 10);
            this.cartesianChartStacked.Name = "cartesianChartStacked";
            this.cartesianChartStacked.Size = new System.Drawing.Size(1274, 470);
            this.cartesianChartStacked.TabIndex = 21;
            this.cartesianChartStacked.Text = "cartesianChart1";
            // 
            // cartesianChartLine
            // 
            this.cartesianChartLine.Location = new System.Drawing.Point(506, 69);
            this.cartesianChartLine.Name = "cartesianChartLine";
            this.cartesianChartLine.Size = new System.Drawing.Size(1274, 470);
            this.cartesianChartLine.TabIndex = 22;
            this.cartesianChartLine.Text = "cartesianChart1";
            // 
            // cartesianChart_Basic_Row
            // 
            this.cartesianChart_Basic_Row.Location = new System.Drawing.Point(506, 45);
            this.cartesianChart_Basic_Row.Name = "cartesianChart_Basic_Row";
            this.cartesianChart_Basic_Row.Size = new System.Drawing.Size(1274, 470);
            this.cartesianChart_Basic_Row.TabIndex = 23;
            this.cartesianChart_Basic_Row.Text = "cartesianChart1";
            // 
            // cartesianChartBasicColumn
            // 
            this.cartesianChartBasicColumn.Location = new System.Drawing.Point(506, 15);
            this.cartesianChartBasicColumn.Name = "cartesianChartBasicColumn";
            this.cartesianChartBasicColumn.Size = new System.Drawing.Size(1274, 470);
            this.cartesianChartBasicColumn.TabIndex = 24;
            this.cartesianChartBasicColumn.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 175);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tables Are As following:\r\n->Basic_Row\r\n->Basic_Column\r\n->Line_Chart\r\n->Pie_Chart\r" +
    "\n->DoughNut_Chart\r\n->Stacked_Chart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1746, 912);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cartesianChartBasicColumn);
            this.Controls.Add(this.cartesianChart_Basic_Row);
            this.Controls.Add(this.cartesianChartLine);
            this.Controls.Add(this.cartesianChartStacked);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.labelExcelTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStacked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoughNut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExcelTable;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.PieChart pieChart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxPie;
        private System.Windows.Forms.PictureBox pictureBoxRow;
        private System.Windows.Forms.PictureBox pictureBoxStacked;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Label labelBasicStacked;
        private System.Windows.Forms.Label labelLineChart;
        private System.Windows.Forms.Label labelDoughNutChart;
        private System.Windows.Forms.Label labelPieChart;
        private System.Windows.Forms.PictureBox pictureBoxDoughNut;
        private System.Windows.Forms.Label labelRowChart;
        private System.Windows.Forms.PictureBox pictureBoxColumn;
        private System.Windows.Forms.Label labelColumnChart;
        private LiveCharts.WinForms.CartesianChart cartesianChartStacked;
        private LiveCharts.WinForms.CartesianChart cartesianChartLine;
        private LiveCharts.WinForms.CartesianChart cartesianChart_Basic_Row;
        private LiveCharts.WinForms.CartesianChart cartesianChartBasicColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}