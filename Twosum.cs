public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> numbers = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int answer = target - nums[i];
            
            if (numbers.ContainsKey(answer)) {
                return new int[] { numbers[answer], i };
            }
            
            numbers[nums[i]] = i;
        }
        
        return new int[] { };
    }
}
