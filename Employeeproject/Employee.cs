using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeproject
{
    public class Employee
    {
        public int emplid;
        public string emplname;
        public double emplsalary;
        public static string companyname;
        public static string companylocation;
        public void PrintEmoployeedetails()
        {
            Console.WriteLine("Emplyee id is:" + emplid);
            Console.WriteLine("Employee name is :" + emplname);
            Console.WriteLine("Employee salary is :" + emplsalary);
            Console.WriteLine("Company Name is :" + Employee.companyname);
            Console.WriteLine("Company Location is :" + Employee.companylocation);
            Console.WriteLine("--------------------------------------------------");

        }
    }
}
