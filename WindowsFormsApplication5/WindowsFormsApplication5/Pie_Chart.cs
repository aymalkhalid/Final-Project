using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts;

namespace WindowsFormsApplication5
{
    public partial class Pie_Chart : Form
    {
        public Pie_Chart()
        {
            InitializeComponent();
        }

        private void Pie_Chart_Load(object sender, EventArgs e)
        {
            History obj = new History();
            historyBindingSource.DataSource = new List<History>();
            Func<ChartPoint, string> labelPoint = chartPoint =>
          string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            //pieChart_History_Sales.Series = new SeriesCollection
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
            pieChart_History_Sales.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            var get_History_linq = (from object_Category_ in historyBindingSource.DataSource as List<History>
                                    select new { grid_Value_Category =object_Category_.category ,grid_Value_units=object_Category_.units }).Distinct();
            foreach (var item in get_History_linq)
            {
                var data = (from object_Data in historyBindingSource.DataSource as List<History>
                            where object_Data.category.Equals(item.grid_Value_Category) && object_Data.units.Equals(item.grid_Value_units)
                            select new { object_Data.category, object_Data.units }).Distinct();
                List<double> values = new List<double>();
                       double value = 0;
                if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().units;
                    values.Add(value);
                    series.Add(new PieSeries() { Title = item.grid_Value_Category.ToString(), Values = new ChartValues<double>(values), DataLabels = true });  

            }
            pieChart_History_Sales.Series = series;
            //var get_History_Category_linq = (from object_Category_ in historyBindingSource.DataSource as List<History>
            //                        select new { grid_Value_Category =object_Category_.category }).Distinct();
            //var get_History_Units_linq = (from object_Units_ in historyBindingSource.DataSource as List<History>
            //                                 select new { grid_value_Units=object_Units_.units}).Distinct();
            //foreach (var category in get_History_Category_linq)
            //{
            //    foreach (var units in get_History_Units_linq)
            //    {
            //        List<double> values = new List<double>();
            //        double value = 0;
            //        var data = from whole_data in historyBindingSource.DataSource as List<History>
            //                   where whole_data.category.Equals(category.grid_Value_Category) && whole_data.category.Equals(units.grid_value_Units)
            //                   orderby whole_data.units ascending
            //                   select new { whole_data.units, whole_data.category };
            //        if (data.SingleOrDefault() != null)
            //            value = data.SingleOrDefault().units;
            //        values.Add(value);
            //        series.Add(new PieSeries() { Title = category.grid_Value_Category.ToString(), Values = new ChartValues<double>(values), DataLabels = true });                   
            //        }

            //}
            pieChart_History_Sales.Series = series;
        }

        private void pieChart_History_Sales_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
