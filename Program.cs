using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace datesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            date myDate = new date(5, 12, 2015);
            for (int i = 0; i < 50; i++)
            {
                myDate++;
                myDate.printDate();
            }
            for (int i = 0; i < 50; i++)
            {
                myDate--;
                myDate.printDate();
            }
            Console.ReadLine();
        }
    }
}
