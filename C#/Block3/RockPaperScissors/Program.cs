using System;

class Aufgabe27
{
    static void Main()
    {
        Random random = new Random();
        int gewinneSpieler = 0;
        string ant = "";

        do
        {
            Console.WriteLine("Wählen Sie: Schere (S), Stein (R) oder Papier (P):");
            char wahlSpieler = char.ToUpper(Console.ReadKey().KeyChar);

            // Zufalls generierte Auswahl des Computergegners
            char[] optionen = { 'S', 'R', 'P' };
            char wahlComputer = optionen[random.Next(optionen.Length)];

            Console.WriteLine($"\nDer Computer hat {GetAuswahlName(wahlComputer)} gewählt.");

            // Überprüfung wer gewonnen hat
            if (wahlSpieler == wahlComputer)
            {
                Console.WriteLine("Unentschieden!");
            }
            else if ((wahlSpieler == 'S' && wahlComputer == 'P') ||
                     (wahlSpieler == 'R' && wahlComputer == 'S') ||
                     (wahlSpieler == 'P' && wahlComputer == 'R'))
            {
                Console.WriteLine("Sie haben gewonnen!");
                gewinneSpieler++;
            }
            else
            {
                Console.WriteLine("Der Computer hat gewonnen!");
            }

            // Ausgabe der Anzahl der Siege
            Console.WriteLine($"Anzahl der Siege: {gewinneSpieler}");

            // Wiederholung
            Console.WriteLine("Möchten Sie nochmal spielen? (J/N):");
            ant = Console.ReadLine();

        } while (ant == "J");
    }

    static string GetAuswahlName(char auswahl)
    {
        switch (auswahl)
        {
            case 'S':
                return "Schere";
            case 'R':
                return "Stein";
            case 'P':
                return "Papier";
            default:
                return "Unbekannt";
        }
    }
}
