namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sl = new Solution();
            int[] res = sl.SelectionSort([10, 1, 2,0,15, 5, 3, 4, 6, 9, 7, 100, 200, 360, 456, 91]);

            foreach (var item in res)
            {
                Console.Write($"{item},");
            }
        }
    }

    internal class Solution
    {
        public int[] SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }

            return nums;
        }
    }
}
