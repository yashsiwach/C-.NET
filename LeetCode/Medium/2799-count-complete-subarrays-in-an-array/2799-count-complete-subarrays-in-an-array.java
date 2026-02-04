import java.util.*;

class Solution {
    public int countCompleteSubarrays(int[] nums) {
        HashSet<Integer> set = new HashSet<>();
        for(int x : nums) set.add(x);
        int k = set.size();

        HashMap<Integer,Integer> map = new HashMap<>();
        int l = 0, ans = 0;

        for(int r = 0; r < nums.length; r++) {
            map.put(nums[r], map.getOrDefault(nums[r], 0) + 1);

            while(map.size() == k) {
                ans += nums.length - r;
                map.put(nums[l], map.get(nums[l]) - 1);
                if(map.get(nums[l]) == 0)
                    map.remove(nums[l]);
                l++;
            }
        }
        return ans;
    }
}