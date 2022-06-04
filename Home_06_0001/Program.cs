//Напишите программу, которая будет создавать 
//копию заданного 2-мерного массива с помощью поэлементного копирования.

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} "); 
    }
    Console.WriteLine();
}

int[] SelectionSort(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void Selection_From_Sort(int[] arr)
{
    int size = arr.Length;
    int [] arr_from_sort = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr_from_sort [i] = arr[i];
        Console.Write($"{arr_from_sort[i]} ");
    }
    
}

int[] arr_1 = SelectionSort(10, -99, +100);
Print(arr_1);
Selection_From_Sort(arr_1);
