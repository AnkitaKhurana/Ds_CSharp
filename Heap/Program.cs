using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Heap h = new Heap();
                int ans = 0;
                do
                {
                    Console.Clear();
                    h.Display();
                    Console.WriteLine();
                    Console.WriteLine("1. Add to heap");
                    Console.WriteLine("2. Pop from heap");
                    Console.WriteLine("3. Check Top Element");
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
                            h.AddToHeap(element);
                            break;
                        case 2:
                            h.DeleteMinElement();
                            break;
                        case 3:
                            Console.WriteLine(h.Top());
                            Console.ReadKey();
                            break;
                        default: break;
                    }
                } while (ans != -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

        }
    }
}
