import java.util.*;

public class Solution {
    public int[] maxSlidingWindow(int[] nums, int k) {
        TreeMap<Integer, Integer> map = new TreeMap<>();
        int n = nums.length;
        int[] ans = new int[n - k + 1];
        int l = 0, idx = 0;

        for (int r = 0; r < n; r++) {
            map.put(nums[r], map.getOrDefault(nums[r], 0) + 1);

            if (r - l + 1 == k) {
                ans[idx++] = map.lastKey();

                map.put(nums[l], map.get(nums[l]) - 1);
                if (map.get(nums[l]) == 0) map.remove(nums[l]);
                l++;
            }
        }
        return ans;
    }
}