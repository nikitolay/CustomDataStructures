using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Stack<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private T[] items;


        public Stack()
        {
            items = new T[INITIAL_CAPACITY];
        }
        //TODO: Add more ctors



        public int Count { get; private set; }

        public void Push(T element)
        {
            if (items.Length == Count)
            {
                Resize();
            }
            items[Count++] = element;
        }

        public T Peek() => items[Count - 1];

        public bool Contains(T element) => items.Contains(element);

        public void Clear()
        {
            items = new T[INITIAL_CAPACITY];
        }

        public T[] ToArray()
        {
            T[] array = new T[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                array[i] = items[i];
            }
            return array;
        }
        public T Pop()
        {

            T element = items[Count - 1];
            Count--;
            if (Count <= items.Length / 4)
            {
                Shrink();
            }
            return element;
        }

        private void Shrink()
        {
            T[] copyItems = new T[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copyItems[i]=items[i];
            }
            items = copyItems;
        }

        private void Resize()
        {
            T[] copyItems = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                copyItems[i] = items[i];
            }
            items = copyItems;
            //second way
            //Array.Copy(items, copyItems, items.Length*2);
            //items=copyItems;
        }


    }
}
