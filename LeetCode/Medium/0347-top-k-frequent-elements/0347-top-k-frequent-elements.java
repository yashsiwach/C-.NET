class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        HashMap<Integer,Integer> tm=new HashMap<>();
        for(int x:nums){
            tm.put(x,tm.getOrDefault(x,0)+1);
        }
        List<Map.Entry<Integer,Integer>>list=new ArrayList<>(tm.entrySet());
        list.sort((a,b)->b.getValue()-a.getValue());
        int [] ans=new int[k];
        for(int i=0;i<k;i++){
            ans[i]=list.get(i).getKey();
        }
        return ans;
    }
}
