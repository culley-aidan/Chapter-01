using System;

namespace BigLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // \t is an escape character for tab, Environment.NewLine dynamically loads the current OS' newline character
            // Console.Write doesn't put a newline character after every line automatically unlike Console.WriteLine which is useful for this project
            Console.Write("H\tH{0}H\tH{0}HHHHHHHHH{0}H\tH{0}H\tH", Environment.NewLine);
            // Calling Console.ReadLine() to keep the window open
            Console.ReadLine();
        }
    }
}