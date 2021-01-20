using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetEnvironmentVariable("inputParameters"));
            Console.WriteLine(Environment.GetEnvironmentVariable("secretParameters"));
            Console.WriteLine(Environment.GetEnvironmentVariable("previousResult"));
            
            Environment.SetEnvironmentVariable("output", "{\"result\": {\"o1\": \"val28\"}}");
        }
    }
}
