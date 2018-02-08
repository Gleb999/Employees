using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee2
    {
        private string empName;
        private int empID;
        private float currPay;
        public string value;
        private int empAge;
        private string empSSN;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public string Name()
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than 16 Characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string GetName()
        {
            return empName;
        }

        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name must be less than 16 characters!");
                else{
                    empName = name;
                }
            }
        }
    }
}
