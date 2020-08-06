public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        var n = nums.Length;

        var globalClosest = int.MaxValue;
        var globalSum = 0;
        for (int i = 0; i < n; i++) {
            var left = i + 1;
            var right = n - 1;

            while (left < right) {
                var sum = nums[i] + nums[left] + nums[right];
                var localClosest = Math.Abs(sum - target);
                if (sum == target) {
                    return target;
                } else if (sum < target) {
                    left++;
                } else {
                    right--;
                }

                if (globalClosest > localClosest) {
                    globalClosest = localClosest;
                    globalSum = sum;
                }
            }

        }

        return globalSum;
    }
}