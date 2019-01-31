using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class ForeignLanguageDal : Dal<ForeignLanguage>
    {
        public override ICollection<ForeignLanguage> All() => 
            entities.ForeignLanguages.ToList();

        public override ForeignLanguage Select(object id) => 
            entities.ForeignLanguages.SingleOrDefault(n => n.Id == (int)id);
    }
}
