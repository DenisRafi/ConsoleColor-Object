using System;

namespace Program
{
    class Color
    {
        static public void Run()
        {
            Console.Title = "By Denis Rafi";
            string input = "";
            ConsoleColor myColor = new ConsoleColor();
            myColor = ConsoleColor.Blue;
            input = Console.ReadLine();
            ColorWriteLine(myColor, input);
            Console.ReadKey();
        }
        static void ColorWriteLine(ConsoleColor theColor, string theMessage)
        {
            Console.ForegroundColor = theColor;
            Console.WriteLine(theMessage);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main()
        {
            Color.Run();

            Console.ReadKey();
        }
    }
}

