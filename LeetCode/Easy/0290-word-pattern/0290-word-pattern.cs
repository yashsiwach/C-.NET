public class Solution {
    public bool WordPattern(string p, string s) {
        Dictionary<char,string>dict=new Dictionary<char,string>();
        Dictionary<String,char>dict2=new Dictionary<String,char>();

        var t=s.Split(" ");
        if(t.Length!=p.Length)return false;
        for(int i=0;i<p.Length;i++){
            if(dict.ContainsKey(p[i])){
                if(dict[p[i]]!=t[i])return false;
            }
            else {
               
                dict[p[i]]=t[i];
               
            }
        }
          for(int i=0;i<p.Length;i++){
            if(dict2.ContainsKey(t[i])){
                if(dict2[t[i]]!=p[i])return false;
            }
            else {
               
                dict2[t[i]]=p[i];
               
            }
        }
        return true;
    }
}