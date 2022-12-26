using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverr.CSharpeassignment_2
{
    public class Questionten
    {
        public static void M10()
        {
            Console.WriteLine("Enter the lenght");
            int length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width");
            int width=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=width;i++)
            {
                for (int j = 1; j <=length; j++)
                {
                    if(i==1 || i==width || j==1 ||j==length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("  ");
                    }  

                }
                Console.WriteLine('\n');
                   
             
                
            }

        }
    }
}
