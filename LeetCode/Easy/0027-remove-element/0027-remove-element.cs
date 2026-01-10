public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i=0;
        int j=nums.Length-1;
        while(i<=j){
            while(nums[j]==val&&j>0)j--;
            if(i <= j &&nums[i]==val){
                int temp=nums[j];
                nums[j]=nums[i];
                nums[i]=temp;
                i++;j--;
            }
            else{
                i++;
            }
        }
        return j+1;
    }
}