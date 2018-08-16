using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            Console.WriteLine("Print In Order");
            bt.PrintInOrder();
            Console.WriteLine();
            Console.WriteLine("Print pre Order");
            bt.PrintPreOrder();
            Console.WriteLine();
            Console.WriteLine("Print post Order");
            bt.PrintPostOrder();
            Console.WriteLine("Print level Order");
            bt.PrintLevelOrder();
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
