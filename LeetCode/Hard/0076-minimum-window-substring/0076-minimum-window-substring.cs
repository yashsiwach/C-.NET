public class Solution {
    public string MinWindow(string s, string t) {
        string ans="";
        int i,j=0;
        int n=s.Length;
        int m=t.Length;
        Dictionary<char,int>dict=new Dictionary<char,int>();
        foreach( var ele in t){
            if(dict.ContainsKey(ele)){
                dict[ele]++;
            }
            else{
                dict[ele]=1;
            }
        }
        int req=m;
        int ansL=0;
        int len=int.MaxValue;
        for(i=0;i<n;i++){
            if(dict.ContainsKey(s[i])){
                dict[s[i]]--;
                if(dict[s[i]]>=0)req--;
            }
            while(req==0){
                if(i-j+1<len){
                    ansL=j;
                    len=i-j+1;
                }
                if(dict.ContainsKey(s[j])){
                    dict[s[j]]++;
                    if(dict[s[j]]>0)req++;
                }
                j++;
            }
        } 
        return len==int.MaxValue?"":s.Substring(ansL,len);
    }
}