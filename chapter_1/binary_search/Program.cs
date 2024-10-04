namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementando busca binária");
            Console.WriteLine();

            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

            int start = 0;
            int end = arr.Length - 1;
            int searchValue = 20;
            int attempts = 0;

            while(start <= end)
            {
                int middle = (start + end) / 2;
                int guess = arr[middle];

                if (guess == searchValue)
                {
                    Console.Write($"Valor {guess} encontrado na posição {middle}, tentativas: {attempts}");
                    Console.WriteLine();
                    return;
                }

                if(guess < searchValue)
                    start = middle + 1;
                else
                    end = middle - 1;

                attempts++;
            }

            Console.WriteLine("Elemento não encontrado");
        }
    }
}
