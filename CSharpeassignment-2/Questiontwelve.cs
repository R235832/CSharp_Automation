using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.CSharpeassignment_2
{
    public class Questiontwelve
    {
        public static void M12()
        {
            Console.WriteLine("Enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int third=Convert.ToInt32(Console.ReadLine());
            int total;
           for(int c=0;c<=2;c++)
            {
                if(second<first)
                {
                    total= first;
                    first= second;
                    second = total;


                }
                if (third < second)
                {
                    total = second;
                    second = third;
                    third = total;
                }
            }
            Console.WriteLine("The accending order is : "  + first + " " +second+ " " +third ); 
        }
    }
}
