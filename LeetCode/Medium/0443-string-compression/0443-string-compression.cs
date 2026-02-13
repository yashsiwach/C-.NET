public class Solution {
    public int Compress(char[] chars) {
        int count = 1;
        int i = 1;
        int n = chars.Length;
        List<char> data = new List<char>();
        
        data.Add(chars[0]);
        
        while (i < n) {
            if (chars[i] == chars[i - 1]) {
                count++;
            }
            else {
                if (count > 1) {
                    var nums = count.ToString().ToCharArray();
                    foreach (var ch in nums) {
                        data.Add(ch);
                    }
                }
                data.Add(chars[i]);
                count = 1;
            }
            i++;
        }

        if (count > 1) {
            var nums = count.ToString().ToCharArray();
            foreach (var ch in nums) {
                data.Add(ch);
            }
        }

        for (int j = 0; j < data.Count; j++) {
            chars[j] = data[j];
        }

        return data.Count;
    }
}