using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class CustomerDal : Dal<Customer>
    {
        public override ICollection<Customer> All() => 
            entities.Customers.ToList();

        public override Customer Select(object id) => 
            entities.Customers.SingleOrDefault(n => n.Id == (int)id);
    }
}
