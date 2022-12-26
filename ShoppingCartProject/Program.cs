using ShoppingCartProject;

namespace Maveric.Shoppingcart
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------SHOPPING CART DETAILS-----------------------------");
            Shopping shp1= new Shopping();
            Shopping shp2= new Shopping();
            Shopping shp3= new Shopping();
            shp1.Fordetailsid = 100;
            shp1.DescribeField = "Laptop";
            shp1.Price = 40000;
            shp1.Quantity = 3;
            shp2.Fordetailsid = 101;
            shp2.DescribeField = "Mobile";
            shp2.Price = 28500.50;
            shp2.Quantity = 2;
            shp3.Fordetailsid = 103;
            shp3.DescribeField = "TV";
            shp3.Price = 24000.80;
            shp3.Quantity = 5;
            shp1.PrintItemDetails();
            shp2.PrintItemDetails();
            shp3.PrintItemDetails();
            shp1.discountedprice();
            shp2.discountedprice();
            shp3.discountedprice();

        }
    }
}