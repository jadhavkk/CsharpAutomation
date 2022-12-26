using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class EmployeeP
    {
        public static void Emp1() { }

        public int empId;//non-s  var or instance var
        public string empName;
        public double empSalary;
        public static string companyName;//static var or class var 
        public static string companyLocation;
        


        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + empSalary);
            Console.WriteLine("Company Name:" + EmployeeP.companyName);
            Console.WriteLine("Company Location" + EmployeeP.companyLocation);
        }
    }
}
