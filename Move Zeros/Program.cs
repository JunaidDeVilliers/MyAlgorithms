public class Solution {
    public void MoveZeroes(int[] nums) {
        int zeroCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[zeroCount] = nums[i];
                zeroCount++;
            }
        }

        for (int i = zeroCount; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}