using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine("Välj ett tal");
                tal[i] = int.Parse(Console.ReadLine());
            }
            int sum = tal[0] + tal[1] + tal[2];

            Console.WriteLine("summan av dina tal är " + sum);

        }
    }
}