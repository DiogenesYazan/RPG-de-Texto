using System;

namespace RPG
{
    public class Dado
    {
        private static readonly Random random = new Random();

        public static bool JogarD20()
        {
            int resultado = random.Next(1, 21);
            Console.WriteLine($"Você jogou o dado e tirou {resultado}!");

            return resultado > 15;
        }
    }
}
