using Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Dal
{
    class CompanyDal : Dal<Company>
    {
        public override ICollection<Company> All() => 
            entities.Companies.ToList();

        public override Company Select(object id) => 
            entities.Companies.SingleOrDefault(n => n.Id == (int)id);
    }
}
