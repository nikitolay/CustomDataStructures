using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T>:IEnumerable<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Last { get; set; }

        public int Count { get; set; }


        public void AddFirst(Node<T> itemNode)
        {
  
            if (Head == null)
            {
                Head = itemNode;
                Last = itemNode;
            }
            else
            {
                itemNode.Next = Head;
                Head = itemNode;
            }
            Count++;
        }
        public void AddFirst(T item)
        {
            Node<T> node = new Node<T>(item);
            if (Head == null)
            {
                Head = node;
                Last = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }
        public void AddLast(T item)
        {
            Node<T> node = new Node<T>(item);
            if (Last==null)
            {
                Last = node;
                Head = node;
            }
            else
            {
                Last.Next = node;
                Last=node;
            }
            Count++;
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
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node=Head;
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
