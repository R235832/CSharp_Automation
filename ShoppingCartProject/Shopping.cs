using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Shopping
    {
        public int Fordetailsid;
        public string DescribeField;
        public int Quantity;
        public double Price;

        public void PrintItemDetails()
        {
            Console.WriteLine("Product Id is : " + Fordetailsid);
            Console.WriteLine("Product name : " + DescribeField);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Price of the product : " + Price);
            Console.WriteLine("-------------------------------------------");
        }
        public void discountedprice()
        {
            Console.WriteLine("Quantity is : " + Quantity);
            if(Quantity==2)
            {
                Console.WriteLine("The Final Price is : " + (Price - (Price * 10 / 100))*Quantity);
            }
            else if(Quantity>=3 || Quantity<5)
            {
                Console.WriteLine("The Final Price is : " + (Price - (Price * 15 / 100)) * Quantity);
            }
            else if(Quantity==5)
            {
                Console.WriteLine("The Final Price is : " + (Price - (Price * 25 / 100)) * Quantity);
            }
            Console.WriteLine("-------------------------------------------");
        }
        }
        }

    

