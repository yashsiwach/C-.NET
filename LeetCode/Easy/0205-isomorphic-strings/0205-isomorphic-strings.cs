public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char>dict=new Dictionary<char,char>();
        Dictionary<char,char>dict2=new Dictionary<char,char>();

        for(int i=0;i<s.Length;i++){
            if(dict.ContainsKey(s[i])){
                if(dict[s[i]]!=t[i])return false;
            }
            else {
               
                dict[s[i]]=t[i];
               
            }
        }
         for(int i=0;i<s.Length;i++){
            if(dict2.ContainsKey(t[i])){
                if(dict2[t[i]]!=s[i])return false;
            }
            else {
               
                dict2[t[i]]=s[i];
               
            }
        }
        return true;
    }
}