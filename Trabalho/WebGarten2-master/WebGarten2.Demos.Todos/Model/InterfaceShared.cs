using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    interface InterfaceShared<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T GetByName(string name);
        void Add(T td);
        void Remove(T pl); 
    }
}
