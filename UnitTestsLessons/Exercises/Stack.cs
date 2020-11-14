using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsLessons.Exercises
{
    public class Stack<T>
    {
        private readonly IList<T> _list = new List<T>();

        public int Count => _list.Count;

        public void Push(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            _list.Add(obj);
        }

        public T Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException();

            int index = _list.Count - 1;
            
            var result = _list[index];
            _list.RemoveAt(index);

            return result;
        }

        public T Peek()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException();

            return _list[_list.Count - 1];
        }
    }
}
