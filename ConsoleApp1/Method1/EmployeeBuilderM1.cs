using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EmployeeBuilderM1
    {
        private EmployeeM1 employee { get; set; }

        public EmployeeBuilderM1()
        {
            employee = new EmployeeM1();
        }

        public EmployeeBuilderM1 SetFullName(string fullName)
        {
            var array = fullName.Split(' ');
            employee.FirstName = array[0];
            employee.LastName = array[1];
            return this;
        }

        public EmployeeBuilderM1 SetEmailAddress(string emailAddress)
        {
            employee.EmailAdress = emailAddress;
            return this;
        }

        public EmployeeBuilderM1 SetUserName(string userName)
        {
            employee.UserName = userName;
            return this;
        }

        public EmployeeM1 BuildEmployee()
        {
            return employee;
        }
    }
}
