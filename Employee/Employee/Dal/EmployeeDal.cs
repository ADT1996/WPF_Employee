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

        public override void Insert (Model.Employee Object)
        {
            entities.Employees.Add(Object);
            entities.SaveChanges();
        }

        public override void Update(Model.Employee Object)
        {
            entities.Employees.Attach(Object);
            entities.SaveChanges();
        }
    }
}
