using CSharp_Advanced.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Classes
{
    internal class Employees03
    {
        #region 3. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
        //prop
        private int id;
        private string name;
        public SecurityLVL03 securityLVL03 { get; set; }
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
                else id = 123;
            }
        }
        public Employees03()
        {
            id = 0;
            name = "NoName";
            securityLVL03 = SecurityLVL03.Guest;
        }
        public Employees03(int id, string name, SecurityLVL03 securityLVL03)
        {
            this.id = id;
            this.name = name;
            this.securityLVL03 = securityLVL03;
        }

        public override string ToString()
        {
            return $"Employee Information: \n Id: {id} \n Name: {name}\n SecurtyLVL: {securityLVL03}";
        }
        #endregion
    }
}
