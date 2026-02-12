public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char,int>data=new();
        int flag=0;
        int ans=0;
        foreach(var i in s){
            if(data.ContainsKey(i))data[i]++;
            else data[i]=1;
        }
        foreach(var i in data){
            if(i.Value%2!=0)flag=1;
            ans+=(i.Value/2);
        }
        ans=ans*2;
        return flag==1?ans+1:ans;
       
    }
}