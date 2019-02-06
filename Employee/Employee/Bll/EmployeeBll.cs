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
        public override ICollection<Model.Employee> All() => new EmployeeDal().All();

        public override Model.Employee Select(object param) => new EmployeeDal().Select(param);

        public Model.Employee Select(string publicKey, string password) => 
            new EmployeeDal().Select(publicKey, password);
    }
}
