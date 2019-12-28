using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class DataBase : Form
    {
        public DataBase()
        {
            InitializeComponent();
        }
        DataTable dataTableBasic_Column = new DataTable();
        DataTable dataTableBasic_Row = new DataTable();
        DataTable dataTableDoughNut_Chart = new DataTable();
        DataTable dataTableLine_Chart = new DataTable();
        DataTable dataTablePie_Chart = new DataTable();
        DataTable dataTableStacked_Chart = new DataTable();
        private void DataBase_Load(object sender, EventArgs e)
        {
            //labelBasicStacked.Visible = false;
            //labelLineChart.Visible = false;
            //labelDoughNutChart.Visible = false;
            //labelRowChart.Visible = false;
            //labelColumnChart.Visible = false;
            //labelPieChart.Visible = false;
            //pictureBoxColumn.Visible = false;
            //pictureBoxPie.Visible = false;
            //pictureBoxRow.Visible = false;
            //pictureBoxDoughNut.Visible = false;
            //pictureBoxStacked.Visible = false;
            //pictureBoxLine.Visible = false;
            //labelLineChart.Visible = false;
            //pictureBoxLine.Visible = false;
            pieChart1.Visible = false;
            pieChart2.Visible = true;
            cartesianChartStacked.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartLine.Visible = false;
            cartesianChartBasicColumn.Visible = false;
            string connectionString;
            SqlConnection connect;
            connectionString = @"Data Source=DESKTOP-TP26O9A\SQLEXPRESS;Initial Catalog=Visualization_Data;Integrated Security=True";
            connect = new SqlConnection(connectionString);
            connect.Open();
            MessageBox.Show("Connected To DataBase 'Visualization Data'  !");
         
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("select *from Basic_Column", connectionString))
            {
                dAdapter.Fill(dataTableBasic_Column);
                
            }
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("select *from Basic_Row;", connectionString))
            {
                dAdapter.Fill(dataTableBasic_Row);
                
            }
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("select *from DoughNut_Chart", connectionString))
            {
                dAdapter.Fill(dataTableDoughNut_Chart);
                
            }
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("select *from Line_chart", connectionString))
            {
                dAdapter.Fill(dataTableLine_Chart);
                
            }
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("select *from Pie_Chart", connectionString))
            {
                dAdapter.Fill(dataTablePie_Chart);
                
            }
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("select *from Stacked_Chart", connectionString))
            {
                dAdapter.Fill(dataTableStacked_Chart);
                
            }       
            connect.Close();
            //comboBox1.Items.Add(dataTableBasic_Column.TableName.ToString());
            //comboBox1.Items.Add(dataTableBasic_Row.TableName.ToString());
            //comboBox1.Items.Add(dataTableLine_Chart.TableName.ToString());
            //comboBox1.Items.Add(dataTableDoughNut_Chart.TableName.ToString());
            //comboBox1.Items.Add(dataTablePie_Chart.TableName.ToString());
            //comboBox1.Items.Add(dataTableStacked_Chart.TableName.ToString());

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

            //cartesian chart stacked
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
            //PieChart
            Func<ChartPoint, string> labelPoint = chartPoint =>
                          string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            //DoughNut
            pieChart1.InnerRadius = 50;
            pieChart1.LegendLocation = LegendLocation.Right;
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
                Labels = new[] { "Aymal", "Wajahat", "Ali" }
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
            //if (comboBox1.SelectedIndex.ToString()== "Basic_Column")
            //{
            //    labelColumnChart.Visible = true;
            //    pictureBoxColumn.Visible = true;
            //}
            //else if (comboBox1.SelectedIndex.ToString() == "Basic_Row")
            //{
            //    labelRowChart.Visible = true;
            //    pictureBoxRow.Visible = true;
            //}
            //else if (comboBox1.SelectedIndex.ToString() == "DoughNut_Chart")
            //{
            //    labelDoughNutChart.Visible = true;
            //    pictureBoxDoughNut.Visible = true;
            //}
            //else if (comboBox1.SelectedIndex.ToString() == "Line_Chart")
            //{
            //    labelLineChart.Visible = true;
            //    pictureBoxLine.Visible = true;
            //}
            //else if (comboBox1.SelectedIndex.ToString() == "Pie_Chart")
            //{
            //    labelPieChart.Visible = true;
            //    pictureBoxPie.Visible = true;
            //}
            //else if (comboBox1.SelectedIndex.ToString() == "Stacked_Chart")
            //{
            //    labelBasicStacked.Visible = true;
            //    pictureBoxStacked.Visible = true;
            //}
        }

        private void pictureBoxLine_Click(object sender, EventArgs e)
        {
            pieChart1.Visible = false;
            pieChart2.Visible = true;
            cartesianChartStacked.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartLine.Visible = true;
            cartesianChartBasicColumn.Visible = false;
            cartesianChartLine.Series.Clear();
                SeriesCollection series = new SeriesCollection();
  
               dataGridView1.DataSource = dataTableLine_Chart;
                foreach (var row in dataTableLine_Chart.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    var jan = Convert.ToInt32(row["Jan"]);
                    values.Add(jan);
                    var feb = Convert.ToInt32(row["Feb"]); ;
                    values.Add(feb);
                    var mar = Convert.ToInt32(row["Mar"]) ;
                    values.Add(mar);
                    var apr = Convert.ToInt32(row["Apr"]) ;
                    values.Add(apr);
                    var may = Convert.ToInt32(row["May"]);
                values.Add(may);
                    var year = Convert.ToString(row["Jan"]); 
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

        private void pictureBoxStacked_Click(object sender, EventArgs e)
        {
            pieChart1.Visible = false;
            pieChart2.Visible = true;
            cartesianChartStacked.Visible = true;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartLine.Visible = false;
            cartesianChartBasicColumn.Visible = false;
            cartesianChartStacked.Series.Clear();
            cartesianChartBasicColumn.Visible = false;
            SeriesCollection series = new SeriesCollection();
            dataGridView1.DataSource = dataTableStacked_Chart;
            foreach (var rowdata in dataTableStacked_Chart.AsEnumerable())
            {
                List<double> values = new List<double>();
                var chrome = Convert.ToInt32(rowdata["Chrome"]);
                values.Add(chrome);
                var mozilla = Convert.ToInt32(rowdata["Mozilla"]);
                values.Add(mozilla);
                var opera = Convert.ToInt32(rowdata["Opera"]);
                values.Add(opera);
                var iE = Convert.ToInt32(rowdata["IE"]);
                values.Add(iE);
                series.Add(new StackedColumnSeries() { Values = new ChartValues<double>(values), DataLabels = true });
            }
            cartesianChartStacked.Series = series;
        }

        private void pictureBoxDoughNut_Click(object sender, EventArgs e)
        {

            pieChart1.Visible = true;
            pieChart2.Visible = false ;
            cartesianChartStacked.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartLine.Visible = false;
            cartesianChartBasicColumn.Visible = false;
            pieChart1.Series.Clear();
            dataGridView1.DataSource = dataTableDoughNut_Chart;
            SeriesCollection series = new SeriesCollection();
            foreach (var row in dataTableDoughNut_Chart.AsEnumerable())
            {
                List<double> values = new List<double>();
                var browser = Convert.ToString(row["Browser"]);
                var users = Convert.ToInt32(row["Users"]);
                values.Add(users);
                series.Add(new PieSeries() { Title = browser, Values = new ChartValues<double>(values), DataLabels = true });
            }
            pieChart1.Series = series;
        }

        private void pictureBoxPie_Click(object sender, EventArgs e)
        {
            pieChart1.Visible = false;
            pieChart2.Visible = true;
            cartesianChartStacked.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartLine.Visible = false;            
            cartesianChartBasicColumn.Visible = false;  
            pieChart2.Series.Clear();
            dataGridView1.DataSource = dataTablePie_Chart;
            SeriesCollection series = new SeriesCollection();            
            foreach (var row in dataTablePie_Chart.AsEnumerable())
            {
                List<double> values = new List<double>();
                var gender = Convert.ToString(row["Gender"]);
                var population = Convert.ToInt32(row["Population"]);
                values.Add(population);
                series.Add(new PieSeries() { Title = gender, Values = new ChartValues<double>(values), DataLabels = true });
            }
            pieChart2.Series = series;
        }

        private void pictureBoxRow_Click(object sender, EventArgs e)
        {
            pieChart1.Visible = false;
            pieChart2.Visible = false;
            cartesianChartStacked.Visible = false;
            cartesianChart_Basic_Row.Visible = true;
            cartesianChartLine.Visible = false;            
            cartesianChartBasicColumn.Visible = false;
            cartesianChart_Basic_Row.Series.Clear();
            dataGridView1.DataSource = dataTableBasic_Row;
            SeriesCollection series = new SeriesCollection();            
                foreach (var row in dataTableBasic_Row.AsEnumerable())
                {
                    List<double> values = new List<double>();
                    //var salesManUmar = row.Field<double>("Umar");
                    //values.Add(salesManUmar);
                    var salesManAymal = Convert.ToDouble(row["Aymal"]);
                    values.Add(salesManAymal);
                    var salesManWajahat = Convert.ToDouble(row["Wajahat"]);
                    values.Add(salesManWajahat);
                    var salesManAli = Convert.ToDouble(row["Ali"]);
                values.Add(salesManAli);
                    var year = Convert.ToString(row["Year"]); 
                    series.Add(new RowSeries() { Title = year, Values = new ChartValues<double>(values), DataLabels = true });
                }
                cartesianChart_Basic_Row.Series = series;
            }

        private void pictureBoxColumn_Click(object sender, EventArgs e)
        {
            pieChart1.Visible = false;
            pieChart2.Visible = false;
            cartesianChartStacked.Visible = false;
            cartesianChart_Basic_Row.Visible = false;
            cartesianChartLine.Visible = false;
            cartesianChartBasicColumn.Visible = true;
            dataGridView1.DataSource = dataTableBasic_Column;
            cartesianChartBasicColumn.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            cartesianChartBasicColumn.Visible = true;
            foreach (var row in dataTableBasic_Column.AsEnumerable())
            {
                List<double> values = new List<double>();
                //var salesManUmar = row.Field<double>("Umar");
                //values.Add(salesManUmar);
                var cats = Convert.ToDouble(row["Cats"]);
                values.Add(cats);
                var dogs = Convert.ToDouble(row["Dogs"]);
                values.Add(dogs);
                var bears = Convert.ToDouble(row["Bears"]);
                values.Add(bears);
                var year = Convert.ToString(row["Year"]);
                series.Add(new RowSeries() { Title = year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChartBasicColumn.Series = series;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Connection obj = new Connection();
            DataBase close = new DataBase();
            close.Close();
            obj.Show();
        }
    }
}
