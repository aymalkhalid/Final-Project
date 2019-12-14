using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//forDataSetConfiguration
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //for importing the excel file
using System.IO;
using ExcelNumberFormat;
using ExcelDataReader;
using System.Data.Common;
namespace WindowsFormsApplication5
{
    public partial class WorkBook : Form
    {
        public WorkBook()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.buttonOpen.Text = openfileDialog1.FileName;
                String filename = DialogResult.ToString();
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;
                excelApp.Workbooks.Open(buttonOpen.Text);
                buttonOpen.Text = "Edit";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void WorkBook_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
            dataGridViewExcel.DataSource = data;
        }
 
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"})
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    textBoxfilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using (IExcelDataReader reader=ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=>new ExcelDataTableConfiguration() {UseHeaderRow=true}
                            });
                            tableCollection = result.Tables;
                            comboBoxSheetSelected.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                comboBoxSheetSelected.Items.Add(table.TableName);
                            }             
                        }
                    }
                }
          }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
