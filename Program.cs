using System;

namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            // ARRAYS MAKEN
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 2.50 };

            string[] artikelen =
            {
                "snoepje",
                "luxe broodje",
                "lunch menu",
                "koekje"
            };

            Formulier[] formulieren = new Formulier[2];

            // FORMULIEREN ARRAY VULLEN
            formulieren[0] = new Formulier()
            {
                Feedback = "prijzig maar lekker",
                Sterren = 5
            };

            formulieren[1] = new Formulier()
            {
                Feedback = "lunch menu was erg veel",
                Sterren = 3
            };

            // FOR LOOP: PRIJZEN + ARTIKELEN
            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artikelen[i]);
            }

            Console.WriteLine();

            // FOREACH: FORMULIEREN
            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
                Console.WriteLine(formulier.Sterren);
            }

            Console.ReadLine();
        }
    }
}


