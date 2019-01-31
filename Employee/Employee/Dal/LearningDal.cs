using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class LearningDal : Dal<Learning>
    {
        public override ICollection<Learning> All() => 
            entities.Learnings.ToList();

        public override Learning Select(object id) => 
            entities.Learnings.SingleOrDefault(n => n.Id == (int)id);
    }
}
