using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IController<T>
    {
        public List<T> GetAll();
        public T Get(int id);
        public void Add(T item);
        public void Update(T item);
        public void Delete(int id);
    }
}
