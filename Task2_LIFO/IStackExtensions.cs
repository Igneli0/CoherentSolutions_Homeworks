using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_LIFO
{
    public static class IStackExtensions
    {
        public static Stack<T> Reverse<T>(this IStack<T> stack)
        {
            Stack<T> _tempStack = new Stack<T>(stack.Size());

            while (!stack.IsEmpty())
            {
                _tempStack.Push(stack.Pop());
            }

            return _tempStack;
        }
    }
}
