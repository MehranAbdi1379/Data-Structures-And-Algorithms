using Data_Structures_And_Algorithms;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = new int[100];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i;
        }
    }

    public static int BinarySearch(int[] nums ,int input)
    {
        int right = nums.Length-1;
        int left = 0;

        while (left <= right)
        {
            int mid = (left+right)/2;

            if (nums[mid] == input)
            {
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
    }
}

