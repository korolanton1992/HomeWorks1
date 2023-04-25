// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");