using DataStructures.SinglyLinkedList;

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr=new int[5] {2,5,4,7,8 };
            List<int> list=new List<int>(arr);
            DataStructures.Queue<int>queue = new DataStructures.Queue<int>(list);
            DataStructures.Stack<int>stack = new DataStructures.Stack<int>(list);
            queue.Dequeue();
            foreach (var item in queue)
            {

            Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(queue.Count);
            Console.WriteLine();
            foreach (var item in stack)
            {

                Console.WriteLine(item);
            }

        }
    }
}