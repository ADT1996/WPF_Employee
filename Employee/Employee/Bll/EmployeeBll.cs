using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Dal;
using Employee.Model;

namespace Employee.Bll
{
    class EmployeeBll : Bll<Model.Employee>
    {
        public override ICollection<Model.Employee> All() => 
            new EmployeeDal().All();

        public override void Delete(Model.Employee Object) =>
            new EmployeeDal().Delete(Object);

        public override void Insert(Model.Employee Object) =>
            new EmployeeDal().Insert(Object);

        public override Model.Employee Select(object param) =>
            new EmployeeDal().Select(param);

        public override void Update(Model.Employee Object) =>
            new EmployeeDal().Update(Object);
    }
}
