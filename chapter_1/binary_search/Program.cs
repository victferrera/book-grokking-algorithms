namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int low = 0;
            int high = arr.Length - 1;
            int target = 11;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arr[mid];

                if (guess == target)
                {
                    Console.WriteLine($"Objeto encontrado na posição {mid} do array");
                    return;
                }                   

                if (guess < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            Console.WriteLine("Elemento não encontrado");
        }
    }
}
