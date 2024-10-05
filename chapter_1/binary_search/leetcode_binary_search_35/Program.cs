namespace leetcode_binary_search_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution lc = new();

            int res = lc.SearchInsert(new int[4] { 1, 3, 4, 5 }, 6);

            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int middle = low + (high - low) / 2;

                if (nums[middle] == target)
                    return middle;

                if (nums[middle] < target)
                    low = middle + 1;
                else
                    high = middle - 1;
            }

            return low;
        }
    }
}
