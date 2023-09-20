using linkedlist;
using System;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode<int> l1 = new ListNode<int>();
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);

            Console.WriteLine(l1.Contains(3));

            Console.ReadKey();
        }
    }
}