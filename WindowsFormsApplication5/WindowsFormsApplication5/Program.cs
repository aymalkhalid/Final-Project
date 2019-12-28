using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start_Data_Visualization());
            Revenue[] RevenueArray = {
            new Revenue() { Year= 2019, Income =1000 , Month =1},
            new Revenue() { Year= 2019, Income =1050 , Month =2},
            new Revenue() { Year= 2019, Income =1100 , Month =3},
            new Revenue() { Year= 2019, Income =1000 , Month =4},
            new Revenue() { Year= 2019, Income =1050 , Month =5},
            new Revenue() { Year= 2018, Income =1100 , Month =1},
            new Revenue() { Year= 2018, Income =1200 , Month =2},
            new Revenue() { Year= 2018, Income =1500 , Month =3},
            new Revenue() { Year= 2018, Income =1250 , Month =4},
            new Revenue() { Year= 2018, Income =1300 , Month =5},
            new Revenue() { Year= 2017, Income =1200 , Month =1},
            new Revenue() { Year= 2017, Income =1400 , Month =2},
            new Revenue() { Year= 2017, Income =1500 , Month =3},
            new Revenue() { Year= 2017, Income =1600 , Month =4},
            new Revenue() { Year= 2017, Income =1450 , Month =5},
        };
        }
    }
}
