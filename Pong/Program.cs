using System;
using Pong.Models;

namespace Pong
{
class PingPong
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Ping-Pong Game!");
        
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            for (int i = 1; i <= userInput; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("ping-pong");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("ping");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("pong");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
}