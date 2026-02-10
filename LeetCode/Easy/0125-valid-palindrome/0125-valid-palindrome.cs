public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb=new StringBuilder();
        foreach(var i in s){
            if(char.IsLetter(i)){
            sb.Append(char.ToLower(i));
            }
            else if(char.IsDigit(i)){
                sb.Append(i);
            }
        }
        string temp=sb.ToString();
         Console.WriteLine(temp);

        string rev=new string(temp.ToCharArray().Reverse().ToArray());
        Console.WriteLine(rev);
        return temp==rev;
    }
}