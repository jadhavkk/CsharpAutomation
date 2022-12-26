using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.CsharpAssig12
{
    public class EvenSum
    {
       public  static void EvenSum3()
        {

            int a;
            int sum = 0;
            for (a = 0; a <= 50; a++)

            {
                if (a % 2 == 0)
                {
                    sum = sum + a;

                  }
            }
            Console.WriteLine(sum);
            if(sum%2 == 0)
            {
                Console.WriteLine("the numuber is an even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }




        }











        }
    } 
