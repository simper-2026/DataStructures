
using Stopwatch = System.Diagnostics.Stopwatch;

int count = 1;

Stopwatch sw = new Stopwatch();

// sw = Stopwatch.StartNew();
// StringConcatentation(count);
// sw.Stop();
// Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");
sw = Stopwatch.StartNew();
StringBuilder(count);
sw.Stop();
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");
sw = Stopwatch.StartNew();
ListAdd(count);
sw.Stop();
Console.WriteLine($"Time in ms: {sw.ElapsedMilliseconds}");

int[] listint = new int[100];

//function selectionSort(array, n)
void SelectionSort(int[] list, int cout){
//    for index from 0 to n - 1
//        minIndex = findMinIndex(array, index, n)
//        exchange(array, index, minIndex)
//
}

//function findMinIndex(array, start, n)
//    minIndex = start
//    for i from start + 1 to n - 1
//        if array[i] < array[minIndex]
//            minIndex = i
//    return minIndex
//
//function exchange(array, i, j)
//    temp = array[i]
//    array[i] = array[j]
//    array[j] = temp


void BubbleSort(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                // swap temp and arr[i]
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void StringConcatentation(int count)
{
    string result = "";

    for (int i = 0; i < count; i++)
    {
        result = result + ".";
    }
}

void StringBuilder(int count)
{
    var sb = new System.Text.StringBuilder();

    for (int i = 0; i < count; i++)
    {
        sb.Append(".");
    }

    string result = sb.ToString();
}

void ListAdd(int count)
{
    var list = new List<char>();

    for (int i = 0; i < count; i++)
    {
        list.Add('.');
    }
    string result = new string(list.ToArray());
}