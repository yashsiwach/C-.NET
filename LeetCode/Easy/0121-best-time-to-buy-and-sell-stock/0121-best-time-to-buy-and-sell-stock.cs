public class Solution {
    public int MaxProfit(int[] prices) {
        int maxi=0;
        int mini=int.MaxValue;
        int ans=0;
        for(int i=0;i<prices.Length;i++){
            mini=Math.Min(prices[i],mini);
            maxi=Math.Max(prices[i],mini);
            ans=Math.Max(maxi-mini,ans);
        }
        return ans;
    }
}