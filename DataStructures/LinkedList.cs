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
                while (node != null)
                {
                    count++;
                    node = node.Next;
                }
                return count;
            }
        }

        public void AddFirst(Node<T> item)
        {
            item.Next = Head;
            if (Head == null)
            {
                Last = item;
            }

            Head = item;

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
        public void AddLast(Node<T> item)
        {
            if (Last == null)
            {
                Last = item;
                Head = item;
            }
            else
            {
                Last.Next = item;
                Last = item;
            }
        }

        public void AddBefore(Node<T> node, Node<T> newNode)
        {
            //TODO: Throw Exception
            if (!Contains(node))
            {
            }

            Node<T> currentNode = Head;

            //if our element(node) is the head
            if (node == Head)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                while (currentNode != null)
                {
                    //if the current next is equal to ours element(node)
                    if (currentNode.Next.Value.Equals(node.Value))
                    {

                        currentNode.Next = newNode;
                        newNode.Next = node;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                }

            }



        }





        public void Clear()
        {
            Head = null;
            Last = null;
        }



        public bool Contains(T item)
        {
            Node<T> node = Head;

            return ContainsLogic(ref node);
        }

        public bool Contains(Node<T> item)
        {
            return ContainsLogic(ref item);
        }



        public void ForEach(Action<T> action)
        {
            Node<T> node = Head;
            while (node != null)
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


        private static bool ContainsLogic(ref Node<T> item)
        {
            while (item != null)
            {
                if (item.Value.Equals(item))
                {
                    return true;
                }
                item = item.Next;
            }
            return false;
        }
    }
}
