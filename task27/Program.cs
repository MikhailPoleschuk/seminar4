// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int newN = N;
while (newN >= 10) // обязательно больше или равно иначе при числе 10001 получим 11
{
    sum = sum + newN % 10;
    newN = newN / 10;
}
sum=sum+newN;
Console.WriteLine(sum);