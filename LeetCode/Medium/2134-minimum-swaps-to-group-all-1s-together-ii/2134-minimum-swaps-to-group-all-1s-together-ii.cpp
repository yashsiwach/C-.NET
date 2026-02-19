
#include<bits/stdc++.h>
using namespace std;

class Solution {
public:
    int minSwaps(vector<int>& nums) {
        int n = nums.size();
        int total = 0;
        
        for(int x : nums) total += x;
        if(total <= 1) return 0;
        
        int curr = 0;
        
        for(int i = 0; i < total; i++)
            curr += nums[i % n];
        
        int maxOnes = curr;
        
        for(int i = total; i < n + total; i++) {
            curr += nums[i % n];
            curr -= nums[(i - total) % n];
            maxOnes = max(maxOnes, curr);
        }
        
        return total - maxOnes;
    }
};
```
