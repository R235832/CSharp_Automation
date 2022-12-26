using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mq.CSharpeassignment_2
{
    public class Questionfifteen
    {
        public static void M15()
        {
            Console.WriteLine("Enter the number");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<number; i++)
            {
                if (number % i == 0)
                {

                    if (i % 1 == 0 || i % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
        }
    }
}
