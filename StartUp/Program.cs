using DataStructures.SinglyLinkedList;
using DataStructures;
using System.Collections.Generic;
namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr=new int[5] {2,5,4,7,8 };
           DataStructures.Queuee<int>queue = new DataStructures.Queuee<int>(arr);
           Queue<int>queue2 = new Queue<int>(arr);


            queue.Dequeue();
            queue.Dequeue();
            queue2.Dequeue();
            queue2.Dequeue();

            queue.Enqueue(115);
            queue2.Enqueue(115);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            


            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in queue2)
            {

                Console.WriteLine(item);
            }

        }
    }
}