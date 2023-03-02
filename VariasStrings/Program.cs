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
        }
    }
}
