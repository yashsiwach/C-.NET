public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxi=0;
        int j=0;
        int n=s.Length;
        Dictionary<char,int>freq=new();
        for(int i=0;i<n;i++){
            while(freq.ContainsKey(s[i])){
                freq.Remove(s[j]);
                j++;
            }
            freq[s[i]]=1;
            maxi=Math.Max(maxi,i-j+1);   
        }
        return maxi;
    }
}