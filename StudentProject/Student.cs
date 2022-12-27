using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentProject
{
    public class Student
    {
        public static void Stud1() { }

        public int studRollNo;
        public string studName;
        public string studEmail;
         public double studRate;
        public char studGrade;
        public static string schoolName;
        public static string schooldAdd;


        public void StudGrade()

        {
        

                if (studRate >= 90)
                {
                    //write
                    
                    Console.WriteLine("Hi" +studName+ "! You Have passed With Grade A");
                }
                else if (studRate >= 80 && studRate <= 89)

                {
                    Console.WriteLine("Hi" + studName + "! You Have passed With Grade B");
                }
                else if(studRate>=60 && studRate <= 79)
                {
                    Console.WriteLine("Hi" + studName + "! You Have passed With Grade C");
                }
                else if(studRate<=60)
                {
                    Console.WriteLine("Hi" + studName + "! You Have passed With Grade F");
                    
                }
               else {
                Console.WriteLine("Hi Peter You Have successfully passed with Grade 'A':");

            } 



            }
        

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student RollNo: " + studRollNo);
            Console.WriteLine("Student Name:" + studName);
            Console.WriteLine("StudentEmail:" + studEmail);
           // Console.WriteLine("StudentRate:" + studRate);
            Console.WriteLine("School Name:"+Student.schoolName);
            Console.WriteLine("SchoolAdd:" + Student.schooldAdd);
            Console.WriteLine("===========================================================");

        }
    }
 }


