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
        LinkedList<string> soldiers = new LinkedList<string>();
        soldiers.AddLast("Mehran");
        soldiers.AddLast("Milad");
        soldiers.AddLast("Ali");
        soldiers.AddLast("Taha");
        soldiers.AddLast("Mohammad");
        soldiers.AddLast("Reza");
        soldiers.AddLast("Alex");
        soldiers.AddLast("Mani");
        soldiers.AddLast("Phill");
        soldiers.AddLast("Luke");

        string[] soldiersArray = new string[soldiers.Count];

        LinkedListNode<string> soldier = soldiers.First;

        for (int i = 0; i < soldiers.Count; i++)
        {
            soldiersArray[i] = soldier.Value;
            soldier = soldier.Next;
        }
        
    }
}