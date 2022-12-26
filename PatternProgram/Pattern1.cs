using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.PatternProgram
{
    public class Pattern1
    {
        public static void Main(String[] args)
        {
            int a = 5;
            int b = 4;
            //Console.WriteLine("Print the rows");
           // Console.WriteLine("Print the columns");
            //int a, b, rows, columns;
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

