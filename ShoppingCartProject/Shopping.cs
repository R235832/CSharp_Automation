using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Shopping
    {
        public int fordetailsid;
        public string describeField;
        private int _quantity;
        public double price;
        //public Shopping()
        //{
        //    _quantity = 1;
        //    Console.WriteLine("Object Created");
        //}
        public Shopping(int _quantity)
        {
           this._quantity =_quantity;
        }
        public int Quantity
        {
            set
            {
                if(value>0)
                {
                    _quantity = value ;
                }
                else
                {
                    Console.WriteLine("NOT VALID");
                }
            }
        }

        public void PrintItemDetails()
        {
            Console.WriteLine("Product Id is : " + fordetailsid);
            Console.WriteLine("Product name : " + describeField);
            Console.WriteLine("Quantity : " + _quantity);
            Console.WriteLine("Price of the product : " + price);
            Console.WriteLine("-------------------------------------------");
        }
        public void discountedprice()
        {
            Console.WriteLine("Quantity is : " + _quantity);
            if(_quantity==2)
            {
                Console.WriteLine("The Final Price is : " + (price - (price * 10 / 100.0))*_quantity);
            }
            else if(_quantity>=3 || _quantity<=5)
            {
                Console.WriteLine("The Final Price is : " + (price - (price * 15 / 100.0)) * _quantity);
            }
            else if(_quantity>5)
            {
                Console.WriteLine("The Final Price is : " + (price - (price * 25 / 100.0)) * _quantity);
            }
            else
            {
                Console.WriteLine("No Discount");
            }
            Console.WriteLine("-------------------------------------------");
        }
        }
        }

    

