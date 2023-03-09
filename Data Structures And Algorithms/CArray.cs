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
        Console.WriteLine();
    }

    public void Clear()
    {
        for (int i = 0; i < upper; i++)
        {
            arr[i] = 0;
        }
        numElements = 0;
    }

    public void BubbleSort()
    {
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    temp = arr[j+1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    public void SelectionSort()
    {
        for (int i = 0; i < arr.Length -1; i++)
        {
            int iMin = i;
            for (int j = i+1 ; j < arr.Length; j++)
            {
                if (arr[iMin] > arr[j])
                {
                    iMin = j;
                }
            }
            if (iMin != i)
            {
                int temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;
            }
        }
    }

    public void InsertionSort()
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int j = i;
            while(j > 0 && arr[j-1] > arr[j])
            {
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
                j--;
            }
        }
    }

    public void ShellSort()
    {
        int h = arr.Length / 2;
        int i = 0;
        int j = i + h;
        int main, secondary;
        while (h>0)
        {
            j = i + h;
            for (i = 0; i < arr.Length - h; i++)
            {
                main = i;
                secondary = j;
                while (main > -1 && arr[main] > arr[secondary] )
                {
                    int temp = arr[main];
                    arr[main] = arr[secondary];
                    arr[secondary] = temp;

                    secondary = main;
                    main = main - h;
                }
                j++;
            }
            h = h / 2;
            i = 0;
        }
    }
}
