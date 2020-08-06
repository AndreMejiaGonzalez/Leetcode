public class Solution {
    public void NextPermutation(int[] nums) {
    int iPeak = nums.Length - 1;
    while(iPeak >= 1 && nums[iPeak] <= nums[iPeak - 1]) iPeak--;
    int i = iPeak, j = nums.Length - 1;
    if(iPeak > 0){
        int k = nums.Length - 1;
        while(k > iPeak && nums[k] <= nums[iPeak - 1]) k--;
        nums[iPeak - 1] = nums[iPeak - 1] ^ nums[k] ^ (nums[k] = nums[iPeak - 1]);
    }
    for(;i < j; i++, j--)
        nums[i] = nums[i] ^ nums[j] ^ (nums[j] = nums[i]);
}
}