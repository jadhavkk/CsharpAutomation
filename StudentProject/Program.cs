
using StudentManagmentProject;

namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********StudentPROJECT**************");
            Student.schoolName = "Global school";

            Student stud1 = new Student();
            Student stud2 = new Student();
            Student stud3 = new Student();
            Student stud4 = new Student();
            

            stud1.studRollNo = 1001;
            stud1.studName = "peter";
            stud1.studEmail = "peter@gmail.com";
             stud1.studRate = 45.2;
           // stud1.StudGrade = 'A';


            stud2.studRollNo = 1002;
            stud2.studName = "jack";
            stud2.studEmail = "jack@gmail.com";
            stud2.studRate = 85.2;
           // stud2.StudGrade = 'B';

            stud3.studRollNo = 1003;
            stud3.studName = "sandy";
            stud3.studEmail = "sandy50@gmail.com";
            stud3.studRate = 56.5;
           // stud3.StudGrade = 'D';


            Student.schoolName = "Global school";
            Student.schooldAdd = "Chennai";

            stud1.PrintStudentDetails();
            stud2.PrintStudentDetails();
            stud3.PrintStudentDetails();
            stud4.PrintStudentDetails();
            stud1.StudGrade();
            stud2.StudGrade();
            stud3.StudGrade();
            stud4.StudGrade();


           // Console.WriteLine(stud1.studRollNo);
           // Console.WriteLine(stud1.studName);
           // Console.WriteLine(stud1.studEmail);
           // Console.WriteLine(stud1.studRate);

           // Console.WriteLine(stud2.studRollNo);
           // Console.WriteLine(stud2.studName);
           // Console.WriteLine(stud2.studEmail);
           // Console.WriteLine(stud2.studRate);

           // Console.WriteLine(stud3.studRollNo);
           // Console.WriteLine(stud3.studName);
            //Console.WriteLine(stud3.studEmail);
           // Console.WriteLine(stud3.studRate);







        }
    }
}
        
   

