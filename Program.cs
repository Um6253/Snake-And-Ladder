﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnm = new Random();
            int random = rnm.Next(6);
            Console.WriteLine(random);
            Console.ReadLine();


        }
    }
}