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
            HiringDate date = new HiringDate(25,6,2021);
            Console.WriteLine(date.TheDate());
            #endregion
        }
    }
}
