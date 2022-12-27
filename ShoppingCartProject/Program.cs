using ShoppingCartProject;

namespace Maveric.Shoppingcart
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------SHOPPING CART DETAILS-----------------------------");
            Shopping shp1= new Shopping(2);
            Shopping shp2= new Shopping(4);
            Shopping shp3= new Shopping(4);
            shp1.fordetailsid = 100;
            shp1.describeField = "Laptop";
            shp1.price = 40000;
            shp1.Quantity = 3;
            shp2.fordetailsid = 101;
            shp2.describeField = "Mobile";
            shp2.price = 28500.50;
            shp2.Quantity = 2;
            shp3.fordetailsid = 103;
            shp3.describeField = "TV";
            shp3.price = 24000.80;
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