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
            this.day = 0;
            this.myMonth = new Month();
            this.year = 0;
        }
        //overloaded constructor, assumes correct input checking has already been done
        public date(int day, int month, int year)
        {
            this.day = day;
            this.myMonth = new Month(month);
            this.year = year;
        }
        public static date operator ++(date value)
        {
            value.day++;
            if (value.day > value.myMonth.getNumDays())
            {
                value.day = 1;
                value.myMonth++;
            }
            return value;
        }
        public static date operator --(date value)
        {
            value.day--;
            if (value.day < 1)
            {
                value.myMonth--;
                value.day = value.myMonth.getNumDays();
            }
            return value;
        }
    }
}
