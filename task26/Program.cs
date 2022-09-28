// 26
Console.Clear();
Console.WriteLine("Введите A:");

int A = Convert.ToInt32(Console.ReadLine());
// простое решение
// string str=Convert.ToString(A);
// Console.WriteLine($"длинна числа равна {str.Length}");

int count=1;
for (int newA=A;newA>10;newA/=10) count++;
Console.WriteLine($"длинна числа равна {count}");


