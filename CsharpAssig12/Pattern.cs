using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.PatternProgram
{
    public class Pattern
    {
        public static void Pattern1()
        {
            int a = 5;
            int b = 4;
            
            for (int i= 0; i <=a; i++)

            {

                for (int j = 0; j <=b; j++)

                {
                    if (i == 0 || i == a || j == 0 || j == b)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine('\n');
            }

        }
    }
}

