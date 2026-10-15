using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWindowsForm.Contracts
{
    internal interface IFactory<T>
    {
        static abstract T Create();
        static abstract T Create(string textCsv);
    }
}
