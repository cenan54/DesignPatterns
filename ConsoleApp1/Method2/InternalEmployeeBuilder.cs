using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public class InternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEmailAddress(string emailAddress)
        {
            var array = emailAddress.Split('@');
            Employee.EmailAdress = array[0] + "@company.com.tr";
        }

        public override void SetFullName(string fullName)
        {
            var array = fullName.Split(new[] {' ','-','_'});
            Employee.FirstName = array[0];
            Employee.LastName = array[1];
        }

        public override void SetUserName(string userName)
        {
            Employee.UserName = userName;
        }
    }
}
