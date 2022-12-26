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
       private double _emplsalary;
        public char emplyoeePerformanceType;
        public static string companyname;
        public static string companylocation;
        public double Emplsalary
        {
            get
            {
                return _emplsalary;
            }
            set
            {
                if(value>3000)
                {
                    _emplsalary = value;
                }
                else
                {
                    Console.WriteLine("INVALID  SALARY SO default value remains!!!!!!");
                }
            }
        }
        public void PrintEmoployeedetails()
        {
            Console.WriteLine("Emplyee id is:" + emplid);
            Console.WriteLine("Employee name is :" + emplname);
            Console.WriteLine("Employee salary is :" + _emplsalary);
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
                Console.WriteLine(_emplsalary + (_emplsalary * 20 / 100.0));
            }
            else if(emplyoeePerformanceType=='B')
            {
                Console.WriteLine(_emplsalary + (_emplsalary * 15 / 100.0));
            }
            else if(emplyoeePerformanceType=='C')
            {
                Console.WriteLine(_emplsalary + (_emplsalary * 10 / 100.0));
            }
            else
            {
                Console.WriteLine("NOT ELIGIBLE FOR BONUS");
            }
            Console.WriteLine("------------------------------------------");
           
        }
    }
}
