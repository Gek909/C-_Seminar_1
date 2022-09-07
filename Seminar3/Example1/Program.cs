int[] nums = new int[10] { 10, 45, 23, 45, 61, 45, 23, 63, 23, 78 };

int max = nums[0];

for (int i = 0; i < nums.Length; i++)
{
    if(nums[i]> max)
    {
        max = nums[i];
    }
}

Console.WriteLine(max);