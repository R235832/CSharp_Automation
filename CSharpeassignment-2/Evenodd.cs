using CSharpeassignment_2;
using M.CSharpeassignment_2;
using Ma.CSharpeassignment_2;
using Mav.CSharpeassignment_2;
using Maveri.CSharpeassignment_2;
using Maverr.CSharpeassignment_2;
using Mq.CSharpeassignment_2;
using Mr.CSharpeassignment_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.CSharpeassignment
{
    public class Evenodd
    {
        static void Main(string[] args)
        {
            
            for (int i=0;i<=30;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i + "is an even number");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }
            Sequence.M1();
            Sumofeven.M2();
            Multiplicationfive.M3();
            Questionten.M10();
            Calculate.M4();
            Questiontwelve.M12();
            Questionnine.M9();
            Questionfifteen.M15();
        }
    }
}
