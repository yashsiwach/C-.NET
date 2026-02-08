class Solution {
    public int maxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int n = customers.length;
        int base = 0;

        for (int i = 0; i < n; i++) {
            if (grumpy[i] == 0) {
                base += customers[i];
            }
        }

        int add = 0, maxAdd = 0;

        for (int i = 0; i < n; i++) {
            if (grumpy[i] == 1) {
                add += customers[i];
            }

            if (i >= minutes && grumpy[i - minutes] == 1) {
                add -= customers[i - minutes];
            }

            maxAdd = Math.max(maxAdd, add);
        }

        return base + maxAdd;
    }
}