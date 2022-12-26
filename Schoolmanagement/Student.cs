using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolmanagement
{
    public class Student
    {
        public static string SchoolName;
        public static string SchoolAdress;
        public int Studentid;
        public string StudentName;
        public string StudentMailId;
        public double StudentPercentage;
      
        public void PrintStudentDetails()
        {
            Console.WriteLine("The name of the school is : " + Student.SchoolName);
            Console.WriteLine("The school address is : " + Student.SchoolAdress);
            Console.WriteLine("The student id is :" + Studentid);
            Console.WriteLine("The student name is : " + StudentName);
            Console.WriteLine("The Email id Of the Student is : " + StudentMailId);
            Console.WriteLine("The percentage of the student is : " + StudentPercentage);
            Console.WriteLine("----------------------------------------------------------");

        }
        public void DisplayCertification()
        {
            Console.WriteLine("Stdent percentage is: " + StudentPercentage);
            if (StudentPercentage > 90)
            {
                Console.WriteLine("Hi  "   +   StudentName + "!  You have successfully passed with grade A  ");
            }
            else if (StudentPercentage >= 80 && StudentPercentage < 90)
            {
                Console.WriteLine("Hi  "   +   StudentName + " !  You have successfully passed with grade A ");
            }
            else if (StudentPercentage >= 60 && StudentPercentage < 80)
            {
                Console.WriteLine("Hi  "   +   StudentName  + " !  You have successfully passed with grade C");

            }
            else if (StudentPercentage < 60)
            {
                Console.WriteLine("Hi  "    +   StudentName + "!  You have successfully passed with grade C");
            }

            
        }
    }
}
