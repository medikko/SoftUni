﻿using System;

namespace P02_Common_Elements
{
    internal class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();


            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                     if (secondArray[i] == firstArray[j])
                        {
                        Console.Write($"{firstArray[j]} ");
                        break;
                        }   
            }
        }
    }
}
