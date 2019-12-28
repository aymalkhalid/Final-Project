using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            salesBindingSource1.DataSource = new List<Sales>();
            //var get_sales_Sales_Man = (from salesObject in salesBindingSource.DataSource as List<Sales>
            //                           select new { salesObject.Sales_Man }).Distinct();
            //int size = get_sales_Sales_Man.Count();
            //richTextBox1.Text = size.ToString();
            //string[] salesManNames = new string[size];
            //int counter = 0;

            //foreach (var item in get_sales_Sales_Man)
            //{
            //    if (counter <= size)
            //    {
            //        salesManNames.SetValue(item.Sales_Man, counter);
            //        counter++;
            //    }
            //}
            cartesianChartBar.Series.Clear();
            cartesianChartRow.Series.Clear();
            cartesianChartBar.AxisX.Add(new Axis
            {
                Title = "Sales Man",
                Labels = new[] { "Aymal","Ali"}
            });

            cartesianChartBar.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });
            cartesianChartRow.AxisY.Add(new Axis
            {
                Labels = new[] { "Aymal","Ali"}
            });

            cartesianChartRow.AxisX.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N")
            });

            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            cartesianChartRow.DataTooltip = tooltip;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartesianChartBar.Series.Clear();
            cartesianChartRow.Series.Clear();
           // string path = @"Z:\WindowsFormsApplication5\Testing.txt";
            SeriesCollection barSeries = new SeriesCollection();
            SeriesCollection Row_Series = new SeriesCollection();
            var get_Sales_year = (from object_Sales_Year in salesBindingSource1.DataSource as List<Sales>
                                  select new { grid_value_Sales_year = object_Sales_Year.year }).Distinct();
            var get_Sales_Apps_Values = (from object_Sales_Values in salesBindingSource1.DataSource as List<Sales>
                                  select new { grid_value_Sales = object_Sales_Values.Apps_Solds }).Distinct();
            foreach (var year_sale in get_Sales_year)
            {
                foreach (var year_app_sold in get_Sales_Apps_Values)
                {
                    List<double> values = new List<double>();
                    double value = 0;
                    var data = from data_whole in salesBindingSource1.DataSource as List<Sales>
                                where data_whole.year.Equals(year_sale.grid_value_Sales_year) && data_whole.Apps_Solds.Equals(year_app_sold.grid_value_Sales)
                                orderby data_whole.year ascending
                                select new { data_whole.year,data_whole.Apps_Solds};
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Apps_Solds;
                    values.Add(value);
                    barSeries.Add(new ColumnSeries() { Title = year_sale.grid_value_Sales_year.ToString(), Values = new ChartValues<double>(values) });
                    Row_Series.Add(new RowSeries() { Title = year_sale.grid_value_Sales_year.ToString(), Values = new ChartValues<double>(values) });
                    cartesianChartBar.Series = barSeries;
                    cartesianChartRow.Series = Row_Series;
                }
               
            }
          
            //var get_Sales_SalesMan

            //using (StreamWriter outputFile = new StreamWriter(path, true))
            //{
            //    foreach (string item in salesman)
            //    {
            //        outputFile.WriteLine(item);
            //    }
            //}
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    richTextBox1.Text = temp[i].ToString();
            //      richTextBox1.AppendText( temp[i].ToString());
            //}

        }

        private void salesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
//Sales objectDummy = new Sales();
//objectDummy.Sales_Man = "Aymal";
//objectDummy.Apps_Solds =300;
//objectDummy.year =2019;
//Sales objectDummy1 = new Sales();
//objectDummy.Sales_Man = "Faroq";
//objectDummy.Apps_Solds =200;
//objectDummy.year = 2019;
//Sales objectDummy2 = new Sales();
//objectDummy.Sales_Man = "Umar";
//objectDummy.Apps_Solds =100;
//objectDummy.year = 2019;
//Sales[] arrayObjecDummy = new Sales[4];
//dataGridView1.DataSource = arrayObjecDummy;




