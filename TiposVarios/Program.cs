using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables for multiple ways to write "100"
            int Integer = 100;
            int Hexa = 0x64;
            int Binary = 0b0110_0100;
            
            //write in console those ways in a line each
            Console.Write(Integer + "\n");
            Console.Write(Hexa + "\n");
            Console.Write(Binary + "\n");
    
            //variable for multiple chars
            char SnowFlake = '\u2746';
            char Skull = '\u2620';
            char Communism = '\u262d';

            //translate char into string
            string SnowFlakeChar = Char.ToString(SnowFlake);
            string SkullChar = Char.ToString(Skull);
            string CommunismChar = Char.ToString(Communism);

            //write in console these new strings
            Console.Write(SnowFlake + "\n");
            Console.Write(Skull + "\n");
            Console.Write(Communism + "\n");
        }
    }
}
