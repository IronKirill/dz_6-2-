using Country1;
using Country2;
using Country3;

namespace dz_6_2_
{
    public class Program
    {
        static void Main(string[] args)
        {
            var capital1 = new Country1.Capital("Kyiv", 3000000);
            var capital2 = new Country2.Capital("Warsaw", 1865000);
            var capital3 = new Country3.Capital("Rome", 2760000);

            Console.WriteLine($"{capital1.Name}: " +
                $"Population {capital1.Population}");

            Console.WriteLine($"{capital2.Name}: " +
                $"Population {capital2.Population}");

            Console.WriteLine($"{capital3.Name}: " +
                $"Population {capital3.Population}");

            Console.WriteLine();

            int maxPopulation = Math.Max(capital1.Population, Math.Max(capital2.Population, 
                capital3.Population));

            if (capital1.Population == maxPopulation)
            {
                Console.WriteLine($"The capital with the largest population is " +
                    $"{capital1.Name} (Country1) with {capital1.Population} people.");
            }
            
            else if (capital2.Population == maxPopulation)
            {
                Console.WriteLine($"The capital with the largest population is " +
                    $"{capital2.Name} (Country2) with {capital2.Population} people.");
            }
            
            else
            {
                Console.WriteLine($"The capital with the largest population is " +
                    $"{capital3.Name} (Country3) with {capital3.Population} people.");
            }
        }
    }
}
