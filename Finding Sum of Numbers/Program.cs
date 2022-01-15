public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] index = new int[2];

        for (int i = 0; i < numbers.Length; i++)
        {
            int temp = target - numbers[i];

            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (numbers[mid] == temp)
                {
                    index[0] = i + 1;
                    index[1] = mid +1;
                    return index;
                }
                else if (numbers[mid] > temp)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }
        return numbers;
    }
}