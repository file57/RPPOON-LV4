using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset file = new Dataset(@"E:\Projects\GitHub\RPPOON-LV4\RPPOON LV4\ZAD2\csv.csv");

            IAnalytics analytics = new Adapter(new Analyzer3rdParty());

            Console.WriteLine("ROW AVERAGE");
            foreach(double average in analytics.CalculateAveragePerRow(file))
            {
                Console.WriteLine(average);
            }
            Console.WriteLine("COLUMN AVERAGE");
            foreach (double average in analytics.CalculateAveragePerColumn(file))
            {
                Console.WriteLine(average);
            }
        }
    }
}
