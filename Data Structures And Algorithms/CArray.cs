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
        int iMin = 0 , temp = 0;
        for (int i = 0; i < arr.Length -1; i++)
        {
            iMin = i;
            for (int j = i+1 ; j < arr.Length; j++)
            {
                if (arr[iMin] > arr[j])
                {
                    iMin = j;
                }
            }
            if (iMin != i)
            {
                temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;
            }
        }
    }

    public void InsertionSort()
    {
        int j = 0 , temp = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            j = i;
            while(j > 0 && arr[j-1] > arr[j])
            {
                temp = arr[j];
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

    public void MergeSort()
    {
        int[] tempArray = new int[arr.Length];
        recMergeSort(tempArray, 0, arr.Length - 1);
    }

    public void recMergeSort(int[] tempArray, int left, int right)
    {
        if (left == right)
        {
            return;
        }
        else
        {
            int mid = (left + right) / 2;
            recMergeSort(tempArray, left, mid);
            recMergeSort(tempArray, mid+1 , right);
            Merge(tempArray, left, mid, right);
        }
    }

    public void Merge(int[] tempArray , int left, int mid , int right)
    {
        int i = left, j = mid+1 , counter = i;
        while (i<=mid && j<= right)
        {
            if (arr[i] <= arr[j])
            {
                tempArray[counter] = arr[i];
                i++;
                counter++;
            }
            else
            {
                tempArray[counter] = arr[j];
                counter++;
                j++;
            }
        }
        while (i<=mid)
        {
            tempArray[counter] = arr[i];
            counter++;
            i++;
        }
        while (j<=right)
        {
            tempArray[counter] = arr[j];
            counter++;
            j++;
        }
        for (int k = 0; k < (right-left+1); k++)
        {
            arr[k+left] = tempArray[k+left];
        }
    }
}
