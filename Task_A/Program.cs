using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date DateEn = new Date(14, 6, 2021);

            var DayOfWeek = DateEn.GetDayOfWeek();
            var DayInMonth = DateEn.Month_.getDays(Date.Month.Month_, DateEn.Year_.isLeap);
            var NextMonth = Date.valueOf(DayInMonth);
            var Between = DateEn.daysBetween();
            var DayOfTheYear = DateEn.getDayOfYear();
            Console.WriteLine();
            Console.WriteLine($"\tDate entered: {DateEn}\n\tDay of week: {DayOfWeek}" + $"\n\tNumber of days in a month: {DayInMonth}\n\tDay of the week next month: {NextMonth}" +
                $"\n\tThe number of days between the current date and the entered date: {Between}" + $"\n\tDay of the year: {DayOfTheYear}");

        }
    }
}