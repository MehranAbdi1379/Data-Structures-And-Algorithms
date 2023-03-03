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
        CArray nums = new CArray(50);

        for (int i = 0; i < 50; i++)
        {
            nums.Insert(i);
        }

        nums.DisplayElements();
    }
}

public class CArray
{
    public int[] arr { get; set; }
    public int upper { get; set; }
    public int numElements { get; set; }

    public CArray(int size)
    {
        arr = new int[size];
        upper = size -1 ;
        numElements = 0;
    }

    public void Insert(int item)
    {
        arr[numElements] = item;
        numElements++;
    }

    public void DisplayElements()
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }

    public void Clear()
    {
        for (int i = 0; i < upper; i++)
        {
            arr[i] = 0;
        }
        numElements = 0;
    }
}
