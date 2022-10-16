using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            AddFirstLogic(item);


        }
        public void AddFirst(T item)
        {
            Node<T> node = new Node<T>(item);
            AddFirstLogic(node);

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


            Node<T> currentNode = Head;

            AddBeforeLogic(node, newNode);

        }


        public void AddBefore(Node<T> node, T item)
        {

            Node<T> newNode = new Node<T>(item);

            AddBeforeLogic(node, newNode);
        }

        public void AddAfter(Node<T> node, T item)
        {

            Node<T> newNode = new Node<T>(item);

            AddAfterLogic(node, newNode);
        }

        public void AddAfter(Node<T> node, Node<T> newNode)
        {

            AddAfterLogic(node, newNode);
        }

        public void Remove(Node<T> node)
        {
            RemoveLogic(node);

        }
        public void Remove(T item)
        {
            Node<T> node = new Node<T>(item);
            RemoveLogic(node);

        }
        public void RemoveFirst()
        {
            //if first is null, throw new exception
            if (true)
            {

            }
            if (Head == Last)
            {
                Clear();
            }
            Head = Head.Next;
        }
        public void RemoveLast()
        {
            //if list is empty, or last is null, throw new exception
            if (true)
            {

            }
            if (Last == Head)
            {
                Clear();
                return;
            }
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Next == Last)
                {
                    Last = current;
                    current.Next = null;

                    return;
                }
                current = current.Next;
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
        private void AddFirstLogic(Node<T> node)
        {
            node.Next = Head;
            if (Head == null)
            {
                Last = node;
            }
            Head = node;
        }
        private void AddBeforeLogic(Node<T> node, Node<T> newNode)
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

        private void AddAfterLogic(Node<T> node, Node<T> newNode)
        {
            //TODO: Throw Exception
            if (!Contains(node))
            {
            }
            Node<T> currentNode = Head;

            while (currentNode != null)
            {
                //if the current is equal to ours element(node)
                if (currentNode.Value.Equals(node.Value))
                {
                    //of the new element's next is equal to the next of the current node
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                    return;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }

        }
        private void RemoveLogic(Node<T> node)
        {
            //TODO: Throw Exception
            if (!Contains(node))
            {
            }

            if (node == Head)
            {
                Head = Head.Next;
                return;
            }
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Next == node)
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }
                currentNode = currentNode.Next;
            }
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
