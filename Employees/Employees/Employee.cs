using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        
        public Employee() { }
        public Employee(string name, int id, float pay)
            :this( name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
            empSSN = ssn;
        }
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
