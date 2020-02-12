using System;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var pokeDistance = int.Parse(Console.ReadLine());
            var pokeExhaust = int.Parse(Console.ReadLine());
            var pokePower2 = pokePower;
            var pokes = 0;

            while (pokePower2 >= pokeDistance)
            {
                pokePower2 -= pokeDistance;
                pokes++;
                if (pokePower % 2 == 0 && pokePower / 2 == pokePower2 && pokeExhaust != 0) pokePower2 /= pokeExhaust;
            }
            Console.WriteLine(pokePower2);
            Console.WriteLine(pokes);
        }
    }
}
