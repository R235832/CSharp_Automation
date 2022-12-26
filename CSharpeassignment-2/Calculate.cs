using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mav.CSharpeassignment_2
{
    public class Calculate
    {
        public static void M4()
        {
            int j = 0;
            Console.WriteLine("Enter the value of n");
            int n= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    j = j + i;
                }
            }
            Console.WriteLine("The sum of the ODD number from 1 to  " + n +": "  + j);
            
        }

    }
}
