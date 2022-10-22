using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queuee<T>:IEnumerable<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private T[] items;
        public Queuee()
        {

        }
        public Queuee(int capacity)
        {
            items=new T[capacity];
        }
        public Queuee(IEnumerable<T> elements)
        {
            items = elements.ToArray();
            Count = items.Length;
        }

        public int Count { get; private set; }


        public void Clear()
        {
            items = new T[INITIAL_CAPACITY];
        }

        public bool Constains(T element)=>items.Contains(element);
        
        public void Enqueue(T element)
        {
            //TODO: check if element is first
            for (int i = Count ; i >= 1; i--)
            {
                items[i] = items[i - 1];
            }
            items[0]=element;
            Count++;

        }
        public T Dequeue()
        {
            T element=items[Count-1];
            //for (int i = 0; i < Count-1; i++)
            //{
            //    items[i] = items[i + 1];
            //}
            Count--;
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
