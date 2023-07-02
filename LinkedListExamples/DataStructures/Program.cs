using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedListWithGenerics<int> linkedList = new SimpleLinkedListWithGenerics<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddFirst(0);
            linkedList.AddFirst(-1);
            linkedList.ReadAll();

            Console.WriteLine();
            linkedList.RemoveLast();
            linkedList.ReadAll();

            Console.WriteLine();
            linkedList.RemoveFirst();
            linkedList.ReadAll();
        }
    }
}
