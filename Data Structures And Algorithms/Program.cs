using Data_Structures_And_Algorithms;
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
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10000; i++)
        {
            int number = Convert.ToInt32(random.NextDouble() * 10);
            if (number == 10)
            {
                numbers.Add(number-1);
            }
            else
            {
                numbers.Add(number);
            }
        }

        foreach (int item in numbers)
        {
            binarySearchTree.Insert(item);
        }

        Dictionary<int , int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < 10; i++)
        {
            dictionary.Add(i, 0);
        }

        foreach (int item in numbers)
        {
            int theCounter = dictionary[item];
            theCounter++;
            dictionary[item] = theCounter;    
        }

        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }

    }
}

public class Node
{
    public int Data{ get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public void DisplayNode()
    {
        Console.Write(Data + " ");
    }
}

public class BinarySearchTree
{
    public Node root;
    public int Count = 0;

    public BinarySearchTree()
    {
        root = null;
    }

    public Node Find(int item)
    {
        Node current = root;

        while (true)
        {
            if (current.Data == item)
            {
                return current;
            }
            else if (item<current.Data)
            {
                if (current.Left == null)
                {
                    return null;
                }
                else
                {
                    current = current.Left;
                }
            }
            else if (item > current.Data)
            {
                if (current.Right == null)
                {
                    return null;
                }
                else
                {
                    current = current.Right;
                }
            }
        }
    }

    public int FindMin()
    {
        Node current = root;
        while (current.Left != null)
        {
            current = current.Left;
        }

        return current.Data;
    }

    public int FindMax()
    {
        Node current = root;

        while (current.Right != null)
        {
            current = current.Right;
        }

        return current.Data;
    }

    public void InOrder(Node theRoot)
    {
        if (root != null)
        {
            if (theRoot.Left != null)
            {
                InOrder(theRoot.Left);
            }
            theRoot.DisplayNode();
            if (theRoot.Right != null)
            {
                InOrder(theRoot.Right);
            }
            
        }
    }

    public void PreOrder(Node theRoot)
    {
        if (root != null)
        {
            theRoot.DisplayNode();
            if (theRoot.Left != null)
            {
                PreOrder(theRoot.Left);
            }
            
            if (theRoot.Right != null)
            {
                PreOrder(theRoot.Right);
            }

        }
    }

    public void PostOrder(Node theRoot)
    {
        if (root != null)
        {
            if (theRoot.Left != null)
            {
                PostOrder(theRoot.Left);
            }
            
            if (theRoot.Right != null)
            {
                PostOrder(theRoot.Right);
            }
            theRoot.DisplayNode();
        }
    }

    public void Insert(int i)
    {
        Node newNode = new Node();
        newNode.Data = i;
        if (root == null)
        {
            root = newNode;
            Count++;
        }
        else
        {
            Node current = root;
            Node parent;
            while (true)
            {
                parent = current;
                if (i < current.Data)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        Count++;
                        break;
                    }
                    
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        Count++;
                        break;
                    }
                }
            }
        }
    }
}