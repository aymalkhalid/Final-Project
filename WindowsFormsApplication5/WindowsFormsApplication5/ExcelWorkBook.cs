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
        string path = @"Z:\WindowsFormsApplication5\'Start Data Visualization' Form Files\DataPassed.txt";
        string OutPutData = @"Z:\WindowsFormsApplication5\'Start Data Visualization' Form Files\DataRetrived.txt";
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void WorkBook_Load(object sender, EventArgs e)
        {
            labelBasicStacked.Visible = false;
            labelLineChart.Visible = false;
            labelDoughNutChart.Visible = false;
            labelRowChart.Visible = false;
            labelColumnChart.Visible = false;
            labelPieChart.Visible = false;
            labelSelectChart.Visible = false;
      
            pictureBoxColumn.Visible = false;
            pictureBoxPie.Visible = false;
            pictureBoxRow.Visible = false;
            pictureBoxDoughNut.Visible = false;
            pictureBoxStacked.Visible = false;
            pictureBoxLine.Visible = false;
            pieChart_Population.Visible = false;
            cartesianChartStacked.Visible = false;
            cartesianChartLine.Visible = false;
            labelLineChart.Visible = false;
            pictureBoxLine.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            //Intialization OF charts
            //Pie_Chart Intialization
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            //Dough-Nut Chart
            pieChart1.InnerRadius = 50;
            pieChart1.LegendLocation = LegendLocation.Right;
            // Stacked_Chart Intialization
            cartesianChartStacked.AxisX.Add(new Axis
            {
                Title = "Browser",
                Labels = new[] { "Chrome", "Mozilla", "Opera", "IE" },
                Separator = DefaultAxes.CleanSeparator
            });
            cartesianChartStacked.AxisY.Add(new Axis
            {
                Title = "Usage",
                LabelFormatter = value => value + "MILLION"
            });
            //Line Chart Intialization
            cartesianChartLine.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });

            cartesianChartLine.AxisY.Add(new Axis
            {
                Title = "Sales",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChartLine.LegendLocation = LegendLocation.Right;
            // column Chart intialization
            cartesianChartBasicColumn.AxisX.Add(new Axis
            {
                Title = "Animals",
                Labels = new[] { "Cats", "Dogs", "Bears" }
            });

            cartesianChartBasicColumn.AxisY.Add(new Axis
            {
                Title = "Value",
                LabelFormatter = value => value.ToString("N")
            });
            cartesianChartBasicColumn.LegendLocation = LegendLocation.Right;
            // Row Chart Intialization
            cartesianChart_Basic_Row.AxisY.Add(new Axis
            {
                Labels = new[] { "Aymal", "Wajahat", "Ali"}
            });
            cartesianChart_Basic_Row.AxisX.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N") + "Ten"
            });
            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };
            cartesianChart_Basic_Row.DataTooltip = tooltip;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerLoadingData.Start();
            DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
            dataGridViewExcel.DataSource = tableData;
            DataSet copy = result.Copy();
            DataTableReader tableReader = new DataTableReader(tableData);
            while (tableReader.Read())
            {
                for (int i = 0; i < tableReader.FieldCount; i++)
                {
                    int exit = tableReader.FieldCount;
                    using (StreamWriter outPutFile = new StreamWriter(path, true))
                    {
                        outPutFile.WriteLine(tableReader[i]);
                    }
                }
            }
            string[] read_Data = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < read_Data.Length; i = i + 2)
            {
                using (StreamWriter outputColumnData = new StreamWriter(OutPutData, true))
                {
                    outputColumnData.WriteLine(read_Data[i]);
                }
            }

            if (textBoxfilename.Text == "Pie_Chart.xlsx")
            {
                labelPieChart.Visible = true;
                pictureBoxPie.Visible = true;

            }
            else if (textBoxfilename.Text == "DoughNut_Chart.xlsx")
            {
                labelDoughNutChart.Visible = true;
                pictureBoxDoughNut.Visible = true;
            }
            else if (textBoxfilename.Text == "Stacked_Chart.xlsx")
            {
                labelBasicStacked.Visible = true;
                pictureBoxStacked.Visible = true;
            }
            else if (textBoxfilename.Text == "Line_Chart.xlsx")
            {
                labelLineChart.Visible = true;
                pictureBoxLine.Visible = true;
            }
            else if (textBoxfilename.Text == "Basic_Row.xlsx")
            {
                labelRowChart.Visible = true;
                pictureBoxRow.Visible = true;
            }
            else if (textBoxfilename.Text == "Basic_Column.xlsx")
            {
                labelColumnChart.Visible = true;
                pictureBoxColumn.Visible = true;
            }
            //cartesianChart1.Series = new SeriesCollection
            //{
            //    new GColumnSeries
            //    {
            //        Title="Units",
            //        Values = new ChartValues<double> { 95,50,36,27}
            //    }
            //};
            //cartesianChart1.AxisX.Add(new Axis
            //{
            //    Title = "Sales Man",
            //    Labels = new[] { "Jones", "Kivell", "Jardine", "Gill" }
            //});

            //cartesianChart1.AxisY.Add(new Axis
            //{
            //    Title = "Sold Apps",
            //    LabelFormatter = value => value.ToString("N")
            //});

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
            labelSelectChart.Text = "";
            labelBasicStacked.Visible = false;
            labelLineChart.Visible = false;
            labelDoughNutChart.Visible = false;
            labelRowChart.Visible = false;
            labelColumnChart.Visible = false;
            labelPieChart.Visible = false;
            labelSelectChart.Visible = false;
            pictureBoxColumn.Visible = false;
            pictureBoxPie.Visible = false;
            pictureBoxRow.Visible = false;
            pictureBoxDoughNut.Visible = false;
            pictureBoxStacked.Visible = false;
            pictureBoxLine.Visible = false;
            pieChart_Population.Visible = false;
            cartesianChartStacked.Visible = false;
            pieChart1.Visible = false;
            cartesianChartLine.Visible = false;
            labelLineChart.Visible = false;
            pictureBoxLine.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartBasicColumn.Visible = false;
            comboBoxSheetSelected.Text = " ";
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|CSV|*.csv", ValidateNames = true, Multiselect = false })
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    FileInfo info = new FileInfo(path);
                    textBoxFilePath.Text = openFileDialog.FileName;
                    textBoxFileType.Text = info.Extension;
                    textBoxfilename.Text = info.Name;

                    if (info.Extension == ".csv" || info.Extension == "CSV")
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
                                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = false }
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
                                    //if (filena)
                                    //if (textBoxfilename.Text == "Pie_Chart.xlsx")
                                    //{
                                    //    labelPieChart.Visible = true;
                                    //    pictureBoxPie.Visible = true;
                                    //}
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
            cartesianChartLine.Visible = true;
            labelSelectChart.Text += "";
            if (textBoxfilename.Text == "Line_Chart.xlsx")
            {
                cartesianChartLine.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Visible = true;
                labelSelectChart.Text = "Can Only Create Line Chart \nFor this Data";
                labelLineChart.Visible = true;
                pictureBoxLine.Visible = true;
                cartesianChartLine.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var jan = row.Field<double>("Jan");
                    values.Add(jan);
                    var feb = row.Field<double>("Feb");
                    values.Add(feb);
                    var mar = row.Field<double>("Mar");
                    values.Add(mar);
                    var apr = row.Field<double>("Apr");
                    values.Add(apr);
                    var may = row.Field<double>("May");
                    values.Add(may);
                    var year = row.Field<double>("Year");
                    series.Add(
                        new LineSeries()
                        {
                            Title = year.ToString(),
                            Values = new ChartValues<double>(values),
                            PointGeometry = DefaultGeometries.Square,
                            PointGeometrySize = 15
                        });
                }
                cartesianChartLine.Series = series;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLineChart_Click(object sender, EventArgs e)
        {
            cartesianChartLine.Visible = true;
            labelSelectChart.Text += "";
            if (textBoxfilename.Text == "Line_Chart.xlsx")
            {
                cartesianChartLine.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Visible = true;
                labelSelectChart.Text = "Can Only Create Line Chart \nFor this Data";
                labelLineChart.Visible = true;
                pictureBoxLine.Visible = true;
                cartesianChartLine.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var jan = row.Field<double>("Jan");
                    values.Add(jan);
                    var feb = row.Field<double>("Feb");
                    values.Add(feb);
                    var mar = row.Field<double>("Mar");
                    values.Add(mar);
                    var apr = row.Field<double>("Apr");
                    values.Add(apr);
                    var may = row.Field<double>("May");
                    values.Add(may);
                    var year = row.Field<double>("Year");
                    series.Add(
                        new LineSeries()
                        {
                            Title = year.ToString(),
                            Values = new ChartValues<double>(values),
                            PointGeometry = DefaultGeometries.Square,
                            PointGeometrySize = 15
                        });
                }
                cartesianChartLine.Series = series;
            }
        }

        private void pictureBoxPie_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            pieChart_Population.Visible = true;
            if (textBoxfilename.Text == "Pie_Chart.xlsx")
            {
                pieChart_Population.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Visible = true;
                labelSelectChart.Text = "Can Only Create Pie_Chart \n For this Data";
                labelPieChart.Visible = true;
                pictureBoxPie.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var gender = row.Field<string>("Gender");
                    var population = row.Field<double>("Population");
                    values.Add(population);
                    series.Add(new PieSeries() { Title = gender, Values = new ChartValues<double>(values), DataLabels = true });
                }
                pieChart_Population.Series = series;
            }
        }

        private void labelPieChart_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "Pie_Chart.xlsx")
            {
                pieChart_Population.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Visible = true;
                labelSelectChart.Text = "Can Only Create Pie_Chart \nFor this Data";
                labelPieChart.Visible = true;
                pictureBoxPie.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var gender = row.Field<string>("Gender");
                    var population = row.Field<double>("Population");
                    values.Add(population);
                    series.Add(new PieSeries() { Title = gender, Values = new ChartValues<double>(values), DataLabels = true });
                }
                pieChart_Population.Series = series;
            }
        }

        private void pictureBoxDoughNut_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "DoughNut_Chart.xlsx")
            {
                pieChart1.Visible = true;
                pieChart1.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Visible = true;
                labelSelectChart.Text = "Can Only Create Dough_Nut \nFor this Data";
                labelDoughNutChart.Visible = true;
                pictureBoxDoughNut.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var browser = row.Field<string>("Browser");
                    var users = row.Field<double>("Users");
                    values.Add(users);
                    series.Add(new PieSeries() { Title = browser, Values = new ChartValues<double>(values), DataLabels = true });
                }
                pieChart1.Series = series;
            }
        }

        private void pieChart_Population_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void pictureBoxStacked_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "Stacked_Chart.xlsx")
            {
                cartesianChartStacked.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Text = "Can Only Create Stacked Chart \nFor this Data";
                labelBasicStacked.Visible = true;
                pictureBoxStacked.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var chrome = row.Field<double>("Chrome");
                    values.Add(chrome);
                    var mozilla = row.Field<double>("Mozilla");
                    values.Add(mozilla);
                    var opera = row.Field<double>("Opera");
                    values.Add(opera);
                    var iE = row.Field<double>("IE");
                    values.Add(iE);
                    series.Add(new StackedColumnSeries() { Values = new ChartValues<double>(values), DataLabels = true });
                }
                cartesianChartStacked.Series = series;
            }
        }

        private void labelDoughNutChart_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "DoughNut_Chart.xlsx")
            {
                pieChart1.Visible = true;
                pieChart1.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Visible = true;
                labelSelectChart.Text = "Can Only Create Dough_Nut \nFor this Data";
                labelDoughNutChart.Visible = true;
                pictureBoxDoughNut.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var browser = row.Field<string>("Browser");
                    var users = row.Field<double>("Users");
                    values.Add(users);
                    series.Add(new PieSeries() { Title = browser, Values = new ChartValues<double>(values), DataLabels = true });
                }
                pieChart1.Series = series;
            }
        }

        private void labelBasicStacked_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "Stacked_Chart.xlsx")
            {
                cartesianChartStacked.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Text = "Can Only Create Stacked Chart \nFor this Data";
                labelBasicStacked.Visible = true;
                pictureBoxStacked.Visible = true;
                cartesianChartStacked.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var chrome = row.Field<double>("Chrome");
                    values.Add(chrome);
                    var mozilla = row.Field<double>("Mozilla");
                    values.Add(mozilla);
                    var opera = row.Field<double>("Opera");
                    values.Add(opera);
                    var iE = row.Field<double>("IE");
                    values.Add(iE);
                    series.Add(new StackedColumnSeries() { Values = new ChartValues<double>(values), DataLabels = true });
                }
                cartesianChartStacked.Series = series;
            }
        }

        private void pictureBoxRow_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "Basic_Row.xlsx")
            {
                cartesianChart_Basic_Row.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Text = "Can Only Create Row Chart \nFor this Data";
                labelRowChart.Visible = true;
                pictureBoxRow.Visible = true;
                cartesianChart_Basic_Row.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    //var salesManUmar = row.Field<double>("Umar");
                    //values.Add(salesManUmar);
                    var salesManAymal = row.Field<double>("Aymal");
                    values.Add(salesManAymal);
                    var salesManWajahat = row.Field<double>("Wajahat");
                    values.Add(salesManWajahat);
                    var salesManAli = row.Field<double>("Ali");
                    values.Add(salesManAli);
                    var year = row.Field<double>("Year");
                    series.Add(new RowSeries() { Title = year.ToString(), Values = new ChartValues<double>(values), DataLabels = true });
                }
                cartesianChart_Basic_Row.Series = series;
            }
        }

        private void pictureBoxColumn_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "Basic_Column.xlsx")
            {
                cartesianChartBasicColumn.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Text = "Can Only Create Column Chart \nFor this Data";
                labelColumnChart.Visible = true;
                pictureBoxColumn.Visible = true;
                cartesianChartBasicColumn.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    //var salesManUmar = row.Field<double>("Umar");
                    //values.Add(salesManUmar);
                    var cats = row.Field<double>("Cats");
                    values.Add(cats);
                    var dogs = row.Field<double>("Dogs");
                    values.Add(dogs);
                    var bears = row.Field<double>("Bears");
                    values.Add(bears);
                    var year = row.Field<double>("Year");
                    series.Add(new RowSeries() { Title = year.ToString(), Values = new ChartValues<double>(values)});
                }
                cartesianChartBasicColumn.Series = series;
            }
        }

        private void labelColumnChart_Click(object sender, EventArgs e)
        {
            labelSelectChart.Text = "";
            if (textBoxfilename.Text == "Basic_Column.xlsx")
            {
                cartesianChartBasicColumn.Series.Clear();
                SeriesCollection series = new SeriesCollection();
                labelSelectChart.Text = "Can Only Create Column Chart \nFor this Data";
                labelColumnChart.Visible = true;
                pictureBoxColumn.Visible = true;
                cartesianChartBasicColumn.Visible = true;
                DataTable tableData = tableCollection[comboBoxSheetSelected.SelectedItem.ToString()];
                foreach (var row in tableData.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    //var salesManUmar = row.Field<double>("Umar");
                    //values.Add(salesManUmar);
                    var cats = row.Field<double>("Cats");
                    values.Add(cats);
                    var dogs = row.Field<double>("Dogs");
                    values.Add(dogs);
                    var bears = row.Field<double>("Bears");
                    values.Add(bears);
                    var year = row.Field<double>("Year");
                    series.Add(new ColumnSeries() { Title = year.ToString(), Values = new ChartValues<double>(values), DataLabels = true });
                }
                cartesianChartBasicColumn.Series = series;
            }
        }

        private void timerLoadingData_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(9990);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Excel_WorkBook_Form close = new Excel_WorkBook_Form();
            close.Close();
            Connection back = new Connection();
            back.Show();
        }
    }
}


