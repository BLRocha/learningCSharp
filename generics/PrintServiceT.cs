using System;
using System.Collections.Generic;

namespace dot.generics
{
    public class PrintServiceT<T>
    {
        private List<T> _list = new List<T>();
        
        public void AddValue(T value)
        {
            _list.Add(value);
        }

        public T First()
        {
            return _list[0];
        }

        public void Print()
        {
            Console.Write("[");
            int _count = _list.Count - 1;
            for (int i = 0; i < _count; i++)
            {
                Console.Write($"{_list[i]} ,");
            }
            Console.WriteLine($"{_list[_count]}]");
            Console.WriteLine($"First: {First()}");
        }
    }
}