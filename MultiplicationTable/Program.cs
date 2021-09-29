using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");

            int NRsisestatud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The multiplication table for the number provided is as follows: ");

            for (int i=1; i < 11; i++)

            {
                
                Console.WriteLine($"{i} * {NRsisestatud} = {i*NRsisestatud}");
                
            }
        }
    }
}
