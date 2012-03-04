using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datesProject
{
    class Month
    {
        private string name;
        private int monthNumber;
        private int daysInMonth;

        //default constructor, sets name to January, month number to 1, and daysInMonth to 31
        public Month()
        {
            setMonth(1);
        }
        //overloaded constructor, sets name/monthnumber/daysinmonth correctly according to which month is given 1-12
        //if some other number is given it sets them the same as the default constructor
        public Month(int month)
        {
            setMonth(month);
        }
        public int getMonthNumber()
        {
            return monthNumber;
        }
        public int getNumDays()
        {
            return daysInMonth;
        }
        public void setMonth(int month)
        {
            switch (month)
            {
                case 1:
                    name = "January";
                    monthNumber = 1;
                    daysInMonth = 31;
                    break;
                case 2:
                    name = "February";
                    monthNumber = 2;
                    daysInMonth = 28;
                    break;
                case 3:
                    name = "March";
                    monthNumber = 3;
                    daysInMonth = 31;
                    break;
                case 4:
                    name = "April";
                    monthNumber = 4;
                    daysInMonth = 28;
                    break;
                case 5:
                    name = "May";
                    monthNumber = 5;
                    daysInMonth = 31;
                    break;
                case 6:
                    name = "June";
                    monthNumber = 6;
                    daysInMonth = 28;
                    break;
                case 7:
                    name = "July";
                    monthNumber = 7;
                    daysInMonth = 31;
                    break;
                case 8:
                    name = "August";
                    monthNumber = 8;
                    daysInMonth = 31;
                    break;
                case 9:
                    name = "September";
                    monthNumber = 9;
                    daysInMonth = 30;
                    break;
                case 10:
                    name = "October";
                    monthNumber = 10;
                    daysInMonth = 31;
                    break;
                case 11:
                    name = "November";
                    monthNumber = 11;
                    daysInMonth = 30;
                    break;
                case 12:
                    name = "December";
                    monthNumber = 12;
                    daysInMonth = 31;
                    break;
                default:
                    name = null;
                    monthNumber = 0;
                    daysInMonth = 0;
                    break;
            }
        }
        public static Month operator ++(Month value)
        {
            value.monthNumber = value.monthNumber + 1;
            if (value.monthNumber == 13)
            {
                value.monthNumber = 1;
                value.name = "January";
            }
            else
            {
                value.setMonth(value.monthNumber);
            }
            return value;
        }
        public static Month operator --(Month value)
        {
            value.monthNumber = value.monthNumber - 1;
            if (value.monthNumber == 0)
            {
                value.monthNumber = 12;
                value.name = "December";
            }
            else
            {
                value.setMonth(value.monthNumber);
            }
            return value;
        }
    }
}
