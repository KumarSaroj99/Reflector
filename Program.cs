﻿using System.Reflection;
using POConReflection.Models;

namespace POConReflection
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            
            Console.WriteLine(reflector.ShowDetails(typeof(Account)));
            Console.WriteLine(reflector.ShowDetails(typeof(Customer)));

        }
        
    }
}
