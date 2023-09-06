using System;
namespace Uppgift1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byter bakgrundsfärg till blå
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //Byter textfärg till vit
            Console.ForegroundColor = ConsoleColor.White;

            //Skriver ut ett errormeddelande
            Console.WriteLine(":(");
            Console.WriteLine("Your PC ran into a problem that it couldn't handle," +
            /*Ny rad*/ "\nand now it needs to restart.");

            //Stänger ner fönstret när en knapp trycks
            Console.ReadKey();

        }
    }

}
