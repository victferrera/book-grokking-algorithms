using System.Diagnostics;

namespace exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício para procurar determinado numero em um array");
            Console.WriteLine();

            int[] numbersArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int searchValue = 10;

            Console.WriteLine($"Numero a ser procurado: {searchValue}");

            int low = 0;
            int high = numbersArray.Length - 1;
            int attempts = 1;
            var sw = new Stopwatch();

            sw.Start();

            while(low <= high)
            {
                int middle = (low + high) / 2;
                int guess = numbersArray[middle];

                if(guess == searchValue)
                {
                    sw.Stop();
                    Console.WriteLine($"Numero encontrado na posição {middle}, tempo decorrido: {sw.Elapsed}, tentativas: {attempts}");
                    return;
                }

                if(guess < searchValue)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }

                attempts++;
            }

            sw.Stop();
            Console.WriteLine($"Numero não encontrado, tempo decorrido: {sw.Elapsed}, tentativas: {attempts}");
        }
    }
}
