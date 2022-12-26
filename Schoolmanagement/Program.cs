using Schoolmanagement;

namespace Maceric.School
{
public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------STUDENT DATA--------------------------");
            Student.SchoolName = "Global School";
            Student.SchoolAdress = "Chennai";
            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student();
            std1.Studentid = 1001;
            std1.StudentName = "Jack";
            std1.StudentMailId = "jack@gmail.com";
            std1.StudentPercentage = 45.2;
          
            std2.Studentid = 1002;
            std2.StudentName = "Peter";
            std2.StudentMailId = "peter@gmail.com";
            std2.StudentPercentage = 85.2;
         
            std3.Studentid = 1003;
            std3.StudentName = "Mark";
            std3.StudentMailId = "mark@gmail.com";
            std3.StudentPercentage = 56.5;
            std1.PrintStudentDetails();
            std2.PrintStudentDetails();
            std3.PrintStudentDetails();
            std1.DisplayCertification();
            std2.DisplayCertification();
            std3.DisplayCertification();


        }
    }

}