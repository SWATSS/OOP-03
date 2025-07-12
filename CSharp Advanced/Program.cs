using CSharp_Advanced.Classes;
using CSharp_Advanced.Enums;

namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees(
    id: 569,
    name: "Ibrahim Taalab",
    securityLVL: SecurityLVL.Developer,
    salary: 55000m,
    hireDate: new DateTime(2025, 3, 1),
    gender: Gender.F
);

            Console.WriteLine(emp);
        }
    }
}
