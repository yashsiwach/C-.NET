class Solution {

    boolean can(int[] piles, int h, int k) {
        long hours = 0;
        for (int x : piles) {
            hours += (x + k - 1) / k;
        }
        return hours <= h;
    }

    public int minEatingSpeed(int[] piles, int h) {
        int l = 1, r = 0;
        for (int x : piles) r = Math.max(r, x);

        int ans = r;

        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (can(piles, h, mid)) {
                ans = mid;
                r = mid - 1;
            } else {
                l = mid + 1;
            }
        }
        return ans;
    }
}
