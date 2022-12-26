using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class EmployeeP
    {
        public static void Emp1() { }

        public int empId;//non-static  var or instance var
        public string empName;
        private double _empSalary;
        public char empPerformanceType;
        public static string companyName;//static var or class var 
        public static string companyLocation;

        public double EmpSalary
        {
            get { 
                //read
                return _empSalary; }
            set
            {
                if (value > 3000)
                {  
                    //write
                    _empSalary = value;
                }
                else {
                    Console.WriteLine("Invalid Salary.So default value remains");

                }
                

               
            
        }
    }


        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name:" + empName);
        Console.WriteLine("Employee Salary:" + _empSalary);
        
        Console.WriteLine("Employee PerformanceType:" + empPerformanceType);
            Console.WriteLine("Company Name:" + EmployeeP.companyName);
            Console.WriteLine("Company Location" + EmployeeP.companyLocation);
            Console.WriteLine("==============================================");
        }
        //CalculateBonus
        public void GetGrossSalaryWithBonus()
        {
            Console.WriteLine("Employee Id:" + empId);
            //non static Methods
            if (empPerformanceType == 'x')
            {
                Console.WriteLine("20%");
                Console.WriteLine(_empSalary + (_empSalary * 20 / 100));
            }
            else if (empPerformanceType == 'd')
            {
                Console.WriteLine("15%");
                Console.WriteLine(_empSalary + (_empSalary * 15 / 100));

            }
            else if (empPerformanceType == 'p')
            {
                Console.WriteLine("10%");
                Console.WriteLine(_empSalary + (_empSalary * 10 / 100));
               
            }
            else
            {
                Console.WriteLine("Not ELigible for Bonus");
            }
            Console.WriteLine("=================================================");

        }
       

    }
}
