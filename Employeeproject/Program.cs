
using Employeeproject;

namespace Maveric.Runner
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********EMPLOYEE DASHBOARD********");
            Employee.companyname = "Maveric";
            Employee.companylocation = "Pune";
            Employee emp1=new Employee();
            Employee emp2=new Employee();
            Employee emp3=new Employee();
            Employee emp4=new Employee();
            emp1.emplid = 101;
            emp1.emplname = "Rakesh Rout";
            emp1.emplsalary = 20000;
            emp1.emplyoeePerformanceType = 'A';
            emp2.emplid = 102;
            emp2.emplname = "Raghav kim";
            emp2.emplsalary = 18000.8;
            emp2.emplyoeePerformanceType = 'B';
            emp3.emplid = 103;
            emp3.emplname = "Rishwa jack";
            emp3.emplsalary = 1200.3;
            emp3.emplyoeePerformanceType = 'C';
            emp2.PrintEmoployeedetails();
            emp1.PrintEmoployeedetails();
            emp3.PrintEmoployeedetails();
            emp4.PrintEmoployeedetails();
            emp1.GetSalarywithBonus();
            emp2.GetSalarywithBonus();
            emp3.GetSalarywithBonus();
            emp4.GetSalarywithBonus();

        // Console.WriteLine( emp1.emplid);
          //  Console.WriteLine(emp1.emplname);
            //Console.WriteLine(emp1.emplsalary);
            //Console.WriteLine(Employee.companyname);
          //  Console.WriteLine(Employee.companylocation);
            //Console.WriteLine(emp2.emplid);
            //Console.WriteLine(emp2.emplname);
            //Console.WriteLine(emp2.emplsalary);
            //Console.WriteLine(Employee.companyname);
            //Console.WriteLine(Employee.companylocation);
            //Console.WriteLine(emp3.emplid);
            //Console.WriteLine(emp3.emplname);
            //Console.WriteLine(emp3.emplsalary);
            //Console.WriteLine(Employee.companyname);
         //   Console.WriteLine(Employee.companylocation);


        }
    }
}
