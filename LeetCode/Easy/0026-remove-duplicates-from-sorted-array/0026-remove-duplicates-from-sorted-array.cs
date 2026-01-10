public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i=0;
        int j=0;
        while(j<nums.Length){
            if(nums[i]==nums[j]){
                j++;
            }
            else{
                i++;
                int temp=nums[i];
                nums[i]=nums[j];
                nums[j]=temp;
                j++;
            }
        }
        return i+1;
    }
}