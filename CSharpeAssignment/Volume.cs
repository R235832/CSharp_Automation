using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Formula
{
    public class Volume
    {
        public static double VolumeOfSphere(double radius)
        {
            return (4.0 / 3.0 * 3.14 * radius * radius);
        }
        public static double VolumeOfACylinder(double height,double radius)
        {
            return (3.14 * radius * radius * height);
        }
        public static double VolumeOfAPyramid(double lenghth,double width,double height)
        {
            return ((lenghth * width * height)/3);
        }
        public static double VolumeOfCone(double radius,double height)
        {
            return ((3.14 * radius * radius * height) / 3);
        }
        public  double VolumeOfCuboid(double length,double width,double height)
        {
            return (length * width * height);
        }
        public static double VolumeOfHemisphere(double radius)
        {
            return (2.0/3*3.14*radius*radius*radius);
        }
        public static string GetAuthorName()
        {
            return "Rakesh Rout";
        }
    }
}
