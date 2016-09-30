﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "shreekesh";
            string result = str.ChangeTheCaseOfFirstLetter();
            Console.WriteLine(result);

            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);
            foreach (var evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
            }
        }
    }
}
