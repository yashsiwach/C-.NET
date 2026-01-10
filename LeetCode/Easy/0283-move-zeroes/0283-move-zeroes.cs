public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        int j = 1;

        while (i < nums.Length && j < nums.Length) {
            while (i < nums.Length && nums[i] != 0) i++;

            if (j <= i) j = i + 1;

            while (j < nums.Length && nums[j] == 0) j++;

            if (i < nums.Length && j < nums.Length) {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}
