
class Solution {
    public int lengthOfLongestSubstring(String s) {
        // In Java, we use HashSet for O(1) average lookup
        Set<Character> st = new HashSet<>();
        int l = 0, maxi = 0, n = s.length();

        for (int i = 0; i < n; i++) {
            char currentChar = s.charAt(i);

            // Equivalent to while(st.count(s[i]))
            while (st.contains(currentChar)) {
                st.remove(s.charAt(l));
                l++;
            }
            
            st.add(currentChar);
            maxi = Math.max(maxi, (i - l + 1));
        }
        
        return maxi;
    }
}