using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.ReverseAssig
{
    public class ReversePrgm
    {
        public static void Main(String[] args)
        {

         
            string originalString ="this is Program";
            string reverseString = " ";
             for (int i = originalString.Length - 1; i > 0; i--)
           
              { reverseString += originalString[i];}
              Console.Write("Program is this");
           




            

        }
    }
}
