namespace WindowsFormsApplication5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelConnect = new System.Windows.Forms.Panel();
            this.buttonDataBase = new System.Windows.Forms.Button();
            this.buttonfile = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelSample = new System.Windows.Forms.Panel();
            this.labelSample = new System.Windows.Forms.Label();
            this.panelConnect.SuspendLayout();
            this.PanelSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConnect
            // 
            this.panelConnect.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelConnect.Controls.Add(this.buttonDataBase);
            this.panelConnect.Controls.Add(this.buttonfile);
            this.panelConnect.Controls.Add(this.buttonExcel);
            this.panelConnect.Controls.Add(this.labelFile);
            this.panelConnect.Controls.Add(this.labelConnect);
            this.panelConnect.Location = new System.Drawing.Point(12, 12);
            this.panelConnect.Name = "panelConnect";
            this.panelConnect.Size = new System.Drawing.Size(191, 586);
            this.panelConnect.TabIndex = 0;
            // 
            // buttonDataBase
            // 
            this.buttonDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDataBase.Image = ((System.Drawing.Image)(resources.GetObject("buttonDataBase.Image")));
            this.buttonDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDataBase.Location = new System.Drawing.Point(9, 277);
            this.buttonDataBase.Name = "buttonDataBase";
            this.buttonDataBase.Size = new System.Drawing.Size(169, 44);
            this.buttonDataBase.TabIndex = 3;
            this.buttonDataBase.Text = "   DataBase";
            this.buttonDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDataBase.UseVisualStyleBackColor = true;
            // 
            // buttonfile
            // 
            this.buttonfile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.buttonfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonfile.Image")));
            this.buttonfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonfile.Location = new System.Drawing.Point(9, 189);
            this.buttonfile.Name = "buttonfile";
            this.buttonfile.Size = new System.Drawing.Size(169, 53);
            this.buttonfile.TabIndex = 2;
            this.buttonfile.Text = "           Text";
            this.buttonfile.UseVisualStyleBackColor = false;
            // 
            // buttonExcel
            // 
            this.buttonExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExcel.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonExcel.ForeColor = System.Drawing.Color.White;
            this.buttonExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcel.Image")));
            this.buttonExcel.Location = new System.Drawing.Point(9, 114);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(169, 59);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "                 Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelFile.ForeColor = System.Drawing.Color.Cornsilk;
            this.labelFile.Location = new System.Drawing.Point(17, 63);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(90, 29);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "To File";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.labelConnect.Location = new System.Drawing.Point(3, 14);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(126, 36);
            this.labelConnect.TabIndex = 0;
            this.labelConnect.Text = "Connect";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1048, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 586);
            this.panel2.TabIndex = 1;
            // 
            // PanelSample
            // 
            this.PanelSample.BackColor = System.Drawing.SystemColors.Info;
            this.PanelSample.Controls.Add(this.labelSample);
            this.PanelSample.Location = new System.Drawing.Point(243, 12);
            this.PanelSample.Name = "PanelSample";
            this.PanelSample.Size = new System.Drawing.Size(765, 586);
            this.PanelSample.TabIndex = 2;
            // 
            // labelSample
            // 
            this.labelSample.AutoSize = true;
            this.labelSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.labelSample.Location = new System.Drawing.Point(224, 31);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(277, 36);
            this.labelSample.TabIndex = 2;
            this.labelSample.Text = "Sample WorkBooks";
            this.labelSample.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1272, 610);
            this.Controls.Add(this.PanelSample);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelConnect);
            this.Name = "Form2";
            this.Text = "Help Your Self";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelConnect.ResumeLayout(false);
            this.panelConnect.PerformLayout();
            this.PanelSample.ResumeLayout(false);
            this.PanelSample.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConnect;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelSample;
        private System.Windows.Forms.Button buttonDataBase;
        private System.Windows.Forms.Button buttonfile;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Label labelSample;
    }
}