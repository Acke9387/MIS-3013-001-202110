using System;
using System.IO;

namespace Processing_A_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesOfFile = File.ReadAllLines("sales_data_sample.csv");
            double totalSales = 0;
            double totalSales2003 = 0;

            for (int i = 1; i < linesOfFile.Length; i++)
            {
                string line = linesOfFile[i];

                //     0             1           2            3           4      5         6      7       8       9         10      11     12         13  
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
                //10107,30,95.7,2,2871,2 / 24 / 2003 0:00,Shipped,1,2,2003,Motorcycles,95,S10_1678,Land of Toys Inc.,2125557818,897 Long Airport Avenue,,NYC,NY,10022,USA,NA,Yu,Kwai,Small

                string[] piecesOfLine = line.Split(',');
                //pieces[0]  : "10107"
                //pieces[1]  : "30"
                //pieces[2]  : "95.7"
                //pieces[3]  : "2"
                //pieces[4]  : "2871"
                //pieces[5]  : "2"

                string status = piecesOfLine[6];
                double sales = Convert.ToDouble(piecesOfLine[4]);
                int year = Convert.ToInt32(piecesOfLine[9]);

                if (status.ToLower() == "shipped")
                {
                    if (year == 2003)
                    {
                        totalSales2003 += sales;
                    }

                    totalSales += sales;
                }

            }

            Console.WriteLine($"The total sales for all orders shipped is {totalSales.ToString("C")}");
            Console.WriteLine($"The total sales for all orders shipped in 2003 is {totalSales2003.ToString("C")}");
        }
    }
}
