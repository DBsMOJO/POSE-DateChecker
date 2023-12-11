/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 13.11.2023
 *--------------------------------------------------------------
 * Description:
 * Checks the date for accuracy
 *--------------------------------------------------------------
*/

using System;

namespace DataChecker
{
    public class Program
    {
        public static void Main()
        {
            int year,
                month,
                day,
                check;

            // Input
            Console.WriteLine("Please enter a date!");
            Console.Write("Year:  ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day:   ");
            day = Convert.ToInt32(Console.ReadLine());

            // Process
            if (month == 2)
            {
                day = (29 - ((2 + year % 4) % (1 + year % 4))) / day;
            }
            else
            {
                day = (30 + month % 2 + month / 8 - 2 * (month % 2) * (month / 8)) / day;
            }
            month = 1 - 1 * month / 12;
            check = day + month;

            // Output
            switch (check)
            {
                case 2:
                    Console.WriteLine("Date is okay!");
                    break;
                default:
                    Console.WriteLine("Date is not okay!");
                    break;
            }
        }
    }
}
