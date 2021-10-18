using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops: ");
            Console.ReadKey(true);

            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
            }

            char input;
            ConsoleKeyInfo readkeyinput = Console.ReadKey();
            input = readkeyinput.KeyChar;
        }
    }
}
