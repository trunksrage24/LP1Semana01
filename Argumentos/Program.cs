using System;

namespace Argumentos
{
    /// <summary>
    /// program to input multiple arguments and count them
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Arguments: " + args.Length);  
            Console.Write("Arguments Are: "); 
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + "\n");
            }
            Console.ReadLine();
        }
    }
}
