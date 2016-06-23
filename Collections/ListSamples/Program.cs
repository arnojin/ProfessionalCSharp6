using System.Collections.Generic;
using static System.Console;

namespace ListSamples
{
    class Program
    {
        static void Main()
        {
            var graham = new Racer(7, "Graham", "Hill", "UK", 14);
            var emerson = new Racer(13, "Emerson", "Fittipaldi", "Brazil", 14);
            var mario = new Racer(16, "Mario", "Andretti", "USA", 12);

            var racers = new List<Racer>(20) { graham, emerson, mario };

            racers.Add(new Racer(24, "Michael", "Schumacher", "Germany", 91));
            racers.Add(new Racer(27, "Mika", "Hakkinen", "Finland", 20));

            racers.AddRange(new Racer[] {
               new Racer(14, "Niki", "Lauda", "Austria", 25),
               new Racer(21, "Alain", "Prost", "France", 51)});

            // insert elements

            racers.Insert(3, new Racer(6, "Phil", "Hill", "USA", 3));

            // accessing elements

            WriteLine($"racers.Count = {racers.Count}");
            for (int i = 0; i < racers.Count; i++)
            {
                WriteLine(racers[i]);
            }
            WriteLine();
            foreach (var r in racers)
            {
                WriteLine(r);
            }
            WriteLine();
            // searching
            int index1 = racers.IndexOf(mario);
            int index2 = racers.FindIndex(new FindCountry("Finland").FindCountryPredicate);
            int index3 = racers.FindIndex(r => r.Country == "Finland");
            WriteLine($"index1 = {index1}, index2 = {index2}, index3 = {index3}");

            Racer racer = racers.Find(r => r.FirstName == "Niki");
            WriteLine($"{racer:A}");
            
            WriteLine();
            List<Racer> bigWinners = racers.FindAll(r => r.Wins > 20);
            foreach (Racer r in bigWinners)
            {
                WriteLine($"{r:A}");
            }

            WriteLine();


            // remove elements

            if (!racers.Remove(graham))
            {
                WriteLine("object not found in collection");
            }
            if (!racers.Remove(graham))
            {
                WriteLine("object not found in collection");
            }


            var racers2 = new List<Racer>(new Racer[] {
               new Racer(12, "Jochen", "Rindt", "Austria", 6),
               new Racer(22, "Ayrton", "Senna", "Brazil", 41) });
        }
    }
}
