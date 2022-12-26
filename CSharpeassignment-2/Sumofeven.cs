using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace M.CSharpeassignment_2
{
    public class Sumofeven
    {

        public static void M2()
        {
            int j=0;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    j = j + i;      
                }     
            }
            Console.WriteLine("The sum of the even number from 0 to 50 is:" + j);
           if(j%2==0)
            {
                Console.WriteLine("The Result is Even");
            }
            else
            {
                Console.WriteLine("The Result is Odd");
            }
        }
    }
}
