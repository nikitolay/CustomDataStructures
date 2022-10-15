using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList()
        {

        }
        public LinkedList(IEnumerable<T> items)
        {
            T[] arr = items.ToArray();
            int arrCount = arr.Length;
            int index = 0;
            while (arrCount > 0)
            {
                Node<T> node = new Node<T>(arr[index++]);
                AddLast(node);
                arrCount--;
            }
        }
        public Node<T> Head { get; set; }

        public Node<T> Last { get; set; }


        public int Count
        {
            get
            {
                int count = 0;
                Node<T> node = Head;
                while (node!=null)
                {
                    count++;
                    node= node.Next;
                }
                return count;
            }
        }
    
        public void AddFirst(Node<T> itemNode)
        {
            itemNode.Next = Head;
            if (Head == null)
            {
                Last = itemNode;
            }

            Head = itemNode;

        }
        public void AddFirst(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = Head;
            if (Head == null)
            {
                Last = node;
            }

            Head = node;

        }
        public void AddLast(T item)
        {
            Node<T> node = new Node<T>(item);
            if (Last == null)
            {
                Last = node;
                Head = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }
        public void AddLast(Node<T> itemNode)
        {
            if (Last == null)
            {
                Last = itemNode;
                Head = itemNode;
            }
            else
            {
                Last.Next = itemNode;
                Last = itemNode;
            }
        }
        public void Clear()
        {
            Head = null;
            Last = null;
        }
        //public bool Contains(T item)
        //{

        //}
        public void ForEach(Action<T> action)
        {
            Node<T> node = Head;
            while (node!=null)
            {
                action(node.Value);
                node = node.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
