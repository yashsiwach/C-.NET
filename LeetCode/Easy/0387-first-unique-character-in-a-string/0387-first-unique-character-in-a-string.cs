public class Solution {
    public int FirstUniqChar(string s) {
        int[] freq= new int[26];
        foreach(var i in s)freq[i-'a']++;
        for(int i=0;i<s.Length;i++){
            if(freq[s[i]-'a']==1)return i;
        }
        return -1;
        // for(int i=0;i<s.Length;i++){
        //     string temp=s.Substring(i+1);
        //     string temp2=s.Substring(0,i);
        //     if(!temp.Contains(s[i])&&!temp2.Contains(s[i]))return i;
        // }
        // return -1;
    }
}