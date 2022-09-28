
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(numberA, numberB);

Console.WriteLine("max of " + numberA + " and " + numberB + " is " + max);
