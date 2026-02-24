public class Solution {
    public int LengthOfLastWord(string s) {
        string trimmed=s.Trim();
        string[] data=trimmed.Split(" ");
        return data[data.Length-1].Length;
    }
}