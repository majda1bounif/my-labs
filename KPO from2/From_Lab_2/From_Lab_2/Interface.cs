using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Lab_2
{    

    interface IStack<T> : IEnumerable<T>// Stack interface
    {

        void Push(T value);
        T Peek();
        T Pop();
        void Clear();

    }
}
