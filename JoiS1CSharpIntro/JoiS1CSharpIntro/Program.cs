using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiS1CSharpIntro 
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            var data = "123";

            System.Console.Write($"Hello World {data}\n");
            System.Console.Write("Hello World " + data + "\n");
            System.Console.Write(
                String.Format(
                    "Hello world {0}, {1}, {2}\n", data, "second string", "third string"
                    )
                );

            foreach (var arg in args) 
            {
                if (arg.Contains("erik"))
                {
                    Console.WriteLine("erik contained in arg " + arg);
                }
            }
        }
    }
}
