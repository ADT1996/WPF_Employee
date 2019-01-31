using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class CityDal : Dal<City>
    {
        public override ICollection<City> All() => 
            entities.Cities.ToList();

        public override City Select(object id) => 
            entities.Cities.SingleOrDefault(n => n.Id == (int)id);
    }
}
