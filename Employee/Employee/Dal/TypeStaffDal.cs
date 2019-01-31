using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class TypeStaffDal : Dal<TypeStaff>
    {
        public override ICollection<TypeStaff> All() => 
            entities.TypeStaffs.ToList();

        public override TypeStaff Select(object id) => 
            entities.TypeStaffs.SingleOrDefault(n => n.Id == (int)id);
    }
}
