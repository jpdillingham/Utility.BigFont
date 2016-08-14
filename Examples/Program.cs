using System;

namespace Utility.BigFont.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Large))
                Console.WriteLine(s);

            Console.WriteLine("\n");

            foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Medium))
                Console.WriteLine(s);

            Console.WriteLine("\n");

            foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Small))
                Console.WriteLine(s);

            Console.WriteLine("\n");

            foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Large))
                Console.WriteLine(s);

            Console.WriteLine("\n");

            foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Medium))
                Console.WriteLine(s);

            Console.WriteLine("\n");

            foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Small))
                Console.WriteLine(s);

            Console.WriteLine("\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
