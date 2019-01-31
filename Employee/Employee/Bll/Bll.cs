using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Dal;
using Employee.Model;

namespace Employee.Bll
{
    abstract class Bll<T>
    {
        abstract public ICollection<T> All();
        abstract public T Select(object param);
        abstract public void Update(T Object);
        abstract public void Delete(T Object);
        abstract public void Insert(T Object);
    }
}
