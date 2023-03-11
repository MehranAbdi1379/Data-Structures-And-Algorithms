using Data_Structures_And_Algorithms;
using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        CArray array = new CArray(100);

        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            array.Insert(random.Next(1, 1000));
        }

        array.QuickSort();

        array.DisplayElements();
    }
}