using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class EmployeeDal : Dal<Model.Employee>
    {
        public override ICollection<Model.Employee> All() => 
            entities.Employees.ToList();

        public override Model.Employee Select(object id) =>
            entities.Employees.SingleOrDefault(n => n.PublicId.Equals(id));

        public virtual Model.Employee Select(string publicKey, string password) => 
            entities.Employees.SingleOrDefault(n => n.PublicId.Equals(publicKey) && n.Password.Equals(password));
    }
}
