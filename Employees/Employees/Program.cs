﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("***** The Employee Hierarchy *****\n");

            Salesperson fred = new Salesperson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;*/

            Manager chucky = new Manager("Chucky", 50, 92, 1000000, "333-23-2322", 9000);
            Console.ReadLine();
        }
    }
}
