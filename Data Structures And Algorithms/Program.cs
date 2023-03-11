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
        CArray array = new CArray(6);
        array.Insert(8);
        array.Insert(15);
        array.Insert(7);
        array.Insert(2);
        array.Insert(17);
        array.Insert(25);
        //array.Insert(32);
        //array.Insert(9);
        //array.Insert(7);
        //array.Insert(18);

        array.HeapSort();

        array.DisplayElements();
    }
}