using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    abstract class Dal<T>
    {
        protected EMDBEntities entities = new EMDBEntities();

        abstract public ICollection<T> All();
        abstract public T Select(object id);
        public virtual void Update(T Object)
        {
            entities.Set(Object.GetType()).Attach(Object);
            entities.SaveChanges();
        }

        public virtual void Delete(T Object)
        {
            entities.Set(Object.GetType()).Remove(Object);
            entities.SaveChanges();
        }

        public virtual void Insert(T Object)
        {
            entities.Set(Object.GetType()).Add(Object);
            entities.SaveChanges();
        }
    }
}
