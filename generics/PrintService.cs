using System;
using System.Collections.Generic;

namespace dot.generics
{
    public class PrintService
    {
        private List<int> _list = new List<int>();
        
        public void AddValue(int value)
        {
            _list.Add(value);
        }

        public int First()
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