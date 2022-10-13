

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStructures.Stack<int> stack = new DataStructures.Stack<int>();
           Stack<int> stack2 = new Stack<int>();
            stack.Pop();
            stack2.Push(6);
            stack2.TrimExcess();
            //stack.Push((int)Enumerable.Range(10,50));
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Push(5);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack[2]);
            Console.WriteLine();
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Length);
        }
    }
}