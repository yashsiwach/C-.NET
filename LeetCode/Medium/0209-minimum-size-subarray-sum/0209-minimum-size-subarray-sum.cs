public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int mini=int.MaxValue;
        int sum=0;
        int n=nums.Length;
        int j=0;
        for(int i=0;i<n;i++){
            sum+=nums[i];
            while(sum>=target){
                mini=Math.Min(mini,i-j+1);
                sum-=nums[j];
                j++;
            }
        }
        return mini==int.MaxValue?0:mini;
    }
}