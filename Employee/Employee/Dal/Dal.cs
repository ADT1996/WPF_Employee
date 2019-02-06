using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Dal
{
    class Dal<T>
    {
        protected EMDBEntities entities = new EMDBEntities();

        public virtual ICollection<T> All()
        {
            throw new Exception("Không thể truy vấn ở lớp Dal.\nHãy dùng ở các lớp con.");
        }
        public virtual T Select(object id)
        {
            throw new Exception("Không thể truy vấn ở lớp Dal.\nHãy dùng ở các lớp con.");
        }

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
