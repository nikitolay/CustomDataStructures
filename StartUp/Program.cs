

namespace StartUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStructures.Stack<int> stack = new DataStructures.Stack<int>(-9);
           Stack<int> stack2 = new Stack<int>(9);
            stack2.Push(1);
            stack2.Clear();
            stack2.Push(6);
            stack2.TrimExcess();
            //stack.Push((int)Enumerable.Range(10,50));
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Push(5);
            for (int i = 0; i < stack2.Count; i++)
            {

            }
            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }
        }
    }
}