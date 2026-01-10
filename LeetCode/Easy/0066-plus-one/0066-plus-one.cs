public class Solution {
    public int[] PlusOne(int[] digits) {
        int n=digits.Length;
        if(digits[n-1]==9){
            int[] temp=new int[n];
            int[] temp1=new int[n+1];
            bool flag=true;
            for(int i=n-1;i>=0;i--){
                if(digits[i]+1==10){
                    temp[i]=0;
                }
                else{
                    temp[i]=digits[i]+1;
                    flag=false;
                }
                
            }
            if(flag){

                
                for(int i=1;i<=n;i++){
                    temp1[i]=temp[i-1];
                }
                temp1[0]=1;
            }
            else return temp;
            return temp1;
        }
        else {
            digits[n-1]++;
            return digits;
        }
    }
}