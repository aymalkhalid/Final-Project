namespace WindowsFormsApplication5
{
    partial class Data_Form_Line_Graph
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
            this.cartesianChart_Line_Graph = new LiveCharts.WinForms.CartesianChart();
            this.button_Load_Line_Graph = new System.Windows.Forms.Button();
            this.Revenue_Line_Graph_dataGrid = new System.Windows.Forms.DataGridView();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Revenue_Line_Graph_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart_Line_Graph
            // 
            this.cartesianChart_Line_Graph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cartesianChart_Line_Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cartesianChart_Line_Graph.ForeColor = System.Drawing.Color.White;
            this.cartesianChart_Line_Graph.Location = new System.Drawing.Point(761, 36);
            this.cartesianChart_Line_Graph.Name = "cartesianChart_Line_Graph";
            this.cartesianChart_Line_Graph.Size = new System.Drawing.Size(954, 497);
            this.cartesianChart_Line_Graph.TabIndex = 0;
            this.cartesianChart_Line_Graph.Text = "cartesianChart1";
            // 
            // button_Load_Line_Graph
            // 
            this.button_Load_Line_Graph.Location = new System.Drawing.Point(541, 627);
            this.button_Load_Line_Graph.Name = "button_Load_Line_Graph";
            this.button_Load_Line_Graph.Size = new System.Drawing.Size(240, 71);
            this.button_Load_Line_Graph.TabIndex = 1;
            this.button_Load_Line_Graph.Text = "Load_Graph";
            this.button_Load_Line_Graph.UseVisualStyleBackColor = true;
            this.button_Load_Line_Graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // Revenue_Line_Graph_dataGrid
            // 
            this.Revenue_Line_Graph_dataGrid.AutoGenerateColumns = false;
            this.Revenue_Line_Graph_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Revenue_Line_Graph_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.Income,
            this.monthDataGridViewTextBoxColumn});
            this.Revenue_Line_Graph_dataGrid.DataSource = this.revenueBindingSource;
            this.Revenue_Line_Graph_dataGrid.Location = new System.Drawing.Point(36, 241);
            this.Revenue_Line_Graph_dataGrid.Name = "Revenue_Line_Graph_dataGrid";
            this.Revenue_Line_Graph_dataGrid.RowTemplate.Height = 28;
            this.Revenue_Line_Graph_dataGrid.Size = new System.Drawing.Size(653, 312);
            this.Revenue_Line_Graph_dataGrid.TabIndex = 2;
            this.Revenue_Line_Graph_dataGrid.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // Income
            // 
            this.Income.DataPropertyName = "Income";
            this.Income.HeaderText = "Income";
            this.Income.Name = "Income";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelInstructions.ForeColor = System.Drawing.Color.Crimson;
            this.labelInstructions.Location = new System.Drawing.Point(30, 50);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(612, 128);
            this.labelInstructions.TabIndex = 3;
            this.labelInstructions.Text = "->Input Values For Comparison of Your Income.\r\n->  For the Last Years\r\n-> Income " +
    "Per Month\r\n-> From January_December\r\n";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(WindowsFormsApplication5.Revenue);
            // 
            // Data_Form_Line_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1859, 830);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.Revenue_Line_Graph_dataGrid);
            this.Controls.Add(this.button_Load_Line_Graph);
            this.Controls.Add(this.cartesianChart_Line_Graph);
            this.Name = "Data_Form_Line_Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data_Form_Line_Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Data_Form_Line_Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Revenue_Line_Graph_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart_Line_Graph;
        private System.Windows.Forms.Button button_Load_Line_Graph;
        private System.Windows.Forms.DataGridView Revenue_Line_Graph_dataGrid;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelInstructions;
    }
}