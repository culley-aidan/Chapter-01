using System;

namespace BurmaShave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Environment.NewLine dynamically loads the newline character
            Console.Write("You can drive{0}A mile A minute{0}But there is no{0}Future in it{0}BurmaShave", Environment.NewLine);
            // Calling Console.ReadLine() to keep the window open
            Console.ReadLine();
        }
    }
}
