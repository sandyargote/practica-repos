using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWindowsForm.Contracts
{
    internal interface ISerialize<T>
    {
        static abstract T Deserialize(string textSCV);
        static abstract string Serialize(T obj);
    }
}
