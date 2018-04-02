using System;
using System.Linq;

namespace Stack
{
    public class Stack<T>
    {
        private const int INITIAL_LENGTH = 10;
        private const int INCREMENT = 10;
        private int _index;
        private T[] _list;

        public Stack()
        {
            _list = new T[INITIAL_LENGTH];
        }

        public int Count { get { return _index; } }

        public void Push(T item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            if (_list.Count() == (_index+1)) IncrementStack();
            _list[_index++] = item;
        }

        public T Pop()
        {
            if (_index <= 0) throw new InvalidOperationException("Cannot pop an item off an empty Stack.");
            return _list[_index---1];
        }

        private void IncrementStack() 
        {
            int currentCount = _list.Count();
            T[] newList = new T[currentCount+INCREMENT];
            for(int i = 0; i < currentCount; i++)
                newList[i] = _list[i];
            _list = newList;
        }
    }
}
