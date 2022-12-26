using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ma.CSharpeassignment_2
{
    public class Multiplicationfive
    {
        public static void M3()
        {

            int evencount=0,oddcount=0;
            for (int i = 1; i <= 30; i++)
            {


                if ((5 * i) % 2 == 0)
                {
                    Console.WriteLine("The number is Even :" + 5 * i);
                    evencount++;
                
                }
                else
                {
                    Console.WriteLine("The number is Odd:" + 5 * i);
                    oddcount++;
                    
                }

            }
            Console.WriteLine("Total Even number is:" + evencount);
            Console.WriteLine("Total Odd Number is :" + oddcount);
        }
    }
}      
        
    
        
         
     

