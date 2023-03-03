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
        CArray nums = new CArray(10);
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            nums.Insert((int)(random.NextDouble() * 100)); 
        }

        Console.Write("Numbers before sorting: ");
        nums.DisplayElements();

        nums.BubbleSort();
        Console.Write("Numbers after Bubble Sorting: ");
        nums.DisplayElements();
    }
}

