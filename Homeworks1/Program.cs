// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("b");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// System.Console.WriteLine("Большее число: " + a + ", меньшее число: " + b);
// else System.Console.WriteLine($"Большее число: {a}, меньшее число: {b}");

Console.WriteLine("Число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");