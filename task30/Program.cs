// 30
int x()
{
    int x = new Random().Next(0, 2);
    return x;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}

int[] array = { x(), x(), x(), x(), x(), x(), x(), x()};
PrintArray(array);

