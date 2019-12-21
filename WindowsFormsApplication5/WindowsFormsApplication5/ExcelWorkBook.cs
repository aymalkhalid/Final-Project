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
using LiveCharts.Geared;
using LiveCharts;
using Newtonsoft.Json;
using LiveCharts.Wpf;
namespace WindowsFormsApplication5
{
    public partial class Excel_WorkBook_Form : Form
    {
        public Excel_WorkBook_Form()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartPoint =>
                           string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        DataTableCollection tableCollection;
        DataSet result = new DataSet();
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.buttonOpen.Text = openfileDialog1.FileName;
                string filename = DialogResult.ToString();
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;
                excelApp.Workbooks.Open(buttonOpen.Text);
                buttonOpen.Text = "Edit";
            }
        }
        string path= @"Z:\WindowsFormsApplication5\WindowsFormsApplication5\DataPassed.txt";
        string OutPutData= @"Z:\WindowsFormsApplication5\WindowsFormsApplication5\DataRetrived.txt";
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void WorkBook_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
            dataGridViewExcel.DataSource = tableData;
            DataSet copy = result.Copy();            
            DataTableReader tableReader = new DataTableReader(tableData);            
            while (tableReader.Read())
            {                
                for (int i = 0; i < tableReader.FieldCount; i++)
                {
                    int exit = tableReader.FieldCount;
                    using (StreamWriter outPutFile = new StreamWriter(path,true))
                    {
                        outPutFile.WriteLine(tableReader[i]);                      
                    }                   
                }                
            }
            string[] firstColumndata = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < firstColumndata.Length; i=i+2)
            {
                using (StreamWriter outputColumnData = new StreamWriter(OutPutData,true))
                {
                    outputColumnData.WriteLine(firstColumndata[i]);
                }
            }

            cartesianChart1.Series = new SeriesCollection
            {
                new GColumnSeries
                {
                    Title="Units",
                    Values = new ChartValues<double> { 95,50,36,27}
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Sales Man",
                Labels = new[] { "Jones", "Kivell", "Jardine", "Gill" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });

            //pieChart1.Series = new SeriesCollection
            //{
            //    new PieSeries
            //    {
            //        Title = "Maria",
            //        Values = new ChartValues<double> {3},
            //        PushOut = 15,
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries
            //    {
            //        Title = "Charles",
            //        Values = new ChartValues<double> {4},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries
            //    {
            //        Title = "Frida",
            //        Values = new ChartValues<double> {6},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries
            //    {
            //        Title = "Frederic",
            //        Values = new ChartValues<double> {2},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    }
            //};


        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|CSV|*.csv" ,ValidateNames = true, Multiselect = false })
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    FileInfo info = new FileInfo(path);
                    textBoxFilePath.Text = openFileDialog.FileName;
                    textBoxFileType.Text = info.Extension;
                    textBoxfilename.Text = info.Name;

                    if (info.Extension == ".csv"|| info.Extension=="CSV")
                    {
                        labelExcelTable.ResetText();
                        try
                        {
                            using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                            {
                                using (IExcelDataReader reader = ExcelReaderFactory.CreateCsvReader(stream))
                                {
                                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                    {
                                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = false}
                                    });
                                    tableCollection = result.Tables;
                                    comboBoxSheetSelected.Items.Clear();
                                   
                                    foreach (DataTable table in tableCollection)
                                    {
                                        comboBoxSheetSelected.Items.Add(table.TableName);
                                       
                                    }
                                    labelExcelTable.Text = "Excel Data in Tabular Form is As Follow" + "->Total No of Rows are ::" + reader.RowCount;
                                    //DataSet copy = result.Copy();
                                    //firstLiveChart(copy);
                                }          
                                
                            }
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message, "Wrong File Format Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                   
                    }
                    else
                    {
                        labelExcelTable.ResetText();
                        try
                        {
                            using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                            {
                                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                                {
                                     result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                    {
                                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                    });
                                    tableCollection = result.Tables;   //result is from the Class dataset (which Stores in memory relational databases)                                     
                                    comboBoxSheetSelected.Items.Clear();
                                    foreach (DataTable table in tableCollection)
                                    {
                                        comboBoxSheetSelected.Items.Add(table.TableName);                                     
                                    }
                                    labelExcelTable.Text = "Excel Data in Tabular Form is As Follow" + "->Total No of Rows are ::" + reader.RowCount;                                                                    
                                }
                           }                                                                     
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message, "Wrong File Format Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
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

        private void textBoxFileType_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxLine_Click(object sender, EventArgs e)
        {     
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
