using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        public void ShopCart1() { }
        public int ID;
        public string descr;
        private int _quantity;
        public double price;

        public void Program() {
           _quantity = 3;
           Console.WriteLine("Object Created");

             }
        public ShoppingCart(int _quantity)
        {
            this._quantity = _quantity;
        }
        


        public int Quantity
        {
            set
            {
                if (value > 0)
                {
                    this._quantity = _quantity;
                    

                }

                else
                {

                    Console.WriteLine("Quantity cannot be negative");
                }
            }
        }

                 public static ShoppingCart CreateInstance(int quantity)
                    {
            ShoppingCart sc = new ShoppingCart(quantity);
            return sc;

                    }

                public void DiscountDetails()
        {
            if (_quantity == 2)
            {

                double d = (price - (price * 10 / 100)) * _quantity;
                Console.WriteLine("Final price : " + d);
            }
            else if (_quantity >= 3 && _quantity < 5)
            {
                double d = (price - (price * 15 / 100)) * _quantity;
                Console.WriteLine("Final price : " + d);
            }
            else if (_quantity == 5)
            {
                double d = (price - (price * 25 / 100)) * _quantity;
                Console.WriteLine("Final price : " + d);
            }
            else
            {
                Console.WriteLine("No discount");
            } }



        public void PrintShoppCartDetails()
        {
            Console.WriteLine("Id:" + ID);
            Console.WriteLine("descr:" + descr);
            Console.WriteLine("quantity:" + _quantity);
            Console.WriteLine("price:" + price);

        }

    } }
             
     
        
