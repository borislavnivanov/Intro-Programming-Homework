//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("What year were you born?");
        int Age = int.Parse(Console.ReadLine());
        int NowDate = DateTime.Now.Year;
        int NowAge = NowDate - Age;
        Console.WriteLine("Now you are {0} years old.", NowAge);
        Console.WriteLine("After 10 years you will be: {0}.", NowAge + 10);
    }
}

