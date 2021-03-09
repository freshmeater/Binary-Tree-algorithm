using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> a = new BinaryTree<int>();
            a.Add(5);
            a.Add(3);
            a.Add(4);
            a.Add(2);
            a.Add(8);
            a.Add(6);
            a.Add(7);
            a.Add(1);
            Console.WriteLine(a);
            Console.WriteLine(a);
            Console.WriteLine(a.Contains(9));
            Console.WriteLine(a.Contains(7));
            Console.WriteLine(a.Contains(6));
            Console.WriteLine(a);
        }
    }
}