using System;

namespace TowerOfHanoi
{
    class Program
    {
        public void toh( int n , char from , char to , char aux)
        {
            if (n == 1)
            {
                Console.WriteLine("Disk 1 " + " From " + from + " to " + to);
                return;
            }
            toh(n - 1, from, aux, to);
            Console.WriteLine("Disk " + n + " From " + from + " to " + to);
            toh(n - 1, aux, to, from);
         }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.toh(3, 'A', 'C', 'B');
            Console.ReadKey();
        }
    }
}
