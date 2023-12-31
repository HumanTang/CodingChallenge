public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var match = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(match.ContainsKey(nums[i])){
                return [i, match[nums[i]]];
            }else{
                match[target - nums[i]] = i;
            }
        }
        return null;
    }
}