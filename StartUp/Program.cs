﻿

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

            stack.AddLast(5);
            stack.AddLast(6);
            stack.AddLast(7);
            stack.AddLast(8);
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}