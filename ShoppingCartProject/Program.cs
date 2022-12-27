
using ShoppingCartProject;
using System.Security.Cryptography.X509Certificates;

namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {

            ShoppingCart sc1 = new ShoppingCart();
            ShoppingCart sc2 = new ShoppingCart();

            sc1.ID = 101;
            sc1.descr = "Laptop";
            sc1.quantity =5;
            sc1.price = 45000.00;

            sc2.ID = 102;
            sc2.descr ="Mobile";
            sc2.quantity =3;
            sc2.price =25000.00;

            sc1.PrintShoppCartDetails();
            sc2.PrintShoppCartDetails();
            sc1.DiscountDetails();
            sc2.DiscountDetails();







        }

    
    }
}
