using System;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyList<int> ll = new MyList<int>();
                int ans = 0;
                do
                {
                    Console.Clear();
                    ll.Display();
                    Console.WriteLine();
                    Console.WriteLine("1. Add to Queue");
                    Console.WriteLine("2. Delete from Queue");
                    Console.WriteLine("3. Add to Stack");
                    Console.WriteLine("4. Delete from Stack");
                    Console.WriteLine("5. Display LL");
                    Console.WriteLine("6. Reverse LL");
                    Console.WriteLine("7. Reverse k elements of LL");
                    if (!int.TryParse(Console.ReadLine(), out ans))
                    {
                        throw new Exception("Only Int Allowed");
                    }
                    int element;
                    switch (ans)
                    {
                        case 1:
                            Console.WriteLine("Enter Element");
                            if (!int.TryParse(Console.ReadLine(), out element))
                            {
                                throw new Exception("Only Int Allowed");
                            }
                            ll.Add(element);
                            ll.Display();
                            break;
                        case 2:
                            ll.Delete();
                            ll.Display();
                            break;
                        case 3:
                            Console.WriteLine("Enter Element");
                            if (!int.TryParse(Console.ReadLine(), out element))
                            {
                                throw new Exception("Only Int Allowed");
                            }
                            ll.Push(element);
                            ll.Display();
                            break;
                        case 4:
                            ll.Pop();
                            ll.Display();
                            break;
                        case 5:
                            ll.Display();
                            break;
                        case 6:
                            ll.Reverse();
                            ll.Display();
                            break;
                        case 7:
                            if (!int.TryParse(Console.ReadLine(), out int k))
                            {
                                throw new Exception("Only Int Allowed");
                            }
                            if (k > ll.Length())
                            {
                                throw new Exception("K cannot be greater than List size " + ll.Length());
                            }
                            ll.Reverse(k);
                            ll.Display();
                            break;
                        default: break;
                    }
                } while (ans != -1);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
