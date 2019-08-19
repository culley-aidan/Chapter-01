using System;

namespace Lyrics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Environment.NewLine dynamically loads the newline character
            Console.Write("Sweet emotion{0}Sweet emotion{0}Sweet emotion{0}Sweet emotion{0}You talk about things that nobody cares", Environment.NewLine);
            // Calling Console.ReadLine() to keep the window open
            Console.ReadLine();
        }
    }
}
