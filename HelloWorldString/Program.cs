using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "HelloWorld";
            for(int i =0; i < HelloWorld.Length; i++)
            {
                Console.WriteLine($"Kohal {i} on {HelloWorld[i]}");
            }
        }
    }
}
