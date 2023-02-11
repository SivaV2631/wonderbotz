using System;
using Sys = System.Console;

namespace HelloWorld
{
    // Created with "Do not use top-level statements" ticked!!!!
    // So, I got all the top-level statements in the Program Class file with the Main() method.  I 

    internal class Program
    {
        static void Main(string[] args)
        {
            Demo();

            Sys.WriteLine("Different World!");

        }

        static void Demo()
        {
            System.Console.WriteLine("Hello, World!");
            Console.WriteLine("Another World!");
            int i = 10;
            Console.WriteLine("i = " + i.ToString());
            Console.WriteLine("i = " + i);
            i = 50;
            Console.WriteLine("i = {0}", i);
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"i = {i + 50}");
            Console.WriteLine($"i = {i.ToString() + 50.ToString()}");

            i = 100;
            Console.WriteLine("{0} {1} {2} {3}", i, i++, ++i, i);

            i = 100;
            Console.WriteLine($"{i} {i++} {++i} {i}");
        }
    }
}