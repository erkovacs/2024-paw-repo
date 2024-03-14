using System;

namespace VineriSeminar1CSharpIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++) 
            {
                // Console.WriteLine($"Arg {i}={args[i]}");
                // Console.WriteLine("Arg " + i + "=" + args[i]);

                string arg = args[i];
                arg = 1.ToString();
                Console.WriteLine(arg);
            }

            foreach (var arg in args)
            {
                
            }
        }
    }
}
