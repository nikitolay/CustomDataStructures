

using DataStructures;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr=new int[4] {2,5,4,7 };
            List<int> list=new List<int>(arr);
            DataStructures.LinkedList<int>stack = new DataStructures.LinkedList<int>(list);
            Node<int> node = new Node<int>(55);
            Node<int> node2 = new Node<int>(525);
            stack.AddLast(5);
            stack.AddLast(node);
            stack.AddLast(6);
            stack.AddLast(7);
            stack.AddAfter(node,node2);
         //  stack.Clear();
           // Console.WriteLine(stack.Count);
            Console.WriteLine();
            Console.WriteLine();
            stack.ForEach(x => Console.WriteLine(x));

        }
    }
}