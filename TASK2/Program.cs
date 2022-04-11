using System;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bal = 93;
            Console.WriteLine("Balınız");

            if (bal >= 91 && bal <= 100)
            {
                Console.WriteLine("A");
            }
            else if (bal >= 81 && bal <= 90)
            {
                Console.WriteLine("B");
            }
            else if (bal >= 71 && bal <= 80)
            {
                Console.WriteLine("C");
            }
            else if (bal >= 61 && bal <= 70)
            {
                Console.WriteLine("D");
            }
            else if (bal >= 51 && bal <= 60)
            {
                Console.WriteLine("E");
            }
            else if (bal >= 0 && bal <= 50)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Balınızı düzgün daxil edin");
            }
        }

    }
}
    
