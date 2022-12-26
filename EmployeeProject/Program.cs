
using EmployeeProject;

namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********EmployeePROJECT**************");
            EmployeeP.companyName = "Maveric";
            

            EmployeeP emp1 = new EmployeeP();
            EmployeeP emp2 = new EmployeeP();
            EmployeeP emp3 = new EmployeeP();
            EmployeeP emp4 = new EmployeeP();

            emp1.empId = 101;
            emp1.empName = "Saul";
            emp1.empSalary = 145500;


            emp2.empId = 102;
            emp2.empName = "PAul";
            emp2.empSalary = 17857.00;



            emp3.empId = 103;
            emp3.empName = "ATul";
            emp2.empSalary = 1856.00;

            EmployeeP.companyName = "Maveric Company";
            EmployeeP.companyLocation = " Pune";

            emp1.PrintEmployeeDetails();
            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();
            emp4.PrintEmployeeDetails();


            Console.WriteLine(emp1.empId);
            Console.WriteLine(emp1.empName);
            Console.WriteLine(emp1.empSalary);

            Console.WriteLine(emp2.empId);
            Console.WriteLine(emp2.empName);
            Console.WriteLine(emp2.empSalary);

            Console.WriteLine(emp3.empId);
            Console.WriteLine(emp3.empName);
            Console.WriteLine(emp1.empSalary);
           
        }
    }
}
                
