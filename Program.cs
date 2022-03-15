using System;
using System.Collections.Generic;

namespace linkedlist14
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
           
            foreach (int ele in linkedList)
            {
                Console.WriteLine(ele);
            }
        }
    }
}