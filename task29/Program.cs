// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

//5 элементов  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//3 элемента  6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

int[] ZapolnimArr(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(0, 100);
    }
    return ar;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}


int[] array = new int[N];
array=ZapolnimArr(array);

//{ x(), x(), x(), x(), x(), x(), x(), x()};
PrintArray(array);