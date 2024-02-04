using System;

public class Aufgabe16
{

    public static void Main()
    {

        // Schreiben Sie hier Ihren Code
        long dec;
        string ant;

        do
        {
            string hex = "";

            Console.WriteLine("Dezimalzahl:");
            dec = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("    Dezimal: " + dec);

            //calculates decimal to hex
            while (dec > 0)
            {
               
                long temp = dec % 16;
                switch (temp)
                {
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break;
                    default:
                        hex += temp;
                        break;
                }



                dec /= 16;
            }

            // reverses th string
            char[] arr = hex.ToCharArray();
            Array.Reverse(arr);
            hex = new string(arr);

            Console.WriteLine("Hexadezimal: " + hex);

            Console.WriteLine("Wollen Sie nochmal(J/N):");
            ant = Console.ReadLine();

        } while (ant == "J" || ant == "j");
    }
}