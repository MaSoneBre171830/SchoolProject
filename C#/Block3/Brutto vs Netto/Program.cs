using System;

public class BruttoNetto
{

    public static void Main()
    {
    //Ihr Code
    start:

        char auswahl;
        double preis;
        char yesOrNo;

        do
        {
            Console.WriteLine("Netto(N) oder Brutto(B)? ");
            auswahl = Convert.ToChar(Console.ReadLine());


        } while (auswahl != 'b' && auswahl != 'B' && auswahl != 'n' && auswahl != 'N');

        Console.WriteLine("Preis: ");
        preis = Convert.ToDouble(Console.ReadLine());

        if (auswahl == 'b' || auswahl == 'B')
        {
            double netto = (preis / 120) * 100;
            double MWST = (preis / 120) * 20;

            Console.WriteLine($" Netto: {netto} \n +MWST: {MWST}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Brutto: " + (netto + MWST));
        }
        else
        {
            double brutto = (preis / 100) * 120;
            double MWST = (preis / 100) * 20;

            Console.WriteLine($" Netto: {brutto - MWST} \n +MWST: {MWST}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Brutto: " + (brutto));
        }

        do
        {
            Console.WriteLine("Wollen Sie nochmal(J/N): ");
            yesOrNo = Convert.ToChar(Console.ReadLine());
        } while (yesOrNo != 'J' && yesOrNo != 'j' && yesOrNo != 'n' && yesOrNo != 'N');

        if (yesOrNo == 'J' || yesOrNo == 'j')
        {
            goto start;
        }



    }
}