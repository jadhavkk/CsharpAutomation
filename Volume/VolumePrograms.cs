using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Math.CsharpAssigment
{//
    public  class VolumePrograms
    {
        static void Main(String[] args) {

            
        }
        public static double VolumeOfSphere(double r)
        {
            double res= (4 * 3.14 * r * r * r)/ 3;
            return res;
        }
        
        public static double VolumeOfCylinder(double r,double height)
        {
            double res = (3.14 * r * r * height);
            return res;
                

        }
        public static double VolumeOfPyramid(int l,double w,double h)
        {
            double res = (l* w* h)/ 3;
            return res;


              }

           public static double VolumeOfCone(int r,double h)
              {
            double res=(3.14*r*r*h)/ 3;
            return r;
               }


            public static double VolumeOfCuboid(double w,double h,int l)
                {
            double res = (w* h * l) / 3;
            return res;

        }

            public static double VolumeOfHemisphere(double r)
        {
            double res = (2 * 3.14 * r * r * r) / 3;
            return res;

        }
        public static double AreaOfRectangle(double w,int l)
        {
            double res = w * l;
            return res;

        }
        public static void GetAuthorName()
        {
            string authorName = Volume.GetAuthorName();
            Console.WriteLine(authorName);
        }

           
    }
}
