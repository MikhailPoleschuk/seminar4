// 28
Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
int result=1;
for (int i=1;i<=N;i++) result=result * i;
Console.WriteLine($"Произведение равно {result}");
