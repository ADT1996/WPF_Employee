using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class FolkDal : Dal<Folk>
    {
        public override ICollection<Folk> All() => 
            entities.Folks.ToList();

        public override Folk Select(object id) => 
            entities.Folks.SingleOrDefault(n => n.Id == (int)id);
    }
}
