
using Task2_LIFO;

    public class Stack<T> : IStack<T>
    {
        private int _margin;
        private T[] _array;
        private int _top = 0;

        
        //Constructor for adding numbers
        public Stack(int margin)
        {
            _margin = margin;
            _array = new T[margin];
        }
        //Constructor for adding strings
        public Stack(T[] array)
        {
            _array = array;
            _margin =array.Length;
        }

        public bool IsEmpty()
        {
            return _top == 0;
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }

            var temp = _array[_top];
            _array[_top] = default(T);
            _top--;
            return temp;
        }   

        public void Push(T parObject)
        {
            if (_array.Length == _margin - 1)
            {
                throw new IndexOutOfRangeException();
            }
                _top++;
                _array[_top] = parObject;
        }

        public int Size() { return _array.Length; }
    }

