// https://leetcode.com/problems/two-sum

int[] nums = [2, 7, 11, 15];
int target = 9;

// int[] nums = [3, 2, 4];
// int target = 6;

// int[] nums = [3, 3];
// int target = 6;

int[] answer = TwoSum(nums, target);
Console.WriteLine($"[{answer[0]}, {answer[1]}]");


static int[] TwoSum(int[] nums, int target) 
{
    for (int r = nums.Length - 1; r >= 0; r--) {
        for (int i = 0; i < r; i++) {
            if (nums[i] + nums[r] == target)
                return [i, r];
        }
    }

    return [];
}
