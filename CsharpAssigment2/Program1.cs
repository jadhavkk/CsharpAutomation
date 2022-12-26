using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.CsharpAssigment2
{
     public class Program1
    {
        public static void P1()
        {
            int a;
            Console.WriteLine("Print even number from 0 to 30");
            a = 0;
            while (a<30)
            { 
                Console.WriteLine(a);
                a=a+2;
            }

            Console.WriteLine("Print odd umber from 0 to 30");
            a = 1;
            while (a < 30)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
        }
    }
}
