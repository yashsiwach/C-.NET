import java.util.*;

class Solution {
    private int atMostK(int[] nums, int k) {
        if (k < 0) return 0;
        Map<Integer, Integer> mp = new HashMap<>();
        int l = 0, res = 0;

        for (int r = 0; r < nums.length; r++) {
            mp.put(nums[r], mp.getOrDefault(nums[r], 0) + 1);
            if (mp.get(nums[r]) == 1) k--;

            while (k < 0) {
                mp.put(nums[l], mp.get(nums[l]) - 1);
                if (mp.get(nums[l]) == 0) k++;
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }

    public int subarraysWithKDistinct(int[] nums, int k) {
        return atMostK(nums, k) - atMostK(nums, k - 1);
    }
}