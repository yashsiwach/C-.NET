class Solution {
    public int takeCharacters(String s, int k) {
        int n = s.length();
        int[] count = new int[3];
        
        for (char c : s.toCharArray()) {
            count[c - 'a']++;
        }
        
        if (count[0] < k || count[1] < k || count[2] < k)
            return -1;
        
        int maxKeep = 0;
        int left = 0;
        int[] window = new int[3];
        
        for (int right = 0; right < n; right++) {
            window[s.charAt(right) - 'a']++;
            
            while (window[0] > count[0] - k ||
                   window[1] > count[1] - k ||
                   window[2] > count[2] - k) {
                window[s.charAt(left) - 'a']--;
                left++;
            }
            
            maxKeep = Math.max(maxKeep, right - left + 1);
        }
        
        return n - maxKeep;
    }
}