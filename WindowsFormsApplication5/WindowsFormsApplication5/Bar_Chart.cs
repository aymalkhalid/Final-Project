using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Bar_Chart : Form
    {
        public Bar_Chart()
        {
            InitializeComponent();
        }

        private void Bar_Chart_Load(object sender, EventArgs e)
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2015",
          
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2016",
   
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var get_Sales_Man = (from o in salesBindingSource.DataSource as List<Sales>
                                 select new { grid_Value_Sales_Man = o.Sales_Man }).Distinct();
            //cartesianChart1.AxisX.Add(new Axis
            //{
            //    Title = "Sales Man",
            //    Labels = new[] { "Maria", "Susan", "Charles", "Frida" }
            //});

            //cartesianChart1.AxisY.Add(new Axis
            //{
            //    Title = "Sold Apps",
            //    LabelFormatter = value => value.ToString("N")
            //});

        }
    }
}
