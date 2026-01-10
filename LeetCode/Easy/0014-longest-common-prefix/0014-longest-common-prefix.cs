public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        string last=strs[strs.Length-1];
        string first=strs[0];
        int counter=0;
        for(int i=0;i<Math.Min(last.Length,first.Length);i++){
            if(first[i]!=last[i]){
                break;
            }
            counter++;
        }
        return first.Substring(0,counter);
    }
}