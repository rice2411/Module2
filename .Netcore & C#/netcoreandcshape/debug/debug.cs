﻿using System;

namespace dotnet_debug
{
    class debug
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Index = " + i);
            }
            Console.ReadKey();
        }
    }
}