using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Dal;

namespace Employee.Bll
{
    abstract class Bll<T>
    {
        abstract public ICollection<T> All();
        abstract public T Select(object param);

        public void Update(T Object) => new Dal<T>().Update(Object);
        public void Delete(T Object) => new Dal<T>().Delete(Object);
        public void Insert(T Object) => new Dal<T>().Insert(Object);
    }
}
