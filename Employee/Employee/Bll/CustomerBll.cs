using Employee.Dal;
using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Bll
{
    class CustomerBll : Bll<Customer>
    {
        public override ICollection<Customer> All() => new CustomerDal().All();

        public override Customer Select(object param) => new CustomerDal().Select(param);
    }
}
