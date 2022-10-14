

using DataStructures;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataStructures.LinkedList<int>stack = new DataStructures.LinkedList<int>();
            stack.AddFirst(5);
            stack.AddFirst(6);
            stack.AddFirst(7);
            stack.AddFirst(8);
            Node<int> node=stack.Head;
            while (node!=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}