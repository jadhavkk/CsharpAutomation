using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssig12
{
    public class Table05
    {
        public static void Table5()

        {
            int num = 5, Count = 0;
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num);
                Count++;
            }
        }

    }
}
