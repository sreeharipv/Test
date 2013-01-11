using System;
using System.Collections.Generic;

using System.Text;

namespace TestUnit
{
    public interface ITest<T>
    {
        T Create(int a);
    }
}
