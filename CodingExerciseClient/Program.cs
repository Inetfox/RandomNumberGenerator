using Pde.CodingExercise.RandomNumberGenerator;
using System;

namespace CodingExerciseClient
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            
            numberGenerator.NumberGenerated += NumberGenerator_NumberGenerated;

            numberGenerator.Start();
            Console.ReadLine();
            numberGenerator.Stop();
        }

        private static void NumberGenerator_NumberGenerated(object sender, NumberGeneratedEventArgs e)
        {
            Console.WriteLine($"Number generated {e.Number}");
        }
    }
}
