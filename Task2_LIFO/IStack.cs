using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_LIFO
{
    public interface IStack<T>
    {
        int Size();
        T Pop();
        void Push(T e);
        bool IsEmpty();
    }
}
