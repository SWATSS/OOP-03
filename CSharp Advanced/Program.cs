using CSharp_Advanced.Classes;
using CSharp_Advanced.Enums;

namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Design and implement a Class for the employees in a company:
            //Employees emp = new Employees(
            //id: 569,
            //name: "Ibrahim Taalab",
            //securityLVL: SecurityLVL.Developer,
            //salary: 55000m,
            //hireDate: new DateTime(2025, 3, 1),
            //gender: Gender.F
            //);

            //Console.WriteLine(emp);
            #endregion

            #region 2. Develop a Class to represent the Hiring Date Data
            //HiringDate date = new HiringDate(25,6,2021);
            //Console.WriteLine(date.TheDate());
            #endregion

            #region 3.Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            Employees03[] employees = new Employees03[3];
            employees[0] = new Employees03(1, "Mohammed", SecurityLVL03.DBA);
            employees[1] = new Employees03(2, "Ali", SecurityLVL03.Guest);
            employees[2] = new Employees03(3, "Khaled", SecurityLVL03.Security_Officer);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion




        }
    }
}
