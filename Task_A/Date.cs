using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Date
    {
        //Перечисление 
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public Day Day_ { get; }
        public Month Month_ { get; }
        public Year Year_ { get; }

        public Date(int day, int month, int year)
        {
            Day_ = new Day(day);
            Month_ = new Month(month);
            Year_ = new Year(year);
        }

        //День недели по заданному числу 
        public DayOfWeek GetDayOfWeek() => new DateTime(Year.Year_, Month.Month_, Day.Day_).DayOfWeek;  
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //День года по заданному числу
        public int getDayOfYear() => new DateTime(Year.Year_, Month.Month_, Day.Day_).DayOfYear;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Метод вычисления количество дней, в заданном временном промежутке
        public int daysBetween() 
        {
            DateTime EndDate = new DateTime(Year.Year_, Month.Month_, Day.Day_);
            DateTime StartDate = DateTime.Now;
            return Math.Abs((EndDate - StartDate).Days);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Вложенный класс
        public class Day
        {
            public static int Day_ { get; set; }
            public Day(int day)
            {
                if (day >= 1 && day <= 31) 
                    Day_ = day;
                else 
                    throw new ArgumentException();
            }
            public override string ToString() => Day_.ToString();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Вложенный класс
        public class Month
        {
            public static int Month_ { get; set; }
            public Month(int month)
            {
                if (month >= 1 && month <= 12) 
                    Month_ = month;
                else 
                    throw new ArgumentException();
            }
            public int getDays(int monthNumber, bool leapYear)
            {
                if (leapYear && Month_ == 2) 
                    return 29;
                return (int)(28.0 + (Month_ + Math.Floor(Month_ / 8.0)) % 2 + 2 % Month_ + 2 * Math.Floor(1.0 / Month_));
            } 
            public override string ToString() => Month_.ToString();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Вложенный класс
        public class Year
        {
            public bool isLeap;
            public static int Year_ { get; set; }
            public Year(int year)
            {
                if (year >= 1 && year <= 9999) 
                    Year_ = year;
                else
                    throw new ArgumentException();
                if (year % 4 == 0)
                    isLeap = true;
                else
                    isLeap = false;
            }
            public override string ToString() => Year_.ToString();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //День недели через месяц
        public static DayOfWeek valueOf(int index) =>
            (DayOfWeek)((int)(DateTime.Now.DayOfWeek + index) % 7); // День недели через месяц
        //Переопределение метода
        public override bool Equals(object obj)
        {
            Date other = obj as Date;
            return other != null ? other.Year_.Equals(Year_) && other.Month_.Equals(Month_) && other.Day_.Equals(Day_) : false;
        }
        public override string ToString() => $"{Day_}.{Month_}.{Year_}";
    }
}