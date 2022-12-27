using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        public void ShopCart1() { }
        public int ID;
        public string descr;
        public int quantity;
        public double price;


        public void DiscountDetails()
        {
            if (quantity == 2 )
            {

                double d = (price - (price * 10 / 100)) * quantity;
                Console.WriteLine("Final price : " + d);
            }
            else if(quantity>=3 && quantity < 5){
                double d = (price - (price * 15 / 100)) * quantity;
                Console.WriteLine("Final price : "  +d);
            }
            else if(quantity == 5)
            {
                double d = (price - (price * 25 / 100)) * quantity;
                Console.WriteLine("Final price : " + d);
            }
        }

        public void PrintShoppCartDetails()
        {
            Console.WriteLine("Id:"+ID);
            Console.WriteLine("descr:" + descr);
            Console.WriteLine("quantity:" + quantity);
            Console.WriteLine("price:" + price);

        }
    }
}
