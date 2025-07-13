using CSharp_Advanced.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Classes
{
    internal class Employees
    {
        #region 1. Design and implement a Class for the employees in a company:
        //prop
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLVL SecurityLVL { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }
        //Ctor
        public Employees(int id, string name, SecurityLVL securityLVL, decimal salary, DateTime hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityLVL = securityLVL;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        //override
        public override string ToString()
        {
            return $"""
                Employee Data is:
                Id : {Id}
                Name : {Name}
                SecurityLevel : {SecurityLVL}
                HireDate : {HireDate.ToString("d")}
                Gender : {Gender}
                Salary : {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}
                """;
        }
        #endregion
    }
}
