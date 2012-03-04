using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace datesProject
{
    class date
    {
        private int day;
        private Month myMonth;
        private int year;

        //default constructor, sets all data to 0 or null or invalid
        public date()
        {
            this.day = 1;
            this.myMonth = new Month();
            this.year = 0;
        }
        //overloaded constructor, if a month greater then 12 is given, sets month to 12, if a month less then 1 is given, sets month to 1
        // if a day less then 1 is given, day is set to 1... if a day less then month.GetNumDays is given, month.GetNumDays is set(aka last day of month)
        public date(int day, int month, int year)
        {
            if (month > 12)
            {
                this.myMonth = new Month(12);
            }
            else if (month < 1)
            {
                this.myMonth = new Month(1);
            }
            else
            {
                this.myMonth = new Month(month);
            }
            if (day > myMonth.getNumDays())
            {
                this.day = myMonth.getNumDays();
            }
            else if (day < 1)
            {
                this.day = 1;
            }
            else
            {
                this.day = day;
            }          
            this.year = year;
        }
        public void printDate()
        {
            Console.WriteLine(day + "-" + this.myMonth.getMonthNumber() + "-" + this.year);
        }
        public static date operator ++(date value)
        {
            value.day++;
            if (value.day > value.myMonth.getNumDays())
            {
                value.day = 1;
                if (value.myMonth.getMonthNumber() == 12)
                {
                    value.year++;
                }
                value.myMonth++;
            }
            return value;
        }
        public static date operator --(date value)
        {
            value.day--;
            if (value.day < 1)
            {
                if (value.myMonth.getMonthNumber() == 1)
                    value.year--;
                value.myMonth--;
                value.day = value.myMonth.getNumDays();
            }
            return value;
        }
    }
}
