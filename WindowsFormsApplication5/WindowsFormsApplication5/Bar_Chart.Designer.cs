namespace WindowsFormsApplication5
{
    partial class Bar_Chart
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
            this.cartesianChartBar = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Load = new System.Windows.Forms.Button();
            this.cartesianChartRow = new LiveCharts.WinForms.CartesianChart();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.appsSoldsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChartBar
            // 
            this.cartesianChartBar.Location = new System.Drawing.Point(1293, 57);
            this.cartesianChartBar.Name = "cartesianChartBar";
            this.cartesianChartBar.Size = new System.Drawing.Size(913, 343);
            this.cartesianChartBar.TabIndex = 0;
            this.cartesianChartBar.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appsSoldsDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(792, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(369, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.CurrentChanged += new System.EventHandler(this.salesBindingSource_CurrentChanged);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(1221, 534);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(110, 40);
            this.button_Load.TabIndex = 2;
            this.button_Load.Text = "Load_Chart";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartesianChartRow
            // 
            this.cartesianChartRow.Location = new System.Drawing.Point(99, 467);
            this.cartesianChartRow.Name = "cartesianChartRow";
            this.cartesianChartRow.Size = new System.Drawing.Size(894, 319);
            this.cartesianChartRow.TabIndex = 3;
            this.cartesianChartRow.Text = "Row_Chart";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelInstructions.ForeColor = System.Drawing.Color.Crimson;
            this.labelInstructions.Location = new System.Drawing.Point(126, 179);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(660, 128);
            this.labelInstructions.TabIndex = 4;
            this.labelInstructions.Text = "->Input Values For Comparison of Application Sold.\r\n->  For Apps Sold\r\n-> Year So" +
    "ld\r\n-> By default the SalesMan Name is \"Aymal\"\r\n";
            // 
            // appsSoldsDataGridViewTextBoxColumn
            // 
            this.appsSoldsDataGridViewTextBoxColumn.DataPropertyName = "Apps_Solds";
            this.appsSoldsDataGridViewTextBoxColumn.HeaderText = "Apps_Solds";
            this.appsSoldsDataGridViewTextBoxColumn.Name = "appsSoldsDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataSource = typeof(WindowsFormsApplication5.Sales);
            // 
            // Bar_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 832);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.cartesianChartRow);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cartesianChartBar);
            this.Name = "Bar_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar_Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bar_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChartBar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private LiveCharts.WinForms.CartesianChart cartesianChartRow;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn appsSoldsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesBindingSource1;
    }
}