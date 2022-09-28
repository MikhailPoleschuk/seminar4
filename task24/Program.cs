// 24

Console.Clear();
Console.WriteLine("Введите A:");

int A = Convert.ToInt32(Console.ReadLine());
 int sum=0;
for (int i = 1; i <= A; i++)
    sum = sum + i;
Console.WriteLine($"Сумма равна {sum}");
