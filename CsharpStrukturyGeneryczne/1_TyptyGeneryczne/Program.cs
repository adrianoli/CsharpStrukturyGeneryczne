using System;

namespace _1_TyptyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            WczytajDane(kolejka);
            WyswietlWynik(kolejka);

            Console.ReadKey();
        }

        private static void WyswietlWynik(KolejkaKolowa<double> kolejka)
        {
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty)
            {
                Console.WriteLine("\t\t" + kolejka.Czytaj());
            }
        }

        private static void WczytajDane(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }

                break;
            }
        }
    }
}
