using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWindowsForm.Contracts
{
    internal interface IDataStore<T>
    {
        IEnumerable<T> LoadAll();
        void SaveAll(IEnumerable<T> list);
    }
}