// string salesman = item.ToString();
//cartesianChart1.AxisX.Add(new Axis
//{
//        Title = "Sales Man"            ,        
//        Labels= new [] { temp[0],temp[1], temp[2], temp[3] ,temp[4], temp[5], temp[6],temp[7],temp[8],temp[9]}
//    });
//cartesianChart1.AxisY.Add(new Axis
//{
//    Title = "Sold Apps",
//    LabelFormatter = value => value.ToString("N")
//});
//cartesianChart1.LegendLocation = LegendLocation.Right;
//cartesianChart1.Series.Clear();
//SeriesCollection series = new SeriesCollection();
////var get_Year_linq = (from object_sales in salesBindingSource.DataSource as List<Sales>
////                     select new { grid_Value_year = object_sales.year }).Distinct();
//////var get_SoldApp_Linq = (from object_sales in salesBindingSource.DataSource as List<Sales>
//////                        select new { grid_Value_year = object_sales.Apps_Solds }).Distinct();
////var get_SalesMan_linq = (from object_sales in salesBindingSource.DataSource as List<Sales>
////                         select new { grid_Value_year = object_sales.Sales_Man }).Distinct();
////foreach (var year in get_Year_linq)
////{                               
////            series.Add(new ColumnSeries { Title = year.grid_Value_year.ToString()});
////    var get_SoldApp_Linq = (from object_sales in salesBindingSource.DataSource as List<Sales>
////                            where get_Year_li
////}
//var get_Sales_linq_year = (from object_sales in salesBindingSource.DataSource as List<Sales>
//                      select new { grid_Value_year = object_sales.year }).Distinct();
//foreach (var item in get_Sales_linq_year)
//{
//    List<double> appsold = new List<double>();

//}
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
//foreach (var year_Sale in get_Sales_Linq)
//{
//double value = 0; //
//List<double> valuesList = new List<double>();
//salesBindingSource.DataSource = new List<Sales>();
//var data_year_Sold = (from salesManCollection in salesBindingSource.DataSource as List<Sales>
//                           where salesManCollection.year.Equals() && salesManCollection.Sales_Man.Equals(Sales_Man.DataGridView) && salesManCollection.Apps_Solds.Equals(Apps_Sold.DataGridView)
//                           orderby salesManCollection.year ascending
//                           select new
//                           {
//                               salesManCollection.year,
//                               salesManCollection.Apps_Solds
//                           });

//if (data_year_Sold.SingleOrDefault() != null)
//{
//    value = data_year_Sold.SingleOrDefault().Apps_Solds;
//    valuesList.Add(value);
//    series.Add(new ColumnSeries() { Title = year_Sale.grid_Value_Year.ToString(), Values = new ChartValues<double>(valuesList) });
//}
////}
//cartesianChart1.Series = series;
//cartesianChart1.Series = new SeriesCollection
//{
//    new ColumnSeries
//    {
//        Title = "2015",
//        Values = new ChartValues<double> { 10, 50, 39, 50 }
//    }
//};

////adding series will update and animate the chart automatically
//cartesianChart1.Series.Add(new ColumnSeries
//{
//    Title = "2016",
//    Values = new ChartValues<double> { 11, 56, 42 }
//});
//cartesianChart1.Series.Clear();
//SeriesCollection series = new SeriesCollection();

//var get_Sales_Linq = (from objectSales_Year in salesBindingSource.DataSource as List<Sales>
//                        select new
//                        {
//                            grid_Value_Year = objectSales_Year.year
//                        }).Distinct();

//salesBindingSource.DataSource = new List<Sales>();

//var sales_Man_Linq = (from salesManCollection in salesBindingSource.DataSource as List<Sales>
//                      where (salesManCollection.year.Equals(Year.DataGridView) && salesManCollection.Sales_Man.Equals(Sales_Man.DataGridView) && salesManCollection.Apps_Solds.Equals(Apps_Sold.DataGridView))
//                      select new
//                      {
//                          salesManCollection.Sales_Man
//                      });
////foreach (var year in sales_Man_Year_Linq)
////{
////    var sales_Man = (from collectionyear in salesBindingSource.DataSource as List<Sales>
////                     where collectionyear.year.Equals(year.grid_Value_Year) && collectionyear.Sales_Man.Equals())
////}
//string[] temp = new string[20];
////IList<string> List = new List<string>();
//int counter = 0;
//foreach (var item in sales_Man_Linq)
//{
//    temp[counter] = item.ToString();
//    counter++;
//}
//for (int i = 0; i < temp.Length; i++)
//{
//    richTextBox1.Text = temp[i].ToString();
//}