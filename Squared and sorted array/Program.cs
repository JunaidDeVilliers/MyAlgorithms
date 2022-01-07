class Program
{
    static void Main(string[] args)
    {
        int[] check = { -9, -7, -5, -3, -1, 0, 2, 4, 6, 8, 10 };
        int[] squared = SortedSquares(check);

        for (int i = 0; i < squared.Length; i++)
        {
            Console.WriteLine(squared[i]);
        }
    }

    public static int[] SortedSquares(int[] nums)
    {
        int[] output = new int[nums.Length];
        int left = 0;
        int right = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (Math.Abs(nums[left]) > nums[right])
            {
                output[i] = nums[left] * nums[left];
                left++;
            }
            else
            {
                output[i] = nums[right] * nums[right];
                right--;
            }
        }
        return output;
    }
}