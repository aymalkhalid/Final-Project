using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace WindowsFormsApplication5
{
    public partial class Data_Form_Line_Graph : Form
    {
        public Data_Form_Line_Graph()
        {
            InitializeComponent();
        }

        private void Data_Form_Line_Graph_Load(object sender, EventArgs e)
        {
            revenueBindingSource.DataSource = new List<Revenue>();
            cartesianChart_Line_Graph.AxisX.Add(new Axis
            {
             
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart_Line_Graph.AxisY.Add(new Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart_Line_Graph.LegendLocation = LegendLocation.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartesianChart_Line_Graph.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var get_years = (from o in revenueBindingSource.DataSource as List<Revenue>
                         select new { grid_Value_Year = o.Year }).Distinct();
            foreach (var year in get_years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in revenueBindingSource.DataSource as List<Revenue>
                               where o.Year.Equals(year.grid_Value_Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Income, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Income;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.grid_Value_Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart_Line_Graph.Series = series;
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
           
            //e.Row.Cells["Year"].Value = "2018";
            //e.Row.Cells["Month"].Value = "1";
            //e.Row.Cells["Income"].Value = "1000";
          
        }
    }
    }

