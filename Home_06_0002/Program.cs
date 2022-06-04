//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} "); 
    }
    Console.WriteLine();
}

int[] SelectionSort(int M, int from, int to)
{
    int[] arr = new int[M];
    for (int i = 0; i < M; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void CountNum(int[] arr)
{
    int SumPlus = 0;
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] > 0) SumPlus++;
    }
    Console.WriteLine(SumPlus);

}


int[] arr_1 = SelectionSort(10, -99, +100);
Print(arr_1);
CountNum(arr_1);

