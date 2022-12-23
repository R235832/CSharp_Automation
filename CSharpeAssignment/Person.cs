using Math.Formula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.CSharpeAssignment
{
    public class Person
    {
        static void Main(String[] args)
        {
            int smith = 25;
            int John = 45;
            int henry = 65;
            if (smith > John || smith > henry)
            {
                if (John > henry)
                {
                    Console.WriteLine("henry is younger");
                }
                else
                {
                    Console.WriteLine("john is younger");
                }
            }
            else
            {
                Console.WriteLine("smith is younger");

            }
            if(smith==John&&John==henry)
            {
                Console.WriteLine("Smith, John, henry are same age" + John);
            }
            Volume vol = new Volume();
            double d= Volume.VolumeOfSphere(15.5);
            Console.WriteLine(d);
            double d1 = Volume.VolumeOfACylinder(65.2, 15.5);
            Console.WriteLine(d1);
            double d2 = Volume.VolumeOfAPyramid(20, 20.5, 65.2);
            Console.WriteLine(d2);
            double d3 = Volume.VolumeOfCone(15.5, 65.2);
            Console.WriteLine(d3);
            double d4 = vol.VolumeOfCuboid(20, 20.5, 65.2);
            Console.WriteLine(d4);
            String[] rak = new string[3];
                rak[0] = "RED";
            rak[1] = "GREEN";
            rak[2] = "YELLOW";
            Console.WriteLine(rak[2]);
            Console.WriteLine(rak[1]);
            Console.WriteLine(rak[0]);
            Volume.GetAuthorName();

        }


    }
}

