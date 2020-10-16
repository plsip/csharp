using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            int y = int.Parse(args[1]);

            Console.WriteLine($"Multiply {x} and {y} result = {Multiply(x, y)}");
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
