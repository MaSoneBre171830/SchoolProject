using System;

public class Aufgabe15
{

    public static void Main()
    {

        // Schreiben Sie hier Ihren Code
        long dec;
        string ant;

        do
        {
            string oct = "";

            Console.WriteLine("Dezimalzahl:");
            dec = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Dezimal: " + dec);

            //calculates decimal to octa
            while (dec > 0)
            {
                oct += dec % 8;
                dec /= 8;
            }

            // reverses th string
            char[] arr = oct.ToCharArray();
            Array.Reverse(arr);
            oct = new string(arr);

            Console.WriteLine("Oktal:   " + oct);

            Console.WriteLine("Wollen Sie nochmal(J/N):");
            ant = Console.ReadLine();

        } while (ant == "J" || ant == "j");
    }
}