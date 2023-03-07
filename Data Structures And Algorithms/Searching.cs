public static class Searching
{
    public static int BinarySearching(this int[] nums, int input)
    {
        int compCount = 0;
        int right = nums.Length - 1;
        int left = 0;

        while (left <= right)
        {
            compCount++;
            int mid = (left + right) / 2;

            if (nums[mid] == input)
            {
                Console.WriteLine(compCount);
                return mid;
            }
            else if (input < nums[mid])
            {
                right = mid - 1;
            }
            else if (input > nums[mid])
            {
                left = mid + 1;
            }
        }
        Console.WriteLine(compCount);
        return -1;
    }
}

