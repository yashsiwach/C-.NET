public class Solution {
    public int ShortestSubarray(int[] nums, int k) {
        LinkedList<int> dq = new LinkedList<int>();
        int n = nums.Length;
//make the 
        long[] prefix = new long[n + 1];
        for (int i = 0; i < n; i++) {
            prefix[i + 1] = prefix[i] + nums[i];
        }

        int ans = int.MaxValue;

        for (int i = 0; i <= n; i++) {

            while (dq.Count > 0 && prefix[i] - prefix[dq.First.Value] >= k) {
                ans = Math.Min(ans, i - dq.First.Value);
                dq.RemoveFirst();
            }

            while (dq.Count > 0 && prefix[i] <= prefix[dq.Last.Value]) {
                dq.RemoveLast();
            }

            dq.AddLast(i);
        }

        return ans == int.MaxValue ? -1 : ans;
    }
}