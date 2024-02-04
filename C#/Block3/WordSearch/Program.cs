using System;

public class Aufgabe23
{

    public static void Main()
    {
        string input;
        string wort;
        string ant;

        // Schreiben Sie hier ihren Code.
        do
        {
            Console.WriteLine("Geben Sie den Text ein:");
            input = Console.ReadLine();

            Console.WriteLine("Geben Sie das zu suchende Wort ein:");
            wort = Console.ReadLine();



            int position = input.IndexOf(wort, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine($"{wort} steht auf der Position {position}");


            Console.WriteLine("Wollen Sie nochmal(J/N):");
            ant = Console.ReadLine();


        } while (ant == "J");

    }
}
