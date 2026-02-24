using System.Collections.Generic;

public class Solution {
    public string RemoveDuplicateLetters(string s) {
        Stack<char> st = new Stack<char>();
        HashSet<char> set = new HashSet<char>();
        int[] last = new int[26];
        
        for(int i = 0; i < s.Length; i++)
            last[s[i] - 'a'] = i;

        for(int i = 0; i < s.Length; i++){
            char c = s[i];

            if(set.Contains(c)) continue;

            while(st.Count > 0 && st.Peek() > c && last[st.Peek() - 'a'] > i){
                set.Remove(st.Pop());
            }

            st.Push(c);
            set.Add(c);
        }

        char[] arr = st.ToArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}