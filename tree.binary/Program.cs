using System;

namespace tree.binary
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeBinary tree = new TreeBinary();

            tree.Add(20);
            tree.Add(11);
            tree.Add(212);
            tree.Add(12);
            tree.Add(11);
            tree.Add(-10);
            tree.Add(33);
            tree.Add(1);
            tree.Add(4);
            tree.Add(8);
            tree.Add(20);
            tree.Add(90);
            tree.Add(100);
            tree.Add(-200);

            tree.Print();

            Console.WriteLine("  ");
            Console.WriteLine("  ");

            tree.Print(Order.Desc);
        }
    }
}
