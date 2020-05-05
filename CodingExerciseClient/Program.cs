using Pde.CodingExercise.RandomNumberGenerator;
using System;

namespace CodingExerciseClient
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();

            Console.ReadLine();
            numberGenerator.NumberGenerated += NumberGenerator_NumberGenerated;

            Console.ReadLine();
        }

        private static void NumberGenerator_NumberGenerated(object sender, NumberGeneratedEventArgs e)
        {
            Console.WriteLine($"Number generated {e.Number}");
        }
    }
}
