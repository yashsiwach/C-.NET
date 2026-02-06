class Solution {
    public int numberOfSubarrays(int[] nums, int k) {
        int[] freq = new int[nums.length + 1];
        freq[0] = 1;

        int oddCount = 0;
        int ans = 0;

        for (int num : nums) {
            if ((num & 1) == 1)
                oddCount++;

            if (oddCount >=k)
                ans += freq[oddCount - k];

            freq[oddCount]++;
        }
        return ans;
    }
}
