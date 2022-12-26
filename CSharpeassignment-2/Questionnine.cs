using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveri.CSharpeassignment_2
{
    public class Questionnine
    {
        public static void M9()
        {
            int first=0;
            Console.WriteLine("enter the number");
            int number=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=number; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(first==1)
                    {
                        Console.Write("0");
                        first= 0;
                    }
                    else if(first==0)
                    {
                        Console.Write("1");
                        first= 1;
                    }

                    
                }
                Console.WriteLine('\n');
            }
        }
    }
}
