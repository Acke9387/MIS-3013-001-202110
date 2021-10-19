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
            double totalSales2004 = 0;
            double totalSales2005 = 0;

            double[] monthTotals = new double[13]; // 12 months, but want index 12 to be in bounds so I made 13 the size

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
                int month = Convert.ToInt32(piecesOfLine[8]);
                
                if (status.ToLower() == "shipped")
                {
                    if (year == 2003)
                    {
                        totalSales2003 += sales;
                    }
                    else if (year == 2004)
                    {
                        totalSales2004 += sales;
                    }
                    else if (year == 2005)
                    {
                        totalSales2005 += sales;
                    }

                    monthTotals[month] += sales;

                    totalSales += sales;
                }

            }

            Console.WriteLine($"The total sales for all orders shipped is {totalSales.ToString("C")}");
            Console.WriteLine($"The total sales for all orders shipped in 2003 is {totalSales2003.ToString("C")}");
            Console.WriteLine($"The total sales for all orders shipped in 2004 is {totalSales2004.ToString("C")}");
            Console.WriteLine($"The total sales for all orders shipped in 2005 is {totalSales2005.ToString("C")}");

            for (int i = 1; i < monthTotals.Length; i++)
            {
                string month = ConvertMonthNumberToMonthName(i);
                Console.WriteLine($"The total sales for {month} is {monthTotals[i].ToString("C")}");
            }

        }
    
        /// <summary>
        /// Converts the month number (e.g. 1) to the month name (e.g. January)
        /// </summary>
        /// <param name="month">The integer value for the month</param>
        /// <returns>The name of the month</returns>
        static string ConvertMonthNumberToMonthName(int month)
        {
            string answer = "";

            switch (month)
            {
                case 1:
                    answer = "January";
                    break;
                case 2:
                    answer = "February";
                    break;
                case 3:
                    answer = "March";
                    break;
                case 4:
                    answer = "April";
                    break;
                case 5:
                    answer = "May";
                    break;
                case 6:
                    answer = "June";
                    break;
                case 7:
                    answer = "July";
                    break;
                case 8:
                    answer = "August";
                    break;
                case 9:
                    answer = "September";
                    break;
                case 10:
                    answer = "October";
                    break;
                case 11:
                    answer = "November";
                    break;
                case 12:
                    answer = "December";
                    break;
                default:
                    break;
            }

            return answer;
        }

    }
}
