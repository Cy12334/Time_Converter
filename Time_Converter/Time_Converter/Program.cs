using System;

class Converter
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Time Converter!");
        Console.WriteLine("Enter a value to convert:");

        double value = Convert.ToDouble(Console.ReadLine());

        ConvertSecondsToMinutes(value);
        ConvertMinutesToHours(value);
        ConvertHoursToDays(value);
        ConvertDaysToMonths(value);

        Console.WriteLine("Convert time!");
    }

    static void ConvertSecondsToMinutes(double seconds)
    {
        double minutes = seconds / 60;
        Console.WriteLine(seconds + " seconds is equal to " + minutes + " minutes.");
    }

    static void ConvertMinutesToHours(double minutes)
    {
        double hours = minutes / 60;
        Console.WriteLine(minutes + " minutes is equal to " + hours + " hours.");
    }

    static void ConvertHoursToDays(double hours)
    {
        double days = hours / 24;
        Console.WriteLine(hours + " hours is equal to " + days + " days.");
    }

    static void ConvertDaysToMonths(double days)
    {
        double months = days / 30.42; // Approximate number of days in a month
        Console.WriteLine(days + " days is equal to approximately " + months + " months.");
    }
}