using System.Diagnostics;

namespace binary_search_exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise ex = new Exercise();

            bool keepWorking = true;

            while(keepWorking)
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine();
                Console.WriteLine("1 - Procurar numero no array de 0 - 100");
                Console.WriteLine("2 - Procurar palavra no array fornecido");

                int option = Convert.ToInt16(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        // Desenvolver uma busca utilizando o binary search para procurar por um numero fornecido pelo usuário no array de 0 - 100.
                        // Pior dos casos seria log de 100 na base 2, que daria mais ou menos 7 tentativas
                        // Melhor dos casos seria o numero ser o meio do array, executando somente 1 vez, que é o caso do 50
                        ex.findNumber();
                        break;
                    case 2:
                        ex.findWord();
                        break;
                    default:
                        Console.WriteLine("Opção não é válida");
                        break;
                }
            }
        }
    }

    internal class Exercise
    {
        internal void findNumber()
        {
            Console.WriteLine("Digite um numero de 0 a 100");
            int search = Convert.ToInt16(Console.ReadLine());

            int[] numbersArray = new int[] {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
                41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
                61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
                71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
                81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                91, 92, 93, 94, 95, 96, 97, 98, 99, 100
            };

            Console.WriteLine($"Procurar o numero {search}...");

            int start = 0;
            int end = numbersArray.Length - 1;

            var sw = new Stopwatch();
            sw.Start();
            int attempts = 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;
                int guess = numbersArray[middle];

                if (guess == search)
                {
                    sw.Stop();
                    Console.WriteLine($"Numero encontrado na posição {middle}, tempo decorrido: {sw.Elapsed}, tentativas: {attempts}");
                    return;
                }

                if (guess <= search)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }

                attempts++;
            }

            sw.Stop();
            Console.WriteLine($"Elemento não encontrado, tempo decorrido: {sw.Elapsed}, tentativas: {attempts}");
        }

        internal void findWord()
        {
            Console.WriteLine("Digite as palavras");
            string[] wordsArray = Console.ReadLine().Split(',');

            Console.WriteLine("Digite a palavra a ser pesquisada");
            string word = Console.ReadLine();

            int start = 0;
            int end = wordsArray.Length - 1;

            var sw = new Stopwatch();

            sw.Start();

            while (start <= end)
            {
                int middle = (start + end) / 2;
                string guess = wordsArray[middle];

                // CompareTo verifica se o palpite está antes da palavra procurada, -1
                // Se está na mesma posição que a palavra procurada, 0
                // Ou se vem depois da palavra procurada, 1
                int res = guess.CompareTo(word);

                if (res == 0)
                {
                    sw.Stop();
                    Console.WriteLine($"Palavra encontrada na posição {middle}, Tempo decorrido: {sw.Elapsed}");
                    return;
                }

                if(res > 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
        }
    }
}
