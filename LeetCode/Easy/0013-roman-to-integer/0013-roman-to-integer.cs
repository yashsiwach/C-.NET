public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> dict=new Dictionary<char,int>();
        dict['I']=1;
        dict['V']=5;
        dict['X']=10;
        dict['L']=50;
        dict['C']=100;
        dict['D']=500;
        dict['M']=1000;
        
        int ans=0;
        int n=s.Length;
    
        for(int i=0;i<n-1;i++){
            if(dict[s[i]]<dict[s[i+1]]){
                ans-=dict[s[i]];
                
            }
            else{
                ans+=dict[s[i]];
            }
        }
        ans+=dict[s[n-1]];
        return ans;
    }
}