namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 13, 19, 24, 25, 31, 41 };
            int target = 13;

            int result = Search(arr, target);


            if (result == -1)
            {
                Console.WriteLine("The number was not found");
            }
            else 
            {
                Console.WriteLine("The number " + target + " was found at index " + result);
            }
        }


        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index = 0;

            while (left <= right)
            {
                int mid = (left + right)/2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                    index = right + 1;
                }
                else 
                {
                    left = mid + 1;
                    index = left;
                }

            }

            return -1;
        }
    }
}