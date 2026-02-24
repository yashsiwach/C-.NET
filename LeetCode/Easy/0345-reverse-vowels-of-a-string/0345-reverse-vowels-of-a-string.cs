public class Solution {
    public string ReverseVowels(string s) {
        StringBuilder sb=new StringBuilder(s);
        int n=s.Length;
        int i=0,j=n-1;
        while(i<j){
            while(i<j&&!"aeiouAEIOU".Contains(sb[i])){
                i++;
            }
            while(i<j&&!"aeiouAEIOU".Contains(sb[j])){
                j--;
            }
            char temp=sb[i];
            sb[i]=sb[j];
            sb[j]=temp;
            i++;
            j--;

        }
        return sb.ToString();
    }
}