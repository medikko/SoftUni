﻿using System;

namespace P04_Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double inch = 2.54;
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * inch;
            Console.WriteLine($"{centimeters:f2}");
        }
    }
}
