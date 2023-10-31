using System.Diagnostics;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catName = "Brian";
            int catLives = 13;
            char catBay = 'A';
            bool catGood = false;
            double catDeaths = 2.3;
            decimal catAverage = 14.23M;

            Console.WriteLine($"I once new a boy who had a cat named {catName}\n" +
                $"A cat in a hat he was not, for {catLives} did {catName} have\n" +
                $"At apartment {catBay} {catName} did stay\n" +
                $"Where any good intentions were vehemently {catGood} \n" +
                $"For {catName} was a bad cat for sure, {catDeaths} dead squirels per week \n" +
                $"With a penchant for the {catAverage} did favor...");
        }
    }
}
