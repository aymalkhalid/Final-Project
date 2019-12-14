using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    partial class WorkBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelExcelFile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfilename = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.Label();
            this.comboBoxSheetSelected = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nullLogFactoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nullLogFactoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonOpen.Location = new System.Drawing.Point(1361, 0);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(562, 144);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "...Browse";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelExcelFile
            // 
            this.labelExcelFile.AutoSize = true;
            this.labelExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.labelExcelFile.Location = new System.Drawing.Point(604, 36);
            this.labelExcelFile.Name = "labelExcelFile";
            this.labelExcelFile.Size = new System.Drawing.Size(674, 73);
            this.labelExcelFile.TabIndex = 1;
            this.labelExcelFile.Text = "Edit Your File in Excel ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelExcelFile);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Location = new System.Drawing.Point(0, 906);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1934, 162);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtf);
            this.panel2.Controls.Add(this.comboBoxSheetSelected);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.textBoxfilename);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 894);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Selected_Sheet:";
            // 
            // textBoxfilename
            // 
            this.textBoxfilename.Location = new System.Drawing.Point(3, 91);
            this.textBoxfilename.Name = "textBoxfilename";
            this.textBoxfilename.ReadOnly = true;
            this.textBoxfilename.Size = new System.Drawing.Size(378, 26);
            this.textBoxfilename.TabIndex = 14;
            // 
            // txtf
            // 
            this.txtf.AutoSize = true;
            this.txtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtf.Location = new System.Drawing.Point(7, 59);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(131, 29);
            this.txtf.TabIndex = 12;
            this.txtf.Text = "File Name:";
            // 
            // comboBoxSheetSelected
            // 
            this.comboBoxSheetSelected.FormattingEnabled = true;
            this.comboBoxSheetSelected.Location = new System.Drawing.Point(0, 157);
            this.comboBoxSheetSelected.Name = "comboBoxSheetSelected";
            this.comboBoxSheetSelected.Size = new System.Drawing.Size(378, 28);
            this.comboBoxSheetSelected.TabIndex = 13;
            this.comboBoxSheetSelected.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowse.Location = new System.Drawing.Point(3, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(378, 49);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataGridViewExcel);
            this.panel3.Location = new System.Drawing.Point(384, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1539, 393);
            this.panel3.TabIndex = 9;
            // 
            // nullLogFactoryBindingSource
            // 
            this.nullLogFactoryBindingSource.DataSource = typeof(ExcelDataReader.Log.Logger.NullLogFactory);
            // 
            // dataGridViewExcel
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewExcel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewExcel.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewExcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcel.Location = new System.Drawing.Point(0, 37);
            this.dataGridViewExcel.Name = "dataGridViewExcel";
            this.dataGridViewExcel.ReadOnly = true;
            this.dataGridViewExcel.RowTemplate.Height = 28;
            this.dataGridViewExcel.Size = new System.Drawing.Size(1536, 350);
            this.dataGridViewExcel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Excel File Data in Tabluar Form:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // WorkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "WorkBook";
            this.Text = "WorkBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nullLogFactoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcel)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelExcelFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private BindingSource nullLogFactoryBindingSource;
        private Label label2;
        private TextBox textBoxfilename;
        private Label txtf;
        private ComboBox comboBoxSheetSelected;
        private Button btnBrowse;
        private DataGridView dataGridViewExcel;
        private Label label1;
    }
}