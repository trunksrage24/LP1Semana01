using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string variables
            string Sentence = "This is a sentence";
            string VerbatimSentence = @"""This sentence is in quotation marks""";
            string FilePath = @"C:\Users\vitor\OneDrive - Ensino Lusófona\Desktop\fcul\LP1\LP1Semana01\TiposVarios\Program.cs";

            //write strings in console
            Console.Write(Sentence + "\n");
            Console.Write(VerbatimSentence + "\n");
            Console.Write(FilePath + "\n");

            //variables to concatenate
            int IntNumber = 5;
            float DecNumber = 3.1415f;

            //concatenate variables in screen
            Console.WriteLine("Concatenate with int: " + IntNumber + "\n");
            Console.WriteLine("Concatenate with float: " + DecNumber + "\n");

            //variables to interpolate
            int X = 75;
            int Y = 25;
            
            //interpolate variables in screen
            Console.WriteLine("valor de W é: " + (X + Y) + "\n");

            //write string.format()
            Console.Write(string.Format("Y é {1},X é {0}", Y, X) + "\n");

            //write directly on screen
            Console.WriteLine(@"""Verbatim with X = {0}""", X);
        }
    }
}
