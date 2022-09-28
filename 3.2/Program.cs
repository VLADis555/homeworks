
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numberC: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = Math.Max(numberA, Math.Max(numberB, numberC));

Console.WriteLine("max of (" + numberA + ", " + numberB + ", " + numberC + ") is " + max);
