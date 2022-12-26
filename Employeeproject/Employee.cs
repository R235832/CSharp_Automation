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
        public char emplyoeePerformanceType;
        public static string companyname;
        public static string companylocation;
        public void PrintEmoployeedetails()
        {
            Console.WriteLine("Emplyee id is:" + emplid);
            Console.WriteLine("Employee name is :" + emplname);
            Console.WriteLine("Employee salary is :" + emplsalary);
            Console.WriteLine("Employee performance is :" + emplyoeePerformanceType);
            Console.WriteLine("Company Name is :" + Employee.companyname);
            Console.WriteLine("Company Location is :" + Employee.companylocation);
            Console.WriteLine("--------------------------------------------------");


        }
        public void GetSalarywithBonus()
        {
            Console.WriteLine("Employee id :" + emplid);
            if(emplyoeePerformanceType=='A')
            {
                Console.WriteLine(emplsalary + (emplsalary * 20 / 100.0));
            }
            else if(emplyoeePerformanceType=='B')
            {
                Console.WriteLine(emplsalary + (emplsalary * 15 / 100.0));
            }
            else if(emplyoeePerformanceType=='C')
            {
                Console.WriteLine(emplsalary + (emplsalary * 10 / 100.0));
            }
            else
            {
                Console.WriteLine("NOT ELIGIBLE FOR BONUS");
            }
            Console.WriteLine("------------------------------------------");
           
        }
    }
}
