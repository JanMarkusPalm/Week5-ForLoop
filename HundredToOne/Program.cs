using System;

namespace HundredToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i > 1; i--)
            {
                Console.WriteLine($"{i - 1}");
            }
        }
    }
}
